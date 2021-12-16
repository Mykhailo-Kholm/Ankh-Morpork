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
            var model = new MeetingNpcViewModel()
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

        [HttpPost]
        public ActionResult SignContract(PlayerViewModel player)
        {
            var assassin = _assassins.Repository.GetNpcForGuild()
                .First(a => a.MaxReward > player.Payment && a.MinReward < player.Payment);
            _assassins.CreateContract()
            return RedirectToAction("NextStep", "Game");
        }
    }
}