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
    
    public static void ActivateGameOverlayToStore(uint appId = 0)
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
    
    public static ulong GetFriendByIndex(int friendNumber, FriendFlag friendFlags)
    {
        return GetInstance().Call(Methods.GetFriendByIndex, friendNumber, (int)friendFlags).AsUInt64();
    }
    
    public static uint GetFriendCoplayGame(ulong friendId)
    {
        return GetInstance().Call(Methods.GetFriendCoplayGame, friendId).AsUInt32();
    }
    
    public static int GetFriendCoplayTime(ulong friendId)
    {
        return GetInstance().Call(Methods.GetFriendCoplayTime, friendId).AsInt32();
    }
    
    public static int GetFriendCount(FriendFlag friendFlags = FriendFlag.Immediate)
    {
        return GetInstance().Call(Methods.GetFriendCount, (int)friendFlags).AsInt32();
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
    
    public static int GetFriendRichPresenceKeyCount(ulong friendId)
    {
        return GetInstance().Call(Methods.GetFriendRichPresenceKeyCount, friendId).AsInt32();
    }
    
    public static string GetFriendRichPresenceKeyByIndex(ulong friendId, int key)
    {
        return GetInstance().Call(Methods.GetFriendRichPresenceKeyByIndex, friendId, key).AsString();
    }
    
    public static int GetFriendsGroupCount()
    {
        return GetInstance().Call(Methods.GetFriendsGroupCount).AsInt32();
    }
    
    public static short GetFriendsGroupIDByIndex(short friendGroup)
    {
        return GetInstance().Call(Methods.GetFriendsGroupIDByIndex, friendGroup).AsInt16();
    }
    
    public static int GetFriendsGroupMembersCount(short friendGroup)
    {
        return GetInstance().Call(Methods.GetFriendsGroupMembersCount, friendGroup).AsInt32();
    }
    
    public static List<ulong> GetFriendsGroupMembersList(short friendGroup, long memberCount)
    {
        var raw = GetInstance().Call(Methods.GetFriendsGroupMembersList, friendGroup, memberCount).AsGodotArray();
        
        return raw.Select(x => x.AsUInt64()).ToList();
    }
    
    public static string GetFriendsGroupName(short friendGroup)
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
    
    public static void RequestFriendRichPresence(ulong friendId)
    {
        GetInstance().Call(Methods.RequestFriendRichPresence, friendId);
    }
    
    public static bool SetListenForFriendsMessages(bool intercept)
    {
        return GetInstance().Call(Methods.SetListenForFriendsMessages, intercept).AsBool();
    }
    public static ulong GetCoplayFriend(int friendNumber)
    {
        return GetInstance().Call(Methods.GetCoplayFriend, friendNumber).AsUInt64();
    }
    
    public static int GetCoplayFriendCount()
    {
        return GetInstance().Call(Methods.GetCoplayFriendCount).AsInt32();
    }
    public static bool CloseClanChatWindowInSteam(ulong chatId)
    {
        return GetInstance().Call(Methods.CloseClanChatWindowInSteam, chatId).AsBool();
    }
    
    public static void DownloadClanActivityCounts(ulong chatId, int clansToRequest)
    {
        GetInstance().Call(Methods.DownloadClanActivityCounts, chatId, clansToRequest);
    }
    
    public static void EnumerateFollowingList(uint startIndex)
    {
        GetInstance().Call(Methods.EnumerateFollowingList, startIndex);
    }
    
    public static ulong GetChatMemberByIndex(ulong clanId, long user)
    {
        return GetInstance().Call(Methods.GetChatMemberByIndex, clanId, user).AsUInt64();
    }
    
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
    
    public static ulong GetClanByIndex(int clan)
    {
        return GetInstance().Call(Methods.GetClanByIndex, clan).AsUInt64();
    }
    
    public static int GetClanChatMemberCount(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanChatMemberCount, clanId).AsInt32();
    }
    
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
    
    public static int GetClanCount()
    {
        return GetInstance().Call(Methods.GetClanCount).AsInt32();
    }
    
    public static string GetClanName(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanName, clanId).AsString();
    }
    
    public static ulong GetClanOfficerByIndex(ulong clanId, int officer)
    {
        return GetInstance().Call(Methods.GetClanOfficerByIndex, clanId, officer).AsUInt64();
    }
    
    public static int GetClanOfficerCount(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanOfficerCount, clanId).AsInt32();
    }
    
    public static ulong GetClanOwner(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanOwner, clanId).AsUInt64();
    }
    
    public static string GetClanTag(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanTag, clanId).AsString();
    }
    
    public static bool IsClanChatAdmin(ulong chatId, ulong steamId)
    {
        return GetInstance().Call(Methods.IsClanChatAdmin, chatId, steamId).AsBool();
    }
    
    public static bool IsClanPublic(ulong clanId)
    {
        return GetInstance().Call(Methods.IsClanPublic, clanId).AsBool();
    }
    
    public static bool IsClanOfficialGameGroup(ulong clanId)
    {
        return GetInstance().Call(Methods.IsClanOfficialGameGroup, clanId).AsBool();
    }
    
    public static bool IsClanChatWindowOpenInSteam(ulong chatId)
    {
        return GetInstance().Call(Methods.IsClanChatWindowOpenInSteam, chatId).AsBool();
    }
    
    public static void JoinClanChatRoom(ulong clanId)
    {
        GetInstance().Call(Methods.JoinClanChatRoom, clanId);
    }
    
    public static bool LeaveClanChatRoom(ulong clanId)
    {
        return GetInstance().Call(Methods.LeaveClanChatRoom, clanId).AsBool();
    }
    
    public static bool OpenClanChatWindowInSteam(ulong chatId)
    {
        return GetInstance().Call(Methods.OpenClanChatWindowInSteam, chatId).AsBool();
    }
    
    public static void RequestClanOfficerList(ulong clanId)
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
    
    public static void GetPlayerAvatar(AvatarSize size = AvatarSize.Medium, ulong steamId = 0)
    {
        GetInstance().Call(Methods.GetPlayerAvatar, (int)size, steamId);
    }
    
    public static string GetPlayerNickname(ulong steamId)
    {
        return GetInstance().Call(Methods.GetPlayerNickname, steamId).AsString();
    }
    
    public static string GetProfileItemPropertyString(ulong steamId, CommunityProfileItemType itemType, CommunityProfileItemProperty itemProperty)
    {
        return GetInstance().Call(Methods.GetProfileItemPropertyString, steamId, (int)itemType, (int)itemProperty).AsString();
    }
    
    public static uint GetProfileItemPropertyInt(ulong steamId, CommunityProfileItemType itemType, CommunityProfileItemProperty itemProperty)
    {
        return GetInstance().Call(Methods.GetProfileItemPropertyInt, steamId, (int)itemType, (int)itemProperty).AsUInt32();
    }
    
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
    
    public static UserRestriction GetUserRestrictions()
    {
        return (UserRestriction)GetInstance().Call(Methods.GetUserRestrictions).AsUInt32();
    }
    
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
    
    public static bool HasEquippedProfileItem(ulong steamId, CommunityProfileItemType itemType)
    {
        return GetInstance().Call(Methods.HasEquippedProfileItem, steamId, (long)itemType).AsBool();
    }
    
    public static bool HasFriend(ulong steamId, FriendFlag friendFlags)
    {
        return GetInstance().Call(Methods.HasFriend, steamId, (int)friendFlags).AsBool();
    }
    
    public static bool InviteUserToGame(ulong friendId, string connectString)
    {
        return GetInstance().Call(Methods.InviteUserToGame, friendId, connectString).AsBool();
    }
    
    public static void IsFollowing(ulong steamId)
    {
        GetInstance().Call(Methods.IsFollowing, steamId);
    }
    
    public static bool IsUserInSource(ulong steamId, ulong sourceId)
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
    
    public static bool SetRichPresence(string richPresenceKey, string value)
    {
        return GetInstance().Call(Methods.SetRichPresence, richPresenceKey, value).AsBool();
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
}