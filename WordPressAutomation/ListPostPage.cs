using OpenQA.Selenium;

namespace WordPressAutomation
{
    public static class ListPostPage
    {
        public static void GoTo(PostType postType)
        {
            switch (postType)
            {
                case PostType.Page:
                    var menuPosts = Driver.Instance.FindElement(By.Id("menu-posts"));
                    menuPosts.Click();
                    var allPosts = Driver.Instance.FindElement(By.LinkText("All Posts"));
                    allPosts.Click();
                    break;
            }
        }

        public static void SelectPost(string title)
        {
            var postLink = Driver.Instance.FindElement(By.LinkText("Career"));
            postLink.Click();
        }

        public enum PostType
        {
            Page
        }
    }
}
