namespace IssuesResearch.Core.Services
{
    using System;
    using System.Collections.Generic;
    using IssuesResearch.Core.Services.Interfaces;
    using IssuesResearch.Core.Shared.Constants;
    using OpenQA.Selenium;

    public class WebElementsFinder : IWebElementsFinder
    {
        private readonly IWebDriver driver;

        public WebElementsFinder(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(ExceptionConstants.WEB_DRIVER);
        }

        public IWebElement FindElement(By by)
        {
            return this.driver.FindElement(by);
        }

        public IEnumerable<IWebElement> FindElements(By by)
        {
            return this.driver.FindElements(by);
        }
    }
}