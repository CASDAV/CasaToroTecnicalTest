using DTOs.Entities;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace ConcessionaireAppClient.Components.Pages
{
    public partial class SalesBySellerId
    {
        public int? Id { get; set; }

        private int? _id { get; set; }

        private IQueryable<SaleResponse> _salesResponse { get; set; }

        [Inject]
        private IHttpClientFactory _clientFactory { get; set; }

        [Inject]
        private IConfiguration _configuration { get; set; }

        protected override void OnInitialized()
        {
            _id = null;
            Id = null;
        }

        public async Task SearchAction()
        {
            if (Id != null)
            {
                var client = _clientFactory.CreateClient();
                client.BaseAddress = new Uri(_configuration["ApiUri"]);

                var resp = await client.GetAsync($"/ConcessionaireApp/GetSalesBySellerId/{Id}");

                using var Stream = await resp.Content.ReadAsStreamAsync();

                _salesResponse = await JsonSerializer.DeserializeAsync<IQueryable<SaleResponse>>(Stream);

                _id = Id;
            }
        }
    }
}
