using System.Collections.Generic;
using Ankh_Morpork_webapp_MVC.Data.IRepository;

namespace Ankh_Morpork_game.Abstract
{
    public interface IGuild<T>
    {
        INpcRepo Repository { get;}
        T GeneratorOfNPC();
    }
}
