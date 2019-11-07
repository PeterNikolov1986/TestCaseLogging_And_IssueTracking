namespace IssuesResearch.PO.Pages
{
    using System;
    using IssuesResearch.Core.Services.Interfaces;
    using IssuesResearch.Core.Shared.Constants;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium.Remote;

    public partial class ArticlePage 
    {
        private readonly IWebElementsFinder elementsFinder;
        private readonly IScreenshotMaker screenshotMaker;
        private readonly IWebPageScroller pageScroller;
        private readonly IMouseActionsBuilder mouseActions;

        public ArticlePage(IWebElementsFinder elementsFinder,
            IScreenshotMaker screenshotMaker,
            IWebPageScroller pageScroller,
            IMouseActionsBuilder mouseActions)
        {
            this.elementsFinder = elementsFinder ?? throw new ArgumentNullException(ExceptionConstants.ELEMENT_FINDER);
            this.screenshotMaker = screenshotMaker ?? throw new ArgumentNullException(ExceptionConstants.SCREENSHOT_MAKER);
            this.pageScroller = pageScroller ?? throw new ArgumentNullException(ExceptionConstants.PAGE_SCROLLER);
            this.mouseActions = mouseActions ?? throw new ArgumentNullException(ExceptionConstants.MOUSE_ACTIONS);
        }

        public void TakeScreenshot()
        {
            string testName = TestContext.CurrentContext.Test.Name;

            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                this.screenshotMaker.TakeScreenshot(testName);
            }
        }

        private void ScrollQuickNavigationHyperlink(RemoteWebElement element)
        {
            this.pageScroller.ScrollToCorrectPosition(element);
            this.pageScroller.FindCorrectLocation(this.QuickNavigationSection.Location.Y - this.QuickNavigationSection.Size.Height);
        }
    }
}