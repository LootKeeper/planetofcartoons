using DataContext.Model.OAuth;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace AuthServices.ExplicitLogin.Jwt
{
    public interface IJwtCreater
    {
        string Create(User user, string privateKey);
    }
}
