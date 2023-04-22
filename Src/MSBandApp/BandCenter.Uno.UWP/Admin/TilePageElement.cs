namespace Microsoft.Band.Admin;

public abstract class TilePageElement : ITilePageElement
{
    public ushort ElementId { get; set; }

    public abstract ushort ElementType { get; }

    //RnD
    //protected 
    public TilePageElement(ushort elementId)
    {
        ElementId = elementId;
    }
}
