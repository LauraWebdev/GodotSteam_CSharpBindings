
using System;

namespace GodotSteam;

public static partial class Steam
{
    public static void AttachLeaderboardUGC(ulong ugcHandle, long thisLeaderboard = 0)
    {
        GetInstance().Call(Methods.AttachLeaderboardUGC, ugcHandle, thisLeaderboard);
    }
    
    public static bool ClearAchievement(string achievementName)
    {
        return GetInstance().Call(Methods.ClearAchievement, achievementName).As<bool>();
    }
    
    public static void DownloadLeaderboardEntries(int start, int end, LeaderboardDataRequest type = 0, long thisLeaderboard = 0)
    {
        GetInstance().Call(Methods.DownloadLeaderboardEntries, start, end, (long)type, thisLeaderboard);
    }
    
    public static void DownloadLeaderboardEntriesForUsers(Godot.Collections.Array usersId, long thisLeaderboard = 0)
    {
        GetInstance().Call(Methods.DownloadLeaderboardEntriesForUsers, usersId, thisLeaderboard);
    }
    
    public static void FindLeaderboard(string leaderboardName)
    {
        GetInstance().Call(Methods.FindLeaderboard, leaderboardName);
    }
    
    public static void FindOrCreateLeaderboard(string leaderboardName, LeaderboardSortMethod sortMethod, LeaderboardDisplayType displayType)
    {
        GetInstance().Call(Methods.FindOrCreateLeaderboard, leaderboardName, (long)sortMethod, (long)displayType);
    }
    
