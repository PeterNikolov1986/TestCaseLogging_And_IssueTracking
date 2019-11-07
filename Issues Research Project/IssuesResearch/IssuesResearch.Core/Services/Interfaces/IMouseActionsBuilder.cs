namespace IssuesResearch.Core.Services.Interfaces
{
    using OpenQA.Selenium;

    public interface IMouseActionsBuilder
    {
        void PressElement(IWebElement element);
    }
}