using OpenQA.Selenium.Chrome;
using System.IO;

namespace Selenium.SpecialElements
{
    public class Screenshot
    {
        public void Make()
        {
            var chrome = new ChromeDriver();

            chrome.Navigate().GoToUrl("https://www.google.com/");

            var screenshot = chrome.GetScreenshot();

            screenshot.SaveAsFile(Directory.GetCurrentDirectory() + ".png", OpenQA.Selenium.ScreenshotImageFormat.Png);

            chrome.Quit();
        }
    }
}