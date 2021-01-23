using AngleSharp.Dom;
using WSP.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace WSP
{
    class Program
    {
        private const string BASE_URL = "https://iitrust.ru";
        public static List<Preview> ArticlePreviews { get; set; } = new List<Preview>();

        static void Main(string[] args)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync($"{BASE_URL}/articles").Result;

                IDocument document = response.Content.ReadAsStringAsync().Result.AsIDocument();

                var elements = document.All;

                var articlePreviewTitles = elements.Where(e => e.ClassList.Contains("iit-article"));

                foreach (var preview in articlePreviewTitles)
                {
                    var link = preview.QuerySelector("a");
                    var title = preview.QuerySelector(".iit-article__title");
                    var theme = preview.QuerySelector(".iit-article__background");

                    var imageUrl = preview.QuerySelector(".iit-article__img");

                    var articlePreview = new Preview
                    {
                        Title = title.Text(),
                        DetailsUrl = link.GetAttribute("href"),
                        ImageUrl = imageUrl.GetAttribute("data-src"),
                        Theme = theme.ClassList.Where(c => c != "iit-article__background").First()
                    };

                    ArticlePreviews.Add(articlePreview);
                }
            }
        }
    }
}
