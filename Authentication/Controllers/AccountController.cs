using Authentication.DTOs.Account;
using Authentication.Models;
using Authentication.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly JWTService _jwtService;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountController(JWTService jwtService, SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _jwtService = jwtService;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        private UserDTO AddUserDTO(User user)
        {
            return new UserDTO(user.FirstName, user.LastName, _jwtService.JWTGenerateToken(user));
        }

        private async Task<bool> CheckEmailExistsAsync(string email)
        {
            return await _userManager.Users.AnyAsync(u => u.Email == email.ToLower());
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            var user = await _userManager.FindByNameAsync(loginDTO.UserName);

            if (user is null)
                return Unauthorized("Invalid username or password.");

            if (!user.EmailConfirmed)
                return Unauthorized("Please confirm your email.");

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDTO.Password, false);


            if (!result.Succeeded)
                return Unauthorized("Invalid username or password.");
            
            return Ok(AddUserDTO(user));
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDTO registerDTO)
        {
            if (await CheckEmailExistsAsync(registerDTO.Email))
                return BadRequest("This email is already used.");

            var userToAdd = new User
            {
                UserName = registerDTO.Email.ToLower(),
                FirstName = registerDTO.FirstName.ToLower(),
                LastName = registerDTO.LastName.ToLower(),
                Email = registerDTO.Email.ToLower(),
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(userToAdd, registerDTO.Password);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok("Your account has been created.");
        }


        [HttpDelete("{username}")]
        public async Task<IActionResult> DeleteUser(string username)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user is null)
                return NotFound("User not found.");

            var result = await _userManager.DeleteAsync(user);

            if (!result.Succeeded)
                return BadRequest("Error deleting user.");

            return Ok("User deleted successfully.");
        }


        [HttpPut("{username}")]
        public async Task<IActionResult> EditUser(string username, [FromBody] EditUserDTO editUserDTO)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user is null)
                return NotFound("User not found.");

            user.FirstName = editUserDTO.FirstName.ToLower();
            user.LastName = editUserDTO.LastName.ToLower();
            user.Email = editUserDTO.Email.ToLower();
            user.UserName = editUserDTO.Email.ToLower();

            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded)
                return BadRequest("Error updating user.");

            return Ok("User updated successfully.");
        }

        [HttpPut("lock/{username}")]
        public async Task<IActionResult> LockUser(string username)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user is null)
                return NotFound("User not found.");

            user.LockoutEnabled = true;

            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded)
                return BadRequest("Error locking user.");

            return Ok("User locked successfully.");
        }
    }
}
