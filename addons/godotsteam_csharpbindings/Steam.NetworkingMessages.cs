namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Describes whether accept session with user
    /// </summary>
    /// <param name="identityReference">The identity reference</param>
    /// <returns>The bool</returns>
    public static bool AcceptSessionWithUser(string identityReference)
    {
        return GetInstance().Call(Methods.AcceptSessionWithUser, identityReference).AsBool();
    }
    
    /// <summary>
    /// Describes whether close channel with user
    /// </summary>
    /// <param name="identityReference">The identity reference</param>
    /// <param name="channel">The channel</param>
    /// <returns>The bool</returns>
    public static bool CloseChannelWithUser(string identityReference, long channel)
    {
        return GetInstance().Call(Methods.CloseChannelWithUser, identityReference, channel).AsBool();
    }
    
    /// <summary>
    /// Describes whether close session with user
    /// </summary>
    /// <param name="identityReference">The identity reference</param>
    /// <returns>The bool</returns>
    public static bool CloseSessionWithUser(string identityReference)
    {
        return GetInstance().Call(Methods.CloseSessionWithUser, identityReference).AsBool();
    }
    
    /// <summary>
    /// Gets the session connection info using the specified identity reference
    /// </summary>
    /// <param name="identityReference">The identity reference</param>
    /// <param name="getConnection">The get connection</param>
    /// <param name="getStatus">The get status</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetSessionConnectionInfo(string identityReference, bool getConnection, bool getStatus)
    {
        return GetInstance().Call(Methods.GetSessionConnectionInfo, identityReference, getConnection, getStatus).AsGodotDictionary();
    }
    
    /// <summary>
    /// Receives the messages on channel using the specified channel
    /// </summary>
    /// <param name="channel">The channel</param>
    /// <param name="maxMessages">The max messages</param>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array ReceiveMessagesOnChannel(int channel, long maxMessages)
    {
        return GetInstance().Call(Methods.ReceiveMessagesOnChannel, channel, maxMessages).AsGodotArray();
    }
    
    /// <summary>
    /// Sends the message to user using the specified identity reference
    /// </summary>
    /// <param name="identityReference">The identity reference</param>
    /// <param name="data">The data</param>
    /// <param name="flags">The flags</param>
    /// <param name="channel">The channel</param>
    /// <returns>The int</returns>
    public static int SendMessageToUser(string identityReference, byte[] data, int flags, long channel)
    {
        return GetInstance().Call(Methods.SendMessageToUser, identityReference, data, flags, channel).AsInt32();
    }
}