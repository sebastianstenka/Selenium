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
            Actions.FillLoginForm(Config.Credentials.Valid.UserName, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);
            Thread.Sleep(3000);
        }
    }
}
