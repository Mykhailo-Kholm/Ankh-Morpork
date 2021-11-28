using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork_game.Abstract
{
    interface INPC
    {
        protected Guid Id { get; set; }
        string Name { get; set; }
        string Speech { get; set; }
    }
}
