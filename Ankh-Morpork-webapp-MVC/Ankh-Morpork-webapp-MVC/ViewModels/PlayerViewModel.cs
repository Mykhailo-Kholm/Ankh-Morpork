using System.ComponentModel.DataAnnotations;

namespace Ankh_Morpork_webapp_MVC.ViewModels
{
    public class PlayerViewModel
    {
        [Required(ErrorMessage = "You must enter a number")]
        [Range(0,30, ErrorMessage = "Enter a number from 0 to 30")]
        public decimal Payment { get; set; }
        public int Beers { get; set; }
    }
}