using System.Linq;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Gets the opf settings using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    public static void GetOPFSettings(uint appId)
    {
        GetInstance().Call(Methods.GetOPFSettings, appId);
    }
    
    /// <summary>
    /// Gets the opf string for app using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <returns>The string</returns>
    public static string GetOPFStringForApp(uint appId)
    {
        return GetInstance().Call(Methods.GetOPFStringForApp, appId).AsString();
    }
    
    /// <summary>
    /// Gets the video url using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    public static void GetVideoURL(uint appId)
    {
        GetInstance().Call(Methods.GetVideoURL, appId);
    }
    
    /// <summary>
    /// Ises the broadcasting
    /// </summary>
    /// <returns>The broadcast status</returns>
    public static BroadcastStatus IsBroadcasting()
    {
        var raw = GetInstance().Call(Methods.IsBroadcasting).AsGodotDictionary();

        return new BroadcastStatus
        {
            Broadcasting = raw["broadcasting"].AsBool(),
            Viewers = raw["viewers"].AsInt32(),
        };
    }
}