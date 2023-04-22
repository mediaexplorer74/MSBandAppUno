using System.Runtime.InteropServices;

namespace Microsoft.Band.Admin;

public struct FitnessPlanWorkout
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] Id;

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
    public byte[] Name;

    public byte NameLength;

    public ushort CircuitCount;

    public CompletionType CompletionType;

    public uint CompletionValue;
}
