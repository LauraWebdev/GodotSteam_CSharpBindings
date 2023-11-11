using System;
using System.Collections.Generic;
using System.Linq;
using Godot;
using Godot.Collections;
using Godot.NativeInterop;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Activates the game overlay using the specified type
    /// </summary>
    /// <param name="type">The type</param>
    public static void ActivateGameOverlay(GameOverlayType type)
    {
        GetInstance().Call(Methods.ActivateGameOverlay, type.ToGodotSteam());
    }
    
    /// <summary>
    /// Activates the game overlay invite dialog using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    public static void ActivateGameOverlayInviteDialog(ulong steamId)
    {
        GetInstance().Call(Methods.ActivateGameOverlayInviteDialog, steamId);
    }
    
    /// <summary>
    /// Activates the game overlay invite dialog connect string using the specified connect string
    /// </summary>
    /// <param name="connectString">The connect string</param>
    public static void ActivateGameOverlayInviteDialogConnectString(string connectString)
    {
        GetInstance().Call(Methods.ActivateGameOverlayInviteDialogConnectString, connectString);
    }
    
    /// <summary>
    /// Activates the game overlay to store using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    public static void ActivateGameOverlayToStore(uint appId = 0)
    {
        GetInstance().Call(Methods.ActivateGameOverlayToStore, appId);
    }
    
    /// <summary>
    /// Activates the game overlay to user using the specified type
    /// </summary>
    /// <param name="type">The type</param>
    /// <param name="steamId">The steam id</param>
    public static void ActivateGameOverlayToUser(GameOverlayUserType type, ulong steamId = 0)
    {
        GetInstance().Call(Methods.ActivateGameOverlayToUser, type.ToGodotSteam(), steamId);
    }
    
    /// <summary>
    /// Activates the game overlay to web page using the specified url
    /// </summary>
    /// <param name="url">The url</param>
    public static void ActivateGameOverlayToWebPage(string url)
    {
        GetInstance().Call(Methods.ActivateGameOverlayToWebPage, url);
    }
    
    /// <summary>
    /// Gets the follower count using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    public static void GetFollowerCount(ulong steamId)
    {
        GetInstance().Call(Methods.GetFollowerCount, steamId);
    }
    
    /// <summary>
    /// Gets the friend by index using the specified friend number
    /// </summary>
    /// <param name="friendNumber">The friend number</param>
    /// <param name="friendFlags">The friend flags</param>
    /// <returns>The ulong</returns>
    public static ulong GetFriendByIndex(int friendNumber, FriendFlag friendFlags)
    {
        return GetInstance().Call(Methods.GetFriendByIndex, friendNumber, (int)friendFlags).AsUInt64();
    }
    
    /// <summary>
    /// Gets the friend coplay game using the specified friend id
    /// </summary>
    /// <param name="friendId">The friend id</param>
    /// <returns>The uint</returns>
    public static uint GetFriendCoplayGame(ulong friendId)
    {
        return GetInstance().Call(Methods.GetFriendCoplayGame, friendId).AsUInt32();
    }
    
    /// <summary>
    /// Gets the friend coplay time using the specified friend id
    /// </summary>
    /// <param name="friendId">The friend id</param>
    /// <returns>The int</returns>
    public static int GetFriendCoplayTime(ulong friendId)
    {
        return GetInstance().Call(Methods.GetFriendCoplayTime, friendId).AsInt32();
    }
    
    /// <summary>
    /// Gets the friend count using the specified friend flags
    /// </summary>
    /// <param name="friendFlags">The friend flags</param>
    /// <returns>The int</returns>
    public static int GetFriendCount(FriendFlag friendFlags = FriendFlag.Immediate)
    {
        return GetInstance().Call(Methods.GetFriendCount, (int)friendFlags).AsInt32();
    }
    
    /// <summary>
    /// Gets the friend count from source using the specified source id
    /// </summary>
    /// <param name="sourceId">The source id</param>
    /// <returns>The int</returns>
    public static int GetFriendCountFromSource(long sourceId)
    {
        return GetInstance().Call(Methods.GetFriendCountFromSource, sourceId).AsInt32();
    }
    
    /// <summary>
    /// Gets the friend from source by index using the specified source id
    /// </summary>
    /// <param name="sourceId">The source id</param>
    /// <param name="friendNumber">The friend number</param>
    /// <returns>The ulong</returns>
    public static ulong GetFriendFromSourceByIndex(ulong sourceId, long friendNumber)
    {
        return GetInstance().Call(Methods.GetFriendFromSourceByIndex, sourceId, friendNumber).AsUInt64();
    }
    
    /// <summary>
    /// Gets the friend game played using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetFriendGamePlayed(ulong steamId)
    {
        return GetInstance().Call(Methods.GetFriendGamePlayed, steamId).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the friend message using the specified friend id
    /// </summary>
    /// <param name="friendId">The friend id</param>
    /// <param name="message">The message</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetFriendMessage(ulong friendId, long message)
    {
        return GetInstance().Call(Methods.GetFriendMessage, friendId, message).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the friend persona name using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <returns>The string</returns>
    public static string GetFriendPersonaName(ulong steamId)
    {
        return GetInstance().Call(Methods.GetFriendPersonaName, steamId).AsString();
    }
    
    /// <summary>
    /// Gets the friend persona name history using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <param name="nameHistory">The name history</param>
    /// <returns>The string</returns>
    public static string GetFriendPersonaNameHistory(ulong steamId, long nameHistory)
    {
        return GetInstance().Call(Methods.GetFriendPersonaNameHistory, steamId, nameHistory).AsString();
    }
    
    /// <summary>
    /// Gets the friend persona state using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <returns>The persona state</returns>
    public static PersonaState GetFriendPersonaState(ulong steamId)
    {
        return (PersonaState)GetInstance().Call(Methods.GetFriendPersonaState, steamId).AsInt64();
    }
    
    /// <summary>
    /// Gets the friend relationship using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <returns>The friend relationship</returns>
    public static FriendRelationship GetFriendRelationship(ulong steamId)
    {
        return (FriendRelationship)GetInstance().Call(Methods.GetFriendRelationship, steamId).AsInt64();
    }
    
    /// <summary>
    /// Gets the friend rich presence using the specified friend id
    /// </summary>
    /// <param name="friendId">The friend id</param>
    /// <param name="key">The key</param>
    /// <returns>The string</returns>
    public static string GetFriendRichPresence(ulong friendId, string key)
    {
        return GetInstance().Call(Methods.GetFriendRichPresence, friendId, key).AsString();
    }
    
    /// <summary>
    /// Gets the friend rich presence key count using the specified friend id
    /// </summary>
    /// <param name="friendId">The friend id</param>
    /// <returns>The int</returns>
    public static int GetFriendRichPresenceKeyCount(ulong friendId)
    {
        return GetInstance().Call(Methods.GetFriendRichPresenceKeyCount, friendId).AsInt32();
    }
    
    /// <summary>
    /// Gets the friend rich presence key by index using the specified friend id
    /// </summary>
    /// <param name="friendId">The friend id</param>
    /// <param name="key">The key</param>
    /// <returns>The string</returns>
    public static string GetFriendRichPresenceKeyByIndex(ulong friendId, int key)
    {
        return GetInstance().Call(Methods.GetFriendRichPresenceKeyByIndex, friendId, key).AsString();
    }
    
    /// <summary>
    /// Gets the friends group count
    /// </summary>
    /// <returns>The int</returns>
    public static int GetFriendsGroupCount()
    {
        return GetInstance().Call(Methods.GetFriendsGroupCount).AsInt32();
    }
    
    /// <summary>
    /// Gets the friends group id by index using the specified friend group
    /// </summary>
    /// <param name="friendGroup">The friend group</param>
    /// <returns>The short</returns>
    public static short GetFriendsGroupIDByIndex(short friendGroup)
    {
        return GetInstance().Call(Methods.GetFriendsGroupIDByIndex, friendGroup).AsInt16();
    }
    
    /// <summary>
    /// Gets the friends group members count using the specified friend group
    /// </summary>
    /// <param name="friendGroup">The friend group</param>
    /// <returns>The int</returns>
    public static int GetFriendsGroupMembersCount(short friendGroup)
    {
        return GetInstance().Call(Methods.GetFriendsGroupMembersCount, friendGroup).AsInt32();
    }
    
    /// <summary>
    /// Gets the friends group members list using the specified friend group
    /// </summary>
    /// <param name="friendGroup">The friend group</param>
    /// <param name="memberCount">The member count</param>
    /// <returns>A list of ulong</returns>
    public static List<ulong> GetFriendsGroupMembersList(short friendGroup, long memberCount)
    {
        var raw = GetInstance().Call(Methods.GetFriendsGroupMembersList, friendGroup, memberCount).AsGodotArray();
        
        return raw.Select(x => x.AsUInt64()).ToList();
    }
    
    /// <summary>
    /// Gets the friends group name using the specified friend group
    /// </summary>
    /// <param name="friendGroup">The friend group</param>
    /// <returns>The string</returns>
    public static string GetFriendsGroupName(short friendGroup)
    {
        return GetInstance().Call(Methods.GetFriendsGroupName, friendGroup).AsString();
    }
    
    /// <summary>
    /// Gets the friend steam level using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <returns>The int</returns>
    public static int GetFriendSteamLevel(ulong steamId)
    {
        return GetInstance().Call(Methods.GetFriendSteamLevel, steamId).AsInt32();
    }
    
    /// <summary>
    /// Gets the large friend avatar using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <returns>The int</returns>
    public static int GetLargeFriendAvatar(ulong steamId)
    {
        return GetInstance().Call(Methods.GetLargeFriendAvatar, steamId).AsInt32();
    }
    
    /// <summary>
    /// Gets the medium friend avatar using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <returns>The int</returns>
    public static int GetMediumFriendAvatar(ulong steamId)
    {
        return GetInstance().Call(Methods.GetMediumFriendAvatar, steamId).AsInt32();
    }
    
    /// <summary>
    /// Gets the small friend avatar using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <returns>The int</returns>
    public static int GetSmallFriendAvatar(ulong steamId)
    {
        return GetInstance().Call(Methods.GetSmallFriendAvatar, steamId).AsInt32();
    }
    
    /// <summary>
    /// Describes whether reply to friend message
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <param name="message">The message</param>
    /// <returns>The bool</returns>
    public static bool ReplyToFriendMessage(ulong steamId, string message)
    {
        return GetInstance().Call(Methods.ReplyToFriendMessage, steamId, message).AsBool();
    }
    
    /// <summary>
    /// Requests the friend rich presence using the specified friend id
    /// </summary>
    /// <param name="friendId">The friend id</param>
    public static void RequestFriendRichPresence(ulong friendId)
    {
        GetInstance().Call(Methods.RequestFriendRichPresence, friendId);
    }
    
    /// <summary>
    /// Describes whether set listen for friends messages
    /// </summary>
    /// <param name="intercept">The intercept</param>
    /// <returns>The bool</returns>
    public static bool SetListenForFriendsMessages(bool intercept)
    {
        return GetInstance().Call(Methods.SetListenForFriendsMessages, intercept).AsBool();
    }
    /// <summary>
    /// Gets the coplay friend using the specified friend number
    /// </summary>
    /// <param name="friendNumber">The friend number</param>
    /// <returns>The ulong</returns>
    public static ulong GetCoplayFriend(int friendNumber)
    {
        return GetInstance().Call(Methods.GetCoplayFriend, friendNumber).AsUInt64();
    }
    
    /// <summary>
    /// Gets the coplay friend count
    /// </summary>
    /// <returns>The int</returns>
    public static int GetCoplayFriendCount()
    {
        return GetInstance().Call(Methods.GetCoplayFriendCount).AsInt32();
    }
    /// <summary>
    /// Describes whether close clan chat window in steam
    /// </summary>
    /// <param name="chatId">The chat id</param>
    /// <returns>The bool</returns>
    public static bool CloseClanChatWindowInSteam(ulong chatId)
    {
        return GetInstance().Call(Methods.CloseClanChatWindowInSteam, chatId).AsBool();
    }
    
    /// <summary>
    /// Downloads the clan activity counts using the specified chat id
    /// </summary>
    /// <param name="chatId">The chat id</param>
    /// <param name="clansToRequest">The clans to request</param>
    public static void DownloadClanActivityCounts(ulong chatId, int clansToRequest)
    {
        GetInstance().Call(Methods.DownloadClanActivityCounts, chatId, clansToRequest);
    }
    
    /// <summary>
    /// Enumerates the following list using the specified start index
    /// </summary>
    /// <param name="startIndex">The start index</param>
    public static void EnumerateFollowingList(uint startIndex)
    {
        GetInstance().Call(Methods.EnumerateFollowingList, startIndex);
    }
    
    /// <summary>
    /// Gets the chat member by index using the specified clan id
    /// </summary>
    /// <param name="clanId">The clan id</param>
    /// <param name="user">The user</param>
    /// <returns>The ulong</returns>
    public static ulong GetChatMemberByIndex(ulong clanId, long user)
    {
        return GetInstance().Call(Methods.GetChatMemberByIndex, clanId, user).AsUInt64();
    }
    
    /// <summary>
    /// Gets the clan activity counts using the specified clan id
    /// </summary>
    /// <param name="clanId">The clan id</param>
    /// <returns>The clan activity counts</returns>
    public static ClanActivityCounts GetClanActivityCounts(ulong clanId)
    {
        var raw = GetInstance().Call(Methods.GetClanActivityCounts, clanId).AsGodotDictionary();

        if (!raw.ContainsKey("clan") || !raw.ContainsKey("online") || !raw.ContainsKey("ingame") || !raw.ContainsKey("chatting"))
        {
            return null;
        }

        return new ClanActivityCounts
        {
            Clan = raw["clan"].AsUInt64(),
            Online = raw["online"].AsInt32(),
            Ingame = raw["ingame"].AsInt32(),
            Chatting = raw["chatting"].AsInt32(),
        };
    }
    
    /// <summary>
    /// Gets the clan by index using the specified clan
    /// </summary>
    /// <param name="clan">The clan</param>
    /// <returns>The ulong</returns>
    public static ulong GetClanByIndex(int clan)
    {
        return GetInstance().Call(Methods.GetClanByIndex, clan).AsUInt64();
    }
    
    /// <summary>
    /// Gets the clan chat member count using the specified clan id
    /// </summary>
    /// <param name="clanId">The clan id</param>
    /// <returns>The int</returns>
    public static int GetClanChatMemberCount(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanChatMemberCount, clanId).AsInt32();
    }
    
    /// <summary>
    /// Gets the clan chat message using the specified chat id
    /// </summary>
    /// <param name="chatId">The chat id</param>
    /// <param name="message">The message</param>
    /// <returns>The clan chat message</returns>
    public static ClanChatMessage GetClanChatMessage(ulong chatId, long message)
    {
        var raw = GetInstance().Call(Methods.GetClanChatMessage, chatId, message).AsGodotDictionary();

        if (!raw.ContainsKey("ret"))
        {
            return null;
        }
        
        return new ClanChatMessage
        {
            Ret = raw["ret"].AsBool(),
            Text = raw["text"].AsString(),
            Type = (ClanChatMessageType)raw["type"].AsInt32(),
            Chatter = raw["chatter"].AsUInt64()
        };
    }
    
    /// <summary>
    /// Gets the clan count
    /// </summary>
    /// <returns>The int</returns>
    public static int GetClanCount()
    {
        return GetInstance().Call(Methods.GetClanCount).AsInt32();
    }
    
    /// <summary>
    /// Gets the clan name using the specified clan id
    /// </summary>
    /// <param name="clanId">The clan id</param>
    /// <returns>The string</returns>
    public static string GetClanName(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanName, clanId).AsString();
    }
    
    /// <summary>
    /// Gets the clan officer by index using the specified clan id
    /// </summary>
    /// <param name="clanId">The clan id</param>
    /// <param name="officer">The officer</param>
    /// <returns>The ulong</returns>
    public static ulong GetClanOfficerByIndex(ulong clanId, int officer)
    {
        return GetInstance().Call(Methods.GetClanOfficerByIndex, clanId, officer).AsUInt64();
    }
    
    /// <summary>
    /// Gets the clan officer count using the specified clan id
    /// </summary>
    /// <param name="clanId">The clan id</param>
    /// <returns>The int</returns>
    public static int GetClanOfficerCount(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanOfficerCount, clanId).AsInt32();
    }
    
    /// <summary>
    /// Gets the clan owner using the specified clan id
    /// </summary>
    /// <param name="clanId">The clan id</param>
    /// <returns>The ulong</returns>
    public static ulong GetClanOwner(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanOwner, clanId).AsUInt64();
    }
    
    /// <summary>
    /// Gets the clan tag using the specified clan id
    /// </summary>
    /// <param name="clanId">The clan id</param>
    /// <returns>The string</returns>
    public static string GetClanTag(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanTag, clanId).AsString();
    }
    
    /// <summary>
    /// Describes whether is clan chat admin
    /// </summary>
    /// <param name="chatId">The chat id</param>
    /// <param name="steamId">The steam id</param>
    /// <returns>The bool</returns>
    public static bool IsClanChatAdmin(ulong chatId, ulong steamId)
    {
        return GetInstance().Call(Methods.IsClanChatAdmin, chatId, steamId).AsBool();
    }
    
    /// <summary>
    /// Describes whether is clan public
    /// </summary>
    /// <param name="clanId">The clan id</param>
    /// <returns>The bool</returns>
    public static bool IsClanPublic(ulong clanId)
    {
        return GetInstance().Call(Methods.IsClanPublic, clanId).AsBool();
    }
    
    /// <summary>
    /// Describes whether is clan official game group
    /// </summary>
    /// <param name="clanId">The clan id</param>
    /// <returns>The bool</returns>
    public static bool IsClanOfficialGameGroup(ulong clanId)
    {
        return GetInstance().Call(Methods.IsClanOfficialGameGroup, clanId).AsBool();
    }
    
    /// <summary>
    /// Describes whether is clan chat window open in steam
    /// </summary>
    /// <param name="chatId">The chat id</param>
    /// <returns>The bool</returns>
    public static bool IsClanChatWindowOpenInSteam(ulong chatId)
    {
        return GetInstance().Call(Methods.IsClanChatWindowOpenInSteam, chatId).AsBool();
    }
    
    /// <summary>
    /// Joins the clan chat room using the specified clan id
    /// </summary>
    /// <param name="clanId">The clan id</param>
    public static void JoinClanChatRoom(ulong clanId)
    {
        GetInstance().Call(Methods.JoinClanChatRoom, clanId);
    }
    
    /// <summary>
    /// Describes whether leave clan chat room
    /// </summary>
    /// <param name="clanId">The clan id</param>
    /// <returns>The bool</returns>
    public static bool LeaveClanChatRoom(ulong clanId)
    {
        return GetInstance().Call(Methods.LeaveClanChatRoom, clanId).AsBool();
    }
    
    /// <summary>
    /// Describes whether open clan chat window in steam
    /// </summary>
    /// <param name="chatId">The chat id</param>
    /// <returns>The bool</returns>
    public static bool OpenClanChatWindowInSteam(ulong chatId)
    {
        return GetInstance().Call(Methods.OpenClanChatWindowInSteam, chatId).AsBool();
    }
    
    /// <summary>
    /// Requests the clan officer list using the specified clan id
    /// </summary>
    /// <param name="clanId">The clan id</param>
    public static void RequestClanOfficerList(ulong clanId)
    {
        GetInstance().Call(Methods.RequestClanOfficerList, clanId);
    }
    
    /// <summary>
    /// Describes whether send clan chat message
    /// </summary>
    /// <param name="chatId">The chat id</param>
    /// <param name="text">The text</param>
    /// <returns>The bool</returns>
    public static bool SendClanChatMessage(ulong chatId, string text)
    {
        return GetInstance().Call(Methods.SendClanChatMessage, chatId, text).AsBool();
    }
    
    /// <summary>
    /// Gets the persona name
    /// </summary>
    /// <returns>The string</returns>
    public static string GetPersonaName()
    {
        return GetInstance().Call(Methods.GetPersonaName).AsString();
    }
    
    /// <summary>
    /// Gets the persona state
    /// </summary>
    /// <returns>The persona state</returns>
    public static PersonaState GetPersonaState()
    {
        return (PersonaState)GetInstance().Call(Methods.GetPersonaState).AsInt64();
    }
    
    /// <summary>
    /// Gets the player avatar using the specified size
    /// </summary>
    /// <param name="size">The size</param>
    /// <param name="steamId">The steam id</param>
    public static void GetPlayerAvatar(AvatarSize size = AvatarSize.Medium, ulong steamId = 0)
    {
        GetInstance().Call(Methods.GetPlayerAvatar, (int)size, steamId);
    }
    
    /// <summary>
    /// Gets the player nickname using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <returns>The string</returns>
    public static string GetPlayerNickname(ulong steamId)
    {
        return GetInstance().Call(Methods.GetPlayerNickname, steamId).AsString();
    }
    
    /// <summary>
    /// Gets the profile item property string using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <param name="itemType">The item type</param>
    /// <param name="itemProperty">The item property</param>
    /// <returns>The string</returns>
    public static string GetProfileItemPropertyString(ulong steamId, CommunityProfileItemType itemType, CommunityProfileItemProperty itemProperty)
    {
        return GetInstance().Call(Methods.GetProfileItemPropertyString, steamId, (int)itemType, (int)itemProperty).AsString();
    }
    
    /// <summary>
    /// Gets the profile item property int using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <param name="itemType">The item type</param>
    /// <param name="itemProperty">The item property</param>
    /// <returns>The uint</returns>
    public static uint GetProfileItemPropertyInt(ulong steamId, CommunityProfileItemType itemType, CommunityProfileItemProperty itemProperty)
    {
        return GetInstance().Call(Methods.GetProfileItemPropertyInt, steamId, (int)itemType, (int)itemProperty).AsUInt32();
    }
    
    /// <summary>
    /// Gets the recent players
    /// </summary>
    /// <returns>A list of recent player</returns>
    public static List<RecentPlayer> GetRecentPlayers()
    {
        var raw = GetInstance().Call(Methods.GetRecentPlayers).AsGodotArray();
        
        return raw.Select(
                rawPlayer => rawPlayer.AsGodotDictionary()).Select(
                playerDictionary => new RecentPlayer
                {
                    Id = playerDictionary["id"].AsUInt64(),
                    Name = playerDictionary["name"].AsString(),
                    Time = playerDictionary["time"].AsInt32(),
                    Status = (PersonaState)playerDictionary["status"].AsInt32(),
                })
            .ToList();
    }
    
    /// <summary>
    /// Gets the user friends groups
    /// </summary>
    /// <returns>A list of friend group</returns>
    public static List<FriendGroup> GetUserFriendsGroups()
    {
        var raw = GetInstance().Call(Methods.GetUserFriendsGroups).AsGodotArray();
        
        return raw.Select(
                rawFriendGroup => rawFriendGroup.AsGodotDictionary()).Select(
                friendGroupDictionary => new FriendGroup
                {
                    Id = friendGroupDictionary["id"].AsInt16(),
                    Name = friendGroupDictionary["name"].AsString(),
                    Members = friendGroupDictionary["time"].AsInt32(),
                })
            .ToList();
    }
    
    /// <summary>
    /// Gets the user restrictions
    /// </summary>
    /// <returns>The user restriction</returns>
    public static UserRestriction GetUserRestrictions()
    {
        return (UserRestriction)GetInstance().Call(Methods.GetUserRestrictions).AsUInt32();
    }
    
    /// <summary>
    /// Gets the user steam friends
    /// </summary>
    /// <returns>A list of friend</returns>
    public static List<Friend> GetUserSteamFriends()
    {
        var raw = GetInstance().Call(Methods.GetUserSteamFriends).AsGodotArray();

        return raw.Select(
            rawFriend => rawFriend.AsGodotDictionary()).Select(
            friendDictionary => new Friend
            {
                Id = friendDictionary["id"].AsUInt64(),
                Name = friendDictionary["name"].AsString(),
                Status = (PersonaState)friendDictionary["status"].AsInt32(),
            })
        .ToList();
    }
    
    /// <summary>
    /// Gets the user steam groups
    /// </summary>
    /// <returns>A list of steam group</returns>
    public static List<SteamGroup> GetUserSteamGroups()
    {
        var raw = GetInstance().Call(Methods.GetUserSteamGroups).AsGodotArray();

        return raw.Select(
                rawGroups => rawGroups.AsGodotDictionary()).Select(
                groupDictionary => new SteamGroup
                {
                    Id = groupDictionary["id"].AsUInt64(),
                    Name = groupDictionary["name"].AsString(),
                    Tag = groupDictionary["tag"].AsString(),
                })
            .ToList();
    }
    
    /// <summary>
    /// Describes whether has equipped profile item
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <param name="itemType">The item type</param>
    /// <returns>The bool</returns>
    public static bool HasEquippedProfileItem(ulong steamId, CommunityProfileItemType itemType)
    {
        return GetInstance().Call(Methods.HasEquippedProfileItem, steamId, (long)itemType).AsBool();
    }
    
    /// <summary>
    /// Describes whether has friend
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <param name="friendFlags">The friend flags</param>
    /// <returns>The bool</returns>
    public static bool HasFriend(ulong steamId, FriendFlag friendFlags)
    {
        return GetInstance().Call(Methods.HasFriend, steamId, (int)friendFlags).AsBool();
    }
    
    /// <summary>
    /// Describes whether invite user to game
    /// </summary>
    /// <param name="friendId">The friend id</param>
    /// <param name="connectString">The connect string</param>
    /// <returns>The bool</returns>
    public static bool InviteUserToGame(ulong friendId, string connectString)
    {
        return GetInstance().Call(Methods.InviteUserToGame, friendId, connectString).AsBool();
    }
    
    /// <summary>
    /// Ises the following using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    public static void IsFollowing(ulong steamId)
    {
        GetInstance().Call(Methods.IsFollowing, steamId);
    }
    
    /// <summary>
    /// Describes whether is user in source
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <param name="sourceId">The source id</param>
    /// <returns>The bool</returns>
    public static bool IsUserInSource(ulong steamId, ulong sourceId)
    {
        return GetInstance().Call(Methods.IsUserInSource, steamId, sourceId).AsBool();
    }
    
    /// <summary>
    /// Requests the equipped profile items using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    public static void RequestEquippedProfileItems(ulong steamId)
    {
        GetInstance().Call(Methods.RequestEquippedProfileItems, steamId);
    }
    
    /// <summary>
    /// Describes whether request user information
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <param name="requireNameOnly">The require name only</param>
    /// <returns>The bool</returns>
    public static bool RequestUserInformation(ulong steamId, bool requireNameOnly)
    {
        return GetInstance().Call(Methods.RequestUserInformation, steamId, requireNameOnly).AsBool();
    }
    
    /// <summary>
    /// Sets the persona name using the specified name
    /// </summary>
    /// <param name="name">The name</param>
    public static void SetPersonaName(string name)
    {
        GetInstance().Call(Methods.SetPersonaName, name);
    }
    
    /// <summary>
    /// Sets the played with using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    public static void SetPlayedWith(ulong steamId)
    {
        GetInstance().Call(Methods.SetPlayedWith, steamId);
    }
    
    /// <summary>
    /// Describes whether set rich presence
    /// </summary>
    /// <param name="richPresenceKey">The rich presence key</param>
    /// <param name="value">The value</param>
    /// <returns>The bool</returns>
    public static bool SetRichPresence(string richPresenceKey, string value)
    {
        return GetInstance().Call(Methods.SetRichPresence, richPresenceKey, value).AsBool();
    }
    /// <summary>
    /// Sets the in game voice speaking using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <param name="speaking">The speaking</param>
    public static void SetInGameVoiceSpeaking(ulong steamId, bool speaking)
    {
        GetInstance().Call(Methods.SetInGameVoiceSpeaking, steamId, speaking);
    }
    
    /// <summary>
    /// Clears the rich presence
    /// </summary>
    public static void ClearRichPresence()
    {
        GetInstance().Call(Methods.ClearRichPresence);
    }
    
    /// <summary>
    /// Describes whether register protocol in overlay browser
    /// </summary>
    /// <param name="protocol">The protocol</param>
    /// <returns>The bool</returns>
    public static bool RegisterProtocolInOverlayBrowser(string protocol)
    {
        return GetInstance().Call(Methods.RegisterProtocolInOverlayBrowser, protocol).AsBool();
    }

    /// <summary>
    /// The overlay to store flag enum
    /// </summary>
    public enum OverlayToStoreFlag : long
    {
        /// <summary>
        /// The none overlay to store flag
        /// </summary>
        None = 0,
        /// <summary>
        /// The add to cart overlay to store flag
        /// </summary>
        AddToCart = 1,
        /// <summary>
        /// The and to cart and show overlay to store flag
        /// </summary>
        AndToCartAndShow = 2
    }

    /// <summary>
    /// The overlay to web page mode enum
    /// </summary>
    public enum OverlayToWebPageMode : long
    {
        /// <summary>
        /// The default overlay to web page mode
        /// </summary>
        Default = 0,
        /// <summary>
        /// The modal overlay to web page mode
        /// </summary>
        Modal = 1
    }
}