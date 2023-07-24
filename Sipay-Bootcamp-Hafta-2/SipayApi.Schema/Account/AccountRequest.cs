using SipayApi.Schema.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipayApi.Schema.Account
{
    public class AccountRequest
    {

        public int CustomerNumber { get; set; }
        public string Name { get; set; }
        public string CurrencyCode { get; set; }
        public bool IsActive { get; set; }
        public virtual List<TransactionResponse> Transactions { get; set; }
    }
}
