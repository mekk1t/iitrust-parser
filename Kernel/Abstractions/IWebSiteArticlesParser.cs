namespace WSP
{
    public interface IWebSiteArticlesParser
    {
        void ParseArticlesFromSite(string siteUrl);
        void ParseArticlesFromSiteToXml(string siteUrl);
    }
}
