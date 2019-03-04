using DataContext.Model.OAuth;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace AuthServices.ExplicitLogin
{
    public interface IAuthService
    {
        string GetToken(User user);
    }
}
