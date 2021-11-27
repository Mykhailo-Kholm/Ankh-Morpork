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
            set => _id = value;
        }

        public string Name { get; set; }
        public void TakeFee(Player player)
        {
            throw new NotImplementedException();
        }

    }
}
