using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyWeb.DataLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctaDataFiles = Directory.GetFiles(@"C:\Projects\CTAData");

            foreach(var ctaDataFile in ctaDataFiles)
            {
                if(!ctaDataFile.EndsWith(".txt"))
                {
                    continue;
                }

                var ctaDataFileName = new FileInfo(ctaDataFile).Name;

                switch(ctaDataFileName)
                {
                    case "agency.txt":
                        var agencyValues = CsvParseFile<Agency>(ctaDataFile, new AgencyClassMap());
                        break;
                    case "calendar.txt":
                        var calendarValues = CsvParseFile<Calendar>(ctaDataFile, new CalendarClassMap());
                        break;
                    //case "calendar_dates.txt":
                    //    var calendarDatesValues = CsvParseFile<CalendarDates>(ctaDataFile);
                    //    break;
                    //case "frequencies.txt":
                    //    var frequenciesValues = CsvParseFile<Frequencies>(ctaDataFile);
                    //    break;
                    //case "routes.txt":
                    //    var routesValues = CsvParseFile<Routes>(ctaDataFile);
                    //    break;
                    //case "shapes.txt":
                    //    var shapesValues = CsvParseFile<Shapes>(ctaDataFile);
                    //    break;
                    //case "stop_times.txt":
                    //    var stopTimesValues = CsvParseFile<StopTimes>(ctaDataFile);
                    //    break;
                    //case "stops.txt":
                    //    var stopsValues = CsvParseFile<Stops>(ctaDataFile);
                    //    break;
                    //case "transfers.txt":
                    //    var transfersValues = CsvParseFile<Transfers>(ctaDataFile);
                    //    break;
                    //case "trips.txt":
                    //    var tripsValues = CsvParseFile<Trips>(ctaDataFile);
                    //    break;
                    default:
                        continue;
                }

            }
        }

        private static IEnumerable<CsvType> CsvParseFile<CsvType>(string ctaDataFile, CsvClassMap classMap)
        {
            using (TextReader textReader = File.OpenText(ctaDataFile))
            {
                var csv = new CsvReader(textReader);
                csv.Configuration.RegisterClassMap(classMap);

                var records = csv.GetRecords<CsvType>();

                return records.ToList();
            }
        }
    }
}