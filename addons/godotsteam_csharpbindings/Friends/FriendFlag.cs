namespace GodotSteam;

[System.Flags]
public enum FriendFlag
{
    None = 0x00,
    Blocked = 0x01,
    FriendshipRequested = 0x02,
    Immediate = 0x04,
    ClanMember = 0x08,
    OnGameServer = 0x10,
    RequestingFriendship = 0x80,
    RequestingInfo = 0x100,
    Ignored = 0x200,
    IgnoredFriend = 0x400,
    ChatMember = 0x0000,
    All = 0xFFFF
}