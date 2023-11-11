namespace GodotSteam;

public static partial class Steam
{
    public static bool AcceptSessionWithUser(string identityReference)
    {
        return GetInstance().Call(Methods.AcceptSessionWithUser, identityReference).AsBool();
    }
    
    public static bool CloseChannelWithUser(string identityReference, long channel)
    {
        return GetInstance().Call(Methods.CloseChannelWithUser, identityReference, channel).AsBool();
    }
    
    public static bool CloseSessionWithUser(string identityReference)
    {
        return GetInstance().Call(Methods.CloseSessionWithUser, identityReference).AsBool();
    }
    
    public static Godot.Collections.Dictionary GetSessionConnectionInfo(string identityReference, bool getConnection, bool getStatus)
    {
        return GetInstance().Call(Methods.GetSessionConnectionInfo, identityReference, getConnection, getStatus).AsGodotDictionary();
    }
    
    public static Godot.Collections.Array ReceiveMessagesOnChannel(int channel, long maxMessages)
    {
        return GetInstance().Call(Methods.ReceiveMessagesOnChannel, channel, maxMessages).AsGodotArray();
    }
    
    public static int SendMessageToUser(string identityReference, byte[] data, int flags, long channel)
    {
        return GetInstance().Call(Methods.SendMessageToUser, identityReference, data, flags, channel).AsInt32();
    }
}