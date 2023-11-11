namespace GodotSteam;

public class SearchProgress
{
    public ulong LobbyId { get; set; }
    public ulong EndedSearchId { get; set; }
    public int SecondsRemainingEstimate { get; set; }
    public int PlayersSearching { get; set; }
}