using System;

namespace AndyWeb.DataLoader
{
    public class Calendar
    {
        private static int _id = 0;

        public Calendar()
        {
            Id = _id++;
        }

        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
