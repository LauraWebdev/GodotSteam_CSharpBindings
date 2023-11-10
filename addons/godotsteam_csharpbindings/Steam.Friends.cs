using System;
using System.Collections.Generic;
using System.Linq;
using Godot;
using Godot.Collections;
using Godot.NativeInterop;

namespace GodotSteam;

public static partial class Steam
{
    public static void ActivateGameOverlay(GameOverlayType type)
    {
        GetInstance().Call(Methods.ActivateGameOverlay, type.ToGodotSteam());
    }
    
    public static void ActivateGameOverlayInviteDialog(ulong steamId)
    {
        GetInstance().Call(Methods.ActivateGameOverlayInviteDialog, steamId);
    }
    
    public static void ActivateGameOverlayInviteDialogConnectString(string connectString)
    {
        GetInstance().Call(Methods.ActivateGameOverlayInviteDialogConnectString, connectString);
    }
    
    public static void ActivateGameOverlayToStore(long appId = 0)
    {
        GetInstance().Call(Methods.ActivateGameOverlayToStore, appId);
    }
    
    public static void ActivateGameOverlayToUser(GameOverlayUserType type, ulong steamId = 0)
    {
        GetInstance().Call(Methods.ActivateGameOverlayToUser, type.ToGodotSteam(), steamId);
    }
    
    public static void ActivateGameOverlayToWebPage(string url)
    {
        GetInstance().Call(Methods.ActivateGameOverlayToWebPage, url);
    }
    
    public static void GetFollowerCount(ulong steamId)
    {
        GetInstance().Call(Methods.GetFollowerCount, steamId);
    }
    
    public static ulong GetFriendByIndex(int friendNumber, FriendFlags friendFlags)
    {
        return GetInstance().Call(Methods.GetFriendByIndex, friendNumber, (long)friendFlags).AsUInt64();
    }
    
    public static uint GetFriendCoplayGame(long friendId)
    {
        return GetInstance().Call(Methods.GetFriendCoplayGame, friendId).AsUInt32();
    }
    
    public static int GetFriendCoplayTime(long friendId)
    {
        return GetInstance().Call(Methods.GetFriendCoplayTime, friendId).AsInt32();
    }
    
    public static int GetFriendCount(FriendFlags friendFlags = FriendFlags.Immediate)
    {
        return GetInstance().Call(Methods.GetFriendCount, (long)friendFlags).AsInt32();
    }
    
    public static int GetFriendCountFromSource(long sourceId)
    {
        return GetInstance().Call(Methods.GetFriendCountFromSource, sourceId).AsInt32();
    }
    
    public static ulong GetFriendFromSourceByIndex(ulong sourceId, long friendNumber)
    {
        return GetInstance().Call(Methods.GetFriendFromSourceByIndex, sourceId, friendNumber).AsUInt64();
    }
    
