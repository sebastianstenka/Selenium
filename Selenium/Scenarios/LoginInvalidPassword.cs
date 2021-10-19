using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Selenium.Scenarios
{
    [Parallelizable]
    public class LoginInvalidPassword
    {
        private ChromeDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = Actions.InitDriver();
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
            Actions.FillLoginForm(_driver, Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.FourCharacter, Config.Credentials.Invalid.Password.FourCharacter);

            var alert = _driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLenghtOutOfRange, alert.Text);

            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(_driver, Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.ThirteenCharacter, Config.Credentials.Invalid.Password.ThirteenCharacter);

            var alert = _driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLenghtOutOfRange, alert.Text);

            alert.Accept();
        }
    }
}