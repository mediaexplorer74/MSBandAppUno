using System;

namespace Microsoft.Band.Admin;

public sealed class TileWrappableTextbox : TilePageElement, ITileWrappableTextbox, ITilePageElement
{
    private string textboxValue;

    public string TextboxValue
    {
        get
        {
            return textboxValue;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            textboxValue = value;
        }
    }

    public override ushort ElementType => 3002;

    public TileWrappableTextbox(ushort elementId, string textboxValue)
        : base(elementId)
    {
        TextboxValue = textboxValue;
    }
}
