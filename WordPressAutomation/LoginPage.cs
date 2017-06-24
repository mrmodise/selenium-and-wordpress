using OpenQA.Selenium.Support.UI;
using System;

namespace WordPressAutomation
{
    public static class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + "wp-login.php");

            // wait 5 seconds 
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "user_login");
        }

        public static LoginCommand LoginAs(string username)
        {
            return new LoginCommand(username);
            
        }
    }
}
