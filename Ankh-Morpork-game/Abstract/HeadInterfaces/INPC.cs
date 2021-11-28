using System;

namespace Ankh_Morpork_game.Abstract
{
    public interface INPC
    {
        protected Guid Id { get; set; }
        string Name { get; set; }
        string Speech { get; set; }
    }
}
