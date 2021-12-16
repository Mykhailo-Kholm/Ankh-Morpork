using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ankh_Morpork_game.Guilds;
using Ankh_Morpork_webapp_MVC.ViewModels;

namespace Ankh_Morpork_webapp_MVC.Controllers
{
    public class AssassinsController : Controller
    {
        private AssassinsGuild _assassins = new AssassinsGuild();
        // GET: Assassins
        public ActionResult AssassinsIndex()
        {
            var assassin = _assassins.GeneratorOfNPC();
            var model = new AssassinsIndexViewModel()
            {
                ImageUrl   = assassin.ImageUrl,
                Message = _assassins.Proposition
            };

            return View(model);
        }

        public ActionResult Contract()
        {
            return View();
        }

        public ActionResult Skip()
        {
            return RedirectToAction("GameOver", "Game");
        }
    }
}