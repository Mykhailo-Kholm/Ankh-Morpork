using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ankh_Morpork_webapp_MVC.ViewModels
{
    public class PlayerViewModel
    {
        public decimal Payment { get; set; }
        public string Name { get; set; }
        public decimal Money { get; set; }
        public int NumberOfBeers { get; set; }
    }
}