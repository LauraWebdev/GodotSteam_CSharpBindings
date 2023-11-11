namespace GodotSteam;

/// <summary>

/// The steam init status enum

/// </summary>

public enum SteamInitStatus
{
    /// <summary>
    /// The steamworks active steam init status
    /// </summary>
    SteamworksActive = 1,
    /// <summary>
    /// The steamworks failed to initialize steam init status
    /// </summary>
    SteamworksFailedToInitialize = 2,
    /// <summary>
    /// The steam not running steam init status
    /// </summary>
    SteamNotRunning = 20,
    /// <summary>
    /// The invalid app id or not installed steam init status
    /// </summary>
    InvalidAppIdOrNotInstalled = 79,
}