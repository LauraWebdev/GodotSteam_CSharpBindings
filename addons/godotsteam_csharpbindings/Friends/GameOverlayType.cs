using System;

namespace GodotSteam;

public enum GameOverlayType
{
    Default,
    Friends,
    Community,
    Players,
    Settings,
    OfficalGameGroup,
    Stats,
    Achievements,
    LobbyInvite
}

public static class GameOverlayTypeExtensions
{
    public static string ToGodotSteam(this GameOverlayType type)
    {
        return type switch
        {
            GameOverlayType.Default => "",
            GameOverlayType.Friends => "Friends",
            GameOverlayType.Community => "Community",
            GameOverlayType.Players => "Players",
            GameOverlayType.Settings => "Settings",
            GameOverlayType.OfficalGameGroup => "OfficalGameGroup",
            GameOverlayType.Stats => "Stats",
            GameOverlayType.Achievements => "Achievements",
            GameOverlayType.LobbyInvite => "LobbyInvite",
            _ => throw new ArgumentException("Invalid GameOverlayType")
        };
    }
}