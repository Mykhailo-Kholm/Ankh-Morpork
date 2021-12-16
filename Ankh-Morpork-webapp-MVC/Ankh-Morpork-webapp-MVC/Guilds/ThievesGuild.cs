using Ankh_Morpork_game.Abstract;
using System.Collections.Generic;
using System.Linq;
using Ankh_Morpork_webapp_MVC.Data;
using Ankh_Morpork_webapp_MVC.Data.IRepository;
using Ankh_Morpork_webapp_MVC.Data.Repository;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_game.Guilds
{
    class ThievesGuild : IGuild<Thief>
    {
        public INpcRepo<Thief> Repository { get; }
        public static int AcceptableNumberOfThefts { get; internal set; } = 6;

        public ThievesGuild()
        {
            Repository = new ThiefRepo(SingletonDbContext.GetInstance());
        }
        public Thief GeneratorOfNPC()
        {
            var thieves = Repository.GetNpcForGuild().ToList();
            return new Thief();
        }
    }
}
