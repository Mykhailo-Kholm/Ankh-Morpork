using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Gameplay.Services;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game.Gameplay
{
    class Game
    {
        private Player player;
        private AssassinsGuildServices assassinsGuildServices = new AssassinsGuildServices();
        private BeggarsGuildServices beggarsGuildServices = new BeggarsGuildServices();
        private FoolsGuildServices foolsGuildServices = new FoolsGuildServices();
        private ThievesGuildServices thievesGuildServices = new ThievesGuildServices();

        public void StartGame(string nameOfPlayer)
        {
            player = new Player(nameOfPlayer);

            do
            {
                Random rnd = new Random();
                switch (rnd.Next(1,4))
                {
                    case 1: assassinsGuildServices.InteractWithPlayer(player);
                        break;
                    case 2:
                        beggarsGuildServices.InteractWithPlayer(player);
                        break;
                    case 3:
                        foolsGuildServices.InteractWithPlayer(player);
                        break;
                    case 4:
                        thievesGuildServices.InteractWithPlayer(player);
                        break;
                }

            } while (player.IsAlive);
        }
        public void EndGame()
        {
            Console.WriteLine("Game over!");
        }
    }
}
