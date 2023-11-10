namespace GodotSteam;

public static partial class Steam
{
    public static void GetOPFSettings(long appId)
    {
        GetInstance().Call(Methods.GetOPFSettings, appId);
    }
    
    public static string GetOPFStringForApp(long appId)
    {
        return GetInstance().Call(Methods.GetOPFStringForApp, appId).AsString();
    }
    
    public static void GetVideoURL(long appId)
    {
        GetInstance().Call(Methods.GetVideoURL, appId);
    }
    
    public static Godot.Collections.Dictionary IsBroadcasting()
    {
        return GetInstance().Call(Methods.IsBroadcasting).AsGodotDictionary();
    }
}