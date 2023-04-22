using System.Runtime.Serialization;

namespace Microsoft.Band.Admin;

[DataContract]
public sealed class CloudProfileDeviceLink
{
    [DataMember(EmitDefaultValue = true)]
    public string LastKDKSyncUpdateOn;

    [DataMember]
    public DeviceLinkIds ApplicationSettings;

    [DataMember]
    public DeviceLinkIds DeviceSettings;
}
