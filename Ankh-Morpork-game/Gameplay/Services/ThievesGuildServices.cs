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
    public class ThievesGuildServices:GuildService
    {
        private ThievesGuild _thievesGuild = new ThievesGuild();
        private List<Thief> _listOThieves;
        public ThievesGuildServices()
        {
            _listOThieves = _thievesGuild.GeneratorOfNPC();
        }
        public override void InteractWithPlayer(Player player)
        {
            Thief tempThief = _listOThieves[0];
            Console.WriteLine(tempThief.Speech);
            player.Choice = Console.ReadLine();
            tempThief.TakeFee(player);
        }
    }
}
