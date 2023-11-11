
using System;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Attaches the leaderboard ugc using the specified ugc handle
    /// </summary>
    /// <param name="ugcHandle">The ugc handle</param>
    /// <param name="thisLeaderboard">The this leaderboard</param>
    public static void AttachLeaderboardUGC(ulong ugcHandle, long thisLeaderboard = 0)
    {
        GetInstance().Call(Methods.AttachLeaderboardUGC, ugcHandle, thisLeaderboard);
    }
    
    /// <summary>
    /// Describes whether clear achievement
    /// </summary>
    /// <param name="achievementName">The achievement name</param>
    /// <returns>The bool</returns>
    public static bool ClearAchievement(string achievementName)
    {
        return GetInstance().Call(Methods.ClearAchievement, achievementName).AsBool();
    }
    
    /// <summary>
    /// Downloads the leaderboard entries using the specified start
    /// </summary>
    /// <param name="start">The start</param>
    /// <param name="end">The end</param>
    /// <param name="type">The type</param>
    /// <param name="thisLeaderboard">The this leaderboard</param>
    public static void DownloadLeaderboardEntries(int start, int end, LeaderboardDataRequest type = 0, long thisLeaderboard = 0)
    {
        GetInstance().Call(Methods.DownloadLeaderboardEntries, start, end, (long)type, thisLeaderboard);
    }
    
    /// <summary>
    /// Downloads the leaderboard entries for users using the specified users id
    /// </summary>
    /// <param name="usersId">The users id</param>
    /// <param name="thisLeaderboard">The this leaderboard</param>
    public static void DownloadLeaderboardEntriesForUsers(Godot.Collections.Array usersId, long thisLeaderboard = 0)
    {
        GetInstance().Call(Methods.DownloadLeaderboardEntriesForUsers, usersId, thisLeaderboard);
    }
    
    /// <summary>
    /// Finds the leaderboard using the specified leaderboard name
    /// </summary>
    /// <param name="leaderboardName">The leaderboard name</param>
    public static void FindLeaderboard(string leaderboardName)
    {
        GetInstance().Call(Methods.FindLeaderboard, leaderboardName);
    }
    
    /// <summary>
    /// Finds the or create leaderboard using the specified leaderboard name
    /// </summary>
    /// <param name="leaderboardName">The leaderboard name</param>
    /// <param name="sortMethod">The sort method</param>
    /// <param name="displayType">The display type</param>
    public static void FindOrCreateLeaderboard(string leaderboardName, LeaderboardSortMethod sortMethod, LeaderboardDisplayType displayType)
    {
        GetInstance().Call(Methods.FindOrCreateLeaderboard, leaderboardName, (long)sortMethod, (long)displayType);
    }
    
    /// <summary>
    /// Gets the achievement using the specified achievement name
    /// </summary>
    /// <param name="achievementName">The achievement name</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetAchievement(string achievementName)
    {
        return GetInstance().Call(Methods.GetAchievement, achievementName).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the achievement achieved percent using the specified achievement name
    /// </summary>
    /// <param name="achievementName">The achievement name</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetAchievementAchievedPercent(string achievementName)
    {
        return GetInstance().Call(Methods.GetAchievementAchievedPercent, achievementName).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the achievement and unlock time using the specified achievement name
    /// </summary>
    /// <param name="achievementName">The achievement name</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetAchievementAndUnlockTime(string achievementName)
    {
        return GetInstance().Call(Methods.GetAchievementAndUnlockTime, achievementName).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the achievement display attribute using the specified achievement name
    /// </summary>
    /// <param name="achievementName">The achievement name</param>
    /// <param name="key">The key</param>
    /// <returns>The string</returns>
    public static string GetAchievementDisplayAttribute(string achievementName, string key)
    {
        return GetInstance().Call(Methods.GetAchievementDisplayAttribute, achievementName, key).AsString();
    }
    
    /// <summary>
    /// Gets the achievement icon using the specified achievement name
    /// </summary>
    /// <param name="achievementName">The achievement name</param>
    /// <returns>The int</returns>
    public static int GetAchievementIcon(string achievementName)
    {
        return GetInstance().Call(Methods.GetAchievementIcon, achievementName).AsInt32();
    }
    
    /// <summary>
    /// Gets the achievement name using the specified achievement
    /// </summary>
    /// <param name="achievement">The achievement</param>
    /// <returns>The string</returns>
    public static string GetAchievementName(long achievement)
    {
        return GetInstance().Call(Methods.GetAchievementName, achievement).AsString();
    }
    
    /// <summary>
    /// Gets the achievement progress limits int using the specified achievement name
    /// </summary>
    /// <param name="achievementName">The achievement name</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetAchievementProgressLimitsInt(string achievementName)
    {
        return GetInstance().Call(Methods.GetAchievementProgressLimitsInt, achievementName).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the achievement progress limits float using the specified achievement name
    /// </summary>
    /// <param name="achievementName">The achievement name</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetAchievementProgressLimitsFloat(string achievementName)
    {
        return GetInstance().Call(Methods.GetAchievementProgressLimitsFloat, achievementName).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the global stat int using the specified stat name
    /// </summary>
    /// <param name="statName">The stat name</param>
    /// <returns>The ulong</returns>
    public static ulong GetGlobalStatInt(string statName)
    {
        return GetInstance().Call(Methods.GetGlobalStatInt, statName).AsUInt64();
    }
    
    /// <summary>
    /// Gets the global stat float using the specified stat name
    /// </summary>
    /// <param name="statName">The stat name</param>
    /// <returns>The double</returns>
    public static double GetGlobalStatFloat(string statName)
    {
        return GetInstance().Call(Methods.GetGlobalStatFloat, statName).AsDouble();
    }
    
    /// <summary>
    /// Gets the global stat int history using the specified stat name
    /// </summary>
    /// <param name="statName">The stat name</param>
    /// <returns>The ulong</returns>
    public static ulong GetGlobalStatIntHistory(string statName)
    {
        return GetInstance().Call(Methods.GetGlobalStatIntHistory, statName).AsUInt64();
    }
    
    /// <summary>
    /// Gets the global stat float history using the specified stat name
    /// </summary>
    /// <param name="statName">The stat name</param>
    /// <returns>The double</returns>
    public static double GetGlobalStatFloatHistory(string statName)
    {
        return GetInstance().Call(Methods.GetGlobalStatFloatHistory, statName).AsDouble();
    }
    
    /// <summary>
    /// Gets the leaderboard display type using the specified this leaderboard
    /// </summary>
    /// <param name="thisLeaderboard">The this leaderboard</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetLeaderboardDisplayType(long thisLeaderboard = 0)
    {
        return GetInstance().Call(Methods.GetLeaderboardDisplayType, thisLeaderboard).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the leaderboard entry count using the specified this leaderboard
    /// </summary>
    /// <param name="thisLeaderboard">The this leaderboard</param>
    /// <returns>The int</returns>
    public static int GetLeaderboardEntryCount(long thisLeaderboard = 0)
    {
        return GetInstance().Call(Methods.GetLeaderboardEntryCount, thisLeaderboard).AsInt32();
    }
    
    /// <summary>
    /// Gets the leaderboard name using the specified this leaderboard
    /// </summary>
    /// <param name="thisLeaderboard">The this leaderboard</param>
    /// <returns>The string</returns>
    public static string GetLeaderboardName(long thisLeaderboard = 0)
    {
        return GetInstance().Call(Methods.GetLeaderboardName, thisLeaderboard).AsString();
    }
    
    /// <summary>
    /// Gets the leaderboard sort method using the specified this leaderboard
    /// </summary>
    /// <param name="thisLeaderboard">The this leaderboard</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetLeaderboardSortMethod(long thisLeaderboard = 0)
    {
        return GetInstance().Call(Methods.GetLeaderboardSortMethod, thisLeaderboard).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the most achieved achievement info
    /// </summary>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetMostAchievedAchievementInfo()
    {
        return GetInstance().Call(Methods.GetMostAchievedAchievementInfo).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the next most achieved achievement info using the specified iterator
    /// </summary>
    /// <param name="iterator">The iterator</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetNextMostAchievedAchievementInfo(long iterator)
    {
        return GetInstance().Call(Methods.GetNextMostAchievedAchievementInfo, iterator).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the num achievements
    /// </summary>
    /// <returns>The long</returns>
    public static long GetNumAchievements()
    {
        return GetInstance().Call(Methods.GetNumAchievements).AsInt64();
    }
    
    /// <summary>
    /// Gets the number of current players
    /// </summary>
    public static void GetNumberOfCurrentPlayers()
    {
        GetInstance().Call(Methods.GetNumberOfCurrentPlayers);
    }
    
    /// <summary>
    /// Gets the stat float using the specified stat name
    /// </summary>
    /// <param name="statName">The stat name</param>
    /// <returns>The float</returns>
    public static float GetStatFloat(string statName)
    {
        return GetInstance().Call(Methods.GetStatFloat, statName).AsSingle();
    }
    
    /// <summary>
    /// Gets the stat int using the specified stat name
    /// </summary>
    /// <param name="statName">The stat name</param>
    /// <returns>The int</returns>
    public static int GetStatInt(string statName)
    {
        return GetInstance().Call(Methods.GetStatInt, statName).AsInt32();
    }
    
    /// <summary>
    /// Gets the user achievement using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <param name="name">The name</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetUserAchievement(ulong steamId, string name)
    {
        return GetInstance().Call(Methods.GetUserAchievement, steamId, name).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the user achievement and unlock time using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <param name="name">The name</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetUserAchievementAndUnlockTime(ulong steamId, string name)
    {
        return GetInstance().Call(Methods.GetUserAchievementAndUnlockTime, steamId, name).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the user stat float using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <param name="name">The name</param>
    /// <returns>The float</returns>
    public static float GetUserStatFloat(ulong steamId, string name)
    {
        return GetInstance().Call(Methods.GetUserStatFloat, steamId, name).AsSingle();
    }
    
    /// <summary>
    /// Gets the user stat int using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <param name="name">The name</param>
    /// <returns>The int</returns>
    public static int GetUserStatInt(ulong steamId, string name)
    {
        return GetInstance().Call(Methods.GetUserStatInt, steamId, name).AsInt32();
    }
    
    /// <summary>
    /// Describes whether indicate achievement progress
    /// </summary>
    /// <param name="name">The name</param>
    /// <param name="currentProgress">The current progress</param>
    /// <param name="maxProgress">The max progress</param>
    /// <returns>The bool</returns>
    public static bool IndicateAchievementProgress(string name, int currentProgress, long maxProgress)
    {
        return GetInstance().Call(Methods.IndicateAchievementProgress, name, currentProgress, maxProgress).AsBool();
    }
    
    /// <summary>
    /// Describes whether request current stats
    /// </summary>
    /// <returns>The bool</returns>
    public static bool RequestCurrentStats()
    {
        return GetInstance().Call(Methods.RequestCurrentStats).AsBool();
    }
    
    /// <summary>
    /// Requests the global achievement percentages
    /// </summary>
    public static void RequestGlobalAchievementPercentages()
    {
        GetInstance().Call(Methods.RequestGlobalAchievementPercentages);
    }
    
    /// <summary>
    /// Requests the global stats using the specified history days
    /// </summary>
    /// <param name="historyDays">The history days</param>
    public static void RequestGlobalStats(long historyDays)
    {
        GetInstance().Call(Methods.RequestGlobalStats, historyDays);
    }
    
    /// <summary>
    /// Requests the user stats using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    public static void RequestUserStats(ulong steamId)
    {
        GetInstance().Call(Methods.RequestUserStats, steamId);
    }
    
    /// <summary>
    /// Describes whether reset all stats
    /// </summary>
    /// <param name="achievementsToo">The achievements too</param>
    /// <returns>The bool</returns>
    public static bool ResetAllStats(bool achievementsToo)
    {
        return GetInstance().Call(Methods.ResetAllStats, achievementsToo).AsBool();
    }
    
    /// <summary>
    /// Describes whether set achievement
    /// </summary>
    /// <param name="name">The name</param>
    /// <returns>The bool</returns>
    public static bool SetAchievement(string name)
    {
        return GetInstance().Call(Methods.SetAchievement, name).AsBool();
    }
    
    /// <summary>
    /// Sets the leaderboard details max using the specified max
    /// </summary>
    /// <param name="max">The max</param>
    /// <returns>The int</returns>
    public static int SetLeaderboardDetailsMax(long max)
    {
        return GetInstance().Call(Methods.SetLeaderboardDetailsMax, max).AsInt32();
    }
    
    /// <summary>
    /// Describes whether set stat float
    /// </summary>
    /// <param name="name">The name</param>
    /// <param name="value">The value</param>
    /// <returns>The bool</returns>
    public static bool SetStatFloat(string name, double value)
    {
        return GetInstance().Call(Methods.SetStatFloat, name, value).AsBool();
    }
    
    /// <summary>
    /// Describes whether set stat int
    /// </summary>
    /// <param name="name">The name</param>
    /// <param name="value">The value</param>
    /// <returns>The bool</returns>
    public static bool SetStatInt(string name, long value)
    {
        return GetInstance().Call(Methods.SetStatInt, name, value).AsBool();
    }
    
    /// <summary>
    /// Describes whether store stats
    /// </summary>
    /// <returns>The bool</returns>
    public static bool StoreStats()
    {
        return GetInstance().Call(Methods.StoreStats).AsBool();
    }
    
    /// <summary>
    /// Describes whether update avg rate stat
    /// </summary>
    /// <param name="name">The name</param>
    /// <param name="thisSession">The this session</param>
    /// <param name="sessionLength">The session length</param>
    /// <returns>The bool</returns>
    public static bool UpdateAvgRateStat(string name, float thisSession, double sessionLength)
    {
        return GetInstance().Call(Methods.UpdateAvgRateStat, name, thisSession, sessionLength).AsBool();
    }
    
    /// <param name="details">If the parameter is null, then the default value is <c>Array.Empty&lt;int&gt;()</c>.</param>
    public static void UploadLeaderboardScore(int score, bool keepBest = true, int[] details = null, long thisLeaderboard = 0)
    {
        var detailsOrDefVal = details ?? Array.Empty<int>();
        GetInstance().Call(Methods.UploadLeaderboardScore, score, keepBest, detailsOrDefVal, thisLeaderboard);

    }
    
    /// <summary>
    /// Gets the leaderboard entries
    /// </summary>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetLeaderboardEntries()
    {
        return GetInstance().Call(Methods.GetLeaderboardEntries).AsGodotArray();
    }

    /// <summary>
    /// The leaderboard data request enum
    /// </summary>
    public enum LeaderboardDataRequest : long
    {
        /// <summary>
        /// The global leaderboard data request
        /// </summary>
        Global = 0,
        /// <summary>
        /// The global around user leaderboard data request
        /// </summary>
        GlobalAroundUser = 1,
        /// <summary>
        /// The friends leaderboard data request
        /// </summary>
        Friends = 2,
        /// <summary>
        /// The users leaderboard data request
        /// </summary>
        Users = 3
    }

    /// <summary>
    /// The leaderboard display type enum
    /// </summary>
    public enum LeaderboardDisplayType : long
    {
        /// <summary>
        /// The none leaderboard display type
        /// </summary>
        None = 0,
        /// <summary>
        /// The numeric leaderboard display type
        /// </summary>
        Numeric = 1,
        /// <summary>
        /// The time seconds leaderboard display type
        /// </summary>
        TimeSeconds = 2,
        /// <summary>
        /// The time milliseconds leaderboard display type
        /// </summary>
        TimeMilliseconds = 3
    }

    /// <summary>
    /// The leaderboard sort method enum
    /// </summary>
    public enum LeaderboardSortMethod : long
    {
        /// <summary>
        /// The none leaderboard sort method
        /// </summary>
        None = 0,
        /// <summary>
        /// The ascending leaderboard sort method
        /// </summary>
        Ascending = 1,
        /// <summary>
        /// The descending leaderboard sort method
        /// </summary>
        Descending = 2
    }

    /// <summary>
    /// The leaderboard upload score method enum
    /// </summary>
    public enum LeaderboardUploadScoreMethod : long
    {
        /// <summary>
        /// The none leaderboard upload score method
        /// </summary>
        None = 0,
        /// <summary>
        /// The keep best leaderboard upload score method
        /// </summary>
        KeepBest = 1,
        /// <summary>
        /// The force update leaderboard upload score method
        /// </summary>
        ForceUpdate = 2
    }
}