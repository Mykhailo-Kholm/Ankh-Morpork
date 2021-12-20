using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ankh_Morpork_webapp_MVC.Models;
using Ankh_Morpork_webapp_MVC.ViewModels;

namespace Ankh_Morpork_webapp_MVC.Controllers
{
    public class MendedDrumController : Controller
    {
        // GET: Bar
        public ActionResult BarIndex()
        {
            return View("BarIndex");
        }

        [HttpPost]
        public ActionResult Buy(Bar bar)
        {
            Player.GetPlayer().Buy(bar.NumOfBeers, bar.Price);
            return RedirectToAction("NextStep", "Game");
        }
    }
}