using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipayApi.Schema.Customer
{
    public class AccountResponse
    {
        public int CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public string Address { get; set; }
        public virtual List<AccountResponse> Accounts { get; set; }
    }
}
