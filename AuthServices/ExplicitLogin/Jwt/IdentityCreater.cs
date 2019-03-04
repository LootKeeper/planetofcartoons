using DataContext.Model.OAuth;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace AuthServices.ExplicitLogin.Jwt
{
    public class IdentityCreater : IIdentityCreater
    {
        public ClaimsIdentity Create(User user)
        {
            return new ClaimsIdentity(
                this.GetClaims(user.Email, user.Role.RoleType.ToString()),
                "Token",
                ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
        }

        private List<Claim> GetClaims(string userName, string roleType)
        {
            return new List<Claim>()
            {
                this.CreateClaim(ClaimsIdentity.DefaultRoleClaimType, roleType),
                this.CreateClaim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
        }

        private Claim CreateClaim(string type, string value)
        {
            return new Claim(type, value);
        }
    }
}
