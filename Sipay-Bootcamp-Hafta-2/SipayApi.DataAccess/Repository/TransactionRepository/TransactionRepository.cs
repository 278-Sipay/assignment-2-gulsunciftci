using SipayApi.DataAccess.ApplicationDbContext;
using SipayApi.DataAccess.Domain;
using SipayApi.DataAccess.Repository.Base;
using System.Linq.Expressions;

namespace SipayApi.DataAccess.Repository.TransactionRepository
    {
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(SimDbContext simDbContext) : base(simDbContext)
        {
        }


        public List<Transaction> GetByParameter(int accountNumber, decimal? minAmountCredit, decimal? maxAmountCredit,
                                            decimal? minAmountDebit, decimal? maxAmountDebit,
                                            string description, DateTime? beginDate, DateTime? endDate,
                                            string referenceNumber)
        {
            
            Expression<Func<Transaction, bool>> expression = x =>
                (accountNumber == null || x.AccountNumber == accountNumber) &&
                (!minAmountCredit.HasValue || x.CreditAmount >= minAmountCredit) &&
                (!maxAmountCredit.HasValue || x.CreditAmount <= maxAmountCredit) &&
                (!minAmountDebit.HasValue || x.DebitAmount >= minAmountDebit) &&
                (!maxAmountDebit.HasValue || x.DebitAmount <= maxAmountDebit) &&
                (string.IsNullOrEmpty(description) || x.Description.Contains(description)) &&
                (!beginDate.HasValue || x.TransactionDate >= beginDate) &&
                (!endDate.HasValue || x.TransactionDate <= endDate) &&
                (string.IsNullOrEmpty(referenceNumber) || x.ReferenceNumber == referenceNumber);

            return GetByParameter(expression);
        }
    }
}


