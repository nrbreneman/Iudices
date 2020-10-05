using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iudices3.Models;
using Iudices3.Providers.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Iudices3.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [AuthorizationFilter("User")]
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [AuthorizationFilter("User")]
        [HttpPost]
        public IActionResult Update(User user)
        {
            return View();
        }
    }
}