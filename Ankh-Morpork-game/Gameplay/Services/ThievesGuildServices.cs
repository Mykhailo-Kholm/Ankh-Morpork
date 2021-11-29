using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract.HeadInterfaces;
using Ankh_Morpork_game.Guilds;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game.Gameplay.Services
{
    class ThievesGuildServices:GuildServices<ThievesGuild,Thief>
    {
        public override void InteractWithPlayer(Player player)
        {
            if (ThievesGuild.AcceptableNumberOfThefts != 0)
            {
                Thief tempNpc = ListOfNPC[Rnd.Next(ListOfNPC.Count)];
                Console.WriteLine(tempNpc.Speech);
                player.Choice = Console.ReadLine();
                tempNpc.GetFee(player);
                ThievesGuild.AcceptableNumberOfThefts--;
                Console.WriteLine();
            }
        }
    }
}
