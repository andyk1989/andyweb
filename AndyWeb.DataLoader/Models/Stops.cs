using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyWeb.DataLoader
{
    public class Stops
    {
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
