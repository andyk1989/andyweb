using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndyWeb.DataLoader
{
    [Table("Transfers")]
    public class Transfer
    {
        private static int _id = 0;

        public Transfer()
        {
            Id = _id++;
        }

        [Key]
        public int Id { get; set; }
        public int SourceStopId { get; set; }
        public int DestinationStopId { get; set; }
        public int TransferType { get; set; }
    }
}