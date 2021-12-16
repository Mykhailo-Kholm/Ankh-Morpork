using Ankh_Morpork_game.Guilds;
using System;
using System.Linq;
using Ankh_Morpork_webapp_MVC.Data.Repository;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_game.Gameplay.Services
{
    public class AssassinsGuildGuildServices:AbstractGuildServices<AssassinsGuild, Assassin>
    {
        public string ResultOfInteract { get; set; }
        private AssassinRepo _assassinRepo;
        public AssassinsGuildGuildServices(AssassinsGuild guild) : base(guild)
        {
            _assassinRepo = new AssassinRepo(NpcContext.GetInstance());
        }

        public override void InteractWithPlayer(Player player)
        {
            var assassins = _assassinRepo.GetNpcForGuild().ToList();
            Npc = Guild.GeneratorOfNPC();
            player.Choice = Console.ReadLine();
            ResultOfInteract = Guild.CreateContract(player, assassins);
        }
    }
}
 