using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TyresShopAPI.Interfaces;
using TyresShopAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TyresShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IIdentityService _identityService;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IIdentityService identityService)
        {
            _userManager = userManager;
            _identityService = identityService;
            _signInManager = signInManager;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<User>> Register(Register registerModel)
        {
            var isUserExist = await _userManager.FindByEmailAsync(registerModel.Email);

            if (isUserExist is not null)
            {
                return BadRequest($"Username with email {registerModel.Email} already exist");
            }

            var user = new IdentityUser
            {
                Email = registerModel.Email,
                UserName = registerModel.Email
            };

            var result = await _userManager.CreateAsync(user, registerModel.Password);

            if (!result.Succeeded)
            {
                return BadRequest();
            }

            return new User
            {
                Token = _identityService.GenerateToken(user),
                Email = user.Email
            };

        }

        [HttpPost("Login")]
        public async Task<ActionResult<User>> Login(Login loginModel)
        {
            var user = await _userManager.FindByEmailAsync(loginModel.Email);

            if (user is null)
            {
                return Unauthorized();
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginModel.Password, false);

            if (!result.Succeeded)
            {
                return Unauthorized();
            }

            return new User
            {
                Token = _identityService.GenerateToken(user),
                Email = user.Email
            };
        }
    }
}
