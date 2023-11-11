namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Gets the session count
    /// </summary>
    /// <returns>The long</returns>
    public static long GetSessionCount()
    {
        return GetInstance().Call(Methods.GetSessionCount).AsInt64();
    }
    
    /// <summary>
    /// Gets the session id using the specified index
    /// </summary>
    /// <param name="index">The index</param>
    /// <returns>The uint</returns>
    public static uint GetSessionID(long index)
    {
        return GetInstance().Call(Methods.GetSessionID, index).AsUInt32();
    }
    
    /// <summary>
    /// Gets the session steam id using the specified session id
    /// </summary>
    /// <param name="sessionId">The session id</param>
    /// <returns>The ulong</returns>
    public static ulong GetSessionSteamID(long sessionId)
    {
        return GetInstance().Call(Methods.GetSessionSteamID, sessionId).AsUInt64();
    }
    
    /// <summary>
    /// Gets the session client name using the specified session id
    /// </summary>
    /// <param name="sessionId">The session id</param>
    /// <returns>The string</returns>
    public static string GetSessionClientName(long sessionId)
    {
        return GetInstance().Call(Methods.GetSessionClientName, sessionId).AsString();
    }
    
    /// <summary>
    /// Gets the session client form factor using the specified session id
    /// </summary>
    /// <param name="sessionId">The session id</param>
    /// <returns>The int</returns>
    public static int GetSessionClientFormFactor(long sessionId)
    {
        return GetInstance().Call(Methods.GetSessionClientFormFactor, sessionId).AsInt32();
    }
    
    /// <summary>
    /// Gets the session client resolution using the specified session id
    /// </summary>
    /// <param name="sessionId">The session id</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetSessionClientResolution(long sessionId)
    {
        return GetInstance().Call(Methods.GetSessionClientResolution, sessionId).AsGodotDictionary();
    }
    
    /// <summary>
    /// Describes whether send remote play together invite
    /// </summary>
    /// <param name="friendId">The friend id</param>
    /// <returns>The bool</returns>
    public static bool SendRemotePlayTogetherInvite(ulong friendId)
    {
        return GetInstance().Call(Methods.SendRemotePlayTogetherInvite, friendId).AsBool();
    }
    
    /// <summary>
    /// Describes whether start remote play together
    /// </summary>
    /// <param name="showOverlay">The show overlay</param>
    /// <returns>The bool</returns>
    public static bool StartRemotePlayTogether(bool showOverlay = true)
    {
        return GetInstance().Call(Methods.StartRemotePlayTogether, showOverlay).AsBool();
    }
}