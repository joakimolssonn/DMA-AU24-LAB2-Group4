using DMA_AU24_LAB2_Group4.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA_AU24_LAB2_Group4.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public ApplicationDbContext DbContext => Context as ApplicationDbContext;

        public CustomerRepository(ApplicationDbContext context)
            : base(context) { }
    }
}
