using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Models;
using System.Collections.Generic;

namespace Ankh_Morpork_game.Guilds
{
    class BeggarsGuild : IGuild<Beggar>
    {
        public List<Beggar> GeneratorOfNPC()
        {
            var beggars = new List<Beggar>(11)
            {
                new("Twitchers ", 3),
                new("Droolers ", 2),
                new("Dribblers ", 1),
                new("Mumblers ", 1),
                new("Mumblers ", 0.9m),
                new("Walking-Along-Shouters", 0.8m),
                new("Demanders of a Chip", 0.6m),
                new("People Who Call Other People Jimmy ", 0.5m),
                new("People Who Need Eightpence For A Meal", 0.08m),
                new("People Who Need Tuppence For A Cup Of Tea", 0.02m),
                new("People With Placards Saying \"Why lie ? I need a beer.\"", 0)
            };
            return beggars;
        }
    }
}
