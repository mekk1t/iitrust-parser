using AngleSharp;
using AngleSharp.Dom;

namespace WSP.Extensions
{
    public static class StringExtensions
    {
        public static IDocument AsIDocument(this string rawHtml)
        {
            return BrowsingContext
                .New()
                .OpenAsync(r => r.Content(rawHtml))
                .Result;
        }
    }
}
