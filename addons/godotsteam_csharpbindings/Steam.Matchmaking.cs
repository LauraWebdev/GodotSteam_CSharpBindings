namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Gets the favorite games
    /// </summary>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetFavoriteGames()
    {
        return GetInstance().Call(Methods.GetFavoriteGames).AsGodotArray();
    }
    
    /// <summary>
    /// Adds the favorite game using the specified i p
    /// </summary>
    /// <param name="iP">The </param>
    /// <param name="port">The port</param>
    /// <param name="queryPort">The query port</param>
    /// <param name="flags">The flags</param>
    /// <param name="lastPlayed">The last played</param>
    /// <returns>The int</returns>
    public static int AddFavoriteGame(uint iP, int port, int queryPort, uint flags, long lastPlayed)
    {
        return GetInstance().Call(Methods.AddFavoriteGame, iP, port, queryPort, flags, lastPlayed).AsInt32();
    }
    
    /// <summary>
    /// Describes whether remove favorite game
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <param name="iP">The </param>
    /// <param name="port">The port</param>
    /// <param name="queryPort">The query port</param>
    /// <param name="flags">The flags</param>
    /// <returns>The bool</returns>
    public static bool RemoveFavoriteGame(uint appId, uint iP, int port, int queryPort, long flags)
    {
        return GetInstance().Call(Methods.RemoveFavoriteGame, appId, iP, port, queryPort, flags).AsBool();
    }
    
    /// <summary>
    /// Requests the lobby list
    /// </summary>
    public static void RequestLobbyList()
    { 
        GetInstance().Call(Methods.RequestLobbyList);
    }
    
    /// <summary>
    /// Adds the request lobby list string filter using the specified key to match
    /// </summary>
    /// <param name="keyToMatch">The key to match</param>
    /// <param name="valueToMatch">The value to match</param>
    /// <param name="comparisonType">The comparison type</param>
    public static void AddRequestLobbyListStringFilter(string keyToMatch, string valueToMatch, LobbyComparison comparisonType)
    {
        GetInstance().Call(Methods.AddRequestLobbyListStringFilter, keyToMatch, valueToMatch, (long)comparisonType);
    }
    
    /// <summary>
    /// Adds the request lobby list numerical filter using the specified key to match
    /// </summary>
    /// <param name="keyToMatch">The key to match</param>
    /// <param name="valueToMatch">The value to match</param>
    /// <param name="comparisonType">The comparison type</param>
    public static void AddRequestLobbyListNumericalFilter(string keyToMatch, int valueToMatch, LobbyComparison comparisonType)
    {
        GetInstance().Call(Methods.AddRequestLobbyListNumericalFilter, keyToMatch, valueToMatch, (long)comparisonType);
    }
    
    /// <summary>
    /// Adds the request lobby list near value filter using the specified key to match
    /// </summary>
    /// <param name="keyToMatch">The key to match</param>
    /// <param name="valueToBeCloseTo">The value to be close to</param>
    public static void AddRequestLobbyListNearValueFilter(string keyToMatch, long valueToBeCloseTo)
    {
        GetInstance().Call(Methods.AddRequestLobbyListNearValueFilter, keyToMatch, valueToBeCloseTo);
    }
    
    /// <summary>
    /// Adds the request lobby list filter slots available using the specified slots available
    /// </summary>
    /// <param name="slotsAvailable">The slots available</param>
    public static void AddRequestLobbyListFilterSlotsAvailable(long slotsAvailable)
    {
        GetInstance().Call(Methods.AddRequestLobbyListFilterSlotsAvailable, slotsAvailable);
    }
    
    /// <summary>
    /// Adds the request lobby list distance filter using the specified distance filter
    /// </summary>
    /// <param name="distanceFilter">The distance filter</param>
    public static void AddRequestLobbyListDistanceFilter(LobbyDistanceFilter distanceFilter)
    {
        GetInstance().Call(Methods.AddRequestLobbyListDistanceFilter, (long)distanceFilter);
    }
    
    /// <summary>
    /// Adds the request lobby list result count filter using the specified max results
    /// </summary>
    /// <param name="maxResults">The max results</param>
    public static void AddRequestLobbyListResultCountFilter(long maxResults)
    {
        GetInstance().Call(Methods.AddRequestLobbyListResultCountFilter, maxResults);
    }
    
    /// <summary>
    /// Creates the lobby using the specified lobby type
    /// </summary>
    /// <param name="lobbyType">The lobby type</param>
    /// <param name="maxMembers">The max members</param>
    public static void CreateLobby(LobbyType lobbyType, long maxMembers = 2)
    {
        GetInstance().Call(Methods.CreateLobby, (long)lobbyType, maxMembers);
    }
    
    /// <summary>
    /// Joins the lobby using the specified steam lobby id
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    public static void JoinLobby(long steamLobbyId)
    {
        GetInstance().Call(Methods.JoinLobby, steamLobbyId);
    }
    
    /// <summary>
    /// Leaves the lobby using the specified steam lobby id
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    public static void LeaveLobby(long steamLobbyId)
    {
        GetInstance().Call(Methods.LeaveLobby, steamLobbyId);
    }
    
    /// <summary>
    /// Describes whether invite user to lobby
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <param name="steamIdInvitee">The steam id invitee</param>
    /// <returns>The bool</returns>
    public static bool InviteUserToLobby(ulong steamLobbyId, ulong steamIdInvitee)
    {
        return GetInstance().Call(Methods.InviteUserToLobby, steamLobbyId, steamIdInvitee).AsBool();
    }
    
    /// <summary>
    /// Gets the num lobby members using the specified steam lobby id
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <returns>The int</returns>
    public static int GetNumLobbyMembers(long steamLobbyId)
    {
        return GetInstance().Call(Methods.GetNumLobbyMembers, steamLobbyId).AsInt32();
    }
    
    /// <summary>
    /// Gets the lobby member by index using the specified steam lobby id
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <param name="member">The member</param>
    /// <returns>The ulong</returns>
    public static ulong GetLobbyMemberByIndex(ulong steamLobbyId, long member)
    {
        return GetInstance().Call(Methods.GetLobbyMemberByIndex, steamLobbyId, member).AsUInt64();
    }
    
    /// <summary>
    /// Gets the lobby data using the specified steam lobby id
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <param name="key">The key</param>
    /// <returns>The string</returns>
    public static string GetLobbyData(ulong steamLobbyId, string key)
    {
        return GetInstance().Call(Methods.GetLobbyData, steamLobbyId, key).AsString();
    }
    
    /// <summary>
    /// Describes whether set lobby data
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <param name="key">The key</param>
    /// <param name="value">The value</param>
    /// <returns>The bool</returns>
    public static bool SetLobbyData(ulong steamLobbyId, string key, string value)
    {
        return GetInstance().Call(Methods.SetLobbyData, steamLobbyId, key, value).AsBool();
    }
    
    /// <summary>
    /// Gets the all lobby data using the specified steam lobby id
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetAllLobbyData(long steamLobbyId)
    {
        return GetInstance().Call(Methods.GetAllLobbyData, steamLobbyId).AsGodotDictionary();
    }
    
    /// <summary>
    /// Describes whether delete lobby data
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <param name="key">The key</param>
    /// <returns>The bool</returns>
    public static bool DeleteLobbyData(ulong steamLobbyId, string key)
    {
        return GetInstance().Call(Methods.DeleteLobbyData, steamLobbyId, key).AsBool();
    }
    
    /// <summary>
    /// Gets the lobby member data using the specified steam lobby id
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <param name="steamIdUser">The steam id user</param>
    /// <param name="key">The key</param>
    /// <returns>The string</returns>
    public static string GetLobbyMemberData(ulong steamLobbyId, ulong steamIdUser, string key)
    {
        return GetInstance().Call(Methods.GetLobbyMemberData, steamLobbyId, steamIdUser, key).AsString();
    }
    
    /// <summary>
    /// Sets the lobby member data using the specified steam lobby id
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <param name="key">The key</param>
    /// <param name="value">The value</param>
    public static void SetLobbyMemberData(ulong steamLobbyId, string key, string value)
    {
        GetInstance().Call(Methods.SetLobbyMemberData, steamLobbyId, key, value);
    }
    
    /// <summary>
    /// Describes whether send lobby chat msg
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <param name="messageBody">The message body</param>
    /// <returns>The bool</returns>
    public static bool SendLobbyChatMsg(ulong steamLobbyId, string messageBody)
    {
        return GetInstance().Call(Methods.SendLobbyChatMsg, steamLobbyId, messageBody).AsBool();
    }
    
    /// <summary>
    /// Describes whether request lobby data
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <returns>The bool</returns>
    public static bool RequestLobbyData(long steamLobbyId)
    {
        return GetInstance().Call(Methods.RequestLobbyData, steamLobbyId).AsBool();
    }
    
    /// <summary>
    /// Sets the lobby game server using the specified steam lobby id
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <param name="serverIP">The server ip</param>
    /// <param name="serverPort">The server port</param>
    /// <param name="steamIdGameServer">The steam id game server</param>
    public static void SetLobbyGameServer(ulong steamLobbyId, string serverIP, int serverPort, ulong steamIdGameServer)
    {
        GetInstance().Call(Methods.SetLobbyGameServer, steamLobbyId, serverIP, serverPort, steamIdGameServer);
    }
    
    /// <summary>
    /// Gets the lobby game server using the specified steam lobby id
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetLobbyGameServer(long steamLobbyId)
    {
        return GetInstance().Call(Methods.GetLobbyGameServer, steamLobbyId).AsGodotDictionary();
    }
    
    /// <summary>
    /// Describes whether set lobby member limit
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <param name="maxMembers">The max members</param>
    /// <returns>The bool</returns>
    public static bool SetLobbyMemberLimit(ulong steamLobbyId, long maxMembers)
    {
        return GetInstance().Call(Methods.SetLobbyMemberLimit, steamLobbyId, maxMembers).AsBool();
    }
    
    /// <summary>
    /// Gets the lobby member limit using the specified steam lobby id
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <returns>The int</returns>
    public static int GetLobbyMemberLimit(long steamLobbyId)
    {
        return GetInstance().Call(Methods.GetLobbyMemberLimit, steamLobbyId).AsInt32();
    }
    
    /// <summary>
    /// Describes whether set lobby type
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <param name="lobbyType">The lobby type</param>
    /// <returns>The bool</returns>
    public static bool SetLobbyType(ulong steamLobbyId, LobbyType lobbyType)
    {
        return GetInstance().Call(Methods.SetLobbyType, steamLobbyId, (long)lobbyType).AsBool();
    }
    
    /// <summary>
    /// Describes whether set lobby joinable
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <param name="joinable">The joinable</param>
    /// <returns>The bool</returns>
    public static bool SetLobbyJoinable(ulong steamLobbyId, bool joinable)
    {
        return GetInstance().Call(Methods.SetLobbyJoinable, steamLobbyId, joinable).AsBool();
    }
    
    /// <summary>
    /// Gets the lobby owner using the specified steam lobby id
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <returns>The ulong</returns>
    public static ulong GetLobbyOwner(long steamLobbyId)
    {
        return GetInstance().Call(Methods.GetLobbyOwner, steamLobbyId).AsUInt64();
    }
    
    /// <summary>
    /// Describes whether set lobby owner
    /// </summary>
    /// <param name="steamLobbyId">The steam lobby id</param>
    /// <param name="steamIdNewOwner">The steam id new owner</param>
    /// <returns>The bool</returns>
    public static bool SetLobbyOwner(ulong steamLobbyId, ulong steamIdNewOwner)
    {
        return GetInstance().Call(Methods.SetLobbyOwner, steamLobbyId, steamIdNewOwner).AsBool();
    }

    /// <summary>
    /// The chat member state change enum
    /// </summary>
    [System.Flags]
    public enum ChatMemberStateChange : long
    {
        /// <summary>
        /// The entered chat member state change
        /// </summary>
        Entered = 1,
        /// <summary>
        /// The left chat member state change
        /// </summary>
        Left = 2,
        /// <summary>
        /// The disconnected chat member state change
        /// </summary>
        Disconnected = 4,
        /// <summary>
        /// The kicked chat member state change
        /// </summary>
        Kicked = 8,
        /// <summary>
        /// The banned chat member state change
        /// </summary>
        Banned = 16
    }

    /// <summary>
    /// The lobby comparison enum
    /// </summary>
    public enum LobbyComparison : long
    {
        /// <summary>
        /// The lobby comparison equal to or less than lobby comparison
        /// </summary>
        LobbyComparisonEqualToOrLessThan = -2,
        /// <summary>
        /// The lobby comparison less than lobby comparison
        /// </summary>
        LobbyComparisonLessThan = -1,
        /// <summary>
        /// The lobby comparison equal lobby comparison
        /// </summary>
        LobbyComparisonEqual = 0,
        /// <summary>
        /// The lobby comparison greater than lobby comparison
        /// </summary>
        LobbyComparisonGreaterThan = 1,
        /// <summary>
        /// The obby comparison equal to greater than lobby comparison
        /// </summary>
        ObbyComparisonEqualToGreaterThan = 2,
        /// <summary>
        /// The lobby comparison not equal lobby comparison
        /// </summary>
        LobbyComparisonNotEqual = 3
    }

    /// <summary>
    /// The lobby distance filter enum
    /// </summary>
    public enum LobbyDistanceFilter : long
    {
        /// <summary>
        /// The close lobby distance filter
        /// </summary>
        Close = 0,
        /// <summary>
        /// The default lobby distance filter
        /// </summary>
        Default = 1,
        /// <summary>
        /// The far lobby distance filter
        /// </summary>
        Far = 2,
        /// <summary>
        /// The worldwide lobby distance filter
        /// </summary>
        Worldwide = 3
    }

    /// <summary>
    /// The lobby type enum
    /// </summary>
    public enum LobbyType : long
    {
        /// <summary>
        /// The private lobby type
        /// </summary>
        Private = 0,
        /// <summary>
        /// The friends only lobby type
        /// </summary>
        FriendsOnly = 1,
        /// <summary>
        /// The public lobby type
        /// </summary>
        Public = 2,
        /// <summary>
        /// The invisible lobby type
        /// </summary>
        Invisible = 3,
        /// <summary>
        /// The private unique lobby type
        /// </summary>
        PrivateUnique = 4
    }
}