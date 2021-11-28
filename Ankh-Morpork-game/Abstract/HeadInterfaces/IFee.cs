using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game.Abstract.ChildInterfaces
{
    public interface IFee
    {
        void GetFee(Player player);
    }
}
