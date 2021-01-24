using System.Collections.Generic;
using WSP.Abstractions;
using WSP.Models;

namespace WSP
{
    public class IitrustRuArticlesParser : IWebSiteArticlesParser
    {
        private readonly IPageParser<IEnumerable<ArticlesParseResult>> parser;
        private readonly IXmlConverter<XmlConvertRequest, XmlConvertResponse> converter;
        private readonly IResultSaver resultSaver;

        public IitrustRuArticlesParser(
            IPageParser<IEnumerable<ArticlesParseResult>> parser,
            IXmlConverter<XmlConvertRequest, XmlConvertResponse> converter,
            IResultSaver resultSaver)
        {
            this.parser = parser;
            this.converter = converter;
            this.resultSaver = resultSaver;
        }

        public void ParseArticlesFromSite(string siteUrl)
        {
            var result = parser.GetPageContent(siteUrl);
            var xmlResult = converter.ConvertToXml(new XmlConvertRequest(result));
            resultSaver.SaveResult(xmlResult.ToString());
        }
    }
}
