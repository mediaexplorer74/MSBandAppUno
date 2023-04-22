using System;

namespace Microsoft.Band.Admin;

public sealed class TileIconbox : TilePageElement, ITileIconbox, ITilePageElement
{
    private ushort iconIndex;

    public ushort IconIndex
    {
        get
        {
            return iconIndex;
        }
        set
        {
            if (value >= 10)
            {
                throw new ArgumentOutOfRangeException("IconIndex");
            }
            iconIndex = value;
        }
    }

    public override ushort ElementType => 3101;

    public TileIconbox(ushort elementId, ushort iconIndex)
        : base(elementId)
    {
        IconIndex = iconIndex;
    }
}
