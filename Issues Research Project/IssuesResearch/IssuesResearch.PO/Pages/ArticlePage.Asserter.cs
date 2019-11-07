namespace IssuesResearch.PO.Pages
{
    using System;
    using System.Linq;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Remote;

    public partial class ArticlePage
    {
        public void AssertThat_QuickNavigationHyperlink_ScrollsPageTo_ProperSection(IWebElement navigationHyperlink)
        {
            RemoteWebElement hyperlink = (RemoteWebElement)navigationHyperlink;

            this.ScrollQuickNavigationHyperlink(hyperlink);

            string navigationHyperlinkHref = hyperlink.GetAttribute("href");
            string sectionID = navigationHyperlinkHref.Substring(navigationHyperlinkHref.IndexOf('#') + 1);
            IWebElement articleSection = this.ArticleSection(sectionID);
            RemoteWebElement section = (RemoteWebElement)articleSection;

            this.mouseActions.PressElement(hyperlink);
            this.ScrollQuickNavigationHyperlink(hyperlink);

            Assert.That(section.Displayed);
            Assert.AreEqual(hyperlink.Text, section.Text);
        }
    }
}