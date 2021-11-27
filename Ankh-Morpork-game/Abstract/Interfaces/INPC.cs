using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork_game.Abstract
{
    interface INPC
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}
