namespace GodotSteam;

public static partial class Steam
{
    public static bool AcceptSessionWithUser(ulong remoteSteamId)
    {
        return GetInstance().Call(Methods.AcceptSessionWithUser, remoteSteamId).AsBool();
    }
    
    public static bool CloseChannelWithUser(ulong remoteSteamId, long channel)
    {
        return GetInstance().Call(Methods.CloseChannelWithUser, remoteSteamId, channel).AsBool();
    }
    
    public static bool CloseSessionWithUser(ulong remoteSteamId)
    {
        return GetInstance().Call(Methods.CloseSessionWithUser, remoteSteamId).AsBool();
    }
    
    public static Godot.Collections.Dictionary GetSessionConnectionInfo(ulong remoteSteamId, bool getConnection, bool getStatus)
    {
        return GetInstance().Call(Methods.GetSessionConnectionInfo, remoteSteamId, getConnection, getStatus).AsGodotDictionary();
    }
    
    public static Godot.Collections.Array ReceiveMessagesOnChannel(int channel, long maxMessages)
    {
        return GetInstance().Call(Methods.ReceiveMessagesOnChannel, channel, maxMessages).AsGodotArray();
    }
    
    public static int SendMessageToUser(ulong remoteSteamId, byte[] data, int flags, long channel)
    {
        return GetInstance().Call(Methods.SendMessageToUser, remoteSteamId, data, flags, channel).AsInt32();
    }
}