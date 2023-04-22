// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.DisposableGCHandle
// Assembly: Microsoft.Band, Version=1.3.20517.1, Culture=neutral, PublicKeyToken=null
// MVID: AFCBFE03-E2CF-481D-86F4-92C60C36D26A
// Assembly location: C:\Users\Pdawg\Downloads\Microsoft Band Sync Setup\Microsoft_Band.dll

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Band
{
    public sealed class DisposableGCHandle : IDisposable
    {
        private GCHandle handle;

        public static DisposableGCHandle Alloc(object target, GCHandleType handleType = GCHandleType.Normal)
        {
            return target != null
                ? new DisposableGCHandle
                {
                    handle = GCHandle.Alloc(target, handleType)
                }
                : throw new ArgumentNullException(nameof(target));
        }

        public object Target => handle.Target;

        public bool IsAllocated => handle.IsAllocated;

        public IntPtr AddrOfPinnedObject() => handle.AddrOfPinnedObject();

        public void Free() => handle.Free();

        public void Dispose()
        {
            if (!IsAllocated)
                return;
            Free();
        }
    }
}
