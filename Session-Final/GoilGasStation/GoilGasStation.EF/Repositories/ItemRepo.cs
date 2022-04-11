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
    public class ItemRepo : IEntityRepo<Item>
    {
        private readonly GoilGasStationContext _context;
        public ItemRepo(GoilGasStationContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Item Entity)
        {
            await _context.Items.AddAsync(Entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var currentItem = _context.Items.SingleOrDefault(item => item.ID == id);
            if (currentItem is null)
                throw new KeyNotFoundException($"'{id}' not found");
            _context.Items.Remove(currentItem);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Item>> GetAllAsync()
        {
            return await _context.Items.ToListAsync();
        }

        public async Task<Item?> GetByIdAsync(Guid id)
        {
            return await _context.Items.Where(item => item.ID == id).SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(Guid id, Item entity)
        {
            var currentItem = await _context.Items.SingleOrDefaultAsync(item => item.ID == id);
            if (currentItem is null)
                throw new KeyNotFoundException($"'{id}' not found");
            currentItem.Code = entity.Code;
            currentItem.Description = entity.Description;
            currentItem.ItemType = entity.ItemType;
            currentItem.Price = entity.Price;
            currentItem.Cost = entity.Cost;
            await _context.SaveChangesAsync();
        }
    }
}
