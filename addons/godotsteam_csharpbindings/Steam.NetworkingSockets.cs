namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Accepts the connection using the specified connection
    /// </summary>
    /// <param name="connection">The connection</param>
    /// <returns>The int</returns>
    public static int AcceptConnection(long connection)
    {
        return GetInstance().Call(Methods.AcceptConnection, connection).AsInt32();
    }
    
    /// <summary>
    /// Describes whether begin async request fake ip
    /// </summary>
    /// <param name="numPorts">The num ports</param>
    /// <returns>The bool</returns>
    public static bool BeginAsyncRequestFakeIP(long numPorts)
    {
        return GetInstance().Call(Methods.BeginAsyncRequestFakeIP, numPorts).AsBool();
    }
    
    /// <summary>
    /// Describes whether close connection
    /// </summary>
    /// <param name="peer">The peer</param>
    /// <param name="reason">The reason</param>
    /// <param name="debugMessage">The debug message</param>
    /// <param name="linger">The linger</param>
    /// <returns>The bool</returns>
    public static bool CloseConnection(uint peer, int reason, string debugMessage, bool linger)
    {
        return GetInstance().Call(Methods.CloseConnection, peer, reason, debugMessage, linger).AsBool();
    }
    
    /// <summary>
    /// Describes whether close listen socket
    /// </summary>
    /// <param name="socket">The socket</param>
    /// <returns>The bool</returns>
    public static bool CloseListenSocket(long socket)
    {
        return GetInstance().Call(Methods.CloseListenSocket, socket).AsBool();
    }
    
    /// <summary>
    /// Configures the connection lanes using the specified connection
    /// </summary>
    /// <param name="connection">The connection</param>
    /// <param name="lanes">The lanes</param>
    /// <param name="priorities">The priorities</param>
    /// <param name="weights">The weights</param>
    /// <returns>The int</returns>
    public static int ConfigureConnectionLanes(uint connection, int lanes, Godot.Collections.Array priorities, Godot.Collections.Array weights)
    {
        return GetInstance().Call(Methods.ConfigureConnectionLanes, connection, lanes, priorities, weights).AsInt32();
    }
    
    /// <summary>
    /// Connects the p 2 p using the specified identity reference
    /// </summary>
    /// <param name="identityReference">The identity reference</param>
    /// <param name="virtualPort">The virtual port</param>
    /// <param name="options">The options</param>
    /// <returns>The uint</returns>
    public static uint ConnectP2P(string identityReference, int virtualPort, Godot.Collections.Array options)
    {
        return GetInstance().Call(Methods.ConnectP2P, identityReference, virtualPort, options).AsUInt32();
    }
    
    /// <summary>
    /// Connects the by ip address using the specified i p address with port
    /// </summary>
    /// <param name="iPAddressWithPort">The address with port</param>
    /// <param name="options">The options</param>
    /// <returns>The uint</returns>
    public static uint ConnectByIPAddress(string iPAddressWithPort, Godot.Collections.Array options)
    {
        return GetInstance().Call(Methods.ConnectByIPAddress, iPAddressWithPort, options).AsUInt32();
    }
    
    /// <summary>
    /// Connects the to hosted dedicated server using the specified identity reference
    /// </summary>
    /// <param name="identityReference">The identity reference</param>
    /// <param name="virtualPort">The virtual port</param>
    /// <param name="options">The options</param>
    /// <returns>The uint</returns>
    public static uint ConnectToHostedDedicatedServer(string identityReference, int virtualPort, Godot.Collections.Array options)
    {
        return GetInstance().Call(Methods.ConnectToHostedDedicatedServer, identityReference, virtualPort, options).AsUInt32();
    }
    
    /// <summary>
    /// Creates the fake udp port using the specified fake server port
    /// </summary>
    /// <param name="fakeServerPort">The fake server port</param>
    public static void CreateFakeUDPPort(long fakeServerPort)
    {
        GetInstance().Call(Methods.CreateFakeUDPPort, fakeServerPort);
    }
    
    /// <summary>
    /// Creates the hosted dedicated server listen socket using the specified virtual port
    /// </summary>
    /// <param name="virtualPort">The virtual port</param>
    /// <param name="options">The options</param>
    /// <returns>The uint</returns>
    public static uint CreateHostedDedicatedServerListenSocket(int virtualPort, Godot.Collections.Array options)
    {
        return GetInstance().Call(Methods.CreateHostedDedicatedServerListenSocket, virtualPort, options).AsUInt32();
    }
    
    /// <summary>
    /// Creates the listen socket ip using the specified i p reference
    /// </summary>
    /// <param name="iPReference">The reference</param>
    /// <param name="options">The options</param>
    /// <returns>The uint</returns>
    public static uint CreateListenSocketIP(string iPReference, Godot.Collections.Array options)
    {
        return GetInstance().Call(Methods.CreateListenSocketIP, iPReference, options).AsUInt32();
    }
    
    /// <summary>
    /// Creates the listen socket p 2 p using the specified virtual port
    /// </summary>
    /// <param name="virtualPort">The virtual port</param>
    /// <param name="options">The options</param>
    /// <returns>The uint</returns>
    public static uint CreateListenSocketP2P(int virtualPort, Godot.Collections.Array options)
    {
        return GetInstance().Call(Methods.CreateListenSocketP2P, virtualPort, options).AsUInt32();
    }
    
    /// <summary>
    /// Creates the listen socket p 2 p fake ip using the specified fake port
    /// </summary>
    /// <param name="fakePort">The fake port</param>
    /// <param name="options">The options</param>
    /// <returns>The uint</returns>
    public static uint CreateListenSocketP2PFakeIP(int fakePort, Godot.Collections.Array options)
    {
        return GetInstance().Call(Methods.CreateListenSocketP2PFakeIP, fakePort, options).AsUInt32();
    }
    
    /// <summary>
    /// Creates the poll group
    /// </summary>
    /// <returns>The long</returns>
    public static long CreatePollGroup()
    {
        return GetInstance().Call(Methods.CreatePollGroup).AsInt64();
    }
    
    /// <summary>
    /// Creates the socket pair using the specified loopback
    /// </summary>
    /// <param name="loopback">The loopback</param>
    /// <param name="identityReference1">The identity reference</param>
    /// <param name="identityReference2">The identity reference</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary CreateSocketPair(bool loopback, string identityReference1, string identityReference2)
    {
        return GetInstance().Call(Methods.CreateSocketPair, loopback, identityReference1, identityReference2).AsGodotDictionary();
    }
    
    /// <summary>
    /// Describes whether destroy poll group
    /// </summary>
    /// <param name="pollGroup">The poll group</param>
    /// <returns>The bool</returns>
    public static bool DestroyPollGroup(long pollGroup)
    {
        return GetInstance().Call(Methods.DestroyPollGroup, pollGroup).AsBool();
    }
    
    /// <summary>
    /// Flushes the messages on connection using the specified connection handle
    /// </summary>
    /// <param name="connectionHandle">The connection handle</param>
    /// <returns>The int</returns>
    public static int FlushMessagesOnConnection(long connectionHandle)
    {
        return GetInstance().Call(Methods.FlushMessagesOnConnection, connectionHandle).AsInt32();
    }
    
    /// <summary>
    /// Gets the authentication status
    /// </summary>
    /// <returns>The networking availability</returns>
    public static NetworkingAvailability GetAuthenticationStatus()
    {
        return (NetworkingAvailability)GetInstance().Call(Methods.GetAuthenticationStatus).AsInt64();
    }
    
    /// <summary>
    /// Gets the certificate request
    /// </summary>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetCertificateRequest()
    {
        return GetInstance().Call(Methods.GetCertificateRequest).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the connection info using the specified connection handle
    /// </summary>
    /// <param name="connectionHandle">The connection handle</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetConnectionInfo(long connectionHandle)
    {
        return GetInstance().Call(Methods.GetConnectionInfo, connectionHandle).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the connection name using the specified peer
    /// </summary>
    /// <param name="peer">The peer</param>
    /// <returns>The string</returns>
    public static string GetConnectionName(long peer)
    {
        return GetInstance().Call(Methods.GetConnectionName, peer).AsString();
    }
    
    /// <summary>
    /// Gets the connection real time status using the specified connection handle
    /// </summary>
    /// <param name="connectionHandle">The connection handle</param>
    /// <param name="lanes">The lanes</param>
    /// <param name="getStatus">The get status</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetConnectionRealTimeStatus(uint connectionHandle, int lanes, bool getStatus = true)
    {
        return GetInstance().Call(Methods.GetConnectionRealTimeStatus, connectionHandle, lanes, getStatus).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the connection user data using the specified peer
    /// </summary>
    /// <param name="peer">The peer</param>
    /// <returns>The ulong</returns>
    public static ulong GetConnectionUserData(long peer)
    {
        return GetInstance().Call(Methods.GetConnectionUserData, peer).AsUInt64();
    }
    
    /// <summary>
    /// Gets the detailed connection status using the specified connection handle
    /// </summary>
    /// <param name="connectionHandle">The connection handle</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetDetailedConnectionStatus(long connectionHandle)
    {
        return GetInstance().Call(Methods.GetDetailedConnectionStatus, connectionHandle).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the fake ip using the specified first port
    /// </summary>
    /// <param name="firstPort">The first port</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetFakeIP(long firstPort = 0)
    {
        return GetInstance().Call(Methods.GetFakeIP, firstPort).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the hosted dedicated server pop id
    /// </summary>
    /// <returns>The long</returns>
    public static long GetHostedDedicatedServerPOPId()
    {
        return GetInstance().Call(Methods.GetHostedDedicatedServerPOPId).AsInt64();
    }
    
    /// <summary>
    /// Gets the hosted dedicated server port
    /// </summary>
    /// <returns>The long</returns>
    public static long GetHostedDedicatedServerPort()
    {
        return GetInstance().Call(Methods.GetHostedDedicatedServerPort).AsInt64();
    }
    
    /// <summary>
    /// Gets the listen socket address using the specified socket
    /// </summary>
    /// <param name="socket">The socket</param>
    /// <param name="withPort">The with port</param>
    /// <returns>The string</returns>
    public static string GetListenSocketAddress(uint socket, bool withPort = true)
    {
        return GetInstance().Call(Methods.GetListenSocketAddress, socket, withPort).AsString();
    }
    
    /// <summary>
    /// Gets the identity
    /// </summary>
    /// <returns>The string</returns>
    public static string GetIdentity()
    {
        return GetInstance().Call(Methods.GetIdentity).AsString();
    }
    
    /// <summary>
    /// Gets the remote fake ip for connection using the specified connection
    /// </summary>
    /// <param name="connection">The connection</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetRemoteFakeIPForConnection(long connection)
    {
        return GetInstance().Call(Methods.GetRemoteFakeIPForConnection, connection).AsGodotDictionary();
    }
    
    /// <summary>
    /// Inits the authentication
    /// </summary>
    /// <returns>The networking availability</returns>
    public static NetworkingAvailability InitAuthentication()
    {
        return (NetworkingAvailability)GetInstance().Call(Methods.InitAuthentication).AsInt64();
    }
    
    /// <summary>
    /// Receives the messages on connection using the specified connection
    /// </summary>
    /// <param name="connection">The connection</param>
    /// <param name="maxMessages">The max messages</param>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array ReceiveMessagesOnConnection(uint connection, long maxMessages)
    {
        return GetInstance().Call(Methods.ReceiveMessagesOnConnection, connection, maxMessages).AsGodotArray();
    }
    
    /// <summary>
    /// Receives the messages on poll group using the specified poll group
    /// </summary>
    /// <param name="pollGroup">The poll group</param>
    /// <param name="maxMessages">The max messages</param>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array ReceiveMessagesOnPollGroup(uint pollGroup, long maxMessages)
    {
        return GetInstance().Call(Methods.ReceiveMessagesOnPollGroup, pollGroup, maxMessages).AsGodotArray();
    }
    
    /// <summary>
    /// Resets the identity using the specified this identity
    /// </summary>
    /// <param name="thisIdentity">The this identity</param>
    public static void ResetIdentity(string thisIdentity)
    {
        GetInstance().Call(Methods.ResetIdentity, thisIdentity);
    }
    
    /// <summary>
    /// Runs the networking callbacks
    /// </summary>
    public static void RunNetworkingCallbacks()
    {
        GetInstance().Call(Methods.RunNetworkingCallbacks);
    }
    
    /// <summary>
    /// Sends the messages using the specified messages
    /// </summary>
    /// <param name="messages">The messages</param>
    /// <param name="data">The data</param>
    /// <param name="connectionHandle">The connection handle</param>
    /// <param name="flags">The flags</param>
    public static void SendMessages(int messages, byte[] data, uint connectionHandle, long flags)
    {
        GetInstance().Call(Methods.SendMessages, messages, data, connectionHandle, flags);
    }
    
    /// <summary>
    /// Sends the message to connection using the specified connection handle
    /// </summary>
    /// <param name="connectionHandle">The connection handle</param>
    /// <param name="data">The data</param>
    /// <param name="flags">The flags</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary SendMessageToConnection(uint connectionHandle, byte[] data, long flags)
    {
        return GetInstance().Call(Methods.SendMessageToConnection, connectionHandle, data, flags).AsGodotDictionary();
    }
    
    /// <summary>
    /// Sets the certificate using the specified certificate
    /// </summary>
    /// <param name="certificate">The certificate</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary SetCertificate(byte[] certificate)
    {
        return GetInstance().Call(Methods.SetCertificate, certificate).AsGodotDictionary();
    }
    
    /// <summary>
    /// Describes whether set connection poll group
    /// </summary>
    /// <param name="connectionHandle">The connection handle</param>
    /// <param name="pollGroup">The poll group</param>
    /// <returns>The bool</returns>
    public static bool SetConnectionPollGroup(uint connectionHandle, long pollGroup)
    {
        return GetInstance().Call(Methods.SetConnectionPollGroup, connectionHandle, pollGroup).AsBool();
    }
    
    /// <summary>
    /// Sets the connection name using the specified peer
    /// </summary>
    /// <param name="peer">The peer</param>
    /// <param name="name">The name</param>
    public static void SetConnectionName(uint peer, string name)
    {
        GetInstance().Call(Methods.SetConnectionName, peer, name);
    }

    /// <summary>
    /// The networking config value enum
    /// </summary>
    public enum NetworkingConfigValue : long
    {
        /// <summary>
        /// The invalid networking config value
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The fake packet loss send networking config value
        /// </summary>
        FakePacketLossSend = 2,
        /// <summary>
        /// The fake packet loss recv networking config value
        /// </summary>
        FakePacketLossRecv = 3,
        /// <summary>
        /// The fake packet lag send networking config value
        /// </summary>
        FakePacketLagSend = 4,
        /// <summary>
        /// The fake packet lag recv networking config value
        /// </summary>
        FakePacketLagRecv = 5,
        /// <summary>
        /// The fake packet reorder send networking config value
        /// </summary>
        FakePacketReorderSend = 6,
        /// <summary>
        /// The fake packet reorder recv networking config value
        /// </summary>
        FakePacketReorderRecv = 7,
        /// <summary>
        /// The fake packet reorder time networking config value
        /// </summary>
        FakePacketReorderTime = 8,
        /// <summary>
        /// The fake packet dup send networking config value
        /// </summary>
        FakePacketDupSend = 26,
        /// <summary>
        /// The fake packet dup revc networking config value
        /// </summary>
        FakePacketDupRevc = 27,
        /// <summary>
        /// The fake packet dup time max networking config value
        /// </summary>
        FakePacketDupTimeMax = 28,
        /// <summary>
        /// The packet trace max bytes networking config value
        /// </summary>
        PacketTraceMaxBytes = 41,
        /// <summary>
        /// The fake rate limit send rate networking config value
        /// </summary>
        FakeRateLimitSendRate = 42,
        /// <summary>
        /// The fake rate limit send burst networking config value
        /// </summary>
        FakeRateLimitSendBurst = 43,
        /// <summary>
        /// The fake rate limit recv rate networking config value
        /// </summary>
        FakeRateLimitRecvRate = 44,
        /// <summary>
        /// The fake rate limit recv burst networking config value
        /// </summary>
        FakeRateLimitRecvBurst = 45,
        /// <summary>
        /// The connection user data networking config value
        /// </summary>
        ConnectionUserData = 40,
        /// <summary>
        /// The timeout initial networking config value
        /// </summary>
        TimeoutInitial = 24,
        /// <summary>
        /// The timeout connected networking config value
        /// </summary>
        TimeoutConnected = 25,
        /// <summary>
        /// The send buffer size networking config value
        /// </summary>
        SendBufferSize = 9,
        /// <summary>
        /// The recv buffer size networking config value
        /// </summary>
        RecvBufferSize = 47,
        /// <summary>
        /// The recv buffer messages networking config value
        /// </summary>
        RecvBufferMessages = 48,
        /// <summary>
        /// The recv max message size networking config value
        /// </summary>
        RecvMaxMessageSize = 49,
        /// <summary>
        /// The recv max segments per packet networking config value
        /// </summary>
        RecvMaxSegmentsPerPacket = 50,
        /// <summary>
        /// The send rate min networking config value
        /// </summary>
        SendRateMin = 10,
        /// <summary>
        /// The send rate max networking config value
        /// </summary>
        SendRateMax = 11,
        /// <summary>
        /// The nagle time networking config value
        /// </summary>
        NagleTime = 12,
        /// <summary>
        /// The ip allow without auth networking config value
        /// </summary>
        IPAllowWithoutAuth = 23,
        /// <summary>
        /// The mtu packet size networking config value
        /// </summary>
        MtuPacketSize = 32,
        /// <summary>
        /// The mtu data size networking config value
        /// </summary>
        MtuDataSize = 33,
        /// <summary>
        /// The unencrypted networking config value
        /// </summary>
        Unencrypted = 34,
        /// <summary>
        /// The symmetric connect networking config value
        /// </summary>
        SymmetricConnect = 37,
        /// <summary>
        /// The local virtual port networking config value
        /// </summary>
        LocalVirtualPort = 38,
        /// <summary>
        /// The dual wifi enable networking config value
        /// </summary>
        DualWifiEnable = 39,
        /// <summary>
        /// The enable diagnostics ui networking config value
        /// </summary>
        EnableDiagnosticsUi = 46,
        /// <summary>
        /// The sdr client consec ping timeout fail initial networking config value
        /// </summary>
        SdrClientConsecPingTimeoutFailInitial = 19,
        /// <summary>
        /// The sdr client consec ping timeout fail networking config value
        /// </summary>
        SdrClientConsecPingTimeoutFail = 20,
        /// <summary>
        /// The sdr client min pings before ping accurate networking config value
        /// </summary>
        SdrClientMinPingsBeforePingAccurate = 21,
        /// <summary>
        /// The sdr client single socket networking config value
        /// </summary>
        SdrClientSingleSocket = 22,
        /// <summary>
        /// The sdr client force relay cluster networking config value
        /// </summary>
        SdrClientForceRelayCluster = 29,
        /// <summary>
        /// The sdr client debug ticket address networking config value
        /// </summary>
        SdrClientDebugTicketAddress = 30,
        /// <summary>
        /// The sdr client force proxy addr networking config value
        /// </summary>
        SdrClientForceProxyAddr = 31,
        /// <summary>
        /// The sdr client fake cluster ping networking config value
        /// </summary>
        SdrClientFakeClusterPing = 36,
        /// <summary>
        /// The log level ack rtt networking config value
        /// </summary>
        LogLevelAckRtt = 13,
        /// <summary>
        /// The log level packet decode networking config value
        /// </summary>
        LogLevelPacketDecode = 14,
        /// <summary>
        /// The log level message networking config value
        /// </summary>
        LogLevelMessage = 15,
        /// <summary>
        /// The log level packet gaps networking config value
        /// </summary>
        LogLevelPacketGaps = 16,
        /// <summary>
        /// The log level rendezvous networking config value
        /// </summary>
        LogLevelP2PRendezvous = 17,
        /// <summary>
        /// The log level srd relay pings networking config value
        /// </summary>
        LogLevelSrdRelayPings = 18,
        /// <summary>
        /// The callback connection status changed networking config value
        /// </summary>
        CallbackConnectionStatusChanged = 201,
        /// <summary>
        /// The callback auth status changed networking config value
        /// </summary>
        CallbackAuthStatusChanged = 202,
        /// <summary>
        /// The callback relay network status changed networking config value
        /// </summary>
        CallbackRelayNetworkStatusChanged = 203,
        /// <summary>
        /// The callback message session request networking config value
        /// </summary>
        CallbackMessageSessionRequest = 204,
        /// <summary>
        /// The callback messages session failed networking config value
        /// </summary>
        CallbackMessagesSessionFailed = 205,
        /// <summary>
        /// The callback create connection signaling networking config value
        /// </summary>
        CallbackCreateConnectionSignaling = 206,
        /// <summary>
        /// The callback fake ip result networking config value
        /// </summary>
        CallbackFakeIPResult = 207,
        /// <summary>
        /// The stun server list networking config value
        /// </summary>
        P2PStunServerList = 103,
        /// <summary>
        /// The transport ice enable networking config value
        /// </summary>
        P2PTransportIceEnable = 104,
        /// <summary>
        /// The transport ice penalty networking config value
        /// </summary>
        P2PTransportIcePenalty = 105,
        /// <summary>
        /// The transport sdr penalty networking config value
        /// </summary>
        P2PTransportSdrPenalty = 106,
        /// <summary>
        /// The turn server list networking config value
        /// </summary>
        P2PTurnServerList = 107,
        /// <summary>
        /// The turn user list networking config value
        /// </summary>
        P2PTurnUserList = 108,
        /// <summary>
        /// The turn pass list networking config value
        /// </summary>
        P2PTurnPassList = 109,
        /// <summary>
        /// The transport ice implementation networking config value
        /// </summary>
        P2PTransportIceImplementation = 110,
        /// <summary>
        /// The value force 32 bit networking config value
        /// </summary>
        ValueForce32Bit = 2147483647
    }

    /// <summary>
    /// The networking connection end enum
    /// </summary>
    public enum NetworkingConnectionEnd : long
    {
        /// <summary>
        /// The invalid networking connection end
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The app min networking connection end
        /// </summary>
        AppMin = 1000,
        /// <summary>
        /// The app generic networking connection end
        /// </summary>
        AppGeneric = 1000,
        /// <summary>
        /// The app max networking connection end
        /// </summary>
        AppMax = 1999,
        /// <summary>
        /// The app exception min networking connection end
        /// </summary>
        AppExceptionMin = 2000,
        /// <summary>
        /// The app exception generic networking connection end
        /// </summary>
        AppExceptionGeneric = 2000,
        /// <summary>
        /// The app exception max networking connection end
        /// </summary>
        AppExceptionMax = 2999,
        /// <summary>
        /// The local min networking connection end
        /// </summary>
        LocalMin = 3000,
        /// <summary>
        /// The local offline mode networking connection end
        /// </summary>
        LocalOfflineMode = 3001,
        /// <summary>
        /// The local many relay connectivity networking connection end
        /// </summary>
        LocalManyRelayConnectivity = 3002,
        /// <summary>
        /// The local hosted server primary relay networking connection end
        /// </summary>
        LocalHostedServerPrimaryRelay = 3003,
        /// <summary>
        /// The local network config networking connection end
        /// </summary>
        LocalNetworkConfig = 3004,
        /// <summary>
        /// The local rights networking connection end
        /// </summary>
        LocalRights = 3005,
        /// <summary>
        /// The no public address networking connection end
        /// </summary>
        NoPublicAddress = 3006,
        /// <summary>
        /// The local max networking connection end
        /// </summary>
        LocalMax = 3999,
        /// <summary>
        /// The remove min networking connection end
        /// </summary>
        RemoveMin = 4000,
        /// <summary>
        /// The remote timeout networking connection end
        /// </summary>
        RemoteTimeout = 4001,
        /// <summary>
        /// The remote bad crypt networking connection end
        /// </summary>
        RemoteBadCrypt = 4002,
        /// <summary>
        /// The remote bad cert networking connection end
        /// </summary>
        RemoteBadCert = 4003,
        /// <summary>
        /// The bad protocol version networking connection end
        /// </summary>
        BadProtocolVersion = 4006,
        /// <summary>
        /// The remote ice no public addresses networking connection end
        /// </summary>
        RemoteP2PIceNoPublicAddresses = 4007,
        /// <summary>
        /// The remote max networking connection end
        /// </summary>
        RemoteMax = 4999,
        /// <summary>
        /// The misc min networking connection end
        /// </summary>
        MiscMin = 5000,
        /// <summary>
        /// The misc generic networking connection end
        /// </summary>
        MiscGeneric = 5001,
        /// <summary>
        /// The misc internal error networking connection end
        /// </summary>
        MiscInternalError = 5002,
        /// <summary>
        /// The misc timeout networking connection end
        /// </summary>
        MiscTimeout = 5003,
        /// <summary>
        /// The misc steam connectivity networking connection end
        /// </summary>
        MiscSteamConnectivity = 5005,
        /// <summary>
        /// The misc no relay sessions to client networking connection end
        /// </summary>
        MiscNoRelaySessionsToClient = 5006,
        /// <summary>
        /// The misc rendezvous networking connection end
        /// </summary>
        MiscP2PRendezvous = 5008,
        /// <summary>
        /// The misc nat firewall networking connection end
        /// </summary>
        MiscP2PNatFirewall = 5009,
        /// <summary>
        /// The misc peer sent no connection networking connection end
        /// </summary>
        MiscPeerSentNoConnection = 5010,
        /// <summary>
        /// The misc max networking connection end
        /// </summary>
        MiscMax = 5999,
        /// <summary>
        /// The force 32 bit networking connection end
        /// </summary>
        Force32Bit = 2147483647
    }

    /// <summary>
    /// The networking connection state enum
    /// </summary>
    public enum NetworkingConnectionState : long
    {
        /// <summary>
        /// The none networking connection state
        /// </summary>
        None = 0,
        /// <summary>
        /// The connecting networking connection state
        /// </summary>
        Connecting = 1,
        /// <summary>
        /// The finding route networking connection state
        /// </summary>
        FindingRoute = 2,
        /// <summary>
        /// The connected networking connection state
        /// </summary>
        Connected = 3,
        /// <summary>
        /// The closed by peer networking connection state
        /// </summary>
        ClosedByPeer = 4,
        /// <summary>
        /// The problem detected locally networking connection state
        /// </summary>
        ProblemDetectedLocally = 5,
        /// <summary>
        /// The fin wait networking connection state
        /// </summary>
        FinWait = -1,
        /// <summary>
        /// The linger networking connection state
        /// </summary>
        Linger = -2,
        /// <summary>
        /// The dead networking connection state
        /// </summary>
        Dead = -3,
        /// <summary>
        /// The force 32 bit networking connection state
        /// </summary>
        Force32Bit = 2147483647
    }

    /// <summary>
    /// The networking fake ip type enum
    /// </summary>
    public enum NetworkingFakeIPType : long
    {
        /// <summary>
        /// The invalid networking fake ip type
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The not fake networking fake ip type
        /// </summary>
        NotFake = 1,
        /// <summary>
        /// The global ipv networking fake ip type
        /// </summary>
        GlobalIpv4 = 2,
        /// <summary>
        /// The local ipv networking fake ip type
        /// </summary>
        LocalIpv4 = 3,
        /// <summary>
        /// The force 32 bit networking fake ip type
        /// </summary>
        Force32Bit = 2147483647
    }

    /// <summary>
    /// The networking get config value result enum
    /// </summary>
    public enum NetworkingGetConfigValueResult : long
    {
        /// <summary>
        /// The bad value networking get config value result
        /// </summary>
        BadValue = -1,
        /// <summary>
        /// The bad scope obj networking get config value result
        /// </summary>
        BadScopeObj = -2,
        /// <summary>
        /// The buffer too small networking get config value result
        /// </summary>
        BufferTooSmall = -3,
        /// <summary>
        /// The ok networking get config value result
        /// </summary>
        Ok = 1,
        /// <summary>
        /// The ok inherited networking get config value result
        /// </summary>
        OkInherited = 2,
        /// <summary>
        /// The force 32 bit networking get config value result
        /// </summary>
        Force32Bit = 2147483647
    }

    /// <summary>
    /// The networking identity type enum
    /// </summary>
    public enum NetworkingIdentityType : long
    {
        /// <summary>
        /// The invalid networking identity type
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The steamid networking identity type
        /// </summary>
        Steamid = 16,
        /// <summary>
        /// The ip address networking identity type
        /// </summary>
        IPAddress = 1,
        /// <summary>
        /// The generic string networking identity type
        /// </summary>
        GenericString = 2,
        /// <summary>
        /// The generic bytes networking identity type
        /// </summary>
        GenericBytes = 3,
        /// <summary>
        /// The unknown type networking identity type
        /// </summary>
        UnknownType = 4,
        /// <summary>
        /// The xbox pairwise networking identity type
        /// </summary>
        XboxPairwise = 17,
        /// <summary>
        /// The sony psn networking identity type
        /// </summary>
        SonyPsn = 18,
        /// <summary>
        /// The google stadia networking identity type
        /// </summary>
        GoogleStadia = 19,
        /// <summary>
        /// The force 32 bit networking identity type
        /// </summary>
        Force32Bit = 2147483647
    }

    /// <summary>
    /// The networking sockets debug output type enum
    /// </summary>
    public enum NetworkingSocketsDebugOutputType : long
    {
        /// <summary>
        /// The none networking sockets debug output type
        /// </summary>
        None = 0,
        /// <summary>
        /// The bug networking sockets debug output type
        /// </summary>
        Bug = 1,
        /// <summary>
        /// The error networking sockets debug output type
        /// </summary>
        Error = 2,
        /// <summary>
        /// The important networking sockets debug output type
        /// </summary>
        Important = 3,
        /// <summary>
        /// The warning networking sockets debug output type
        /// </summary>
        Warning = 4,
        /// <summary>
        /// The msg networking sockets debug output type
        /// </summary>
        Msg = 5,
        /// <summary>
        /// The verbose networking sockets debug output type
        /// </summary>
        Verbose = 6,
        /// <summary>
        /// The debug networking sockets debug output type
        /// </summary>
        Debug = 7,
        /// <summary>
        /// The everything networking sockets debug output type
        /// </summary>
        Everything = 8,
        /// <summary>
        /// The force 32 bit networking sockets debug output type
        /// </summary>
        Force32Bit = 2147483647
    }
}