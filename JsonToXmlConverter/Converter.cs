using Newtonsoft.Json;
using System.Xml.Linq;
using WSP.Abstractions;
using WSP.Models;
using System.Collections.Generic;
using Kernel.Abstractions;

namespace JsonToXmlConverter
{
    public class Converter: IXmlConverter<XmlConvertRequest, XmlConvertResponse>
    {
        public XmlConvertResponse ConvertToXml(XmlConvertRequest req)
        {
            IEnumerable<IArticle> data = req.Data;
            string jsonString = JsonConvert.SerializeObject(data);

            string result = ConvertJsonToXml(jsonString);

            return new XmlConvertResponse(result);
        }

        private string ConvertJsonToXml(string jsonString)
        {
             XNode node = JsonConvert.DeserializeXNode(jsonString, "Root");

            return node.ToString();
        }
    }
}
