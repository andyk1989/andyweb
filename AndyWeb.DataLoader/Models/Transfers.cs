using System.ComponentModel.DataAnnotations;

namespace AndyWeb.DataLoader
{
    public class Transfers
    {
        private static int _id = 0;

        public Transfers()
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