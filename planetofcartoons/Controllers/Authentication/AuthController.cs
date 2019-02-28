using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthServices.ExplicitLogin;
using AuthServices.Model.Auth;
using DataContext.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using planetofcartoons.ControllersExtend;

namespace planetofcartoons.Controllers.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IUserRepository _userRepository;
        private IAuthService _authService;

        public AuthController(
            IUserRepository userRepository,
            IAuthService authService)
        {
            this._userRepository = userRepository;
            this._authService = authService;
        }

        [HttpPost, AllowAnonymous, Route("login")]        
        public IActionResult Login([FromBody]LoginModel user)
        {
            if (!ModelState.IsValid)
            {
                return this.Json(ModelState.FirstOrDefault().Value.Errors.Select(error => error.ErrorMessage).ToArray());    
            }

             _userRepository.Get(user.Email, user.Password);
            
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult VerifyEmail(string email)
        {
            return new JsonResult(true);
        }
    }
}