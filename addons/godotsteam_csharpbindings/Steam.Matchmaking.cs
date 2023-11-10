namespace GodotSteam;

public static partial class Steam
{
    public static Godot.Collections.Array GetFavoriteGames()
    {
        return GetInstance().Call(Methods.GetFavoriteGames).AsGodotArray();
    }
    
    public static int AddFavoriteGame(uint iP, int port, int queryPort, uint flags, long lastPlayed)
    {
        return GetInstance().Call(Methods.AddFavoriteGame, iP, port, queryPort, flags, lastPlayed).AsInt32();
    }
    
    public static bool RemoveFavoriteGame(uint appId, uint iP, int port, int queryPort, long flags)
    {
        return GetInstance().Call(Methods.RemoveFavoriteGame, appId, iP, port, queryPort, flags).AsBool();
    }
    
    public static void RequestLobbyList()
    { 
        GetInstance().Call(Methods.RequestLobbyList);
    }
    
    public static void AddRequestLobbyListStringFilter(string keyToMatch, string valueToMatch, LobbyComparison comparisonType)
    {
        GetInstance().Call(Methods.AddRequestLobbyListStringFilter, keyToMatch, valueToMatch, (long)comparisonType);
    }
    
    public static void AddRequestLobbyListNumericalFilter(string keyToMatch, int valueToMatch, LobbyComparison comparisonType)
    {
        GetInstance().Call(Methods.AddRequestLobbyListNumericalFilter, keyToMatch, valueToMatch, (long)comparisonType);
    }
    
    public static void AddRequestLobbyListNearValueFilter(string keyToMatch, long valueToBeCloseTo)
    {
        GetInstance().Call(Methods.AddRequestLobbyListNearValueFilter, keyToMatch, valueToBeCloseTo);
    }
    
    public static void AddRequestLobbyListFilterSlotsAvailable(long slotsAvailable)
    {
        GetInstance().Call(Methods.AddRequestLobbyListFilterSlotsAvailable, slotsAvailable);
    }
    
    public static void AddRequestLobbyListDistanceFilter(LobbyDistanceFilter distanceFilter)
    {
        GetInstance().Call(Methods.AddRequestLobbyListDistanceFilter, (long)distanceFilter);
    }
    
    public static void AddRequestLobbyListResultCountFilter(long maxResults)
    {
        GetInstance().Call(Methods.AddRequestLobbyListResultCountFilter, maxResults);
    }
    
    public static void CreateLobby(LobbyType lobbyType, long maxMembers = 2)
    {
        GetInstance().Call(Methods.CreateLobby, (long)lobbyType, maxMembers);
    }
    
    public static void JoinLobby(long steamLobbyId)
    {
        GetInstance().Call(Methods.JoinLobby, steamLobbyId);
    }
    
    public static void LeaveLobby(long steamLobbyId)
    {
        GetInstance().Call(Methods.LeaveLobby, steamLobbyId);
    }
    
    public static bool InviteUserToLobby(ulong steamLobbyId, ulong steamIdInvitee)
    {
        return GetInstance().Call(Methods.InviteUserToLobby, steamLobbyId, steamIdInvitee).AsBool();
    }
    
    public static int GetNumLobbyMembers(long steamLobbyId)
    {
        return GetInstance().Call(Methods.GetNumLobbyMembers, steamLobbyId).AsInt32();
    }
    
    public static ulong GetLobbyMemberByIndex(ulong steamLobbyId, long member)
    {
        return GetInstance().Call(Methods.GetLobbyMemberByIndex, steamLobbyId, member).AsUInt64();
    }
    
    public static string GetLobbyData(ulong steamLobbyId, string key)
    {
        return GetInstance().Call(Methods.GetLobbyData, steamLobbyId, key).AsString();
    }
    
    public static bool SetLobbyData(ulong steamLobbyId, string key, string value)
    {
        return GetInstance().Call(Methods.SetLobbyData, steamLobbyId, key, value).AsBool();
    }
    
