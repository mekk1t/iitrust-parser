namespace WSP.Abstractions
{
    public interface IPageParser<TResult>
    {
        TResult GetPageContent(string pageUrl);
    }
}
