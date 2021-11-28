using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork_game.Models
{
    public class Player
    {
        public float AmountOfMoney { get; private set; } = 100;
        public bool IsAlive { get; set; } = true;
        public string Name { get; private set; }
        public string Choice { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public bool GiveMoney(float amount)
        {
            if (amount <= AmountOfMoney)
            {
                AmountOfMoney -= amount;
                Console.WriteLine($"You have {AmountOfMoney}");
                return true;
            }
            Console.WriteLine("You are Liar. You don't have this amount");
            IsAlive = false;
            return false;
        }

        public void EarnMoney(float amount)
        {
            AmountOfMoney += amount;
        }
    }
}
