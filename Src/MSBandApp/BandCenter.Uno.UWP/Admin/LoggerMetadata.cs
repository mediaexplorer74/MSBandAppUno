using System.Runtime.InteropServices;

namespace Microsoft.Band.Admin;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct LoggerMetadata
{
    public uint ChunkSize;

    public uint SequenceNumber;
}
