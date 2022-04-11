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
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        private readonly GoilGasStationContext _context;
        public TransactionRepo(GoilGasStationContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Transaction Entity)
        {
            await _context.Transactions.AddAsync(Entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var currentTransaction = _context.Transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (currentTransaction is null)
                throw new KeyNotFoundException($"'{id}' not found");
            _context.Transactions.Remove(currentTransaction);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Transaction>> GetAllAsync()
        {
            return await _context.Transactions.ToListAsync();
        }

        public async Task<Transaction?> GetByIdAsync(Guid id)
        {
            return await _context.Transactions.Where(transaction => transaction.ID == id).SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(Guid id, Transaction entity)
        {
            var currentTransaction = await _context.Transactions.SingleOrDefaultAsync(transaction => transaction.ID == id);
            if (currentTransaction is null)
                throw new KeyNotFoundException($"'{id}' not found");
            currentTransaction.CustomerID = entity.CustomerID;
            currentTransaction.EmployeeID = entity.EmployeeID;
            currentTransaction.TotalValue = entity.TotalValue;
            currentTransaction.PaymentMethod = entity.PaymentMethod;
            currentTransaction.TransactionLines = entity.TransactionLines;
            await _context.SaveChangesAsync();
        }
    }
}
