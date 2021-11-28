﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract.HeadInterfaces;
using Ankh_Morpork_game.Gameplay.Services;
using Ankh_Morpork_game.Guilds;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game.Gameplay
{
    class Game
    {
        private readonly Player _player;
        private readonly AssassinsGuildServices _assassinsGuildServices;
        private readonly GuildServices<BeggarsGuild, Beggar> _beggarsGuildServices;
        private readonly GuildServices<FoolsGuild, Fool> _foolsGuildServices;
        private readonly GuildServices<ThievesGuild, Thief> _thievesGuildServices;


        public Game(string nameOfPlayer)
        {
            _player = new Player(nameOfPlayer);
            _assassinsGuildServices = new AssassinsGuildServices();
            _beggarsGuildServices = new GuildServices<BeggarsGuild, Beggar>();
            _foolsGuildServices = new GuildServices<FoolsGuild, Fool>();
            _thievesGuildServices = new GuildServices<ThievesGuild, Thief>();
        }

        public void GameRules()
        {
            Console.WriteLine(@"Welcome to the fine city of Ankh-Morpork!
 
Ankh-Morpork lies on the River Ankh (the most polluted waterway on the Discworld and reputedly solid enough to walk on), 
where the fertile loam of the Sto Plains meets the Circle Sea. This, naturally, puts it in an excellent trading position.
The central city divides more or less into Ankh (the posh part) and Morpork (the humble part, which includes the slum area known as 'the Shades'), which are separated by the River Ankh.
It can be dangerous to walk the streets. So watch out!
You gets 100 AM$ on balance.
Than randomly you will meet one of the four guilds over and over again.
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
                    case 1: _assassinsGuildServices.InteractWithPlayer(_player);
                        Console.WriteLine("--------------------------------------");
                        break;
                    case 2:
                        _beggarsGuildServices.InteractWithPlayer(_player);
                        Console.WriteLine("--------------------------------------");
                        break;
                    case 3:
                        _foolsGuildServices.InteractWithPlayer(_player);
                        Console.WriteLine("--------------------------------------");
                        break;
                    case 4:
                        _thievesGuildServices.InteractWithPlayer(_player);
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