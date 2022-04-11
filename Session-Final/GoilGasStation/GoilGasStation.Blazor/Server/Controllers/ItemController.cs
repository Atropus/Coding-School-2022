using Microsoft.AspNetCore.Mvc;
using GoilGasStation.Model;
using GoilGasStation.EF.Repositories;
using GoilGasStation.Blazor.Shared.ViewModels;

namespace RedMotors.Blazor.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IEntityRepo<Item> _itemRepo;
        public ItemController(IEntityRepo<Item> itemRepo)
        {
            _itemRepo = itemRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<ItemViewModel>> Get()
        {
            var result = await _itemRepo.GetAllAsync();
            return result.Select(item => new ItemViewModel
            {
                ID = item.ID,
                Code = item.Code,
                Description = item.Description,
                ItemType = item.ItemType,
                Price = item.Price,
                Cost = item.Cost,
            });
        }
        [HttpGet("{id}")]
        public async Task<ItemEditViewModel> Get(Guid id)
        {
            ItemEditViewModel model = new();
            if (id != Guid.Empty)
            {
                var existingItem = await _itemRepo.GetByIdAsync(id);
                model.ID = existingItem.ID;
                model.Code = existingItem.Code;
                model.Description = existingItem.Description;
                model.ItemType = existingItem.ItemType;
                model.Price = existingItem.Price;
                model.Cost = existingItem.Cost;
            }
            return model;
        }
        [HttpPost]
        public async Task Post(ItemEditViewModel item)
        {
            var newItem = new Item
            {
                Code = item.Code,
                Description = item.Description,
                ItemType = item.ItemType,
                Price = item.Price,
                Cost = item.Cost,
            };
            await _itemRepo.CreateAsync(newItem);
        }


        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _itemRepo.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(ItemEditViewModel item)
        {
            var itemToUpdate = await _itemRepo.GetByIdAsync(item.ID);
            if (itemToUpdate == null) return NotFound();
            itemToUpdate.Code = item.Code;
            itemToUpdate.Description = item.Description;
            itemToUpdate.ItemType = item.ItemType;
            itemToUpdate.Price = item.Price;
            itemToUpdate.Cost = item.Cost;

            await _itemRepo.UpdateAsync(item.ID, itemToUpdate);
            return Ok();
        }
    }
}
