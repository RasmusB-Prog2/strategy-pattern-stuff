using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You need to go somewhere else, what do you do?");
            Console.WriteLine("1. Run");
            Console.WriteLine("2. Walk");
            Console.WriteLine("3. Fly");
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
                case "3":
                    FlyStrategy flyer = new FlyStrategy();
                    flyer.Move(120, "west");
                    break;
            }
        }
    }
}
