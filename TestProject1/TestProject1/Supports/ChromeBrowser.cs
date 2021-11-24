using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;

namespace Support
{
    internal static class ChromeBrowser
    {
        private static IWebDriver _driver;

        private static void CreateDriver()
        {
            var option = new ChromeOptions();
            option.AddArguments("--start-maximized");
            _driver = new ChromeDriver(option);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        internal static IWebDriver GetDriver()
        {
            if (_driver == null)
                CreateDriver();

            return _driver;
        }

        internal static void CleanDriver()
        {
            // Open new empty tab.
            _driver.ExecuteJavaScript("window.open('');");

            // Close all tabs but one tab and delete all cookies.
            for (var tabs = _driver.WindowHandles; tabs.Count > 1; tabs = _driver.WindowHandles)
            {
                _driver.SwitchTo().Window(tabs[0]);
                _driver.Manage().Cookies.DeleteAllCookies();
                _driver.Close();
            }

            // Switch to empty tab.
            _driver.SwitchTo().Window(_driver.WindowHandles[0]);
        }

        internal static void CloseDriver()
        {
            _driver.Quit();
        }
    }
}