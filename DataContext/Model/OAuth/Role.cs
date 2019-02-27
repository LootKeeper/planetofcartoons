using DataContext.Model.OAuth.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataContext.Model.OAuth
{
    public class Role
    {
        public int Id { get; set; }
        public RoleType RoleType { get; set; }
    }
}
