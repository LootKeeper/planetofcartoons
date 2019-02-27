using System;
using System.Collections.Generic;
using System.Text;

namespace DataContext.Model.OAuth
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public byte[] Avatar { get; set; }
        public int Role { get; set; }
    }
}
