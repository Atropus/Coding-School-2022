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
    public class EmployeeManager
    {
        HttpClient httpClient = new HttpClient();
        public EmployeeManager()
        {
            //httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("https://localhost:7069/");

        }
        public async Task<List<EmployeeViewModel>> GetEmployees()
        {
            return await httpClient.GetFromJsonAsync<List<EmployeeViewModel>>("https://localhost:7069/Employee");
        }
        public async Task CreateEmployee(EmployeeViewModel employee)
        {
            var response = await httpClient.PostAsJsonAsync("https://localhost:7069/Employee", employee);
            response.EnsureSuccessStatusCode();
        }
        public async Task PutEmployee(EmployeeViewModel employee)
        {
            var response = await httpClient.PutAsJsonAsync("https://localhost:7069/Employee", employee);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteEmployee(EmployeeViewModel employee)
        {
            var response = await httpClient.DeleteAsync($"https://localhost:7069/Employee/{employee.ID}/");
            response.EnsureSuccessStatusCode();
        }
    }
}
