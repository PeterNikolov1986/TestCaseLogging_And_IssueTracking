namespace IssuesResearch.Core.Services
{
    using System;
    using IssuesResearch.Core.Services.Interfaces;
    using IssuesResearch.Core.ServiceSupport.Interfaces;
    using IssuesResearch.Core.Shared.Constants;
    using IssuesResearch.Core.Shared.Types;
    using OpenQA.Selenium;

    public class WebPageScroller : IWebPageScroller
    {
        private readonly IJavaScriptExecutor jse;
        private readonly ITimeManager timeManager;

        public WebPageScroller(IJavaScriptExecutor jse, ITimeManager timeManager)
        {
            this.jse = jse ?? throw new ArgumentNullException(ExceptionConstants.JSE);
            this.timeManager = timeManager ?? throw new ArgumentNullException(ExceptionConstants.TIME_MANAGER);
        }
        
        public void ScrollToCorrectPosition(IWebElement element)
        {
            this.jse.ExecuteScript("arguments[0].scrollIntoView();", element);
        }

        public void FindCorrectLocation(int position)
        {
            this.jse.ExecuteScript($"window.scrollTo(0, {position})");
            this.timeManager.DelayPage(DelayType.Double);
        }
    }
}