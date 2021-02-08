using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to run?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            switch (Console.ReadLine())
            {
                case "1":
                    RunStrategy runner = new RunStrategy();
                    runner.Move(3, "right");
                    break;
                case "2":
                    WalkStrategy walker = new WalkStrategy();
                    walker.Move(1, "left");
                    break;
            }
        }
    }
}
