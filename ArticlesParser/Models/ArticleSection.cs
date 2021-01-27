using Kernel.Abstractions;
using System.Collections.Generic;

namespace ArticlesParser.Models
{
    public class ArticleSection
    {
        public string Title { get; }
        public string OldImageBase64 { get; set; }
        public string NewImageBase64 { get; set; }
        public IEnumerable<IArticle> Articles { get; set; }
    }
}
