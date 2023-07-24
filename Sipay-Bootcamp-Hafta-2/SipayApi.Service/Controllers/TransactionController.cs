using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SipayApi.Base.Response;
using SipayApi.DataAccess.Domain;
using SipayApi.DataAccess.Repository;
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


        [HttpGet]
        public ApiResponse<List<Transaction>> GetAll()
        {
            var entityList = repository.GetAll();
            return new ApiResponse<List<Transaction>>(entityList);
        }

        [HttpGet("{id}")]
        public ApiResponse<Transaction> Get(int id)
        {
            var entity = repository.GetById(id);
            return new ApiResponse<Transaction>(entity);
        }


        [HttpPost]
        public ApiResponse Post([FromBody] Transaction request)
        {
            repository.Insert(request);
            return new ApiResponse();
        }

        [HttpPut("{id}")]
        public ApiResponse Put(int id, [FromBody] Transaction request)
        {
            repository.Update(request);
            return new ApiResponse();
        }


        [HttpDelete("{id}")]
        public ApiResponse Delete(int id)
        {
            repository.DeleteById(id);
            return new ApiResponse();
        }


    }

}
