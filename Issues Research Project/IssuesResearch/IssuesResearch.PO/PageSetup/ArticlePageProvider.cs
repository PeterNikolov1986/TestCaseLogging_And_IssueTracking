namespace IssuesResearch.PO.PageSetup
{
    using System;
    using IssuesResearch.Core.ServiceSetup.Interfaces;
    using IssuesResearch.Core.Shared.Constants;
    using IssuesResearch.PO.Pages;

    public class ArticlePageProvider
    {
        private readonly IServiceSetupBuilder serviceSetup;

        public ArticlePageProvider(IServiceSetupBuilder serviceSetup)
        {
            this.serviceSetup = serviceSetup ?? throw new ArgumentNullException(ExceptionConstants.SERVICE_SETUP);
        }

        public ArticlePage ArticlePage
        {
            get
            {
                return new ArticlePage(this.serviceSetup.ElementsFinder,
                    this.serviceSetup.ScreenshotMaker,
                    this.serviceSetup.PageScroller,
                    this.serviceSetup.MouseActionsBuilder);
            }
        }
    }
}