using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Selenium
{
    public class EntryPoint
    {
        private static void Main()
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}
 