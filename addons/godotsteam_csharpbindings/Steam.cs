using System;
using Godot;
using Godot.Collections;

namespace GodotSteam;

public static partial class Steam
{
    public static GodotObject Instance;

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

    public static bool IsSteamRunning()
    {
        return GetInstance().Call(Methods.IsSteamRunning).As<bool>();
    }

    public static void RunCallbacks()
    {
        GetInstance().Call(Methods.RunCallbacks);
    }

    public static bool RestartAppIfNecessary(uint appId)
    {
        return GetInstance().Call(Methods.RestartAppIfNecessary, appId).As<bool>();
    }
    
    public static bool SteamInit(bool retrieveStats = true, uint appId = 0)
    {
        if (appId == 0)
        {
            appId = Convert.ToUInt32(OS.GetEnvironment("SteamAppId"));
        }
        
        return GetInstance().Call(Methods.SteamInit, appId, retrieveStats).AsBool();
    }
    
    public static SteamInitExResult SteamInitEx(bool retrieveStats, uint appId = 0)
    {
        if (appId == 0)
        {
            appId = Convert.ToUInt32(OS.GetEnvironment("SteamAppId"));
        }
        
        var raw = GetInstance().Call(Methods.SteamInitEx, appId, retrieveStats).AsGodotDictionary();

        return new SteamInitExResult
        {
            Status = (SteamInitExStatus)raw["status"].AsInt32(),
            Verbal = raw["verbal"].AsString(),
        };
    }
    
    public static void SteamShutdown()
    {
        GetInstance().Call(Methods.SteamShutdown);
    }
    
    public static bool IsCybercafe()
    {
        return GetInstance().Call(Methods.IsCybercafe).As<bool>();
    }
    
    public enum AccountType : long
    {
        Invalid = 0,
        Individual = 1,
        Multiseat = 2,
        GameServer = 3,
        AnonGameServer = 4,
        Pending = 5,
        ContentServer = 6,
        Clan = 7,
        Chat = 8,
        ConsoleUser = 9,
        AnonUser = 10,
        Max = 11,
    }

    public enum AuthSessionResponse : long
    {
        Ok = 0,
        UserNotConnectedToSteam = 1,
        NoLicenseOrExpired = 2,
        VacBanned = 3,
        LoggedInElsewhere = 4,
        VacCheckTimedOut = 5,
        AuthTicketCanceled = 6,
        AuthTicketInvalidAlreadyUsed = 7,
        AuthTicketInvalid = 8,
        PublisherIssuedBan = 9,
        AuthTicketNetworkIdentityFailure = 10
    }

    public enum BeginAuthSessionResult : long
    {
        Ok = 0,
        InvalidTicket = 1,
        DuplicateRequest = 2,
        InvalidVersion = 3,
        GameMismatch = 4,
        ExpiredTicket = 5
    }

    public enum BroadcastUploadResult : long
    {
        None = 0,
        Ok = 1,
        InitFailed = 2,
        FrameFailed = 3,
        TimeOut = 4,
        BandwidthExceeded = 5,
        LowFps = 6,
        MissingKeyframes = 7,
        NoConnection = 8,
        RelayFailed = 9,
        SettingsChanged = 10,
        MissingAudio = 11,
        TooFarBehind = 12,
        TranscodeBehind = 13,
        NotAllowedToPlay = 14,
        Busy = 15,
        Banned = 16,
        AlreadyActive = 17,
        ForcedOff = 18,
        AudioBehind = 19,
        Shutdown = 20,
        Disconnect = 21,
        VideoInitFailed = 22,
        AudioInitFailed = 23,
    }

    [System.Flags]
    public enum ChatSteamIdInstanceFlags : long
    {
        AccountInstanceMask = 4095,
        InstanceFlagClan = 524288,
        InstanceFlagLobby = 262144,
        InstanceFlagMmsLobby = 131072
    }

    public enum DenyReason : long
    {
        Invalid = 0,
        InvalidVersion = 1,
        Generic = 2,
        NotLoggedOn = 3,
        NoLicense = 4,
        Cheater = 5,
        LoggedInElsewhere = 6,
        UnknownText = 7,
        IncompatibleAntiCheat = 8,
        MemoryCorruption = 9,
        IncompatibleSoftware = 10,
        SteamConnectionLost = 11,
        SteamConnectionError = 12,
        SteamResponseTimedOut = 13,
        SteamValidationStalled = 14,
        SteamOwnerLeftGuestUser = 15
    }

    public enum GameIdType : long
    {
        App = 0,
        GameMod = 1,
        Shortcut = 2,
        P2P = 3
    }

    public enum Universe : long
    {
        Invalid = 0,
        Public = 1,
        Beta = 2,
        Internal = 3,
        Dev = 4,
        Max = 5
    }

    public enum UserHasLicenseForAppResult : long
    {
        HasLicense = 0,
        DoesNotHaveLicense = 1,
        NoAuth = 2
    }

    public enum VoiceResult : long
    {
        Ok = 0,
        NotInitialized = 1,
        NotRecording = 2,
        NoDate = 3,
        BufferTooSmall = 4,
        DataCorrupted = 5,
        Restricted = 6,
        UnsupportedCodec = 7,
        ReceiverOutOfDate = 8,
        ReceiverDidNotAnswer = 9
    }
}