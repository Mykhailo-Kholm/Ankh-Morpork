using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Abstract.Interfaces;

namespace Ankh_Morpork_game.Models
{
    public class Assassin : IAssassin
    {
        private Guid _id;

        Guid INPC.Id
        {
            get => _id;
            set => _id = Guid.NewGuid();
        }

        public string Name { get; set; }
        public string Speech { get; set; }
        public float MinReward { get; set; }
        public float MaxReward { get; set; }
        public bool IsOccupied { get; set; }

        public Assassin(string name, float minReward, float maxReward, bool isOccupied)
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
