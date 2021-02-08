using System.IO;

namespace StrategyPattern.services
{
    public class UiService : IUiService
    {
        private const string Path =
            "/home/hackerbuddy/repos/strategy-pattern-stuff/StrategyPattern/StrategyPattern/menu.ui";

        public UiService()
        {
            
        }
        
        public string GetUi()
        {
            if (!File.Exists(Path))
                throw new IOException($"{Path} does not exist in env");
            
            var output = File.ReadAllText(Path);
            return output;
        }
    }
}