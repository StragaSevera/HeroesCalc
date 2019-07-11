namespace KingsBountyLib
{
    public struct Damage
    {
        public double Min { get; }
        public double Max { get; }

        public Damage(double min, double max)
        {
            Min = min;
            Max = max;
        }

        public override string ToString()
        {
            return $"({Min} .. {Max})";
        }

        private bool Equals(Damage other)
        {
            return Min.Equals(other.Min) && Max.Equals(other.Max);
        }

        public override bool Equals(object obj)
        {
            return obj is Damage other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Min.GetHashCode() * 397) ^ Max.GetHashCode();
            }
        }

        public static bool operator ==(Damage a, Damage b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Damage a, Damage b)
        {
            return !(a == b);
        }

        public static Damage operator *(Damage dmg, double c)
        {
            return new Damage(dmg.Min * c, dmg.Max * c);
        }

        public static Damage operator *(double c, Damage dmg)
        {
            return dmg * c;
        }
    }
}