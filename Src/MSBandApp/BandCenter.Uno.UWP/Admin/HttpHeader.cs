namespace Microsoft.Band.Admin;

public class HttpHeader
{
    public string Name { get; private set; }

    public string Value { get; private set; }

    public HttpHeader(string name, string value)
    {
        Name = name;
        Value = value;
    }
}
