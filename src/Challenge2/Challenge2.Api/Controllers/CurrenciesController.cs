using Application.ServiceCurrency;
using Application.ServiceCurrencyConversion;
using Challenge2.Api.Utilities.CSV;
using Challenge2.Api.Utilities.JSON;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        private readonly ICurrencyService _currencyService;
        private readonly ICurrencyConversionService _currencyConversionService;
        private readonly IJsonConvert _jsonConvert;
        private readonly ICSVConvert _cSVConvert;

        public CurrenciesController
            (ICurrencyService currencyService,
            ICurrencyConversionService currencyConversionService,
            IJsonConvert jsonConvert,
            ICSVConvert cSVConvert)
        {
            _currencyService = currencyService;
            _currencyConversionService = currencyConversionService;
            _jsonConvert = jsonConvert;
            _cSVConvert = cSVConvert;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _currencyService.GetCurrency();

            foreach (var currency in result)
            {
                currency.todolar = await _currencyConversionService.GetAll(currency.id);
            }

            _jsonConvert.Convert(result);

            var convert = result.Select(x => x.todolar).Select(x => x.ratio).ToList();

            _cSVConvert.Convert(convert);

            return Ok(result);
        }
    }
}