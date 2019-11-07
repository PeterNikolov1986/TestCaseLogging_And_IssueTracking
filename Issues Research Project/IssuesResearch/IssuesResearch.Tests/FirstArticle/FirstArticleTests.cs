namespace IssuesResearch.Tests.FirstArticle
{
    using IssuesResearch.Core.Shared.Constants;
    using IssuesResearch.PO.PageSetup;
    using IssuesResearch.Tests.Base;
    using NUnit.Framework;
    using OpenQA.Selenium;

    [TestFixture]
    public class FirstArticleTests : BaseTests
    {
        private ArticlePageProvider provider;
        private IWebElement navigationHyperlink;

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            this.provider = new ArticlePageProvider(base.ServiceSetupBuilder);
            base.ServiceSetupBuilder.PageNavigator.NavigateToPage(UrlConstants.FIRST_ARTICLE);
        }

        [TearDown]
        public override void TearDown()
        {
            this.provider.ArticlePage.TakeScreenshot();
            base.TearDown();
        }

        [Test]
        public void FirstArticle_FirstQuickNavigationHyperlink_ScrollsPageTo_ProperSection()
        {
            this.navigationHyperlink = this.provider.ArticlePage.QuickNavigationHyperlinks[0];

            this.provider.ArticlePage.AssertThat_QuickNavigationHyperlink_ScrollsPageTo_ProperSection(this.navigationHyperlink);
        }

        [Test]
        public void FirstArticle_SecondQuickNavigationHyperlink_ScrollsPageTo_ProperSection()
        {
            this.navigationHyperlink = this.provider.ArticlePage.QuickNavigationHyperlinks[1];

            this.provider.ArticlePage.AssertThat_QuickNavigationHyperlink_ScrollsPageTo_ProperSection(this.navigationHyperlink);
        }

        [Test]
        public void FirstArticle_ThirdQuickNavigationHyperlink_ScrollsPageTo_ProperSection()
        {
            this.navigationHyperlink = this.provider.ArticlePage.QuickNavigationHyperlinks[2];

            this.provider.ArticlePage.AssertThat_QuickNavigationHyperlink_ScrollsPageTo_ProperSection(this.navigationHyperlink);
        }

        [Test]
        public void FirstArticle_FourthQuickNavigationHyperlink_ScrollsPageTo_ProperSection()
        {
            this.navigationHyperlink = this.provider.ArticlePage.QuickNavigationHyperlinks[3];

            this.provider.ArticlePage.AssertThat_QuickNavigationHyperlink_ScrollsPageTo_ProperSection(this.navigationHyperlink);
        }

        [Test]
        public void FirstArticle_FifthQuickNavigationHyperlink_ScrollsPageTo_ProperSection()
        {
            this.navigationHyperlink = this.provider.ArticlePage.QuickNavigationHyperlinks[4];

            this.provider.ArticlePage.AssertThat_QuickNavigationHyperlink_ScrollsPageTo_ProperSection(this.navigationHyperlink);
        }

        [Test]
        public void FirstArticle_SixthQuickNavigationHyperlink_ScrollsPageTo_ProperSection()
        {
            this.navigationHyperlink = this.provider.ArticlePage.QuickNavigationHyperlinks[5];

            this.provider.ArticlePage.AssertThat_QuickNavigationHyperlink_ScrollsPageTo_ProperSection(this.navigationHyperlink);
        }

        [Test]
        public void FirstArticle_SeventhQuickNavigationHyperlink_ScrollsPageTo_ProperSection()
        {
            this.navigationHyperlink = this.provider.ArticlePage.QuickNavigationHyperlinks[6];

            this.provider.ArticlePage.AssertThat_QuickNavigationHyperlink_ScrollsPageTo_ProperSection(this.navigationHyperlink);
        }

        [Test]
        public void FirstArticle_EighthQuickNavigationHyperlink_ScrollsPageTo_ProperSection()
        {
            this.navigationHyperlink = this.provider.ArticlePage.QuickNavigationHyperlinks[7];

            this.provider.ArticlePage.AssertThat_QuickNavigationHyperlink_ScrollsPageTo_ProperSection(this.navigationHyperlink);
        }
    }
}