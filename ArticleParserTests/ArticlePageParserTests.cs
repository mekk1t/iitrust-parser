using ArticlesParser;
using Xunit;

namespace ArticleParserTests
{
    public class ArticlePageParserTests
    {
        [Fact]
        public void Test1()
        {
            var parser = new ArticlePageParser();

            var result = parser.GetPageContent("https://iitrust.ru/articles/expert/izmeneniya-v-trudovom-zakonodatelstve-trudovye-otnosheniya-i-edo-s-distantsionnymi-rabotnikami-v-2021-godu");

            Assert.NotNull(result);
        }
    }
}
