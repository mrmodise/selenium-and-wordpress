using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomation;

namespace WordPressTests
{
    [TestClass]
    public class LoginPageTests : WordPressBaseTest
    {

        [TestMethod]
        public void Admin_User_Can_Login()
        {
            // check if are able to login
            Assert.IsTrue(DashBoardPage.IsAt, "Failed to login");
        }
    }
}
