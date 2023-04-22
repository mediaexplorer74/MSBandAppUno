using System.Runtime.InteropServices;

namespace Microsoft.Band.Admin;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Config_PCBPermanent
{
    public byte PCBID;

    public byte ConfigurationRecordVersion;

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] SerialNumber;

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
    public byte[] BTMACAddress;

    [MarshalAs(UnmanagedType.Bool)]
    public bool IsPermanentyConfigValid;

    [MarshalAs(UnmanagedType.Bool)]
    public bool IsLocked;
}
