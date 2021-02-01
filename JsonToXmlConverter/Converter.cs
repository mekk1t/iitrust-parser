using Newtonsoft.Json;
using System.Xml.Linq;
using WSP.Abstractions;
using WSP.Models;

namespace JsonToXmlConverter
{
    public class Converter: IXmlConverter<XmlConvertRequest, XmlConvertResponse>
    {
        public XmlConvertResponse ConvertToXml(XmlConvertRequest req)
        {
            var convert = req.Data;
            string jsonString = JsonConvert.SerializeObject(convert);

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
