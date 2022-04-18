using Microsoft.AspNetCore.Mvc;
using GoilGasStation.Model;
using GoilGasStation.EF.Repositories;
using GoilGasStation.Blazor.Shared.ViewModels;

namespace RedMotors.Blazor.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TransactionLineController : ControllerBase
    {
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        public TransactionLineController(IEntityRepo<TransactionLine> transactionLineRepo)
        {
            _transactionLineRepo = transactionLineRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<TransactionLineViewModel>> Get()
        {
            var result = await _transactionLineRepo.GetAllAsync();
            return result.Select(transactionLine => new TransactionLineViewModel
            {
                ID = transactionLine.ID,
                TransactionID = transactionLine.TransactionID,
                ItemID = transactionLine.ItemID,
                Quantity = transactionLine.Quantity,
                ItemPrice = transactionLine.ItemPrice,
                NetValue = transactionLine.NetValue,
                DiscountPercent = transactionLine.DiscountPercent,
                DiscountValue = transactionLine.DiscountValue,
                TotalValue = transactionLine.TotalValue,

            });
        }
        [HttpGet("{id}")]
        public async Task<TransactionLineEditViewModel> Get(Guid id)
        {
            
            TransactionLineEditViewModel model = new();
            if (id != Guid.Empty)
            {
                var existingTransactionLine = await _transactionLineRepo.GetByIdAsync(id);
                model.ID = existingTransactionLine.ID;
                model.TransactionID = existingTransactionLine.TransactionID;
                model.ItemID = existingTransactionLine.ItemID;
                model.Quantity = existingTransactionLine.Quantity;
                model.ItemPrice = existingTransactionLine.ItemPrice;
                model.NetValue = existingTransactionLine.NetValue;
                model.DiscountPercent = existingTransactionLine.DiscountPercent;
                model.DiscountValue = existingTransactionLine.DiscountValue;
                model.TotalValue = existingTransactionLine.TotalValue;

            }
            return model;
        }


        [HttpPost]
        public async Task Post(TransactionLineEditViewModel transactionLine)
        {

            var newTransactionLine = new TransactionLine
            {
                TransactionID = transactionLine.TransactionID,
                ItemID = transactionLine.ItemID,
                Quantity = transactionLine.Quantity,
                ItemPrice = transactionLine.ItemPrice,
                NetValue = transactionLine.NetValue,
                DiscountPercent = transactionLine.DiscountPercent,
                DiscountValue = transactionLine.DiscountValue,
                TotalValue = transactionLine.TotalValue,
                

            };
            await _transactionLineRepo.CreateAsync(newTransactionLine);
        }


        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _transactionLineRepo.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(TransactionLineEditViewModel transactionLine)
        {
            var transactionLineToUpdate = await _transactionLineRepo.GetByIdAsync(transactionLine.ID);
            if (transactionLineToUpdate == null) return NotFound();
            transactionLineToUpdate.ItemID = transactionLine.ItemID;
            transactionLineToUpdate.Quantity = transactionLine.Quantity;
            transactionLineToUpdate.ItemPrice = transactionLine.ItemPrice;
            transactionLineToUpdate.NetValue = transactionLine.NetValue;
            transactionLineToUpdate.DiscountPercent = transactionLine.DiscountPercent;
            transactionLineToUpdate.DiscountValue = transactionLine.DiscountValue;
            transactionLineToUpdate.TotalValue = transactionLine.TotalValue;

            await _transactionLineRepo.UpdateAsync(transactionLine.ID, transactionLineToUpdate);
            return Ok();
        }
    }
}
