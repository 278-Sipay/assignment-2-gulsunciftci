using SipayApi.DataAccess.Domain;
using SipayApi.DataAccess.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Transaction = SipayApi.DataAccess.Domain.Transaction;

namespace SipayApi.DataAccess.Repository
{
    public interface ITransactionRepository : IGenericRepository<Transaction>
    {
        List<Transaction> GetByParameter(int accountNumber, decimal? minAmountCredit, decimal? maxAmountCredit,
                                     decimal? minAmountDebit, decimal? maxAmountDebit,
                                     string description, DateTime? beginDate, DateTime? endDate,
                                     string referenceNumber);
    }

}
