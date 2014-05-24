using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AndyWeb
{
    public class CTAStation
    {
        public int ID { get; set; }

        public IEnumerable<CTAStationEntrance> Entrances { get; set; }

        public string Name { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
    }
}