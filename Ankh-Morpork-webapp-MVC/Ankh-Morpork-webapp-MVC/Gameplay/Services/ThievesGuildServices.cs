using System;
using Ankh_Morpork_game.Abstract.HeadInterfaces;
using Ankh_Morpork_game.Guilds;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_game.Gameplay.Services
{
    class ThievesGuildServices:GuildServices<ThievesGuild,Thief>
    {
        public ThievesGuildServices(ThievesGuild guild) : base(guild)
        {
        }
        public override void InteractWithPlayer(Player player)
        {
            if (ThievesGuild.AcceptableNumberOfThefts != 0)
            {
                base.InteractWithPlayer(player);
                ThievesGuild.AcceptableNumberOfThefts--;
            }
        }
    }
}
