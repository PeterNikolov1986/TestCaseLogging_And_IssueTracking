﻿namespace IssuesResearch.Core.Services
{
    using System;
    using IssuesResearch.Core.Services.Interfaces;
    using IssuesResearch.Core.Shared.Constants;
    using OpenQA.Selenium;

    public class ScreenshotMaker : IScreenshotMaker
    {
        private readonly IWebDriver driver;

        public ScreenshotMaker(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(ExceptionConstants.WEB_DRIVER);
        }

        public void TakeScreenshot(string testName)
        {
            Screenshot screenshot = ((ITakesScreenshot)this.driver).GetScreenshot();
            string testFile = @"..\..\..\Screenshots\" + testName + ".png";

            screenshot.SaveAsFile(testFile, ScreenshotImageFormat.Png);
        }
    }
}