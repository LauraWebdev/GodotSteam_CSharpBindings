namespace GodotSteam;

public static partial class Steam
{
    public static void CancelQuery(long serverListRequest)
    {
        GetInstance().Call(Methods.CancelQuery, serverListRequest);
    }
    
    public static void CancelServerQuery(long serverQuery)
    {
        GetInstance().Call(Methods.CancelServerQuery, serverQuery);
    }
    
    public static int GetServerCount(long serverListRequest)
    {
        return GetInstance().Call(Methods.GetServerCount, serverListRequest).AsInt32();
    }
    
    public static Godot.Collections.Dictionary GetServerDetails(int server, long serverListRequest)
    {
        return GetInstance().Call(Methods.GetServerDetails, server, serverListRequest).AsGodotDictionary();
    }
    
    public static bool IsRefreshing(long serverListRequest)
    {
        return GetInstance().Call(Methods.IsRefreshing, serverListRequest).AsBool();
    }
    
    public static int PingServer(string iP, long port)
    {
        return GetInstance().Call(Methods.PingServer, iP, port).AsInt32();
    }
    
    public static int PlayerDetails(string iP, long port)
    {
        return GetInstance().Call(Methods.PlayerDetails, iP, port).AsInt32();
    }
    
    public static void RefreshQuery(long serverListRequest)
    {
        GetInstance().Call(Methods.RefreshQuery, serverListRequest);
    }
    
    public static void RefreshServer(int server, long serverListRequest)
    {
        GetInstance().Call(Methods.RefreshServer, server, serverListRequest);
    }
    
    public static void ReleaseRequest(long serverListRequest)
    {
        GetInstance().Call(Methods.ReleaseRequest, serverListRequest);
    }
    
    public static ulong RequestFavoritesServerList(uint appId, Godot.Collections.Array filters)
    {
        return GetInstance().Call(Methods.RequestFavoritesServerList, appId, filters).AsUInt64();
    }
    
    public static ulong RequestFriendsServerList(uint appId, Godot.Collections.Array filters)
    {
        return GetInstance().Call(Methods.RequestFriendsServerList, appId, filters).AsUInt64();
    }
    
    public static ulong RequestHistoryServerList(uint appId, Godot.Collections.Array filters)
    {
        return GetInstance().Call(Methods.RequestHistoryServerList, appId, filters).AsUInt64();
    }
    
    public static ulong RequestInternetServerList(uint appId, Godot.Collections.Array filters)
    {
        return GetInstance().Call(Methods.RequestInternetServerList, appId, filters).AsUInt64();
    }
    
    public static ulong RequestLANServerList(uint appId)
    {
        return GetInstance().Call(Methods.RequestLANServerList, appId).AsUInt64();
    }
    
    public static ulong RequestSpectatorServerList(uint appId, Godot.Collections.Array filters)
    {
        return GetInstance().Call(Methods.RequestSpectatorServerList, appId, filters).AsUInt64();
    }
    
    public static int ServerRules(string iP, long port)
    {
        return GetInstance().Call(Methods.ServerRules, iP, port).AsInt32();
    }

    public enum MatchMakingServerResponse : long
    {
        ServerResponded = 0,
        ServerFailedToRespond = 1,
        NoServersListedOnMasterServer = 2
    }
}