using NUnit.Framework;
using Support;
using TestProject1.POM.Methods;

namespace TestProject1
{
    public class Tests : Hooks
    {

        [Test]
        public void RegistrationWithValidData()
        {
            MainPageMeth.ClickRegistratinButton();
            RegistrationMeth.EmailInput();
            RegistrationMeth.PasswordInput();
            RegistrationMeth.ConfirmPassInput();
            RegistrationMeth.ClickSubmitButton();

            Assert.IsTrue(MainPageMeth.IsUserimailShowOnMainPage());
        }
        
        [TestCase("stivenitwork@gmail.com", "Test1234")]
        public void AuthirizationWithValidData(string validEmail, string validPass)
        {
            MainPageMeth.ClickAuthorizationButton();
            AuthMeth.EmailInput(validEmail);
            AuthMeth.PasswordInput(validPass);
            AuthMeth.ClickSubmitButton();

            Assert.IsTrue(MainPageMeth.IsUserimailShowOnMainPage());
            Assert.IsTrue(MainPageMeth.IsSuccessMassageShow());
        }
    }
}