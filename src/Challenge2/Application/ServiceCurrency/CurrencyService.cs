using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.ServiceCurrency
{
    internal class CurrencyService : ICurrencyService
    {
        private readonly HttpClient _httpClient;

        public CurrencyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Currency>> GetCurrency()
        {
            var request = await _httpClient.GetAsync("https://api.mercadolibre.com/currencies");

            return JsonSerializer.Deserialize<List<Currency>>(await request.Content.ReadAsStringAsync());
        }
    }
}