using Selenium.Selectors;

namespace Selenium
{
    public class EntryPoint
    {
        private static void Main()
        {
            var selector = new CssPathSelector();
            selector.Run();

            System.Console.ReadKey();
        }
    }
}
