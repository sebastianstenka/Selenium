using System.Threading;

namespace Selenium
{
    public class EntryPoint
    {
        private const string URL = "http://testing.todorvachev.com/";

        private static void Main()
        {
            Driver.WebDriver.Navigate().GoToUrl(URL);
            NavigateTo.LoginFormThroughtTheMenu();
            Thread.Sleep(3000);
        }
    }
}
