using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game.Abstract.HeadInterfaces
{
    public abstract class GuildService
    {
        public Random rnd = new Random();
        public abstract void InteractWithPlayer(Player player);
    }
}
