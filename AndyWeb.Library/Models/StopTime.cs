using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndyWeb.Library
{
    [Table("StopTimes")]
    public class StopTime
    {
        private static int _id = 0;

        public StopTime()
        {
            Id = _id++;
        }

        [Key]
        public int Id { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public int DistanceTraveled { get; set; }
        public int PickupType { get; set; }
        public string StopHeadSign { get; set; }
        public int StopId { get; set; }
        public int StopSequence { get; set; }
        public long TripId { get; set; }
    }
}