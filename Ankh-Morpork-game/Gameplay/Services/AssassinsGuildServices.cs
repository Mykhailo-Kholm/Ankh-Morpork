using Ankh_Morpork_game.Guilds;
using Ankh_Morpork_game.Models;
using System;

namespace Ankh_Morpork_game.Gameplay.Services
{
    public class AssassinsGuildGuildServices:AbstractGuildServices<AssassinsGuild, Assassin>
    {
        public override void InteractWithPlayer(Player player)
        {
             ListOfNPC = Guild.GeneratorOfNPC();
            Console.WriteLine(Guild.proposition);
            player.Choice = Console.ReadLine();
            Guild.CreateContract(player,ListOfNPC);
        }
    }
}
