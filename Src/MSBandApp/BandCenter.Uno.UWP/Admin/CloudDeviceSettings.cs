using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Microsoft.Band.Admin;

[DataContract]
public sealed class CloudDeviceSettings
{
    [DataMember(EmitDefaultValue = true)]
    public Guid DeviceId { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string SerialNumber { get; set; }

    [DataMember(Name = "FirmwareDeviceName", EmitDefaultValue = false)]
    public string DeviceName { get; set; }

    [DataMember(Name = "FirmwareProfileVersion", EmitDefaultValue = false)]
    public int DeviceProfileVersion { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string FirmwareByteArray { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string FirmwareReserved { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime? LastReset { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public DateTime? LastSuccessfulSync { get; set; }

    [DataMember(Name = "FirmwareLocale", EmitDefaultValue = false)]
    public CloudLocaleSettings? LocaleSettings { get; set; }

    [DataMember(Name = "RunDisplayUnits", EmitDefaultValue = true)]
    public byte RunDisplayUnits { get; set; }

    [DataMember(Name = "IsTelemetryEnabled", EmitDefaultValue = false)]
    public bool? TelemetryEnabled { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public Dictionary<string, string> AdditionalSettings { get; set; }
}
