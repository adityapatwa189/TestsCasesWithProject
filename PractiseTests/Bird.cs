using System;

namespace PractiseTests
{
    abstract class Bird
    {
        private BirdType _birdtype;

        public int numberOfCoconuts { get; private set; }

        public bool isNailed { get; private set; }

        public int voltage { get; private set; }
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

        public int getBaseSpeed(int voltage)
        {
            throw new NotImplementedException();
        }

        public int getLoadFactor()
        {
            throw new NotImplementedException();
        }



        public double getBaseSpeed()
        {
            throw new NotImplementedException();

        }
    }
}
