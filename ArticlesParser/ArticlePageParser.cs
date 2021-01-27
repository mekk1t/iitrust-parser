using AngleSharp;
using AngleSharp.Dom;
using ArticlesParser.Models;
using Kernel.Abstractions;
using System.Linq;
using System.Net.Http;
using WSP.Abstractions;

namespace ArticlesParser
{
    public class ArticlePageParser : IPageParser<IArticle>
    {
        public IArticle GetPageContent(string pageUrl)
        {
            IDocument page;
            using (var client = new HttpClient())
            {
                var response = client.GetStringAsync(pageUrl).Result;
                page = BrowsingContext.New().OpenAsync(c => c.Content(response)).Result;
            }

            var title = page.GetElementsByClassName("iit-article-head__title").First().Text();
            var content = page.GetElementsByClassName("iit-mix").First().Text();
            content = content.Split("Эта статья была полезной?").First();

            return new ArticlePage
            {
                Title = title,
                Content = content,
                Url = pageUrl
            };
        }
    }
}
