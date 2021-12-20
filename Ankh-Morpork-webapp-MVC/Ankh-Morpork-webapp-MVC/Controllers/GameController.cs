using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ankh_Morpork_game.Guilds;
using Ankh_Morpork_webapp_MVC.Data.Resources;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_webapp_MVC.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
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
                    return ThievesGuild.AcceptableNumberOfThefts != 0
                        ? RedirectToAction("ThievesINdex", "Thieves")
                        : RedirectToAction("RandomNpc", "Game");
            }
        }

        public ActionResult GameOver()
        {
            return View("GameOver");
        }

        public ActionResult NextStep()
        {
            return View("NextStep");
        }

        public ActionResult Bar()
        {
            return RedirectToAction("BarIndex", "MendedDrum");
        }

        public ActionResult Restart()
        {
            Player.GetPlayer().AmountOfBeers = 1;
            Player.GetPlayer().AmountOfMoney = 100;
            Player.GetPlayer().IsAlive = true;
            return RedirectToAction("Index");
        }
    }
}