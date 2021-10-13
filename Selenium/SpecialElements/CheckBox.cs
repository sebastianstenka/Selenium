using OpenQA.Selenium;
using Selenium.Selectors;
using System.Threading;

namespace Selenium.SpecialElements
{
    public class CheckBox
    {
        private const string SUBPAGE_NAME = "check-button-test-3";
        private const string ELEMENT_NAME = "#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(";

        public void Run()
        {
            var option = "1";
            var checkbox = Selector.GetElement(SUBPAGE_NAME, By.CssSelector(ELEMENT_NAME + option + ")"));
            checkbox.Click();
            Thread.Sleep(3000);

            var isChecked = checkbox.GetAttribute("checked") == "true";

            Thread.Sleep(3000);
            Selector.Quit();
        }
    }
}