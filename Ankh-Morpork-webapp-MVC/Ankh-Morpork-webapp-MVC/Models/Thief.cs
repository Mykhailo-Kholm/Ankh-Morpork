using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Abstract.ChildInterfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ankh_Morpork_webapp_MVC.Models
{
    [Table("Thieves")]
    public class Thief : AbstractFee, INPC
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}