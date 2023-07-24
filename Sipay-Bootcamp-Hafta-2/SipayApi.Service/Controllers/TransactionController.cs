using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SipayApi.Base.Response;
using SipayApi.DataAccess.Domain;
using SipayApi.DataAccess.Repository;
using System.Collections.Generic;
using System.Transactions;
using Transaction = SipayApi.DataAccess.Domain.Transaction;

namespace SipayApi.Service.Controllers
{
    [ApiController]
    [Route("sipy/api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionRepository repository;
        public TransactionController(ITransactionRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("GetByParameters")]
        public ApiResponse<List<Transaction>> GetByParameters(int accountNumber, decimal? minCreditAmount, decimal? maxCreditAmount,
                                                                 decimal? minDebitAmount, decimal? maxDebitAmount, string description,
                                                                 DateTime? beginDate, DateTime? endDate, string referenceNumber)
        {
            var List = repository.GetByParameter(accountNumber,minCreditAmount,maxCreditAmount,minDebitAmount,maxDebitAmount,description,beginDate,endDate,referenceNumber);

           
            return new ApiResponse<List<Transaction>>(List);
        }
    }

}
