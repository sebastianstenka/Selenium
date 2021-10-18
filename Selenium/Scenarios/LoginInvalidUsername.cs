using NUnit.Framework;

namespace Selenium.Scenarios
{
    [TestFixture]
    public class LoginInvalidUsername
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
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacter, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            var alert = Driver.WebDriver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutOfRange, alert.Text);

            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenCharacter, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            var alert = Driver.WebDriver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutOfRange, alert.Text);

            alert.Accept();
        }
    }
}