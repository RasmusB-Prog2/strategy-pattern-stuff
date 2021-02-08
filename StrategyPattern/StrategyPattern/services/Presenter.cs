using System;

namespace StrategyPattern.services
{
    public class Presenter : IPresents
    {
        public void DisplayLine(string content) => Console.WriteLine(content);
        public void DisplayOnLine(string content) => Console.Write(content);
    }
}