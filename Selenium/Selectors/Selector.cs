using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.Selectors
{
    public static class Selector
    {
        private const string URL = "http://testing.todorvachev.com/selectors/";
        private static IWebDriver _driver;

        public static IWebElement GetElement(string subpageName, By type)
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl($"{URL}{subpageName}");

            try
            {
                return _driver.FindElement(type);
            }
            catch (NoSuchElementException)
            {
                System.Console.WriteLine($"Element {subpageName} not found");
                return null;
            }
        }

        public static void Quit()
        {
            _driver.Quit();
        }
    }
}
