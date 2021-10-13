using OpenQA.Selenium;

namespace Selenium.Selectors
{
    public class CssPathSelector
    {
        private const string SUBPAGE_NAME = "/selectors/css-path";
        private const string ELEMENT_NAME = "#post-108 > div > figure > img2";

        public void Run()
        {
            var element = Selector.GetElement(SUBPAGE_NAME, By.CssSelector(ELEMENT_NAME));
            if (element != null)
            {
                System.Console.WriteLine(element.Text);
                Selector.Quit();
            }
        }
    }
}