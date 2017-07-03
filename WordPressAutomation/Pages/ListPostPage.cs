using OpenQA.Selenium;
using System.Linq;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;

namespace WordPressAutomation
{
    public static class ListPostPage
    {
        // lists the posts'last count
        private static int lastCount;

        // lists previous post count
        public static int PreviousPostCount { get { return lastCount; } }

        // lists current post count
        public static object CurrentPostCount { get { return GetPostCount(); } }

        // checks to see if we are at a particular post/page
        public static bool IsAt
        {
            get
            {
                // collect all the h1 tags in the page
                var h2s = Driver.Instance.FindElements(By.TagName("h1"));

                // check if we found more than 1 h1 tags
                if (h2s.Count > 0)
                {
                    // check if the 1st one has text posts
                    return h2s[0].Text == "Posts";
                }
                else
                {
                    // if not we not at posts page
                    return false;
                }
            }
        }

        /**
         * Navigates to a post/page and show all posts
         */
        public static void GoTo(PostType postType)
        {
            switch (postType)
            {
                case PostType.Page:
                case PostType.Posts:
                    LeftNavigation.Pages.AllPages.Select();
                    break;
            }
        }

        /**
         * Select the career post
         */
        public static void SelectPost(string title)
        {
            var postLink = Driver.Instance.FindElement(By.LinkText("Career"));
            postLink.Click();
        }
        
        // different post types
        public enum PostType
        {
            Page,
            Posts
        }

        /*
         * Checks if a post with a given title exists
         */
        public static bool DoesPostExistWithTitle(string title)
        {
            return Driver.Instance.FindElements(By.LinkText(title)).Any();
        }

        /**
         * Delete a post given by the title
         */
        public static void DeletePost(string title)
        {
            // retrieve the table rows
            var rows = Driver.Instance.FindElements(By.TagName("tr"));

            // loop through all table rows
            foreach(var row in rows)
            {
                ReadOnlyCollection<IWebElement> links = null;

                // retrive the links that match the provided title
                Driver.NoWait(() => links = row.FindElements(By.LinkText(title)));

                if(links.Count > 0)
                {
                    // hover over the selected link and click trash to delete post
                    Actions action = new Actions(Driver.Instance);
                    action.MoveToElement(links[0]);
                    action.Perform();
                    row.FindElement(By.ClassName("submitdelete")).Click();
                    return;
                }
            }
        }

        /**
         *  Searches for a particular
         */
        public static void SearchForPost(string searchString)
        {
            if (!IsAt)
            {
                // go to post
                GoTo(PostType.Posts);
            }

            var searchBox = Driver.Instance.FindElement(By.Id("post-search-input"));
            searchBox.SendKeys(searchString);

            var searchButton = Driver.Instance.FindElement(By.Id("search-submit"));
            searchBox.Click();
        }

        /**
         * Keeps record of posts added
         */
        public static void StoreCount()
        {
            lastCount = GetPostCount();
        }

        /**
         * Retrieves the count of added posts
         */
        public static int GetPostCount()
        {
            var countText = Driver.Instance.FindElement(By.ClassName("displaying-num")).Text;
            return int.Parse(countText.Split(' ')[0]);
        }
    }
}
