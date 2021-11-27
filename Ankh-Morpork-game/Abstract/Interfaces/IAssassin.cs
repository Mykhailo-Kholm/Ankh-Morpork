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
        int MinReward { get; set; }
        int MaxReward { get; set; }
        bool Status { get; set; }
        void Kill(Player player);
    }
}
