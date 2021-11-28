using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Abstract.Interfaces;

namespace Ankh_Morpork_game.Models
{
    class Fool:IFool
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
            Speech = $@"Hi, my friend! Do you want to earn {Salary} $?";
            Salary = salary;
        }
        public void GiveJob(Player player)
        {
            if (player.Choice.ToLower() != "skip")
            {
                player.EarnMoney(Salary);
            }
            else
            {
                Console.WriteLine("See you later!");
            }
        }
    }
}
