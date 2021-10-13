using OpenQA.Selenium;
using Selenium.Selectors;
using System.Threading;

namespace Selenium.SpecialElements
{
    public class RadioButton
    {
        private const string SUBPAGE_NAME = "radio-button-test";
        private const string ELEMENT_NAME = "#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(1)";

        public void Run()
        {
            var radioButton = Selector.GetElement(SUBPAGE_NAME, By.CssSelector(ELEMENT_NAME));
            radioButton.Click();
            Thread.Sleep(3000); 

            var isChecked = radioButton.GetAttribute("checked") == "true";

            Thread.Sleep(3000);
            Selector.Quit();
        }
    }
}