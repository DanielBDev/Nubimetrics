using Application.ServiceCountry;
using Application.ServiceSearch;
using Application.ServiceUser;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddHttpClient<ICountryService, CountryService>();
            services.AddHttpClient<ISearchService, SearchService>();
            services.AddTransient<IUserService, UserService>();

            return services;
        }
    }
}