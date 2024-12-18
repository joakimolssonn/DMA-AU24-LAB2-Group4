using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMA_AU24_LAB2_Group4.Data.Entity
{
    public class Booking
    {
        [Key]
        public required int Id { get; set; }

        [ForeignKey(nameof(Performance))]
        public required int PerformanceId { get; set; }

        [ForeignKey(nameof(Customer))]
        public required int CustomerId { get; set; }

        //Navigation properties
        public  Performance? Performance { get; set; }
        public  Customer? Customer { get; set; }

    }
}
