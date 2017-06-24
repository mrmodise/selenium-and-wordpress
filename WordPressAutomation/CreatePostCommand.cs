using WordPressAutomation;
using OpenQA.Selenium;
using System.Threading;

namespace WordPressTests
{
    public class CreatePostCommand
    {
        private readonly string title;
        private string body;

        public CreatePostCommand(string title)
        {
            this.title = title;
        }

        public CreatePostCommand WithBody(string body)
        {
            this.body = body;
            return this;
        }

        public void Publish()
        {
            Driver.Instance.FindElement(By.Id("title")).SendKeys(title);

            Driver.Instance.SwitchTo().Frame("content_ifr");
            Driver.Instance.SwitchTo().ActiveElement().SendKeys(body);
            Driver.Instance.SwitchTo().DefaultContent();

            Thread.Sleep(1000);

            Driver.Instance.FindElement(By.Id("publish")).Click();
        }
    }
}