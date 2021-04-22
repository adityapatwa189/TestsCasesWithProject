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
            return 20;
        }
    }
}
