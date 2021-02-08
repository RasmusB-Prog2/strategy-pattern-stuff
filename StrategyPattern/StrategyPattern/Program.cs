using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
            HandleMenuInput();
        }
        static void PrintMenu()
        {
            Console.WriteLine("You need to go somewhere else, what do you do?");
            Console.WriteLine("1. Walk");
            Console.WriteLine("2. Run");
            Console.WriteLine("3. Fly");
        }
        static void HandleMenuInput()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    WalkStrategy walker = new WalkStrategy();
                    walker.Move(1, "left");
                    break;
                case "2":
                    RunStrategy runner = new RunStrategy();
                    runner.Move(3, "right");
                    break;
                case "3":
                    FlyStrategy flyer = new FlyStrategy();
                    flyer.Move(120, "west");
                    break;
            }
        }
    }
}
