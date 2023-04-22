using System.Runtime.InteropServices;

namespace Microsoft.Band.Admin;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct LoggerSubscriptionsList
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] ActiveSubscriptions;

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] PassiveSubscritpions;
}
