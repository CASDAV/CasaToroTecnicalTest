using DTOs.Entities;
using Microsoft.AspNetCore.Components;
using System.Text;
using System.Text.Json;

namespace ConcessionaireAppClient.Components.Pages
{
    public partial class EditSeller
    {
        [Parameter]
        public int Id { get; set; }

        private SellerResponse Model { get; set; }

        [Inject]
        private IHttpClientFactory _clientFactory { get; set; }

        [Inject]
        private IConfiguration _configuration { get; set; }

        private readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions { PropertyNamingPolicy = null };



        protected override async Task OnInitializedAsync()
        {

            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["ApiUri"]);

            var resp = await client.GetAsync($"/ConcessionaireApp/GetSellerById/{Id}");

            using var Stream = await resp.Content.ReadAsStreamAsync();

            Model = await JsonSerializer.DeserializeAsync<SellerResponse>(Stream) ?? new SellerResponse();
        }

        private async Task Submit()
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["ApiUri"]);

            var body = JsonSerializer.Serialize(Model, _jsonSerializerOptions);

            var content = new StringContent(body, Encoding.UTF8, "application/json");

            var resp = await client.PutAsync($"/ConcessionaireApp/UpdateSeller", content);

            using var Stream = await resp.Content.ReadAsStreamAsync();

            bool UpdateResult = await JsonSerializer.DeserializeAsync<bool>(Stream);

        }

    }
}
