using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Iudices3.Models;
using Iudices3.DAL;
using Iudices3.Providers.Auth;

namespace Iudices3.Controllers
{
    public class HomeController : Controller
    {
        private JurySQLDAO jurySQLDAO;
        private IAuthProvider authProvider;

        public HomeController(IAuthProvider authProvider, JurySQLDAO jurySQLDAO)
        {
            this.jurySQLDAO = jurySQLDAO;
            this.authProvider = authProvider;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
