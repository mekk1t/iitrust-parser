namespace WSP
{
    class Program
    {
        static void Main(string[] args)
        {
            var iitrustRuArticlesParser = new IitrustRuArticlesParser();
            iitrustRuArticlesParser.ParseArticlesFromSite("http://iitrust.ru/articles");
        }
    }
}
