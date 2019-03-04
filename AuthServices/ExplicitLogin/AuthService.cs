using AuthServices.ExplicitLogin.Jwt;
using DataContext.Model.OAuth;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace AuthServices.ExplicitLogin
{
    public class AuthService : IAuthService
    {
        private IConfiguration _configuration;
        private IJwtCreater _jwtCreater;

        public AuthService(IConfiguration configuration, IJwtCreater jwtCreater)
        {
            this._configuration = configuration;
            this._jwtCreater = jwtCreater;
        }

        public string GetToken(User user)
        {
            return this._jwtCreater.Create(user, _configuration["JwtKey"]);
        }
    }
}
