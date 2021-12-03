using Application.ServiceCurrency;
using Application.ServiceCurrencyConversion;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<ICurrencyService, CurrencyService>();
            services.AddHttpClient<ICurrencyConversionService, CurrencyConversionService>();

            return services;
        }
    }
}