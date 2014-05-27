namespace AndyWeb.DataLoader
{
    public class Trips
    {
        public int Id { get; set; }
        public string RouteId { get; set; }
        public long ServiceId { get; set; }
        public long TripId { get; set; }
        public int DirectionId { get; set; }
        public long BlockId { get; set; }
        public long ShapeId { get; set; }
        public string Direction { get; set; }
        public bool WheelchairAccessible { get; set; }
        public string ScheduledTripId { get; set; }
    }
}
