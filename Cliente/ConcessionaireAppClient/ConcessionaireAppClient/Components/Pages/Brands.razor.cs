using DTOs.Entities;
using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace ConcessionaireAppClient.Components.Pages
{
    public partial class Brands
    {
        private QuickGrid<BrandResponse>? Grid { get; set; }
        private IQueryable<BrandResponse> _BrandResponse { get; set; }

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

            var resp = await client.GetAsync($"/ConcessionaireApp/GetBrands");

            using var Stream = await resp.Content.ReadAsStreamAsync();

            _BrandResponse = (await JsonSerializer.DeserializeAsync<List<BrandResponse>>(Stream)).AsQueryable();
        }

        public async Task NewBrand()
        {
            _navigationManager.NavigateTo("/NewBrand");

        }
    }
}
