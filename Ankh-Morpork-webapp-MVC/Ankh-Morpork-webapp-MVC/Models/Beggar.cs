using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ankh_Morpork_webapp_MVC.Models
{
    public class Beggar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speech { get; set; }
        public decimal Alms { get; set; }
    }
}