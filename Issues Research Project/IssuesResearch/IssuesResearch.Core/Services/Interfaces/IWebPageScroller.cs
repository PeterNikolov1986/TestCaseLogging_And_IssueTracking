namespace IssuesResearch.Core.Services.Interfaces
{
    using OpenQA.Selenium;

    public interface IWebPageScroller
    {
        void ScrollToCorrectPosition(IWebElement element);

        void FindCorrectLocation(int position);
    }
}