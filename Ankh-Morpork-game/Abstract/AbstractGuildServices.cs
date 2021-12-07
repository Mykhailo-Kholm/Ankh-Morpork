using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Models;
using System;
using System.Collections.Generic;

namespace Ankh_Morpork_game.Gameplay.Services
{
    public abstract class AbstractGuildServices<TGuild,TNpc> where TGuild : IGuild<TNpc>, new()
                                                             where TNpc : INPC
    {
        protected TGuild Guild;
        protected List<TNpc> ListOfNpc;
        protected Random Rnd;

        public AbstractGuildServices()
        {
            Rnd = new Random();
            Guild = new TGuild();
            ListOfNpc = Guild.GeneratorOfNPC();
        }

        public abstract void InteractWithPlayer(Player player);
    }
}
