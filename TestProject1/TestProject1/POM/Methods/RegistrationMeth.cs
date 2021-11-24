using Support;
using TestProject1.POM.Locators;
using TestProject1.Supports;

namespace TestProject1.POM.Methods
{
    class RegistrationMeth
    {
        internal static void EmailInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.RegEmailField).SendKeys(GenerateDataForRegist.GenerateMail());
        internal static void PasswordInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.RegPassword).SendKeys(GenerateDataForRegist.defaultPassword);
        internal static void ConfirmPassInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.RegPassConfirm).SendKeys(GenerateDataForRegist.defaultPassword);
        internal static void ClickSubmitButton() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.RegSubmitButton).Click();
    }
}
