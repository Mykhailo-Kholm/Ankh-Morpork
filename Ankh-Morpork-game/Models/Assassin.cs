using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Abstract.Interfaces;

namespace Ankh_Morpork_game.Models
{
    class Assassin : INPC, IAssassin
    {
        public (int, int) rewardRange { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
