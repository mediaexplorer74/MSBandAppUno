using System.Runtime.InteropServices;

namespace Microsoft.Band.Admin;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
public struct CortanaNotificationData
{
    public CortanaStatus Status;

    public ushort StringLengthInBytes;

    public byte RSVD1;

    public byte RSVD2;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 320)]
    public string String;
}
