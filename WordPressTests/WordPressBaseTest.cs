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
        }

        [TestCleanup]
        public void CleanUp()
        {
            // close selenium driver
            Driver.Close();
        }
    }
}
