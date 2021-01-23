namespace WSP.Models
{
    public class ArticlesParseResult
    {
        private string placeholderImage;

        private readonly string imageBase64;

        public string Title { get; }
        public string Url { get; }
        public string ImageBase64
        {
            get
            {
                if (string.IsNullOrWhiteSpace(imageBase64))
                {
                    if (!string.IsNullOrWhiteSpace(placeholderImage))
                        return placeholderImage;

                    return string.Empty;
                }

                return imageBase64;
            }
        }
        public string Content { get; }

        public ArticlesParseResult(string title, string url, string imageBase64, string content)
        {
            this.Title = title;
            this.Url = url;
            this.imageBase64 = imageBase64;
            this.Content = content;
        }

        public void SetPlaceholderImage(string placeholderImage)
        {
            this.placeholderImage = placeholderImage;
        }
    }
}
