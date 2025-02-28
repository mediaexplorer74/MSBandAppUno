﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.Tiles.Pages.FilledButton
// Assembly: Microsoft.Band, Version=1.3.20517.1, Culture=neutral, PublicKeyToken=null
// MVID: AFCBFE03-E2CF-481D-86F4-92C60C36D26A
// Assembly location: C:\Users\Pdawg\Downloads\Microsoft Band Sync Setup\Microsoft_Band.dll

namespace Microsoft.Band.Tiles.Pages
{
    public sealed class FilledButton : PageElement
    {
        public FilledButton() : base(CommonElementColors.White)
        {
        }

        public BandColor BackgroundColor
        {
            get => Color;
            set => Color = value;
        }

        public override PageElementType TypeId => PageElementType.InteractiveButtonWithBorder;

        protected override uint AttributesToCustomStyleMask() => 1073741824;
    }
}
