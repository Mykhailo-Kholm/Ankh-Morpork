using System;

namespace Ankh_Morpork_game.Models
{
    public class Player
    {
        public decimal AmountOfMoney { get; private set; } = 100;
        public bool IsAlive { get; set; } = true;
        public string Name { get; }
        public string Choice { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public bool GiveMoney(decimal amount)
        {
            if (amount >= 0 && amount <= AmountOfMoney)
            {
                AmountOfMoney -= amount;
                Console.WriteLine($"You have {MoneyFormatter.FormatMoney(AmountOfMoney)}");
                return true;
            }

            if (amount < 0)
                return false;

            Console.WriteLine("You are Liar. You don't have this amount");
            AmountOfMoney = 0;
            IsAlive = false;
            return false;
        }

        public void EarnMoney(decimal amount)
        {
            if (amount >=0)
                AmountOfMoney += amount;
            Console.WriteLine($"You have {MoneyFormatter.FormatMoney(AmountOfMoney)}");
        }
    }
}
