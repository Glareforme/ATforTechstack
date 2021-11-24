using OpenQA.Selenium;

namespace TestProject1.POM.Locators
{
    internal static class AuthLoc
    {
        internal static By AuthEmailField = By.Id("email");
        internal static By AuthPasswordField = By.Id("password");
        internal static By AuthSubmitButton = By.XPath("//button [@class='col-md-3 btn btn-primary']");
    }
}
