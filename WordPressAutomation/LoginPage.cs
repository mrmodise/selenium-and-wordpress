using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressAutomation
{
    public static class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://seleniumtests-com.stackstaging.com/wp-login.php");
        }

        public static LoginCommand LoginAs(string username)
        {
            return new LoginCommand(username);
            
        }
    }
}
