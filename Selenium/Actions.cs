using Selenium.UiElements;

namespace Selenium
{
    public class Actions
    {
        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            var lsPost = new LoginScenarioPost();

            lsPost.UserNameField.SendKeys(username);
            lsPost.PasswordField.SendKeys(password);
            lsPost.RepeatPasswordField.SendKeys(repeatPassword);
            lsPost.LoginButton.Click();
        }
    }
}