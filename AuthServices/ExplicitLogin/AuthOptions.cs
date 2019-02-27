using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServices.ExplicitLogin
{
    public class AuthOptions
    {
        public const string ISSUER = "planetofcartoons24";
        public const int LIFETIME = 1 * 60 * 24; // 1 day
        public static SymmetricSecurityKey GetSymmetricSecurityKey(string privateKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(privateKey));
        }
    }
}
