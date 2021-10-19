using OpenQA.Selenium;
using Selenium.UiElements;

namespace Selenium
{
    public class NavigateTo
    {
        public static void LoginFormThroughtTheMenu(IWebDriver driver)
        {
            var menu = new Menu(driver);
            var tsPage = new TestSceneriosPage(driver);

            menu.TestScenarios.Click();
            tsPage.LoginForm.Click();
        }
    }
}