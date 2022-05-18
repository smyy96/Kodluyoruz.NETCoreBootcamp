using Bionluk.Business;
using Bionluk.DataTransferObjects.Request;
using Bionluk.DataTransferObjects.Responses;
using Bionluk.Entities;
using BionlukAPI.Filters;
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


        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            UserDisplayResponse user = await _userService.GetUser(id);
            return Ok(user);
        }


        [HttpGet("Search/{key}")]
        public async Task<IActionResult> Search(string key)
        {
            var responses = await _userService.GetUserByName(key);
            return Ok(responses);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserRequest user)
        {
            if (ModelState.IsValid)
            {
                int Userid = await _userService.AddUser(user);
                return CreatedAtAction(nameof(GetUsers), routeValues: new { id = Userid }, value: null);
            }

            return BadRequest(ModelState);
        }


        [HttpPut("{id}")]
        [IsExist]
        public async Task<IActionResult> UpdateUser(int id, UpdateUserRequest user)
        {

            if (ModelState.IsValid)
            {
                await _userService.UpdateUser(user);
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        [IsExist]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _userService.DeleteUser(id);
            return Ok();

        }

    }
}
