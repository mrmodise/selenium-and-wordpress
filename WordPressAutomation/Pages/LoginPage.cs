using OpenQA.Selenium.Support.UI;
using System;

namespace WordPressAutomation
{
    public static class LoginPage
    {
        /**
         * navigates to the login page
         */
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + "wp-login.php");
            // keep trying to detect username for 10 seconds
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(1));
            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "user_login");
        }

        /*
         * logs the user in based on user-name 
         */
        public static LoginCommand LoginAs(string username)
        {
            return new LoginCommand(username);
        }
    }
}
