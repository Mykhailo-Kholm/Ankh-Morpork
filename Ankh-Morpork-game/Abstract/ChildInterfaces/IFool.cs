using Ankh_Morpork_game.Abstract.ChildInterfaces;

namespace Ankh_Morpork_game.Abstract.Interfaces
{
    interface IFool : INPC,IFee
    {
        float Salary { get; set; }
    }
}
