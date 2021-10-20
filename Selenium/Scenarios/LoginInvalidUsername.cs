using NUnit.Framework;

namespace Selenium.Scenarios
{
    [Parallelizable]
    public class LoginInvalidUsername
    {
        private OpenQA.Selenium.IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = OwnActions.InitDriver();
            NavigateTo.LoginFormThroughtTheMenu(_driver);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }

        [Test]
        public void LessThan5Characters()
        {
            OwnActions.FillLoginForm(_driver, Config.Credentials.Invalid.Username.FourCharacter, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            var alert = _driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutOfRange, alert.Text);

            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            OwnActions.FillLoginForm(_driver, Config.Credentials.Invalid.Username.ThirteenCharacter, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            var alert = _driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutOfRange, alert.Text);

            alert.Accept();
        }
    }
}