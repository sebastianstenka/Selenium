using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Selenium.SpecialElements
{
    public class AlertBox
    {
        private const string URL = "http://testing.todorvachev.com/special-elements/alert-box";

        public void Run()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);

            Thread.Sleep(3000);
            var alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            Thread.Sleep(3000);
            alert.Accept();
            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}