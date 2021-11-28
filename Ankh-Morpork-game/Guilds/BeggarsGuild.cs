using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game.Guilds
{
    class BeggarsGuild : IGuild<Beggar>
    {
        public List<Beggar> GeneratorOfNPC()
        {
            var beggars = new List<Beggar>();
            beggars.Add(new Beggar("Twitchers ", 3));
            beggars.Add(new Beggar("Droolers ", 2));
            beggars.Add(new Beggar("Dribblers ", 1)); 
            beggars.Add(new Beggar("Mumblers ", 1));
            beggars.Add(new Beggar("Mumblers ", 0.9f));
            beggars.Add(new Beggar("Walking-Along-Shouters", 0.8f));
            beggars.Add(new Beggar("Demanders of a Chip", 0.6f));
            beggars.Add(new Beggar("People Who Call Other People Jimmy ", 0.5f));
            beggars.Add(new Beggar("People Who Need Eightpence For A Meal", 0.08f));
            beggars.Add(new Beggar("People Who Need Tuppence For A Cup Of Tea", 0.02f));
            beggars.Add(new Beggar("People With Placards Saying \"Why lie ? I need a beer.\"", 0));
            return beggars;
        }
    }
}
