using DTOs.Entities;
using Microsoft.AspNetCore.Components;
using System.Text.Json;
using System.Text;

namespace ConcessionaireAppClient.Components.Pages
{
    public partial class NewBrand
    {
        private BrandResponse Model { get; set; }

        [Inject]
        private IHttpClientFactory _clientFactory { get; set; }

        [Inject]
        private IConfiguration _configuration { get; set; }

        [Inject]
        private NavigationManager _navigationManager { get; set; }

        private readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions { PropertyNamingPolicy = null };



        protected override void OnInitialized()
        {
            Model = new BrandResponse();
        }

        private async Task Submit()
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["ApiUri"]);

            var body = JsonSerializer.Serialize(Model, _jsonSerializerOptions);

            var content = new StringContent(body, Encoding.UTF8, "application/json");

            var resp = await client.PostAsync($"/ConcessionaireApp/CreateNewBrand", content);

            using var Stream = await resp.Content.ReadAsStreamAsync();

            bool UpdateResult = await JsonSerializer.DeserializeAsync<bool>(Stream);

            if (UpdateResult)
            {
                _navigationManager.NavigateTo("/Brands");
            }

        }
    }
}
