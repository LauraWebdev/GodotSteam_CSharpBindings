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
        return GetInstance().Call(Methods.GetFriendByIndex, (int)friendNumber, (int)friendFlags).As<ulong>();
    }
    
    public static uint GetFriendCoplayGame(ulong friendId)
    {
        return GetInstance().Call(Methods.GetFriendCoplayGame, friendId).As<uint>();
    }
    
    public static int GetFriendCoplayTime(ulong friendId)
    {
        return GetInstance().Call(Methods.GetFriendCoplayTime, friendId).As<int>();
    }
    
    public static int GetFriendCount(FriendFlag friendFlags = FriendFlag.Immediate)
    {
        return GetInstance().Call(Methods.GetFriendCount, (int)friendFlags).As<int>();
    }
    
    public static int GetFriendCountFromSource(ulong sourceId)
    {
        return GetInstance().Call(Methods.GetFriendCountFromSource, sourceId).As<int>();
    }
    
    public static ulong GetFriendFromSourceByIndex(ulong sourceId, int friendNumber)
    {
        return GetInstance().Call(Methods.GetFriendFromSourceByIndex, sourceId, friendNumber).As<ulong>();
    }
    
    public static FriendGame? GetFriendGamePlayed(ulong steamId)
    {
        var raw = GetInstance().Call(Methods.GetFriendGamePlayed, steamId).AsGodotDictionary();
        
        if (!raw.ContainsKey("game_port") || !raw.ContainsKey("id") || !raw.ContainsKey("ip") || !raw.ContainsKey("lobby") || raw["lobby"].As<string>() == "No valid lobby" || !raw.ContainsKey("query_port"))
        {
            return null;
        }
        
        return new FriendGame
        {
            GamePort = raw["game_port"].As<ushort>(),
            Id = raw["id"].As<int>(),
            Ip = raw["ip"].As<string>(),
            Lobby = raw["lobby"].As<ulong>(),
            QueryPort = raw["query_port"].As<ushort>(),
        };
    }
    
    public static FriendMessage? GetFriendMessage(ulong friendId, int message)
    {
        var raw = GetInstance().Call(Methods.GetFriendMessage, friendId, message).AsGodotDictionary();
        
        if (!raw.ContainsKey("ret") || !raw.ContainsKey("text") || !raw.ContainsKey("type"))
        {
            return null;
        }
        
        return new FriendMessage
        {
            Ret = raw["ret"].As<int>(),
            Text = raw["text"].As<string>(),
            Type = raw["type"].As<ChatEntryType>(),
        };
    }
    
    public static string GetFriendPersonaName(ulong steamId)
    {
        return GetInstance().Call(Methods.GetFriendPersonaName, steamId).As<string>();
    }
    
    public static string GetFriendPersonaNameHistory(ulong steamId, int nameHistory)
    {
        return GetInstance().Call(Methods.GetFriendPersonaNameHistory, steamId, nameHistory).As<string>();
    }
    
    public static PersonaState GetFriendPersonaState(ulong steamId)
    {
        return GetInstance().Call(Methods.GetFriendPersonaState, steamId).As<PersonaState>();
    }
    
    public static FriendRelationship GetFriendRelationship(ulong steamId)
    {
        return GetInstance().Call(Methods.GetFriendRelationship, steamId).As<FriendRelationship>();
    }
    
    public static string GetFriendRichPresence(ulong friendId, string key)
    {
        return GetInstance().Call(Methods.GetFriendRichPresence, friendId, key).As<string>();
    }
    
    public static int GetFriendRichPresenceKeyCount(ulong friendId)
    {
        return GetInstance().Call(Methods.GetFriendRichPresenceKeyCount, friendId).As<int>();
    }
    
    public static string GetFriendRichPresenceKeyByIndex(ulong friendId, int key)
    {
        return GetInstance().Call(Methods.GetFriendRichPresenceKeyByIndex, friendId, key).As<string>();
    }
    
    public static int GetFriendsGroupCount()
    {
        return GetInstance().Call(Methods.GetFriendsGroupCount).As<int>();
    }
    
    public static short GetFriendsGroupIDByIndex(short friendGroup)
    {
        return GetInstance().Call(Methods.GetFriendsGroupIDByIndex, friendGroup).AsInt16();
    }
    
    public static int GetFriendsGroupMembersCount(short friendGroup)
    {
        return GetInstance().Call(Methods.GetFriendsGroupMembersCount, friendGroup).As<int>();
    }
    
    public static List<ulong> GetFriendsGroupMembersList(short friendGroup, int memberCount)
    {
        var raw = GetInstance().Call(Methods.GetFriendsGroupMembersList, friendGroup, memberCount).AsGodotArray();
        
        return raw.Select(x => x.As<ulong>()).ToList();
    }
    
    public static string GetFriendsGroupName(short friendGroup)
    {
        return GetInstance().Call(Methods.GetFriendsGroupName, friendGroup).As<string>();
    }
    
    public static int GetFriendSteamLevel(ulong steamId)
    {
        return GetInstance().Call(Methods.GetFriendSteamLevel, steamId).As<int>();
    }
    
    public static int GetLargeFriendAvatar(ulong steamId)
    {
        return GetInstance().Call(Methods.GetLargeFriendAvatar, steamId).As<int>();
    }
    
    public static int GetMediumFriendAvatar(ulong steamId)
    {
        return GetInstance().Call(Methods.GetMediumFriendAvatar, steamId).As<int>();
    }
    
    public static int GetSmallFriendAvatar(ulong steamId)
    {
        return GetInstance().Call(Methods.GetSmallFriendAvatar, steamId).As<int>();
    }
    
    public static bool ReplyToFriendMessage(ulong steamId, string message)
    {
        return GetInstance().Call(Methods.ReplyToFriendMessage, steamId, message).As<bool>();
    }
    
    public static void RequestFriendRichPresence(ulong friendId)
    {
        GetInstance().Call(Methods.RequestFriendRichPresence, friendId);
    }
    
    public static bool SetListenForFriendsMessages(bool intercept)
    {
        return GetInstance().Call(Methods.SetListenForFriendsMessages, intercept).As<bool>();
    }
    public static ulong GetCoplayFriend(int friendNumber)
    {
        return GetInstance().Call(Methods.GetCoplayFriend, friendNumber).As<ulong>();
    }
    
    public static int GetCoplayFriendCount()
    {
        return GetInstance().Call(Methods.GetCoplayFriendCount).As<int>();
    }
    public static bool CloseClanChatWindowInSteam(ulong chatId)
    {
        return GetInstance().Call(Methods.CloseClanChatWindowInSteam, chatId).As<bool>();
    }
    
    public static void DownloadClanActivityCounts(ulong chatId, int clansToRequest)
    {
        GetInstance().Call(Methods.DownloadClanActivityCounts, chatId, clansToRequest);
    }
    
    public static void EnumerateFollowingList(uint startIndex)
    {
        GetInstance().Call(Methods.EnumerateFollowingList, startIndex);
    }
    
    public static ulong GetChatMemberByIndex(ulong clanId, int user)
    {
        return GetInstance().Call(Methods.GetChatMemberByIndex, clanId, user).As<ulong>();
    }
    
    public static ClanActivityCounts? GetClanActivityCounts(ulong clanId)
    {
        var raw = GetInstance().Call(Methods.GetClanActivityCounts, clanId).AsGodotDictionary();

        if (!raw.ContainsKey("clan") || !raw.ContainsKey("online") || !raw.ContainsKey("ingame") || !raw.ContainsKey("chatting"))
        {
            return null;
        }

        return new ClanActivityCounts
        {
            Clan = raw["clan"].As<ulong>(),
            Online = raw["online"].As<int>(),
            Ingame = raw["ingame"].As<int>(),
            Chatting = raw["chatting"].As<int>(),
        };
    }
    
    public static ulong GetClanByIndex(int clan)
    {
        return GetInstance().Call(Methods.GetClanByIndex, clan).As<ulong>();
    }
    
    public static int GetClanChatMemberCount(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanChatMemberCount, clanId).As<int>();
    }
    
    public static ClanChatMessage? GetClanChatMessage(ulong chatId, long message)
    {
        var raw = GetInstance().Call(Methods.GetClanChatMessage, chatId, message).AsGodotDictionary();

        if (!raw.ContainsKey("ret"))
        {
            return null;
        }
        
        return new ClanChatMessage
        {
            Ret = raw["ret"].As<bool>(),
            Text = raw["text"].As<string>(),
            Type = raw["type"].As<ClanChatMessageType>(),
            Chatter = raw["chatter"].As<ulong>()
        };
    }
    
    public static int GetClanCount()
    {
        return GetInstance().Call(Methods.GetClanCount).As<int>();
    }
    
    public static string GetClanName(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanName, clanId).As<string>();
    }
    
    public static ulong GetClanOfficerByIndex(ulong clanId, int officer)
    {
        return GetInstance().Call(Methods.GetClanOfficerByIndex, clanId, officer).As<ulong>();
    }
    
    public static int GetClanOfficerCount(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanOfficerCount, clanId).As<int>();
    }
    
    public static ulong GetClanOwner(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanOwner, clanId).As<ulong>();
    }
    
    public static string GetClanTag(ulong clanId)
    {
        return GetInstance().Call(Methods.GetClanTag, clanId).As<string>();
    }
    
    public static bool IsClanChatAdmin(ulong chatId, ulong steamId)
    {
        return GetInstance().Call(Methods.IsClanChatAdmin, chatId, steamId).As<bool>();
    }
    
    public static bool IsClanPublic(ulong clanId)
    {
        return GetInstance().Call(Methods.IsClanPublic, clanId).As<bool>();
    }
    
    public static bool IsClanOfficialGameGroup(ulong clanId)
    {
        return GetInstance().Call(Methods.IsClanOfficialGameGroup, clanId).As<bool>();
    }
    
    public static bool IsClanChatWindowOpenInSteam(ulong chatId)
    {
        return GetInstance().Call(Methods.IsClanChatWindowOpenInSteam, chatId).As<bool>();
    }
    
    public static void JoinClanChatRoom(ulong clanId)
    {
        GetInstance().Call(Methods.JoinClanChatRoom, clanId);
    }
    
    public static bool LeaveClanChatRoom(ulong clanId)
    {
        return GetInstance().Call(Methods.LeaveClanChatRoom, clanId).As<bool>();
    }
    
    public static bool OpenClanChatWindowInSteam(ulong chatId)
    {
        return GetInstance().Call(Methods.OpenClanChatWindowInSteam, chatId).As<bool>();
    }
    
    public static void RequestClanOfficerList(ulong clanId)
    {
        GetInstance().Call(Methods.RequestClanOfficerList, clanId);
    }
    
    public static bool SendClanChatMessage(ulong chatId, string text)
    {
        return GetInstance().Call(Methods.SendClanChatMessage, chatId, text).As<bool>();
    }
    
    public static string GetPersonaName()
    {
        return GetInstance().Call(Methods.GetPersonaName).As<string>();
    }
    
    public static PersonaState GetPersonaState()
    {
        return GetInstance().Call(Methods.GetPersonaState).As<PersonaState>();
    }
    
    public static void GetPlayerAvatar(AvatarSize size = AvatarSize.Medium, ulong steamId = 0)
    {
        GetInstance().Call(Methods.GetPlayerAvatar, (int)size, steamId);
    }
    
    public static string GetPlayerNickname(ulong steamId)
    {
        return GetInstance().Call(Methods.GetPlayerNickname, steamId).As<string>();
    }
    
    public static string GetProfileItemPropertyString(ulong steamId, CommunityProfileItemType itemType, CommunityProfileItemProperty itemProperty)
    {
        return GetInstance().Call(Methods.GetProfileItemPropertyString, steamId, (int)itemType, (int)itemProperty).As<string>();
    }
    
    public static uint GetProfileItemPropertyInt(ulong steamId, CommunityProfileItemType itemType, CommunityProfileItemProperty itemProperty)
    {
        return GetInstance().Call(Methods.GetProfileItemPropertyInt, steamId, (int)itemType, (int)itemProperty).As<uint>();
    }
    
    public static List<RecentPlayer> GetRecentPlayers()
    {
        var raw = GetInstance().Call(Methods.GetRecentPlayers).AsGodotArray();
        
        return raw.Select(
                rawPlayer => rawPlayer.AsGodotDictionary()).Select(
                playerDictionary => new RecentPlayer
                {
                    Id = playerDictionary["id"].As<ulong>(),
                    Name = playerDictionary["name"].As<string>(),
                    Time = playerDictionary["time"].As<int>(),
                    Status = playerDictionary["status"].As<PersonaState>(),
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
                    Name = friendGroupDictionary["name"].As<string>(),
                    Members = friendGroupDictionary["members"].As<int>(),
                })
            .ToList();
    }
    
    public static UserRestriction GetUserRestrictions()
    {
        return GetInstance().Call(Methods.GetUserRestrictions).As<UserRestriction>();
    }
    
    public static List<Friend> GetUserSteamFriends()
    {
        var raw = GetInstance().Call(Methods.GetUserSteamFriends).AsGodotArray();

        return raw.Select(
            rawFriend => rawFriend.AsGodotDictionary()).Select(
            friendDictionary => new Friend
            {
                Id = friendDictionary["id"].As<ulong>(),
                Name = friendDictionary["name"].As<string>(),
                Status = friendDictionary["status"].As<PersonaState>(),
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
                    Id = groupDictionary["id"].As<ulong>(),
                    Name = groupDictionary["name"].As<string>(),
                    Tag = groupDictionary["tag"].As<string>(),
                })
            .ToList();
    }
    
    public static bool HasEquippedProfileItem(ulong steamId, CommunityProfileItemType itemType)
    {
        return GetInstance().Call(Methods.HasEquippedProfileItem, steamId, (int)itemType).As<bool>();
    }
    
    public static bool HasFriend(ulong steamId, FriendFlag friendFlags)
    {
        return GetInstance().Call(Methods.HasFriend, steamId, (int)friendFlags).As<bool>();
    }
    
    public static bool InviteUserToGame(ulong friendId, string connectString)
    {
        return GetInstance().Call(Methods.InviteUserToGame, friendId, connectString).As<bool>();
    }
    
    public static void IsFollowing(ulong steamId)
    {
        GetInstance().Call(Methods.IsFollowing, steamId);
    }
    
    public static bool IsUserInSource(ulong steamId, ulong sourceId)
    {
        return GetInstance().Call(Methods.IsUserInSource, steamId, sourceId).As<bool>();
    }
    
    public static void RequestEquippedProfileItems(ulong steamId)
    {
        GetInstance().Call(Methods.RequestEquippedProfileItems, steamId);
    }
    
    public static bool RequestUserInformation(ulong steamId, bool requireNameOnly)
    {
        return GetInstance().Call(Methods.RequestUserInformation, steamId, requireNameOnly).As<bool>();
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
        return GetInstance().Call(Methods.SetRichPresence, richPresenceKey, value).As<bool>();
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
        return GetInstance().Call(Methods.RegisterProtocolInOverlayBrowser, protocol).As<bool>();
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

    public enum ChatEntryType : long
    {
        Invalid = 0,
        ChatMsg = 1,
        Typing = 2,
        InviteGame = 3,
        Emote = 4,
        LeftConversation = 6,
        Entered = 7,
        WasKicked = 8,
        WasBanned = 9,
        Disconnected = 10,
        HistoricalChat = 11,
        LinkBlocked = 14,
    }
}