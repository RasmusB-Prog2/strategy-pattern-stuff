using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class FlyStrategy
    {
        public void Move(double velocity, string direction)
        {
            Console.WriteLine("You somehow acquired wings and are now flying towards {0} at {1} m/s", direction, velocity);
        }
    }
}
