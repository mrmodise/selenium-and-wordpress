using WordPressAutomation;
using OpenQA.Selenium;
using System.Threading;
using System;

namespace WordPressAutomation
{
    public class CreatePostCommand
    {
        // create post title and body placeholders
        private readonly string title;
        private string body;
        
        public CreatePostCommand(string title)
        {
            this.title = title;
        }

        /**
         * parses the body of the post
         */
        public CreatePostCommand WithBody(string body)
        {
            this.body = body;
            return this;
        }

        /**
         * handles clicking on publish post button
         */
        public void Publish()
        {
            Driver.Instance.FindElement(By.Id("title")).SendKeys(title);
            Driver.Instance.SwitchTo().Frame("content_ifr");
            Driver.Instance.SwitchTo().ActiveElement().SendKeys(body);
            Driver.Instance.SwitchTo().DefaultContent();
            Driver.Wait(TimeSpan.FromSeconds(1));
            Driver.Instance.FindElement(By.Id("publish")).Click();
        }
    }
}