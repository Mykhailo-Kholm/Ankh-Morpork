using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ankh_Morpork_game.Guilds;
using Ankh_Morpork_webapp_MVC.Models;
using Ankh_Morpork_webapp_MVC.ViewModels;

namespace Ankh_Morpork_webapp_MVC.Controllers
{
    public class ThievesController : Controller
    {
        private static readonly ThievesGuild Thieves = new ThievesGuild();
        // GET: Thieves
        public ActionResult ThievesIndex()
        {
            var thief = Thieves.GeneratorOfNPC();
            ThievesGuild.AcceptableNumberOfThefts--;
            return View("ThievesIndex", thief);
        }
        public ActionResult Skip()
        {
            return RedirectToAction("GameOver", "Game");
        }
        public ActionResult Play(int id)
        {
            Thieves.GetNpc(id).GetFee(Player.GetPlayer());
            return RedirectToAction("NextStep", "Game");
        }
    }
}