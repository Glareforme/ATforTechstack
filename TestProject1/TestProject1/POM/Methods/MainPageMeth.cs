using Support;
using TestProject1.POM.Locators;

namespace TestProject1.POM.Methods
{
    class MainPageMeth
    {
        internal static void ClickRegistratinButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc.CreateAccountButton).Click();
        internal static void ClickAuthorizationButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc.LoginButton).Click();
        internal static bool IsUserimailShowOnMainPage()
        {
            if (ChromeBrowser.GetDriver().FindElement(MainPageLoc.AuthUserLogin).Displayed)
                return true;
            return false;
        }
        internal static bool IsSuccessMassageShow()
        {
            if (ChromeBrowser.GetDriver().FindElement(MainPageLoc.MassageSuccessAuth).Displayed)
                return true;
            return false;
        }
    }
}
