using SipayApi.DataAccess.ApplicationDbContext;
using SipayApi.DataAccess.Domain;
using SipayApi.DataAccess.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipayApi.DataAccess.Repository.CustomerRepository
{
    public class CustomerRepository : GenericRepository<Customer>,ICustomerRepository
    {
        private readonly SimDbContext _dbContext;
        public CustomerRepository(SimDbContext simDbContext) : base(simDbContext)
        {
            _dbContext = simDbContext;
        }
        public  List<Customer> GetAll()
        {
            return _dbContext.Set<Customer>().ToList();
        }
      
    }
}
