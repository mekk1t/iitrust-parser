using System.Collections.Generic;

namespace WSP.Interfaces
{
    public interface IParser<TResult>
    {
        TResult ParseSite(string siteUrl);
        void SaveParseResult(TResult result);
        void SaveParseResult(IEnumerable<TResult> results);
    }
}
