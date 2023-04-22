using System.Collections.Generic;

namespace Microsoft.Band.Admin;

public sealed class LogSyncResult
{
    public long DownloadedSensorLogBytes { get; set; }

    public long UploadedSensorLogBytes { get; set; }

    public double DownloadKbitsPerSecond { get; set; }

    public double DownloadKbytesPerSecond { get; set; }

    public double UploadKbitsPerSecond { get; set; }

    public double UploadKbytesPerSecond { get; set; }

    public long DevicePendingSensorLogBytes { get; set; }

    public bool RanToCompletion { get; set; }

    public long UploadTime { get; set; }

    public long DownloadTime { get; set; }

    public List<LogProcessingStatus> LogFilesProcessing { get; set; }
}
