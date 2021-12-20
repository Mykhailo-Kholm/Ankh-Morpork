using Ankh_Morpork_webapp_MVC.Data;
using Ankh_Morpork_webapp_MVC.Data.IRepository;
using Ankh_Morpork_webapp_MVC.Data.Repository;
using Ankh_Morpork_webapp_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ankh_Morpork_game.Guilds
{
    public class AssassinsGuild
    {
        public INpcRepo Repository { get; }
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
            return (Assassin)assassin;
        }

        public bool CreateContract(Player player,decimal payment)
        {
            var assassin = ((IEnumerable<Assassin>) Repository.GetNpcForGuild()).FirstOrDefault(a =>
                    a.MaxReward > payment && payment > a.MinReward && !a.IsOccupied);

            if (assassin != null)
            {
                player.GiveMoney(payment);
                return true;
            }
            Assassin.Kill(player);
            return false;
        }

    }
}
