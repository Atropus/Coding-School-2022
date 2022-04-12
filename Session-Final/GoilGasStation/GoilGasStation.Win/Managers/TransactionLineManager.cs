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
    public class TransactionLineManager
    {
        HttpClient httpClient = new HttpClient();
        public TransactionLineManager()
        {
            //httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("https://localhost:7069/");

        }
        public async Task<List<TransactionLineViewModel>> GetTransactionLines()
        {
            return await httpClient.GetFromJsonAsync<List<TransactionLineViewModel>>("https://localhost:7069/TransactionLine");
        }
        public async Task CreateTransactionLine(TransactionLineViewModel transactionLine)
        {
            var response = await httpClient.PostAsJsonAsync("https://localhost:7069/TransactionLine", transactionLine);
            response.EnsureSuccessStatusCode();
        }
        public async Task PutTransactionLine(TransactionLineViewModel transactionLine)
        {
            var response = await httpClient.PutAsJsonAsync("https://localhost:7069/TransactionLine", transactionLine);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteTransactionLine(TransactionLineViewModel transactionLine)
        {
            var response = await httpClient.DeleteAsync($"https://localhost:7069/TransactionLine/{transactionLine.ID}/");
            response.EnsureSuccessStatusCode();
        }
    }
}
