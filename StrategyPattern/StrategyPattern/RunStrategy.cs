using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class RunStrategy : IMovementStrategy
    {
        public void Move(double velocity, string direction)
        {
            Console.WriteLine("Running towards {0} at {1} m/s", direction, velocity);
        }
    }
}
