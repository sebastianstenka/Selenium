using System.Threading;

namespace Selenium.SpecialElements
{
    public class BrowserPositionAndSize
    {
        public BrowserPositionAndSize()
        {
            var url = "https://testing.todorvachev.com/";
            var driver = OwnActions.InitDriver();
            driver.Navigate().GoToUrl(url);

            driver.Manage().Window.FullScreen();
            Thread.Sleep(2000);

            driver.Manage().Window.Position = new System.Drawing.Point(200, 200);
            driver.Manage().Window.Size = new System.Drawing.Size(600, 600);
        }
    }
}
