using System;

namespace GodotSteam;

public enum RichPresenceKey
{
    Status,
    Connect,
    SteamDisplay,
    SteamPlayerGroup,
    SteamPlayerGroupSize,
}

public static class RichPresenceKeyExtensions
{
    public static string ToGodotSteam(this RichPresenceKey key)
    {
        return key switch
        {
            RichPresenceKey.Status => "status",
            RichPresenceKey.Connect => "connect",
            RichPresenceKey.SteamDisplay => "steam_display",
            RichPresenceKey.SteamPlayerGroup => "steam_player_group",
            RichPresenceKey.SteamPlayerGroupSize => "steam_player_group_size",
            _ => throw new ArgumentException("Invalid RichPresenceKey")
        };
    }
}