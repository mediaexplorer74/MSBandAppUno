using System.Runtime.Serialization;

namespace Microsoft.Band.Admin;

[DataContract]
public sealed class CloudProfileFirmwareBytes
{
    [DataMember]
    public CloudDeviceSettingsFirmwareBytes DeviceSettings;
}
