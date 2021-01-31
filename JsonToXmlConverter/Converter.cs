using Newtonsoft.Json;
using System;
using System.Xml.Linq;

namespace JsonToXmlConverter
{
    public class Converter
    {
        static string convert(string jsonString)
        {
            XNode node = JsonConvert.DeserializeXNode(jsonString, "Root");

            return node.ToString();
        }
    }
}
