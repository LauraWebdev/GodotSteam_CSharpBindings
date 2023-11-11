using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void EndGameResultEventHandler(long result, long gameId);
    private static event EndGameResultEventHandler EndGameResultEvent;
    static Action<long, long> _endGameResultAction = (result, gameId) =>
    {
        EndGameResultEvent?.Invoke(result, gameId);
    };
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
    
    public delegate void RequestPlayersForGameFinalResultEventHandler(long result, long searchId, long gameId);
    private static event RequestPlayersForGameFinalResultEventHandler RequestPlayersForGameFinalResultEvent;
    static Action<long, long, long> _requestPlayersForGameFinalResultAction = (result, searchId, gameId) =>
    {
        RequestPlayersForGameFinalResultEvent?.Invoke(result, searchId, gameId);
    };
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
    
    public delegate void RequestPlayersForGameProgressEventHandler(long result, long searchId);
    private static event RequestPlayersForGameProgressEventHandler RequestPlayersForGameProgressEvent;
    static Action<long, long> _requestPlayersForGameProgressAction = (result, searchId) =>
    {
        RequestPlayersForGameProgressEvent?.Invoke(result, searchId);
    };
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
    
    public delegate void RequestPlayersForGameResultEventHandler(long result, long searchId, Godot.Collections.Dictionary playerData);
    private static event RequestPlayersForGameResultEventHandler RequestPlayersForGameResultEvent;
    static Action<long, long, Godot.Collections.Dictionary> _requestPlayersForGameResultAction = (result, searchId, playerData) =>
    {
        RequestPlayersForGameResultEvent?.Invoke(result, searchId, playerData);
    };
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
    
    public delegate void SearchForGameProgressEventHandler(long result, long searchId, Godot.Collections.Dictionary searchProgress);
    private static event SearchForGameProgressEventHandler SearchForGameProgressEvent;
    static Action<long, long, Godot.Collections.Dictionary> _searchForGameProgressAction = (result, searchId, searchProgress) =>
    {
        SearchForGameProgressEvent?.Invoke(result, searchId, searchProgress);
    };
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
    
    public delegate void SearchForGameResultEventHandler(long result, long searchId, Godot.Collections.Dictionary searchResult);
    private static event SearchForGameResultEventHandler SearchForGameResultEvent;
    static Action<long, long, Godot.Collections.Dictionary> _searchForGameResultAction = (result, searchId, searchResult) =>
    {
        SearchForGameResultEvent?.Invoke(result, searchId, searchResult);
    };
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
    
    public delegate void SubmitPlayerResultSignalEventHandler(long result, long gameId, long playerId);
    private static event SubmitPlayerResultSignalEventHandler SubmitPlayerResultSignalEvent;
    static Action<long, long, long> _submitPlayerResultSignalAction = (result, gameId, playerId) =>
    {
        SubmitPlayerResultSignalEvent?.Invoke(result, gameId, playerId);
    };
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