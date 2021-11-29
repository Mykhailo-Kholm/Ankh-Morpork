using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Models;
using System.Collections.Generic;

namespace Ankh_Morpork_game.Guilds
{
    class FoolsGuild : IGuild<Fool>
    {
        public List<Fool> GeneratorOfNPC()
        {
            var fools = new List<Fool>(9)
            {
                new("Muggins", 0.5f),
                new("Gull", 1),
                new("Dupe", 2),
                new("Butt", 3),
                new("Fool", 5),
                new("Tomfool", 6),
                new("Stupid Fool", 7),
                new("Arch Fool", 8),
                new("Complete Fool", 10)
            };
            return fools;
        }
    }
}
