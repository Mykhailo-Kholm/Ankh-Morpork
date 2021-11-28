using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
