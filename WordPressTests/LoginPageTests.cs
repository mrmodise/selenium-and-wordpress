using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomation;

namespace WordPressTests
{
    [TestClass]
    public class LoginPageTests
    {
        [TestInitialize]
        public void Initialize()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Admin_User_Can_Login()
        {
            LoginPage
                .GoTo();

            LoginPage
                .LoginAs("admin")
                .WithPassword("admin")
                .Login();

            Assert.IsTrue(DashBoardPage.IsAt, "Failed to login");
        }

        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}
