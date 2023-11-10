using System;

namespace GodotSteam;

public enum GameOverlayUserType
{
    SteamId,
    Chat,
    JoinTrade,
    Stats,
    Achievements,
    FriendAdd,
    FriendRemove,
    FriendRequestAccept,
    FriendRequestIgnore
}

public static class GameOverlayUserTypeExtensions
{
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