using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceCurrencyConversion
{
    public interface ICurrencyConversionService
    {
        Task<CurrencyConversion> GetAll(string search);
    }
}