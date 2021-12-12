using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ankh_Morpork_webapp_MVC.Models
{
    public class Player
    {
        public decimal AmountOfMoney { get; private set; } = 100;
        public bool IsAlive { get; set; } = true;
        public string Name { get; set; }
        public string Choice { get; set; }
    }
}