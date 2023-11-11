using System.Collections.Generic;
using System.Linq;
using Godot.Collections;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Gets the installed apps using the specified max app ids
    /// </summary>
    /// <param name="maxAppIds">The max app ids</param>
    /// <returns>A list of uint</returns>
    public static List<uint> GetInstalledApps(uint maxAppIds)
    {
        var raw = GetInstance().Call(Methods.GetInstalledApps, maxAppIds).AsGodotArray();

        return raw.Select(x => x.AsUInt32()).ToList();
    }
    
    /// <summary>
    /// Gets the app name using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <param name="nameMax">The name max</param>
    /// <returns>The string</returns>
    public static string GetAppName(uint appId, int nameMax)
    {
        return GetInstance().Call(Methods.GetAppName, appId, nameMax).AsString();
    }
    
    /// <summary>
    /// Gets the app list install dir using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <param name="nameMax">The name max</param>
    /// <returns>The string</returns>
    public static string GetAppListInstallDir(uint appId, int nameMax)
    {
        return GetInstance().Call(Methods.GetAppListInstallDir, appId, nameMax).AsString();
    }
    
    /// <summary>
    /// Gets the app list build id using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <returns>The int</returns>
    public static int GetAppListBuildId(uint appId)
    {
        return GetInstance().Call(Methods.GetAppListBuildId, appId).AsInt32();
    }
    
    /// <summary>
    /// Gets the num installed apps
    /// </summary>
    /// <returns>The long</returns>
    public static long GetNumInstalledApps()
    {
        return GetInstance().Call(Methods.GetNumInstalledApps).AsInt64();
    }
}