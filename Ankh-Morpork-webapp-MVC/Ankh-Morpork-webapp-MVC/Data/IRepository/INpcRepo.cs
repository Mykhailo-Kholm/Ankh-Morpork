using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork_webapp_MVC.Data.IRepository
{
    public interface INpcRepo<T>
    {
        IEnumerable<T> GetNpcForGuild();
    }
}
