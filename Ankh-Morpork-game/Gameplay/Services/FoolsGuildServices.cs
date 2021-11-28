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
    public class FoolsGuildServices:GuildService
    {
        private FoolsGuild _foolsGuild = new FoolsGuild();
        private List<Fool> _listOfFools;

        public FoolsGuildServices()
        {
            _listOfFools = _foolsGuild.GeneratorOfNPC();
        }


        public override void InteractWithPlayer(Player player)
        {
            Fool tempFool = _listOfFools[rnd.Next(_listOfFools.Count)];
            Console.WriteLine(tempFool.Speech);
            player.Choice = Console.ReadLine();
            tempFool.GiveJob(player);
        }
    }
}
