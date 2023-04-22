// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.BandResources
// Assembly: Microsoft.Band, Version=1.3.20517.1, Culture=neutral, PublicKeyToken=null
// MVID: AFCBFE03-E2CF-481D-86F4-92C60C36D26A
// Assembly location: C:\Users\Pdawg\Downloads\Microsoft Band Sync Setup\Microsoft_Band.dll

namespace Microsoft.Band
{
    public class BandResources
    {
        public static string BadDeviceCommandStatusPacket => "Unexpected packet type encountered while reading command status packet.";

        public static string BandAtMaxTileCapacity => "The Band already has its maximum number of Tiles.";

        public static string BandTileIdAlreadyInstalled => "Tile already exists.";

        public static string BandTileEmptyName => "A BandTile must have a non-empty Name property.";

        public static string BandTileEmptyTileId => "A BandTile must have a non-empty Tile ID.";

        public static string BandTileNameLengthExceeded => "The Name property must be no greater than {0} characters.";

        public static string BandTileNoSmallIcon => "A BandTile must have a non-null SmallIcon property.";

        public static string BandTileNoTileIcon => "A BandTile must have a non-null TileIcon property.";

        public static string BandTileNullTemplateEncountered => "Null page templates not allowed.";

        public static string BandTileOwnedTileNameExceedsLength => "A Band Tile name length exceeds that allowed by owned Tiles.";

        public static string BandTilePageDataInvalidElementChildCount => "The data element count  is invalid.";

        public static string BandTilePageDataNullElementEncountered => "Null page data elements are not allowed.";

        public static string BandTilePageTemplateBlobTooBig => "Page template byte count exceeds the maximum.";

        public static string BandTilePageTemplateDuplicateElementOrId => "A duplicate page element or element Id was encountered.";

        public static string BandTilePageTemplateInvalidCheckDigit => "Page template check digit mismatch.";

        public static string BandTilePageTemplateInvalidElementChildCount => "The page template element count is invalid.";

        public static string BandTilePageTemplateNullElementEncountered => "Null page template elements not not allowed.";

        public static string BandTilePageTemplateUnexpectedElementType => "Unexpected element type.";

        public static string BandTilePageTemplateUnknownOrInvalidElementType => "Invalid or unknown element type.";

        public static string BandTileTooManyIcons => "The page icon count exceeds the maximum.";

        public static string BandTileTooManyTemplates => "The page template count exceeds the maximum.";

        public static string BarcodeDataEmpty => "Barcode data cannot be empty.";

        public static string BarcodeDataTooLong => "Value exceeds maximum barcode data length {0}.";

        public static string ByteWriteFailure => "Cannot write the byte value to the stream.";

        public static string CargoCommandStatusUnavailable => "CommandStatus is not available until all data has been transferred to/from the band.";

        public static string CommandStatusError => "Device status code: 0x{0:X8} received.";

        public static string ConnectionAttemptFailed => "Failed to connect to the target band.";

        public static string ConsentDialogTitle => "Microsoft Band";

        public static string DeviceInNonAppMode => "The band is not running in App mode. Current Device Mode = {0}.";

        public static string EofExceptionOnWrite => "An attempt was made to write beyond the end of the stream.";

        public static string GenericCountZero => "{0} must have at least one entry.";

        public static string GenericLengthExceeded => "{0} is too long.";

        public static string GenericNullCollectionElement => "A null element was encountered";

        public static string HeartRateSensorConsentPrompt => "Allow this application to access the heart rate sensor on your Microsoft Band?";

        public static string IconButtonsAreNotSupportedOnCargo => "Icon buttons are only available on Microsoft Band 2 and newer devices";

        public static string ImageDimensionPixelDataMismatch => "Pixel data does not match width and height.";

        public static string InvalidAppAmount => "Invalid amount of apps found on the device.";

        public static string InvalidBarcodeCode39Data => "Invalid Code-39 data encountered.";

        public static string InvalidBarcodePdf417Data => "Invalid Pdf417 data encountered. Some Band versions support a limited character set; see documentation for details.";

        public static string MeTileHeightHeightError => "Me Tile image height must be {0}.";

        public static string MeTileImageWidthError => "Me Tile image width must be {0}.";

        public static string NotificationFieldsEmpty => "Both title and body are null or empty.";

        public static string NotificationInvalidTileId => "Tile ID is invalid.";

        public static string OperationRequiredConnectedDevice => "The attempted operation requires a connected band.";

        public static string RemovePagesEmptyGuid => "Unable to remove pages from Tile '{0}'.";

        public static string RemoveTileEmptyTileId => "Removing a tile requires a non-empty Tile ID.";

        public static string RemoveTileFailed => "Unable to remove the Tile '{0}' from the Band.";

        public static string SdkVersionNotSupported => "This version of the SDK is no longer supported.";

        public static string SensorUserConsentNotQueried => "This sensor type requires explicit user consent. RequestUserConsentAsync() must be called one time prior to subscribing.";

        public static string SetPagesEmptyGuid => "Unable to set pages on Tile '{0}'.";

        public static string StreamReadFailure => "Cannot read data from the stream.";

        public static string StreamWriteFailure => "Cannot write data to the stream.";

        public static string UICommandLabelNo => "No";

        public static string UICommandLabelYes => "Yes";

        public static string UnsupportedSensor => "Use of an unsupported sensor.";

        public static string UnsupportedSensorInterval => "Use of an unsupported reporting interval.";

        public static string AddTileConsentPrompt => "Add {0} tile to your Band?";
    }
}
