namespace IssuesResearch.Core.Services
{
    using System;
    using IssuesResearch.Core.Services.Interfaces;
    using IssuesResearch.Core.ServiceSupport.Interfaces;
    using IssuesResearch.Core.Shared.Constants;
    using IssuesResearch.Core.Shared.Types;
    using OpenQA.Selenium;

    public class MouseActionsBuilder : IMouseActionsBuilder
    {
        private readonly ITimeManager timeManager;

        public MouseActionsBuilder(ITimeManager timeManager)
        {
            this.timeManager = timeManager ?? throw new ArgumentNullException(ExceptionConstants.TIME_MANAGER);
        }

        public void PressElement(IWebElement element)
        {
            element.Click();
            this.timeManager.DelayPage(DelayType.Double);
        }
    }
}