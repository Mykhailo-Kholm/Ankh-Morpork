using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Abstract.Interfaces;
using System;

namespace Ankh_Morpork_game.Models
{
    class Beggar:IBeggar
    {
        private Guid _id;

        Guid INPC.Id
        {
            get => _id;
            set => _id = Guid.NewGuid();
        }

        public string Name { get; set; }
        public string Speech { get; set; }
        public float Alms { get; set; }

        public Beggar(string name, float alms)
        {
            Name = name;
            Alms = alms;
            if (alms != 0)
                Speech = $"Give me {Alms} or I will chase you to death";
            else
                Speech = "Why lie? I need a beer.";
        }
        public void GetFee(Player player)
        {
            bool goNext = false;
            while (!goNext)
            {
                if (player.Choice.ToLower() == "play" && player.GiveMoney(Alms))
                {
                    Console.WriteLine("You can go!");
                    break;
                }
                if(player.Choice.ToLower() == "skip")
                {
                    player.IsAlive = false;
                    Console.WriteLine("You was chased to death");
                    break;
                }
                Console.WriteLine("Please, Enter \"skip\" or \"play\"");
                player.Choice = Console.ReadLine();
            }
        }
    }
}
