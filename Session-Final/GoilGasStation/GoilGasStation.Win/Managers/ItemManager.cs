using GoilGasStation.Blazor.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace GoilGasStation.Win.Managers
{
    public class ItemManager
    {
        HttpClient httpClient = new HttpClient();
        public ItemManager()
        {

        }
        public async Task<List<ItemViewModel>> GetItems()
        {
            return await httpClient.GetFromJsonAsync<List<ItemViewModel>>("https://localhost:7069/item");
        }
        public async Task CreateItem(ItemViewModel item)
        {
            var response = await httpClient.PostAsJsonAsync("https://localhost:7069/item", item);
        }
        public async Task PutItem(ItemViewModel item)
        {
            var response = await httpClient.PutAsJsonAsync("https://localhost:7069/item", item);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteItem(ItemViewModel item)
        {
            var response = await httpClient.DeleteAsync($"https://localhost:7069/item/{item.ID}/");
            response.EnsureSuccessStatusCode();
        }
    }
}
