﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.Selectors
{
    public class NameSelector
    {
        private const string NAME_SELECTOR_URL = "http://testing.todorvachev.com/selectors/name/";
        private const string ELEMENT_NAME = "myName";

        public void Run()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(NAME_SELECTOR_URL);

            var element = driver.FindElement(By.Name(ELEMENT_NAME));
            System.Console.WriteLine(element.Displayed ? "element is visible" : "element is not visible");

            driver.Quit();
        }
    }
}
