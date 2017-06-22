using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomation;

namespace WordPressTests
{
    [TestClass]
    public class PageTests
    {
        [TestInitialize]
        public void Initialize()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Can_Create_Basic_Post()
        {
            // navigate to site under automation
            LoginPage
                .GoTo();

            // test the login functionality
            LoginPage
                .LoginAs("selenium")
                .WithPassword("selenium")
                .Login();

            // navigate to the list post page
            ListPostPage.GoTo(PostType.Page);

            // select page/post to select
            ListPostPage.SelectPost("Sample Page");
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}
