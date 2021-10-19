using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Selenium.SpecialElements
{
    public class CheckBox
    {
        private const string SUBPAGE_NAME = "/special-elements/check-button-test-3";
        private const string ELEMENT_NAME = "#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(";

        public void Run()
        {
            var option = "1";

            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseUrl + SUBPAGE_NAME);

            var checkbox = driver.FindElement(By.Name(ELEMENT_NAME + option + ")"));
            checkbox.Click();
            Thread.Sleep(3000);

            var isChecked = checkbox.GetAttribute("checked") == "true";

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}