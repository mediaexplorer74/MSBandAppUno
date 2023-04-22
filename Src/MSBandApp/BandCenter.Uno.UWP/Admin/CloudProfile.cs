using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Microsoft.Band.Admin;

[DataContract]
public sealed class CloudProfile
{
    [DataMember(EmitDefaultValue = false)]
    public string CreatedOn;

    [DataMember(EmitDefaultValue = true)]
    public string LastKDKSyncUpdateOn;

    [DataMember(EmitDefaultValue = false)]
    public string LastModifiedOn;

    [DataMember(EmitDefaultValue = false)]
    public string LastUserUpdateOn;

    [DataMember(EmitDefaultValue = false)]
    public string EndPoint;

    [DataMember(EmitDefaultValue = false)]
    public string FUSEndPoint;

    [DataMember(Name = "ODSUserID", EmitDefaultValue = false)]
    public Guid? UserID;

    [DataMember(EmitDefaultValue = false)]
    public string FirstName;

    [DataMember(EmitDefaultValue = false)]
    public string LastName;

    [DataMember(EmitDefaultValue = false)]
    public string ZipCode;

    [DataMember(EmitDefaultValue = false)]
    public string EmailAddress;

    [DataMember(EmitDefaultValue = false)]
    public string SmsAddress;

    [DataMember(Name = "HeightInMM", EmitDefaultValue = false)]
    public uint? Height;

    [DataMember(Name = "WeightInGrams", EmitDefaultValue = false)]
    public uint? Weight;

    [DataMember(EmitDefaultValue = false)]
    public bool? HasCompletedOOBE;

    [DataMember(EmitDefaultValue = true)]
    public Gender Gender;

    [DataMember(Name = "DateOfBirth", EmitDefaultValue = false)]
    public string Birthdate;

    [DataMember(EmitDefaultValue = false)]
    public ulong? TotalCaloriesBurnedFromMotion;

    [DataMember(EmitDefaultValue = false)]
    public ulong? TotalCaloriesBurnedWhileNotWorn;

    [DataMember(EmitDefaultValue = false)]
    public ulong? TotalCaloriesBurnedFromHR;

    [DataMember(EmitDefaultValue = false)]
    public ulong? TotalDistanceTravelledInM;

    [DataMember(EmitDefaultValue = false)]
    public ulong? TotalDistanceMeasuredByPedometerInM;

    [DataMember(EmitDefaultValue = false)]
    public ulong? TotalDistanceMeasuredByGPSInM;

    [DataMember(EmitDefaultValue = false)]
    public ulong? TotalStepsCounted;

    [DataMember(EmitDefaultValue = false)]
    public uint? HRGain;

    [DataMember(EmitDefaultValue = false)]
    public uint? HRRecoveryTime;

    [DataMember(EmitDefaultValue = false)]
    public uint? HRIntensity;

    [DataMember(EmitDefaultValue = false)]
    public uint? HRResponseTime;

    [DataMember(EmitDefaultValue = false)]
    public float? StrideLengthWhileWalking;

    [DataMember(EmitDefaultValue = false)]
    public float? StrideLengthWhileRunning;

    [DataMember(EmitDefaultValue = false)]
    public float? StrideLengthWhileJogging;

    [DataMember(EmitDefaultValue = false)]
    public uint? MaxHR;

    [DataMember(EmitDefaultValue = false)]
    public uint? RestingHR;

    [DataMember(EmitDefaultValue = false)]
    public bool? RestingHROverride;

    [DataMember(EmitDefaultValue = false)]
    public bool? MaxHROverride;

    [DataMember(EmitDefaultValue = false)]
    public float? ActivityClass;

    [DataMember]
    public CloudApplicationSettings ApplicationSettings { get; set; }

    [DataMember]
    public CloudDeviceSettings DeviceSettings { get; set; }

    [DataMember]
    public IDictionary<Guid, CloudDeviceSettings> AllDeviceSettings { get; set; }
}
