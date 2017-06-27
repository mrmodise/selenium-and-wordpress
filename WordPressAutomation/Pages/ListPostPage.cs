using System;
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
