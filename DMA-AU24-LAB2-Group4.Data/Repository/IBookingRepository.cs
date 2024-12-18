using DMA_AU24_LAB2_Group4.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA_AU24_LAB2_Group4.Data.Repository
{
    public interface IBookingRepository : IRepository<Booking>
    {
        Task<bool> DoesItemExist(int id);
        Task<Booking?> Find(int id);
        void Update(Booking item);
        void Delete(int id);
    }
}
