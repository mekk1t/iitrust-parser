namespace WSP.Models
{
    public class ArticlesParseResult
    {
        public string Title { get; }
        public string Url { get; }
        public string ImageBase64 { get; }
        public string Content { get; }

        public ArticlesParseResult(string title, string url, string imageBase64, string content)
        {
            this.Title = title;
            this.Url = url;
            this.ImageBase64 = imageBase64;
            this.Content = content;
        }
    }
}
