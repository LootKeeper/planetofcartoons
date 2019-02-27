using DataContext.Model.OAuth;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataContext.Repository
{
    public interface IUserRepository
    {
        bool IsUserExist(string login);
        User CreateUser(string login, string password);
    }
}
