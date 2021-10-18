using Selenium.AutoTestFramework;

namespace Selenium
{
    public class EntryPoint
    {
        private const string URL = "http://testing.todorvachev.com/";

        private static void Main()
        {
            Driver.WebDriver.Navigate().GoToUrl(URL);
            var menu = new Menu();

            menu.About.Click();
        }
    }
}
