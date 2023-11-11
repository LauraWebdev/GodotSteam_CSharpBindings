namespace GodotSteam;

/// <summary>

/// The steam init ex status enum

/// </summary>

public enum SteamInitExStatus
{
    /// <summary>
    /// The steamworks active steam init ex status
    /// </summary>
    SteamworksActive = 0,
    /// <summary>
    /// The failed steam init ex status
    /// </summary>
    Failed = 1,
    /// <summary>
    /// The cannot connect to steam steam init ex status
    /// </summary>
    CannotConnectToSteam = 2,
    /// <summary>
    /// The steam client out of date steam init ex status
    /// </summary>
    SteamClientOutOfDate = 3,
}