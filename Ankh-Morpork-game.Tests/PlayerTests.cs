using Ankh_Morpork_game.Models;
using NUnit.Framework;

namespace Ankh_Morpork_game.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var player = new Player("Mike");

            player.GiveMoney(20);
            
            Assert.AreEqual(80, player.AmountOfMoney);
        }
    }
}