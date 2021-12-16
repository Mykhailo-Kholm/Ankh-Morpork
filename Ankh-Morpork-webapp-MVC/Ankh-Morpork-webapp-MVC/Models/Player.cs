using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ankh_Morpork_game;

namespace Ankh_Morpork_webapp_MVC.Models
{
    public class Player
    {
        public int Id { get; set; }
        public decimal AmountOfMoney { get; private set; } = 100;
        public bool IsAlive { get; set; } = true;
        public string Name { get; set; }
        public string Choice { get; set; }
        public int AmountOfBeers { get; set; } = 1;
        public bool IsHaveBeer { get; set; } = true;

        public string MoneyMessage;

        public Player(string name)
        {
            Name = name;
        }

        public void GiveMoney(decimal amount)
        {
            if (amount >= 0 && amount <= AmountOfMoney)
            {
                AmountOfMoney -= amount;
                MoneyMessage = $"You have {MoneyFormatter.FormatMoney(AmountOfMoney)}";
            }

            if (amount < 0)
                return;

            MoneyMessage = "You are Liar. You don't have this amount";
            AmountOfMoney = 0;
            IsAlive = false;
        }

        public void EarnMoney(decimal amount)
        {
            if (amount >= 0)
                AmountOfMoney += amount;
            MoneyMessage = $"You have {MoneyFormatter.FormatMoney(AmountOfMoney)}";
        }

        public bool Buy(int numOfBeers)
        {
            if (numOfBeers > 2 || AmountOfBeers >= 2) return false;
            AmountOfBeers += numOfBeers;
            return true;
        }
    }
}