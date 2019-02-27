using System;
using System.Collections.Generic;
using System.Text;

namespace DataContext.Model.OAuth
{
    public class UserOAuthProvider
    {
        public User User { get; set; }
        public OAuthProvider OAuthProvider { get; set; }
        public string RefreshToken { get; set; }
    }
}
