using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game.Abstract.Interfaces
{
    interface IAssassin:INPC
    {
        float MinReward { get; set; }
        float MaxReward { get; set; }
        bool IsOccupied { get; set; }
        void Kill(Player player);
    }
}
