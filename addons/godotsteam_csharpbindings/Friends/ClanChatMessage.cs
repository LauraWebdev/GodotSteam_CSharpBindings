namespace GodotSteam;

/// <summary>

/// The clan chat message class

/// </summary>

public class ClanChatMessage
{
    /// <summary>
    /// Gets or sets the value of the ret
    /// </summary>
    public bool Ret { get; set; }
    /// <summary>
    /// Gets or sets the value of the text
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Gets or sets the value of the type
    /// </summary>
    public ClanChatMessageType Type { get; set; }
    /// <summary>
    /// Gets or sets the value of the chatter
    /// </summary>
    public ulong Chatter { get; set; }
}