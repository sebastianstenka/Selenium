using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Selenium.SpecialElements
{
    public class DropDown
    {
        private const string URL = "http://testing.todorvachev.com/special-elements/drop-down-menu-test";
        private const string DROP_DOWN_NAME = "DropDownTest";
        private const string ELEMENT_NAME = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

        public void Run()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);

            var dropDown = driver.FindElement(By.Name(DROP_DOWN_NAME));

            System.Console.WriteLine($"The selected value is: {dropDown.GetAttribute("value")}");

            var elementFromDropDown = driver.FindElement(By.CssSelector(ELEMENT_NAME));
            System.Console.WriteLine($"The third option from the drop down is: {elementFromDropDown.GetAttribute("value")}");

            elementFromDropDown.Click();
            System.Console.WriteLine($"The selected value is: {dropDown.GetAttribute("value")}");
            Thread.Sleep(3000);
        }
    }
}