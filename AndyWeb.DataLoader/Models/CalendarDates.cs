using System;

namespace AndyWeb.DataLoader
{
    public class CalendarDates
    {
        private static int _id = 0;

        public CalendarDates()
        {
            Id = _id++;
        }

        public int Id { get; set; }
        public int ServiceId { get; set; }
        public DateTime Date { get; set; }
        public int ExceptionType { get; set; }
    }
}
