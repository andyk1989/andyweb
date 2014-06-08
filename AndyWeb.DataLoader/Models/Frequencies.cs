using System;
using System.ComponentModel.DataAnnotations;

namespace AndyWeb.DataLoader
{
    public class Frequencies
    {
        private static int _id = 0;

        public Frequencies()
        {
            Id = _id++;
        }

        [Key]
        public int Id { get; set; }
        public long TripId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int HeadwaySeconds { get; set; }
    }
}