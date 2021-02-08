using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class WalkStrategy : IMovementStrategy
    {
        public void Move(double velocity, string direction)
        {
            Console.WriteLine("Walking towards {0} at {1} m/s", direction, velocity);
        }
    }
}
