using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA_AU24_LAB2_Group4.MAUI.Models
{
    public class Booking
    {
        public int Id { get; set; } = 0!;
        public int? PerformanceId { get; set; }
        public int? CustomerId { get; set; }
        //Navigation properties
        public Performance? Performance { get; set; }
        public Customer? Customer { get; set; }
    }
}
