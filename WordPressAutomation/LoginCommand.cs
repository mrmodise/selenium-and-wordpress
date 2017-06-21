using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressAutomation
{
    public class LoginCommand
    {
        private readonly string username;
        private string password;

        public LoginCommand(string username)
        {
            this.username = username;
        }

        /**
         * set password user will login with
         */
        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
            
        }

        /**
         * handles login related functionality
         *
         */
        public void Login()
        {
            // locate username field, enter username and submit
            var loginInput = Driver.Instance.FindElement(By.Id("user_login"));
            loginInput.SendKeys(username);

            // locate password field, enter password and submit
            var passwordInput = Driver.Instance.FindElement(By.Id("user_pass"));
            passwordInput.SendKeys(password);

            // locate login button and click it
            var loginButton = Driver.Instance.FindElement(By.Id("wp-submit"));
            loginButton.Click();
            
        }
    }
}
