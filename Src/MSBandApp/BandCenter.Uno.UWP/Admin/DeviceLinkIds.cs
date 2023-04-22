using System;
using System.Runtime.Serialization;

namespace Microsoft.Band.Admin;

[DataContract]
public struct DeviceLinkIds
{
    [DataMember(EmitDefaultValue = false)]
    public Guid ApplicationId;

    [DataMember(EmitDefaultValue = false)]
    public Guid? PairedDeviceId;

    [DataMember(EmitDefaultValue = false)]
    public Guid? DeviceId;

    [DataMember(EmitDefaultValue = false)]
    public string SerialNumber;
}
