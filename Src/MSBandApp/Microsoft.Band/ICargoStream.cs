﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.ICargoStream
// Assembly: Microsoft.Band, Version=1.3.20517.1, Culture=neutral, PublicKeyToken=null
// MVID: AFCBFE03-E2CF-481D-86F4-92C60C36D26A
// Assembly location: C:\Users\Pdawg\Downloads\Microsoft Band Sync Setup\Microsoft_Band.dll

using System;
using System.Threading;

namespace Microsoft.Band
{
    public interface ICargoStream : IDisposable
    {
        int ReadTimeout { get; set; }

        int WriteTimeout { get; set; }

        CancellationToken Cancel { get; set; }

        int Read(byte[] buffer, int offset, int count);

        void Write(byte[] buffer, int offset, int count);

        void Flush();
    }
}
