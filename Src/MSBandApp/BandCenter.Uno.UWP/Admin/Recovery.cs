using System.Runtime.InteropServices;

namespace Microsoft.Band.Admin;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Recovery
{
    public ushort RecoveryTime;

    public FitnessProfile FitnessProfile;
}
