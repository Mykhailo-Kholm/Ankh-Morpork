using Ankh_Morpork_game.Abstract;
using System.Collections.Generic;

namespace Ankh_Morpork_webapp_MVC.Data.IRepository
{
    public interface INpcRepo
    {
        IEnumerable<INPC> GetNpcForGuild();
    }
}
