using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Abstract.ChildInterfaces;

namespace Ankh_Morpork_webapp_MVC.Models
{
    public class Fool : INPC, IFee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [NotMapped]
        public string Speech { get; set; }
        public decimal Salary { get; set; }
        public string ImageUrl { get; set; }
        public void GetFee(Player player)
        {
            if (player.Choice.ToLower() == "play") player.EarnMoney(Salary);
        }
    }
}