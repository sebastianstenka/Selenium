using Selenium.Selectors;

namespace Selenium
{
    public class EntryPoint
    {
        private static void Main()
        {
            var nameSelector = new NameSelector();
            nameSelector.Run();

            System.Console.ReadKey();
        }
    }
}
