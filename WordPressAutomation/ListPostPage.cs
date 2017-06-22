using System;
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
                    Driver.Instance.FindElement(By.Id("menu-pages")).Click();
                    Driver.Instance.FindElement(By.Id("All Pages")).Click();
                    break;

            }
        }

        public static void SelectPost(string title)
        {
            var postLink = Driver.Instance.FindElement(By.LinkText("Sample Page"));
            postLink.Click();
        }

        public enum PostType
        {
            Page
        }
    }
}
