using System.ComponentModel.DataAnnotations;

namespace AndyWeb.DataLoader
{
    public class Routes
    {
        private static int _id = 0;

        public Routes()
        {
            Id = _id++;
        }

        [Key]
        public int Id { get; set; }
        public string RouteId { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public int RouteType { get; set; }
        public string Url { get; set; }
        public string RouteColor { get; set; }
        public string RouteTextColor { get; set; }
    }
}