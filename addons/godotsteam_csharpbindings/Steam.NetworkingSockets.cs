namespace GodotSteam;

public static partial class Steam
{
    public static int AcceptConnection(uint connection)
    {
        return GetInstance().Call(Methods.AcceptConnection, connection).As<int>();
    }
    
    public static bool BeginAsyncRequestFakeIP(long numPorts)
    {
        return GetInstance().Call(Methods.BeginAsyncRequestFakeIP, numPorts).As<bool>();
    }
    
    public static bool CloseConnection(uint peer, int reason, string debugMessage, bool linger)
    {
        return GetInstance().Call(Methods.CloseConnection, peer, reason, debugMessage, linger).As<bool>();
    }
    
    public static bool CloseListenSocket(long socket)
    {
        return GetInstance().Call(Methods.CloseListenSocket, socket).As<bool>();
    }
    
    public static int ConfigureConnectionLanes(uint connection, int lanes, Godot.Collections.Array priorities, Godot.Collections.Array weights)
    {
        return GetInstance().Call(Methods.ConfigureConnectionLanes, connection, lanes, priorities, weights).As<int>();
    }
    
    public static uint ConnectP2P(ulong identity, int virtualPort, Godot.Collections.Array options)
    {
        return GetInstance().Call(Methods.ConnectP2P, identity, virtualPort, options).As<uint>();
    }
    
    public static uint ConnectByIPAddress(string iPAddressWithPort, Godot.Collections.Array options)
    {
        return GetInstance().Call(Methods.ConnectByIPAddress, iPAddressWithPort, options).As<uint>();
    }
    
    public static uint ConnectToHostedDedicatedServer(string identityReference, int virtualPort, Godot.Collections.Array options)
    {
        return GetInstance().Call(Methods.ConnectToHostedDedicatedServer, identityReference, virtualPort, options).As<uint>();
    }
    
    public static void CreateFakeUDPPort(long fakeServerPort)
    {
        GetInstance().Call(Methods.CreateFakeUDPPort, fakeServerPort);
    }
    
    public static uint CreateHostedDedicatedServerListenSocket(int virtualPort, Godot.Collections.Array options)
    {
        return GetInstance().Call(Methods.CreateHostedDedicatedServerListenSocket, virtualPort, options).As<uint>();
    }
    
    public static uint CreateListenSocketIP(string iPReference, Godot.Collections.Array options)
    {
        return GetInstance().Call(Methods.CreateListenSocketIP, iPReference, options).As<uint>();
    }
    
    public static uint CreateListenSocketP2P(int virtualPort, Godot.Collections.Array options)
    {
        return GetInstance().Call(Methods.CreateListenSocketP2P, virtualPort, options).As<uint>();
    }
    
    public static uint CreateListenSocketP2PFakeIP(int fakePort, Godot.Collections.Array options)
    {
        return GetInstance().Call(Methods.CreateListenSocketP2PFakeIP, fakePort, options).As<uint>();
    }
    
    public static long CreatePollGroup()
    {
        return GetInstance().Call(Methods.CreatePollGroup).AsInt64();
    }
    
    public static Godot.Collections.Dictionary CreateSocketPair(bool loopback, string identityReference1, string identityReference2)
    {
        return GetInstance().Call(Methods.CreateSocketPair, loopback, identityReference1, identityReference2).AsGodotDictionary();
    }
    
    public static bool DestroyPollGroup(long pollGroup)
    {
        return GetInstance().Call(Methods.DestroyPollGroup, pollGroup).As<bool>();
    }
    
    public static int FlushMessagesOnConnection(uint connectionHandle)
    {
        return GetInstance().Call(Methods.FlushMessagesOnConnection, connectionHandle).As<int>();
    }
    
    public static NetworkingAvailability GetAuthenticationStatus()
    {
        return (NetworkingAvailability)GetInstance().Call(Methods.GetAuthenticationStatus).AsInt64();
    }
    
