using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The favorites list accounts updated event handler
    /// </summary>
    public delegate void FavoritesListAccountsUpdatedEventHandler(long result);
    private static event FavoritesListAccountsUpdatedEventHandler FavoritesListAccountsUpdatedEvent;
    /// <summary>
    /// The result
    /// </summary>
    static Action<long> _favoritesListAccountsUpdatedAction = (result) =>
    {
        FavoritesListAccountsUpdatedEvent?.Invoke(result);
    };
    /// <summary>
    /// The favorites list accounts updated
    /// </summary>
    public static event FavoritesListAccountsUpdatedEventHandler FavoritesListAccountsUpdated
    {
        add
        {
            if(FavoritesListAccountsUpdatedEvent == null)
            {
                GetInstance().Connect(Signals.FavoritesListAccountsUpdated, Callable.From(_favoritesListAccountsUpdatedAction));
            }
            FavoritesListAccountsUpdatedEvent += value;
        }
        remove
        {
            FavoritesListAccountsUpdatedEvent -= value;
            if(FavoritesListAccountsUpdatedEvent == null)
            {
                GetInstance().Disconnect(Signals.FavoritesListAccountsUpdated, Callable.From(_favoritesListAccountsUpdatedAction));
            }
        }
    }
    
    /// <summary>
    /// The favorites list changed event handler
    /// </summary>
    public delegate void FavoritesListChangedEventHandler(Godot.Collections.Dictionary favorite);
    private static event FavoritesListChangedEventHandler FavoritesListChangedEvent;
    /// <summary>
    /// The favorite
    /// </summary>
    static Action<Godot.Collections.Dictionary> _favoritesListChangedAction = (favorite) =>
    {
        FavoritesListChangedEvent?.Invoke(favorite);
    };
    /// <summary>
    /// The favorites list changed
    /// </summary>
    public static event FavoritesListChangedEventHandler FavoritesListChanged
    {
        add
        {
            if(FavoritesListChangedEvent == null)
            {
                GetInstance().Connect(Signals.FavoritesListChanged, Callable.From(_favoritesListChangedAction));
            }
            FavoritesListChangedEvent += value;
        }
        remove
        {
            FavoritesListChangedEvent -= value;
            if(FavoritesListChangedEvent == null)
            {
                GetInstance().Disconnect(Signals.FavoritesListChanged, Callable.From(_favoritesListChangedAction));
            }
        }
    }
    
    /// <summary>
    /// The lobby message event handler
    /// </summary>
    public delegate void LobbyMessageEventHandler(long lobbyId, long user, string message, long chatType);
    private static event LobbyMessageEventHandler LobbyMessageEvent;
    /// <summary>
    /// The chat type
    /// </summary>
    static Action<long, long, string, long> _lobbyMessageAction = (lobbyId, user, message, chatType) =>
    {
        LobbyMessageEvent?.Invoke(lobbyId, user, message, chatType);
    };
    /// <summary>
    /// The lobby message
    /// </summary>
    public static event LobbyMessageEventHandler LobbyMessage
    {
        add
        {
            if(LobbyMessageEvent == null)
            {
                GetInstance().Connect(Signals.LobbyMessage, Callable.From(_lobbyMessageAction));
            }
            LobbyMessageEvent += value;
        }
        remove
        {
            LobbyMessageEvent -= value;
            if(LobbyMessageEvent == null)
            {
                GetInstance().Disconnect(Signals.LobbyMessage, Callable.From(_lobbyMessageAction));
            }
        }
    }
    
    /// <summary>
    /// The lobby chat update event handler
    /// </summary>
    public delegate void LobbyChatUpdateEventHandler(long lobbyId, long changedId, long makingChangeId, long chatState);
    private static event LobbyChatUpdateEventHandler LobbyChatUpdateEvent;
    /// <summary>
    /// The chat state
    /// </summary>
    static Action<long, long, long, long> _lobbyChatUpdateAction = (lobbyId, changedId, makingChangeId, chatState) =>
    {
        LobbyChatUpdateEvent?.Invoke(lobbyId, changedId, makingChangeId, chatState);
    };
    /// <summary>
    /// The lobby chat update
    /// </summary>
    public static event LobbyChatUpdateEventHandler LobbyChatUpdate
    {
        add
        {
            if(LobbyChatUpdateEvent == null)
            {
                GetInstance().Connect(Signals.LobbyChatUpdate, Callable.From(_lobbyChatUpdateAction));
            }
            LobbyChatUpdateEvent += value;
        }
        remove 
        { 
            LobbyChatUpdateEvent -= value; 
            if(LobbyChatUpdateEvent == null)
            {
                GetInstance().Disconnect(Signals.LobbyChatUpdate, Callable.From(_lobbyChatUpdateAction));
            }
        }
    }
    
    /// <summary>
    /// The lobby created event handler
    /// </summary>
    public delegate void LobbyCreatedEventHandler(long connect, long lobbyId);
    private static event LobbyCreatedEventHandler LobbyCreatedEvent;
    /// <summary>
    /// The lobby id
    /// </summary>
    static Action<long, long> _lobbyCreatedAction = (connect, lobbyId) =>
    {
        LobbyCreatedEvent?.Invoke(connect, lobbyId);
    };
    /// <summary>
    /// The lobby created
    /// </summary>
    public static event LobbyCreatedEventHandler LobbyCreated
    {
        add
        {
            if(LobbyCreatedEvent == null)
            {
                GetInstance().Connect(Signals.LobbyCreated, Callable.From(_lobbyCreatedAction));
            }
            LobbyCreatedEvent += value;
        }
        remove 
        { 
            LobbyCreatedEvent -= value; 
            if(LobbyCreatedEvent == null)
            {
                GetInstance().Disconnect(Signals.LobbyCreated, Callable.From(_lobbyCreatedAction));
            }
        }
    }
    
    public static event Action LobbyDataUpdateEvent;
    /// <summary>
    /// The invoke
    /// </summary>
    static Action _lobbyDataUpdateAction = () =>
    {
        LobbyDataUpdateEvent?.Invoke();
    };
    /// <summary>
    /// The lobby data update
    /// </summary>
    public static event Action LobbyDataUpdate
    {
        add
        {
            if(LobbyDataUpdateEvent == null)
            {
                GetInstance().Connect(Signals.LobbyDataUpdate, Callable.From(_lobbyDataUpdateAction));
            }
            LobbyDataUpdateEvent += value;
        }
        remove
        {
            LobbyDataUpdateEvent -= value;
            if(LobbyDataUpdateEvent == null)
            {
                GetInstance().Disconnect(Signals.LobbyDataUpdate, Callable.From(_lobbyDataUpdateAction));
            }
        }
    }
    
    /// <summary>
    /// The lobby joined event handler
    /// </summary>
    public delegate void LobbyJoinedEventHandler(long lobby, long permissions, bool locked, long response);
    private static event LobbyJoinedEventHandler LobbyJoinedEvent;
    /// <summary>
    /// The response
    /// </summary>
    static Action<long, long, bool, long> _lobbyJoinedAction = (lobby, permissions, locked, response) =>
    {
        LobbyJoinedEvent?.Invoke(lobby, permissions, locked, response);
    };
    /// <summary>
    /// The lobby joined
    /// </summary>
    public static event LobbyJoinedEventHandler LobbyJoined
    {
        add
        {
            if(LobbyJoinedEvent == null)
            {
                GetInstance().Connect(Signals.LobbyJoined, Callable.From(_lobbyJoinedAction));
            }
            LobbyJoinedEvent += value;
        }
        remove 
        { 
            LobbyJoinedEvent -= value;
            if(LobbyJoinedEvent == null)
            {
                GetInstance().Disconnect(Signals.LobbyJoined, Callable.From(_lobbyJoinedAction));
            }
        }
    }
    
    /// <summary>
    /// The lobby game created event handler
    /// </summary>
    public delegate void LobbyGameCreatedEventHandler(long lobbyId, long serverId, string serverIP, long port);
    private static event LobbyGameCreatedEventHandler LobbyGameCreatedEvent;
    /// <summary>
    /// The port
    /// </summary>
    static Action<long, long, string, long> _lobbyGameCreatedAction = (lobbyId, serverId, serverIP, port) =>
    {
        LobbyGameCreatedEvent?.Invoke(lobbyId, serverId, serverIP, port);
    };
    /// <summary>
    /// The lobby game created
    /// </summary>
    public static event LobbyGameCreatedEventHandler LobbyGameCreated
    {
        add
        {
            if(LobbyGameCreatedEvent == null)
            {
                GetInstance().Connect(Signals.LobbyGameCreated, Callable.From(_lobbyGameCreatedAction));
            }
            LobbyGameCreatedEvent += value;
        }
        remove 
        { 
            LobbyGameCreatedEvent -= value; 
            if(LobbyGameCreatedEvent == null)
            {
                GetInstance().Disconnect(Signals.LobbyGameCreated, Callable.From(_lobbyGameCreatedAction));
            }
        }
    }
    
    /// <summary>
    /// The lobby invite event handler
    /// </summary>
    public delegate void LobbyInviteEventHandler(long inviter, long lobby, long game);
    private static event LobbyInviteEventHandler LobbyInviteEvent;
    /// <summary>
    /// The game
    /// </summary>
    static Action<long, long, long> _lobbyInviteAction = (inviter, lobby, game) =>
    {
        LobbyInviteEvent?.Invoke(inviter, lobby, game);
    };
    /// <summary>
    /// The lobby invite
    /// </summary>
    public static event LobbyInviteEventHandler LobbyInvite
    {
        add
        {
            if(LobbyInviteEvent == null)
            {
                GetInstance().Connect(Signals.LobbyInvite, Callable.From(_lobbyInviteAction));
            }
            LobbyInviteEvent += value;
        }
        remove 
        { 
            LobbyInviteEvent -= value; 
            if(LobbyInviteEvent == null)
            {
                GetInstance().Disconnect(Signals.LobbyInvite, Callable.From(_lobbyInviteAction));
            }
        }
    }
    
    /// <summary>
    /// The lobby match list event handler
    /// </summary>
    public delegate void LobbyMatchListEventHandler(Godot.Collections.Array lobbies);
    private static event LobbyMatchListEventHandler LobbyMatchListEvent;
    /// <summary>
    /// The lobbies
    /// </summary>
    static Action<Godot.Collections.Array> _lobbyMatchListAction = (lobbies) =>
    {
        LobbyMatchListEvent?.Invoke(lobbies);
    };
    /// <summary>
    /// The lobby match list
    /// </summary>
    public static event LobbyMatchListEventHandler LobbyMatchList
    {
        add 
        { 
            if(LobbyMatchListEvent == null)
            {
                GetInstance().Connect(Signals.LobbyMatchList, Callable.From(_lobbyMatchListAction));
            }
            LobbyMatchListEvent += value;
        }
        remove 
        { 
            LobbyMatchListEvent -= value; 
            if(LobbyMatchListEvent == null)
            {
                GetInstance().Disconnect(Signals.LobbyMatchList, Callable.From(_lobbyMatchListAction));
            }
        }
    }
    
    /// <summary>
    /// The lobby kicked event handler
    /// </summary>
    public delegate void LobbyKickedEventHandler(long lobbyId, long adminId, long dueToDisconnect);
    private static event LobbyKickedEventHandler LobbyKickedEvent;
    /// <summary>
    /// The due to disconnect
    /// </summary>
    static Action<long, long, long> _lobbyKickedAction = (lobbyId, adminId, dueToDisconnect) =>
    {
        LobbyKickedEvent?.Invoke(lobbyId, adminId, dueToDisconnect);
    };
    /// <summary>
    /// The lobby kicked
    /// </summary>
    public static event LobbyKickedEventHandler LobbyKicked
    {
        add
        {
            if(LobbyKickedEvent == null)
            {
                GetInstance().Connect(Signals.LobbyKicked, Callable.From(_lobbyKickedAction));
            }
            LobbyKickedEvent += value;
        }
        remove 
        { 
            LobbyKickedEvent -= value; 
            if(LobbyKickedEvent == null)
            {
                GetInstance().Disconnect(Signals.LobbyKicked, Callable.From(_lobbyKickedAction));
            }
        }
    }
}