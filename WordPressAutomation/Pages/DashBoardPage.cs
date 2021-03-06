﻿using WordPressAutomation;
using OpenQA.Selenium;

namespace WordPressAutomation
{
    public static class DashBoardPage
    {
        /**
         * checks if the user is at the dashboard page
         */
        public static bool IsAt
        {
            get
            {
                // collect all the h1 tags in the Dashboard page
                var h2s = Driver.Instance.FindElements(By.TagName("h1"));

                // check if we found more than 1 h1 tags
                if(h2s.Count > 0)
                {
                    // check if the 1st one has text dashboard, if yes, we at home page
                    return h2s[0].Text == "Dashboard";
                }
                else
                {
                    // if not we not at home page
                    return false;
                }
            }
        }
    }
}