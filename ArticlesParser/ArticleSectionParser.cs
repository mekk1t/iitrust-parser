using AngleSharp;
using AngleSharp.Dom;
using Kernel.Abstractions;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WSP.Abstractions;

namespace ArticlesParser
{
    public class ArticleSectionParser : IPageParser<IEnumerable<IArticle>>
    {
        private readonly IPageParser<IArticle> articlePageParser;

        public ArticleSectionParser(IPageParser<IArticle> articlePageParser)
        {
            this.articlePageParser = articlePageParser;
        }

        public IEnumerable<IArticle> GetPageContent(string pageUrl)
        {
            IDocument page;
            var result = new ConcurrentBag<IArticle>();

            using (var client = new HttpClient())
            {
                var response = client.GetStringAsync(pageUrl).Result;
                page = BrowsingContext.New().OpenAsync(c => c.Content(response)).Result;
            }

            var navigationLinks = GetNavigationLinksFromPage(page).Select(l => pageUrl.Split("/articles").First() + l);

            var lastLinkSplitBySlash = navigationLinks.Last().Split('/');
            var lastLinkLastPart = navigationLinks.Last().Split('/').ElementAt(lastLinkSplitBySlash.Length - 2);
            var lastNav = GetNumberFromString(lastLinkLastPart);

            for (int i = 1; i <= lastNav; i++)
            {
                var url = pageUrl + $"/p_{i}";
                using (var client = new HttpClient())
                {
                    var response = client.GetStringAsync(url).Result;
                    page = BrowsingContext.New().OpenAsync(c => c.Content(response)).Result;
                }

                var links = GetArticleLinksFromPage(page).Select(l => pageUrl.Split("/article").First() + l);

                Parallel.ForEach(links, link =>
                {
                    result.Add(articlePageParser.GetPageContent(link));
                });
            }

            return result;
        }

        private string[] GetArticleLinksFromPage(IDocument document)
        {
            return document.All
                .Where(e => e.ClassList.Contains("iit-article"))
                .Children("a")
                .Select(link => link.GetAttribute("href"))
                .ToArray();
        }

        private string[] GetNavigationLinksFromPage(IDocument document)
        {
            var navigationElement = document.All.Where(e => e.ClassList.Contains("iit-pagination")).First();

            return navigationElement
                .GetElementsByClassName("iit-pagination__link")
                .Select(link => link.GetAttribute("href"))
                .ToArray();
        }

        private int GetNumberFromString(string str)
        {
            var numbers = str.Where(c => int.TryParse(c.ToString(), out _)).ToArray();

            var result = int.Parse(numbers);

            return result;
        }
    }
}
