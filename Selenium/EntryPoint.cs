using Selenium.Selectors;
using Selenium.SpecialElements;

namespace Selenium
{
    public class EntryPoint
    {
        private static void Main()
        {
            var selector = new CheckBox();
            selector.Run();

            System.Console.ReadKey();
        }
    }
}
