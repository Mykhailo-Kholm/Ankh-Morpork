using System;
using Ankh_Morpork_game.Abstract;
using System.Collections.Generic;
using System.Linq;
using Ankh_Morpork_webapp_MVC.Data;
using Ankh_Morpork_webapp_MVC.Data.IRepository;
using Ankh_Morpork_webapp_MVC.Data.Repository;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_game.Guilds
{
    class BeggarsGuild : IGuild<Beggar>
    {
        public INpcRepo Repository { get; }
        private Random rnd = new Random();

        public BeggarsGuild()
        {
            Repository = new BeggarRepo(SingletonDbContext.GetInstance());
        }
        public Beggar GeneratorOfNPC()
        {
            var beggars = ((IEnumerable<Beggar>)Repository.GetNpcForGuild()).ToList();
            int index = rnd.Next(1, beggars.Count);
            return beggars[index];
        }

        public Beggar GetNpc(int id)
        {
            return (Beggar)Repository.GetNpcForGuild().FirstOrDefault(n => n.Id == id);
        }
    }
}
