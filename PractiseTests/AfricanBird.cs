using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseTests
{
    class AfricanBird : Bird
    {
        public AfricanBird(BirdType birdType) : base(birdType)
        {
        }

        public override double getSpeed()
        {
            return getBaseSpeed();
        }
    }
    class EuropeanBird : Bird
    {
        public EuropeanBird(BirdType birdType) : base(birdType)
        {
        }

        public override double getSpeed()
        {
            return getBaseSpeed() - getLoadFactor() * numberOfCoconuts;
        }
    }
    class NorwegianBird : Bird
    {
        public NorwegianBird(BirdType birdType) : base(birdType)
        {
        }

        public override double getSpeed()
        {
            return (isNailed) ? 0 : getBaseSpeed(voltage);
        }
    }
}
