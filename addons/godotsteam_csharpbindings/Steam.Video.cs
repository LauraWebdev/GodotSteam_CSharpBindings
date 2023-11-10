namespace GodotSteam;

public static partial class Steam
{
    public static void GetOPFSettings(uint appId)
    {
        GetInstance().Call(Methods.GetOPFSettings, appId);
    }
    
    public static string GetOPFStringForApp(uint appId)
    {
        return GetInstance().Call(Methods.GetOPFStringForApp, appId).AsString();
    }
    
    public static void GetVideoURL(uint appId)
    {
        GetInstance().Call(Methods.GetVideoURL, appId);
    }
    
    public static Godot.Collections.Dictionary IsBroadcasting()
    {
        return GetInstance().Call(Methods.IsBroadcasting).AsGodotDictionary();
    }
}