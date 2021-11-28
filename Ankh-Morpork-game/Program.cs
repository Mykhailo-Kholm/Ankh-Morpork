using System;
using Ankh_Morpork_game.Gameplay;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name stranger?");
            string name = Console.ReadLine();
            Game game = new Game(name);
            game.GameRules();
            game.StartGame();
            game.EndGame();
        }
    }
}
