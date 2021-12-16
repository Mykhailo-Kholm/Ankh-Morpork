using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Abstract.ChildInterfaces;

namespace Ankh_Morpork_webapp_MVC.Models
{
    [Table("Thieves")]
    public class Thief : INPC, IFee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [NotMapped]
        public string Speech { get; set; }

        public decimal Fee { get; set; } = 10;
        public string ImageUrl { get; set; }
        public void GetFee(Player player)
        {
            if (player.Choice.ToLower() == "play") player.GiveMoney(Fee);
            if (player.Choice.ToLower() == "skip" || player.AmountOfMoney < Fee)
            {
                player.GiveMoney(player.AmountOfMoney);
                player.IsAlive = false;
            }
        }
    }
}