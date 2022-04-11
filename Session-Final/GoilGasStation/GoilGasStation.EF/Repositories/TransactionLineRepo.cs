using GoilGasStation.Model;
using GoilGasStation.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoilGasStation.EF.Repositories
{
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        private readonly GoilGasStationContext _context;
        public TransactionLineRepo(GoilGasStationContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(TransactionLine Entity)
        {
            await _context.TransactionLines.AddAsync(Entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var currentTransactionLine = _context.TransactionLines.SingleOrDefault(transactionline => transactionline.ID == id);
            if (currentTransactionLine is null)
                throw new KeyNotFoundException($"'{id}' not found");
            _context.TransactionLines.Remove(currentTransactionLine);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TransactionLine>> GetAllAsync()
        {
            return await _context.TransactionLines.ToListAsync();
        }

        public async Task<TransactionLine?> GetByIdAsync(Guid id)
        {
            return await _context.TransactionLines.Where(transactionline => transactionline.ID == id).SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(Guid id, TransactionLine entity)
        {
            var currentTransactionLine = await _context.TransactionLines.SingleOrDefaultAsync(transactionline => transactionline.ID == id);
            if (currentTransactionLine is null)
                throw new KeyNotFoundException($"'{id}' not found");
            currentTransactionLine.TransactionID = entity.TransactionID;
            currentTransactionLine.ItemID = entity.ItemID;
            currentTransactionLine.Quantity = entity.Quantity;
            currentTransactionLine.ItemPrice = entity.ItemPrice;
            currentTransactionLine.NetValue = entity.NetValue;
            currentTransactionLine.DiscountPercent = entity.DiscountPercent;
            currentTransactionLine.DiscountValue = entity.DiscountValue;
            currentTransactionLine.TotalValue = entity.TotalValue;
            await _context.SaveChangesAsync();
        }
    }
}
