namespace GodotSteam;

public static partial class Steam
{
    public static bool AcceptP2PSessionWithUser(ulong steamIdRemote)
    {
        return GetInstance().Call(Methods.AcceptP2PSessionWithUser, steamIdRemote).AsBool();
    }
    
    public static bool AllowP2PPacketRelay(bool allow)
    {
        return GetInstance().Call(Methods.AllowP2PPacketRelay, allow).AsBool();
    }
    
    public static bool CloseP2PChannelWithUser(ulong steamIdRemote, long channel)
    {
        return GetInstance().Call(Methods.CloseP2PChannelWithUser, steamIdRemote, channel).AsBool();
    }
    
    public static bool CloseP2PSessionWithUser(ulong steamIdRemote)
    {
        return GetInstance().Call(Methods.CloseP2PSessionWithUser, steamIdRemote).AsBool();
    }
    
    public static Godot.Collections.Dictionary GetP2PSessionState(ulong steamIdRemote)
    {
        return GetInstance().Call(Methods.GetP2PSessionState, steamIdRemote).AsGodotDictionary();
    }
    
    public static uint GetAvailableP2PPacketSize(long channel = 0)
    {
        return GetInstance().Call(Methods.GetAvailableP2PPacketSize, channel).AsUInt32();
    }
    
    public static Godot.Collections.Dictionary ReadP2PPacket(uint packet, long channel = 0)
    {
        return GetInstance().Call(Methods.ReadP2PPacket, packet, channel).AsGodotDictionary();
    }
    
    public static bool SendP2PPacket(ulong steamIdRemote, byte[] data, P2PSend sendType, long channel = 0)
    {
        return GetInstance().Call(Methods.SendP2PPacket, steamIdRemote, data, (long)sendType, channel).AsBool();
    }
    
    public enum P2PSend : long
    {
        Unreliable = 0,
        UnreliableNoDelay = 1,
        Reliable = 2,
        ReliableWithBuffering = 3
    }

    public enum P2PSessionError : long
    {
        None = 0,
        NotRunningApp = 1,
        NoRightsToApp = 2,
        DestinationNotLoggedOn = 3,
        Timeout = 4,
        Max = 5
    }

    public enum SocketConnectionType : long
    {
        NotConnected = 0,
        Udp = 1,
        UdpRelay = 2
    }

    public enum SocketState : long
    {
        Invalid = 0,
        Connected = 1,
        Initiated = 10,
        LocalCandidateFound = 11,
        ReceivedRemoteCandidates = 12,
        ChallengeHandshake = 15,
        Disconnecting = 21,
        LocalDisconnect = 22,
        TimeoutDuringConnect = 23,
        RemoteEndDisconnected = 24,
        Broken = 25
    }
}