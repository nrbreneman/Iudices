using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iudices3.Models;

namespace Iudices3.DAL
{
    public interface IUserDAL
    {
        User GetUser(string username);

        void CreateUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);

    }
}
