using OpenQA.Selenium;

namespace Selenium.Selectors
{
    public class IdSelector
    {
        private const string SUBPAGE_NAME = "id";
        private const string ELEMENT_NAME = "testImage";

        public void Run()
        {
            var element = Selector.GetElement(SUBPAGE_NAME, By.Id(ELEMENT_NAME));
            if (element != null)
            {
                System.Console.WriteLine(element.Text);
                Selector.Quit();
            }
        }
    }
}