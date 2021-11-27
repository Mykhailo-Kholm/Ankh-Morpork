using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ankh_Morpork_game.Models
{
    class Player
    {
        public float AMountOfMoney { get; private set; } = 100;
        public bool IsAlive { get; set; }
        public string Name { get; private set; }

        public Player(string name)
        {
            Name = name;
        }

        void GiveMoney(float amount)
        {

        }

        void EarnMoney(float amount)
        {

        }
    }
}
