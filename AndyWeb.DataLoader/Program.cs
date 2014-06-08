﻿using CsvHelper;
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
                        break;

                    case "calendar.txt":
                        var calendarValues = CsvParseFile<Calendar>(ctaDataFile, new CalendarClassMap());
                        break;

                    case "calendar_dates.txt":
                        var calendarDatesValues = CsvParseFile<CalendarDates>(ctaDataFile, new CalendarDatesClassMap());
                        break;

                    case "frequencies.txt":
                        var frequenciesValues = CsvParseFile<Frequencies>(ctaDataFile, new FrequenciesClassMap());
                        break;

                    case "routes.txt":
                        var routesValues = CsvParseFile<Routes>(ctaDataFile, new RoutesClassMap());
                        break;

                    case "shapes.txt":
                        var shapesValues = CsvParseFile<Shapes>(ctaDataFile, new ShapesClassMap());
                        break;

                    case "stop_times.txt":
                        var stopTimesValues = CsvParseFile<StopTimes>(ctaDataFile, new StopTimesClassMap());
                        break;

                    case "stops.txt":
                        var stopsValues = CsvParseFile<Stops>(ctaDataFile, new StopsClassMap());
                        break;

                    case "transfers.txt":
                        var transfersvalues = CsvParseFile<Transfers>(ctaDataFile, new TransfersClassMap());
                        break;

                    case "trips.txt":
                        var tripsvalues = CsvParseFile<Trips>(ctaDataFile, new TripsClassMap());
                        break;

                    default:
                        continue;
                }
            }
        }
    }
}