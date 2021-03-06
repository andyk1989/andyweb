﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndyWeb.Library
{
    [Table("Stops")]
    public class Stop
    {
        private static int _id = 0;

        public Stop()
        {
            Id = _id++;
        }

        [Key]
        public int Id { get; set; }
        public int StopId { get; set; }
        public int StopCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int LocationType { get; set; }
        public int ParentStation { get; set; }
        public bool WheelchairBoarding { get; set; }
    }
}