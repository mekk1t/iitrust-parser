using Kernel.Abstractions;
using System.Collections.Generic;

namespace WSP.Models
{
    public class XmlConvertRequest
    {
        public IEnumerable<IArticle> Data { get; }

        public XmlConvertRequest(IEnumerable<IArticle> dataToConvert)
        {
            this.Data = dataToConvert;
        }
    }
}
