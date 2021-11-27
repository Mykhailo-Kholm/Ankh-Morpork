using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_game.Abstract.Interfaces;

namespace Ankh_Morpork_game.Models
{
    class Assassin : IAssassin
    {
        private Guid _id;

        Guid INPC.Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name { get; set; }
        public float MinReward { get; set; }
        public float MaxReward { get; set; }
        public bool Status { get; set; }
        public void Kill(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
