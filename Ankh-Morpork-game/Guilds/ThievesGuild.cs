using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Models;

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
