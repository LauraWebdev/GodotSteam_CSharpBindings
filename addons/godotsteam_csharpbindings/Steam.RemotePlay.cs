namespace GodotSteam;

public static partial class Steam
{
    public static long GetSessionCount()
    {
        return GetInstance().Call(Methods.GetSessionCount).AsInt64();
    }
    
    public static uint GetSessionID(long index)
    {
        return GetInstance().Call(Methods.GetSessionID, index).AsUInt32();
    }
    
    public static ulong GetSessionSteamID(long sessionId)
    {
        return GetInstance().Call(Methods.GetSessionSteamID, sessionId).AsUInt64();
    }
    
    public static string GetSessionClientName(long sessionId)
    {
        return GetInstance().Call(Methods.GetSessionClientName, sessionId).AsString();
    }
    
    public static int GetSessionClientFormFactor(long sessionId)
    {
        return GetInstance().Call(Methods.GetSessionClientFormFactor, sessionId).AsInt32();
    }
    
    public static Godot.Collections.Dictionary GetSessionClientResolution(long sessionId)
    {
        return GetInstance().Call(Methods.GetSessionClientResolution, sessionId).AsGodotDictionary();
    }
    
    public static bool SendRemotePlayTogetherInvite(long friendId)
    {
        return GetInstance().Call(Methods.SendRemotePlayTogetherInvite, friendId).AsBool();
    }
    
    public static bool StartRemotePlayTogether(bool showOverlay = true)
    {
        return GetInstance().Call(Methods.StartRemotePlayTogether, showOverlay).AsBool();
    }
}