using Ankh_Morpork_webapp_MVC.Models;
using NUnit.Framework;

namespace Ankh_Morpork_webapp_MVC.Tests
{
    public class AssassinTests
    {
        private Player _player;

        [SetUp]
        public void SetUp()
        {
            _player = Player.GetPlayer();
        }

        [Test]
        public void Kill_KillingOfPlayer_ChangeIsAlivePropertyInPlayerToFalse()
        {
            Assassin.Kill(_player);

            Assert.That(_player.IsAlive, Is.EqualTo(false));
        }
    }
}