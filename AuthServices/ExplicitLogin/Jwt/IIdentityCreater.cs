using DataContext.Model.OAuth;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace AuthServices.ExplicitLogin.Jwt
{
    public interface IIdentityCreater
    {
        ClaimsIdentity Create(User user);
    }
}
