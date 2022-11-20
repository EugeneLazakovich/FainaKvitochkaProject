using FainaKvitochka_BL.Interfaces;
using FainaKvitochka_BL.Services.AuthService;
using FainaKvitochka_DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FainaKvitochkaProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuthService _authService;

        public UserController(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _userService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public async Task<User> GetById(Guid id)
        {
            return await _userService.GetByIdUser(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, User user)
        {
            try
            {
                user.Id = id;
                var result = await _userService.UpdateUser(user);

                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(Guid id)
        {
            return await _userService.DeleteByIdUser(id);
        }

        [HttpGet("signin")]
        public async Task<IActionResult> SignIn(string login, string password)
        {
            string token = null;
            try
            {
                token = await _authService.SignIn(login, password);
            }
            catch (ArgumentException)
            {
            }

            return !String.IsNullOrEmpty(token) ? Ok(token) : Unauthorized();
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp(User user)
        {
            try
            {
                var id = await _authService.SignUp(user);
                return Ok(id);
            }
            catch (ArgumentException ex)
            {
                return Unauthorized(ex.Message);
            }
        }
    }
}
