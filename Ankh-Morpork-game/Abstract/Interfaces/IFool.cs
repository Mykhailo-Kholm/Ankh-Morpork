using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game.Abstract.Interfaces
{
    interface IFool : INPC
    {
        double Salary { get; set; }
        void GiveJob(Player player);
    }
}
