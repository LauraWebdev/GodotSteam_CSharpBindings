namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    
    /// <summary>
    /// Adds the game search params using the specified key
    /// </summary>
    /// <param name="key">The key</param>
    /// <param name="values">The values</param>
    /// <returns>The int</returns>
    public static int AddGameSearchParams(string key, string values)
    {
        return GetInstance().Call(Methods.AddGameSearchParams, key, values).AsInt32();
    }
    
    /// <summary>
    /// Searches the for game with lobby using the specified lobby id
    /// </summary>
    /// <param name="lobbyId">The lobby id</param>
    /// <param name="playerMin">The player min</param>
    /// <param name="playerMax">The player max</param>
    /// <returns>The int</returns>
    public static int SearchForGameWithLobby(ulong lobbyId, int playerMin, long playerMax)
    {
        return GetInstance().Call(Methods.SearchForGameWithLobby, lobbyId, playerMin, playerMax).AsInt32();
    }
    
    /// <summary>
    /// Searches the for game solo using the specified player min
    /// </summary>
    /// <param name="playerMin">The player min</param>
    /// <param name="playerMax">The player max</param>
    /// <returns>The int</returns>
    public static int SearchForGameSolo(int playerMin, long playerMax)
    {
        return GetInstance().Call(Methods.SearchForGameSolo, playerMin, playerMax).AsInt32();
    }
    
    /// <summary>
    /// Accepts the game
    /// </summary>
    /// <returns>The long</returns>
    public static long AcceptGame()
    {
        return GetInstance().Call(Methods.AcceptGame).AsInt64();
    }
    
    /// <summary>
    /// Declines the game
    /// </summary>
    /// <returns>The long</returns>
    public static long DeclineGame()
    {
        return GetInstance().Call(Methods.DeclineGame).AsInt64();
    }
    
    /// <summary>
    /// Retrieves the connection details using the specified host id
    /// </summary>
    /// <param name="hostId">The host id</param>
    /// <returns>The string</returns>
    public static string RetrieveConnectionDetails(long hostId)
    {
        return GetInstance().Call(Methods.RetrieveConnectionDetails, hostId).AsString();
    }
    
    /// <summary>
    /// Ends the game search
    /// </summary>
    /// <returns>The long</returns>
    public static long EndGameSearch()
    {
        return GetInstance().Call(Methods.EndGameSearch).AsInt64();
    }
    
    /// <summary>
    /// Sets the game host params using the specified key
    /// </summary>
    /// <param name="key">The key</param>
    /// <param name="value">The value</param>
    /// <returns>The int</returns>
    public static int SetGameHostParams(string key, string value)
    {
        return GetInstance().Call(Methods.SetGameHostParams, key, value).AsInt32();
    }
    
    /// <summary>
    /// Sets the connection details using the specified details
    /// </summary>
    /// <param name="details">The details</param>
    /// <param name="connectionDetails">The connection details</param>
    /// <returns>The int</returns>
    public static int SetConnectionDetails(string details, long connectionDetails)
    {
        return GetInstance().Call(Methods.SetConnectionDetails, details, connectionDetails).AsInt32();
    }
    
    /// <summary>
    /// Requests the players for game using the specified player min
    /// </summary>
    /// <param name="playerMin">The player min</param>
    /// <param name="playerMax">The player max</param>
    /// <param name="maxTeamSize">The max team size</param>
    /// <returns>The int</returns>
    public static int RequestPlayersForGame(int playerMin, int playerMax, long maxTeamSize)
    {
        return GetInstance().Call(Methods.RequestPlayersForGame, playerMin, playerMax, maxTeamSize).AsInt32();
    }
    
    /// <summary>
    /// Hosts the confirm game start using the specified game id
    /// </summary>
    /// <param name="gameId">The game id</param>
    /// <returns>The int</returns>
    public static int HostConfirmGameStart(long gameId)
    {
        return GetInstance().Call(Methods.HostConfirmGameStart, gameId).AsInt32();
    }
    
    /// <summary>
    /// Cancels the request players for game
    /// </summary>
    /// <returns>The long</returns>
    public static long CancelRequestPlayersForGame()
    {
        return GetInstance().Call(Methods.CancelRequestPlayersForGame).AsInt32();
    }
    
    /// <summary>
    /// Submits the player result using the specified game id
    /// </summary>
    /// <param name="gameId">The game id</param>
    /// <param name="playerId">The player id</param>
    /// <param name="playerResult">The player result</param>
    /// <returns>The player result</returns>
    public static PlayerResult SubmitPlayerResult(ulong gameId, ulong playerId, PlayerResult playerResult)
    {
        return (PlayerResult)GetInstance().Call(Methods.SubmitPlayerResult, gameId, playerId, (int)playerResult).AsInt32();
    }
    
    /// <summary>
    /// Ends the game using the specified game id
    /// </summary>
    /// <param name="gameId">The game id</param>
    /// <returns>The int</returns>
    public static int EndGame(long gameId)
    {
        return GetInstance().Call(Methods.EndGame, gameId).AsInt32();
    }

    /// <summary>
    /// The player result enum
    /// </summary>
    public enum PlayerResult
    {
        /// <summary>
        /// The failed to connect player result
        /// </summary>
        FailedToConnect = 1,
        /// <summary>
        /// The abandoned player result
        /// </summary>
        Abandoned = 2,
        /// <summary>
        /// The kicked player result
        /// </summary>
        Kicked = 3,
        /// <summary>
        /// The incomplete player result
        /// </summary>
        Incomplete = 4,
        /// <summary>
        /// The completed player result
        /// </summary>
        Completed = 5
    }
}