namespace GodotSteam;

/// <summary>

/// The persona change enum

/// </summary>

[System.Flags]
public enum PersonaChange
{
    /// <summary>
    /// The name persona change
    /// </summary>
    Name = 0x0001,
    /// <summary>
    /// The status persona change
    /// </summary>
    Status = 0x0002,
    /// <summary>
    /// The come online persona change
    /// </summary>
    ComeOnline = 0x0004,
    /// <summary>
    /// The gone offline persona change
    /// </summary>
    GoneOffline = 0x0008,
    /// <summary>
    /// The game played persona change
    /// </summary>
    GamePlayed = 0x0010,
    /// <summary>
    /// The game server persona change
    /// </summary>
    GameServer = 0x0020,
    /// <summary>
    /// The avatar persona change
    /// </summary>
    Avatar = 0x0040,
    /// <summary>
    /// The joined source persona change
    /// </summary>
    JoinedSource = 0x0080,
    /// <summary>
    /// The left source persona change
    /// </summary>
    LeftSource = 0x0100,
    /// <summary>
    /// The relationship changed persona change
    /// </summary>
    RelationshipChanged = 0x0200,
    /// <summary>
    /// The name first set persona change
    /// </summary>
    NameFirstSet = 0x0400,
    /// <summary>
    /// The facebook info persona change
    /// </summary>
    FacebookInfo = 0x0800,
    /// <summary>
    /// The nickname persona change
    /// </summary>
    Nickname = 0x1000,
    /// <summary>
    /// The steam level persona change
    /// </summary>
    SteamLevel = 0x2000,
    /// <summary>
    /// The rich presence persona change
    /// </summary>
    RichPresence = 0x4000
}