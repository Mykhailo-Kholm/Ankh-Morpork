using Ankh_Morpork_game.Guilds;
using Ankh_Morpork_webapp_MVC.Models;
using System.Web.Mvc;

namespace Ankh_Morpork_webapp_MVC.Controllers
{
    public class ThievesController : Controller
    {
        private static readonly ThievesGuild Thieves = new ThievesGuild();
        // GET: Thieves
        public ActionResult ThievesIndex()
        {
            if (Player.GetPlayer().AmountOfMoney == 0 || !Player.GetPlayer().IsAlive)
                return RedirectToAction("GameOver", "Game");
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