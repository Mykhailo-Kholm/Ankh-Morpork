using Ankh_Morpork_game.Abstract.HeadInterfaces;
using Ankh_Morpork_game.Gameplay.Services;
using Ankh_Morpork_game.Guilds;
using Ankh_Morpork_game.Models;
using System;

namespace Ankh_Morpork_game.Gameplay
{
    class Game
    {
        private readonly Player _player;
        private readonly AssassinsGuildGuildServices _assassinsGuildGuildServices;
        private readonly GuildGuildServices<BeggarsGuild, Beggar> _beggarsGuildGuildServices;
        private readonly GuildGuildServices<FoolsGuild, Fool> _foolsGuildGuildServices;
        private readonly GuildGuildServices<ThievesGuild, Thief> _thievesGuildGuildServices;


        public Game(string nameOfPlayer)
        {
            _player = new Player(nameOfPlayer);
            _assassinsGuildGuildServices = new AssassinsGuildGuildServices();
            _beggarsGuildGuildServices = new GuildGuildServices<BeggarsGuild, Beggar>();
            _foolsGuildGuildServices = new GuildGuildServices<FoolsGuild, Fool>();
            _thievesGuildGuildServices = new GuildGuildServices<ThievesGuild, Thief>();
        }

        public void GameRules()
        {
            Console.WriteLine(@"Welcome to the fine city of Ankh-Morpork!
 
Ankh-Morpork lies on the River Ankh (the most polluted waterway on the Discworld and reputedly solid enough to walk on), 
where the fertile loam of the Sto Plains meets the Circle Sea. This, naturally, puts it in an excellent trading position.
The central city divides more or less into Ankh (the posh part) and Morpork (the humble part, which includes the slum area known as 'the Shades'), which are separated by the River Ankh.
It can be dangerous to walk the streets. So watch out!
You gets 100 AM$ on balance.
Than randomly you will meet one of the four guilds: Assassins, Thieves, Fools and Beggars.
Player can select an action between 2 options (play or skip) depending on the guild type.
Game is over if the Player got killed, chased to death by the beggar or out of money.
");
        }
        public void StartGame()
        {
            do
            {
                Random rnd = new Random();
                switch (rnd.Next(1,4))
                {
                    case 1: _assassinsGuildGuildServices.InteractWithPlayer(_player);
                        Console.WriteLine("--------------------------------------");
                        break;
                    case 2:
                        _beggarsGuildGuildServices.InteractWithPlayer(_player);
                        Console.WriteLine("--------------------------------------");
                        break;
                    case 3:
                        _foolsGuildGuildServices.InteractWithPlayer(_player);
                        Console.WriteLine("--------------------------------------");
                        break;
                    case 4:
                        _thievesGuildGuildServices.InteractWithPlayer(_player);
                        Console.WriteLine("--------------------------------------");
                        break;
                }

            } while (_player.IsAlive);
        }
        public void EndGame()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game over!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
