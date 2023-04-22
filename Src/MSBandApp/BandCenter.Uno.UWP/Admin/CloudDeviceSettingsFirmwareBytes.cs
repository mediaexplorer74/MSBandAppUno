using System.Runtime.Serialization;

namespace Microsoft.Band.Admin;

[DataContract]
public sealed class CloudDeviceSettingsFirmwareBytes
{
    [DataMember]
    public string FirmwareByteArray;
}
