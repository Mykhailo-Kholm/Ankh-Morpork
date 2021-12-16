using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ankh_Morpork_webapp_MVC.Controllers
{
    public class BeggarsController : Controller
    {
        // GET: Beggars
        public ActionResult BeggarsIndex()
        {
            return View();
        }
    }
}