using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using GoilGasStation.Blazor.Shared.ViewModels;
using System.Net.Http.Json;

namespace GoilGasStation.Blazor.Client.Pages
{
    public partial class ItemList
    {
        List<ItemViewModel> itemList = new List<ItemViewModel>();
        private bool isLoading = true;


        protected override async Task OnInitializedAsync()
        {
            await LoadItemsFromServer();
            isLoading = false;
        }

        private async Task LoadItemsFromServer()
        {
            itemList = await httpClient.GetFromJsonAsync<List<ItemViewModel>>("Item");
        }

        async Task AddItem()
        {
            if (navigationManager.Uri.Contains("Staff"))
            {
                navigationManager.NavigateTo("/Staff/ItemList/edit");
            }
            else
            {
                navigationManager.NavigateTo("/ItemList/edit");
            }
                
        }
        async Task EditItem(ItemViewModel itemToEdit)
        {
            if (navigationManager.Uri.Contains("Staff"))
            {
                navigationManager.NavigateTo($"/Staff/ItemList/edit/{itemToEdit.ID}");
            }
            else
            {
                navigationManager.NavigateTo($"/ItemList/edit/{itemToEdit.ID}");
            }
        }
        async Task DeleteItem(ItemViewModel itemToDelete)
        {
            var response = await httpClient.DeleteAsync($"Item/{itemToDelete.ID}");
            response.EnsureSuccessStatusCode();
            await LoadItemsFromServer();
        }

    }
}