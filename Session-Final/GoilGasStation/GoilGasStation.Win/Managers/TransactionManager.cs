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
    public class TransactionManager
    {
        HttpClient httpClient = new HttpClient();
        public TransactionManager()
        {
            //httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("https://localhost:7069/");

        }
        public async Task<List<TransactionViewModel>> GetTransactions()
        {
            return await httpClient.GetFromJsonAsync<List<TransactionViewModel>>("https://localhost:7069/transaction");
        }
        public async Task CreateTransaction(TransactionViewModel transaction)
        {
            var response = await httpClient.PostAsJsonAsync("https://localhost:7069/transaction", transaction);
            response.EnsureSuccessStatusCode();
        }
        public async Task PutTransaction(TransactionViewModel transaction)
        {
            var response = await httpClient.PutAsJsonAsync("https://localhost:7069/transaction", transaction);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteTransaction(TransactionViewModel transaction)
        {
            var response = await httpClient.DeleteAsync($"https://localhost:7069/transaction/{transaction.ID}/");
            response.EnsureSuccessStatusCode();
        }
    }
}
