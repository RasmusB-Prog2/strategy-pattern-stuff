using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.services;

namespace StrategyPattern
{
    public class WalkStrategy : MovementStrategy
    {
        public WalkStrategy(IPresents presenter) : base("Walking towards {0} at {1} m/s", presenter)
        { }
    }
}
