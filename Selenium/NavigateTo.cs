using Selenium.UiElements;

namespace Selenium
{
    public class NavigateTo
    {
        public static void LoginFormThroughtTheMenu()
        {
            var menu = new Menu();
            var tsPage = new TestSceneriosPage();

            menu.TestScenarios.Click();
            tsPage.LoginForm.Click();
        }
    }
}