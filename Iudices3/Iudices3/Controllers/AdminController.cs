using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iudices3.Providers.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Iudices3.Controllers
{
    public class AdminController : Controller
    {
        [AuthorizationFilter("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}