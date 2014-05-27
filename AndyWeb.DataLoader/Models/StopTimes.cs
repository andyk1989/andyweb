using System;

namespace AndyWeb.DataLoader
{
    public class StopTimes
    {
        public int Id { get; set; }
        public long TripId { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public int StopId { get; set; }
        public int StopSequence { get; set; }
        public string StopHeadSign { get; set; }
        public int PickupType { get; set; }
        public int DistanceTraveled { get; set; }
    }
}
