using OpenQA.Selenium;

namespace Selenium.Selectors
{
    public class ClassNameSelector
    {
        private const string SUBPAGE_NAME = "/selectors/class-name";
        private const string ELEMENT_NAME = "testClass";

        public void Run()
        {
            var element = Selector.GetElement(SUBPAGE_NAME, By.ClassName(ELEMENT_NAME));
            if (element != null)
            {
                System.Console.WriteLine(element.Text);
                Selector.Quit();
            }
        }
    }
}