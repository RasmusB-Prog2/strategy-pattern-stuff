using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.services;

namespace StrategyPattern
{
    class RunStrategy : MovementStrategy
    {
        public RunStrategy(IPresents presenter) : base("Running towards {0} at {1} m/s", presenter) { }
    }
}
