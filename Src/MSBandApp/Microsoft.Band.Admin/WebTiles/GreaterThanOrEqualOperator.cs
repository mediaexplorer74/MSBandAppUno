﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.Admin.WebTiles.GreaterThanOrEqualOperator
// Assembly: Microsoft.Band.Admin, Version=1.3.31002.2, Culture=neutral, PublicKeyToken=null
// MVID: 366705DD-0763-47F9-B6A9-5EDF88598091
// Assembly location: D:\Documents\REProj\MicrosoftBand\HealthApp.WindowsPhone_1.3.31002.2_ARM\Microsoft.Band.Admin.dll

namespace Microsoft.Band.Admin.WebTiles
{
    public class GreaterThanOrEqualOperator : BinaryOperator
    {
        private GreaterThanOrEqualOperator(string tokenValue, int position)
          : base(tokenValue, position)
        {
        }

        public static GreaterThanOrEqualOperator Create(
          string tokenValue,
          int position)
        {
            return new GreaterThanOrEqualOperator(tokenValue, position);
        }

        public override bool Compare(object leftOperand, object rightOperand) => this.Compare(leftOperand, rightOperand, (BinaryOperator.CompareOperation)(diff => diff >= 0));
    }
}
