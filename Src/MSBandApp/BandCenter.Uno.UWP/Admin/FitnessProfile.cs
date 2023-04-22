using System.Runtime.InteropServices;

namespace Microsoft.Band.Admin;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct FitnessProfile
{
    public byte MinHr;

    public byte MaxHr;

    public int MaxMET;
}
