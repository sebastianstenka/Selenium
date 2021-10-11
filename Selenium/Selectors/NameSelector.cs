using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.Selectors
{
    public class NameSelector
    {


        public void Run()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name/");

            var element = driver.FindElement(By.Name("myName"));
            System.Console.WriteLine(element.Displayed ? "element is visible" : "element is not visible");

            driver.Quit();
        }
    }
}
