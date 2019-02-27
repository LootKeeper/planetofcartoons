using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthServices.Model.Auth;
using DataContext.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace planetofcartoons.Controllers.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IUserRepository _userRepository;

        public AuthController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        [HttpPost, AllowAnonymous, Route("login")]        
        public IActionResult Login([FromBody]LoginModel user)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult();
            }
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult VerifyEmail(string email)
        {
            return new JsonResult(true);
        }
    }
}