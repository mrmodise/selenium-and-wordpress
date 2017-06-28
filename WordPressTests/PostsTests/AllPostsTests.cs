﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomation;
using static WordPressAutomation.ListPostPage;

namespace WordPressTests.PostsTests
{
    [TestClass]
    public class AllPostsTests: WordPressBaseTest
    {
        [TestMethod]
        public void Added_Posts_Show_Up()
        {
            // go to posts, get post count and store
            ListPostPage.GoTo(PostType.Posts);
            ListPostPage.StoreCount();

            // add a new post
            NewPostPage.GoTo();
            NewPostPage.CreatePost("Added posts show up, title")
                .WithBody("Added posts show up, body")
                .Publish();

            // go to posts, get new post count
            ListPostPage.GoTo(PostType.Posts);
            Assert.AreEqual(ListPostPage.PreviousPostCount + 1, ListPostPage.CurrentPostCount, "Post count did not match");

            // check for added post
            Assert.IsTrue(ListPostPage.DoesPostExistWithTitle("Added posts show up, title"));

            // delete post
            ListPostPage.DeletePost("Added posts show up, title");
            Assert.AreEqual(ListPostPage.PreviousPostCount, ListPostPage.CurrentPostCount, "Could not delete post");

        }

        [TestMethod]
        public void Can_Search_Posts()
        {
            // create new post
            NewPostPage.GoTo();
            NewPostPage.CreatePost("Searching posts, title")
                .WithBody("Searching posts, body")
                .Publish();

            // go to list posts
            ListPostPage.GoTo(PostType.Posts);

            // search for post
            ListPostPage.SearchForPost("Searching posts, title");

            // check that post shows up in results
            Assert.IsTrue(ListPostPage.DoesPostExistWithTitle("Search posts, title"));

            // delete post
            ListPostPage.DeletePost("Searching posts, title");
        }
    }
}