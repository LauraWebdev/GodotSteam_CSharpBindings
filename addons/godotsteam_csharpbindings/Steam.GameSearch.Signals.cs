using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The end game result event handler
    /// </summary>
    public delegate void EndGameResultEventHandler(long result, long gameId);
    private static event EndGameResultEventHandler EndGameResultEvent;
    /// <summary>
    /// The game id
    /// </summary>
    static Action<long, long> _endGameResultAction = (result, gameId) =>
    {
        EndGameResultEvent?.Invoke(result, gameId);
    };
    /// <summary>
    /// The end game result
    /// </summary>
    public static event EndGameResultEventHandler EndGameResult
    {
        add
        {
            if(EndGameResultEvent == null)
            {
                GetInstance().Connect(Signals.EndGameResult, Callable.From(_endGameResultAction));
            }
            EndGameResultEvent += value;
        }
        remove 
        { 
            EndGameResultEvent -= value; 
            if(EndGameResultEvent == null)
            {
                GetInstance().Disconnect(Signals.EndGameResult, Callable.From(_endGameResultAction));
            }
        }
    }
    
    /// <summary>
    /// The request players for game final result event handler
    /// </summary>
    public delegate void RequestPlayersForGameFinalResultEventHandler(long result, long searchId, long gameId);
    private static event RequestPlayersForGameFinalResultEventHandler RequestPlayersForGameFinalResultEvent;
    /// <summary>
    /// The game id
    /// </summary>
    static Action<long, long, long> _requestPlayersForGameFinalResultAction = (result, searchId, gameId) =>
    {
        RequestPlayersForGameFinalResultEvent?.Invoke(result, searchId, gameId);
    };
    /// <summary>
    /// The request players for game final result
    /// </summary>
    public static event RequestPlayersForGameFinalResultEventHandler RequestPlayersForGameFinalResult
    {
        add
        {
            if(RequestPlayersForGameFinalResultEvent == null)
            {
                GetInstance().Connect(Signals.RequestPlayersForGameFinalResult, Callable.From(_requestPlayersForGameFinalResultAction));
            }
            RequestPlayersForGameFinalResultEvent += value;
        }
        remove 
        { 
            RequestPlayersForGameFinalResultEvent -= value; 
            if(RequestPlayersForGameFinalResultEvent == null)
            {
                GetInstance().Disconnect(Signals.RequestPlayersForGameFinalResult, Callable.From(_requestPlayersForGameFinalResultAction));
            }
        }
    }
    
    /// <summary>
    /// The request players for game progress event handler
    /// </summary>
    public delegate void RequestPlayersForGameProgressEventHandler(long result, long searchId);
    private static event RequestPlayersForGameProgressEventHandler RequestPlayersForGameProgressEvent;
    /// <summary>
    /// The search id
    /// </summary>
    static Action<long, long> _requestPlayersForGameProgressAction = (result, searchId) =>
    {
        RequestPlayersForGameProgressEvent?.Invoke(result, searchId);
    };
    /// <summary>
    /// The request players for game progress
    /// </summary>
    public static event RequestPlayersForGameProgressEventHandler RequestPlayersForGameProgress
    {
        add
        {
            if(RequestPlayersForGameProgressEvent == null)
            {
                GetInstance().Connect(Signals.RequestPlayersForGameProgress, Callable.From(_requestPlayersForGameProgressAction));
            }
            RequestPlayersForGameProgressEvent += value;
        }
        remove 
        { 
            RequestPlayersForGameProgressEvent -= value; 
            if(RequestPlayersForGameProgressEvent == null)
            {
                GetInstance().Disconnect(Signals.RequestPlayersForGameProgress, Callable.From(_requestPlayersForGameProgressAction));
            }
        }
    }
    
    /// <summary>
    /// The request players for game result event handler
    /// </summary>
    public delegate void RequestPlayersForGameResultEventHandler(long result, long searchId, Godot.Collections.Dictionary playerData);
    private static event RequestPlayersForGameResultEventHandler RequestPlayersForGameResultEvent;
    /// <summary>
    /// The player data
    /// </summary>
    static Action<long, long, Godot.Collections.Dictionary> _requestPlayersForGameResultAction = (result, searchId, playerData) =>
    {
        RequestPlayersForGameResultEvent?.Invoke(result, searchId, playerData);
    };
    /// <summary>
    /// The request players for game result
    /// </summary>
    public static event RequestPlayersForGameResultEventHandler RequestPlayersForGameResult
    {
        add
        {
            if(RequestPlayersForGameResultEvent == null)
            {
                GetInstance().Connect(Signals.RequestPlayersForGameResult, Callable.From(_requestPlayersForGameResultAction));
            }
            RequestPlayersForGameResultEvent += value;
        }
        remove 
        { 
            RequestPlayersForGameResultEvent -= value; 
            if(RequestPlayersForGameResultEvent == null)
            {
                GetInstance().Disconnect(Signals.RequestPlayersForGameResult, Callable.From(_requestPlayersForGameResultAction));
            }
        }
    }
    
    /// <summary>
    /// The search for game progress event handler
    /// </summary>
    public delegate void SearchForGameProgressEventHandler(long result, long searchId, Godot.Collections.Dictionary searchProgress);
    private static event SearchForGameProgressEventHandler SearchForGameProgressEvent;
    /// <summary>
    /// The search progress
    /// </summary>
    static Action<long, long, Godot.Collections.Dictionary> _searchForGameProgressAction = (result, searchId, searchProgress) =>
    {
        SearchForGameProgressEvent?.Invoke(result, searchId, searchProgress);
    };
    /// <summary>
    /// The search for game progress
    /// </summary>
    public static event SearchForGameProgressEventHandler SearchForGameProgress
    {
        add
        {
            if(SearchForGameProgressEvent == null)
            {
                GetInstance().Connect(Signals.SearchForGameProgress, Callable.From(_searchForGameProgressAction));
            }
            SearchForGameProgressEvent += value;
        }
        remove 
        { 
            SearchForGameProgressEvent -= value; 
            if(SearchForGameProgressEvent == null)
            {
                GetInstance().Disconnect(Signals.SearchForGameProgress, Callable.From(_searchForGameProgressAction));
            }
        }
    }
    
    /// <summary>
    /// The search for game result event handler
    /// </summary>
    public delegate void SearchForGameResultEventHandler(long result, long searchId, Godot.Collections.Dictionary searchResult);
    private static event SearchForGameResultEventHandler SearchForGameResultEvent;
    /// <summary>
    /// The search result
    /// </summary>
    static Action<long, long, Godot.Collections.Dictionary> _searchForGameResultAction = (result, searchId, searchResult) =>
    {
        SearchForGameResultEvent?.Invoke(result, searchId, searchResult);
    };
    /// <summary>
    /// The search for game result
    /// </summary>
    public static event SearchForGameResultEventHandler SearchForGameResult
    {
        add
        {
            if(SearchForGameResultEvent == null)
            {
                GetInstance().Connect(Signals.SearchForGameResult, Callable.From(_searchForGameResultAction));
            }
            SearchForGameResultEvent += value;
        }
        remove 
        { 
            SearchForGameResultEvent -= value; 
            if(SearchForGameResultEvent == null)
            {
                GetInstance().Disconnect(Signals.SearchForGameResult, Callable.From(_searchForGameResultAction));
            }
        }
    }
    
    /// <summary>
    /// The submit player result signal event handler
    /// </summary>
    public delegate void SubmitPlayerResultSignalEventHandler(long result, long gameId, long playerId);
    private static event SubmitPlayerResultSignalEventHandler SubmitPlayerResultSignalEvent;
    /// <summary>
    /// The player id
    /// </summary>
    static Action<long, long, long> _submitPlayerResultSignalAction = (result, gameId, playerId) =>
    {
        SubmitPlayerResultSignalEvent?.Invoke(result, gameId, playerId);
    };
    /// <summary>
    /// The submit player result signal
    /// </summary>
    public static event SubmitPlayerResultSignalEventHandler SubmitPlayerResultSignal
    {
        add
        {
            if(SubmitPlayerResultSignalEvent == null)
            {
                GetInstance().Connect(Signals.SubmitPlayerResultSignal, Callable.From(_submitPlayerResultSignalAction));
            }
            SubmitPlayerResultSignalEvent += value;
        }
        remove 
        { 
            SubmitPlayerResultSignalEvent -= value; 
            if(SubmitPlayerResultSignalEvent == null)
            {
                GetInstance().Disconnect(Signals.SubmitPlayerResultSignal, Callable.From(_submitPlayerResultSignalAction));
            }
        }
    }
}