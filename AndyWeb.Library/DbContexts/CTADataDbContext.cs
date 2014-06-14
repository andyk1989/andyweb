using System.Data.Entity;

namespace AndyWeb.Library
{
    public class CTADataDbContext : DbContext
    {
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<CalendarDate> CalendarDates { get; set; }
        public DbSet<Frequency> Frequencies { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Shape> Shapes { get; set; }
        public DbSet<Stop> Stops { get; set; }
        public DbSet<StopTime> StopTimes { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}
