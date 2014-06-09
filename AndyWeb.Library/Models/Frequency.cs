using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndyWeb.Library
{
    [Table("Frequencies")]
    public class Frequency
    {
        private static int _id = 0;

        public Frequency()
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