using Microsoft.AspNetCore.Mvc;
using Services;
using TemplateApi.Models;

namespace TemplateApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] UserLogin userLogin)
        {
            return Ok(_userService.Login(userLogin));
        }
    }
}