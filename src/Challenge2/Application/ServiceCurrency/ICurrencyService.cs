using Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.ServiceCurrency
{
    public interface ICurrencyService
    {
        Task<List<Currency>> GetCurrency();
    }
}