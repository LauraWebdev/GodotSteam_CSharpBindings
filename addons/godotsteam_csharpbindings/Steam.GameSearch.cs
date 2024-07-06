namespace GodotSteam;

public static partial class Steam
{
    
    public static int AddGameSearchParams(string key, string values)
    {
        return GetInstance().Call(Methods.AddGameSearchParams, key, values).As<int>();
    }
    
    public static int SearchForGameWithLobby(ulong lobbyId, int playerMin, int playerMax)
    {
        return GetInstance().Call(Methods.SearchForGameWithLobby, lobbyId, playerMin, playerMax).As<int>();
    }
    
    public static int SearchForGameSolo(int playerMin, int playerMax)
    {
        return GetInstance().Call(Methods.SearchForGameSolo, playerMin, playerMax).As<int>();
    }
    
    public static int AcceptGame()
    {
        return GetInstance().Call(Methods.AcceptGame).As<int>();
    }
    
    public static int DeclineGame()
    {
        return GetInstance().Call(Methods.DeclineGame).As<int>();
    }
    
    public static string RetrieveConnectionDetails(ulong hostId)
    {
        return GetInstance().Call(Methods.RetrieveConnectionDetails, hostId).As<string>();
    }
    
    public static int EndGameSearch()
    {
        return GetInstance().Call(Methods.EndGameSearch).As<int>();
    }
    
    public static int SetGameHostParams(string key, string value)
    {
        return GetInstance().Call(Methods.SetGameHostParams, key, value).As<int>();
    }
    
    public static int SetConnectionDetails(string details, int connectionDetails)
    {
        return GetInstance().Call(Methods.SetConnectionDetails, details, connectionDetails).As<int>();
    }
    
    public static int RequestPlayersForGame(int playerMin, int playerMax, int maxTeamSize)
    {
        return GetInstance().Call(Methods.RequestPlayersForGame, playerMin, playerMax, maxTeamSize).As<int>();
    }
    
    public static int HostConfirmGameStart(ulong gameId)
    {
        return GetInstance().Call(Methods.HostConfirmGameStart, gameId).As<int>();
    }
    
    public static int CancelRequestPlayersForGame()
    {
        return GetInstance().Call(Methods.CancelRequestPlayersForGame).As<int>();
    }
    
    public static PlayerResult SubmitPlayerResult(ulong gameId, ulong playerId, PlayerResult playerResult)
    {
        return (PlayerResult)GetInstance().Call(Methods.SubmitPlayerResult, gameId, playerId, (int)playerResult).As<int>();
    }
    
    public static int EndGame(ulong gameId)
    {
        return GetInstance().Call(Methods.EndGame, gameId).As<int>();
    }
}