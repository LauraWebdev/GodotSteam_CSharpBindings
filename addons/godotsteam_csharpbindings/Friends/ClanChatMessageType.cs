namespace GodotSteam;

/// <summary>

/// The clan chat message type enum

/// </summary>

public enum ClanChatMessageType
{
    /// <summary>
    /// The invalid clan chat message type
    /// </summary>
    Invalid = 0,
    /// <summary>
    /// The chat message clan chat message type
    /// </summary>
    ChatMessage = 1,
    /// <summary>
    /// The typing clan chat message type
    /// </summary>
    Typing = 2,
    /// <summary>
    /// The invite game clan chat message type
    /// </summary>
    InviteGame = 3,
    /// <summary>
    /// The emote clan chat message type
    /// </summary>
    Emote = 4,
    /// <summary>
    /// The left conversation clan chat message type
    /// </summary>
    LeftConversation = 6,
    /// <summary>
    /// The entered clan chat message type
    /// </summary>
    Entered = 7,
    /// <summary>
    /// The was kicked clan chat message type
    /// </summary>
    WasKicked = 8,
    /// <summary>
    /// The was banned clan chat message type
    /// </summary>
    WasBanned = 9,
    /// <summary>
    /// The disconnected clan chat message type
    /// </summary>
    Disconnected = 10,
    /// <summary>
    /// The historical chat clan chat message type
    /// </summary>
    HistoricalChat = 11,
    /// <summary>
    /// The link blocked clan chat message type
    /// </summary>
    LinkBlocked = 14,
}