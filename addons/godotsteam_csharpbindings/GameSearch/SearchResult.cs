namespace GodotSteam;

public class SearchResult
{
    public int CountPlayersIngame { get; set; }
    public int CountAcceptedGame { get; set; }
    public ulong HostId { get; set; }
    public bool FinalCallback { get; set; }
}