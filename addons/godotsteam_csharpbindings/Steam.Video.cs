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
        return GetInstance().Call(Methods.GetOPFStringForApp, appId).AsString();
    }
    
    public static void GetVideoURL(uint appId)
    {
        GetInstance().Call(Methods.GetVideoURL, appId);
    }
    
    public static BroadcastStatus IsBroadcasting()
    {
        var rawStatus = GetInstance().Call(Methods.IsBroadcasting).AsGodotDictionary();

        return new BroadcastStatus
        {
            Broadcasting = rawStatus["broadcasting"].AsBool(),
            Viewers = rawStatus["viewers"].AsInt32(),
        };
    }
}