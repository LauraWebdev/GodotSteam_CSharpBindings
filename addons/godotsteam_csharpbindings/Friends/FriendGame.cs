namespace GodotSteam;

public struct FriendGame
{
    public ushort GamePort { get; set; }
    public int Id { get; set; }
    public string Ip { get; set; }
    public ulong? Lobby { get; set; }
    public ushort QueryPort { get; set; }
}