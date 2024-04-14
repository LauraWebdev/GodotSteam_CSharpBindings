using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void FavoritesListAccountsUpdatedEventHandler(long result);
    private static event FavoritesListAccountsUpdatedEventHandler FavoritesListAccountsUpdatedEvent;
    static Action<long> _favoritesListAccountsUpdatedAction = (result) =>
    {
        FavoritesListAccountsUpdatedEvent?.Invoke(result);
    };
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
    
    public delegate void FavoritesListChangedEventHandler(Godot.Collections.Dictionary favorite);
    private static event FavoritesListChangedEventHandler FavoritesListChangedEvent;
    static Action<Godot.Collections.Dictionary> _favoritesListChangedAction = (favorite) =>
    {
        FavoritesListChangedEvent?.Invoke(favorite);
    };
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
    
    public delegate void LobbyMessageEventHandler(ulong lobbyId, long user, string message, long chatType);
    private static event LobbyMessageEventHandler LobbyMessageEvent;
    static Action<ulong, long, string, long> _lobbyMessageAction = (lobbyId, user, message, chatType) =>
    {
        LobbyMessageEvent?.Invoke(lobbyId, user, message, chatType);
    };
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
    
    public delegate void LobbyChatUpdateEventHandler(ulong lobbyId, long changedId, long makingChangeId, long chatState);
    private static event LobbyChatUpdateEventHandler LobbyChatUpdateEvent;
    static Action<ulong, long, long, long> _lobbyChatUpdateAction = (lobbyId, changedId, makingChangeId, chatState) =>
    {
        LobbyChatUpdateEvent?.Invoke(lobbyId, changedId, makingChangeId, chatState);
    };
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
    
    public delegate void LobbyCreatedEventHandler(long connect, ulong lobbyId);
    private static event LobbyCreatedEventHandler LobbyCreatedEvent;
    static Action<long, ulong> _lobbyCreatedAction = (connect, lobbyId) =>
    {
        LobbyCreatedEvent?.Invoke(connect, lobbyId);
    };
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

    public delegate void LobbyDataUpdateEventHandler(uint success, ulong lobbyID, ulong memberID);
    public static event LobbyDataUpdateEventHandler LobbyDataUpdateEvent;
    static Action<uint, ulong, ulong> _lobbyDataUpdateAction = (success, lobbyID, memberID) =>
    {
        LobbyDataUpdateEvent?.Invoke(success, lobbyID, memberID);
    };
    public static event LobbyDataUpdateEventHandler LobbyDataUpdate
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
    
    public delegate void LobbyJoinedEventHandler(ulong lobby, long permissions, bool locked, long response);
    private static event LobbyJoinedEventHandler LobbyJoinedEvent;
    static Action<ulong, long, bool, long> _lobbyJoinedAction = (lobby, permissions, locked, response) =>
    {
        LobbyJoinedEvent?.Invoke(lobby, permissions, locked, response);
    };
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
    
    public delegate void LobbyGameCreatedEventHandler(ulong lobbyId, ulong serverId, string serverIP, ushort port);
    private static event LobbyGameCreatedEventHandler LobbyGameCreatedEvent;
    static Action<ulong, ulong, string, ushort> _lobbyGameCreatedAction = (lobbyId, serverId, serverIP, port) =>
    {
        LobbyGameCreatedEvent?.Invoke(lobbyId, serverId, serverIP, port);
    };
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
    
    public delegate void LobbyInviteEventHandler(ulong inviter, ulong lobby, ulong game);
    private static event LobbyInviteEventHandler LobbyInviteEvent;
    static Action<ulong, ulong, ulong> _lobbyInviteAction = (inviter, lobby, game) =>
    {
        LobbyInviteEvent?.Invoke(inviter, lobby, game);
    };
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
    
    public delegate void LobbyMatchListEventHandler(Godot.Collections.Array lobbies);
    private static event LobbyMatchListEventHandler LobbyMatchListEvent;
    static Action<Godot.Collections.Array> _lobbyMatchListAction = (lobbies) =>
    {
        LobbyMatchListEvent?.Invoke(lobbies);
    };
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
    
    public delegate void LobbyKickedEventHandler(ulong lobbyId, ulong adminId, byte dueToDisconnect);
    private static event LobbyKickedEventHandler LobbyKickedEvent;
    static Action<ulong, ulong, byte> _lobbyKickedAction = (lobbyId, adminId, dueToDisconnect) =>
    {
        LobbyKickedEvent?.Invoke(lobbyId, adminId, dueToDisconnect);
    };
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