    public static Godot.Collections.Dictionary GetFriendGamePlayed(ulong steamId)
    {
        return GetInstance().Call(Methods.GetFriendGamePlayed, steamId).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetFriendMessage(ulong friendId, long message)
    {
        return GetInstance().Call(Methods.GetFriendMessage, friendId, message).AsGodotDictionary();
    }
    
    public static string GetFriendPersonaName(ulong steamId)
    {
        return GetInstance().Call(Methods.GetFriendPersonaName, steamId).AsString();
    }
    
    public static string GetFriendPersonaNameHistory(ulong steamId, long nameHistory)
    {
        return GetInstance().Call(Methods.GetFriendPersonaNameHistory, steamId, nameHistory).AsString();
    }
    
    public static PersonaState GetFriendPersonaState(ulong steamId)
    {
        return (PersonaState)GetInstance().Call(Methods.GetFriendPersonaState, steamId).AsInt64();
    }
    
    public static FriendRelationship GetFriendRelationship(ulong steamId)
    {
        return (FriendRelationship)GetInstance().Call(Methods.GetFriendRelationship, steamId).AsInt64();
    }
    
    public static string GetFriendRichPresence(ulong friendId, string key)
    {
        return GetInstance().Call(Methods.GetFriendRichPresence, friendId, key).AsString();
    }
    
    public static int GetFriendRichPresenceKeyCount(long friendId)
    {
        return GetInstance().Call(Methods.GetFriendRichPresenceKeyCount, friendId).AsInt32();
    }
    
    public static string GetFriendRichPresenceKeyByIndex(ulong friendId, long key)
    {
        return GetInstance().Call(Methods.GetFriendRichPresenceKeyByIndex, friendId, key).AsString();
    }
    
    public static long GetFriendsGroupCount()
    {
        return GetInstance().Call(Methods.GetFriendsGroupCount).AsInt64();
    }
    
    public static short GetFriendsGroupIDByIndex(long friendGroup)
    {
        return GetInstance().Call(Methods.GetFriendsGroupIDByIndex, friendGroup).AsInt16();
    }
    
    public static int GetFriendsGroupMembersCount(long friendGroup)
    {
        return GetInstance().Call(Methods.GetFriendsGroupMembersCount, friendGroup).AsInt32();
    }
    
    public static Godot.Collections.Array GetFriendsGroupMembersList(int friendGroup, long memberCount)
    {
        return GetInstance().Call(Methods.GetFriendsGroupMembersList, friendGroup, memberCount).AsGodotArray();
    }
    
    public static string GetFriendsGroupName(long friendGroup)
    {
        return GetInstance().Call(Methods.GetFriendsGroupName, friendGroup).AsString();
    }
    
    public static int GetFriendSteamLevel(ulong steamId)
    {
        return GetInstance().Call(Methods.GetFriendSteamLevel, steamId).AsInt32();
    }
    
    public static int GetLargeFriendAvatar(ulong steamId)
    {
        return GetInstance().Call(Methods.GetLargeFriendAvatar, steamId).AsInt32();
    }
    
    public static int GetMediumFriendAvatar(ulong steamId)
    {
        return GetInstance().Call(Methods.GetMediumFriendAvatar, steamId).AsInt32();
    }
    
    public static int GetSmallFriendAvatar(ulong steamId)
    {
        return GetInstance().Call(Methods.GetSmallFriendAvatar, steamId).AsInt32();
    }
    
    public static bool ReplyToFriendMessage(ulong steamId, string message)
    {
        return GetInstance().Call(Methods.ReplyToFriendMessage, steamId, message).AsBool();
    }
    
    public static void RequestFriendRichPresence(long friendId)
    {
        GetInstance().Call(Methods.RequestFriendRichPresence, friendId);
    }
    
    public static bool SetListenForFriendsMessages(bool intercept)
    {
        return GetInstance().Call(Methods.SetListenForFriendsMessages, intercept).AsBool();
    }
    public static ulong GetCoplayFriend(long friendNumber)
    {
        return GetInstance().Call(Methods.GetCoplayFriend, friendNumber).AsUInt64();
    }
    
    public static long GetCoplayFriendCount()
    {
        return GetInstance().Call(Methods.GetCoplayFriendCount).AsInt64();
    }
    public static bool CloseClanChatWindowInSteam(long chatId)
    {
        return GetInstance().Call(Methods.CloseClanChatWindowInSteam, chatId).AsBool();
    }
    
    public static void DownloadClanActivityCounts(ulong chatId, long clansToRequest)
    {
        GetInstance().Call(Methods.DownloadClanActivityCounts, chatId, clansToRequest);
    }
    
    public static void EnumerateFollowingList(long startIndex)
    {
        GetInstance().Call(Methods.EnumerateFollowingList, startIndex);
    }
    
    public static ulong GetChatMemberByIndex(ulong clanId, long user)
    {
        return GetInstance().Call(Methods.GetChatMemberByIndex, clanId, user).AsUInt64();
    }
    
    public static Dictionary GetClanActivityCounts(long clanId)
    {
        return GetInstance().Call(Methods.GetClanActivityCounts, clanId).AsGodotDictionary();
    }
    
    public static ulong GetClanByIndex(long clan)
    {
        return GetInstance().Call(Methods.GetClanByIndex, clan).AsUInt64();
    }
    
    public static int GetClanChatMemberCount(long clanId)
    {
        return GetInstance().Call(Methods.GetClanChatMemberCount, clanId).AsInt32();
    }
    
    public static Dictionary GetClanChatMessage(ulong chatId, long message)
    {
        return GetInstance().Call(Methods.GetClanChatMessage, chatId, message).AsGodotDictionary();
    }
    
    public static long GetClanCount()
    {
        return GetInstance().Call(Methods.GetClanCount).AsInt64();
    }
    
    public static string GetClanName(long clanId)
    {
        return GetInstance().Call(Methods.GetClanName, clanId).AsString();
    }
    
    public static ulong GetClanOfficerByIndex(ulong clanId, long officer)
    {
        return GetInstance().Call(Methods.GetClanOfficerByIndex, clanId, officer).AsUInt64();
    }
    
    public static int GetClanOfficerCount(long clanId)
    {
        return GetInstance().Call(Methods.GetClanOfficerCount, clanId).AsInt32();
    }
    
    public static ulong GetClanOwner(long clanId)
    {
        return GetInstance().Call(Methods.GetClanOwner, clanId).AsUInt64();
    }
    
    public static string GetClanTag(long clanId)
    {
        return GetInstance().Call(Methods.GetClanTag, clanId).AsString();
    }
    
    public static bool IsClanChatAdmin(ulong chatId, ulong steamId)
    {
        return GetInstance().Call(Methods.IsClanChatAdmin, chatId, steamId).AsBool();
    }
    
    public static bool IsClanPublic(long clanId)
    {
        return GetInstance().Call(Methods.IsClanPublic, clanId).AsBool();
    }
    
    public static bool IsClanOfficialGameGroup(long clanId)
    {
        return GetInstance().Call(Methods.IsClanOfficialGameGroup, clanId).AsBool();
    }
    
    public static bool IsClanChatWindowOpenInSteam(long chatId)
    {
        return GetInstance().Call(Methods.IsClanChatWindowOpenInSteam, chatId).AsBool();
    }
    
    public static void JoinClanChatRoom(long clanId)
    {
        GetInstance().Call(Methods.JoinClanChatRoom, clanId);
    }
    
    public static bool LeaveClanChatRoom(long clanId)
    {
        return GetInstance().Call(Methods.LeaveClanChatRoom, clanId).AsBool();
    }
    
    public static bool OpenClanChatWindowInSteam(long chatId)
    {
        return GetInstance().Call(Methods.OpenClanChatWindowInSteam, chatId).AsBool();
    }
    
    public static void RequestClanOfficerList(long clanId)
    {
        GetInstance().Call(Methods.RequestClanOfficerList, clanId);
    }
    
    public static bool SendClanChatMessage(ulong chatId, string text)
    {
        return GetInstance().Call(Methods.SendClanChatMessage, chatId, text).AsBool();
    }
    
    public static string GetPersonaName()
    {
        return GetInstance().Call(Methods.GetPersonaName).AsString();
    }
    
    public static PersonaState GetPersonaState()
    {
        return (PersonaState)GetInstance().Call(Methods.GetPersonaState).AsInt64();
    }
    
    public static void GetPlayerAvatar(AvatarSizes size = AvatarSizes.Medium, ulong steamId = 0)
    {
        GetInstance().Call(Methods.GetPlayerAvatar, (int)size, steamId);
    }
    
    public static string GetPlayerNickname(ulong steamId)
    {
        return GetInstance().Call(Methods.GetPlayerNickname, steamId).AsString();
    }
    
    public static string GetProfileItemPropertyString(ulong steamId, CommunityProfileItemType itemType, CommunityProfileItemProperty itemProperty)
    {
        return GetInstance().Call(Methods.GetProfileItemPropertyString, steamId, (long)itemType, (long)itemProperty).AsString();
    }
    
    public static uint GetProfileItemPropertyInt(ulong steamId, CommunityProfileItemType itemType, CommunityProfileItemProperty itemProperty)
    {
        return GetInstance().Call(Methods.GetProfileItemPropertyInt, steamId, (long)itemType, (long)itemProperty).AsUInt32();
    }
    
    public static Godot.Collections.Array GetRecentPlayers()
    {
        return GetInstance().Call(Methods.GetRecentPlayers).AsGodotArray();
    }
    
    public static Godot.Collections.Array GetUserFriendsGroups()
    {
        return GetInstance().Call(Methods.GetUserFriendsGroups).AsGodotArray();
    }
    
    public static long GetUserRestrictions()
    {
        return GetInstance().Call(Methods.GetUserRestrictions).AsInt64();
    }
    
    public static List<Friend> GetUserSteamFriends()
    {
        var rawFriends = GetInstance().Call(Methods.GetUserSteamFriends).AsGodotArray();

        return rawFriends.Select(
            rawFriend => rawFriend.AsGodotDictionary()).Select(
            friendDictionary => new Friend
            {
                Id = friendDictionary["id"].AsUInt64(),
                Name = friendDictionary["name"].AsString(),
                Status = (PersonaState)friendDictionary["status"].AsInt32(),
            })
        .ToList();
    }
    
    public static Godot.Collections.Array GetUserSteamGroups()
    {
        return GetInstance().Call(Methods.GetUserSteamGroups).AsGodotArray();
    }
    
    public static bool HasEquippedProfileItem(ulong steamId, CommunityProfileItemType itemType)
    {
        return GetInstance().Call(Methods.HasEquippedProfileItem, steamId, (long)itemType).AsBool();
    }
    
    public static bool HasFriend(ulong steamId, FriendFlags friendFlags)
    {
        return GetInstance().Call(Methods.HasFriend, steamId, (long)friendFlags).AsBool();
    }
    
    public static bool InviteUserToGame(ulong friendId, string connectString)
    {
        return GetInstance().Call(Methods.InviteUserToGame, friendId, connectString).AsBool();
    }
    
    public static void IsFollowing(ulong steamId)
    {
        GetInstance().Call(Methods.IsFollowing, steamId);
    }
    
    public static bool IsUserInSource(ulong steamId, long sourceId)
    {
        return GetInstance().Call(Methods.IsUserInSource, steamId, sourceId).AsBool();
    }
    
    public static void RequestEquippedProfileItems(ulong steamId)
    {
        GetInstance().Call(Methods.RequestEquippedProfileItems, steamId);
    }
    
    public static bool RequestUserInformation(ulong steamId, bool requireNameOnly)
    {
        return GetInstance().Call(Methods.RequestUserInformation, steamId, requireNameOnly).AsBool();
    }
    
    public static void SetPersonaName(string name)
    {
        GetInstance().Call(Methods.SetPersonaName, name);
    }
    
    public static void SetPlayedWith(ulong steamId)
    {
        GetInstance().Call(Methods.SetPlayedWith, steamId);
    }
    
    public static bool SetRichPresence(RichPresenceKey key, string value)
    {
        return GetInstance().Call(Methods.SetRichPresence, key.ToGodotSteam(), value).AsBool();
    }
    public static void SetInGameVoiceSpeaking(ulong steamId, bool speaking)
    {
        GetInstance().Call(Methods.SetInGameVoiceSpeaking, steamId, speaking);
    }
    
    public static void ClearRichPresence()
    {
        GetInstance().Call(Methods.ClearRichPresence);
    }
    
    public static bool RegisterProtocolInOverlayBrowser(string protocol)
    {
        return GetInstance().Call(Methods.RegisterProtocolInOverlayBrowser, protocol).AsBool();
    }

    public enum AvatarSizes
    {
        Small = 1,
        Medium = 2,
        Large = 3
    }

    public enum FriendRelationship : long
    {
        None = 0,
        Blocked = 1,
        RequestRecipient = 2,
        Friend = 3,
        RequestInitiator = 4,
        Ignored = 5,
        IgnoredFriend = 6,
        Suggested = 7,
        Max = 8
    }

    public enum CommunityProfileItemType : long
    {
        AnimatedAvatar = 0,
        AvatarFrame = 1,
        ProfileModifier = 2,
        ProfileBackground = 3,
        MiniProfileBackground = 4
    }

    public enum CommunityProfileItemProperty : long
    {
        ImageSmall = 0,
        ImageLarge = 1,
        InternalName = 2,
        Title = 3,
        Description = 4,
        AppId = 5,
        TypeId = 6,
        Class = 7,
        MovieWebm = 8,
        MovieMp4 = 9,
        MovieWebmSmall = 10,
        MovieMp4Small = 11
    }

    [System.Flags]
    public enum FriendFlags : long
    {
        None = 0,
        Blocked = 1,
        FriendshipRequested = 2,
        Immediate = 4,
        ClanMember = 8,
        OnGameServer = 16,
        RequestingFriendship = 128,
        RequestingInfo = 256,
        Ignored = 512,
        IgnoredFriend = 1024,
        ChatMember = 4096,
        All = 65535
    }

    [System.Flags]
    public enum UserRestriction : long
    {
        None = 0,
        Unknown = 1,
        AnyChat = 2,
        VoiceChat = 4,
        GroupChat = 8,
        Rating = 16,
        GameInvites = 32,
        Trading = 64
    }

    public enum OverlayToStoreFlag : long
    {
        None = 0,
        AddToCart = 1,
        AndToCartAndShow = 2
    }

    public enum OverlayToWebPageMode : long
    {
        Default = 0,
        Modal = 1
    }

    public enum PersonaState
    {
        Offline = 0,
        Online = 1,
        Busy = 2,
        Away = 3,
        Snooze = 4,
        LookingToTrade = 5,
        LookingToPlay = 6,
        Invisible = 7,
        Max = 8
    }

    [System.Flags]
    public enum PersonaChange : long
    {
        Name = 1,
        Status = 2,
        ComeOnline = 4,
        GoneOffline = 8,
        GamePlayed = 16,
        GameServer = 32,
        Avatar = 64,
        JoinedSource = 128,
        LeftSource = 256,
        RelationshipChanged = 512,
        NameFirstSet = 1024,
        FacebookInfo = 2048,
        Nickname = 4096,
        SteamLevel = 8192,
        RichPresence = 16384
    }
}