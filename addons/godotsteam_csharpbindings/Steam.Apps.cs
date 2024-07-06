using System.Collections.Generic;
using System.Linq;
using Godot;
using Godot.Collections;

namespace GodotSteam;

public static partial class Steam
{
    public static bool IsAppInstalled(uint appId)
    {
        return GetInstance().Call(Methods.IsAppInstalled, appId).As<bool>();
    }
    
    public static int GetAppBuildId()
    {
        return GetInstance().Call(Methods.GetAppBuildId).As<int>();
    }
    
    public static InstalledApps GetAppInstallDir(uint appId)
    {
        var raw = GetInstance().Call(Methods.GetAppInstallDir, appId).AsGodotDictionary();

        return new InstalledApps
        {
            Directory = raw["directory"].As<string>(),
            InstallSize = raw["install_size"].As<uint>()
        };
    }
    
    public static ulong GetAppOwner()
    {
        return GetInstance().Call(Methods.GetAppOwner).As<ulong>();
    }
    
    public static string GetAvailableGameLanguages()
    {
        return GetInstance().Call(Methods.GetAvailableGameLanguages).As<string>();
    }
    
    public static string GetCurrentBetaName()
    {
        return GetInstance().Call(Methods.GetCurrentBetaName).As<string>();
    }
    
    public static string GetCurrentGameLanguage()
    {
        return GetInstance().Call(Methods.GetCurrentGameLanguage).As<string>();
    }
    
    public static uint GetEarliestPurchaseUnixTime(uint appId)
    {
        return GetInstance().Call(Methods.GetEarliestPurchaseUnixTime, appId).As<uint>();
    }
    
    public static void GetFileDetails(string fileName)
    {
        GetInstance().Call(Methods.GetFileDetails, fileName);
    }
    
    public static List<uint> GetInstalledDepots(uint appId)
    {
        var raw = GetInstance().Call(Methods.GetInstalledDepots, appId).AsGodotArray();
        
        return raw.Select(x => x.As<uint>()).ToList();
    }
    
    public static string GetLaunchCommandLine()
    {
        return GetInstance().Call(Methods.GetLaunchCommandLine).As<string>();
    }
    
    public static string GetLaunchQueryParam(string key)
    {
        return GetInstance().Call(Methods.GetLaunchQueryParam, key).As<string>();
    }
    public static List<Dlc> GetDLCDataByIndex()
    {
        var raw = GetInstance().Call(Methods.GetDLCDataByIndex).AsGodotArray();

        return raw.Select(
                rawDlc => rawDlc.AsGodotDictionary()).Select(
                dlcDictionary => new Dlc
                {
                    AppId = dlcDictionary["app_id"].As<uint>(),
                    Available = dlcDictionary["available"].As<bool>(),
                    Name = dlcDictionary["name"].As<string>(),
                })
            .ToList();
    }
    
    public static bool IsDLCInstalled(uint dlcId)
    {
        return GetInstance().Call(Methods.IsDLCInstalled, dlcId).As<bool>();
    }
    
    public static int GetDLCCount()
    {
        return GetInstance().Call(Methods.GetDLCCount).As<int>();
    }
    
    public static DlcDownloadProgress? GetDLCDownloadProgress(uint dlcId)
    {
        var raw = GetInstance().Call(Methods.GetDLCDownloadProgress, dlcId).AsGodotDictionary();
        
        if (!raw.ContainsKey("ret") || !raw.ContainsKey("downloaded") || !raw.ContainsKey("total"))
        {
            return null;
        }
        
        return new DlcDownloadProgress
        {
            Ret = raw["ret"].As<bool>(),
            Downloaded = raw["downloaded"].As<ulong>(),
            Total = raw["total"].As<ulong>()
        };
    }
    
    public static void InstallDLC(uint dlcId)
    {
        GetInstance().Call(Methods.InstallDLC, dlcId);
    }
    
    public static bool MarkContentCorrupt(bool missingFilesOnly)
    {
        return GetInstance().Call(Methods.MarkContentCorrupt, missingFilesOnly).As<bool>();
    }
    
    public static bool SetDLCContext(uint appId)
    {
        return GetInstance().Call(Methods.SetDLCContext, appId).As<bool>();
    }
    
    public static void UninstallDLC(uint dlcId)
    {
        GetInstance().Call(Methods.UninstallDLC, dlcId);
    }
    
    public static bool IsLowViolence()
    {
        return GetInstance().Call(Methods.IsLowViolence).As<bool>();
    }
    
    public static bool IsSubscribed()
    {
        return GetInstance().Call(Methods.IsSubscribed).As<bool>();
    }
    
    public static bool IsSubscribedApp(uint appId)
    {
        return GetInstance().Call(Methods.IsSubscribedApp, appId).As<bool>();
    }
    
    public static bool IsSubscribedFromFamilySharing()
    {
        return GetInstance().Call(Methods.IsSubscribedFromFamilySharing).As<bool>();
    }
    
    public static bool IsSubscribedFromFreeWeekend()
    {
        return GetInstance().Call(Methods.IsSubscribedFromFreeWeekend).As<bool>();
    }
    
    public static TimedTrial IsTimedTrial()
    {
        var raw = GetInstance().Call(Methods.IsTimedTrial).AsGodotDictionary();

        if (!raw.ContainsKey("seconds_allowed") || !raw.ContainsKey("seconds_played"))
        {
            return null;
        }

        return new TimedTrial
        {
            SecondsAllowed = raw["seconds_allowed"].As<uint>(),
            SecondsPlayed = raw["seconds_played"].As<uint>()
        };
    }
    
    public static bool IsVACBanned()
    {
        return GetInstance().Call(Methods.IsVACBanned).As<bool>();
    }
}