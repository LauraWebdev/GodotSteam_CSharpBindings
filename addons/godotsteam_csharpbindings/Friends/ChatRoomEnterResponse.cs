namespace GodotSteam;

/// <summary>

/// The chat room enter response enum

/// </summary>

public enum ChatRoomEnterResponse
{
    /// <summary>
    /// The success chat room enter response
    /// </summary>
    Success = 1,
    /// <summary>
    /// The doesnt exist chat room enter response
    /// </summary>
    DoesntExist = 2,
    /// <summary>
    /// The not allowed chat room enter response
    /// </summary>
    NotAllowed = 3,
    /// <summary>
    /// The full chat room enter response
    /// </summary>
    Full = 4,
    /// <summary>
    /// The error chat room enter response
    /// </summary>
    Error = 5,
    /// <summary>
    /// The banned chat room enter response
    /// </summary>
    Banned = 6,
    /// <summary>
    /// The limited chat room enter response
    /// </summary>
    Limited = 7,
    /// <summary>
    /// The clan disabled chat room enter response
    /// </summary>
    ClanDisabled = 8,
    /// <summary>
    /// The community ban chat room enter response
    /// </summary>
    CommunityBan = 9,
    /// <summary>
    /// The member blocked you chat room enter response
    /// </summary>
    MemberBlockedYou = 10,
    /// <summary>
    /// The you blocked member chat room enter response
    /// </summary>
    YouBlockedMember = 11,
    /// <summary>
    /// The rate limit exceeded chat room enter response
    /// </summary>
    RateLimitExceeded = 15
}