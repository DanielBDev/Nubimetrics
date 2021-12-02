using Application.DTOs.Search;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.ServiceSearch
{
    public class SearchService : ISearchService
    {
        private readonly HttpClient _httpClient;

        public SearchService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Search> Search(string product)
        {
            var request = await _httpClient.GetAsync("https://api.mercadolibre.com/sites/MLA/search?q=" + product);

            return JsonSerializer.Deserialize<Search>(await request.Content.ReadAsStringAsync());
        }
    }
}