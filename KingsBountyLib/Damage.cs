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
    }
}