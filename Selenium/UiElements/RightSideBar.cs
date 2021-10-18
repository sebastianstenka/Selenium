using SeleniumExtras.PageObjects;

namespace Selenium
{
    public class RightSideBar
    {
        public RightSideBar()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }
    }
}