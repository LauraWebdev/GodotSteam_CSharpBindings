namespace GodotSteam;

/// <summary>

/// The friend relationship enum

/// </summary>

public enum FriendRelationship
{
    /// <summary>
    /// The none friend relationship
    /// </summary>
    None = 0,
    /// <summary>
    /// The blocked friend relationship
    /// </summary>
    Blocked = 1,
    /// <summary>
    /// The request recipient friend relationship
    /// </summary>
    RequestRecipient = 2,
    /// <summary>
    /// The friend friend relationship
    /// </summary>
    Friend = 3,
    /// <summary>
    /// The request initiator friend relationship
    /// </summary>
    RequestInitiator = 4,
    /// <summary>
    /// The ignored friend relationship
    /// </summary>
    Ignored = 5,
    /// <summary>
    /// The ignored friend friend relationship
    /// </summary>
    IgnoredFriend = 6,
    /// <summary>
    /// The suggested friend relationship
    /// </summary>
    Suggested = 7,
    /// <summary>
    /// The max friend relationship
    /// </summary>
    Max = 8
}