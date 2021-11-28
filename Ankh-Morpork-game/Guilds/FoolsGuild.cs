using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game.Guilds
{
    class FoolsGuild : IGuild<Fool>
    {
        public List<Fool> GeneratorOfNPC()
        {
            var fools = new List<Fool>();
            fools.Add(new Fool("Muggins", 0.5f));
            fools.Add(new Fool("Gull", 1));
            fools.Add(new Fool("Dupe", 2));
            fools.Add(new Fool("Butt", 3));
            fools.Add(new Fool("Fool", 5)); 
            fools.Add(new Fool("Tomfool", 6)); 
            fools.Add(new Fool("Stupid Fool", 7));
            fools.Add(new Fool("Arch Fool", 8));
            fools.Add(new Fool("Complete Fool", 10));
            return fools;
        }
    }
}
