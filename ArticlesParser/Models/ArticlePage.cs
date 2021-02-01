using Kernel.Abstractions;

namespace ArticlesParser.Models
{
    public class ArticlePage : IArticle
    {
        public string Content { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
