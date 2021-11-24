using Support;
using TestProject1.POM.Locators;

namespace TestProject1.POM.Methods
{
    internal static class AuthMeth
    {
        internal static void EmailInput(string validLogin) => ChromeBrowser.GetDriver().FindElement(AuthLoc.AuthEmailField).SendKeys(validLogin);
        internal static void PasswordInput(string validPass) => ChromeBrowser.GetDriver().FindElement(AuthLoc.AuthPasswordField).SendKeys(validPass);
        internal static void ClickSubmitButton() => ChromeBrowser.GetDriver().FindElement(AuthLoc.AuthSubmitButton).Click();
    }
}
