using System.Runtime.InteropServices;

namespace Microsoft.Band.Admin;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct KeyboardCmdSample
{
    public const int MAX_NUM_OF_CANDIDATES = 4;

    public const int MAX_KBDCMD_DATA_LEN = 400;

    public KeyboardMessageType KeyboardMsgType;

    public byte NumOfCandidates;

    public byte WordIndex;

    public uint DataLength;

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 400)]
    public byte[] Datafield;
}
