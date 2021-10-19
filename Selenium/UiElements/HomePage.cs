
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Selenium
{
    public class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "#page-17 > header > h1")]
        public IWebElement Headline { get; set; }
    }
}