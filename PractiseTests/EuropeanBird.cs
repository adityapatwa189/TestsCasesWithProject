namespace PractiseTests
{
    class EuropeanBird : Bird
    {
        public int numberOfCoconuts { get;private set; }
        public EuropeanBird(BirdType birdType) : base(birdType)
        {
        }

        public override double getSpeed()
        {
            return getBaseSpeed() - getLoadFactor() * numberOfCoconuts;
        }
        public double getBaseSpeed()
        {
            return 10;
        }
        public double getLoadFactor()
        {
            return 2;
        }
    }
}
