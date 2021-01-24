using Kernel.Abstractions;
using System.Collections.Generic;
using WSP.Abstractions;
using WSP.Models;

namespace WSP
{
    public class IitrustRuArticlesParser : IWebSiteArticlesParser
    {
        private readonly IPageParser<IEnumerable<IArticle>> parser;
        private readonly IXmlConverter<XmlConvertRequest, XmlConvertResponse> converter;
        private readonly IResultSaver<string> resultSaver;

        public IitrustRuArticlesParser(
            IPageParser<IEnumerable<IArticle>> parser,
            IXmlConverter<XmlConvertRequest, XmlConvertResponse> converter,
            IResultSaver<string> resultSaver)
        {
            this.parser = parser;
            this.converter = converter;
            this.resultSaver = resultSaver;
        }

        public void ParseArticlesFromSite(string siteArticlesUrl)
        {
            var result = parser.GetPageContent(siteArticlesUrl);
            var xmlResult = converter.ConvertToXml(new XmlConvertRequest(result));
            resultSaver.SaveResult(xmlResult.ToString());
        }

        public void ParseArticlesFromSiteToXml(string siteUrl)
        {
            var result = parser.GetPageContent(siteUrl);
            var xmlResult = converter.ConvertToXml(new XmlConvertRequest(result));
            resultSaver.SaveResult(xmlResult.ToString());
        }
    }
}
