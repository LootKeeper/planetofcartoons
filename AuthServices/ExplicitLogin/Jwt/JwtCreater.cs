using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace AuthServices.ExplicitLogin.Jwt
{
    public class JwtCreater
    {
        public JwtSecurityToken Create()
        {
            JwtSecurityToken jwt = new JwtSecurityToken(
                );

            return jwt;
        }
    }
}
