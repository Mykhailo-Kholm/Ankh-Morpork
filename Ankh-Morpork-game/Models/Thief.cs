using Ankh_Morpork_game.Abstract;
using System;
using Ankh_Morpork_game.Abstract.ChildInterfaces;

namespace Ankh_Morpork_game.Models
{
    public class Thief:INPC, IFee
    {
        private Guid _id;

        Guid INPC.Id
        {
            get => _id;
            set => _id = Guid.NewGuid();
        }

        public string Name { get; set; }
        public string Speech { get; set; } = "Pay the fee - 10 bucks, otherwise you will be robbed next time";
        public const decimal DefaultFee  = 10;

        public Thief(string name)
        {
            Name = name;
        }

        public void GetFee(Player player) 
        {
            bool goNext = false;
            while (!goNext)
            {
                if (player.Choice.ToLower() == "play" && player.GiveMoney(DefaultFee))
                {
                    Console.WriteLine("You can go!");
                    break;
                }

                if(player.Choice.ToLower() == "skip" || player.AmountOfMoney < DefaultFee)
                {
                    player.GiveMoney(player.AmountOfMoney);
                    player.IsAlive = false;
                    Console.WriteLine($"You were robbed by {Name}");
                    break;
                }
                Console.WriteLine("Please, Enter \"skip\" or \"play\"");
                player.Choice = Console.ReadLine();
            }
        }

    }
}
