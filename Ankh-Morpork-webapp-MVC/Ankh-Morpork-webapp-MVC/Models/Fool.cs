using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Abstract.ChildInterfaces;
using System.ComponentModel.DataAnnotations;

namespace Ankh_Morpork_webapp_MVC.Models
{
    public class Fool : AbstractFee, INPC
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public override void GetFee(Player player)
        {
            player.EarnMoney(Fee);
        }
    }
}