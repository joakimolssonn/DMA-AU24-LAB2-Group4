using DMA_AU24_LAB2_Group4.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA_AU24_LAB2_Group4.Data.Repository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<bool> DoesItemExist(int id);
        Task<Customer?> Find(int id);
        void Update(Customer item);
        void Delete(int id);
    }
}
