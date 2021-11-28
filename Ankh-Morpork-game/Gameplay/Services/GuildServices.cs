using Ankh_Morpork_game.Abstract.ChildInterfaces;
using Ankh_Morpork_game.Gameplay.Services;
using Ankh_Morpork_game.Models;
using System;

namespace Ankh_Morpork_game.Abstract.HeadInterfaces
{
    public class GuildGuildServices<TGuild,TNpc>:AbstractGuildServices<TGuild,TNpc> where TGuild : IGuild<TNpc>, new() 
                                                                        where TNpc : INPC,IFee
    {
        public override void InteractWithPlayer(Player player)
        {
            TNpc tempNpc = ListOfNPC[Rnd.Next(ListOfNPC.Count)];
            Console.WriteLine(tempNpc.Speech);
            player.Choice = Console.ReadLine();
            tempNpc.GetFee(player);
        }
    }
}
