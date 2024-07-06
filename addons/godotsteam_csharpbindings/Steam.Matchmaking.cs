namespace GodotSteam;

public static partial class Steam
{
    public static Godot.Collections.Array GetFavoriteGames()
    {
        return GetInstance().Call(Methods.GetFavoriteGames).AsGodotArray();
    }
    
    public static int AddFavoriteGame(uint iP, int port, int queryPort, uint flags, long lastPlayed)
    {
        return GetInstance().Call(Methods.AddFavoriteGame, iP, port, queryPort, flags, lastPlayed).As<int>();
    }
    
    public static bool RemoveFavoriteGame(uint appId, uint iP, int port, int queryPort, long flags)
    {
        return GetInstance().Call(Methods.RemoveFavoriteGame, appId, iP, port, queryPort, flags).As<bool>();
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
    
    public static void JoinLobby(ulong steamLobbyId)
    {
        GetInstance().Call(Methods.JoinLobby, steamLobbyId);
    }
    
    public static void LeaveLobby(ulong steamLobbyId)
    {
        GetInstance().Call(Methods.LeaveLobby, steamLobbyId);
    }
    
    public static bool InviteUserToLobby(ulong steamLobbyId, ulong steamIdInvitee)
    {
        return GetInstance().Call(Methods.InviteUserToLobby, steamLobbyId, steamIdInvitee).As<bool>();
    }
    
    public static int GetNumLobbyMembers(ulong steamLobbyId)
    {
        return GetInstance().Call(Methods.GetNumLobbyMembers, steamLobbyId).As<int>();
    }
    
    public static ulong GetLobbyMemberByIndex(ulong steamLobbyId, long member)
    {
        return GetInstance().Call(Methods.GetLobbyMemberByIndex, steamLobbyId, member).As<ulong>();
    }
    
    public static string GetLobbyData(ulong steamLobbyId, string key)
    {
        return GetInstance().Call(Methods.GetLobbyData, steamLobbyId, key).As<string>();
    }
    
    public static bool SetLobbyData(ulong steamLobbyId, string key, string value)
    {
        return GetInstance().Call(Methods.SetLobbyData, steamLobbyId, key, value).As<bool>();
    }
    
    public static Godot.Collections.Dictionary GetAllLobbyData(ulong steamLobbyId)
    {
        return GetInstance().Call(Methods.GetAllLobbyData, steamLobbyId).AsGodotDictionary();
    }
    
    public static bool DeleteLobbyData(ulong steamLobbyId, string key)
    {
        return GetInstance().Call(Methods.DeleteLobbyData, steamLobbyId, key).As<bool>();
    }
    
    public static string GetLobbyMemberData(ulong steamLobbyId, ulong steamIdUser, string key)
    {
        return GetInstance().Call(Methods.GetLobbyMemberData, steamLobbyId, steamIdUser, key).As<string>();
    }
    
    public static void SetLobbyMemberData(ulong steamLobbyId, string key, string value)
    {
        GetInstance().Call(Methods.SetLobbyMemberData, steamLobbyId, key, value);
    }
    
    public static bool SendLobbyChatMsg(ulong steamLobbyId, string messageBody)
    {
        return GetInstance().Call(Methods.SendLobbyChatMsg, steamLobbyId, messageBody).As<bool>();
    }
    
    public static bool RequestLobbyData(ulong steamLobbyId)
    {
        return GetInstance().Call(Methods.RequestLobbyData, steamLobbyId).As<bool>();
    }
    
    public static void SetLobbyGameServer(ulong steamLobbyId, string serverIP, int serverPort, ulong steamIdGameServer)
    {
        GetInstance().Call(Methods.SetLobbyGameServer, steamLobbyId, serverIP, serverPort, steamIdGameServer);
    }
    
    public static Godot.Collections.Dictionary GetLobbyGameServer(ulong steamLobbyId)
    {
        return GetInstance().Call(Methods.GetLobbyGameServer, steamLobbyId).AsGodotDictionary();
    }
    
    public static bool SetLobbyMemberLimit(ulong steamLobbyId, long maxMembers)
    {
        return GetInstance().Call(Methods.SetLobbyMemberLimit, steamLobbyId, maxMembers).As<bool>();
    }
    
    public static int GetLobbyMemberLimit(ulong steamLobbyId)
    {
        return GetInstance().Call(Methods.GetLobbyMemberLimit, steamLobbyId).As<int>();
    }
    
    public static bool SetLobbyType(ulong steamLobbyId, LobbyType lobbyType)
    {
        return GetInstance().Call(Methods.SetLobbyType, steamLobbyId, (long)lobbyType).As<bool>();
    }
    
    public static bool SetLobbyJoinable(ulong steamLobbyId, bool joinable)
    {
        return GetInstance().Call(Methods.SetLobbyJoinable, steamLobbyId, joinable).As<bool>();
    }
    
    public static ulong GetLobbyOwner(ulong steamLobbyId)
    {
        return GetInstance().Call(Methods.GetLobbyOwner, steamLobbyId).As<ulong>();
    }
    
    public static bool SetLobbyOwner(ulong steamLobbyId, ulong steamIdNewOwner)
    {
        return GetInstance().Call(Methods.SetLobbyOwner, steamLobbyId, steamIdNewOwner).As<bool>();
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
        LobbyComparisonEqualToGreaterThan = 2,
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