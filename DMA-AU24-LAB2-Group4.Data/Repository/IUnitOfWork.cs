using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA_AU24_LAB2_Group4.Data.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IBookingRepository Bookings { get; }
        IConcertRepository Concerts { get; }
        ICustomerRepository Customers { get; }
        IPerformanceRepository Performances { get; }

        Task<int> SaveChangesAsync();
        
    }
}
