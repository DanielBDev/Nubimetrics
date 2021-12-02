using Application.ServiceSearch;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Challenge1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusquedaController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public BusquedaController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string product)
        {
            var result = await _searchService.Search(product);

            return Ok(result);
        }
    }
}