namespace GodotSteam;

/// <summary>

/// The recent player class

/// </summary>

public class RecentPlayer
{
    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    public ulong Id { get; set; }
    /// <summary>
    /// Gets or sets the value of the name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Gets or sets the value of the time
    /// </summary>
    public int Time { get; set; }
    /// <summary>
    /// Gets or sets the value of the status
    /// </summary>
    public PersonaState Status { get; set; }
}