using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Selenium.SpecialElements
{
    public class TextInputField
    {
        private const string SUBPAGE_NAME = "/special-elements/text-input-field";
        private const string ELEMENT_NAME = "username";

        public void Run()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseUrl + SUBPAGE_NAME);

            var textBox = driver.FindElement(By.Name(ELEMENT_NAME));
            textBox.SendKeys("Test text");

            Thread.Sleep(3000);
            System.Console.WriteLine(textBox.GetAttribute("value"));
            System.Console.WriteLine(textBox.GetAttribute("maxlength"));
            textBox.Clear();
            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}
