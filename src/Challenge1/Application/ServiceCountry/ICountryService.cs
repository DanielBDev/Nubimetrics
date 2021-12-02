using Application.DTOs.Country;
using System.Threading.Tasks;

namespace Application.ServiceCountry
{
    public interface ICountryService
    {
        Task<Country> GetCountry(string country);
    }
}