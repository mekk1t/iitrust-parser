using ArticlesParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArticleParserTests
{
    public class ArticleSectionParserTests
    {
        [Fact]
        public void Foo()
        {
            var parser = new ArticleSectionParser(new ArticlePageParser());

            var result = parser.GetPageContent("https://iitrust.ru/articles");


        }
    }
}
