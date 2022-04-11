using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using GoilGasStation.Blazor.Shared.ViewModels;
using System.Net.Http.Json;

namespace GoilGasStation.Blazor.Client.Pages
{
    public partial class CustomerList
    {
        List<CustomerViewModel> customerList = new List<CustomerViewModel>();
        private bool isLoading = true;


        protected override async Task OnInitializedAsync()
        {
            await LoadCustomersFromServer();
            isLoading = false;
        }

        private async Task LoadCustomersFromServer()
        {
            customerList = await httpClient.GetFromJsonAsync<List<CustomerViewModel>>("Customer");
        }

        async Task AddCustomer()
        {
            navigationManager.NavigateTo("/CustomerList/edit");
        }
        async Task EditCustomer(CustomerViewModel customerToEdit)
        {
            navigationManager.NavigateTo($"/CustomerList/edit/{customerToEdit.ID}");
        }
        async Task DeleteCustomer(CustomerViewModel customerToDelete)
        {
            var response = await httpClient.DeleteAsync($"Customer/{customerToDelete.ID}");
            response.EnsureSuccessStatusCode();
            await LoadCustomersFromServer();
        }

    }
}
