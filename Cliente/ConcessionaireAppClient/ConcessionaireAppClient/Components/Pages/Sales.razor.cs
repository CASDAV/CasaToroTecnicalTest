using DTOs.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using System.Text.Json;

namespace ConcessionaireAppClient.Components.Pages
{
    public partial class Sales
    {

        private QuickGrid<SaleResponse>? Grid { get; set; }
        private IQueryable<SaleResponse> _salesResponse {  get; set; }

        [Inject]
        private IHttpClientFactory _clientFactory { get; set; }

        [Inject]
        private IConfiguration _configuration { get; set; }


        protected override async Task OnInitializedAsync()
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["ApiUri"]);

            var resp = await client.GetAsync($"/ConcessionaireApp/GetSales");

            using var Stream = await resp.Content.ReadAsStreamAsync();

            _salesResponse = await JsonSerializer.DeserializeAsync<IQueryable<SaleResponse>>(Stream);
        }

        public async Task DeleteSale(int id)
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["ApiUri"]);

            var resp = await client.DeleteAsync($"/ConcessionaireApp/DeleteSale/{id}");

            using var Stream = await resp.Content.ReadAsStreamAsync();

            bool DeleteResult = await JsonSerializer.DeserializeAsync<bool>(Stream);

            if (DeleteResult)
            {
                var respUpdated = await client.GetAsync($"/GetSales");

                using var StreamUpdated = await resp.Content.ReadAsStreamAsync();

                _salesResponse = await JsonSerializer.DeserializeAsync<IQueryable<SaleResponse>>(Stream);
            }

        }

    }
}
