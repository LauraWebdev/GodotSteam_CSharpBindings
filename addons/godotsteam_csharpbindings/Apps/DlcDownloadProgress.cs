namespace GodotSteam;

/// <summary>

/// The dlc download progress class

/// </summary>

public class DlcDownloadProgress
{
    /// <summary>
    /// Gets or sets the value of the ret
    /// </summary>
    public bool Ret { get; set; }
    /// <summary>
    /// Gets or sets the value of the downloaded
    /// </summary>
    public ulong Downloaded { get; set; }
    /// <summary>
    /// Gets or sets the value of the total
    /// </summary>
    public ulong Total { get; set; }
}