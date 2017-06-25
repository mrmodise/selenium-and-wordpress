using OpenQA.Selenium;

namespace WordPressAutomation
{
    public partial class LeftNavigation
    {
        public class MenuSelector
        {
            /**
             * Selects a particular menu given the menu id and link text
             */
            public static void Select(string topLevelMenuId, string subMenuLinkText)
            {
                Driver.Instance.FindElement(By.Id(topLevelMenuId)).Click();
                Driver.Instance.FindElement(By.LinkText(subMenuLinkText)).Click();
            }
        }
    }
}