namespace WSP.Models
{
    public class XmlConvertResponse
    {
        public string Xml { get; }

        public XmlConvertResponse(string xmlConvertResult)
        {
            this.Xml = xmlConvertResult;
        }
    }
}
