using NUnit.Framework;
using Is = KingsBountyLib.Test.Utils.Is;
// ReSharper disable AccessToStaticMemberViaDerivedType

namespace KingsBountyLib.Test
{
    public class DamageTest
    {
        [TestFixture]
        public class WithEquality
        {
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

            [Test]
            public void Equals_With_Operator()
            {
                var damage = new Damage(1, 2);
                var other = new Damage(1, 2);
                Assert.True(damage == other);
            }

            [Test]
            public void Not_Equals_With_Operator()
            {
                var damage = new Damage(1, 2);
                var other = new Damage(1, 1.999);
                Assert.True(damage != other);
            }
        }

        [TestFixture]
        public class WithArithmetic
        {
            [Test]
            public void Can_Be_Multiplied_By_Const()
            {
                var damage = new Damage(1, 2);
                Assert.That(damage * 2, Is.EqualTo(new Damage(2, 4)));
            }

            [Test]
            public void Can_Be_Reverse_Multiplied_By_Const()
            {
                var damage = new Damage(1, 2);
                Assert.That(2 * damage, Is.EqualTo(new Damage(2, 4)));
            }
        }
    }
}