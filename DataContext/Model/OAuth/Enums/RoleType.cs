using System;
using System.Collections.Generic;
using System.Text;

namespace DataContext.Model.OAuth.Enums
{
    [Flags]
    public enum RoleType
    {
        User = 0,
        Admin = 2
    }
}
