using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ankh_Morpork_game;
using Ankh_Morpork_game.Guilds;
using Ankh_Morpork_webapp_MVC.Models;
using Ankh_Morpork_webapp_MVC.ViewModels;

namespace Ankh_Morpork_webapp_MVC.Controllers
{
    public class FoolsController : Controller
    {
        private static readonly FoolsGuild Fools = new FoolsGuild();
        // GET: Fools
        public ActionResult FoolsIndex()
        {
            var fool = Fools.GeneratorOfNPC();
            return View("FoolsIndex", fool);
        }
        public ActionResult Skip()
        {
            return RedirectToAction("NextStep", "Game");
        }
        public ActionResult Play(int id)
        {
            Fools.GetNpc(id).GetFee(Player.GetPlayer());
            return RedirectToAction("NextStep", "Game");
        }
    }
}