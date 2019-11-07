namespace IssuesResearch.Core.ServiceSupport.Interfaces
{
    using IssuesResearch.Core.Shared.Types;

    public interface ITimeManager
    {
        void DelayPage(DelayType type);
    }
}