using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.Selectors
{
    public class ClassNameSelector
    {
        private const string SELECTOR_URL = "http://testing.todorvachev.com/selectors/class-name/";
        private const string CLASS_NAME = "testClass";

        public void Run()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(SELECTOR_URL);

            var element = driver.FindElement(By.ClassName(CLASS_NAME));
            System.Console.WriteLine(element.Text);

            driver.Quit();
        }
    }
}