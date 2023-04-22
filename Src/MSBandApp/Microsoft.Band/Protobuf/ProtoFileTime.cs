// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.Protobuf.ProtoFileTime
// Assembly: Microsoft.Band, Version=1.3.20517.1, Culture=neutral, PublicKeyToken=null
// MVID: AFCBFE03-E2CF-481D-86F4-92C60C36D26A
// Assembly location: C:\Users\Pdawg\Downloads\Microsoft Band Sync Setup\Microsoft_Band.dll

using Google.Protobuf;
using System;

namespace Microsoft.Band.Protobuf
{
    public class ProtoFileTime
    {
        public static int GetSerializedProtobufByteCount() => 10;

        public static void SerializeProtobufToBand(CodedOutputStream output, DateTime timeStamp) => SerializeProtobufToBand(output, timeStamp.ToFileTime());

        public static void SerializeProtobufToBand(CodedOutputStream output, DateTimeOffset timeStamp) => SerializeProtobufToBand(output, timeStamp.ToFileTime());

        private static void SerializeProtobufToBand(CodedOutputStream output, long fileTime)
        {
            output.WriteRawTag(13);
            output.WriteFixed32((uint)fileTime);
            output.WriteRawTag(21);
            output.WriteFixed32((uint)(fileTime >> 32));
        }
    }
}
