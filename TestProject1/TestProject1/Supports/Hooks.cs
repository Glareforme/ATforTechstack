using NUnit.Framework;

namespace Support
{
    public class Hooks
    {
        [SetUp]
        public void SetUp()
        {
            ChromeBrowser.GetDriver().Navigate().GoToUrl("https://sample-project.tech-stack.dev/");
        }

        [TearDown]
        public void TearDown()
        {
            ChromeBrowser.CleanDriver();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            ChromeBrowser.CloseDriver();
        }
    }
}