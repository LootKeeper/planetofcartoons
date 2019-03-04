using DataContext.Model.OAuth;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataContext.Repository
{
    public interface IUserRepository
    {
        bool IsLoginExist(string login);
        bool IsValid(string login, string password);
        User Get(string login, string password);
        User Create(string login, string password);
    }
}
