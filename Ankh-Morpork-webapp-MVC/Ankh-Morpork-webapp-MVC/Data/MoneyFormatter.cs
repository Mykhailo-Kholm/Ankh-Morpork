using System;

namespace Ankh_Morpork_webapp_MVC
{
    public static class MoneyFormatter
    {
        public static string FormatMoney(decimal amount)
        {
            decimal dollars = Math.Truncate(amount);
            decimal pennies = Math.Round((amount - dollars) * 100); 
            if (pennies == 0)
                return $"{dollars} AM$";
            return dollars == 0 ? $"{pennies} pennies": $"{dollars} AM$ and {pennies} pennies";
        }
    }
}
