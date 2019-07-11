using NUnit.Framework;
using Is = KingsBountyLib.Test.Utils.Is;

namespace KingsBountyLib.Test
{
    public class DamageTest
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void Equal_To_Another()
        {
            var damage = new Damage(1, 2);
            var other = new Damage(1, 2);
            Assert.That(damage, Is.EqualTo(other));
        }

        [Test]
        public void Not_Equal_To_Different()
        {
            var damage = new Damage(1, 2);
            var other = new Damage(1, 1.999);
            Assert.That(damage, Is.Not.EqualTo(other));
        }

        [Test]
        public void Equals_With_Tolerance_With_Custom_Constraint()
        {
            var damage = new Damage(1, 2);
            var other = new Damage(1, 1.999);
            Assert.That(damage, Is.Damage(other));
        }
    }
}