    public static Godot.Collections.Dictionary GetCertificateRequest()
    {
        return GetInstance().Call(Methods.GetCertificateRequest).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetConnectionInfo(uint connectionHandle)
    {
        return GetInstance().Call(Methods.GetConnectionInfo, connectionHandle).AsGodotDictionary();
    }
    
    public static string GetConnectionName(long peer)
    {
        return GetInstance().Call(Methods.GetConnectionName, peer).As<string>();
    }
    
    public static Godot.Collections.Dictionary GetConnectionRealTimeStatus(uint connectionHandle, int lanes, bool getStatus = true)
    {
        return GetInstance().Call(Methods.GetConnectionRealTimeStatus, connectionHandle, lanes, getStatus).AsGodotDictionary();
    }
    
    public static ulong GetConnectionUserData(long peer)
    {
        return GetInstance().Call(Methods.GetConnectionUserData, peer).As<ulong>();
    }
    
    public static Godot.Collections.Dictionary GetDetailedConnectionStatus(uint connectionHandle)
    {
        return GetInstance().Call(Methods.GetDetailedConnectionStatus, connectionHandle).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetFakeIP(long firstPort = 0)
    {
        return GetInstance().Call(Methods.GetFakeIP, firstPort).AsGodotDictionary();
    }
    
    public static long GetHostedDedicatedServerPOPId()
    {
        return GetInstance().Call(Methods.GetHostedDedicatedServerPOPId).AsInt64();
    }
    
    public static long GetHostedDedicatedServerPort()
    {
        return GetInstance().Call(Methods.GetHostedDedicatedServerPort).AsInt64();
    }
    
    public static string GetListenSocketAddress(uint socket, bool withPort = true)
    {
        return GetInstance().Call(Methods.GetListenSocketAddress, socket, withPort).As<string>();
    }
    
    public static string GetIdentity()
    {
        return GetInstance().Call(Methods.GetIdentity).As<string>();
    }
    
    public static Godot.Collections.Dictionary GetRemoteFakeIPForConnection(uint connection)
    {
        return GetInstance().Call(Methods.GetRemoteFakeIPForConnection, connection).AsGodotDictionary();
    }
    
    public static NetworkingAvailability InitAuthentication()
    {
        return (NetworkingAvailability)GetInstance().Call(Methods.InitAuthentication).AsInt64();
    }
    
    public static Godot.Collections.Array ReceiveMessagesOnConnection(uint connection, long maxMessages)
    {
        return GetInstance().Call(Methods.ReceiveMessagesOnConnection, connection, maxMessages).AsGodotArray();
    }
    
    public static Godot.Collections.Array ReceiveMessagesOnPollGroup(uint pollGroup, long maxMessages)
    {
        return GetInstance().Call(Methods.ReceiveMessagesOnPollGroup, pollGroup, maxMessages).AsGodotArray();
    }
    
    public static void ResetIdentity(string thisIdentity)
    {
        GetInstance().Call(Methods.ResetIdentity, thisIdentity);
    }
    
    public static void RunNetworkingCallbacks()
    {
        GetInstance().Call(Methods.RunNetworkingCallbacks);
    }
    
    public static void SendMessages(int messages, byte[] data, uint connectionHandle, long flags)
    {
        GetInstance().Call(Methods.SendMessages, messages, data, connectionHandle, flags);
    }
    
    public static Godot.Collections.Dictionary SendMessageToConnection(uint connectionHandle, byte[] data, long flags)
    {
        return GetInstance().Call(Methods.SendMessageToConnection, connectionHandle, data, flags).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary SetCertificate(byte[] certificate)
    {
        return GetInstance().Call(Methods.SetCertificate, certificate).AsGodotDictionary();
    }
    
    public static bool SetConnectionPollGroup(uint connectionHandle, long pollGroup)
    {
        return GetInstance().Call(Methods.SetConnectionPollGroup, connectionHandle, pollGroup).As<bool>();
    }
    
    public static void SetConnectionName(uint peer, string name)
    {
        GetInstance().Call(Methods.SetConnectionName, peer, name);
    }

    public enum NetworkingConfigValue : long
    {
        Invalid = 0,
        FakePacketLossSend = 2,
        FakePacketLossRecv = 3,
        FakePacketLagSend = 4,
        FakePacketLagRecv = 5,
        FakePacketReorderSend = 6,
        FakePacketReorderRecv = 7,
        FakePacketReorderTime = 8,
        FakePacketDupSend = 26,
        FakePacketDupRevc = 27,
        FakePacketDupTimeMax = 28,
        PacketTraceMaxBytes = 41,
        FakeRateLimitSendRate = 42,
        FakeRateLimitSendBurst = 43,
        FakeRateLimitRecvRate = 44,
        FakeRateLimitRecvBurst = 45,
        ConnectionUserData = 40,
        TimeoutInitial = 24,
        TimeoutConnected = 25,
        SendBufferSize = 9,
        RecvBufferSize = 47,
        RecvBufferMessages = 48,
        RecvMaxMessageSize = 49,
        RecvMaxSegmentsPerPacket = 50,
        SendRateMin = 10,
        SendRateMax = 11,
        NagleTime = 12,
        IPAllowWithoutAuth = 23,
        MtuPacketSize = 32,
        MtuDataSize = 33,
        Unencrypted = 34,
        SymmetricConnect = 37,
        LocalVirtualPort = 38,
        DualWifiEnable = 39,
        EnableDiagnosticsUi = 46,
        SdrClientConsecPingTimeoutFailInitial = 19,
        SdrClientConsecPingTimeoutFail = 20,
        SdrClientMinPingsBeforePingAccurate = 21,
        SdrClientSingleSocket = 22,
        SdrClientForceRelayCluster = 29,
        SdrClientDebugTicketAddress = 30,
        SdrClientForceProxyAddr = 31,
        SdrClientFakeClusterPing = 36,
        LogLevelAckRtt = 13,
        LogLevelPacketDecode = 14,
        LogLevelMessage = 15,
        LogLevelPacketGaps = 16,
        LogLevelP2PRendezvous = 17,
        LogLevelSrdRelayPings = 18,
        CallbackConnectionStatusChanged = 201,
        CallbackAuthStatusChanged = 202,
        CallbackRelayNetworkStatusChanged = 203,
        CallbackMessageSessionRequest = 204,
        CallbackMessagesSessionFailed = 205,
        CallbackCreateConnectionSignaling = 206,
        CallbackFakeIPResult = 207,
        P2PStunServerList = 103,
        P2PTransportIceEnable = 104,
        P2PTransportIcePenalty = 105,
        P2PTransportSdrPenalty = 106,
        P2PTurnServerList = 107,
        P2PTurnUserList = 108,
        P2PTurnPassList = 109,
        P2PTransportIceImplementation = 110,
        ValueForce32Bit = 2147483647
    }

    public enum NetworkingConnectionEnd : long
    {
        Invalid = 0,
        AppMin = 1000,
        AppGeneric = 1000,
        AppMax = 1999,
        AppExceptionMin = 2000,
        AppExceptionGeneric = 2000,
        AppExceptionMax = 2999,
        LocalMin = 3000,
        LocalOfflineMode = 3001,
        LocalManyRelayConnectivity = 3002,
        LocalHostedServerPrimaryRelay = 3003,
        LocalNetworkConfig = 3004,
        LocalRights = 3005,
        NoPublicAddress = 3006,
        LocalMax = 3999,
        RemoveMin = 4000,
        RemoteTimeout = 4001,
        RemoteBadCrypt = 4002,
        RemoteBadCert = 4003,
        BadProtocolVersion = 4006,
        RemoteP2PIceNoPublicAddresses = 4007,
        RemoteMax = 4999,
        MiscMin = 5000,
        MiscGeneric = 5001,
        MiscInternalError = 5002,
        MiscTimeout = 5003,
        MiscSteamConnectivity = 5005,
        MiscNoRelaySessionsToClient = 5006,
        MiscP2PRendezvous = 5008,
        MiscP2PNatFirewall = 5009,
        MiscPeerSentNoConnection = 5010,
        MiscMax = 5999,
        Force32Bit = 2147483647
    }

    public enum NetworkingConnectionState : long
    {
        None = 0,
        Connecting = 1,
        FindingRoute = 2,
        Connected = 3,
        ClosedByPeer = 4,
        ProblemDetectedLocally = 5,
        FinWait = -1,
        Linger = -2,
        Dead = -3,
        Force32Bit = 2147483647
    }

    public enum NetworkingFakeIPType : long
    {
        Invalid = 0,
        NotFake = 1,
        GlobalIpv4 = 2,
        LocalIpv4 = 3,
        Force32Bit = 2147483647
    }

    public enum NetworkingGetConfigValueResult : long
    {
        BadValue = -1,
        BadScopeObj = -2,
        BufferTooSmall = -3,
        Ok = 1,
        OkInherited = 2,
        Force32Bit = 2147483647
    }

    public enum NetworkingIdentityType : long
    {
        Invalid = 0,
        Steamid = 16,
        IPAddress = 1,
        GenericString = 2,
        GenericBytes = 3,
        UnknownType = 4,
        XboxPairwise = 17,
        SonyPsn = 18,
        GoogleStadia = 19,
        Force32Bit = 2147483647
    }

    public enum NetworkingSocketsDebugOutputType : long
    {
        None = 0,
        Bug = 1,
        Error = 2,
        Important = 3,
        Warning = 4,
        Msg = 5,
        Verbose = 6,
        Debug = 7,
        Everything = 8,
        Force32Bit = 2147483647
    }
}