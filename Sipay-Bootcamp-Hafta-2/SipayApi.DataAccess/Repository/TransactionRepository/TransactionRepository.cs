using SipayApi.DataAccess.ApplicationDbContext;
using SipayApi.DataAccess.Domain;
using SipayApi.DataAccess.Repository.Base;

namespace SipayApi.DataAccess.Repository.TransactionRepository
    {
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(SimDbContext simDbContext) : base(simDbContext)
        {
        }
    }
}


