// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.DeviceCommands
// Assembly: Microsoft.Band, Version=1.3.20517.1, Culture=neutral, PublicKeyToken=null
// MVID: AFCBFE03-E2CF-481D-86F4-92C60C36D26A
// Assembly location: C:\Users\Pdawg\Downloads\Microsoft Band Sync Setup\Microsoft_Band.dll

namespace Microsoft.Band
{
    public static class DeviceCommands
    {
        public const ushort IndexShift = 0;
        public const ushort IndexBits = 7;
        public const ushort IndexMask = 127;
        public const ushort TXShift = 7;
        public const ushort TXBits = 1;
        public const ushort TXMask = 128;
        public const ushort CategoryShift = 8;
        public const ushort CategoryBits = 8;
        public const ushort CategoryMask = 65280;
        public static ushort CargoCoreModuleGetVersion = MakeCommand(Facility.LibraryJutil, TX.True, 1);
        public static ushort CargoCoreModuleGetUniqueID = MakeCommand(Facility.LibraryJutil, TX.True, 2);
        public static ushort CargoCoreModuleWhoAmI = MakeCommand(Facility.LibraryJutil, TX.True, 3);
        public static ushort CargoCoreModuleGetLogVersion = MakeCommand(Facility.LibraryJutil, TX.True, 5);
        public static ushort CargoCoreModuleGetApiVersion = MakeCommand(Facility.LibraryJutil, TX.True, 6);
        public static ushort CargoCoreModuleSdkCheck = MakeCommand(Facility.LibraryJutil, TX.False, 7);
        public static ushort CargoTimeGetUtcTime = MakeCommand(Facility.LibraryTime, TX.True, 0);
        public static ushort CargoTimeSetUtcTime = MakeCommand(Facility.LibraryTime, TX.False, 1);
        public static ushort CargoTimeGetLocalTime = MakeCommand(Facility.LibraryTime, TX.True, 2);
        public static ushort CargoTimeSetTimeZoneFile = MakeCommand(Facility.LibraryTime, TX.False, 4);
        public static ushort CargoTimeZoneFileGetVersion = MakeCommand(Facility.LibraryTime, TX.True, 6);
        public static ushort CargoLoggerGetChunkData = MakeCommand(Facility.LibraryLogger, TX.True, 1);
        public static ushort CargoLoggerEnableLogging = MakeCommand(Facility.LibraryLogger, TX.False, 3);
        public static ushort CargoLoggerDisableLogging = MakeCommand(Facility.LibraryLogger, TX.False, 4);
        public static ushort CargoLoggerGetChunkCounts = MakeCommand(Facility.LibraryLogger, TX.True, 9);
        public static ushort CargoLoggerFlush = MakeCommand(Facility.LibraryLogger, TX.False, 13);
        public static ushort CargoLoggerGetChunkRangeMetadata = MakeCommand(Facility.LibraryLogger, TX.True, 14);
        public static ushort CargoLoggerGetChunkRangeData = MakeCommand(Facility.LibraryLogger, TX.True, 15);
        public static ushort CargoLoggerDeleteChunkRange = MakeCommand(Facility.LibraryLogger, TX.False, 16);
        public static ushort CargoProfileGetDataApp = MakeCommand(Facility.ModuleProfile, TX.True, 6);
        public static ushort CargoProfileSetDataApp = MakeCommand(Facility.ModuleProfile, TX.False, 7);
        public static ushort CargoProfileGetDataFW = MakeCommand(Facility.ModuleProfile, TX.True, 8);
        public static ushort CargoProfileSetDataFW = MakeCommand(Facility.ModuleProfile, TX.False, 9);
        public static ushort CargoRemoteSubscriptionSubscribe = MakeCommand(Facility.LibraryRemoteSubscription, TX.False, 0);
        public static ushort CargoRemoteSubscriptionUnsubscribe = MakeCommand(Facility.LibraryRemoteSubscription, TX.False, 1);
        public static ushort CargoRemoteSubscriptionGetDataLength = MakeCommand(Facility.LibraryRemoteSubscription, TX.True, 2);
        public static ushort CargoRemoteSubscriptionGetData = MakeCommand(Facility.LibraryRemoteSubscription, TX.True, 3);
        public static ushort CargoRemoteSubscriptionSubscribeId = MakeCommand(Facility.LibraryRemoteSubscription, TX.False, 7);
        public static ushort CargoRemoteSubscriptionUnsubscribeId = MakeCommand(Facility.LibraryRemoteSubscription, TX.False, 8);
        public static ushort CargoNotification = MakeCommand(Facility.ModuleNotification, TX.False, 0);
        public static ushort CargoNotificationProtoBuf = MakeCommand(Facility.ModuleNotification, TX.False, 5);
        public static ushort CargoDynamicAppRegisterApp = MakeCommand(Facility.ModuleFireballAppsManagement, TX.False, 0);
        public static ushort CargoDynamicAppRemoveApp = MakeCommand(Facility.ModuleFireballAppsManagement, TX.False, 1);
        public static ushort CargoDynamicAppRegisterAppIcons = MakeCommand(Facility.ModuleFireballAppsManagement, TX.False, 2);
        public static ushort CargoDynamicAppSetAppTileIndex = MakeCommand(Facility.ModuleFireballAppsManagement, TX.False, 3);
        public static ushort CargoDynamicAppSetAppBadgeTileIndex = MakeCommand(Facility.ModuleFireballAppsManagement, TX.False, 5);
        public static ushort CargoDynamicAppSetAppNotificationTileIndex = MakeCommand(Facility.ModuleFireballAppsManagement, TX.False, 11);
        public static ushort CargoDynamicPageLayoutSet = MakeCommand(Facility.ModuleFireballPageManagement, TX.False, 0);
        public static ushort CargoDynamicPageLayoutRemove = MakeCommand(Facility.ModuleFireballPageManagement, TX.False, 1);
        public static ushort CargoDynamicPageLayoutGet = MakeCommand(Facility.ModuleFireballPageManagement, TX.True, 2);
        public static ushort CargoInstalledAppListGet = MakeCommand(Facility.ModuleInstalledAppList, TX.True, 0);
        public static ushort CargoInstalledAppListSet = MakeCommand(Facility.ModuleInstalledAppList, TX.False, 1);
        public static ushort CargoInstalledAppListStartStripSyncStart = MakeCommand(Facility.ModuleInstalledAppList, TX.False, 2);
        public static ushort CargoInstalledAppListStartStripSyncEnd = MakeCommand(Facility.ModuleInstalledAppList, TX.False, 3);
        public static ushort CargoInstalledAppListGetDefaults = MakeCommand(Facility.ModuleInstalledAppList, TX.True, 4);
        public static ushort CargoInstalledAppListSetTile = MakeCommand(Facility.ModuleInstalledAppList, TX.False, 6);
        public static ushort CargoInstalledAppListGetTile = MakeCommand(Facility.ModuleInstalledAppList, TX.True, 7);
        public static ushort CargoInstalledAppListGetSettingsMask = MakeCommand(Facility.ModuleInstalledAppList, TX.True, 13);
        public static ushort CargoInstalledAppListSetSettingsMask = MakeCommand(Facility.ModuleInstalledAppList, TX.False, 14);
        public static ushort CargoInstalledAppListEnableSetting = MakeCommand(Facility.ModuleInstalledAppList, TX.False, 15);
        public static ushort CargoInstalledAppListDisableSetting = MakeCommand(Facility.ModuleInstalledAppList, TX.False, 16);
        public static ushort CargoInstalledAppListGetNoImages = MakeCommand(Facility.ModuleInstalledAppList, TX.True, 18);
        public static ushort CargoInstalledAppListGetDefaultsNoImages = MakeCommand(Facility.ModuleInstalledAppList, TX.True, 19);
        public static ushort CargoInstalledAppListGetMaxTileCount = MakeCommand(Facility.ModuleInstalledAppList, TX.True, 21);
        public static ushort CargoInstalledAppListGetMaxTileAllocatedCount = MakeCommand(Facility.ModuleInstalledAppList, TX.True, 22);
        public static ushort CargoSystemSettingsOobeCompleteClear = MakeCommand(Facility.ModuleSystemSettings, TX.False, 0);
        public static ushort CargoSystemSettingsOobeCompleteSet = MakeCommand(Facility.ModuleSystemSettings, TX.False, 1);
        public static ushort CargoSystemSettingsFactoryReset = MakeCommand(Facility.ModuleSystemSettings, TX.True, 7);
        public static ushort CargoSystemSettingsGetTimeZone = MakeCommand(Facility.ModuleSystemSettings, TX.True, 10);
        public static ushort CargoSystemSettingsSetTimeZone = MakeCommand(Facility.ModuleSystemSettings, TX.False, 11);
        public static ushort CargoSystemSettingsSetEphemerisFile = MakeCommand(Facility.ModuleSystemSettings, TX.False, 15);
        public static ushort CargoSystemSettingsGetMeTileImageID = MakeCommand(Facility.ModuleSystemSettings, TX.True, 18);
        public static ushort CargoSystemSettingsOobeCompleteGet = MakeCommand(Facility.ModuleSystemSettings, TX.True, 19);
        public static ushort CargoSystemSettingsEnableDemoMode = MakeCommand(Facility.ModuleSystemSettings, TX.False, 25);
        public static ushort CargoSystemSettingsDisableDemoMode = MakeCommand(Facility.ModuleSystemSettings, TX.False, 26);
        public static ushort CargoSRAMFWUpdateLoadData = MakeCommand(Facility.LibrarySRAMFWUpdate, TX.False, 0);
        public static ushort CargoSRAMFWUpdateBootIntoUpdateMode = MakeCommand(Facility.LibrarySRAMFWUpdate, TX.False, 1);
        public static ushort CargoSRAMFWUpdateValidateAssets = MakeCommand(Facility.LibrarySRAMFWUpdate, TX.True, 2);
        public static ushort CargoEFlashRead = MakeCommand(Facility.DriverEFlash, TX.True, 1);
        public static ushort CargoGpsIsEnabled = MakeCommand(Facility.LibraryGps, TX.True, 6);
        public static ushort CargoGpsEphemerisCoverageDates = MakeCommand(Facility.LibraryGps, TX.True, 13);
        public static ushort CargoFireballUINavigateToScreen = MakeCommand(Facility.ModuleFireballUI, TX.False, 0);
        public static ushort CargoFireballUIClearMeTileImage = MakeCommand(Facility.ModuleFireballUI, TX.False, 6);
        public static ushort CargoFireballUISetSmsResponse = MakeCommand(Facility.ModuleFireballUI, TX.False, 7);
        public static ushort CargoFireballUIGetAllSmsResponse = MakeCommand(Facility.ModuleFireballUI, TX.True, 11);
        public static ushort CargoFireballUIReadMeTileImage = MakeCommand(Facility.ModuleFireballUI, TX.True, 14);
        public static ushort CargoFireballUIWriteMeTileImageWithID = MakeCommand(Facility.ModuleFireballUI, TX.False, 17);
        public static ushort CargoThemeColorSetFirstPartyTheme = MakeCommand(Facility.ModuleThemeColor, TX.False, 0);
        public static ushort CargoThemeColorGetFirstPartyTheme = MakeCommand(Facility.ModuleThemeColor, TX.True, 1);
        public static ushort CargoThemeColorSetCustomTheme = MakeCommand(Facility.ModuleThemeColor, TX.False, 2);
        public static ushort CargoThemeColorReset = MakeCommand(Facility.ModuleThemeColor, TX.False, 4);
        public static ushort CargoHapticPlayVibrationStream = MakeCommand(Facility.LibraryHaptic, TX.False, 0);
        public static ushort CargoGoalTrackerSet = MakeCommand(Facility.ModuleGoalTracker, TX.False, 0);
        public static ushort CargoFitnessPlansWriteFile = MakeCommand(Facility.LibraryFitnessPlans, TX.False, 4);
        public static ushort CargoGolfCourseFileWrite = MakeCommand(Facility.LibraryGolf, TX.False, 0);
        public static ushort CargoGolfCourseFileGetMaxSize = MakeCommand(Facility.LibraryGolf, TX.True, 1);
        public static ushort CargoOobeSetStage = MakeCommand(Facility.ModuleOobe, TX.False, 0);
        public static ushort CargoOobeGetStage = MakeCommand(Facility.ModuleOobe, TX.True, 1);
        public static ushort CargoOobeFinalize = MakeCommand(Facility.ModuleOobe, TX.False, 2);
        public static ushort CargoCortanaNotification = MakeCommand(Facility.ModuleCortana, TX.False, 0);
        public static ushort CargoCortanaStart = MakeCommand(Facility.ModuleCortana, TX.False, 1);
        public static ushort CargoCortanaStop = MakeCommand(Facility.ModuleCortana, TX.False, 2);
        public static ushort CargoCortanaCancel = MakeCommand(Facility.ModuleCortana, TX.False, 3);
        public static ushort CargoPersistedAppDataSetRunMetrics = MakeCommand(Facility.ModulePersistedApplicationData, TX.False, 0);
        public static ushort CargoPersistedAppDataGetRunMetrics = MakeCommand(Facility.ModulePersistedApplicationData, TX.True, 1);
        public static ushort CargoPersistedAppDataSetBikeMetrics = MakeCommand(Facility.ModulePersistedApplicationData, TX.False, 2);
        public static ushort CargoPersistedAppDataGetBikeMetrics = MakeCommand(Facility.ModulePersistedApplicationData, TX.True, 3);
        public static ushort CargoPersistedAppDataSetBikeSplitMult = MakeCommand(Facility.ModulePersistedApplicationData, TX.False, 4);
        public static ushort CargoPersistedAppDataGetBikeSplitMult = MakeCommand(Facility.ModulePersistedApplicationData, TX.True, 5);
        public static ushort CargoPersistedAppDataSetWorkoutActivities = MakeCommand(Facility.ModulePersistedApplicationData, TX.False, 9);
        public static ushort CargoPersistedAppDataGetWorkoutActivities = MakeCommand(Facility.ModulePersistedApplicationData, TX.True, 16);
        public static ushort CargoPersistedAppDataSetSleepNotification = MakeCommand(Facility.ModulePersistedApplicationData, TX.False, 17);
        public static ushort CargoPersistedAppDataGetSleepNotification = MakeCommand(Facility.ModulePersistedApplicationData, TX.True, 18);
        public static ushort CargoPersistedAppDataDisableSleepNotification = MakeCommand(Facility.ModulePersistedApplicationData, TX.False, 19);
        public static ushort CargoPersistedAppDataSetLightExposureNotification = MakeCommand(Facility.ModulePersistedApplicationData, TX.False, 21);
        public static ushort CargoPersistedAppDataGetLightExposureNotification = MakeCommand(Facility.ModulePersistedApplicationData, TX.True, 22);
        public static ushort CargoPersistedAppDataDisableLightExposureNotification = MakeCommand(Facility.ModulePersistedApplicationData, TX.False, 23);
        public static ushort CargoGetProductSerialNumber = MakeCommand(Facility.LibraryConfiguration, TX.True, 8);
        public static ushort CargoKeyboardCmd = MakeCommand(Facility.LibraryKeyboard, TX.False, 0);
        public static ushort CargoSubscriptionLoggerSubscribe = MakeCommand(Facility.ModuleLoggerSubscriptions, TX.False, 0);
        public static ushort CargoSubscriptionLoggerUnsubscribe = MakeCommand(Facility.ModuleLoggerSubscriptions, TX.False, 1);
        public static ushort CargoCrashDumpGetFileSize = MakeCommand(Facility.DriverCrashDump, TX.True, 1);
        public static ushort CargoCrashDumpGetAndDeleteFile = MakeCommand(Facility.DriverCrashDump, TX.True, 2);
        public static ushort CargoInstrumentationGetFileSize = MakeCommand(Facility.ModuleInstrumentation, TX.True, 4);
        public static ushort CargoInstrumentationGetFile = MakeCommand(Facility.ModuleInstrumentation, TX.True, 5);
        public static ushort CargoPersistedStatisticsRunGet = MakeCommand(Facility.ModulePersistedStatistics, TX.True, 2);
        public static ushort CargoPersistedStatisticsWorkoutGet = MakeCommand(Facility.ModulePersistedStatistics, TX.True, 3);
        public static ushort CargoPersistedStatisticsSleepGet = MakeCommand(Facility.ModulePersistedStatistics, TX.True, 4);
        public static ushort CargoPersistedStatisticsGuidedWorkoutGet = MakeCommand(Facility.ModulePersistedStatistics, TX.True, 5);

        public static ushort MakeCommand(Facility category, TX isTXCommand, byte index) => (ushort)((ushort)((uint)category << 8) | (uint)(ushort)((uint)isTXCommand << 7) | index);

        public static void LookupCommand(
          ushort commandId,
          out Facility category,
          out TX isTXCommand,
          out byte index)
        {
            category = (Facility)((commandId & 65280) >> 8);
            isTXCommand = (TX)((commandId & 128) >> 7);
            index = (byte)(commandId & (uint)sbyte.MaxValue);
        }
    }
}
