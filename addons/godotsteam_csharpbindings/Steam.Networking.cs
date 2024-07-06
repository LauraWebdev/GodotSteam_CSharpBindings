using System;

namespace GodotSteam;

public static partial class Steam
{
    [Obsolete]
    public static bool AcceptP2PSessionWithUser(ulong steamIdRemote)
    {
        return GetInstance().Call(Methods.AcceptP2PSessionWithUser, steamIdRemote).As<bool>();
    }
    
    [Obsolete]
    public static bool AllowP2PPacketRelay(bool allow)
    {
        return GetInstance().Call(Methods.AllowP2PPacketRelay, allow).As<bool>();
    }
    
    [Obsolete]
    public static bool CloseP2PChannelWithUser(ulong steamIdRemote, long channel)
    {
        return GetInstance().Call(Methods.CloseP2PChannelWithUser, steamIdRemote, channel).As<bool>();
    }
    
    [Obsolete]
    public static bool CloseP2PSessionWithUser(ulong steamIdRemote)
    {
        return GetInstance().Call(Methods.CloseP2PSessionWithUser, steamIdRemote).As<bool>();
    }
    
    [Obsolete]
    public static Godot.Collections.Dictionary GetP2PSessionState(ulong steamIdRemote)
    {
        return GetInstance().Call(Methods.GetP2PSessionState, steamIdRemote).AsGodotDictionary();
    }
    
    [Obsolete]
    public static uint GetAvailableP2PPacketSize(long channel = 0)
    {
        return GetInstance().Call(Methods.GetAvailableP2PPacketSize, channel).As<uint>();
    }
    
    [Obsolete]
    public static Godot.Collections.Dictionary ReadP2PPacket(uint packet, long channel = 0)
    {
        return GetInstance().Call(Methods.ReadP2PPacket, packet, channel).AsGodotDictionary();
    }
    
    [Obsolete]
    public static bool SendP2PPacket(ulong steamIdRemote, byte[] data, P2PSend sendType, long channel = 0)
    {
        return GetInstance().Call(Methods.SendP2PPacket, steamIdRemote, data, (long)sendType, channel).As<bool>();
    }
    
    [Obsolete]
    public enum P2PSend : long
    {
        Unreliable = 0,
        UnreliableNoDelay = 1,
        Reliable = 2,
        ReliableWithBuffering = 3
    }

    [Obsolete]
    public enum P2PSessionError : long
    {
        None = 0,
        NotRunningApp = 1,
        NoRightsToApp = 2,
        DestinationNotLoggedOn = 3,
        Timeout = 4,
        Max = 5
    }

    [Obsolete]
    public enum SocketConnectionType : long
    {
        NotConnected = 0,
        Udp = 1,
        UdpRelay = 2
    }

    [Obsolete]
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