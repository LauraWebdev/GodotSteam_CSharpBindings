using System;
using System.Collections.Generic;
using System.Linq;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The avatar loaded event handler
    /// </summary>
    public delegate void AvatarLoadedEventHandler(ulong avatarId, int width, byte[] data);
    private static event AvatarLoadedEventHandler AvatarLoadedEvent;
    /// <summary>
    /// The data
    /// </summary>
    static Action<ulong, int, byte[]> _avatarLoadedAction = (avatarId, width, data) =>
    {
        AvatarLoadedEvent?.Invoke(avatarId, width, data);
    };
    /// <summary>
    /// The avatar loaded
    /// </summary>
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
    
    /// <summary>
    /// The avatar image loaded event handler
    /// </summary>
    public delegate void AvatarImageLoadedEventHandler(ulong avatarId, uint avatarIndex, uint width, uint height);
    private static event AvatarImageLoadedEventHandler AvatarImageLoadedEvent;
    /// <summary>
    /// The height
    /// </summary>
    static Action<ulong, uint, uint, uint> _avatarImageLoadedAction = (avatarId, avatarIndex, width, height) =>
    {
        AvatarImageLoadedEvent?.Invoke(avatarId, avatarIndex, width, height);
    };
    /// <summary>
    /// The avatar image loaded
    /// </summary>
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
    
    /// <summary>
    /// The change server requested event handler
    /// </summary>
    public delegate void ChangeServerRequestedEventHandler(string server, string password);
    private static event ChangeServerRequestedEventHandler ChangeServerRequestedEvent;
    /// <summary>
    /// The password
    /// </summary>
    static Action<string, string> _changeServerRequestedAction = (server, password) =>
    {
        ChangeServerRequestedEvent?.Invoke(server, password);
    };
    /// <summary>
    /// The change server requested
    /// </summary>
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
    
    /// <summary>
    /// The clan activity downloaded event handler
    /// </summary>
    public delegate void ClanActivityDownloadedEventHandler(int online, int ingame, int chatting);
    private static event ClanActivityDownloadedEventHandler ClanActivityDownloadedEvent;
    /// <summary>
    /// The chatting
    /// </summary>
    static Action<int, int, int> _clanActivityDownloadedAction = (online, ingame, chatting) =>
    {
        ClanActivityDownloadedEvent?.Invoke(online, ingame, chatting);
    };
    /// <summary>
    /// The clan activity downloaded
    /// </summary>
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
    
    /// <summary>
    /// The connected chat join event handler
    /// </summary>
    public delegate void ConnectedChatJoinEventHandler(ulong chatId, ulong steamId);
    private static event ConnectedChatJoinEventHandler ConnectedChatJoinEvent;
    /// <summary>
    /// The steam id
    /// </summary>
    static Action<ulong, ulong> _connectedChatJoinAction = (chatId, steamId) =>
    {
        ConnectedChatJoinEvent?.Invoke(chatId, steamId);
    };
    /// <summary>
    /// The connected chat join
    /// </summary>
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
    
    /// <summary>
    /// The connected chat leave event handler
    /// </summary>
    public delegate void ConnectedChatLeaveEventHandler(ulong chatId, ulong steamId, bool kicked, bool dropped);
    private static event ConnectedChatLeaveEventHandler ConnectedChatLeaveEvent;
    /// <summary>
    /// The dropped
    /// </summary>
    static Action<ulong, ulong, bool, bool> _connectedChatLeaveAction = (chatId, steamId, kicked, dropped) =>
    {
        ConnectedChatLeaveEvent?.Invoke(chatId, steamId, kicked, dropped);
    };
    /// <summary>
    /// The connected chat leave
    /// </summary>
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
    
    /// <summary>
    /// The connected clan chat message event handler
    /// </summary>
    public delegate void ConnectedClanChatMessageEventHandler(int ret, string text, string type, ulong chatter);
    private static event ConnectedClanChatMessageEventHandler ConnectedClanChatMessageEvent;
    /// <summary>
    /// The as int 64
    /// </summary>
    static Action<Godot.Collections.Dictionary> _connectedClanChatMessageAction = (raw) =>
    {
        ConnectedClanChatMessageEvent?.Invoke(raw["ret"].AsInt32(), raw["text"].AsString(), raw["type"].AsString(), raw["chatter"].AsUInt64());
    };
    /// <summary>
    /// The connected clan chat message
    /// </summary>
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
    
    /// <summary>
    /// The connected friend chat message event handler
    /// </summary>
    public delegate void ConnectedFriendChatMessageEventHandler(int ret, string text);
    private static event ConnectedFriendChatMessageEventHandler ConnectedFriendChatMessageEvent;
    /// <summary>
    /// The as string
    /// </summary>
    static Action<Godot.Collections.Dictionary> _connectedFriendChatMessageAction = (raw) =>
    {
        ConnectedFriendChatMessageEvent?.Invoke(raw["ret"].AsInt32(), raw["text"].AsString());
    };
    /// <summary>
    /// The connected friend chat message
    /// </summary>
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
    
    /// <summary>
    /// The enumerate following list signal event handler
    /// </summary>
    public delegate void EnumerateFollowingListSignalEventHandler(string message, List<Follow> following);
    private static event EnumerateFollowingListSignalEventHandler EnumerateFollowingListSignalEvent;
    /// <summary>
    /// The to list
    /// </summary>
    static Action<string, Godot.Collections.Array> _enumerateFollowingListSignalAction = (message, following) =>
    {
        EnumerateFollowingListSignalEvent?.Invoke(
            message,
            following
                .Select(rawFollow => rawFollow.AsGodotDictionary())
                .Select(
                    followDictionary => new Follow
                    {
                        Num = followDictionary["num"].AsInt32(),
                        Id = followDictionary["id"].AsUInt64(),
                    })
                .ToList()
        );
    };
    /// <summary>
    /// The enumerate following list signal
    /// </summary>
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
    
    /// <summary>
    /// The equipped profile items changed event handler
    /// </summary>
    public delegate void EquippedProfileItemsChangedEventHandler(ulong steamId);
    private static event EquippedProfileItemsChangedEventHandler EquippedProfileItemsChangedEvent;
    /// <summary>
    /// The steam id
    /// </summary>
    static Action<ulong> _equippedProfileItemsChangedAction = (steamId) =>
    {
        EquippedProfileItemsChangedEvent?.Invoke(steamId);
    };
    /// <summary>
    /// The equipped profile items changed
    /// </summary>
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
    
    /// <summary>
    /// The equipped profile items event handler
    /// </summary>
    public delegate void EquippedProfileItemsEventHandler(ErrorResult result, ulong steamId, ProfileData profileData);
    private static event EquippedProfileItemsEventHandler EquippedProfileItemsEvent;
    /// <summary>
    /// The as bool
    /// </summary>
    static Action<int, ulong, Godot.Collections.Dictionary> _equippedProfileItemsAction = (result, steamId, profileData) =>
    {
        EquippedProfileItemsEvent?.Invoke(
            (ErrorResult)result,
            steamId, new ProfileData
            {
                AvatarAnimated = profileData["avatar_animated"].AsBool(),
                AvatarFrame = profileData["avatar_frame"].AsBool(),
                ProfileModifier = profileData["profile_modifier"].AsBool(),
                ProfileBackground = profileData["profile_background"].AsBool(),
                ProfileMiniBackground = profileData["profile_mini_background"].AsBool(),
            }
        );
    };
    /// <summary>
    /// The equipped profile items
    /// </summary>
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
    
    /// <summary>
    /// The friend rich presence update event handler
    /// </summary>
    public delegate void FriendRichPresenceUpdateEventHandler(ulong steamId, uint appId);
    private static event FriendRichPresenceUpdateEventHandler FriendRichPresenceUpdateEvent;
    /// <summary>
    /// The app id
    /// </summary>
    static Action<ulong, uint> _friendRichPresenceUpdateAction = (steamId, appId) =>
    {
        FriendRichPresenceUpdateEvent?.Invoke(steamId, appId);
    };
    /// <summary>
    /// The friend rich presence update
    /// </summary>
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
    
    /// <summary>
    /// The get follower count signal event handler
    /// </summary>
    public delegate void GetFollowerCountSignalEventHandler(ErrorResult result, ulong steamId, int count);
    private static event GetFollowerCountSignalEventHandler GetFollowerCountSignalEvent;
    /// <summary>
    /// The count
    /// </summary>
    static Action<int, ulong, int> _getFollowerCountSignalAction = (result, steamId, count) =>
    {
        GetFollowerCountSignalEvent?.Invoke((ErrorResult)result, steamId, count);
    };
    /// <summary>
    /// The get follower count signal
    /// </summary>
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
    
    /// <summary>
    /// The is following signal event handler
    /// </summary>
    public delegate void IsFollowingSignalEventHandler(ErrorResult result, ulong steamId, bool following);
    private static event IsFollowingSignalEventHandler IsFollowingSignalEvent;
    /// <summary>
    /// The following
    /// </summary>
    static Action<int, ulong, bool> _isFollowingSignalAction = (result, steamId, following) =>
    {
        IsFollowingSignalEvent?.Invoke((ErrorResult)result, steamId, following);
    };
    /// <summary>
    /// The is following signal
    /// </summary>
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
    
    /// <summary>
    /// The join clan chat complete event handler
    /// </summary>
    public delegate void JoinClanChatCompleteEventHandler(ulong chatId, ChatRoomEnterResponse response);
    private static event JoinClanChatCompleteEventHandler JoinClanChatCompleteEvent;
    /// <summary>
    /// The response
    /// </summary>
    static Action<ulong, int> _joinClanChatCompleteAction = (chatId, response) =>
    {
        JoinClanChatCompleteEvent?.Invoke(chatId, (ChatRoomEnterResponse)response);
    };
    /// <summary>
    /// The join clan chat complete
    /// </summary>
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
    
    /// <summary>
    /// The join game requested event handler
    /// </summary>
    public delegate void JoinGameRequestedEventHandler(ulong user, string connect);
    private static event JoinGameRequestedEventHandler JoinGameRequestedEvent;
    /// <summary>
    /// The connect
    /// </summary>
    static Action<ulong, string> _joinGameRequestedAction = (user, connect) =>
    {
        JoinGameRequestedEvent?.Invoke(user, connect);
    };
    /// <summary>
    /// The join game requested
    /// </summary>
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
    
    /// <summary>
    /// The join requested event handler
    /// </summary>
    public delegate void JoinRequestedEventHandler(ulong lobbyId, ulong steamId);
    private static event JoinRequestedEventHandler JoinRequestedEvent;
    /// <summary>
    /// The steam id
    /// </summary>
    static Action<ulong, ulong> _joinRequestedAction = (lobbyId, steamId) =>
    {
        JoinRequestedEvent?.Invoke(lobbyId, steamId);
    };
    /// <summary>
    /// The join requested
    /// </summary>
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
    
    /// <summary>
    /// The name changed event handler
    /// </summary>
    public delegate void NameChangedEventHandler(bool success, bool localSuccess, ErrorResult result);
    private static event NameChangedEventHandler NameChangedEvent;
    /// <summary>
    /// The result
    /// </summary>
    static Action<bool, bool, int> _nameChangedAction = (success, localSuccess, result) =>
    {
        NameChangedEvent?.Invoke(success, localSuccess, (ErrorResult)result);
    };
    /// <summary>
    /// The name changed
    /// </summary>
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
    
    /// <summary>
    /// The overlay browser protocol event handler
    /// </summary>
    public delegate void OverlayBrowserProtocolEventHandler(Uri uri);
    private static event OverlayBrowserProtocolEventHandler OverlayBrowserProtocolEvent;
    /// <summary>
    /// The uri
    /// </summary>
    static Action<string> _overlayBrowserProtocolAction = (uri) =>
    {
        OverlayBrowserProtocolEvent?.Invoke(new Uri(uri));
    };
    /// <summary>
    /// The overlay browser protocol
    /// </summary>
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
    
    /// <summary>
    /// The overlay toggled event handler
    /// </summary>
    public delegate void OverlayToggledEventHandler(bool active, bool userInitiated, uint appId);
    private static event OverlayToggledEventHandler OverlayToggledEvent;
    /// <summary>
    /// The app id
    /// </summary>
    static Action<bool, bool, uint> _overlayToggledAction = (active, userInitiated, appId) =>
    {
        OverlayToggledEvent?.Invoke(active, userInitiated, appId);
    };
    /// <summary>
    /// The overlay toggled
    /// </summary>
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
    
    /// <summary>
    /// The persona state change event handler
    /// </summary>
    public delegate void PersonaStateChangeEventHandler(ulong steamId, PersonaChange flags);
    private static event PersonaStateChangeEventHandler PersonaStateChangeEvent;
    /// <summary>
    /// The flags
    /// </summary>
    static Action<ulong, long> _personaStateChangeAction = (steamId, flags) =>
    {
        PersonaStateChangeEvent?.Invoke(steamId, (PersonaChange)flags);
    };
    /// <summary>
    /// The persona state change
    /// </summary>
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
    
    /// <summary>
    /// The request clan officer list signal event handler
    /// </summary>
    public delegate void RequestClanOfficerListSignalEventHandler(string message, List<ClanOfficer> officerList);
    private static event RequestClanOfficerListSignalEventHandler RequestClanOfficerListSignalEvent;
    /// <summary>
    /// The to list
    /// </summary>
    static Action<string, Godot.Collections.Array> _requestClanOfficerListSignalAction = (message, officerList) =>
    {
        RequestClanOfficerListSignalEvent?.Invoke(
            message,
            officerList
                .Select(rawOfficer => rawOfficer.AsGodotDictionary())
                .Select(
                    officerDictionary => new ClanOfficer
                    {
                        Id = officerDictionary["id"].AsUInt64(),
                        Name = officerDictionary["name"].AsString(),
                    })
                .ToList()
        );
    };
    /// <summary>
    /// The request clan officer list signal
    /// </summary>
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
    /// <summary>
    /// The invoke
    /// </summary>
    static Action _unreadChatMessagesChangedAction = () =>
    {
        UnreadChatMessagesChangedEvent?.Invoke();
    };
    /// <summary>
    /// The unread chat messages changed
    /// </summary>
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