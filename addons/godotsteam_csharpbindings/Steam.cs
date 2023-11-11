using System;
using Godot;
using Godot.Collections;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The instance
    /// </summary>
    public static GodotObject Instance;

    /// <summary>
    /// Gets the instance
    /// </summary>
    /// <exception cref="Exception">GodotSteam cannot be instantiated.</exception>
    /// <exception cref="Exception">GodotSteam is not installed.</exception>
    /// <returns>The instance</returns>
    public static GodotObject GetInstance()
    {
        if (Instance != null) return Instance;
        
        if (!ClassDB.ClassExists("Steam"))
        {
            throw new Exception("GodotSteam is not installed.");
        }

        if (!ClassDB.CanInstantiate("Steam"))
        {
            throw new Exception("GodotSteam cannot be instantiated.");
        }

        Instance = ClassDB.Instantiate("Steam").AsGodotObject();
        return Instance;
    }

    /// <summary>
    /// Describes whether is steam running
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsSteamRunning()
    {
        return GetInstance().Call(Methods.IsSteamRunning).AsBool();
    }

    /// <summary>
    /// Runs the callbacks
    /// </summary>
    public static void RunCallbacks()
    {
        GetInstance().Call(Methods.RunCallbacks);
    }

    /// <summary>
    /// Describes whether restart app if necessary
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <returns>The bool</returns>
    public static bool RestartAppIfNecessary(uint appId)
    {
        return GetInstance().Call(Methods.RestartAppIfNecessary, appId).AsBool();
    }
    
    /// <summary>
    /// Initializes Steam
    /// </summary>
    /// <param name="retrieveStats">The retrieve stats</param>
    /// <returns>The steam init result</returns>
    public static SteamInitResult SteamInit(bool retrieveStats = true)
    {
        var raw = GetInstance().Call(Methods.SteamInit, retrieveStats).AsGodotDictionary();

        return new SteamInitResult
        {
            Status = (SteamInitStatus)raw["status"].AsInt32(),
            Verbal = raw["verbal"].AsString(),
        };
    }
    
    /// <summary>
    /// Initialized SteamEx
    /// </summary>
    /// <param name="retrieveStats">The retrieve stats</param>
    /// <returns>The steam init ex result</returns>
    public static SteamInitExResult SteamInitEx(bool retrieveStats)
    {
        var raw = GetInstance().Call(Methods.SteamInitEx, retrieveStats).AsGodotDictionary();

        return new SteamInitExResult
        {
            Status = (SteamInitExStatus)raw["status"].AsInt32(),
            Verbal = raw["verbal"].AsString(),
        };
    }
    
    /// <summary>
    /// Steams the shutdown
    /// </summary>
    public static void SteamShutdown()
    {
        GetInstance().Call(Methods.SteamShutdown);
    }
    
    /// <summary>
    /// Describes whether is cybercafe
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsCybercafe()
    {
        return GetInstance().Call(Methods.IsCybercafe).AsBool();
    }
    
    /// <summary>
    /// The account type enum
    /// </summary>
    public enum AccountType : long
    {
        /// <summary>
        /// The invalid account type
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The individual account type
        /// </summary>
        Individual = 1,
        /// <summary>
        /// The multiseat account type
        /// </summary>
        Multiseat = 2,
        /// <summary>
        /// The game server account type
        /// </summary>
        GameServer = 3,
        /// <summary>
        /// The anon game server account type
        /// </summary>
        AnonGameServer = 4,
        /// <summary>
        /// The pending account type
        /// </summary>
        Pending = 5,
        /// <summary>
        /// The content server account type
        /// </summary>
        ContentServer = 6,
        /// <summary>
        /// The clan account type
        /// </summary>
        Clan = 7,
        /// <summary>
        /// The chat account type
        /// </summary>
        Chat = 8,
        /// <summary>
        /// The console user account type
        /// </summary>
        ConsoleUser = 9,
        /// <summary>
        /// The anon user account type
        /// </summary>
        AnonUser = 10,
        /// <summary>
        /// The max account type
        /// </summary>
        Max = 11
    }

    /// <summary>
    /// The auth session response enum
    /// </summary>
    public enum AuthSessionResponse : long
    {
        /// <summary>
        /// The ok auth session response
        /// </summary>
        Ok = 0,
        /// <summary>
        /// The user not connected to steam auth session response
        /// </summary>
        UserNotConnectedToSteam = 1,
        /// <summary>
        /// The no license or expired auth session response
        /// </summary>
        NoLicenseOrExpired = 2,
        /// <summary>
        /// The vac banned auth session response
        /// </summary>
        VacBanned = 3,
        /// <summary>
        /// The logged in elsewhere auth session response
        /// </summary>
        LoggedInElsewhere = 4,
        /// <summary>
        /// The vac check timed out auth session response
        /// </summary>
        VacCheckTimedOut = 5,
        /// <summary>
        /// The auth ticket canceled auth session response
        /// </summary>
        AuthTicketCanceled = 6,
        /// <summary>
        /// The auth ticket invalid already used auth session response
        /// </summary>
        AuthTicketInvalidAlreadyUsed = 7,
        /// <summary>
        /// The auth ticket invalid auth session response
        /// </summary>
        AuthTicketInvalid = 8,
        /// <summary>
        /// The publisher issued ban auth session response
        /// </summary>
        PublisherIssuedBan = 9,
        /// <summary>
        /// The auth ticket network identity failure auth session response
        /// </summary>
        AuthTicketNetworkIdentityFailure = 10
    }

    /// <summary>
    /// The begin auth session result enum
    /// </summary>
    public enum BeginAuthSessionResult : long
    {
        /// <summary>
        /// The ok begin auth session result
        /// </summary>
        Ok = 0,
        /// <summary>
        /// The invalid ticket begin auth session result
        /// </summary>
        InvalidTicket = 1,
        /// <summary>
        /// The duplicate request begin auth session result
        /// </summary>
        DuplicateRequest = 2,
        /// <summary>
        /// The invalid version begin auth session result
        /// </summary>
        InvalidVersion = 3,
        /// <summary>
        /// The game mismatch begin auth session result
        /// </summary>
        GameMismatch = 4,
        /// <summary>
        /// The expired ticket begin auth session result
        /// </summary>
        ExpiredTicket = 5
    }

    /// <summary>
    /// The broadcast upload result enum
    /// </summary>
    public enum BroadcastUploadResult : long
    {
        /// <summary>
        /// The none broadcast upload result
        /// </summary>
        None = 0,
        /// <summary>
        /// The ok broadcast upload result
        /// </summary>
        Ok = 1,
        /// <summary>
        /// The init failed broadcast upload result
        /// </summary>
        InitFailed = 2,
        /// <summary>
        /// The frame failed broadcast upload result
        /// </summary>
        FrameFailed = 3,
        /// <summary>
        /// The time out broadcast upload result
        /// </summary>
        TimeOut = 4,
        /// <summary>
        /// The bandwidth exceeded broadcast upload result
        /// </summary>
        BandwidthExceeded = 5,
        /// <summary>
        /// The low fps broadcast upload result
        /// </summary>
        LowFps = 6,
        /// <summary>
        /// The missing keyframes broadcast upload result
        /// </summary>
        MissingKeyframes = 7,
        /// <summary>
        /// The no connection broadcast upload result
        /// </summary>
        NoConnection = 8,
        /// <summary>
        /// The relay failed broadcast upload result
        /// </summary>
        RelayFailed = 9,
        /// <summary>
        /// The settings changed broadcast upload result
        /// </summary>
        SettingsChanged = 10,
        /// <summary>
        /// The missing audio broadcast upload result
        /// </summary>
        MissingAudio = 11,
        /// <summary>
        /// The too far behind broadcast upload result
        /// </summary>
        TooFarBehind = 12,
        /// <summary>
        /// The transcode behind broadcast upload result
        /// </summary>
        TranscodeBehind = 13,
        /// <summary>
        /// The not allowed to play broadcast upload result
        /// </summary>
        NotAllowedToPlay = 14,
        /// <summary>
        /// The busy broadcast upload result
        /// </summary>
        Busy = 15,
        /// <summary>
        /// The banned broadcast upload result
        /// </summary>
        Banned = 16,
        /// <summary>
        /// The already active broadcast upload result
        /// </summary>
        AlreadyActive = 17,
        /// <summary>
        /// The forced off broadcast upload result
        /// </summary>
        ForcedOff = 18,
        /// <summary>
        /// The audio behind broadcast upload result
        /// </summary>
        AudioBehind = 19,
        /// <summary>
        /// The shutdown broadcast upload result
        /// </summary>
        Shutdown = 20,
        /// <summary>
        /// The disconnect broadcast upload result
        /// </summary>
        Disconnect = 21,
        /// <summary>
        /// The video init failed broadcast upload result
        /// </summary>
        VideoInitFailed = 22,
        /// <summary>
        /// The audio init failed broadcast upload result
        /// </summary>
        AudioInitFailed = 23
    }

    /// <summary>
    /// The chat steam id instance flags enum
    /// </summary>
    [System.Flags]
    public enum ChatSteamIdInstanceFlags : long
    {
        /// <summary>
        /// The account instance mask chat steam id instance flags
        /// </summary>
        AccountInstanceMask = 4095,
        /// <summary>
        /// The instance flag clan chat steam id instance flags
        /// </summary>
        InstanceFlagClan = 524288,
        /// <summary>
        /// The instance flag lobby chat steam id instance flags
        /// </summary>
        InstanceFlagLobby = 262144,
        /// <summary>
        /// The instance flag mms lobby chat steam id instance flags
        /// </summary>
        InstanceFlagMmsLobby = 131072
    }

    /// <summary>
    /// The deny reason enum
    /// </summary>
    public enum DenyReason : long
    {
        /// <summary>
        /// The invalid deny reason
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The invalid version deny reason
        /// </summary>
        InvalidVersion = 1,
        /// <summary>
        /// The generic deny reason
        /// </summary>
        Generic = 2,
        /// <summary>
        /// The not logged on deny reason
        /// </summary>
        NotLoggedOn = 3,
        /// <summary>
        /// The no license deny reason
        /// </summary>
        NoLicense = 4,
        /// <summary>
        /// The cheater deny reason
        /// </summary>
        Cheater = 5,
        /// <summary>
        /// The logged in elsewhere deny reason
        /// </summary>
        LoggedInElsewhere = 6,
        /// <summary>
        /// The unknown text deny reason
        /// </summary>
        UnknownText = 7,
        /// <summary>
        /// The incompatible anti cheat deny reason
        /// </summary>
        IncompatibleAntiCheat = 8,
        /// <summary>
        /// The memory corruption deny reason
        /// </summary>
        MemoryCorruption = 9,
        /// <summary>
        /// The incompatible software deny reason
        /// </summary>
        IncompatibleSoftware = 10,
        /// <summary>
        /// The steam connection lost deny reason
        /// </summary>
        SteamConnectionLost = 11,
        /// <summary>
        /// The steam connection error deny reason
        /// </summary>
        SteamConnectionError = 12,
        /// <summary>
        /// The steam response timed out deny reason
        /// </summary>
        SteamResponseTimedOut = 13,
        /// <summary>
        /// The steam validation stalled deny reason
        /// </summary>
        SteamValidationStalled = 14,
        /// <summary>
        /// The steam owner left guest user deny reason
        /// </summary>
        SteamOwnerLeftGuestUser = 15
    }

    /// <summary>
    /// The game id type enum
    /// </summary>
    public enum GameIdType : long
    {
        /// <summary>
        /// The app game id type
        /// </summary>
        App = 0,
        /// <summary>
        /// The game mod game id type
        /// </summary>
        GameMod = 1,
        /// <summary>
        /// The shortcut game id type
        /// </summary>
        Shortcut = 2,
        /// <summary>
        /// The  game id type
        /// </summary>
        P2P = 3
    }

    /// <summary>
    /// The universe enum
    /// </summary>
    public enum Universe : long
    {
        /// <summary>
        /// The invalid universe
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The public universe
        /// </summary>
        Public = 1,
        /// <summary>
        /// The beta universe
        /// </summary>
        Beta = 2,
        /// <summary>
        /// The internal universe
        /// </summary>
        Internal = 3,
        /// <summary>
        /// The dev universe
        /// </summary>
        Dev = 4,
        /// <summary>
        /// The max universe
        /// </summary>
        Max = 5
    }

    /// <summary>
    /// The user has license for app result enum
    /// </summary>
    public enum UserHasLicenseForAppResult : long
    {
        /// <summary>
        /// The has license user has license for app result
        /// </summary>
        HasLicense = 0,
        /// <summary>
        /// The does not have license user has license for app result
        /// </summary>
        DoesNotHaveLicense = 1,
        /// <summary>
        /// The no auth user has license for app result
        /// </summary>
        NoAuth = 2
    }

    /// <summary>
    /// The voice result enum
    /// </summary>
    public enum VoiceResult : long
    {
        /// <summary>
        /// The ok voice result
        /// </summary>
        Ok = 0,
        /// <summary>
        /// The not initialized voice result
        /// </summary>
        NotInitialized = 1,
        /// <summary>
        /// The not recording voice result
        /// </summary>
        NotRecording = 2,
        /// <summary>
        /// The no date voice result
        /// </summary>
        NoDate = 3,
        /// <summary>
        /// The buffer too small voice result
        /// </summary>
        BufferTooSmall = 4,
        /// <summary>
        /// The data corrupted voice result
        /// </summary>
        DataCorrupted = 5,
        /// <summary>
        /// The restricted voice result
        /// </summary>
        Restricted = 6,
        /// <summary>
        /// The unsupported codec voice result
        /// </summary>
        UnsupportedCodec = 7,
        /// <summary>
        /// The receiver out of date voice result
        /// </summary>
        ReceiverOutOfDate = 8,
        /// <summary>
        /// The receiver did not answer voice result
        /// </summary>
        ReceiverDidNotAnswer = 9
    }
}