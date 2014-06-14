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
                        var agencyValues = CsvParseFile<Agency>(ctaDataFile, new AgencyClassMap()) as List<Agency>;
                        DbUtilities.BulkInsertAndThrowaway<CTADataDbContext, Agency>(agencyValues);
                        agencyValues = null;
                        break;

                    case "calendar.txt":
                        var calendarValues = CsvParseFile<Calendar>(ctaDataFile, new CalendarClassMap()) as List<Calendar>;
                        DbUtilities.BulkInsertAndThrowaway<CTADataDbContext, Calendar>(calendarValues);
                        calendarValues = null;
                        break;

                    case "calendar_dates.txt":
                        var calendarDatesValues = CsvParseFile<CalendarDate>(ctaDataFile, new CalendarDatesClassMap()) as List<CalendarDate>;
                        DbUtilities.BulkInsertAndThrowaway<CTADataDbContext, CalendarDate>(calendarDatesValues);
                        calendarDatesValues = null;
                        break;

                    case "frequencies.txt":
                        var frequenciesValues = CsvParseFile<Frequency>(ctaDataFile, new FrequenciesClassMap()) as List<Frequency>;
                        DbUtilities.BulkInsertAndThrowaway<CTADataDbContext, Frequency>(frequenciesValues);
                        frequenciesValues = null;
                        break;

                    case "routes.txt":
                        var routesValues = CsvParseFile<Route>(ctaDataFile, new RoutesClassMap()) as List<Route>;
                        DbUtilities.BulkInsertAndThrowaway<CTADataDbContext, Route>(routesValues);
                        routesValues = null;
                        break;

                    case "shapes.txt":
                        var shapesValues = CsvParseFile<Shape>(ctaDataFile, new ShapesClassMap()) as List<Shape>;
                        DbUtilities.BulkInsertAndThrowaway<CTADataDbContext, Shape>(shapesValues);
                        shapesValues = null;
                        break;

                    case "stop_times.txt":
                        var stopTimesValues = CsvParseFile<StopTime>(ctaDataFile, new StopTimesClassMap()) as List<StopTime>;
                        DbUtilities.BulkInsertAndThrowaway<CTADataDbContext, StopTime>(stopTimesValues);
                        stopTimesValues = null;
                        break;

                    case "stops.txt":
                        var stopsValues = CsvParseFile<Stop>(ctaDataFile, new StopsClassMap()) as List<Stop>;
                        DbUtilities.BulkInsertAndThrowaway<CTADataDbContext, Stop>(stopsValues);
                        stopsValues = null;
                        break;

                    case "transfers.txt":
                        var transfersvalues = CsvParseFile<Transfer>(ctaDataFile, new TransfersClassMap()) as List<Transfer>;
                        DbUtilities.BulkInsertAndThrowaway<CTADataDbContext, Transfer>(transfersvalues);
                        transfersvalues = null;
                        break;

                    case "trips.txt":
                        var tripsvalues = CsvParseFile<Trip>(ctaDataFile, new TripsClassMap()) as List<Trip>;
                        DbUtilities.BulkInsertAndThrowaway<CTADataDbContext, Trip>(tripsvalues);
                        tripsvalues = null;
                        break;

                    default:
                        continue;

                }
            }
        }
    }
}