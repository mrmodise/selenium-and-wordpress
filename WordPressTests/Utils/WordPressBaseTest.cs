using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomation;

namespace WordPressTests
{
    [TestClass]
    public class WordPressBaseTest
    {
        [TestInitialize]
        public void Initialize()
        {
            // initialize selenium driver
            Driver.Initialize();

            // navigate to site under automation
            LoginPage
                .GoTo();

            // test the login functionality
            LoginPage
                .LoginAs("selenium")
                .WithPassword("selenium")
                .Login();
        }

        [TestCleanup]
        public void CleanUp()
        {
            // close selenium driver
            Driver.Close();
        }
    }
}
