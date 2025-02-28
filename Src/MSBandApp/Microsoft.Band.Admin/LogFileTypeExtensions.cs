﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.Admin.LogFileTypeExtensions
// Assembly: Microsoft.Band.Admin, Version=1.3.31002.2, Culture=neutral, PublicKeyToken=null
// MVID: 366705DD-0763-47F9-B6A9-5EDF88598091
// Assembly location: D:\Documents\REProj\MicrosoftBand\HealthApp.WindowsPhone_1.3.31002.2_ARM\Microsoft.Band.Admin.dll

using System;

namespace Microsoft.Band.Admin
{
    public static class LogFileTypeExtensions
    {
        public static string ToCloudUploadPameterValue(this LogFileTypes type)
        {
            switch (type)
            {
                case LogFileTypes.Sensor:
                    return "BandBinary";
                case LogFileTypes.CrashDump:
                    return "CrashDump";
                case LogFileTypes.KAppLogs:
                    return "AppDump";
                case LogFileTypes.Telemetry:
                    return "Telemetry";
                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
        }
    }
}
