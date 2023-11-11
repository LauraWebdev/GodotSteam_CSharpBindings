namespace GodotSteam;

/// <summary>

/// The friend flag enum

/// </summary>

[System.Flags]
public enum FriendFlag
{
    /// <summary>
    /// The none friend flag
    /// </summary>
    None = 0x00,
    /// <summary>
    /// The blocked friend flag
    /// </summary>
    Blocked = 0x01,
    /// <summary>
    /// The friendship requested friend flag
    /// </summary>
    FriendshipRequested = 0x02,
    /// <summary>
    /// The immediate friend flag
    /// </summary>
    Immediate = 0x04,
    /// <summary>
    /// The clan member friend flag
    /// </summary>
    ClanMember = 0x08,
    /// <summary>
    /// The on game server friend flag
    /// </summary>
    OnGameServer = 0x10,
    /// <summary>
    /// The requesting friendship friend flag
    /// </summary>
    RequestingFriendship = 0x80,
    /// <summary>
    /// The requesting info friend flag
    /// </summary>
    RequestingInfo = 0x100,
    /// <summary>
    /// The ignored friend flag
    /// </summary>
    Ignored = 0x200,
    /// <summary>
    /// The ignored friend friend flag
    /// </summary>
    IgnoredFriend = 0x400,
    /// <summary>
    /// The chat member friend flag
    /// </summary>
    ChatMember = 0x0000,
    /// <summary>
    /// The all friend flag
    /// </summary>
    All = 0xFFFF
}