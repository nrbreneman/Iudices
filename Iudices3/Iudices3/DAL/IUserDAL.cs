using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iudices3.Models;

namespace Iudices3.DAL
{
    interface IUserDAL
    {
        User GetUser(string username);

        void CreateUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);

        List<User> GetAllUnapprovedUsers();

        User GetUserTemp(string username);

        void DeleteUserTemp(User user);

        void AdminApproveUser(User user);
    }
}
