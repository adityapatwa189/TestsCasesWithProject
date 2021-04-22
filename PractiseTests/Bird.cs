using System;

namespace PractiseTests
{
    abstract class Bird
    {
        private BirdType _birdtype;
        public Bird(BirdType birdType)
        {

            _birdtype = birdType;
        }
        abstract public double getSpeed();

        //{
        //    switch (_birdtype)
        //    {
        //        case BirdType.EUROPEAN:

        //            return getBaseSpeed();

        //        case BirdType.AFRICAN:

        //            return getBaseSpeed() - getLoadFactor() * numberOfCoconuts;

        //        case BirdType.NORWEGIAN_BLUE:

        //            return (isNailed) ? 0 : getBaseSpeed(voltage);

        //    }
        //    throw new NotSupportedException("Should be unreachable");

        //}
    }
}
