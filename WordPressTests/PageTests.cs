using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomation;
using static WordPressAutomation.ListPostPage;

namespace WordPressTests
{
    [TestClass]
    public class PageTests
    {

        [TestMethod]
        public void Can_Edit_Page()
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

            // verify edit mode
            Assert.IsTrue(NewPostPage.IsInEditMode(), "Was not in edit mode");

            // verify we are at the page/post to edit
            Assert.AreEqual("Sample Page", NewPostPage.Title, "Title did not match");
        }
    }
}
