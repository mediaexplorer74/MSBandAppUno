﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.Tiles.Pages.PageElementData
// Assembly: Microsoft.Band, Version=1.3.20517.1, Culture=neutral, PublicKeyToken=null
// MVID: AFCBFE03-E2CF-481D-86F4-92C60C36D26A
// Assembly location: C:\Users\Pdawg\Downloads\Microsoft Band Sync Setup\Microsoft_Band.dll

namespace Microsoft.Band.Tiles.Pages
{
    public abstract class PageElementData
    {
        private readonly PageElementType elementTypeId;

        internal PageElementData(PageElementType elementType, short elementId)
        {
            elementTypeId = elementType;
            ElementId = elementId;
        }

        public short ElementId { get; set; }

        internal virtual void Validate(BandTypeConstants constants)
        {
        }

        internal virtual int GetSerializedLength() => 4;

        internal virtual void SerializeToBand(ICargoWriter writer)
        {
            writer.WriteUInt16((ushort)elementTypeId);
            writer.WriteInt16(ElementId);
        }
    }
}
