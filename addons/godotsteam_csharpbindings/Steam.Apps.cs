using System.Collections.Generic;
using System.Linq;
using Godot;
using Godot.Collections;

namespace GodotSteam;

public static partial class Steam
{
    public static bool IsAppInstalled(uint appId)
    {
        return GetInstance().Call(Methods.IsAppInstalled, appId).AsBool();
    }
    
    public static int GetAppBuildId()
    {
        return GetInstance().Call(Methods.GetAppBuildId).AsInt32();
    }
    
    public static InstalledAppsResult GetAppInstallDir(uint appId)
    {
        var raw = GetInstance().Call(Methods.GetAppInstallDir, appId).AsGodotDictionary();

        return new InstalledAppsResult
        {
            Directory = raw["directory"].AsString(),
            InstallSize = raw["install_size"].AsUInt32()
        };
    }
    
    public static ulong GetAppOwner()
    {
        return GetInstance().Call(Methods.GetAppOwner).AsUInt64();
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
    
    public static List<uint> GetInstalledDepots(uint appId)
    {
        var raw = GetInstance().Call(Methods.GetInstalledDepots, appId).AsGodotArray();
        
        return raw.Select(x => x.AsUInt32()).ToList();
    }
    
    public static string GetLaunchCommandLine()
    {
        return GetInstance().Call(Methods.GetLaunchCommandLine).AsString();
    }
    
    public static string GetLaunchQueryParam(string key)
    {
        return GetInstance().Call(Methods.GetLaunchQueryParam, key).AsString();
    }
    public static List<Dlc> GetDLCDataByIndex()
    {
        var raw = GetInstance().Call(Methods.GetDLCDataByIndex).AsGodotArray();

        return raw.Select(
                rawDlc => rawDlc.AsGodotDictionary()).Select(
                dlcDictionary => new Dlc
                {
                    AppId = dlcDictionary["app_id"].AsUInt32(),
                    Available = dlcDictionary["available"].AsBool(),
                    Name = dlcDictionary["name"].AsString(),
                })
            .ToList();
    }
    
    public static bool IsDLCInstalled(uint dlcId)
    {
        return GetInstance().Call(Methods.IsDLCInstalled, dlcId).AsBool();
    }
    
    public static int GetDLCCount()
    {
        return GetInstance().Call(Methods.GetDLCCount).AsInt32();
    }
    
    public static DlcDownloadProgress GetDLCDownloadProgress(uint dlcId)
    {
        var raw = GetInstance().Call(Methods.GetDLCDownloadProgress, dlcId).AsGodotDictionary();
        
        if (!raw.ContainsKey("ret") || !raw.ContainsKey("downloaded") || !raw.ContainsKey("total"))
        {
            return null;
        }
        
        return new DlcDownloadProgress
        {
            Ret = raw["ret"].AsBool(),
            Downloaded = raw["downloaded"].AsUInt64(),
            Total = raw["total"].AsUInt64()
        };
    }
    
    public static void InstallDLC(uint dlcId)
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
    
    public static void UninstallDLC(uint dlcId)
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
    
    public static IsTimedTrialResult IsTimedTrial()
    {
        var raw = GetInstance().Call(Methods.IsTimedTrial).AsGodotDictionary();

        if (!raw.ContainsKey("seconds_allowed") || !raw.ContainsKey("seconds_played"))
        {
            return null;
        }

        return new IsTimedTrialResult
        {
            SecondsAllowed = raw["seconds_allowed"].AsUInt32(),
            SecondsPlayed = raw["seconds_played"].AsUInt32()
        };
    }
    
    public static bool IsVACBanned()
    {
        return GetInstance().Call(Methods.IsVACBanned).AsBool();
    }
}