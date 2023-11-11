namespace GodotSteam;

public static partial class Steam
{
    
    public static int AddGameSearchParams(string key, string values)
    {
        return GetInstance().Call(Methods.AddGameSearchParams, key, values).AsInt32();
    }
    
    public static int SearchForGameWithLobby(ulong lobbyId, int playerMin, int playerMax)
    {
        return GetInstance().Call(Methods.SearchForGameWithLobby, lobbyId, playerMin, playerMax).AsInt32();
    }
    
    public static int SearchForGameSolo(int playerMin, int playerMax)
    {
        return GetInstance().Call(Methods.SearchForGameSolo, playerMin, playerMax).AsInt32();
    }
    
    public static int AcceptGame()
    {
        return GetInstance().Call(Methods.AcceptGame).AsInt32();
    }
    
    public static int DeclineGame()
    {
        return GetInstance().Call(Methods.DeclineGame).AsInt32();
    }
    
    public static string RetrieveConnectionDetails(ulong hostId)
    {
        return GetInstance().Call(Methods.RetrieveConnectionDetails, hostId).AsString();
    }
    
    public static int EndGameSearch()
    {
        return GetInstance().Call(Methods.EndGameSearch).AsInt32();
    }
    
    public static int SetGameHostParams(string key, string value)
    {
        return GetInstance().Call(Methods.SetGameHostParams, key, value).AsInt32();
    }
    
    public static int SetConnectionDetails(string details, int connectionDetails)
    {
        return GetInstance().Call(Methods.SetConnectionDetails, details, connectionDetails).AsInt32();
    }
    
    public static int RequestPlayersForGame(int playerMin, int playerMax, int maxTeamSize)
    {
        return GetInstance().Call(Methods.RequestPlayersForGame, playerMin, playerMax, maxTeamSize).AsInt32();
    }
    
    public static int HostConfirmGameStart(ulong gameId)
    {
        return GetInstance().Call(Methods.HostConfirmGameStart, gameId).AsInt32();
    }
    
    public static int CancelRequestPlayersForGame()
    {
        return GetInstance().Call(Methods.CancelRequestPlayersForGame).AsInt32();
    }
    
    public static PlayerResult SubmitPlayerResult(ulong gameId, ulong playerId, PlayerResult playerResult)
    {
        return (PlayerResult)GetInstance().Call(Methods.SubmitPlayerResult, gameId, playerId, (int)playerResult).AsInt32();
    }
    
    public static int EndGame(ulong gameId)
    {
        return GetInstance().Call(Methods.EndGame, gameId).AsInt32();
    }
}