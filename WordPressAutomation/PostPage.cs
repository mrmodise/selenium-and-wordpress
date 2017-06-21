using System;
using OpenQA.Selenium;
using WordPressAutomation;

namespace WordPressAutomation
{
    public class PostPage
    {
        public static string Title
        {
            get
            {
                var title = Driver.Instance.FindElement(By.ClassName("entry-title"));

                if(title != null)
                {
                    return title.Text;
                }
                else
                {
                    return "";
                }

            }
        }
    }
}
