using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.ServiceCurrencyConversion
{
    public class CurrencyConversionService : ICurrencyConversionService
    {
        private readonly HttpClient _httpClient;

        public CurrencyConversionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CurrencyConversion> GetAll(string search)
        {
            var request = await _httpClient.GetAsync($"https://api.mercadolibre.com/currency_conversions/search?from={search}&to=USD");

            return JsonSerializer.Deserialize<CurrencyConversion>(await request.Content.ReadAsStringAsync());
        }
    }
}