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
    public class BeggarsGuildServices:GuildService
    {
        private readonly BeggarsGuild _beggarsGuild = new BeggarsGuild();
        private List<Beggar> _listOfBeggars;

        public BeggarsGuildServices()
        {
            _listOfBeggars = _beggarsGuild.GeneratorOfNPC();
        }

        public override void InteractWithPlayer(Player player)
        {
            Beggar tempBeggar = _listOfBeggars[rnd.Next(_listOfBeggars.Count)];
            Console.WriteLine(tempBeggar.Speech);
            player.Choice = Console.ReadLine();
            tempBeggar.TakeAlms(player);
        }
    }
}
