﻿using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Abstract.Interfaces;
using System;

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
        public string Speech { get; set; } = "Pay the fee - 10 bucks, otherwise you will be robbed next time";

        public Thief(string name)
        {
            Name = name;
        }

        public void GetFee(Player player) 
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
                    Console.WriteLine($"You were robbed by {Name}");
                    player.GiveMoney(player.AmountOfMoney);
                    break;
                }
                Console.WriteLine("Please, Enter \"skip\" or \"play\"");
                player.Choice = Console.ReadLine();
            }
        }

    }
}
