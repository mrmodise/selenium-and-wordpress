using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressAutomation
{
    public class Driver
    {
        // return driver singleton
        public static IWebDriver Instance
        {
            get; set;
        }

        // setup driver 
        public static void Initialize()
        {
            // use firefox browser
            Instance = new FirefoxDriver();

            // wait 5 seconds 
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        // close driver when done with it
        public static void Close()
        {
            // close driver
            Instance.Close();
        }
    }
}
