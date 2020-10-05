using Iudices3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iudices3.DAL
{
    interface IAdminDAL
    {
        void CreateUser(User user);

        void CreateAdmin(User user);

        void DeleteUser(User user);

        void CreateJuror(Juror juror);

        void UpdateJuror(Juror juror);

        void DeleteJuror(Juror juror);
    }
}
