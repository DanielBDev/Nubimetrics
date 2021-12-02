using Application.ServiceCountry;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Challenge1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public PaisesController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string country)
        {
            if (country.ToUpper() == "BR" || country.ToUpper() == "CO")
            {
                return Unauthorized();
            }

            var result = await _countryService.GetCountry(country);

            return Ok(result);
        }
    }
}