using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void EndGameResultEventHandler(ErrorResult result, ulong gameId);
    private static event EndGameResultEventHandler EndGameResultEvent;
    static Action<int, ulong> _endGameResultAction = (result, gameId) =>
    {
        EndGameResultEvent?.Invoke((ErrorResult)result, gameId);
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
    
    public delegate void RequestPlayersForGameFinalResultEventHandler(ErrorResult result, ulong searchId, ulong gameId);
    private static event RequestPlayersForGameFinalResultEventHandler RequestPlayersForGameFinalResultEvent;
    static Action<int, ulong, ulong> _requestPlayersForGameFinalResultAction = (result, searchId, gameId) =>
    {
        RequestPlayersForGameFinalResultEvent?.Invoke((ErrorResult)result, searchId, gameId);
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
    
    public delegate void RequestPlayersForGameProgressEventHandler(ErrorResult result, ulong searchId);
    private static event RequestPlayersForGameProgressEventHandler RequestPlayersForGameProgressEvent;
    static Action<int, ulong> _requestPlayersForGameProgressAction = (result, searchId) =>
    {
        RequestPlayersForGameProgressEvent?.Invoke((ErrorResult)result, searchId);
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
    
    public delegate void RequestPlayersForGameResultEventHandler(ErrorResult result, ulong searchId, PlayerData playerData);
    private static event RequestPlayersForGameResultEventHandler RequestPlayersForGameResultEvent;
    static Action<int, ulong, Godot.Collections.Dictionary> _requestPlayersForGameResultAction = (result, searchId, playerData) =>
    {
        RequestPlayersForGameResultEvent?.Invoke(
            (ErrorResult)result,
            searchId,
            new PlayerData
            {
                PlayerId = playerData["player_id"].As<ulong>(),
                LobbyId = playerData["lobby_id"].As<ulong>(),
                PlayerAcceptState = playerData["player_accept_state"].As<int>(),
                PlayerIndex = playerData["player_index"].As<int>(),
                TotalPlayers = playerData["total_players"].As<int>(),
                TotalPlayersAcceptedGame = playerData["total_players_accepted_game"].As<int>(),
                SuggestedTeamIndex = playerData["suggested_team_index"].As<int>(),
                UniqueGameId = playerData["unique_game_id"].As<ulong>(),
            }
        );
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
    
    public delegate void SearchForGameProgressEventHandler(ErrorResult result, long searchId, SearchProgress searchProgress);
    private static event SearchForGameProgressEventHandler SearchForGameProgressEvent;
    static Action<int, long, Godot.Collections.Dictionary> _searchForGameProgressAction = (result, searchId, searchProgress) =>
    {
        SearchForGameProgressEvent?.Invoke(
            (ErrorResult)result,
            searchId,
            new SearchProgress
            {
                LobbyId = searchProgress["lobby_id"].As<ulong>(),
                EndedSearchId = searchProgress["lobby_id"].As<ulong>(),
                SecondsRemainingEstimate = searchProgress["seconds_remaining_estimate"].As<int>(),
                PlayersSearching = searchProgress["players_searching"].As<int>(),
            }
        );
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
    
    public delegate void SearchForGameResultEventHandler(ErrorResult result, ulong searchId, SearchResult searchResult);
    private static event SearchForGameResultEventHandler SearchForGameResultEvent;
    static Action<int, ulong, Godot.Collections.Dictionary> _searchForGameResultAction = (result, searchId, searchResult) =>
    {
        SearchForGameResultEvent?.Invoke(
            (ErrorResult)result,
            searchId,
            new SearchResult
            {
                CountPlayersIngame = searchResult["count_players_ingame"].As<int>(),
                CountAcceptedGame = searchResult["count_accepted_game"].As<int>(),
                HostId = searchResult["host_id"].As<ulong>(),
                FinalCallback = searchResult["final_callback"].As<bool>()
            }
        );
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
    
    public delegate void SubmitPlayerResultSignalEventHandler(ErrorResult result, ulong gameId, ulong playerId);
    private static event SubmitPlayerResultSignalEventHandler SubmitPlayerResultSignalEvent;
    static Action<int, ulong, ulong> _submitPlayerResultSignalAction = (result, gameId, playerId) =>
    {
        SubmitPlayerResultSignalEvent?.Invoke((ErrorResult)result, gameId, playerId);
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