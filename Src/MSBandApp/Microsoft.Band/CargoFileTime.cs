// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.CargoFileTime
// Assembly: Microsoft.Band, Version=1.3.20517.1, Culture=neutral, PublicKeyToken=null
// MVID: AFCBFE03-E2CF-481D-86F4-92C60C36D26A
// Assembly location: C:\Users\Pdawg\Downloads\Microsoft Band Sync Setup\Microsoft_Band.dll

using System;

namespace Microsoft.Band
{
    public static class CargoFileTime
    {
        public static int GetSerializedByteCount() => 8;

        public static DateTime DeserializeFromBandAsDateTime(ICargoReader reader)
        {
            long fileTime = reader.ReadInt64();
            return fileTime <= 2650467743999990000L ? DateTime.FromFileTimeUtc(fileTime) : DateTime.FromFileTimeUtc(2650467743999990000L);
        }

        public static void SerializeToBandFromDateTime(ICargoWriter writer, DateTime timestamp)
        {
            if (timestamp >= BandConstants.MinDateTimeForFileTime)
                writer.WriteInt64(timestamp.ToFileTime());
            else
                writer.WriteInt64(BandConstants.MinDateTimeForFileTime.ToFileTime());
        }

        public static void SerializeToBandFromDateTime(ICargoWriter writer, DateTime? timestamp)
        {
            if (timestamp.HasValue)
            {
                DateTime? nullable = timestamp;
                DateTime dateTimeForFileTime = BandConstants.MinDateTimeForFileTime;
                if ((nullable.HasValue ? (nullable.GetValueOrDefault() >= dateTimeForFileTime ? 1 : 0) : 0) != 0)
                    writer.WriteInt64(timestamp.Value.ToFileTime());
                else
                    writer.WriteInt64(BandConstants.MinDateTimeForFileTime.ToFileTime());
            }
            else
                writer.WriteInt64(0L);
        }

        public static DateTimeOffset DeserializeFromBandAsDateTimeOffset(ICargoReader reader)
        {
            return DeserializeFromBandAsDateTime(reader);
        }

        public static void SerializeToBandFromDateTimeOffset(ICargoWriter writer, DateTimeOffset timestamp)
        {
            if (timestamp >= BandConstants.MinDateTimeOffsetForFileTime)
                writer.WriteInt64(timestamp.ToFileTime());
            else
                writer.WriteInt64(BandConstants.MinDateTimeOffsetForFileTime.ToFileTime());
        }

        public static void SerializeToBandFromDateTimeOffset(ICargoWriter writer, DateTimeOffset? timestamp)
        {
            if (timestamp.HasValue)
            {
                DateTimeOffset? nullable = timestamp;
                DateTimeOffset offsetForFileTime = BandConstants.MinDateTimeOffsetForFileTime;
                if ((nullable.HasValue ? (nullable.GetValueOrDefault() >= offsetForFileTime ? 1 : 0) : 0) != 0)
                    writer.WriteInt64(timestamp.Value.ToFileTime());
                else
                    writer.WriteInt64(BandConstants.MinDateTimeOffsetForFileTime.ToFileTime());
            }
            else
                writer.WriteInt64(0L);
        }
    }
}
