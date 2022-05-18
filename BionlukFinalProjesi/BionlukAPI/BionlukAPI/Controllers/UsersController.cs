using Bionluk.Business;
using Bionluk.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BionlukAPI.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userService.GetUsers(); 
            return Ok(users);
        }
    }
}
