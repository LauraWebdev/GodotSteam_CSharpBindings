namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Cancels the query using the specified server list request
    /// </summary>
    /// <param name="serverListRequest">The server list request</param>
    public static void CancelQuery(long serverListRequest)
    {
        GetInstance().Call(Methods.CancelQuery, serverListRequest);
    }
    
    /// <summary>
    /// Cancels the server query using the specified server query
    /// </summary>
    /// <param name="serverQuery">The server query</param>
    public static void CancelServerQuery(long serverQuery)
    {
        GetInstance().Call(Methods.CancelServerQuery, serverQuery);
    }
    
    /// <summary>
    /// Gets the server count using the specified server list request
    /// </summary>
    /// <param name="serverListRequest">The server list request</param>
    /// <returns>The int</returns>
    public static int GetServerCount(long serverListRequest)
    {
        return GetInstance().Call(Methods.GetServerCount, serverListRequest).AsInt32();
    }
    
    /// <summary>
    /// Gets the server details using the specified server
    /// </summary>
    /// <param name="server">The server</param>
    /// <param name="serverListRequest">The server list request</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetServerDetails(int server, long serverListRequest)
    {
        return GetInstance().Call(Methods.GetServerDetails, server, serverListRequest).AsGodotDictionary();
    }
    
    /// <summary>
    /// Describes whether is refreshing
    /// </summary>
    /// <param name="serverListRequest">The server list request</param>
    /// <returns>The bool</returns>
    public static bool IsRefreshing(long serverListRequest)
    {
        return GetInstance().Call(Methods.IsRefreshing, serverListRequest).AsBool();
    }
    
    /// <summary>
    /// Pings the server using the specified i p
    /// </summary>
    /// <param name="iP">The </param>
    /// <param name="port">The port</param>
    /// <returns>The int</returns>
    public static int PingServer(string iP, long port)
    {
        return GetInstance().Call(Methods.PingServer, iP, port).AsInt32();
    }
    
    /// <summary>
    /// Players the details using the specified i p
    /// </summary>
    /// <param name="iP">The </param>
    /// <param name="port">The port</param>
    /// <returns>The int</returns>
    public static int PlayerDetails(string iP, long port)
    {
        return GetInstance().Call(Methods.PlayerDetails, iP, port).AsInt32();
    }
    
    /// <summary>
    /// Refreshes the query using the specified server list request
    /// </summary>
    /// <param name="serverListRequest">The server list request</param>
    public static void RefreshQuery(long serverListRequest)
    {
        GetInstance().Call(Methods.RefreshQuery, serverListRequest);
    }
    
    /// <summary>
    /// Refreshes the server using the specified server
    /// </summary>
    /// <param name="server">The server</param>
    /// <param name="serverListRequest">The server list request</param>
    public static void RefreshServer(int server, long serverListRequest)
    {
        GetInstance().Call(Methods.RefreshServer, server, serverListRequest);
    }
    
    /// <summary>
    /// Releases the request using the specified server list request
    /// </summary>
    /// <param name="serverListRequest">The server list request</param>
    public static void ReleaseRequest(long serverListRequest)
    {
        GetInstance().Call(Methods.ReleaseRequest, serverListRequest);
    }
    
    /// <summary>
    /// Requests the favorites server list using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <param name="filters">The filters</param>
    /// <returns>The ulong</returns>
    public static ulong RequestFavoritesServerList(uint appId, Godot.Collections.Array filters)
    {
        return GetInstance().Call(Methods.RequestFavoritesServerList, appId, filters).AsUInt64();
    }
    
    /// <summary>
    /// Requests the friends server list using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <param name="filters">The filters</param>
    /// <returns>The ulong</returns>
    public static ulong RequestFriendsServerList(uint appId, Godot.Collections.Array filters)
    {
        return GetInstance().Call(Methods.RequestFriendsServerList, appId, filters).AsUInt64();
    }
    
    /// <summary>
    /// Requests the history server list using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <param name="filters">The filters</param>
    /// <returns>The ulong</returns>
    public static ulong RequestHistoryServerList(uint appId, Godot.Collections.Array filters)
    {
        return GetInstance().Call(Methods.RequestHistoryServerList, appId, filters).AsUInt64();
    }
    
    /// <summary>
    /// Requests the internet server list using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <param name="filters">The filters</param>
    /// <returns>The ulong</returns>
    public static ulong RequestInternetServerList(uint appId, Godot.Collections.Array filters)
    {
        return GetInstance().Call(Methods.RequestInternetServerList, appId, filters).AsUInt64();
    }
    
    /// <summary>
    /// Requests the lan server list using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <returns>The ulong</returns>
    public static ulong RequestLANServerList(uint appId)
    {
        return GetInstance().Call(Methods.RequestLANServerList, appId).AsUInt64();
    }
    
    /// <summary>
    /// Requests the spectator server list using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <param name="filters">The filters</param>
    /// <returns>The ulong</returns>
    public static ulong RequestSpectatorServerList(uint appId, Godot.Collections.Array filters)
    {
        return GetInstance().Call(Methods.RequestSpectatorServerList, appId, filters).AsUInt64();
    }
    
    /// <summary>
    /// Servers the rules using the specified i p
    /// </summary>
    /// <param name="iP">The </param>
    /// <param name="port">The port</param>
    /// <returns>The int</returns>
    public static int ServerRules(string iP, long port)
    {
        return GetInstance().Call(Methods.ServerRules, iP, port).AsInt32();
    }

    /// <summary>
    /// The match making server response enum
    /// </summary>
    public enum MatchMakingServerResponse : long
    {
        /// <summary>
        /// The server responded match making server response
        /// </summary>
        ServerResponded = 0,
        /// <summary>
        /// The server failed to respond match making server response
        /// </summary>
        ServerFailedToRespond = 1,
        /// <summary>
        /// The no servers listed on master server match making server response
        /// </summary>
        NoServersListedOnMasterServer = 2
    }
}