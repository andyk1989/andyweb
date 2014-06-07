namespace AndyWeb.DataLoader
{
    public class Shapes
    {
        private static int _id = 0;

        public Shapes()
        {
            Id = _id++;
        }

        public int Id { get; set; }
        public long ShapeId { get; set; }
        public decimal LatitudePoint { get; set; }
        public decimal LongitudePoint { get; set; }
        public int PointSequence { get; set; }
        public int DistanceTraveled { get; set; }
    }
}
