namespace GodotSteam;

/// <summary>

/// The user restriction enum

/// </summary>

[System.Flags]
public enum UserRestriction
{
    /// <summary>
    /// The none user restriction
    /// </summary>
    None = 0,
    /// <summary>
    /// The unknown user restriction
    /// </summary>
    Unknown = 1,
    /// <summary>
    /// The any chat user restriction
    /// </summary>
    AnyChat = 2,
    /// <summary>
    /// The voice chat user restriction
    /// </summary>
    VoiceChat = 4,
    /// <summary>
    /// The group chat user restriction
    /// </summary>
    GroupChat = 8,
    /// <summary>
    /// The rating user restriction
    /// </summary>
    Rating = 16,
    /// <summary>
    /// The game invites user restriction
    /// </summary>
    GameInvites = 32,
    /// <summary>
    /// The trading user restriction
    /// </summary>
    Trading = 64
}