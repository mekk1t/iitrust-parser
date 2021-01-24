using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSP.Abstractions;

namespace Implementations
{
    public class ArticlesSectionParser : IPageParser<string>
    {
        private readonly IPageParser<string> articlePageParser;

        public string GetPageContent(string pageUrl)
        {
            throw new NotImplementedException();
        }
    }
}
