using DMA_AU24_LAB2_Group4.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA_AU24_LAB2_Group4.Data.Repository
{
    public class PerformanceRepository : Repository<Performance>, IPerformanceRepository
    {
        public ApplicationDbContext DbContext => Context as ApplicationDbContext;

        public PerformanceRepository(ApplicationDbContext context)
            : base(context) { }
    }
}
