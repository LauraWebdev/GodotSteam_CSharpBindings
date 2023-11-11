using System.Collections.Generic;
using System.Linq;
using Godot;
using Godot.Collections;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Describes whether is app installed
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <returns>The bool</returns>
    public static bool IsAppInstalled(uint appId)
    {
        return GetInstance().Call(Methods.IsAppInstalled, appId).AsBool();
    }
    
    /// <summary>
    /// Gets the app build id
    /// </summary>
    /// <returns>The int</returns>
    public static int GetAppBuildId()
    {
        return GetInstance().Call(Methods.GetAppBuildId).AsInt32();
    }
    
    /// <summary>
    /// Gets the app install dir using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <returns>The installed apps</returns>
    public static InstalledApps GetAppInstallDir(uint appId)
    {
        var raw = GetInstance().Call(Methods.GetAppInstallDir, appId).AsGodotDictionary();

        return new InstalledApps
        {
            Directory = raw["directory"].AsString(),
            InstallSize = raw["install_size"].AsUInt32()
        };
    }
    
    /// <summary>
    /// Gets the app owner
    /// </summary>
    /// <returns>The ulong</returns>
    public static ulong GetAppOwner()
    {
        return GetInstance().Call(Methods.GetAppOwner).AsUInt64();
    }
    
    /// <summary>
    /// Gets the available game languages
    /// </summary>
    /// <returns>The string</returns>
    public static string GetAvailableGameLanguages()
    {
        return GetInstance().Call(Methods.GetAvailableGameLanguages).AsString();
    }
    
    /// <summary>
    /// Gets the current beta name
    /// </summary>
    /// <returns>The string</returns>
    public static string GetCurrentBetaName()
    {
        return GetInstance().Call(Methods.GetCurrentBetaName).AsString();
    }
    
    /// <summary>
    /// Gets the current game language
    /// </summary>
    /// <returns>The string</returns>
    public static string GetCurrentGameLanguage()
    {
        return GetInstance().Call(Methods.GetCurrentGameLanguage).AsString();
    }
    
    /// <summary>
    /// Gets the earliest purchase unix time using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <returns>The uint</returns>
    public static uint GetEarliestPurchaseUnixTime(uint appId)
    {
        return GetInstance().Call(Methods.GetEarliestPurchaseUnixTime, appId).AsUInt32();
    }
    
    /// <summary>
    /// Gets the file details using the specified file name
    /// </summary>
    /// <param name="fileName">The file name</param>
    public static void GetFileDetails(string fileName)
    {
        GetInstance().Call(Methods.GetFileDetails, fileName);
    }
    
    /// <summary>
    /// Gets the installed depots using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <returns>A list of uint</returns>
    public static List<uint> GetInstalledDepots(uint appId)
    {
        var raw = GetInstance().Call(Methods.GetInstalledDepots, appId).AsGodotArray();
        
        return raw.Select(x => x.AsUInt32()).ToList();
    }
    
    /// <summary>
    /// Gets the launch command line
    /// </summary>
    /// <returns>The string</returns>
    public static string GetLaunchCommandLine()
    {
        return GetInstance().Call(Methods.GetLaunchCommandLine).AsString();
    }
    
    /// <summary>
    /// Gets the launch query param using the specified key
    /// </summary>
    /// <param name="key">The key</param>
    /// <returns>The string</returns>
    public static string GetLaunchQueryParam(string key)
    {
        return GetInstance().Call(Methods.GetLaunchQueryParam, key).AsString();
    }
    /// <summary>
    /// Gets the dlc data by index
    /// </summary>
    /// <returns>A list of dlc</returns>
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
    
    /// <summary>
    /// Describes whether is dlc installed
    /// </summary>
    /// <param name="dlcId">The dlc id</param>
    /// <returns>The bool</returns>
    public static bool IsDLCInstalled(uint dlcId)
    {
        return GetInstance().Call(Methods.IsDLCInstalled, dlcId).AsBool();
    }
    
    /// <summary>
    /// Gets the dlc count
    /// </summary>
    /// <returns>The int</returns>
    public static int GetDLCCount()
    {
        return GetInstance().Call(Methods.GetDLCCount).AsInt32();
    }
    
    /// <summary>
    /// Gets the dlc download progress using the specified dlc id
    /// </summary>
    /// <param name="dlcId">The dlc id</param>
    /// <returns>The dlc download progress</returns>
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
    
    /// <summary>
    /// Installs the dlc using the specified dlc id
    /// </summary>
    /// <param name="dlcId">The dlc id</param>
    public static void InstallDLC(uint dlcId)
    {
        GetInstance().Call(Methods.InstallDLC, dlcId);
    }
    
    /// <summary>
    /// Describes whether mark content corrupt
    /// </summary>
    /// <param name="missingFilesOnly">The missing files only</param>
    /// <returns>The bool</returns>
    public static bool MarkContentCorrupt(bool missingFilesOnly)
    {
        return GetInstance().Call(Methods.MarkContentCorrupt, missingFilesOnly).AsBool();
    }
    
    /// <summary>
    /// Describes whether set dlc context
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <returns>The bool</returns>
    public static bool SetDLCContext(uint appId)
    {
        return GetInstance().Call(Methods.SetDLCContext, appId).AsBool();
    }
    
    /// <summary>
    /// Uninstalls the dlc using the specified dlc id
    /// </summary>
    /// <param name="dlcId">The dlc id</param>
    public static void UninstallDLC(uint dlcId)
    {
        GetInstance().Call(Methods.UninstallDLC, dlcId);
    }
    
    /// <summary>
    /// Describes whether is low violence
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsLowViolence()
    {
        return GetInstance().Call(Methods.IsLowViolence).AsBool();
    }
    
    /// <summary>
    /// Describes whether is subscribed
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsSubscribed()
    {
        return GetInstance().Call(Methods.IsSubscribed).AsBool();
    }
    
    /// <summary>
    /// Describes whether is subscribed app
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <returns>The bool</returns>
    public static bool IsSubscribedApp(uint appId)
    {
        return GetInstance().Call(Methods.IsSubscribedApp, appId).AsBool();
    }
    
    /// <summary>
    /// Describes whether is subscribed from family sharing
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsSubscribedFromFamilySharing()
    {
        return GetInstance().Call(Methods.IsSubscribedFromFamilySharing).AsBool();
    }
    
    /// <summary>
    /// Describes whether is subscribed from free weekend
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsSubscribedFromFreeWeekend()
    {
        return GetInstance().Call(Methods.IsSubscribedFromFreeWeekend).AsBool();
    }
    
    /// <summary>
    /// Ises the timed trial
    /// </summary>
    /// <returns>The timed trial</returns>
    public static TimedTrial IsTimedTrial()
    {
        var raw = GetInstance().Call(Methods.IsTimedTrial).AsGodotDictionary();

        if (!raw.ContainsKey("seconds_allowed") || !raw.ContainsKey("seconds_played"))
        {
            return null;
        }

        return new TimedTrial
        {
            SecondsAllowed = raw["seconds_allowed"].AsUInt32(),
            SecondsPlayed = raw["seconds_played"].AsUInt32()
        };
    }
    
    /// <summary>
    /// Describes whether is vac banned
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsVACBanned()
    {
        return GetInstance().Call(Methods.IsVACBanned).AsBool();
    }
}