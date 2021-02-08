using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    interface IMovementStrategy
    {
        void Move(double velocity, string direction);
    }
}
