﻿namespace IssuesResearch.Core.ServiceSupport.Services
{
    using System;
    using IssuesResearch.Core.ServiceSupport.Interfaces;
    using IssuesResearch.Core.Shared.Constants;
    using IssuesResearch.Core.Shared.Types;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class TimeManager : ITimeManager
    {
        private readonly IWebDriver driver;
        private WebDriverWait wait;

        public TimeManager(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(ExceptionConstants.WEB_DRIVER);
        }

        public void DelayPage(DelayType type)
        {
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromMilliseconds((double)type));
            DateTime now = DateTime.Now;

            this.wait.Until(wd => (DateTime.Now - now) - TimeSpan.FromMilliseconds((double)type) > TimeSpan.Zero);
        }
    }
}