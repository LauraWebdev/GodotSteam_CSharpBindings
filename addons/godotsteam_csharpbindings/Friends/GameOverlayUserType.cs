using System;

namespace GodotSteam;

/// <summary>

/// The game overlay user type enum

/// </summary>

public enum GameOverlayUserType
{
    /// <summary>
    /// The steam id game overlay user type
    /// </summary>
    SteamId,
    /// <summary>
    /// The chat game overlay user type
    /// </summary>
    Chat,
    /// <summary>
    /// The join trade game overlay user type
    /// </summary>
    JoinTrade,
    /// <summary>
    /// The stats game overlay user type
    /// </summary>
    Stats,
    /// <summary>
    /// The achievements game overlay user type
    /// </summary>
    Achievements,
    /// <summary>
    /// The friend add game overlay user type
    /// </summary>
    FriendAdd,
    /// <summary>
    /// The friend remove game overlay user type
    /// </summary>
    FriendRemove,
    /// <summary>
    /// The friend request accept game overlay user type
    /// </summary>
    FriendRequestAccept,
    /// <summary>
    /// The friend request ignore game overlay user type
    /// </summary>
    FriendRequestIgnore
}

/// <summary>

/// The game overlay user type extensions class

/// </summary>

public static class GameOverlayUserTypeExtensions
{
    /// <summary>
    /// Returns the godot steam using the specified type
    /// </summary>
    /// <param name="type">The type</param>
    /// <exception cref="ArgumentException">Invalid GameOverlayUserType</exception>
    /// <returns>The string</returns>
    public static string ToGodotSteam(this GameOverlayUserType type)
    {
        return type switch
        {
            GameOverlayUserType.SteamId => "steamid",
            GameOverlayUserType.Chat => "chat",
            GameOverlayUserType.JoinTrade => "jointrade",
            GameOverlayUserType.Stats => "stats",
            GameOverlayUserType.Achievements => "achievements",
            GameOverlayUserType.FriendAdd => "friendadd",
            GameOverlayUserType.FriendRemove => "friendremove",
            GameOverlayUserType.FriendRequestAccept => "friendrequestaccept",
            GameOverlayUserType.FriendRequestIgnore => "friendrequestignore",
            _ => throw new ArgumentException("Invalid GameOverlayUserType")
        };
    }
}