using DTOs.Entities;
using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace ConcessionaireAppClient.Components.Pages
{
    public partial class Sellers
    {

        private QuickGrid<SellerResponse>? Grid { get; set; }
        private IQueryable<SellerResponse> _sellersResponse { get; set; }

        [Inject]
        private IHttpClientFactory _clientFactory { get; set; }

        [Inject]
        private IConfiguration _configuration { get; set; }

        [Inject]
        private NavigationManager _navigationManager { get; set; }


        protected override async Task OnInitializedAsync()
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["ApiUri"]);

            var resp = await client.GetAsync($"/ConcessionaireApp/GetSellers");

            using var Stream = await resp.Content.ReadAsStreamAsync();

            _sellersResponse = await JsonSerializer.DeserializeAsync<IQueryable<SellerResponse>>(Stream);
        }

        public async void EditSeller(int id)
        {
            _navigationManager.NavigateTo($"/EditSeller/{id}");

        }
    }
}
