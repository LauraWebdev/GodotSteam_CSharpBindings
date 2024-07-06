namespace GodotSteam;

public struct RecentPlayer
{
    public ulong Id { get; set; }
    public string Name { get; set; }
    public int Time { get; set; }
    public PersonaState Status { get; set; }
}