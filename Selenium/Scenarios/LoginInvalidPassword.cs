using NUnit.Framework;

namespace Selenium.Scenarios
{
    [TestFixture]
    public class LoginInvalidPassword
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            Actions.InitDriver();
            NavigateTo.LoginFormThroughtTheMenu();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.WebDriver.Quit();
        }

        [Test]
        public void LessThan5Characters()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.FourCharacter, Config.Credentials.Invalid.Password.FourCharacter);

            var alert = Driver.WebDriver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLenghtOutOfRange, alert.Text);

            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.ThirteenCharacter, Config.Credentials.Invalid.Password.ThirteenCharacter);

            var alert = Driver.WebDriver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLenghtOutOfRange, alert.Text);

            alert.Accept();
        }
    }
}