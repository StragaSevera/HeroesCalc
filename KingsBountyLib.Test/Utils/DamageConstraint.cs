using System;
using NUnit.Framework.Constraints;

namespace KingsBountyLib.Test.Utils
{
    public class DamageConstraint : Constraint
    {
        public object Expected { get; }
        private const double TOLERANCE = 0.01;

        public DamageConstraint(object expected)
        {
            Expected = expected;
        }

        public override ConstraintResult ApplyTo<TActual>(TActual actual)
        {
            if (!(Expected is Damage))
            {
                Description = "second value to be Damage.";
                return new ConstraintResult(this, actual, false);
            }

            if (!(actual is Damage))
            {
                Description = "first value to be Damage.";
                return new ConstraintResult(this, actual, false);
            }

            var expectedDmg = (Damage) Expected;
            var actualDmg = (Damage) (object) actual;

            if (CompareDamages(expectedDmg, actualDmg))
            {
                return new ConstraintResult(this, actual, true);
            }
            else
            {
                Description =
                    $"{expectedDmg} to be equal to {actualDmg} within {TOLERANCE}.";
                return new ConstraintResult(this, actual, false);
            }
        }

        private bool CompareDamages(Damage expected, Damage actual)
        {
            return Math.Abs(expected.Min - actual.Min) <= TOLERANCE &&
                   Math.Abs(expected.Max - actual.Max) <= TOLERANCE;
        }
    }
}