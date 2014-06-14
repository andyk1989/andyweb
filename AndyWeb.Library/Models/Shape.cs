using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndyWeb.Library
{
    [Table("Shapes")]
    public class Shape
    {
        private static int _id = 0;

        public Shape()
        {
            Id = _id++;
        }

        [Key]
        public int Id { get; set; }
        public long ShapeId { get; set; }
        public decimal LatitudePoint { get; set; }
        public decimal LongitudePoint { get; set; }
        public int PointSequence { get; set; }
        public int DistanceTraveled { get; set; }
    }
}