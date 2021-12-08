using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ankh_Morpork_game.Guilds
{
    public class AssassinsGuild:IGuild<Assassin>
    {
        public string Proposition { get; private set; } = "Someone wants to kill you. Do you want to stay alive? Let's sign a contract! Enter your amount or skip:";
        public List<Assassin> GeneratorOfNPC()
        {
            var assassins = new List<Assassin>(15);
            var rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                bool isOccupied = rnd.Next(2) == 1;
                assassins.Add(new Assassin($"Assassin {i}", 
                    rnd.Next(7,15),
                    rnd.Next(16,30),
                    isOccupied
                    ));
            }
            return assassins;
        }

        public void CreateContract(Player player, List<Assassin> assassins)
        {
            while (player.AmountOfMoney >= 0 )
            {
                decimal payment = 0;
                try
                {
                    if (String.Equals(player.Choice.ToLower(), "skip"))
                    {
                        assassins[0].Kill(player);
                        return;
                    }

                    if (decimal.TryParse(player.Choice, out payment))
                    {

                        var freeAssassins = assassins.Where(a => !a.IsOccupied && a.MinReward <= payment && payment <= a.MaxReward);
                        var enumerable = freeAssassins.ToList();
                        if (enumerable.Any() && player.GiveMoney(payment)) 
                        { 
                            Console.WriteLine($"{enumerable.First().Name} take the contract");
                            return;
                        }
                        Console.WriteLine("No one can take the contract");
                        assassins[0].Kill(player);
                        return;
                    }
                    Console.WriteLine("Please, enter valid answer!(number or \"skip\"");
                    player.Choice = Console.ReadLine();
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            assassins[0].Kill(player);
        }

    }
}
