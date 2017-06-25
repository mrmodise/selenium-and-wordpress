using OpenQA.Selenium;

namespace WordPressAutomation
{
    public partial class LeftNavigation
    {
        /**
         * Selects left navigation menu link
         */
        public static void Select(string topLevelMenuId, string subMenuLinkText)
        {
            Driver.Instance.FindElement(By.Id(topLevelMenuId)).Click();
            Driver.Instance.FindElement(By.Id(subMenuLinkText)).Click();
        }

        public class Posts
        {
            public class AddNew
            {
                /**
                 * Selects link to add new post
                 */
                public static void Select()
                {
                    MenuSelector.Select("menu-posts", "Add New");
                }
            }
        }

        public class Pages
        {
            public class AllPages
            {
                /**
                 * Select link to show all posts
                 */
                public static void Select()
                {
                    MenuSelector.Select("menu-posts", "All Posts");
                }
            }
        }
    }
}