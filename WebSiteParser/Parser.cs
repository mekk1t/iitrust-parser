using System.Collections.Generic;
using WSP.Interfaces;

namespace WSP
{
    public class Parser : IParser<string>
    {
        public string ParseSite(string siteUrl)
        {
            throw new System.NotImplementedException();
        }

        public void SaveParseResult(string result)
        {
            throw new System.NotImplementedException();
        }

        public void SaveParseResult(IEnumerable<string> results)
        {
            throw new System.NotImplementedException();
        }
    }
}
