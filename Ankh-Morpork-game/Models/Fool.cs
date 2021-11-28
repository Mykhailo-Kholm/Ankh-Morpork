using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Abstract.Interfaces;
using System;

namespace Ankh_Morpork_game.Models
{
    public class Fool:IFool
    {
        private Guid _id;

        Guid INPC.Id
        {
            get => _id;
            set => _id = Guid.NewGuid();
        }

        public string Name { get; set; }
        public string Speech { get; set; }
        public float Salary { get; set; }

        public Fool(string name, float salary)
        {
            Name = name;
            Salary = salary;
            Speech = $@"Hi, my friend! Do you want to earn {Salary} $?";
        }
        public void GetFee(Player player)
        {
            bool goNext = false;
            while (!goNext)
            {
                if (player.Choice.ToLower() == "play")
                {
                    player.EarnMoney(Salary);
                    break;
                }
                if (player.Choice.ToLower() == "skip")
                {
                    Console.WriteLine("See you later!");
                    break;
                }
                Console.WriteLine("Please, Enter \"skip\" or \"play\"");
                player.Choice = Console.ReadLine();
            }

        }
    }
}
