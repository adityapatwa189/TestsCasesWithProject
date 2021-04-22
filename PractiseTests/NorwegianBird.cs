namespace PractiseTests
{
    class NorwegianBird : Bird
    {
        public bool isNailed { get;private set; }
        public int voltage { get;private set; }
        public NorwegianBird(BirdType birdType) : base(birdType)
        {
        }

        public override double getSpeed()
        {
            return (isNailed) ? 0 : getBaseSpeed(voltage);
        }
        public double getBaseSpeed(int _voltage) 
        {
            return _voltage *1.2;
        }
    }
}
