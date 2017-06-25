﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace WordPressAutomation
{
    public class Driver
    {
        // return driver singleton
        public static IWebDriver Instance
        {
            get; set;
        }

        // return base url
        public static string BaseAddress { get { return "http://seleniumtests-com.stackstaging.com/"; } }

        /**
         * Setup driver
         */
        public static void Initialize()
        {
            // use firefox browser
            Instance = new FirefoxDriver();

            // wait 5 seconds 
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        /**
         * Close driver when done with it
         */
        public static void Close()
        {
            // close driver
            Instance.Close();
        }

        /**
         * sets the time for Selenium to keep trying to detect an element
         */
        public static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int) timeSpan.TotalSeconds * 1000);
        }
    }
}