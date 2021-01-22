using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ParksApi.Models;
using ParksApi.Services;

namespace ParksApi.Controllers
{
    [Authorize]
        [ApiController]
        [Route("[controller]")]
        public class UsersController : ControllerBase
       {
           private IUserService _userService;
           public UsersController(IUserService userService)
            {
                _userService = userService;
            }

            [AllowAnonymous]
            [HttpPost("authenticate")]
            public IActionResult Authenticate([FromBody]User userParam)
            {
                var user = _userService.Authenticate(userParam.Username, userParam.Password);
                
                if (user == null)
                    return BadRequest(new { message = "Invalid user credentials"});

                return Ok(user);
            }
       }
}
