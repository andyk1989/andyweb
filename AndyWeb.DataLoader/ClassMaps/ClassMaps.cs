using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyWeb.DataLoader
{
    public class AgencyClassMap : CsvClassMap<Agency>
    {
        public AgencyClassMap()
        {
            Map(m => m.Name).Name("agency_name");
            Map(m => m.Url).Name("agency_url");
            Map(m => m.Timezone).Name("agency_timezone");
            Map(m => m.Language).Name("agency_lang");
            Map(m => m.PhoneNumber).Name("agency_phone");
            Map(m => m.FareUrl).Name("agency_fare_url");
        }
    }
    public class CalendarClassMap : CsvClassMap<Calendar>
    {
        public CalendarClassMap()
        {
            Map(m => m.ServiceId).Name("service_id");
            Map(m => m.Monday).Name("monday");
            Map(m => m.Tuesday).Name("tuesday");
            Map(m => m.Wednesday).Name("wednesday");
            Map(m => m.Thursday).Name("thursday");
            Map(m => m.Friday).Name("friday");
            Map(m => m.Saturday).Name("saturday");
            Map(m => m.Sunday).Name("sunday");
            Map(m => m.StartDate).Name("start_date").TypeConverter<DateTimeConverter>();
            Map(m => m.EndDate).Name("end_date").TypeConverter<DateTimeConverter>();
        }
    }

    public class CalendarDatesClassMap : CsvClassMap<CalendarDates>
    {
        public CalendarDatesClassMap()
        {
            Map(m => m.ServiceId).Name("service_id");
            Map(m => m.Date).Name("date").TypeConverter<DateTimeConverter>();
            Map(m => m.ExceptionType).Name("exception_type");
        }
    }

    public class FrequenciesClassMap : CsvClassMap<Frequencies>
    {
        public FrequenciesClassMap()
        {
            Map(m => m.TripId).Name("trip_id");
            Map(m => m.StartTime).Name("start_time").TypeConverter<DateTimeConverter>();
            Map(m => m.EndTime).Name("end_time").TypeConverter<DateTimeConverter>();
            Map(m => m.HeadwaySeconds).Name("headway_secs");
        }
    }

    public class RoutesClassMap : CsvClassMap<Routes>
    {
        public RoutesClassMap()
        {
            Map(m => m.RouteId).Name("route_id");
            Map(m => m.ShortName).Name("route_short_name");
            Map(m => m.FullName).Name("route_long_name");
            Map(m => m.RouteType).Name("route_type");
            Map(m => m.Url).Name("route_url");
            Map(m => m.RouteColor).Name("route_color");
            Map(m => m.RouteTextColor).Name("route_text_color");
        }
    }
}
