using OpenQA.Selenium;

namespace Selenium.Selectors
{
    public class NameSelector
    {
        private const string SUBPAGE_NAME = "/selectors/name";
        private const string ELEMENT_NAME = "myName";

        public void Run()
        {
            var element = Selector.GetElement(SUBPAGE_NAME, By.Name(ELEMENT_NAME));
            if (element != null)
            {
                System.Console.WriteLine(element.Text);
                Selector.Quit();
            }
        }
    }
}