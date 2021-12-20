using Ankh_Morpork_webapp_MVC.Data;
using Ankh_Morpork_webapp_MVC.Data.IRepository;
using Ankh_Morpork_webapp_MVC.Data.Repository;
using Ankh_Morpork_webapp_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ankh_Morpork_game.Guilds
{
    class ThievesGuild
    {
        public INpcRepo Repository { get; }
        private Random rnd = new Random();
        public static int AcceptableNumberOfThefts { get; internal set; } = 6;

        public ThievesGuild()
        {
            Repository = new ThiefRepo(SingletonDbContext.GetInstance());
        }
        public Thief GeneratorOfNPC()
        {
            var thieves = ((IEnumerable<Thief>)Repository.GetNpcForGuild()).ToList();
            int index = rnd.Next(1, thieves.Count);
            return thieves[index];
        }
        public Thief GetNpc(int id)
        {
            return (Thief)Repository.GetNpcForGuild().FirstOrDefault(n => n.Id == id);
        }
    }
}
