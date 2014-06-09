using AndyWeb.Library;
using AndyWeb.Library.Utilities;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AndyWeb.DataLoader
{
    internal class Program
    {
        private static IEnumerable<CsvType> CsvParseFile<CsvType>(string ctaDataFile, CsvClassMap classMap)
        {
            using (TextReader textReader = File.OpenText(ctaDataFile))
            {
                var csv = new CsvReader(textReader);
                csv.Configuration.RegisterClassMap(classMap);
                csv.Configuration.WillThrowOnMissingField = false;
                csv.Configuration.TrimFields = true;

                var records = csv.GetRecords<CsvType>();

                return records.ToList();
            }
        }

        private static void Main(string[] args)
        {
            var ctaDataFiles = Directory.GetFiles(@"C:\Projects\CTAData");

            foreach (var ctaDataFile in ctaDataFiles)
            {
                if (!ctaDataFile.EndsWith(".txt"))
                {
                    continue;
                }

                var ctaDataFileName = new FileInfo(ctaDataFile).Name;

                switch (ctaDataFileName)
                {
                    case "agency.txt":
                        var agencyValues = CsvParseFile<Agency>(ctaDataFile, new AgencyClassMap());
                        DbUtilities.BulkInsert<CTADataDbContext, Agency>(agencyValues);
                        break;

                    case "calendar.txt":
                        var calendarValues = CsvParseFile<Calendar>(ctaDataFile, new CalendarClassMap());
                        DbUtilities.BulkInsert<CTADataDbContext, Calendar>(calendarValues);
                        break;

                    case "calendar_dates.txt":
                        var calendarDatesValues = CsvParseFile<CalendarDate>(ctaDataFile, new CalendarDatesClassMap());
                        DbUtilities.BulkInsert<CTADataDbContext, CalendarDate>(calendarDatesValues);
                        break;

                    case "frequencies.txt":
                        var frequenciesValues = CsvParseFile<Frequency>(ctaDataFile, new FrequenciesClassMap());
                        DbUtilities.BulkInsert<CTADataDbContext, Frequency>(frequenciesValues);
                        break;

                    case "routes.txt":
                        var routesValues = CsvParseFile<Route>(ctaDataFile, new RoutesClassMap());
                        DbUtilities.BulkInsert<CTADataDbContext, Route>(routesValues);
                        break;

                    case "shapes.txt":
                        var shapesValues = CsvParseFile<Shape>(ctaDataFile, new ShapesClassMap());
                        DbUtilities.BulkInsert<CTADataDbContext, Shape>(shapesValues);
                        break;

                    case "stop_times.txt":
                        var stopTimesValues = CsvParseFile<StopTime>(ctaDataFile, new StopTimesClassMap());
                        DbUtilities.BulkInsert<CTADataDbContext, StopTime>(stopTimesValues);
                        break;

                    case "stops.txt":
                        var stopsValues = CsvParseFile<Stop>(ctaDataFile, new StopsClassMap());
                        DbUtilities.BulkInsert<CTADataDbContext, Stop>(stopsValues);
                        break;

                    case "transfers.txt":
                        var transfersvalues = CsvParseFile<Transfer>(ctaDataFile, new TransfersClassMap());
                        DbUtilities.BulkInsert<CTADataDbContext, Transfer>(transfersvalues);
                        break;

                    case "trips.txt":
                        var tripsvalues = CsvParseFile<Trip>(ctaDataFile, new TripsClassMap());
                        DbUtilities.BulkInsert<CTADataDbContext, Trip>(tripsvalues);
                        break;

                    default:
                        continue;

                }
            }
        }
    }
}