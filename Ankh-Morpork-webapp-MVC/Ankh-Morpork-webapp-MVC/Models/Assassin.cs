using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Ankh_Morpork_game.Abstract;

namespace Ankh_Morpork_webapp_MVC.Models
{
    public class Assassin : INPC
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public decimal MinReward { get; set; }
        public decimal MaxReward { get; set; }
        public bool IsOccupied { get; set; }
        public string ImageUrl { get; set; }

        public static void Kill(Player player)
        {
            player.IsAlive = false;
        }
    }
}