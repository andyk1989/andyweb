using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndyWeb.Library
{
    [Table("CalendarDates")]
    public class CalendarDate
    {
        private static int _id = 0;

        public CalendarDate()
        {
            Id = _id++;
        }

        [Key]
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public DateTime Date { get; set; }
        public int ExceptionType { get; set; }
    }
}