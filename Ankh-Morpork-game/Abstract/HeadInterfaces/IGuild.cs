using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract.Interfaces;

namespace Ankh_Morpork_game.Abstract
{
    interface IGuild<T>
    {
        List<T> GeneratorOfNPC();
    }
}
