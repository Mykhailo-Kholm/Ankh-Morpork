using Ankh_Morpork_webapp_MVC.Data;
using Ankh_Morpork_webapp_MVC.Data.IRepository;
using Ankh_Morpork_webapp_MVC.Data.Repository;
using Ankh_Morpork_webapp_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ankh_Morpork_game.Guilds
{
    class FoolsGuild
    {
        public INpcRepo Repository { get; }
        private Random rnd = new Random();
        public FoolsGuild()
        {
            Repository = new FoolRepo(SingletonDbContext.GetInstance());
        }
        public Fool GeneratorOfNPC()
        {
            var fools = ((IEnumerable<Fool>)Repository.GetNpcForGuild()).ToList();
            int index = rnd.Next(1, fools.Count);
            return fools[index];
        }
        public Fool GetNpc(int id)
        {
            return (Fool)Repository.GetNpcForGuild().FirstOrDefault(n => n.Id == id);
        }
    }
}
