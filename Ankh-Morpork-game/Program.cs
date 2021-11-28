using System;
using Ankh_Morpork_game.Gameplay;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("What is your name stranger?");
            string name = Console.ReadLine();
            game.StartGame(name);
            game.EndGame();
        }
    }
}
