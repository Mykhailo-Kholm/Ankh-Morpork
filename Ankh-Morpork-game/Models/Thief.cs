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
            bool goNext = false;
            while (!goNext)
            {
                if (player.Choice.ToLower() == "play" && player.GiveMoney(IThief.DefaultFee))
                {
                    Console.WriteLine("You can go!");
                    break;
                }

                if(player.Choice.ToLower() == "skip")
                {
                    player.IsAlive = false;
                    Console.WriteLine("You were robbed");
                    break;
                }
                Console.WriteLine("Please, Enter \"skip\" or \"play\"");
                player.Choice = Console.ReadLine();
            }
        }

    }
}
