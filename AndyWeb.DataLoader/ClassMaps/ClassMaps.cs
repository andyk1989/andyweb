using CsvHelper.Configuration;

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

    public class ShapesClassMap : CsvClassMap<Shapes>
    {
        public ShapesClassMap()
        {
            Map(m => m.ShapeId).Name("shape_id");
            Map(m => m.LatitudePoint).Name("shape_pt_lat");
            Map(m => m.LongitudePoint).Name("shape_pt_lon");
            Map(m => m.PointSequence).Name("shape_pt_sequence");
            Map(m => m.DistanceTraveled).Name("shape_dist_traveled");
        }
    }

    public class StopsClassMap : CsvClassMap<Stops>
    {
        public StopsClassMap()
        {
            Map(m => m.StopId).Name("stop_id");
            Map(m => m.StopCode).Name("stop_code").TypeConverter<NotNullableIntConverter>();
            Map(m => m.Name).Name("stop_name");
            Map(m => m.Description).Name("stop_desc");
            Map(m => m.Latitude).Name("stop_lat");
            Map(m => m.Longitude).Name("stop_lon");
            Map(m => m.LocationType).Name("location_type");
            Map(m => m.ParentStation).Name("parent_station").TypeConverter<NotNullableIntConverter>();
            Map(m => m.WheelchairBoarding).Name("wheelchair_boarding");
        }
    }

    public class StopTimesClassMap : CsvClassMap<StopTimes>
    {
        public StopTimesClassMap()
        {
            Map(m => m.TripId).Name("trip_id");
            Map(m => m.ArrivalTime).Name("arrival_time").TypeConverter<TimeSpanConverter>();
            Map(m => m.DepartureTime).Name("departure_time").TypeConverter<TimeSpanConverter>();
            Map(m => m.StopId).Name("stop_id");
            Map(m => m.StopSequence).Name("stop_sequence");
            Map(m => m.StopHeadSign).Name("stop_headsign");
            Map(m => m.PickupType).Name("pickup_type");
            Map(m => m.DistanceTraveled).Name("shape_dist_traveled");
        }
    }

    public class TransfersClassMap : CsvClassMap<Transfers>
    {
        public TransfersClassMap()
        {
            Map(m => m.SourceStopId).Name("from_stop_id");
            Map(m => m.DestinationStopId).Name("to_stop_id");
            Map(m => m.TransferType).Name("transfer_type");
        }
    }

    public class TripsClassMap : CsvClassMap<Trips>
    {
        public TripsClassMap()
        {
            Map(m => m.RouteId).Name("route_id");
            Map(m => m.ServiceId).Name("service_id");
            Map(m => m.TripId).Name("trip_id");
            Map(m => m.DirectionId).Name("direction_id");
            Map(m => m.BlockId).Name("block_id");
            Map(m => m.ShapeId).Name("shape_id");
            Map(m => m.Direction).Name("direction");
            Map(m => m.WheelchairAccessible).Name("wheelchair_accessible");
            Map(m => m.ScheduledTripId).Name("schd_trip_id");
        }
    }
}