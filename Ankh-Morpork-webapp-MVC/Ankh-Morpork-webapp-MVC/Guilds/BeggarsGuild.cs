using Ankh_Morpork_game.Abstract;
using System.Collections.Generic;
using System.Linq;
using Ankh_Morpork_webapp_MVC.Data.IRepository;
using Ankh_Morpork_webapp_MVC.Data.Repository;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_game.Guilds
{
    class BeggarsGuild : IGuild<Beggar>
    {
        public INpcRepo<Beggar> Repository { get; }

        public BeggarsGuild()
        {
            Repository = new BeggarRepo(NpcContext.GetInstance());
        }
        public Beggar GeneratorOfNPC()
        {
            var beggars = Repository.GetNpcForGuild().ToList();
            return new Beggar();
        }
    }
}
