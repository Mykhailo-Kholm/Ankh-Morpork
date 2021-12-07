using System.Collections.Generic;

namespace Ankh_Morpork_game.Abstract
{
    public interface IGuild<T>
    {
        public List<T> GeneratorOfNPC();
    }
}
