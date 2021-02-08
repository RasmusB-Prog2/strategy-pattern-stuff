using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.services;

namespace StrategyPattern
{
    class FlyStrategy : MovementStrategy
    {

        public FlyStrategy(IPresents presenter) 
            : base("You somehow acquired wings and are now flying towards {0} at {1} m/s", presenter) { }
        
    }
}
