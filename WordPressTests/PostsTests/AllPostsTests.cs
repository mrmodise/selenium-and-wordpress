using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomation;
using static WordPressAutomation.ListPostPage;

namespace WordPressTests
{
    [TestClass]
    public class AllPostsTests: WordPressBaseTest
    {
        [TestMethod]
        public void Added_Posts_Show_Up()
        {
            // get post count and store
            ListPostPage.StoreCount();

            // add a new post
            PostCreator.CreatePost();

            // get new post count
            Assert.AreEqual(ListPostPage.PreviousPostCount + 1, ListPostPage.CurrentPostCount, "Post count did not match");

            // check for added post
            Assert.IsTrue(ListPostPage.DoesPostExistWithTitle(PostCreator.PreviousTitle));

            // delete post
            ListPostPage.DeletePost(PostCreator.PreviousTitle);
            Assert.AreEqual(ListPostPage.PreviousPostCount, ListPostPage.CurrentPostCount, "Could not delete post");

        }

        [TestMethod]
        public void Can_Search_Posts()
        {
            // add a new post
            PostCreator.CreatePost();

            // search for post
            ListPostPage.SearchForPost(PostCreator.PreviousTitle);

            // check that post shows up in results
            Assert.IsTrue(ListPostPage.DoesPostExistWithTitle(PostCreator.PreviousTitle));
        }
    }
}
