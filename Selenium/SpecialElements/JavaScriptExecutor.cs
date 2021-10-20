using System.Threading;

namespace Selenium.SpecialElements
{
    public class JavaScriptExecutor
    {
        public void Run()
        {
            var driver = OwnActions.InitDriver();
            var img = driver.FindElementByCssSelector("#page-17 > div > p:nth-child(1) > a > img");

            var script = "arguments[0].style.border = '5px solid red'";
            driver.ExecuteScript(script, img);
            Thread.Sleep(3000);
            script = "arguments[0].style.display = 'none'";
            driver.ExecuteScript(script, img);
        }
    }
}
