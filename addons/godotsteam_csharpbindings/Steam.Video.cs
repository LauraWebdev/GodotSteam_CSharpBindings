using System.Linq;

namespace GodotSteam;

public static partial class Steam
{
    public static void GetOPFSettings(uint appId)
    {
        GetInstance().Call(Methods.GetOPFSettings, appId);
    }
    
    public static string GetOPFStringForApp(uint appId)
    {
        return GetInstance().Call(Methods.GetOPFStringForApp, appId).As<string>();
    }
    
    public static void GetVideoURL(uint appId)
    {
        GetInstance().Call(Methods.GetVideoURL, appId);
    }
    
    public static BroadcastStatus IsBroadcasting()
    {
        var raw = GetInstance().Call(Methods.IsBroadcasting).AsGodotDictionary();

        return new BroadcastStatus
        {
            Broadcasting = raw["broadcasting"].As<bool>(),
            Viewers = raw["viewers"].As<int>(),
        };
    }
}