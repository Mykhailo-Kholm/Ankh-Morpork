using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Models;
using System.Collections.Generic;

namespace Ankh_Morpork_game.Guilds
{
    class ThievesGuild : IGuild<Thief>
    {
        public static int AcceptableNumberOfThefts = 6;
        public List<Thief> GeneratorOfNPC()
        {
            var thieves = new List<Thief>(1)
            {
                new("Yanukovich")
            };
            return thieves;
        }
    }
}
