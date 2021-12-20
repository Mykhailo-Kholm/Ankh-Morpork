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
    public class AssassinsController : Controller
    {
        private readonly AssassinsGuild _assassins = new AssassinsGuild();
        // GET: Assassins
        public ActionResult AssassinsIndex()
        {
            if (Player.GetPlayer().AmountOfMoney == 0 || !Player.GetPlayer().IsAlive)
                return RedirectToAction("GameOver", "Game");
            var assassin = _assassins.GeneratorOfNPC();
            var model = new MessageViewModel()
            {
                Money = Player.GetPlayer().MoneyMessage,
                Beers = Player.GetPlayer().AmountOfBeers,
                ImageUrl   = assassin.ImageUrl,
                Message = _assassins.Proposition
            };
            return View("AssassinsIndex",model);
        }

        public ActionResult Contract()
        {
            return View("Contract");
        }

        public ActionResult Skip()
        {
            return RedirectToAction("GameOver", "Game");
        }

        [HttpPost]
        public ActionResult SignContract(PlayerViewModel player)
        {
            if (!ModelState.IsValid)
            {
                return View("Contract", player);
            }
            bool isMadeContract = _assassins.CreateContract(Player.GetPlayer(), player.Payment);
            if (isMadeContract)
            {
                return RedirectToAction("NextStep", "Game");
            }
            return RedirectToAction("GameOver", "Game");
        }
    }
}