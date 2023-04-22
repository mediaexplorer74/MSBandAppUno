using System.Runtime.Serialization;

namespace Microsoft.Band.Admin;

[DataContract]
public sealed class FirmwareUpdateInfo : IFirmwareUpdateInfo
{
    [DataMember]
    public string DeviceFamily { get; set; }

    [DataMember]
    public string UniqueVersion { get; set; }

    [DataMember]
    public string FirmwareVersion { get; set; }

    [DataMember]
    public string PrimaryUrl { get; set; }

    [DataMember]
    public string FallbackUrl { get; set; }

    [DataMember]
    public string MirrorUrl { get; set; }

    [DataMember]
    public string HashMd5 { get; set; }

    [DataMember]
    public string SizeInBytes { get; set; }

    [DataMember]
    public bool IsFirmwareUpdateAvailable { get; set; }
}
