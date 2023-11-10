namespace GodotSteam;

public static partial class Steam
{
    
    public static int AddGameSearchParams(string key, string values)
    {
        return GetInstance().Call(Methods.AddGameSearchParams, key, values).AsInt32();
    }
    
    public static int SearchForGameWithLobby(ulong lobbyId, int playerMin, long playerMax)
    {
        return GetInstance().Call(Methods.SearchForGameWithLobby, lobbyId, playerMin, playerMax).AsInt32();
    }
    
    public static int SearchForGameSolo(int playerMin, long playerMax)
    {
        return GetInstance().Call(Methods.SearchForGameSolo, playerMin, playerMax).AsInt32();
    }
    
    public static long AcceptGame()
    {
        return GetInstance().Call(Methods.AcceptGame).AsInt64();
    }
    
    public static long DeclineGame()
    {
        return GetInstance().Call(Methods.DeclineGame).AsInt64();
    }
    
    public static string RetrieveConnectionDetails(long hostId)
    {
        return GetInstance().Call(Methods.RetrieveConnectionDetails, hostId).AsString();
    }
    
    public static long EndGameSearch()
    {
        return GetInstance().Call(Methods.EndGameSearch).AsInt64();
    }
    
    public static int SetGameHostParams(string key, string value)
    {
        return GetInstance().Call(Methods.SetGameHostParams, key, value).AsInt32();
    }
    
    public static int SetConnectionDetails(string details, long connectionDetails)
    {
        return GetInstance().Call(Methods.SetConnectionDetails, details, connectionDetails).AsInt32();
    }
    
    public static int RequestPlayersForGame(int playerMin, int playerMax, long maxTeamSize)
    {
        return GetInstance().Call(Methods.RequestPlayersForGame, playerMin, playerMax, maxTeamSize).AsInt32();
    }
    
    public static int HostConfirmGameStart(long gameId)
    {
        return GetInstance().Call(Methods.HostConfirmGameStart, gameId).AsInt32();
    }
    
    public static long CancelRequestPlayersForGame()
    {
        return GetInstance().Call(Methods.CancelRequestPlayersForGame).AsInt32();
    }
    
    public static PlayerResult SubmitPlayerResult(ulong gameId, ulong playerId, PlayerResult playerResult)
    {
        return (PlayerResult)GetInstance().Call(Methods.SubmitPlayerResult, gameId, playerId, (int)playerResult).AsInt32();
    }
    
    public static int EndGame(long gameId)
    {
        return GetInstance().Call(Methods.EndGame, gameId).AsInt32();
    }

    public enum PlayerResult
    {
        FailedToConnect = 1,
        Abandoned = 2,
        Kicked = 3,
        Incomplete = 4,
        Completed = 5
    }
}