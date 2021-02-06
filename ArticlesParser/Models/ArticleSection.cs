using Kernel.Abstractions;
using System.Collections.Generic;

namespace ArticlesParser.Models
{
    public class ArticleSection
    {
        public IEnumerable<IArticle> Articles { get; set; }
    }
}
