using System;

namespace GodotSteam;

/// <summary>

/// The game overlay type enum

/// </summary>

public enum GameOverlayType
{
    /// <summary>
    /// The default game overlay type
    /// </summary>
    Default,
    /// <summary>
    /// The friends game overlay type
    /// </summary>
    Friends,
    /// <summary>
    /// The community game overlay type
    /// </summary>
    Community,
    /// <summary>
    /// The players game overlay type
    /// </summary>
    Players,
    /// <summary>
    /// The settings game overlay type
    /// </summary>
    Settings,
    /// <summary>
    /// The offical game group game overlay type
    /// </summary>
    OfficalGameGroup,
    /// <summary>
    /// The stats game overlay type
    /// </summary>
    Stats,
    /// <summary>
    /// The achievements game overlay type
    /// </summary>
    Achievements,
    /// <summary>
    /// The lobby invite game overlay type
    /// </summary>
    LobbyInvite
}

/// <summary>

/// The game overlay type extensions class

/// </summary>

public static class GameOverlayTypeExtensions
{
    /// <summary>
    /// Returns the godot steam using the specified type
    /// </summary>
    /// <param name="type">The type</param>
    /// <exception cref="ArgumentException">Invalid GameOverlayType</exception>
    /// <returns>The string</returns>
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