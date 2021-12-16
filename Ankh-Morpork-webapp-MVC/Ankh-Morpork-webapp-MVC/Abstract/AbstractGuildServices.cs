using Ankh_Morpork_game.Abstract;
using System;
using System.Collections.Generic;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_game.Gameplay.Services
{
    public abstract class AbstractGuildServices<TGuild,TNpc> where TGuild : IGuild<TNpc>
                                                             where TNpc : INPC
    {
        protected TGuild Guild;
        protected TNpc Npc;
        protected Random Rnd;

        public AbstractGuildServices(TGuild guild)
        {
            Rnd = new Random();
            Guild = guild;
            Npc = Guild.GeneratorOfNPC();
        }

        public abstract void InteractWithPlayer(Player player);
    }
}
