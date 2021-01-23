using System.Collections.Generic;

namespace WSP.Models
{
    public class XmlConvertRequest
    {
        public IEnumerable<ArticlesParseResult> Data { get; }

        public XmlConvertRequest(IEnumerable<ArticlesParseResult> dataToConvert)
        {
            this.Data = dataToConvert;
        }
    }
}
