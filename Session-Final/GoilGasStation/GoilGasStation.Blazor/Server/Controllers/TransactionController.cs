using Microsoft.AspNetCore.Mvc;
using GoilGasStation.Model;
using GoilGasStation.EF.Repositories;
using GoilGasStation.Blazor.Shared.ViewModels;

namespace RedMotors.Blazor.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        public TransactionController(IEntityRepo<Transaction> transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<TransactionViewModel>> Get()
        {
            var result = await _transactionRepo.GetAllAsync();
            return result.Select(transaction => new TransactionViewModel
            {
                ID = transaction.ID,
                Date = transaction.Date,
                CustomerID = transaction.CustomerID,
                EmployeeID = transaction.EmployeeID,
                TotalValue = transaction.TotalValue,
                PaymentMethod = transaction.PaymentMethod,


            });
        }
        [HttpGet("{id}")]
        public async Task<TransactionEditViewModel> Get(Guid id)
        {

            TransactionEditViewModel model = new();
            if (id != Guid.Empty)
            {
                var existingTransaction = await _transactionRepo.GetByIdAsync(id);
                model.ID = existingTransaction.ID;
                model.Date = existingTransaction.Date;
                model.CustomerID = existingTransaction.CustomerID;
                model.EmployeeID = existingTransaction.EmployeeID;
                model.TotalValue = existingTransaction.TotalValue;
                model.PaymentMethod = existingTransaction.PaymentMethod;


            }
            return model;
        }

        [HttpPost]
        public async Task Post(TransactionViewModel transaction)
        {

            var newTransaction = new Transaction();

            newTransaction.Date = transaction.Date;
            newTransaction.CustomerID = transaction.CustomerID;
            newTransaction.EmployeeID = transaction.EmployeeID;
            newTransaction.TotalValue = transaction.TotalValue;
            newTransaction.PaymentMethod = transaction.PaymentMethod;
            newTransaction.TransactionLines = new();
            foreach (var line in transaction.TransactionLines)
            {
                newTransaction.TransactionLines.Add(new TransactionLine()
                {
                    TransactionID = newTransaction.ID,
                    ItemID = line.ItemID,
                    Quantity = line.Quantity,
                    ItemPrice = line.ItemPrice,
                    NetValue = line.NetValue,
                    DiscountPercent = line.DiscountPercent,
                    DiscountValue = line.DiscountValue,
                    TotalValue = line.TotalValue,
                });
            }

            await _transactionRepo.CreateAsync(newTransaction);
        }


        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _transactionRepo.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(TransactionEditViewModel transaction)
        {
            var transactionToUpdate = await _transactionRepo.GetByIdAsync(transaction.ID);
            if (transactionToUpdate == null) return NotFound();
            transactionToUpdate.Date = transaction.Date;
            transactionToUpdate.CustomerID = transaction.CustomerID;
            transactionToUpdate.EmployeeID = transaction.EmployeeID;
            transactionToUpdate.TotalValue = transaction.TotalValue;
            transactionToUpdate.PaymentMethod = transaction.PaymentMethod;
            await _transactionRepo.UpdateAsync(transaction.ID, transactionToUpdate);
            return Ok();
        }
    }
}
