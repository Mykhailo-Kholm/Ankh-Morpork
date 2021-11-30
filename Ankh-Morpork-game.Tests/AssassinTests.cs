using Ankh_Morpork_game.Models;
using NUnit.Framework;

namespace Ankh_Morpork_game.Tests
{
    [TestFixture]
    public class AssassinTests
    {
        private Assassin _assassin;
        private Player _player;

        [SetUp]
        public void SetUp()
        {
            _assassin = new Assassin("A1",10,20,false);
            _player = new Player("Mike");
        }

        [Test]
        public void Kill_KillingOfPlayer_ChangeIsAlivePropertyInPlayerToFalse()
        {
            _assassin.Kill(_player);

            Assert.That(_player.IsAlive, Is.EqualTo(false));
        }

    }
}