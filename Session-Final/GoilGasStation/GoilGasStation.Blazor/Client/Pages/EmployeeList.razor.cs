using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using GoilGasStation.Blazor.Shared.ViewModels;
using System.Net.Http.Json;

namespace GoilGasStation.Blazor.Client.Pages
{
    public partial class EmployeeList
    {
        List<EmployeeViewModel> employeeList = new List<EmployeeViewModel>();
        private bool isLoading = true;


        protected override async Task OnInitializedAsync()
        {
            await LoadEmployeesFromServer();
            isLoading = false;
        }

        private async Task LoadEmployeesFromServer()
        {
            employeeList = await httpClient.GetFromJsonAsync<List<EmployeeViewModel>>("Employee");
        }

        async Task AddEmployee()
        {
            navigationManager.NavigateTo("/EmployeeList/edit");
        }
        async Task EditEmployee(EmployeeViewModel employeeToEdit)
        {
            navigationManager.NavigateTo($"/EmployeeList/edit/{employeeToEdit.ID}");
        }
        async Task DeleteEmployee(EmployeeViewModel employeeToDelete)
        {
            var response = await httpClient.DeleteAsync($"Employee/{employeeToDelete.ID}");
            response.EnsureSuccessStatusCode();
            await LoadEmployeesFromServer();
        }

    }
}
