using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using TemplateApi.Models;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UserController : ControllerBase
    {
        //dependency injection
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        //end of dependency injection

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register(RegUser regUser)
        {
            return Created("User Created: ", _userService.Post(regUser));
        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(_userService.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Search([FromRoute] int id)
        {
            return Ok(_userService.Search(id));
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] UpdateUser updateUser)
        {
            return Ok(_userService.Put(updateUser, id));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _userService.Delete(id);
            return Ok();
        }
    }
}