using Application.DTOs.Country;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.ServiceCountry
{
    public class CountryService : ICountryService
    {
        private readonly HttpClient _httpClient;

        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Country> GetCountry(string country)
        {
            var request = await _httpClient.GetAsync("https://api.mercadolibre.com/classified_locations/countries/" + country.ToUpper());

            return JsonSerializer.Deserialize<Country>(await request.Content.ReadAsStringAsync());
        }
    }
}