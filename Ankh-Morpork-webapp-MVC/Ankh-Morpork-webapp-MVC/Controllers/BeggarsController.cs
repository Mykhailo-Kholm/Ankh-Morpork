using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ankh_Morpork_game;
using Ankh_Morpork_game.Guilds;
using Ankh_Morpork_webapp_MVC.Models;
using Ankh_Morpork_webapp_MVC.ViewModels;

namespace Ankh_Morpork_webapp_MVC.Controllers
{
    public class BeggarsController : Controller
    {
        readonly BeggarsGuild _beggars = new BeggarsGuild();
        // GET: Beggars
        public ActionResult BeggarsIndex()
        {
            var _beggar = _beggars.GeneratorOfNPC();
            return View("BeggarsIndex",_beggar);
        }
        public ActionResult Skip()
        {
            return RedirectToAction("GameOver", "Game");
        }
        public ActionResult Play(int id)
        {
            if (_beggars.GetNpc(id).Fee == 0)
                Player.GetPlayer().AmountOfBeers--;
            else
            {
                _beggars.GetNpc(id).GetFee(Player.GetPlayer());
            }
            return RedirectToAction("NextStep", "Game");
        }
    }
}