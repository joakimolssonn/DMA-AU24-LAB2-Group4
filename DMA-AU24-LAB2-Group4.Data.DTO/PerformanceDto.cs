﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA_AU24_LAB2_Group4.Data.DTO
{
    public class PerformanceDto
    {
        public int ID { get; set; } = 0!;
        public DateTime PerformanceDate { get; set; } 
        public string Venue { get; set; } = null!;
        public string City {  get; set; } = null!;
        public string Country { get; set; } = null!;
        public string ConcertTitle { get; set; } = null!;
    }
}