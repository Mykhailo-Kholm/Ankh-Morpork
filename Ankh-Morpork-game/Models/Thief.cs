using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Abstract.Interfaces;

namespace Ankh_Morpork_game.Models
{
    class Thief:IThief
    {
        private Guid _id;

        Guid INPC.Id
        {
            get => _id;
            set => _id = Guid.NewGuid();
        }

        public string Name { get; set; }
        public string Speech { get; set; } = "Pay the fee, otherwise you will be robbed next time";

        public Thief(string name)
        {
            Name = name;
        }

        public void TakeFee(Player player) 
        {
            if(player.Choice.ToLower() != "skip" && player.GiveMoney(IThief.DefaultFee))
                Console.WriteLine("You can go");
            else
            {
                player.IsAlive = false;
                Console.WriteLine("You were robbed");
            }

        }

    }
}
