using Ankh_Morpork_game.Models;
using NUnit.Framework;

namespace Ankh_Morpork_game.Tests
{
    [TestFixture]
    class ThiefTests
    {
        private Player _player;
        private Thief _thief;
        [SetUp]
        public void SetUp()
        {
            _player = new Player("Mike");
            _thief = new Thief("Azarov");
        }
        [Test]
        [TestCase("play", true, 90)]
        [TestCase("skip", false, 0)]
        public void GetFee_TakeFeeFromThePlayer_DecreaseAmountOfPlayerMoney(string choice, bool isAlive, float expectedAmount)
        {
            _player.Choice = choice;
            _thief.GetFee(_player);

            Assert.That(_player.IsAlive, Is.EqualTo(isAlive));
            Assert.That(_player.AmountOfMoney, Is.EqualTo(expectedAmount));
        }
    }
}
