using Ankh_Morpork_game.Models;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;

namespace Ankh_Morpork_game.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        private Player _player;

        [SetUp]
        public void SetUp()
        {
            _player = new Player("Mike");
        }

        [Test]
        [TestCase(20, true)]
        [TestCase(1000000,false)]
        [TestCase(-20,false)]

        public void GiveMoney_PaymentForMove_ReturnBoolResultAboutPayment(float payment, bool expectedResult)
        {
            bool actualResult = _player.GiveMoney(payment);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(20, 80)]
        [TestCase(-20, 100)]
        [TestCase(1000000,100)]
        public void GiveMoney_PaymentForMove_UpdatePlayerAmount(float payment, float expectedResult)
        {
            _player.GiveMoney(payment);
            float actualResult = _player.AmountOfMoney;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(10,110)]
        [TestCase(-10, 100)]
        public void EarnMoney_TakeAJobFromFool_IncreaseAmountOfMoney(float amount, float expectedResult)
        {
            _player.EarnMoney(amount);
            
            Assert.That(_player.AmountOfMoney, Is.EqualTo(expectedResult));
        }
    }
}