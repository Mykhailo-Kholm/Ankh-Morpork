using Ankh_Morpork_game.Abstract.ChildInterfaces;

namespace Ankh_Morpork_game.Abstract.Interfaces
{
    interface IBeggar:INPC,IFee
    {
        float Alms { get; set; }
    }
}
