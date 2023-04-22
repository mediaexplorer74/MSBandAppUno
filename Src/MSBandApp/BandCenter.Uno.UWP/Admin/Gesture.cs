using System.Runtime.InteropServices;

namespace Microsoft.Band.Admin;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Gesture
{
    public ushort PegMessageType;

    public short TouchPointX;

    public short TouchPointY;

    public short FlickPointX;

    public short FlickPointY;

    public short FlickVelocity;

    public short FlickAcceleration;

    public uint TimeStart;

    public uint TimeEnd;
}
