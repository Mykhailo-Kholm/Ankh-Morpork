using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract.ChildInterfaces;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game.Abstract.Interfaces
{
    interface IThief:INPC,IFee
    {
        const float DefaultFee = 10f;
    }
}
