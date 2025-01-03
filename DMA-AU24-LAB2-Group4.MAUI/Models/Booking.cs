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
        public string Id { get; set; } = null!;
        public int PerformanceId { get; set; } = 0!;
        public int CustomerId { get; set; } = 0!;
        //Navigation properties
        public Performance? Performance { get; set; }
        public Customer? Customer { get; set; }
    }
}
