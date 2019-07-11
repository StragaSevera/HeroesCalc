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

        public bool Equals(Damage other)
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
    }
}