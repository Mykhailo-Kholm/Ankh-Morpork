using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_game.Abstract.ChildInterfaces
{
    public abstract class AbstractFee
    {
        public decimal Fee { get; set; } = 10;

        public virtual void GetFee(Player player)
        {
            if (player.AmountOfMoney < Fee)
            {
                player.IsAlive = false;
                player.GiveMoney(player.AmountOfMoney);
                return;
            };
            player.GiveMoney(Fee);
        }
    }
}
