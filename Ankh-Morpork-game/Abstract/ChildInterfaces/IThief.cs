using Ankh_Morpork_game.Abstract.ChildInterfaces;

namespace Ankh_Morpork_game.Abstract.Interfaces
{
    interface IThief:INPC,IFee
    {
        const float DefaultFee = 10f;
    }
}
