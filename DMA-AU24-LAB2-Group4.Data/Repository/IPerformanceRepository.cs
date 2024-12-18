using DMA_AU24_LAB2_Group4.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA_AU24_LAB2_Group4.Data.Repository
{
    public interface IPerformanceRepository : IRepository<Performance>
    {
        Task<bool> DoesItemExist(int id);
        Task<Performance?> Find(int id);
        void Update(Performance item);
        void Delete(int id);
    }
}
