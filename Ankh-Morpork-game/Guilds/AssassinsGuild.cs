using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game.Guilds
{
    class AssassinsGuild:IGuild<Assassin>
    {
        const string proposition = "Someone wants to kill you. Do you want to stay alive? Let's sign a contract! Enter your amount or skip:";
        public List<Assassin> GeneratorOfNPC()
        {
            var assassins = new List<Assassin>(15);
            var rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                bool isOccupied = rnd.Next(2) == 1;
                assassins.Add(new Assassin($"Assassin {i}", 
                    rnd.Next(1,15),
                    rnd.Next(16,30),
                    isOccupied
                    ));
            }
            return assassins;
        }

        public void CreateContract(Player player, List<Assassin> assassins)
        {
            Console.WriteLine(proposition);
            while (player.AmountOfMoney >= 0 )
            {
                float payment = 0;
                try
                {
                    player.Choice = Console.ReadLine();
                    if (String.Equals(player.Choice.ToLower(), "skip"))
                    {
                        assassins[0].Kill(player);
                        return;
                    }

                    if (float.TryParse(player.Choice, out payment))
                    {
                        bool isKill = false;
                        foreach (var assassin in assassins)
                        {
                            if (!assassin.IsOccupied && assassin.MinReward <= payment && payment <= assassin.MaxReward)
                            {
                                if (player.GiveMoney(payment))
                                {
                                    Console.WriteLine("Contract is created! You can go!");
                                    isKill = false;
                                    break;
                                }
                            }

                            isKill = true;
                        }

                        if (isKill)
                            assassins[0].Kill(player);
                        return;
                    }
                    Console.WriteLine("Please, enter valid answer!(number or \"skip\"");

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
