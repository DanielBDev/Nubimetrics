using Application.DTOs.User;
using Application.ServiceUser;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Challenge1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsuariosController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _userService.GetAll();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _userService.GetById(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] UserDto user)
        {
            var result = await _userService.Insert(user);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UserDto user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            var result = await _userService.Update(user);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _userService.DeleteById(id);
            return Ok(result);
        }
    }
}