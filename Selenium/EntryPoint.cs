using Selenium.Selectors;

namespace Selenium
{
    public class EntryPoint
    {
        private static void Main()
        {
            var selector = new ClassNameSelector();
            selector.Run();

            System.Console.ReadKey();
        }
    }
}
