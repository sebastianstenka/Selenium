using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Selenium.SpecialElements
{
    internal class HoverEffect
    {
        public void Run()
        {
            var url = "https://testing.todorvachev.com/draganddrop/draganddrop.html";
            var driver = OwnActions.InitDriver();
            driver.Navigate().GoToUrl(url);

            var elementsIds = new string[]
            {
                "Drag1",
                "Drag2",
                "Drag3",
                "Drag4",
                "Drag5"
            };

            var elements = new IWebElement[]
            {
                driver.FindElementById(elementsIds[0]),
                driver.FindElementById(elementsIds[1]),
                driver.FindElementById(elementsIds[2]),
                driver.FindElementById(elementsIds[3]),
                driver.FindElementById(elementsIds[4])
            };

            var actions = new Actions(driver);
            actions.MoveToElement(elements[0]).Build().Perform();
            Thread.Sleep(2000);

            MoveElement(new Actions(driver), elements[0], elements[1], 0, 10);
            Thread.Sleep(1000);

            MoveElement(new Actions(driver), elements[0], elements[2], 0, 10);
            Thread.Sleep(1000);

            MoveElement(new Actions(driver), elements[4], elements[1], 0, 10);
            Thread.Sleep(1000);
        }

        private void MoveElement(Actions actions, IWebElement from, IWebElement to, int x, int y)
        {
            actions.ClickAndHold(from)
                .MoveToElement(to)
                .MoveByOffset(x, y)
                .Release()
                .Build()
                .Perform();
        }
    }
}