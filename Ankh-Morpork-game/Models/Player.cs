using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork_game.Models
{
    class Player
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
                return true;
            }
            else
            {
                return false;
            }
        }

        public void EarnMoney(float amount)
        {
            AmountOfMoney += amount;
        }
    }
}
