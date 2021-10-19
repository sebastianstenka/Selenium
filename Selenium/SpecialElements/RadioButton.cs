using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Selenium.SpecialElements
{
    public class RadioButton
    {
        private const string SUBPAGE_NAME = "/special-elements/radio-button-test";
        private const string ELEMENT_NAME = "#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(1)";

        public void Run()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseUrl + SUBPAGE_NAME);

            var radioButton = driver.FindElement(By.Name(ELEMENT_NAME));
            radioButton.Click();
            Thread.Sleep(3000);

            var isChecked = radioButton.GetAttribute("checked") == "true";

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}