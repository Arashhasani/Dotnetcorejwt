using JwtPrpject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;

namespace JwtPrpject.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IJwtService _ijwtservice;
        private readonly IConfiguration _iconfiguration;
        public UserController(IUserService userService , IJwtService jwtService, IConfiguration iconfiguration )
        {
            _userService = userService;
            _ijwtservice = jwtService;
            _iconfiguration = iconfiguration;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<string> Token([FromForm] String email , [FromForm] String password,CancellationToken cancellationToken)
        {
            var user= _userService.getUserByUsernameAndPass(email, password);
            if (user == null)
            {
                return "this user not found ...";
            }
            else
            {
                

             
                var jwt = _ijwtservice.Generate(user);
                return jwt;
            }

        }


        [HttpGet]
        public JsonResult GetUsers()
        {
            return new JsonResult(_userService.GetUsers());

        }



        [HttpGet]
        [Route("userr")]
        [Authorize]
        public JsonResult getUserInfo()
        {
            var g= new Guid(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var user = _userService.getCurrentUserInfo(g);
            return  new JsonResult(user);

        }

    }
}