    public static Godot.Collections.Dictionary GetAllLobbyData(long steamLobbyId)
    {
        return GetInstance().Call(Methods.GetAllLobbyData, steamLobbyId).AsGodotDictionary();
    }
    
    public static bool DeleteLobbyData(ulong steamLobbyId, string key)
    {
        return GetInstance().Call(Methods.DeleteLobbyData, steamLobbyId, key).AsBool();
    }
    
    public static string GetLobbyMemberData(ulong steamLobbyId, ulong steamIdUser, string key)
    {
        return GetInstance().Call(Methods.GetLobbyMemberData, steamLobbyId, steamIdUser, key).AsString();
    }
    
    public static void SetLobbyMemberData(ulong steamLobbyId, string key, string value)
    {
        GetInstance().Call(Methods.SetLobbyMemberData, steamLobbyId, key, value);
    }
    
    public static bool SendLobbyChatMsg(ulong steamLobbyId, string messageBody)
    {
        return GetInstance().Call(Methods.SendLobbyChatMsg, steamLobbyId, messageBody).AsBool();
    }
    
    public static bool RequestLobbyData(long steamLobbyId)
    {
        return GetInstance().Call(Methods.RequestLobbyData, steamLobbyId).AsBool();
    }
    
    public static void SetLobbyGameServer(ulong steamLobbyId, string serverIP, int serverPort, ulong steamIdGameServer)
    {
        GetInstance().Call(Methods.SetLobbyGameServer, steamLobbyId, serverIP, serverPort, steamIdGameServer);
    }
    
    public static Godot.Collections.Dictionary GetLobbyGameServer(long steamLobbyId)
    {
        return GetInstance().Call(Methods.GetLobbyGameServer, steamLobbyId).AsGodotDictionary();
    }
    
    public static bool SetLobbyMemberLimit(ulong steamLobbyId, long maxMembers)
    {
        return GetInstance().Call(Methods.SetLobbyMemberLimit, steamLobbyId, maxMembers).AsBool();
    }
    
    public static int GetLobbyMemberLimit(long steamLobbyId)
    {
        return GetInstance().Call(Methods.GetLobbyMemberLimit, steamLobbyId).AsInt32();
    }
    
    public static bool SetLobbyType(ulong steamLobbyId, LobbyType lobbyType)
    {
        return GetInstance().Call(Methods.SetLobbyType, steamLobbyId, (long)lobbyType).AsBool();
    }
    
    public static bool SetLobbyJoinable(ulong steamLobbyId, bool joinable)
    {
        return GetInstance().Call(Methods.SetLobbyJoinable, steamLobbyId, joinable).AsBool();
    }
    
    public static ulong GetLobbyOwner(long steamLobbyId)
    {
        return GetInstance().Call(Methods.GetLobbyOwner, steamLobbyId).AsUInt64();
    }
    
    public static bool SetLobbyOwner(ulong steamLobbyId, ulong steamIdNewOwner)
    {
        return GetInstance().Call(Methods.SetLobbyOwner, steamLobbyId, steamIdNewOwner).AsBool();
    }

    [System.Flags]
    public enum ChatMemberStateChange : long
    {
        Entered = 1,
        Left = 2,
        Disconnected = 4,
        Kicked = 8,
        Banned = 16
    }

    public enum LobbyComparison : long
    {
        LobbyComparisonEqualToOrLessThan = -2,
        LobbyComparisonLessThan = -1,
        LobbyComparisonEqual = 0,
        LobbyComparisonGreaterThan = 1,
        ObbyComparisonEqualToGreaterThan = 2,
        LobbyComparisonNotEqual = 3
    }

    public enum LobbyDistanceFilter : long
    {
        Close = 0,
        Default = 1,
        Far = 2,
        Worldwide = 3
    }

    public enum LobbyType : long
    {
        Private = 0,
        FriendsOnly = 1,
        Public = 2,
        Invisible = 3,
        PrivateUnique = 4
    }
}