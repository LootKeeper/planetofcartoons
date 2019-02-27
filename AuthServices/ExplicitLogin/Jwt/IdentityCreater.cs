using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace AuthServices.ExplicitLogin.Jwt
{
    public class IdentityCreater
    {
        public ClaimsIdentity Create(string login, string role)
        {
            ClaimsIdentity identity = new ClaimsIdentity();


            return identity;
        }
    }
}
