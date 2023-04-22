using System.Runtime.InteropServices;

namespace Microsoft.Band.Admin;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct ButtonEvent
{
    public ButtonType Button;

    public byte ButtonEventDown;
}
