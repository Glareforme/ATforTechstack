using OpenQA.Selenium;

namespace TestProject1.POM.Locators
{
    class MainPageLoc
    {
        internal static By LoginButton = By.XPath("//a [text()='Login']");
        internal static By CreateAccountButton = By.XPath("//a [text()='Create Account']");
        internal static By AuthUserLogin = By.XPath("//span[contains(text(), '@gmail.com')]");
        internal static By MassageSuccessAuth = By.XPath("//div[text()='Success! You are logged in.']");
    }
}
