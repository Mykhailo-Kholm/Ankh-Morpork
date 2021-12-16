using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ankh_Morpork_webapp_MVC.Data.Resources;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_webapp_MVC.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RandomNpc()
        {
            Random rnd = new Random();
            switch (rnd.Next(1,5))
            {
                case 1:
                    return RedirectToAction("AssassinsIndex", "Assassins");
                case 2:
                    return RedirectToAction("BeggarsIndex", "Beggars");
                case 3:
                    return RedirectToAction("FoolsIndex", "Fools");
                default:
                    return RedirectToAction("ThievesINdex", "Thieves");
            }
        }

        public ActionResult GameOver()
        {
            return View("GameOver");
        }

        public ActionResult NextStep()
        {
            return View();
        }
    }
}