using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game.Abstract.Interfaces
{
    interface IThief
    {
        const int DefaultFee = 10;
        void TakeFee(Player player);
    }
}
