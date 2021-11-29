using Ankh_Morpork_game.Models;
using NUnit.Framework;

namespace Ankh_Morpork_game.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test] public void GiveMoney_Payment20dollars_PlayerAmount80()
        {
            var player = new Player("Mike");

            player.GiveMoney(20);
            
            Assert.AreEqual(80, player.AmountOfMoney);
        }
    }
}