using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ankh_Morpork_webapp_MVC.Controllers
{
    public class FoolsController : Controller
    {
        // GET: Fools
        public ActionResult FoolsIndex()
        {
            return View();
        }
    }
}