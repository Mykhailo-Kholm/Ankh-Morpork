using Ankh_Morpork_game.Models;
using NUnit.Framework;

namespace Ankh_Morpork_game.Tests
{
    [TestFixture]
    class BeggarTests
    {
        private Player _player;
        private Beggar _beggar;
        [SetUp]
        public void SetUp()
        {
            _player = new Player("Mike");
            _beggar = new Beggar("Twitchers ", 3);
        }

        [Test]
        [TestCase("play", true, 97)]
        [TestCase("skip", false, 0)]
        public void GetFee_TakeFeeFromThePlayer_DecreaseAmountOfPlayerMoney(string choice, bool isAlive, float expectedAmount)
        {
            _player.Choice = choice;
            _beggar.GetFee(_player);

            Assert.That(_player.IsAlive, Is.EqualTo(isAlive));
            Assert.That(_player.AmountOfMoney, Is.EqualTo(expectedAmount));
        }
    }
}
