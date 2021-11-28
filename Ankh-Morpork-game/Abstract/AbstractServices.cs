using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Abstract.HeadInterfaces;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game.Gameplay.Services
{
    public abstract class AbstractServices<TGuild,TNpc> where TGuild : IGuild<TNpc>, new()
                                                       where TNpc : INPC  
    {
        protected TGuild Guild;
        protected List<TNpc> ListOfNPC;
        protected Random Rnd;

        public AbstractServices()
        {
            Rnd = new Random();
            Guild = new TGuild();
            ListOfNPC = Guild.GeneratorOfNPC();
        }

        public abstract void InteractWithPlayer(Player player);
    }
}
