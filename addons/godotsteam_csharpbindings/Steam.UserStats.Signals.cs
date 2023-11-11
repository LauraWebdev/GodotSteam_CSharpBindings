using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The global achievement percentages ready event handler
    /// </summary>
    public delegate void GlobalAchievementPercentagesReadyEventHandler(long gameId, long result);
    private static event GlobalAchievementPercentagesReadyEventHandler GlobalAchievementPercentagesReadyEvent;
    /// <summary>
    /// The result
    /// </summary>
    static Action<long, long> _globalAchievementPercentagesReadyAction = (gameId, result) =>
    {
        GlobalAchievementPercentagesReadyEvent?.Invoke(gameId, result);
    };
    /// <summary>
    /// The global achievement percentages ready
    /// </summary>
    public static event GlobalAchievementPercentagesReadyEventHandler GlobalAchievementPercentagesReady
    {
        add
        {
            if (GlobalAchievementPercentagesReadyEvent == null)
            {
                GetInstance().Connect(Signals.GlobalAchievementPercentagesReady, Callable.From(_globalAchievementPercentagesReadyAction));
            }
            GlobalAchievementPercentagesReadyEvent += value;
        }
        remove
        {
            GlobalAchievementPercentagesReadyEvent -= value;
            if (GlobalAchievementPercentagesReadyEvent == null)
            {
                GetInstance().Disconnect(Signals.GlobalAchievementPercentagesReady, Callable.From(_globalAchievementPercentagesReadyAction));
            }
        }
    }
    
    /// <summary>
    /// The global stats received event handler
    /// </summary>
    public delegate void GlobalStatsReceivedEventHandler(long gameId, string result);
    private static event GlobalStatsReceivedEventHandler GlobalStatsReceivedEvent;
    /// <summary>
    /// The result
    /// </summary>
    static Action<long, string> _globalStatsReceivedAction = (gameId, result) =>
    {
        GlobalStatsReceivedEvent?.Invoke(gameId, result);
    };
    /// <summary>
    /// The global stats received
    /// </summary>
    public static event GlobalStatsReceivedEventHandler GlobalStatsReceived
    {
        add
        {
            if (GlobalStatsReceivedEvent == null)
            {
                GetInstance().Connect(Signals.GlobalStatsReceived, Callable.From(_globalStatsReceivedAction));
            }
            GlobalStatsReceivedEvent += value;
        }
        remove
        {
            GlobalStatsReceivedEvent -= value;
            if (GlobalStatsReceivedEvent == null)
            {
                GetInstance().Disconnect(Signals.GlobalStatsReceived, Callable.From(_globalStatsReceivedAction));
            }
        }
    }
    
    /// <summary>
    /// The leaderboard find result event handler
    /// </summary>
    public delegate void LeaderboardFindResultEventHandler(long leaderboardHandle, long found);
    private static event LeaderboardFindResultEventHandler LeaderboardFindResultEvent;
    /// <summary>
    /// The found
    /// </summary>
    static Action<long, long> _leaderboardFindResultAction = (leaderboardHandle, found) =>
    {
        LeaderboardFindResultEvent?.Invoke(leaderboardHandle, found);
    };
    /// <summary>
    /// The leaderboard find result
    /// </summary>
    public static event LeaderboardFindResultEventHandler LeaderboardFindResult
    {
        add
        {
            if (LeaderboardFindResultEvent == null)
            {
                GetInstance().Connect(Signals.LeaderboardFindResult, Callable.From(_leaderboardFindResultAction));
            }
            LeaderboardFindResultEvent += value;
        }
        remove
        {
            LeaderboardFindResultEvent -= value;
            if (LeaderboardFindResultEvent == null)
            {
                GetInstance().Disconnect(Signals.LeaderboardFindResult, Callable.From(_leaderboardFindResultAction));
            }
        }
    }
    
    /// <summary>
    /// The leaderboard scores downloaded event handler
    /// </summary>
    public delegate void LeaderboardScoresDownloadedEventHandler(string message, Godot.Collections.Array leaderboardEntries);
    private static event LeaderboardScoresDownloadedEventHandler LeaderboardScoresDownloadedEvent;
    /// <summary>
    /// The leaderboard entries
    /// </summary>
    static Action<string, Godot.Collections.Array> _leaderboardScoresDownloadedAction = (message, leaderboardEntries) =>
    {
        LeaderboardScoresDownloadedEvent?.Invoke(message, leaderboardEntries);
    };
    /// <summary>
    /// The leaderboard scores downloaded
    /// </summary>
    public static event LeaderboardScoresDownloadedEventHandler LeaderboardScoresDownloaded
    {
        add
        {
            if (LeaderboardScoresDownloadedEvent == null)
            {
                GetInstance().Connect(Signals.LeaderboardScoresDownloaded, Callable.From(_leaderboardScoresDownloadedAction));
            }
            LeaderboardScoresDownloadedEvent += value;
        }
        remove
        {
            LeaderboardScoresDownloadedEvent -= value;
            if (LeaderboardScoresDownloadedEvent == null)
            {
                GetInstance().Disconnect(Signals.LeaderboardScoresDownloaded, Callable.From(_leaderboardScoresDownloadedAction));
            }
        }
    }
    
    /// <summary>
    /// The leaderboard score uploaded event handler
    /// </summary>
    public delegate void LeaderboardScoreUploadedEventHandler(bool success, long thisHandle, Godot.Collections.Dictionary thisScore);
    private static event LeaderboardScoreUploadedEventHandler LeaderboardScoreUploadedEvent;
    /// <summary>
    /// The this score
    /// </summary>
    static Action<bool, long, Godot.Collections.Dictionary> _leaderboardScoreUploadedAction = (success, thisHandle, thisScore) =>
    {
        LeaderboardScoreUploadedEvent?.Invoke(success, thisHandle, thisScore);
    };
    /// <summary>
    /// The leaderboard score uploaded
    /// </summary>
    public static event LeaderboardScoreUploadedEventHandler LeaderboardScoreUploaded
    {
        add
        {
            if (LeaderboardScoreUploadedEvent == null)
            {
                GetInstance().Connect(Signals.LeaderboardScoreUploaded, Callable.From(_leaderboardScoreUploadedAction));
            }
            LeaderboardScoreUploadedEvent += value;
        }
        remove
        {
            LeaderboardScoreUploadedEvent -= value;
            if (LeaderboardScoreUploadedEvent == null)
            {
                GetInstance().Disconnect(Signals.LeaderboardScoreUploaded, Callable.From(_leaderboardScoreUploadedAction));
            }
        }
    }
    
    /// <summary>
    /// The leaderboard ugc set event handler
    /// </summary>
    public delegate void LeaderboardUgcSetEventHandler(long leaderboardHandle, string result);
    private static event LeaderboardUgcSetEventHandler LeaderboardUgcSetEvent;
    /// <summary>
    /// The result
    /// </summary>
    static Action<long, string> _leaderboardUgcSetAction = (leaderboardHandle, result) =>
    {
        LeaderboardUgcSetEvent?.Invoke(leaderboardHandle, result);
    };
    /// <summary>
    /// The leaderboard ugc set
    /// </summary>
    public static event LeaderboardUgcSetEventHandler LeaderboardUgcSet
    {
        add
        {
            if (LeaderboardUgcSetEvent == null)
            {
                GetInstance().Connect(Signals.LeaderboardUgcSet, Callable.From(_leaderboardUgcSetAction));
            }
            LeaderboardUgcSetEvent += value;
        }
        remove
        {
            LeaderboardUgcSetEvent -= value;
            if (LeaderboardUgcSetEvent == null)
            {
                GetInstance().Disconnect(Signals.LeaderboardUgcSet, Callable.From(_leaderboardUgcSetAction));
            }
        }
    }
    
    /// <summary>
    /// The number of current players event handler
    /// </summary>
    public delegate void NumberOfCurrentPlayersEventHandler(long success, long players);
    private static event NumberOfCurrentPlayersEventHandler NumberOfCurrentPlayersEvent;
    /// <summary>
    /// The players
    /// </summary>
    static Action<long, long> _numberOfCurrentPlayersAction = (success, players) =>
    {
        NumberOfCurrentPlayersEvent?.Invoke(success, players);
    };
    /// <summary>
    /// The number of current players
    /// </summary>
    public static event NumberOfCurrentPlayersEventHandler NumberOfCurrentPlayers
    {
        add
        {
            if (NumberOfCurrentPlayersEvent == null)
            {
                GetInstance().Connect(Signals.NumberOfCurrentPlayers, Callable.From(_numberOfCurrentPlayersAction));
            }
            NumberOfCurrentPlayersEvent += value;
        }
        remove
        {
            NumberOfCurrentPlayersEvent -= value;
            if (NumberOfCurrentPlayersEvent == null)
            {
                GetInstance().Disconnect(Signals.NumberOfCurrentPlayers, Callable.From(_numberOfCurrentPlayersAction));
            }
        }
    }
    
    /// <summary>
    /// The user achievement stored event handler
    /// </summary>
    public delegate void UserAchievementStoredEventHandler(long gameId, bool groupAchieve, string achievementName, long currentProgress, long maxProgress);
    private static event UserAchievementStoredEventHandler UserAchievementStoredEvent;
    /// <summary>
    /// The max progress
    /// </summary>
    static Action<long, bool, string, long, long> _userAchievementStoredAction = (gameId, groupAchieve, achievementName, currentProgress, maxProgress) =>
    {
        UserAchievementStoredEvent?.Invoke(gameId, groupAchieve, achievementName, currentProgress, maxProgress);
    };
    /// <summary>
    /// The user achievement stored
    /// </summary>
    public static event UserAchievementStoredEventHandler UserAchievementStored
    {
        add
        {
            if (UserAchievementStoredEvent == null)
            {
                GetInstance().Connect(Signals.UserAchievementStored, Callable.From(_userAchievementStoredAction));
            }
            UserAchievementStoredEvent += value;
        }
        remove
        {
            UserAchievementStoredEvent -= value;
            if (UserAchievementStoredEvent == null)
            {
                GetInstance().Disconnect(Signals.UserAchievementStored, Callable.From(_userAchievementStoredAction));
            }
        }
    }
    
    /// <summary>
    /// The current stats received event handler
    /// </summary>
    public delegate void CurrentStatsReceivedEventHandler(long gameId, long result, long userId);
    private static event CurrentStatsReceivedEventHandler CurrentStatsReceivedEvent;
    /// <summary>
    /// The user id
    /// </summary>
    static Action<long, long, long> _currentStatsReceivedAction = (gameId, result, userId) =>
    {
        CurrentStatsReceivedEvent?.Invoke(gameId, result, userId);
    };
    /// <summary>
    /// The current stats received
    /// </summary>
    public static event CurrentStatsReceivedEventHandler CurrentStatsReceived
    {
        add
        {
            if (CurrentStatsReceivedEvent == null)
            {
                GetInstance().Connect(Signals.CurrentStatsReceived, Callable.From(_currentStatsReceivedAction));
            }
            CurrentStatsReceivedEvent += value;
        }
        remove
        {
            CurrentStatsReceivedEvent -= value;
            if (CurrentStatsReceivedEvent == null)
            {
                GetInstance().Disconnect(Signals.CurrentStatsReceived, Callable.From(_currentStatsReceivedAction));
            }
        }
    }
    
    /// <summary>
    /// The user stats received event handler
    /// </summary>
    public delegate void UserStatsReceivedEventHandler(long gameId, long result, long userId);
    private static event UserStatsReceivedEventHandler UserStatsReceivedEvent;
    /// <summary>
    /// The user id
    /// </summary>
    static Action<long, long, long> _userStatsReceivedAction = (gameId, result, userId) =>
    {
        UserStatsReceivedEvent?.Invoke(gameId, result, userId);
    };
    /// <summary>
    /// The user stats received
    /// </summary>
    public static event UserStatsReceivedEventHandler UserStatsReceived
    {
        add
        {
            if (UserStatsReceivedEvent == null)
            {
                GetInstance().Connect(Signals.UserStatsReceived, Callable.From(_userStatsReceivedAction));
            }
            UserStatsReceivedEvent += value;
        }
        remove
        {
            UserStatsReceivedEvent -= value;
            if (UserStatsReceivedEvent == null)
            {
                GetInstance().Disconnect(Signals.UserStatsReceived, Callable.From(_userStatsReceivedAction));
            }
        }
    }
    
    /// <summary>
    /// The user stats stored event handler
    /// </summary>
    public delegate void UserStatsStoredEventHandler(long gameId, long result);
    private static event UserStatsStoredEventHandler UserStatsStoredEvent;
    /// <summary>
    /// The result
    /// </summary>
    static Action<long, long> _userStatsStoredAction = (gameId, result) =>
    {
        UserStatsStoredEvent?.Invoke(gameId, result);
    };
    /// <summary>
    /// The user stats stored
    /// </summary>
    public static event UserStatsStoredEventHandler UserStatsStored
    {
        add
        {
            if (UserStatsStoredEvent == null)
            {
                GetInstance().Connect(Signals.UserStatsStored, Callable.From(_userStatsStoredAction));
            }
            UserStatsStoredEvent += value;
        }
        remove
        {
            UserStatsStoredEvent -= value;
            if (UserStatsStoredEvent == null)
            {
                GetInstance().Disconnect(Signals.UserStatsStored, Callable.From(_userStatsStoredAction));
            }
        }
    }
    
    /// <summary>
    /// The user stats unloaded event handler
    /// </summary>
    public delegate void UserStatsUnloadedEventHandler(long userId);
    private static event UserStatsUnloadedEventHandler UserStatsUnloadedEvent;
    /// <summary>
    /// The user id
    /// </summary>
    static Action<long> _userStatsUnloadedAction = (userId) =>
    {
        UserStatsUnloadedEvent?.Invoke(userId);
    };
    /// <summary>
    /// The user stats unloaded
    /// </summary>
    public static event UserStatsUnloadedEventHandler UserStatsUnloaded
    {
        add
        {
            if (UserStatsUnloadedEvent == null)
            {
                GetInstance().Connect(Signals.UserStatsUnloaded, Callable.From(_userStatsUnloadedAction));
            }
            UserStatsUnloadedEvent += value;
        }
        remove
        {
            UserStatsUnloadedEvent -= value;
            if (UserStatsUnloadedEvent == null)
            {
                GetInstance().Disconnect(Signals.UserStatsUnloaded, Callable.From(_userStatsUnloadedAction));
            }
        }
    }
}