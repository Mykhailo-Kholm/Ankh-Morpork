using Ankh_Morpork_game.Abstract;
using System.Collections.Generic;
using System.Linq;
using Ankh_Morpork_webapp_MVC.Data.IRepository;
using Ankh_Morpork_webapp_MVC.Data.Repository;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_game.Guilds
{
    class FoolsGuild : IGuild<Fool>
    {
        public INpcRepo<Fool> Repository { get; }

        public FoolsGuild()
        {
            Repository = new FoolRepo(NpcContext.GetInstance());
        }
        public Fool GeneratorOfNPC()
        {
            var fools = Repository.GetNpcForGuild().ToList();
            return new Fool();
        }
    }
}
