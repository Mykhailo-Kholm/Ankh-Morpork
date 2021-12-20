using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract;

namespace Ankh_Morpork_webapp_MVC.Data.IRepository
{
    public interface INpcRepo
    {
        IEnumerable<INPC> GetNpcForGuild();
    }
}
