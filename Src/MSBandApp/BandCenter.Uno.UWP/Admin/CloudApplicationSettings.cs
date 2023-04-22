using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Microsoft.Band.Admin;

[DataContract]
public sealed class CloudApplicationSettings
{
    [DataMember(EmitDefaultValue = false)]
    public string PreferredLocale;

    [DataMember(EmitDefaultValue = false)]
    public string PreferredRegion;

    [DataMember]
    public Guid? ApplicationId { get; set; }

    [DataMember]
    public Guid? PairedDeviceId { get; set; }

    [DataMember]
    public string Locale { get; set; }

    [DataMember]
    public bool? AllowPersonalization { get; set; }

    [DataMember]
    public bool? AllowToRunInBackground { get; set; }

    [DataMember]
    public TimeSpan? SyncInterval { get; set; }

    [DataMember]
    public string AvatarFileURL { get; set; }

    [DataMember]
    public string HomeScreenWallpaperURL { get; set; }

    [DataMember]
    public ApplicationThemeColor? ThemeColor { get; set; }

    [DataMember]
    public TemperatureUnitType? TemperatureDisplayType { get; set; }

    [DataMember]
    public MeasurementUnitType? MeasurementDisplayType { get; set; }

    [DataMember]
    public string ThirdPartyPartnersPortalEndpoint { get; set; }

    [DataMember]
    public IDictionary<string, string> AdditionalSettings { get; set; }
}
