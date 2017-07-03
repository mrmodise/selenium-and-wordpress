using OpenQA.Selenium;
using WordPressAutomation;

namespace WordPressAutomation
{
    public class NewPostPage
    {
        public static object Title
        {
            get
            {
                var title = Driver.Instance.FindElement(By.Id("title"));
                
                if(title != null)
                {
                    return title.GetAttribute("value");
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /**
         * 
         */
        public static void GoTo()
        {
            LeftNavigation.Posts.AddNew.Select();
        }

        /**
         * Handles logic to create new post
         */
        public static CreatePostCommand CreatePost(string title)
        {
            return new CreatePostCommand(title);
        }

        /**
         * Handles navigation to newly created post
         */
        public static void GoToNewPost()
        {
            var message = Driver.Instance.FindElement(By.Id("message"));
            var newPostLink = message.FindElements(By.TagName("a"))[0];
            newPostLink.Click();
        }
        /**
         * 
         */
        public static bool IsInEditMode()
        {
            return Driver.Instance.FindElement(By.Id("content_ifr")) != null;
        }
    }
}