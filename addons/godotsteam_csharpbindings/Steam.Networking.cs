namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Describes whether accept p 2 p session with user
    /// </summary>
    /// <param name="steamIdRemote">The steam id remote</param>
    /// <returns>The bool</returns>
    public static bool AcceptP2PSessionWithUser(ulong steamIdRemote)
    {
        return GetInstance().Call(Methods.AcceptP2PSessionWithUser, steamIdRemote).AsBool();
    }
    
    /// <summary>
    /// Describes whether allow p 2 p packet relay
    /// </summary>
    /// <param name="allow">The allow</param>
    /// <returns>The bool</returns>
    public static bool AllowP2PPacketRelay(bool allow)
    {
        return GetInstance().Call(Methods.AllowP2PPacketRelay, allow).AsBool();
    }
    
    /// <summary>
    /// Describes whether close p 2 p channel with user
    /// </summary>
    /// <param name="steamIdRemote">The steam id remote</param>
    /// <param name="channel">The channel</param>
    /// <returns>The bool</returns>
    public static bool CloseP2PChannelWithUser(ulong steamIdRemote, long channel)
    {
        return GetInstance().Call(Methods.CloseP2PChannelWithUser, steamIdRemote, channel).AsBool();
    }
    
    /// <summary>
    /// Describes whether close p 2 p session with user
    /// </summary>
    /// <param name="steamIdRemote">The steam id remote</param>
    /// <returns>The bool</returns>
    public static bool CloseP2PSessionWithUser(ulong steamIdRemote)
    {
        return GetInstance().Call(Methods.CloseP2PSessionWithUser, steamIdRemote).AsBool();
    }
    
    /// <summary>
    /// Gets the p 2 p session state using the specified steam id remote
    /// </summary>
    /// <param name="steamIdRemote">The steam id remote</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetP2PSessionState(ulong steamIdRemote)
    {
        return GetInstance().Call(Methods.GetP2PSessionState, steamIdRemote).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the available p 2 p packet size using the specified channel
    /// </summary>
    /// <param name="channel">The channel</param>
    /// <returns>The uint</returns>
    public static uint GetAvailableP2PPacketSize(long channel = 0)
    {
        return GetInstance().Call(Methods.GetAvailableP2PPacketSize, channel).AsUInt32();
    }
    
    /// <summary>
    /// Reads the p 2 p packet using the specified packet
    /// </summary>
    /// <param name="packet">The packet</param>
    /// <param name="channel">The channel</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary ReadP2PPacket(uint packet, long channel = 0)
    {
        return GetInstance().Call(Methods.ReadP2PPacket, packet, channel).AsGodotDictionary();
    }
    
    /// <summary>
    /// Describes whether send p 2 p packet
    /// </summary>
    /// <param name="steamIdRemote">The steam id remote</param>
    /// <param name="data">The data</param>
    /// <param name="sendType">The send type</param>
    /// <param name="channel">The channel</param>
    /// <returns>The bool</returns>
    public static bool SendP2PPacket(ulong steamIdRemote, byte[] data, P2PSend sendType, long channel = 0)
    {
        return GetInstance().Call(Methods.SendP2PPacket, steamIdRemote, data, (long)sendType, channel).AsBool();
    }
    
    /// <summary>
    /// The send enum
    /// </summary>
    public enum P2PSend : long
    {
        /// <summary>
        /// The unreliable send
        /// </summary>
        Unreliable = 0,
        /// <summary>
        /// The unreliable no delay send
        /// </summary>
        UnreliableNoDelay = 1,
        /// <summary>
        /// The reliable send
        /// </summary>
        Reliable = 2,
        /// <summary>
        /// The reliable with buffering send
        /// </summary>
        ReliableWithBuffering = 3
    }

    /// <summary>
    /// The session error enum
    /// </summary>
    public enum P2PSessionError : long
    {
        /// <summary>
        /// The none session error
        /// </summary>
        None = 0,
        /// <summary>
        /// The not running app session error
        /// </summary>
        NotRunningApp = 1,
        /// <summary>
        /// The no rights to app session error
        /// </summary>
        NoRightsToApp = 2,
        /// <summary>
        /// The destination not logged on session error
        /// </summary>
        DestinationNotLoggedOn = 3,
        /// <summary>
        /// The timeout session error
        /// </summary>
        Timeout = 4,
        /// <summary>
        /// The max session error
        /// </summary>
        Max = 5
    }

    /// <summary>
    /// The socket connection type enum
    /// </summary>
    public enum SocketConnectionType : long
    {
        /// <summary>
        /// The not connected socket connection type
        /// </summary>
        NotConnected = 0,
        /// <summary>
        /// The udp socket connection type
        /// </summary>
        Udp = 1,
        /// <summary>
        /// The udp relay socket connection type
        /// </summary>
        UdpRelay = 2
    }

    /// <summary>
    /// The socket state enum
    /// </summary>
    public enum SocketState : long
    {
        /// <summary>
        /// The invalid socket state
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The connected socket state
        /// </summary>
        Connected = 1,
        /// <summary>
        /// The initiated socket state
        /// </summary>
        Initiated = 10,
        /// <summary>
        /// The local candidate found socket state
        /// </summary>
        LocalCandidateFound = 11,
        /// <summary>
        /// The received remote candidates socket state
        /// </summary>
        ReceivedRemoteCandidates = 12,
        /// <summary>
        /// The challenge handshake socket state
        /// </summary>
        ChallengeHandshake = 15,
        /// <summary>
        /// The disconnecting socket state
        /// </summary>
        Disconnecting = 21,
        /// <summary>
        /// The local disconnect socket state
        /// </summary>
        LocalDisconnect = 22,
        /// <summary>
        /// The timeout during connect socket state
        /// </summary>
        TimeoutDuringConnect = 23,
        /// <summary>
        /// The remote end disconnected socket state
        /// </summary>
        RemoteEndDisconnected = 24,
        /// <summary>
        /// The broken socket state
        /// </summary>
        Broken = 25
    }
}