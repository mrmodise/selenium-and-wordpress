using System;
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
            // navigate to site under automation
            LoginPage
                .GoTo();

            // test the login functionality
            LoginPage
                .LoginAs("selenium")
                .WithPassword("selenium")
                .Login();

            // check if are able to login
            Assert.IsTrue(DashBoardPage.IsAt, "Failed to login");
        }
    }
}
