using Ankh_Morpork_game.Abstract.ChildInterfaces;
using Ankh_Morpork_game.Gameplay.Services;
using System;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_game.Abstract.HeadInterfaces
{
    public class GuildServices<TGuild, TNpc> : AbstractGuildServices<TGuild, TNpc> where TGuild : IGuild<TNpc>, new()
                                                                                where TNpc : INPC,IFee
    {
        public GuildServices(TGuild guild) : base(guild)
        {
        }
        public override void InteractWithPlayer(Player player)
        {
            TNpc tempNpc = Npc;
            Console.WriteLine(tempNpc.Speech);
            player.Choice = Console.ReadLine();
            tempNpc.GetFee(player);
        }
    }
}
