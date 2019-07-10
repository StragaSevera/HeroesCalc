using NUnit.Framework;
using Is = KingsBountyLib.Test.Utils.Is;

namespace KingsBountyLib.Test
{
    public class CreatureTest
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void Peasant_To_Peasant_Attack()
        {
            var unit = new Creature(1, 1, 1, 2);
            Damage damage = unit.PureDamage(unit);
            Assert.That(damage, Is.Damage(new Damage(1, 1.999)));
        }
    }
}