namespace IssuesResearch.PO.Pages
{
    using OpenQA.Selenium;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ArticlePage
    {
        public List<IWebElement> QuickNavigationHyperlinks
        {
            get
            {
                return this.elementsFinder.FindElements(By.CssSelector("div.tve_contents_table.tve_clearfix div a")).ToList();
            }
        }

        private IWebElement QuickNavigationSection
        {
            get
            {
                return this.elementsFinder.FindElement(By.CssSelector("div.ct_column"));
            }
        }

        private IWebElement ArticleSection(string sectionID)
        {
            return this.elementsFinder.FindElement(By.Id(sectionID));
        }
    }
}