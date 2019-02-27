using DataContext.Model.OAuth.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataContext.Model.OAuth
{
    public class OAuthProvider
    {
        public int Id { get; set; }
        public OAuthProviderType ProviderType { get; set; }
    }
}
