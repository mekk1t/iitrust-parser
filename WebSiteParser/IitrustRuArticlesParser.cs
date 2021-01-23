using WSP.Abstractions;
using WSP.Models;

namespace WSP
{
    public class IitrustRuArticlesParser : IWebSiteArticlesParser
    {
        private readonly IPageParser<ArticlesParseResult> parser;
        private readonly IXmlConverter<XmlConvertRequest, XmlConvertResponse> converter;
        private readonly IResultSaver resultSaver;

        public void ParseArticlesFromSite(string siteUrl)
        {
            var result = parser.GetPageContent(siteUrl);
            var xmlResult = converter.ConvertToXml(new XmlConvertRequest
            {
                Data = result
            });

            resultSaver.SaveResult(xmlResult.ToString());
        }
    }
}
