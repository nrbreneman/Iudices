using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iudices3.DAL;
using Iudices3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Iudices3.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetNumber()
        {
            NumJuror model = new NumJuror();
            return View(model);
        }

        [HttpPost]
        public IActionResult GetNumber(NumJuror model)
        {
            return RedirectToAction("ListPool", model);
        }

        [HttpGet]
        public IActionResult ListPool(NumJuror model)
        {

            int numberOfJurors = model.numberOfJurors;
            JurySQLDAO jurySQLDAO = new JurySQLDAO();
            JuryPool jury = new JuryPool();
            int rows = jurySQLDAO.GetRows();
            RandomID randomID = new RandomID();
            for (int i = 0; i < numberOfJurors; i++)
            {
                Juror juror = new Juror();
                juror = jurySQLDAO.GetJuror(randomID.getRandomID(rows));
                jury.Pool.Add(juror);
            }

            return View(jury);
        }
    }
}