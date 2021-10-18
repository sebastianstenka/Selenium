using OpenQA.Selenium.Chrome;
using Selenium.UiElements;

namespace Selenium
{
    public class Actions
    {
        public static void InitDriver()
        {
            Driver.WebDriver = new ChromeDriver();
            Driver.WebDriver.Navigate().GoToUrl(Config.BaseUrl);
        }

        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            var lsPost = new LoginScenarioPost();

            lsPost.UsernameField.Clear();
            lsPost.UsernameField.SendKeys(username);
            lsPost.PasswordField.Clear();
            lsPost.PasswordField.SendKeys(password);
            lsPost.RepeatPasswordField.Clear();
            lsPost.RepeatPasswordField.SendKeys(repeatPassword);
            lsPost.LoginButton.Click();
        }
    }
}