using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Selenium
{
    public class RightSideBar
    {
        public RightSideBar(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}