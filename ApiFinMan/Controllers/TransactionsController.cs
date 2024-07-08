using ApiFinMan.Storages;
using Microsoft.AspNetCore.Mvc;
using ApiFinMan.Models;

namespace ApiFinMan.Controllers
{
    [ApiController]
    [Route("/[Action]")]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionStorage transactionStorage;

        public TransactionsController(ITransactionStorage _transactionStorage)
        {
            transactionStorage = _transactionStorage;
        }

        [HttpGet("/GetAllTransactions")]
        public List<Transaction> Get()
        {
            var transancions = transactionStorage.GetAll();
            return transancions;
        }

        [HttpPost("/SaveTransaction")]
        public IActionResult Post(Transaction transaction)
        {
            if (transaction != null)
            {

                transactionStorage.Add(transaction);
                return Ok();
            }
            return BadRequest(); 
        }
    }
}
