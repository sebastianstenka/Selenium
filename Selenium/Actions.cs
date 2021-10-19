using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.UiElements;
using System;

namespace Selenium
{
    public class Actions
    {
        public static ChromeDriver InitDriver()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return driver; 
        }

        public static void FillLoginForm(IWebDriver driver, string username, string password, string repeatPassword)
        {
            var lsPost = new LoginScenarioPost(driver);

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