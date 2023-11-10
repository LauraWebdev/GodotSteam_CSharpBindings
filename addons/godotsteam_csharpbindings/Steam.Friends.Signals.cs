using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void AvatarLoadedEventHandler(long avatarId, int size, byte[] data);
    private static event AvatarLoadedEventHandler AvatarLoadedEvent;
    static Action<long, int, byte[]> _avatarLoadedAction = (avatarId, size, data) =>
    {
        AvatarLoadedEvent?.Invoke(avatarId, size, data);
    };
    public static event AvatarLoadedEventHandler AvatarLoaded
    {
        add
        {
            if(AvatarLoadedEvent == null)
            {
                GetInstance().Connect(Signals.AvatarLoaded, Callable.From(_avatarLoadedAction));
            }
            AvatarLoadedEvent += value;
        }
        remove
        {
            AvatarLoadedEvent -= value;
            if(AvatarLoadedEvent == null)
            {
                GetInstance().Disconnect(Signals.AvatarLoaded, Callable.From(_avatarLoadedAction));
            }
        }
    }
    
    public delegate void AvatarImageLoadedEventHandler(long avatarId, long avatarIndex, int width, int height);
    private static event AvatarImageLoadedEventHandler AvatarImageLoadedEvent;
    static Action<long, long, int, int> _avatarImageLoadedAction = (avatarId, avatarIndex, width, height) =>
    {
        AvatarImageLoadedEvent?.Invoke(avatarId, avatarIndex, width, height);
    };
    public static event AvatarImageLoadedEventHandler AvatarImageLoaded
    {
        add
        {
            if(AvatarImageLoadedEvent == null)
            {
                GetInstance().Connect(Signals.AvatarImageLoaded, Callable.From(_avatarImageLoadedAction));
            }
            AvatarImageLoadedEvent += value;
        }
        remove
        {
            AvatarImageLoadedEvent -= value;
            if(AvatarImageLoadedEvent == null)
            {
                GetInstance().Disconnect(Signals.AvatarImageLoaded, Callable.From(_avatarImageLoadedAction));
            }
        }
    }
    
    public delegate void ChangeServerRequestedEventHandler(string server, string password);
    private static event ChangeServerRequestedEventHandler ChangeServerRequestedEvent;
    static Action<string, string> _changeServerRequestedAction = (server, password) =>
    {
        ChangeServerRequestedEvent?.Invoke(server, password);
    };
    public static event ChangeServerRequestedEventHandler ChangeServerRequested
    {
        add
        {
            if(ChangeServerRequestedEvent == null)
            {
                GetInstance().Connect(Signals.ChangeServerRequested, Callable.From(_changeServerRequestedAction));
            }
            ChangeServerRequestedEvent += value;
        }
        remove
        {
            ChangeServerRequestedEvent -= value;
            if(ChangeServerRequestedEvent == null)
            {
                GetInstance().Disconnect(Signals.ChangeServerRequested, Callable.From(_changeServerRequestedAction));
            }
        }
    }
    
    public delegate void ClanActivityDownloadedEventHandler(Godot.Collections.Dictionary activity);
    private static event ClanActivityDownloadedEventHandler ClanActivityDownloadedEvent;
    static Action<Godot.Collections.Dictionary> _clanActivityDownloadedAction = (activity) =>
    {
        ClanActivityDownloadedEvent?.Invoke(activity);
    };
    public static event ClanActivityDownloadedEventHandler ClanActivityDownloaded
    {
        add
        {
            if(ClanActivityDownloadedEvent == null)
            {
                GetInstance().Connect(Signals.ClanActivityDownloaded, Callable.From(_clanActivityDownloadedAction));
            }
            ClanActivityDownloadedEvent += value;
        }
        remove
        {
            ClanActivityDownloadedEvent -= value;
            if(ClanActivityDownloadedEvent == null)
            {
                GetInstance().Disconnect(Signals.ClanActivityDownloaded, Callable.From(_clanActivityDownloadedAction));
            }
        }
    }
    
    public delegate void ConnectedChatJoinEventHandler(long chatId, ulong steamId);
    private static event ConnectedChatJoinEventHandler ConnectedChatJoinEvent;
    static Action<long, ulong> _connectedChatJoinAction = (chatId, steamId) =>
    {
        ConnectedChatJoinEvent?.Invoke(chatId, steamId);
    };
    public static event ConnectedChatJoinEventHandler ConnectedChatJoin
    {
        add
        {
            if(ConnectedChatJoinEvent == null)
            {
                GetInstance().Connect(Signals.ConnectedChatJoin, Callable.From(_connectedChatJoinAction));
            }
            ConnectedChatJoinEvent += value;
        }
        remove
        {
            ConnectedChatJoinEvent -= value;
            if(ConnectedChatJoinEvent == null)
            {
                GetInstance().Disconnect(Signals.ConnectedChatJoin, Callable.From(_connectedChatJoinAction));
            }
        }
    }
    
    public delegate void ConnectedChatLeaveEventHandler(long chatId, ulong steamId, bool kicked, bool dropped);
    private static event ConnectedChatLeaveEventHandler ConnectedChatLeaveEvent;
    static Action<long, ulong, bool, bool> _connectedChatLeaveAction = (chatId, steamId, kicked, dropped) =>
    {
        ConnectedChatLeaveEvent?.Invoke(chatId, steamId, kicked, dropped);
    };
    public static event ConnectedChatLeaveEventHandler ConnectedChatLeave
    {
        add
        {
            if(ConnectedChatLeaveEvent == null)
            {
                GetInstance().Connect(Signals.ConnectedChatLeave, Callable.From(_connectedChatLeaveAction));
            }
            ConnectedChatLeaveEvent += value;
        }
        remove
        {
            ConnectedChatLeaveEvent -= value;
            if(ConnectedChatLeaveEvent == null)
            {
                GetInstance().Disconnect(Signals.ConnectedChatLeave, Callable.From(_connectedChatLeaveAction));
            }
        }
    }
    
    public delegate void ConnectedClanChatMessageEventHandler(Godot.Collections.Dictionary chat);
    private static event ConnectedClanChatMessageEventHandler ConnectedClanChatMessageEvent;
    static Action<Godot.Collections.Dictionary> _connectedClanChatMessageAction = (chat) =>
    {
        ConnectedClanChatMessageEvent?.Invoke(chat);
    };
    public static event ConnectedClanChatMessageEventHandler ConnectedClanChatMessage
    {
        add
        {
            if(ConnectedClanChatMessageEvent == null)
            {
                GetInstance().Connect(Signals.ConnectedClanChatMessage, Callable.From(_connectedClanChatMessageAction));
            }
            ConnectedClanChatMessageEvent += value;
        }
        remove
        {
            ConnectedClanChatMessageEvent -= value;
            if(ConnectedClanChatMessageEvent == null)
            {
                GetInstance().Disconnect(Signals.ConnectedClanChatMessage, Callable.From(_connectedClanChatMessageAction));
            }
        }
    }
    
    public delegate void ConnectedFriendChatMessageEventHandler(Godot.Collections.Dictionary chat);
    private static event ConnectedFriendChatMessageEventHandler ConnectedFriendChatMessageEvent;
    static Action<Godot.Collections.Dictionary> _connectedFriendChatMessageAction = (chat) =>
    {
        ConnectedFriendChatMessageEvent?.Invoke(chat);
    };
    public static event ConnectedFriendChatMessageEventHandler ConnectedFriendChatMessage
    {
        add
        {
            if(ConnectedFriendChatMessageEvent == null)
            {
                GetInstance().Connect(Signals.ConnectedFriendChatMessage, Callable.From(_connectedFriendChatMessageAction));
            }
            ConnectedFriendChatMessageEvent += value;
        }
        remove
        {
            ConnectedFriendChatMessageEvent -= value;
            if(ConnectedFriendChatMessageEvent == null)
            {
                GetInstance().Disconnect(Signals.ConnectedFriendChatMessage, Callable.From(_connectedFriendChatMessageAction));
            }
        }
    }
    
    public delegate void EnumerateFollowingListSignalEventHandler(string message, Godot.Collections.Array following);
    private static event EnumerateFollowingListSignalEventHandler EnumerateFollowingListSignalEvent;
    static Action<string, Godot.Collections.Array> _enumerateFollowingListSignalAction = (message, following) =>
    {
        EnumerateFollowingListSignalEvent?.Invoke(message, following);
    };
    public static event EnumerateFollowingListSignalEventHandler EnumerateFollowingListSignal
    {
        add
        {
            if(EnumerateFollowingListSignalEvent == null)
            {
                GetInstance().Connect(Signals.EnumerateFollowingListSignal, Callable.From(_enumerateFollowingListSignalAction));
            }
            EnumerateFollowingListSignalEvent += value;
        }
        remove
        {
            EnumerateFollowingListSignalEvent -= value;
            if(EnumerateFollowingListSignalEvent == null)
            {
                GetInstance().Disconnect(Signals.EnumerateFollowingListSignal, Callable.From(_enumerateFollowingListSignalAction));
            }
        }
    }
    
    public delegate void EquippedProfileItemsChangedEventHandler(ulong steamId);
    private static event EquippedProfileItemsChangedEventHandler EquippedProfileItemsChangedEvent;
    static Action<ulong> _equippedProfileItemsChangedAction = (steamId) =>
    {
        EquippedProfileItemsChangedEvent?.Invoke(steamId);
    };
    public static event EquippedProfileItemsChangedEventHandler EquippedProfileItemsChanged
    {
        add
        {
            if(EquippedProfileItemsChangedEvent == null)
            {
                GetInstance().Connect(Signals.EquippedProfileItemsChanged, Callable.From(_equippedProfileItemsChangedAction));
            }
            EquippedProfileItemsChangedEvent += value;
        }
        remove
        {
            EquippedProfileItemsChangedEvent -= value;
            if(EquippedProfileItemsChangedEvent == null)
            {
                GetInstance().Disconnect(Signals.EquippedProfileItemsChanged, Callable.From(_equippedProfileItemsChangedAction));
            }
        }
    }
    
    public delegate void EquippedProfileItemsEventHandler(long result, ulong steamId, Godot.Collections.Dictionary profileData);
    private static event EquippedProfileItemsEventHandler EquippedProfileItemsEvent;
    static Action<long, ulong, Godot.Collections.Dictionary> _equippedProfileItemsAction = (result, steamId, profileData) =>
    {
        EquippedProfileItemsEvent?.Invoke(result, steamId, profileData);
    };
    public static event EquippedProfileItemsEventHandler EquippedProfileItems
    {
        add
        {
            if(EquippedProfileItemsEvent == null)
            {
                GetInstance().Connect(Signals.EquippedProfileItems, Callable.From(_equippedProfileItemsAction));
            }
            EquippedProfileItemsEvent += value;
        }
        remove
        {
            EquippedProfileItemsEvent -= value;
            if(EquippedProfileItemsEvent == null)
            {
                GetInstance().Disconnect(Signals.EquippedProfileItems, Callable.From(_equippedProfileItemsAction));
            }
        }
    }
    
    public delegate void FriendRichPresenceUpdateEventHandler(ulong steamId, uint appId);
    private static event FriendRichPresenceUpdateEventHandler FriendRichPresenceUpdateEvent;
    static Action<ulong, uint> _friendRichPresenceUpdateAction = (steamId, appId) =>
    {
        FriendRichPresenceUpdateEvent?.Invoke(steamId, appId);
    };
    public static event FriendRichPresenceUpdateEventHandler FriendRichPresenceUpdate
    {
        add
        {
            if(FriendRichPresenceUpdateEvent == null)
            {
                GetInstance().Connect(Signals.FriendRichPresenceUpdate, Callable.From(_friendRichPresenceUpdateAction));
            }
            FriendRichPresenceUpdateEvent += value;
        }
        remove
        {
            FriendRichPresenceUpdateEvent -= value;
            if(FriendRichPresenceUpdateEvent == null)
            {
                GetInstance().Disconnect(Signals.FriendRichPresenceUpdate, Callable.From(_friendRichPresenceUpdateAction));
            }
        }
    }
    
    public delegate void GetFollowerCountSignalEventHandler(long result, ulong steamId, long count);
    private static event GetFollowerCountSignalEventHandler GetFollowerCountSignalEvent;
    static Action<long, ulong, long> _getFollowerCountSignalAction = (result, steamId, count) =>
    {
        GetFollowerCountSignalEvent?.Invoke(result, steamId, count);
    };
    public static event GetFollowerCountSignalEventHandler GetFollowerCountSignal
    {
        add
        {
            if(GetFollowerCountSignalEvent == null)
            {
                GetInstance().Connect(Signals.GetFollowerCountSignal, Callable.From(_getFollowerCountSignalAction));
            }
            GetFollowerCountSignalEvent += value;
        }
        remove
        {
            GetFollowerCountSignalEvent -= value;
            if(GetFollowerCountSignalEvent == null)
            {
                GetInstance().Disconnect(Signals.GetFollowerCountSignal, Callable.From(_getFollowerCountSignalAction));
            }
        }
    }
    
    public delegate void IsFollowingSignalEventHandler(long result, ulong steamId, bool following);
    private static event IsFollowingSignalEventHandler IsFollowingSignalEvent;
    static Action<long, ulong, bool> _isFollowingSignalAction = (result, steamId, following) =>
    {
        IsFollowingSignalEvent?.Invoke(result, steamId, following);
    };
    public static event IsFollowingSignalEventHandler IsFollowingSignal
    {
        add
        {
            if(IsFollowingSignalEvent == null)
            {
                GetInstance().Connect(Signals.IsFollowingSignal, Callable.From(_isFollowingSignalAction));
            }
            IsFollowingSignalEvent += value;
        }
        remove
        {
            IsFollowingSignalEvent -= value;
            if(IsFollowingSignalEvent == null)
            {
                GetInstance().Disconnect(Signals.IsFollowingSignal, Callable.From(_isFollowingSignalAction));
            }
        }
    }
    
    public delegate void JoinClanChatCompleteEventHandler(long chatId, long response);
    private static event JoinClanChatCompleteEventHandler JoinClanChatCompleteEvent;
    static Action<long, long> _joinClanChatCompleteAction = (chatId, response) =>
    {
        JoinClanChatCompleteEvent?.Invoke(chatId, response);
    };
    public static event JoinClanChatCompleteEventHandler JoinClanChatComplete
    {
        add
        {
            if(JoinClanChatCompleteEvent == null)
            {
                GetInstance().Connect(Signals.JoinClanChatComplete, Callable.From(_joinClanChatCompleteAction));
            }
            JoinClanChatCompleteEvent += value;
        }
        remove
        {
            JoinClanChatCompleteEvent -= value;
            if(JoinClanChatCompleteEvent == null)
            {
                GetInstance().Disconnect(Signals.JoinClanChatComplete, Callable.From(_joinClanChatCompleteAction));
            }
        }
    }
    
    public delegate void JoinGameRequestedEventHandler(long user, string connect);
    private static event JoinGameRequestedEventHandler JoinGameRequestedEvent;
    static Action<long, string> _joinGameRequestedAction = (user, connect) =>
    {
        JoinGameRequestedEvent?.Invoke(user, connect);
    };
    public static event JoinGameRequestedEventHandler JoinGameRequested
    {
        add
        {
            if(JoinGameRequestedEvent == null)
            {
                GetInstance().Connect(Signals.JoinGameRequested, Callable.From(_joinGameRequestedAction));
            }
            JoinGameRequestedEvent += value;
        }
        remove
        {
            JoinGameRequestedEvent -= value;
            if(JoinGameRequestedEvent == null)
            {
                GetInstance().Disconnect(Signals.JoinGameRequested, Callable.From(_joinGameRequestedAction));
            }
        }
    }
    
    public delegate void JoinRequestedEventHandler(long lobbyId, string steamId);
    private static event JoinRequestedEventHandler JoinRequestedEvent;
    static Action<long, string> _joinRequestedAction = (lobbyId, steamId) =>
    {
        JoinRequestedEvent?.Invoke(lobbyId, steamId);
    };
    public static event JoinRequestedEventHandler JoinRequested
    {
        add
        {
            if(JoinRequestedEvent == null)
            {
                GetInstance().Connect(Signals.JoinRequested, Callable.From(_joinRequestedAction));
            }
            JoinRequestedEvent += value;
        }
        remove
        {
            JoinRequestedEvent -= value;
            if(JoinRequestedEvent == null)
            {
                GetInstance().Disconnect(Signals.JoinRequested, Callable.From(_joinRequestedAction));
            }
        }
    }
    
    public delegate void NameChangedEventHandler(bool success, bool localSuccess, long result);
    private static event NameChangedEventHandler NameChangedEvent;
    static Action<bool, bool, long> _nameChangedAction = (success, localSuccess, result) =>
    {
        NameChangedEvent?.Invoke(success, localSuccess, result);
    };
    public static event NameChangedEventHandler NameChanged
    {
        add
        {
            if(NameChangedEvent == null)
            {
                GetInstance().Connect(Signals.NameChanged, Callable.From(_nameChangedAction));
            }
            NameChangedEvent += value;
        }
        remove
        {
            NameChangedEvent -= value;
            if(NameChangedEvent == null)
            {
                GetInstance().Disconnect(Signals.NameChanged, Callable.From(_nameChangedAction));
            }
        }
    }
    
    public delegate void OverlayBrowserProtocolEventHandler(string uri);
    private static event OverlayBrowserProtocolEventHandler OverlayBrowserProtocolEvent;
    static Action<string> _overlayBrowserProtocolAction = (uri) =>
    {
        OverlayBrowserProtocolEvent?.Invoke(uri);
    };
    public static event OverlayBrowserProtocolEventHandler OverlayBrowserProtocol
    {
        add
        {
            if(OverlayBrowserProtocolEvent == null)
            {
                GetInstance().Connect(Signals.OverlayBrowserProtocol, Callable.From(_overlayBrowserProtocolAction));
            }
            OverlayBrowserProtocolEvent += value;
        }
        remove
        {
            OverlayBrowserProtocolEvent -= value;
            if(OverlayBrowserProtocolEvent == null)
            {
                GetInstance().Disconnect(Signals.OverlayBrowserProtocol, Callable.From(_overlayBrowserProtocolAction));
            }
        }
    }
    
    public delegate void OverlayToggledEventHandler(bool active, bool userInitiated, uint appId);
    private static event OverlayToggledEventHandler OverlayToggledEvent;
    static Action<bool, bool, uint> _overlayToggledAction = (active, userInitiated, appId) =>
    {
        OverlayToggledEvent?.Invoke(active, userInitiated, appId);
    };
    public static event OverlayToggledEventHandler OverlayToggled
    {
        add
        {
            if(OverlayToggledEvent == null)
            {
                GetInstance().Connect(Signals.OverlayToggled, Callable.From(_overlayToggledAction));
            }
            OverlayToggledEvent += value;
        }
        remove
        {
            OverlayToggledEvent -= value;
            if(OverlayToggledEvent == null)
            {
                GetInstance().Disconnect(Signals.OverlayToggled, Callable.From(_overlayToggledAction));
            }
        }
    }
    
    public delegate void PersonaStateChangeEventHandler(ulong steamId, long flags);
    private static event PersonaStateChangeEventHandler PersonaStateChangeEvent;
    static Action<ulong, long> _personaStateChangeAction = (steamId, flags) =>
    {
        PersonaStateChangeEvent?.Invoke(steamId, flags);
    };
    public static event PersonaStateChangeEventHandler PersonaStateChange
    {
        add
        {
            if(PersonaStateChangeEvent == null)
            {
                GetInstance().Connect(Signals.PersonaStateChange, Callable.From(_personaStateChangeAction));
            }
            PersonaStateChangeEvent += value;
        }
        remove
        {
            PersonaStateChangeEvent -= value;
            if(PersonaStateChangeEvent == null)
            {
                GetInstance().Disconnect(Signals.PersonaStateChange, Callable.From(_personaStateChangeAction));
            }
        }
    }
    
    public delegate void RequestClanOfficerListSignalEventHandler(string message, Godot.Collections.Array officerList);
    private static event RequestClanOfficerListSignalEventHandler RequestClanOfficerListSignalEvent;
    static Action<string, Godot.Collections.Array> _requestClanOfficerListSignalAction = (message, officerList) =>
    {
        RequestClanOfficerListSignalEvent?.Invoke(message, officerList);
    };
    public static event RequestClanOfficerListSignalEventHandler RequestClanOfficerListSignal
    {
        add
        {
            if(RequestClanOfficerListSignalEvent == null)
            {
                GetInstance().Connect(Signals.RequestClanOfficerListSignal, Callable.From(_requestClanOfficerListSignalAction));
            }
            RequestClanOfficerListSignalEvent += value;
        }
        remove
        {
            RequestClanOfficerListSignalEvent -= value;
            if(RequestClanOfficerListSignalEvent == null)
            {
                GetInstance().Disconnect(Signals.RequestClanOfficerListSignal, Callable.From(_requestClanOfficerListSignalAction));
            }
        }
    }
    
    private static event Action UnreadChatMessagesChangedEvent;
    static Action _unreadChatMessagesChangedAction = () =>
    {
        UnreadChatMessagesChangedEvent?.Invoke();
    };
    public static event Action UnreadChatMessagesChanged
    {
        add
        {
            if(UnreadChatMessagesChangedEvent == null)
            {
                GetInstance().Connect(Signals.UnreadChatMessagesChanged, Callable.From(_unreadChatMessagesChangedAction));
            }
            UnreadChatMessagesChangedEvent += value;
        }
        remove
        {
            UnreadChatMessagesChangedEvent -= value;
            if(UnreadChatMessagesChangedEvent == null)
            {
                GetInstance().Disconnect(Signals.UnreadChatMessagesChanged, Callable.From(_unreadChatMessagesChangedAction));
            }
        }
    }
}