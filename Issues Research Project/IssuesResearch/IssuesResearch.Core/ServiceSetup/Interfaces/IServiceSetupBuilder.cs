namespace IssuesResearch.Core.ServiceSetup.Interfaces
{
    using IssuesResearch.Core.Services.Interfaces;

    public interface IServiceSetupBuilder
    {
        IWebElementsFinder ElementsFinder { get; }

        IScreenshotMaker ScreenshotMaker { get; }

        IWebPageNavigator PageNavigator { get; }

        IWebPageScroller PageScroller { get; }

        IMouseActionsBuilder MouseActionsBuilder { get; }
    }
}