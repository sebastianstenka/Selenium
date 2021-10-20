using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Threading;

namespace Selenium.SpecialElements
{
    public class Tab
    {
        public Tab()
        {
            var yahoo = "https://www.yahoo.com/";
            var google = "https://www.google.com/";
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(yahoo);

            driver.ExecuteScript("window.open();");

            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Navigate().GoToUrl(google);
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Thread.Sleep(2000);
        }
    }
}