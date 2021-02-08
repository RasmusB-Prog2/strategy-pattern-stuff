using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WalkStrategy walker = new WalkStrategy();
            walker.Move(1, "left");


        }
    }
}
