using OpenQA.Selenium;
using Selenium.Selectors;
using System.Threading;

namespace Selenium.SpecialElements
{
    public class TextInputField
    {
        private const string SUBPAGE_NAME = "/special-elements/text-input-field";
        private const string ELEMENT_NAME = "username";

        public void Run()
        {
            var textBox = Selector.GetElement(SUBPAGE_NAME, By.Name(ELEMENT_NAME));
            textBox.SendKeys("Test text");
            Thread.Sleep(3000);
            System.Console.WriteLine(textBox.GetAttribute("value"));
            System.Console.WriteLine(textBox.GetAttribute("maxlength"));
            textBox.Clear();
            Thread.Sleep(3000);
            Selector.Quit();
        }
    }
}
