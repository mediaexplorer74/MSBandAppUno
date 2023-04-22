using System;

namespace Microsoft.Band.Admin;

public sealed class TileTextbox : TilePageElement, ITileTextbox, ITilePageElement
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

    public override ushort ElementType => 3001;

    public TileTextbox(ushort elementId, string textboxValue)
        : base(elementId)
    {
        TextboxValue = textboxValue;
    }
}
