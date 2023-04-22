using System.Runtime.Serialization;

namespace Microsoft.Band.Admin;

[DataContract]
public struct CloudLocaleSettings
{
    [DataMember]
    public string LocaleName;

    [DataMember(Name = "Locale")]
    public ushort LocaleId;

    [DataMember]
    public ushort Language;

    [DataMember]
    public char DateSeparator;

    [DataMember]
    public char NumberSeparator;

    [DataMember]
    public char DecimalSeparator;

    [DataMember]
    public byte TimeFormat;

    [DataMember]
    public byte DateFormat;

    [DataMember(Name = "DisplaySizeUnit")]
    public byte DistanceShortUnits;

    [DataMember(Name = "DisplayDistanceUnit")]
    public byte DistanceLongUnits;

    [DataMember(Name = "DisplayWeightUnit")]
    public byte MassUnits;

    [DataMember(Name = "DisplayVolumeUnit")]
    public byte VolumeUnits;

    [DataMember(Name = "DisplayCaloriesUnit")]
    public byte EnergyUnits;

    [DataMember(Name = "DisplayTemperatureUnit")]
    public byte TemperatureUnits;
}
