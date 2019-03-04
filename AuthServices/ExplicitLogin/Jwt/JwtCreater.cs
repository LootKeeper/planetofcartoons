using DataContext.Model.OAuth;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace AuthServices.ExplicitLogin.Jwt
{
    public class JwtCreater : IJwtCreater
    {
        private IIdentityCreater _identityCreater;

        public JwtCreater(IIdentityCreater identityCreater)
        {
            this._identityCreater = identityCreater;
        }

        public string Create(User user, string privateKey)
        {
            var jwt = new JwtSecurityToken(
               issuer: AuthOptions.ISSUER,
               claims: _identityCreater.Create(user).Claims,
               signingCredentials: new Microsoft.IdentityModel.Tokens.SigningCredentials(AuthOptions.GetSymmetricSecurityKey(privateKey), SecurityAlgorithms.HmacSha256)
               );

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}
