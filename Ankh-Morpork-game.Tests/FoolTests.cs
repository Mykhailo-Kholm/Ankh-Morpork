using Ankh_Morpork_game.Models;
using NUnit.Framework;

namespace Ankh_Morpork_game.Tests
{
    [TestFixture]
    class FoolTests
    {
        private Player _player;
        private Fool _fool;

        [SetUp]
        public void SetUp()
        {
            _player = new Player("Mike");
            _fool = new Fool("Arch Fool", 8);
        }

        [Test]
        [TestCase("play", true, 108)]
        [TestCase("skip", true, 100)]
        public void GetFee_GiveFeeToThePlayer_IncreaseAmountOfPlayerMoney(string choice, bool isAlive, float expectedAmount)
        {
            _player.Choice = choice;
            _fool.GetFee(_player);

            Assert.That(_player.IsAlive, Is.EqualTo(isAlive));
            Assert.That(_player.AmountOfMoney, Is.EqualTo(expectedAmount));
        }
    }
}
