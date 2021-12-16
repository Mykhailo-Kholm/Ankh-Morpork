using Ankh_Morpork_game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using Ankh_Morpork_webapp_MVC.Data;
using Ankh_Morpork_webapp_MVC.Data.IRepository;
using Ankh_Morpork_webapp_MVC.Data.Repository;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_game.Guilds
{
    public class AssassinsGuild:IGuild<Assassin>
    {
        public INpcRepo<Assassin> Repository { get; }
        public string Proposition => "Someone wants to kill you. Do you want to stay alive? Let's sign a contract!";

        public AssassinsGuild()
        {
            Repository = new AssassinRepo(SingletonDbContext.GetInstance());
        }
        public Assassin GeneratorOfNPC()
        {
            Random rnd = new Random();
            var assassins = Repository.GetNpcForGuild().ToList();
            var assassin = assassins[rnd.Next(0, assassins.Count)];
            return assassin;
        }

        public string CreateContract(Player player, List<Assassin> assassins)
        {
            decimal payment = 0;
            try
            {
                if (String.Equals(player.Choice.ToLower(), "skip"))
                {
                    assassins[0].Kill(player);
                }

                if (decimal.TryParse(player.Choice, out payment))
                {

                    var freeAssassins = assassins.Where(a => !a.IsOccupied && a.MinReward <= payment && payment <= a.MaxReward);
                    var enumerable = freeAssassins.ToList();
                    if (enumerable.Any())
                    {
                        player.GiveMoney(payment);
                        return $"{enumerable.First().Name} take the contract";
                    }
                    assassins[0].Kill(player);
                    return "No one can take the contract";
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            if(player.AmountOfMoney == 0) assassins[0].Kill(player);
            return "Contract not created";
        }

    }
}
