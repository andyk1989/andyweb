using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndyWeb.DataLoader
{
    [Table("Agencies")]
    public class Agency
    {
        private static int _id = 0;

        public Agency()
        {
            Id = _id++;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Timezone { get; set; }
        public string Language { get; set; }
        public string PhoneNumber { get; set; }
        public string FareUrl { get; set; }
    }
}