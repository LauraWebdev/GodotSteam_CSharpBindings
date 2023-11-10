namespace GodotSteam;

[System.Flags]
public enum UserRestriction
{
    None = 0,
    Unknown = 1,
    AnyChat = 2,
    VoiceChat = 4,
    GroupChat = 8,
    Rating = 16,
    GameInvites = 32,
    Trading = 64
}