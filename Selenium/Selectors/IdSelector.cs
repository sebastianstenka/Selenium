using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.Selectors
{
    public class IdSelector
    {
        private const string ID_SELECTOR_URL = "http://testing.todorvachev.com/selectors/id/";
        private const string IMG_ID = "testImage";

        public void Run()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(ID_SELECTOR_URL);

            var element = driver.FindElement(By.Id(IMG_ID));
            System.Console.WriteLine(element.Displayed ? "element is visible" : "element is not visible");

            driver.Quit();
        }
    }
}