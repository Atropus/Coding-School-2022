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
    public class CustomerManager
    {
        HttpClient httpClient = new HttpClient();
        public CustomerManager()
        {
            //httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("https://localhost:7069/");

        }
        public async Task<List<CustomerViewModel>> GetCustomers()
        {
            return await httpClient.GetFromJsonAsync<List<CustomerViewModel>>("https://localhost:7069/customer");
        }
        public async Task CreateCustomer(CustomerViewModel customer)
        {
            var response = await httpClient.PostAsJsonAsync("https://localhost:7069/Customer", customer);
            response.EnsureSuccessStatusCode();
        }
        public async Task PutCustomer(CustomerViewModel customer)
        {
            var response = await httpClient.PutAsJsonAsync("https://localhost:7069/Customer", customer);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteCustomer(CustomerViewModel customer)
        {
            var response = await httpClient.DeleteAsync($"https://localhost:7069/Customer/{customer.ID}/");
            response.EnsureSuccessStatusCode();
        }
    }
}
