using Selenium.Selectors;
using Selenium.SpecialElements;

namespace Selenium
{
    public class EntryPoint
    {
        private static void Main()
        {
            var selector = new AlertBox();
            selector.Run();

            System.Console.ReadKey();
        }
    }
}
