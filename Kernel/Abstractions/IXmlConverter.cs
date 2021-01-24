namespace WSP.Abstractions
{
    public interface IXmlConverter<in THtmlResult, out TXmlResult>
    {
        TXmlResult ConvertToXml(THtmlResult html);
    }
}
