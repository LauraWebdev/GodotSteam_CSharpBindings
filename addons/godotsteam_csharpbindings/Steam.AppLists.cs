using System.Collections.Generic;
using System.Linq;
using Godot.Collections;

namespace GodotSteam;

public static partial class Steam
{
    public static List<uint> GetInstalledApps(uint maxAppIds)
    {
        var raw = GetInstance().Call(Methods.GetInstalledApps, maxAppIds).AsGodotArray();

        return raw.Select(x => x.As<uint>()).ToList();
    }
    
    public static string GetAppName(uint appId, int nameMax)
    {
        return GetInstance().Call(Methods.GetAppName, appId, nameMax).As<string>();
    }
    
    public static string GetAppListInstallDir(uint appId, int nameMax)
    {
        return GetInstance().Call(Methods.GetAppListInstallDir, appId, nameMax).As<string>();
    }
    
    public static int GetAppListBuildId(uint appId)
    {
        return GetInstance().Call(Methods.GetAppListBuildId, appId).As<int>();
    }
    
    public static long GetNumInstalledApps()
    {
        return GetInstance().Call(Methods.GetNumInstalledApps).AsInt64();
    }
}