using AngleSharp;
using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IitrustParser.Extensions
{
    public static class StringExtensions
    {
        public static IDocument AsHTML(this string rawHtml)
        {
            return BrowsingContext.New().OpenAsync(r => r.Content(rawHtml)).Result;
        }
    }
}
