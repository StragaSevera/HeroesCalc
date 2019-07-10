using KingsBountyLib.Test.Utils;
using NUnit.Framework.Constraints;

namespace KingsBountyLib.Test.Utils
{
    public class Is : NUnit.Framework.Is
    {
        public static DamageConstraint Damage(object expected)
        {
            return new DamageConstraint(expected);
        }
    }
}

public static class CustomConstraintExtensions
{
    public static DamageConstraint Damage(this ConstraintExpression expression, object expected)
    {
        var constraint = new DamageConstraint(expected);
        expression.Append(constraint);

        return constraint;
    }
}