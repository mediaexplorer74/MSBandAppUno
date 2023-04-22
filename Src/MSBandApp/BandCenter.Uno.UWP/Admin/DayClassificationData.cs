using System.Runtime.InteropServices;

namespace Microsoft.Band.Admin;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct DayClassificationData
{
    public DayClassificationType PredictedClass;

    public byte SequenceId;
}