    public static Godot.Collections.Dictionary GetAchievement(string achievementName)
    {
        return GetInstance().Call(Methods.GetAchievement, achievementName).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetAchievementAchievedPercent(string achievementName)
    {
        return GetInstance().Call(Methods.GetAchievementAchievedPercent, achievementName).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetAchievementAndUnlockTime(string achievementName)
    {
        return GetInstance().Call(Methods.GetAchievementAndUnlockTime, achievementName).AsGodotDictionary();
    }
    
    public static string GetAchievementDisplayAttribute(string achievementName, string key)
    {
        return GetInstance().Call(Methods.GetAchievementDisplayAttribute, achievementName, key).As<string>();
    }
    
    public static int GetAchievementIcon(string achievementName)
    {
        return GetInstance().Call(Methods.GetAchievementIcon, achievementName).As<int>();
    }
    
    public static string GetAchievementName(long achievement)
    {
        return GetInstance().Call(Methods.GetAchievementName, achievement).As<string>();
    }
    
    public static Godot.Collections.Dictionary GetAchievementProgressLimitsInt(string achievementName)
    {
        return GetInstance().Call(Methods.GetAchievementProgressLimitsInt, achievementName).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetAchievementProgressLimitsFloat(string achievementName)
    {
        return GetInstance().Call(Methods.GetAchievementProgressLimitsFloat, achievementName).AsGodotDictionary();
    }
    
    public static ulong GetGlobalStatInt(string statName)
    {
        return GetInstance().Call(Methods.GetGlobalStatInt, statName).As<ulong>();
    }
    
    public static double GetGlobalStatFloat(string statName)
    {
        return GetInstance().Call(Methods.GetGlobalStatFloat, statName).AsDouble();
    }
    
    public static ulong GetGlobalStatIntHistory(string statName)
    {
        return GetInstance().Call(Methods.GetGlobalStatIntHistory, statName).As<ulong>();
    }
    
    public static double GetGlobalStatFloatHistory(string statName)
    {
        return GetInstance().Call(Methods.GetGlobalStatFloatHistory, statName).AsDouble();
    }
    
    public static Godot.Collections.Dictionary GetLeaderboardDisplayType(long thisLeaderboard = 0)
    {
        return GetInstance().Call(Methods.GetLeaderboardDisplayType, thisLeaderboard).AsGodotDictionary();
    }
    
    public static int GetLeaderboardEntryCount(long thisLeaderboard = 0)
    {
        return GetInstance().Call(Methods.GetLeaderboardEntryCount, thisLeaderboard).As<int>();
    }
    
    public static string GetLeaderboardName(long thisLeaderboard = 0)
    {
        return GetInstance().Call(Methods.GetLeaderboardName, thisLeaderboard).As<string>();
    }
    
    public static Godot.Collections.Dictionary GetLeaderboardSortMethod(long thisLeaderboard = 0)
    {
        return GetInstance().Call(Methods.GetLeaderboardSortMethod, thisLeaderboard).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetMostAchievedAchievementInfo()
    {
        return GetInstance().Call(Methods.GetMostAchievedAchievementInfo).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetNextMostAchievedAchievementInfo(long iterator)
    {
        return GetInstance().Call(Methods.GetNextMostAchievedAchievementInfo, iterator).AsGodotDictionary();
    }
    
    public static long GetNumAchievements()
    {
        return GetInstance().Call(Methods.GetNumAchievements).AsInt64();
    }
    
    public static void GetNumberOfCurrentPlayers()
    {
        GetInstance().Call(Methods.GetNumberOfCurrentPlayers);
    }
    
    public static float GetStatFloat(string statName)
    {
        return GetInstance().Call(Methods.GetStatFloat, statName).AsSingle();
    }
    
    public static int GetStatInt(string statName)
    {
        return GetInstance().Call(Methods.GetStatInt, statName).As<int>();
    }
    
    public static Godot.Collections.Dictionary GetUserAchievement(ulong steamId, string name)
    {
        return GetInstance().Call(Methods.GetUserAchievement, steamId, name).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetUserAchievementAndUnlockTime(ulong steamId, string name)
    {
        return GetInstance().Call(Methods.GetUserAchievementAndUnlockTime, steamId, name).AsGodotDictionary();
    }
    
    public static float GetUserStatFloat(ulong steamId, string name)
    {
        return GetInstance().Call(Methods.GetUserStatFloat, steamId, name).AsSingle();
    }
    
    public static int GetUserStatInt(ulong steamId, string name)
    {
        return GetInstance().Call(Methods.GetUserStatInt, steamId, name).As<int>();
    }
    
    public static bool IndicateAchievementProgress(string name, int currentProgress, long maxProgress)
    {
        return GetInstance().Call(Methods.IndicateAchievementProgress, name, currentProgress, maxProgress).As<bool>();
    }
    
    public static bool RequestCurrentStats()
    {
        return GetInstance().Call(Methods.RequestCurrentStats).As<bool>();
    }
    
    public static void RequestGlobalAchievementPercentages()
    {
        GetInstance().Call(Methods.RequestGlobalAchievementPercentages);
    }
    
    public static void RequestGlobalStats(long historyDays)
    {
        GetInstance().Call(Methods.RequestGlobalStats, historyDays);
    }
    
    public static void RequestUserStats(ulong steamId)
    {
        GetInstance().Call(Methods.RequestUserStats, steamId);
    }
    
    public static bool ResetAllStats(bool achievementsToo)
    {
        return GetInstance().Call(Methods.ResetAllStats, achievementsToo).As<bool>();
    }
    
    public static bool SetAchievement(string name)
    {
        return GetInstance().Call(Methods.SetAchievement, name).As<bool>();
    }
    
    [Obsolete]
    public static int SetLeaderboardDetailsMax(long max)
    {
        return GetInstance().Call(Methods.SetLeaderboardDetailsMax, max).As<int>();
    }
    
    public static bool SetStatFloat(string name, double value)
    {
        return GetInstance().Call(Methods.SetStatFloat, name, value).As<bool>();
    }
    
    public static bool SetStatInt(string name, long value)
    {
        return GetInstance().Call(Methods.SetStatInt, name, value).As<bool>();
    }
    
    public static bool StoreStats()
    {
        return GetInstance().Call(Methods.StoreStats).As<bool>();
    }
    
    public static bool UpdateAvgRateStat(string name, float thisSession, double sessionLength)
    {
        return GetInstance().Call(Methods.UpdateAvgRateStat, name, thisSession, sessionLength).As<bool>();
    }
    
    /// <param name="details">If the parameter is null, then the default value is <c>Array.Empty&lt;int&gt;()</c>.</param>
    public static void UploadLeaderboardScore(int score, bool keepBest = true, int[] details = null, long thisLeaderboard = 0)
    {
        var detailsOrDefVal = details ?? Array.Empty<int>();
        GetInstance().Call(Methods.UploadLeaderboardScore, score, keepBest, detailsOrDefVal, thisLeaderboard);

    }
    
    public static Godot.Collections.Array GetLeaderboardEntries()
    {
        return GetInstance().Call(Methods.GetLeaderboardEntries).AsGodotArray();
    }

    public enum LeaderboardDataRequest : long
    {
        Global = 0,
        GlobalAroundUser = 1,
        Friends = 2,
        Users = 3
    }

    public enum LeaderboardDisplayType : long
    {
        None = 0,
        Numeric = 1,
        TimeSeconds = 2,
        TimeMilliseconds = 3
    }

    public enum LeaderboardSortMethod : long
    {
        None = 0,
        Ascending = 1,
        Descending = 2
    }

    public enum LeaderboardUploadScoreMethod : long
    {
        None = 0,
        KeepBest = 1,
        ForceUpdate = 2
    }
}