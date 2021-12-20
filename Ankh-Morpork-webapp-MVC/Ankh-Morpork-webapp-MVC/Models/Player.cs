namespace Ankh_Morpork_webapp_MVC.Models
{
    public class Player
    {
        public int Id { get; set; }
        public decimal AmountOfMoney { get; set; } = 100;
        public bool IsAlive { get; set; } = true;
        public int AmountOfBeers { get; set; } = 1;
        public string MoneyMessage { get; set; } = MoneyFormatter.FormatMoney(100);
        private static Player _player;
        public static Player GetPlayer()
        {
            return _player ?? (_player = new Player());
        }
        public void GiveMoney(decimal amount)
        {
            if (amount >= 0 && amount <= AmountOfMoney)
            {
                AmountOfMoney -= amount;
                MoneyMessage = $"You have {MoneyFormatter.FormatMoney(AmountOfMoney)}";
                return;
            }

            if (amount < 0)
                return;

            MoneyMessage = "You are Liar. You don't have this amount";
            AmountOfMoney = 0;
            IsAlive = false;
        }

        public void EarnMoney(decimal amount)
        {
            if (amount >= 0)
                AmountOfMoney += amount;
            MoneyMessage = $"You have {MoneyFormatter.FormatMoney(AmountOfMoney)}";
        }

        public bool Buy(int numOfBeers, decimal payment)
        {
            if (AmountOfBeers >= 2 || AmountOfBeers + numOfBeers > 2)
            {
                AmountOfBeers = 2;
                return false;
            }
            AmountOfMoney -= payment*numOfBeers;
            AmountOfBeers += numOfBeers;
            return true;
        }
    }
}