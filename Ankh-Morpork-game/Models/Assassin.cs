using Ankh_Morpork_game.Abstract;
using System;

namespace Ankh_Morpork_game.Models
{
    public class Assassin : INPC
    {
        private Guid _id;

        Guid INPC.Id
        {
            get => _id;
            set => _id = Guid.NewGuid();
        }

        public string Name { get; set; }
        public string Speech { get; set; }
        public decimal MinReward { get; set; }
        public decimal MaxReward { get; set; }
        public bool IsOccupied { get; set; }

        public Assassin(string name, decimal minReward, decimal maxReward, bool isOccupied)
        {
            Name = name;
            MinReward = minReward;
            MaxReward = maxReward;
            IsOccupied = isOccupied;
            Speech = $"{Name} killed you";
        }
        public void Kill(Player player)
        {
            player.IsAlive = false;
            Console.WriteLine(Speech);
        }
    }
}
