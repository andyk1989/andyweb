namespace AndyWeb
{
    public class CTAStationEntrance
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public int DirectionWeight { get; set; }

        public CardinalDirection Direction { get; set; }
    }
}