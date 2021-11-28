using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Models;
using System.Collections.Generic;

namespace Ankh_Morpork_game.Guilds
{
    class ThievesGuild : IGuild<Thief>
    {
        public List<Thief> GeneratorOfNPC()
        {
            var thieves = new List<Thief>(1);
            thieves.Add(new Thief("Yanukovich"));
            return thieves;
        }
    }
}
