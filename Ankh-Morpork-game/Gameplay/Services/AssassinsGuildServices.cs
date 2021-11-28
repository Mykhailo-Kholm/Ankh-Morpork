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
    public class AssassinsGuildServices:GuildService
    {
        private AssassinsGuild _assassinsGuild = new AssassinsGuild();
        private List<Assassin> _listOfAssassins = new List<Assassin>();

        public override void InteractWithPlayer(Player player)
        {
            _listOfAssassins = _assassinsGuild.GeneratorOfNPC();
            Console.WriteLine(_assassinsGuild.proposition);
            player.Choice = Console.ReadLine();
            _assassinsGuild.CreateContract(player,_listOfAssassins);
        }
    }
}
