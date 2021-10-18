using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    public class Driver
    {
        public static readonly IWebDriver WebDriver = new ChromeDriver();
    }
}