using Microsoft.AspNetCore.Mvc;
using SpaceYaTech.BusinessLayerLogic.Dtos;
using SpaceYaTech.BusinessLayerLogic.Interfaces;

namespace SpaceYaTech.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser([FromBody] UserDto user)
        {
            await _userService.AddUserAsync(user);
            return Ok();
        }
    }
}