using System.Runtime.InteropServices;

namespace Microsoft.Band.Admin;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct BTNotification
{
    public BTEventType EventType;

    public uint NumCompValue;
}
