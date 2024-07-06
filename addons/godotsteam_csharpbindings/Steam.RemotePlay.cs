namespace GodotSteam;

public static partial class Steam
{
    public static long GetSessionCount()
    {
        return GetInstance().Call(Methods.GetSessionCount).AsInt64();
    }
    
    public static uint GetSessionID(long index)
    {
        return GetInstance().Call(Methods.GetSessionID, index).As<uint>();
    }
    
    public static ulong GetSessionSteamID(long sessionId)
    {
        return GetInstance().Call(Methods.GetSessionSteamID, sessionId).As<ulong>();
    }
    
    public static string GetSessionClientName(long sessionId)
    {
        return GetInstance().Call(Methods.GetSessionClientName, sessionId).As<string>();
    }
    
    public static int GetSessionClientFormFactor(long sessionId)
    {
        return GetInstance().Call(Methods.GetSessionClientFormFactor, sessionId).As<int>();
    }
    
    public static Godot.Collections.Dictionary GetSessionClientResolution(long sessionId)
    {
        return GetInstance().Call(Methods.GetSessionClientResolution, sessionId).AsGodotDictionary();
    }
    
    public static bool SendRemotePlayTogetherInvite(ulong friendId)
    {
        return GetInstance().Call(Methods.SendRemotePlayTogetherInvite, friendId).As<bool>();
    }
    
    public static bool StartRemotePlayTogether(bool showOverlay = true)
    {
        return GetInstance().Call(Methods.StartRemotePlayTogether, showOverlay).As<bool>();
    }
}