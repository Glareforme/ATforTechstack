using OpenQA.Selenium;

namespace TestProject1.POM.Locators
{
    internal static class RegistrationLoc
    {
        internal static By RegEmailField = By.Id("email");
        internal static By RegPassword = By.Id("password");
        internal static By RegPassConfirm = By.Id("confirmPassword");
        internal static By RegSubmitButton = By.XPath("//button [@class='btn btn-success']");
    }
}
