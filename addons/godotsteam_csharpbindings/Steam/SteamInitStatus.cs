namespace GodotSteam;

public enum SteamInitStatus
{
    SteamworksActive = 1,
    SteamworksFailedToInitialize = 2,
    SteamNotRunning = 20,
    InvalidAppIdOrNotInstalled = 79,
}