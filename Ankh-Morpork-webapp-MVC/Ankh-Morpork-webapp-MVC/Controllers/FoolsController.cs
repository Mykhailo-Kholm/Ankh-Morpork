using Ankh_Morpork_game.Guilds;
using Ankh_Morpork_webapp_MVC.Models;
using System.Web.Mvc;

namespace Ankh_Morpork_webapp_MVC.Controllers
{
    public class FoolsController : Controller
    {
        private static readonly FoolsGuild Fools = new FoolsGuild();
        // GET: Fools
        public ActionResult FoolsIndex()
        {
            if (!Player.GetPlayer().IsAlive)
                return RedirectToAction("GameOver", "Game");
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