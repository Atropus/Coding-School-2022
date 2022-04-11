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
    public class CustomerRepo : IEntityRepo<Customer>
    {
        private readonly GoilGasStationContext _context;
        public CustomerRepo(GoilGasStationContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Customer Entity)
        {
            await _context.Customers.AddAsync(Entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var currentCustomer = _context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (currentCustomer is null)
                throw new KeyNotFoundException($"'{id}' not found");
            _context.Customers.Remove(currentCustomer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer?> GetByIdAsync(Guid id)
        {
            return await _context.Customers.Where(customer => customer.ID == id).SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(Guid id, Customer entity)
        {
            var currentCustomer = await _context.Customers.SingleOrDefaultAsync(customer => customer.ID == id);
            if (currentCustomer is null)
                throw new KeyNotFoundException($"'{id}' not found");
            currentCustomer.Name = entity.Name;
            currentCustomer.Surname = entity.Surname;
            currentCustomer.CardNumber = entity.CardNumber;
            await _context.SaveChangesAsync();
        }
    }
}
