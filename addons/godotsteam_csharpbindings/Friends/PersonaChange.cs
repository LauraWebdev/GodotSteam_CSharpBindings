namespace GodotSteam;

[System.Flags]
public enum PersonaChange
{
    Name = 0x0001,
    Status = 0x0002,
    ComeOnline = 0x0004,
    GoneOffline = 0x0008,
    GamePlayed = 0x0010,
    GameServer = 0x0020,
    Avatar = 0x0040,
    JoinedSource = 0x0080,
    LeftSource = 0x0100,
    RelationshipChanged = 0x0200,
    NameFirstSet = 0x0400,
    FacebookInfo = 0x0800,
    Nickname = 0x1000,
    SteamLevel = 0x2000,
    RichPresence = 0x4000
}