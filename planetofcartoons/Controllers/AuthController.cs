using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using AuthServices.ExplicitLogin;
using AuthServices.Model.Auth;
using DataContext.Model.OAuth;
using DataContext.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using planetofcartoons.ControllersExtend;

namespace planetofcartoons.Controllers
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

        [HttpPost, AllowAnonymous, Route("Login")]        
        public IActionResult Login([FromBody]LoginModel loginModel)
        {
            if (!_userRepository.IsLoginExist(loginModel.Email))
            {
                return new UnauthorizedResult();
            }

            if(!_userRepository.IsValid(loginModel.Email, loginModel.Password))
            {
                return new UnauthorizedResult();
            }

            User user = _userRepository.Get(loginModel.Email, loginModel.Password);
            string token = _authService.GetToken(user);
            return this.TokenResult(token, user.Email);
        }

        [HttpPost, AllowAnonymous, Route("registration")]
        public IActionResult Registration([FromBody]RegistrationModel registrationModel)
        {
            if (!_userRepository.IsLoginExist(registrationModel.Email))
            {
                return new BadRequestResult();
            }

            User user = _userRepository.Create(registrationModel.Email, registrationModel.Password);
            string token = _authService.GetToken(user);
            return this.TokenResult(token, user.Email);
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult VerifyEmail(string email)
        {
            return new JsonResult(true);
        }

        private JsonResult TokenResult(string token, string userName)
        {
            return this.Json(new { accessToken = token, userName = userName });
        }
    }
}