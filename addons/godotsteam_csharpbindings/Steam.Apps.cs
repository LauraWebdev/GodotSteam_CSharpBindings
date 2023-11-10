using Godot.Collections;

namespace GodotSteam;

public static partial class Steam
{
    public static bool IsAppInstalled(uint appId)
    {
        return GetInstance().Call(Methods.IsAppInstalled, appId).AsBool();
    }
    
    public static long GetAppBuildId()
    {
        return GetInstance().Call(Methods.GetAppBuildId).AsInt64();
    }
    
    public static Dictionary GetAppInstallDir(uint appId)
    {
        return GetInstance().Call(Methods.GetAppInstallDir, appId).AsGodotDictionary();
    }
    
    public static long GetAppOwner()
    {
        return GetInstance().Call(Methods.GetAppOwner).AsInt64();
    }
    
    public static string GetAvailableGameLanguages()
    {
        return GetInstance().Call(Methods.GetAvailableGameLanguages).AsString();
    }
    
    public static string GetCurrentBetaName()
    {
        return GetInstance().Call(Methods.GetCurrentBetaName).AsString();
    }
    
    public static string GetCurrentGameLanguage()
    {
        return GetInstance().Call(Methods.GetCurrentGameLanguage).AsString();
    }
    
    public static uint GetEarliestPurchaseUnixTime(uint appId)
    {
        return GetInstance().Call(Methods.GetEarliestPurchaseUnixTime, appId).AsUInt32();
    }
    
    public static void GetFileDetails(string fileName)
    {
        GetInstance().Call(Methods.GetFileDetails, fileName);
    }
    
    public static Godot.Collections.Array GetInstalledDepots(uint appId)
    {
        return GetInstance().Call(Methods.GetInstalledDepots, appId).AsGodotArray();
    }
    
    public static string GetLaunchCommandLine()
    {
        return GetInstance().Call(Methods.GetLaunchCommandLine).AsString();
    }
    
    public static string GetLaunchQueryParam(string key)
    {
        return GetInstance().Call(Methods.GetLaunchQueryParam, key).AsString();
    }
    public static Godot.Collections.Array GetDLCDataByIndex()
    {
        return GetInstance().Call(Methods.GetDLCDataByIndex).AsGodotArray();
    }
    
    public static bool IsDLCInstalled(long dlcId)
    {
        return GetInstance().Call(Methods.IsDLCInstalled, dlcId).AsBool();
    }
    
    public static long GetDLCCount()
    {
        return GetInstance().Call(Methods.GetDLCCount).AsInt64();
    }
    
    public static Godot.Collections.Dictionary GetDLCDownloadProgress(long dlcId)
    {
        return GetInstance().Call(Methods.GetDLCDownloadProgress, dlcId).AsGodotDictionary();
    }
    
    public static void InstallDLC(long dlcId)
    {
        GetInstance().Call(Methods.InstallDLC, dlcId);
    }
    
    public static bool MarkContentCorrupt(bool missingFilesOnly)
    {
        return GetInstance().Call(Methods.MarkContentCorrupt, missingFilesOnly).AsBool();
    }
    
    public static bool SetDLCContext(uint appId)
    {
        return GetInstance().Call(Methods.SetDLCContext, appId).AsBool();
    }
    
    public static void UninstallDLC(long dlcId)
    {
        GetInstance().Call(Methods.UninstallDLC, dlcId);
    }
    
    public static bool IsLowViolence()
    {
        return GetInstance().Call(Methods.IsLowViolence).AsBool();
    }
    
    public static bool IsSubscribed()
    {
        return GetInstance().Call(Methods.IsSubscribed).AsBool();
    }
    
    public static bool IsSubscribedApp(uint appId)
    {
        return GetInstance().Call(Methods.IsSubscribedApp, appId).AsBool();
    }
    
    public static bool IsSubscribedFromFamilySharing()
    {
        return GetInstance().Call(Methods.IsSubscribedFromFamilySharing).AsBool();
    }
    
    public static bool IsSubscribedFromFreeWeekend()
    {
        return GetInstance().Call(Methods.IsSubscribedFromFreeWeekend).AsBool();
    }
    
    public static Dictionary IsTimedTrial()
    {
        return GetInstance().Call(Methods.IsTimedTrial).AsGodotDictionary();
    }
    
    public static bool IsVACBanned()
    {
        return GetInstance().Call(Methods.IsVACBanned).AsBool();
    }
}