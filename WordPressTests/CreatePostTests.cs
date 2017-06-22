﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomation;

namespace WordPressTests
{
    
    [TestClass]
    public class CreatePostTests
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

            // navigate to the create post page
            NewPostPage.GoTo();

            // create post contents - title, body
            NewPostPage
                .CreatePost("This is the post test title")
                .WithBody("Hi, this is the body")
                .Publish();

            // create post
            NewPostPage.GoToNewPost();

            // check if the post has been created and that the title of the post equals the provided one
            Assert.AreEqual(PostPage.Title, "This is the Title", "Title did not match a new post");
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}
