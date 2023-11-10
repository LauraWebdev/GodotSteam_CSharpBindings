using Godot.Collections;

namespace GodotSteam;

public static partial class Steam
{
    public static Godot.Collections.Array GetInstalledApps(long maxAppIds)
    {
        return GetInstance().Call(Methods.GetInstalledApps, maxAppIds).AsGodotArray();
    }
    
    public static string GetAppName(uint appId, long nameMax)
    {
        return GetInstance().Call(Methods.GetAppName, appId, nameMax).AsString();
    }
    
    public static string GetAppListInstallDir(uint appId, long nameMax)
    {
        return GetInstance().Call(Methods.GetAppListInstallDir, appId, nameMax).AsString();
    }
    
    public static string GetAppListBuildId(uint appId, long _UnnamedArg1)
    {
        return GetInstance().Call(Methods.GetAppListBuildId, appId, _UnnamedArg1).AsString();
    }
    
    public static long GetNumInstalledApps()
    {
        return GetInstance().Call(Methods.GetNumInstalledApps).AsInt64();
    }
}