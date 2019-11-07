namespace IssuesResearch.Core.ServiceSetup.Services
{
    using System;
    using IssuesResearch.Core.Services;
    using IssuesResearch.Core.Services.Interfaces;
    using IssuesResearch.Core.ServiceSetup.Interfaces;
    using IssuesResearch.Core.ServiceSupport.Interfaces;
    using IssuesResearch.Core.ServiceSupport.Services;
    using IssuesResearch.Core.Shared.Constants;
    using OpenQA.Selenium;

    public class ServiceSetupBuilder : IServiceSetupBuilder
    {
        private readonly IWebDriver driver;

        public ServiceSetupBuilder(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(ExceptionConstants.WEB_DRIVER);
        }

        public IWebElementsFinder ElementsFinder
        {
            get
            {
                return new WebElementsFinder(this.driver);
            }
        }

        public IScreenshotMaker ScreenshotMaker
        {
            get
            {
                return new ScreenshotMaker(this.driver);
            }
        }

        public IWebPageNavigator PageNavigator
        {
            get
            {
                return new WebPageNavigator(this.driver, this.GetTimeManager());
            }
        }

        public IWebPageScroller PageScroller
        {
            get
            {
                return new WebPageScroller(this.GetJavaScriptExecutor(), this.GetTimeManager());
            }
        }

        public IMouseActionsBuilder MouseActionsBuilder
        {
            get
            {
                return new MouseActionsBuilder(this.GetTimeManager());
            }
        }

        private ITimeManager GetTimeManager()
        {
            return new TimeManager(this.driver);
        }

        private IJavaScriptExecutor GetJavaScriptExecutor()
        {
            return (IJavaScriptExecutor)this.driver;
        }
    }
}