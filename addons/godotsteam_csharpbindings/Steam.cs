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
        return GetInstance().Call(Methods.IsSteamRunning).AsBool();
    }

    public static void RunCallbacks()
    {
        GetInstance().Call(Methods.RunCallbacks);
    }

    public static bool RestartAppIfNecessary(uint appId)
    {
        return GetInstance().Call(Methods.RestartAppIfNecessary, appId).AsBool();
    }
    
    public static SteamInitResult SteamInit(bool retrieveStats = true)
    {
        var raw = GetInstance().Call(Methods.SteamInit, retrieveStats).AsGodotDictionary();

        return new SteamInitResult
        {
            Status = (SteamInitStatus)raw["status"].AsInt32(),
            Verbal = raw["verbal"].AsString(),
        };
    }
    
    public static SteamInitExResult SteamInitEx(bool retrieveStats)
    {
        var raw = GetInstance().Call(Methods.SteamInitEx, retrieveStats).AsGodotDictionary();

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
        return GetInstance().Call(Methods.IsCybercafe).AsBool();
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
        Max = 11
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
        AudioInitFailed = 23
    }

    public enum ChatEntryType : long
    {
        Invalid = 0,
        ChatMsg = 1,
        Typing = 2,
        InviteGame = 3,
        Emote = 4,
        LeftConversation = 6,
        Entered = 7,
        WasKicked = 8,
        WasBanned = 9,
        Disconnected = 10,
        HistoricalChat = 11,
        LinkBlocked = 14
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

    public enum NotificationPosition : long
    {
        Invalid = -1,
        TopLeft = 0,
        TopRight = 1,
        BottomLeft = 2,
        BottomRight = 3
    }

    public enum Result : long
    {
        None = 0,
        Ok = 1,
        Fail = 2,
        NoConnection = 3,
        InvalidPassword = 5,
        LoggedInElsewhere = 6,
        InvalidProtocolVer = 7,
        InvalidParam = 8,
        FileNotFound = 9,
        Busy = 10,
        InvalidState = 11,
        InvalidName = 12,
        InvalidEmail = 13,
        DuplicateName = 14,
        AccessDenied = 15,
        Timeout = 16,
        Banned = 17,
        AccountNotFound = 18,
        InvalidSteamid = 19,
        ServiceUnavailable = 20,
        NotLoggedOn = 21,
        Pending = 22,
        EncryptionFailure = 23,
        InsufficientPrivilege = 24,
        LimitExceeded = 25,
        Revoked = 26,
        Expired = 27,
        AlreadyRedeemed = 28,
        DuplicateRequest = 29,
        AlreadyOwned = 30,
        IPNotFound = 31,
        PersistFailed = 32,
        LockingFailed = 33,
        LogOnSessionReplaced = 34,
        ConnectFailed = 35,
        HandshakeFailed = 36,
        IOFailure = 37,
        RemoteDisconnect = 38,
        ShoppingCartNotFound = 39,
        Blocked = 40,
        Ignored = 41,
        NoMatch = 42,
        AccountDisabled = 43,
        ServiceReadOnly = 44,
        AccountNotFeatured = 45,
        AdministratoRok = 46,
        ContentVersion = 47,
        TryAnotherCm = 48,
        PasswordRequiredToKickSession = 49,
        AlreadyLoggedInElsewhere = 50,
        Suspended = 51,
        Cancelled = 52,
        DataCorruption = 53,
        DiskFull = 54,
        RemoteCallFailed = 55,
        PasswordUnset = 56,
        ExternalAccountUnlinked = 57,
        PsnTicketInvalid = 58,
        ExternalAccountAlreadyLinked = 59,
        RemoteFileConflict = 60,
        IllegalPassword = 61,
        SameAsPreviousValue = 62,
        AccountLogOnDenied = 63,
        CannotUseOldPassword = 64,
        InvalidLogInAuthCode = 65,
        AccountLogOnDeniedNoMail = 66,
        HardwareNotCapableOfIpt = 67,
        IptInitError = 68,
        ParentalControlRestricted = 69,
        FacebookQueryError = 70,
        ExpiredLoginAuthCode = 71,
        IPLoginRestrictionFailed = 72,
        AccountLockedDown = 73,
        AccountLogOnDeniedVerifiedEmailRequired = 74,
        NoMatchingUrl = 75,
        BadResponse = 76,
        RequirePasswordReentry = 77,
        ValueOutOfRange = 78,
        UnexpectedError = 79,
        Disabled = 80,
        InvalidCegSubmission = 81,
        RestrictedDevice = 82,
        RegionLocked = 83,
        RateLimitExceeded = 84,
        AccountLoginDeniedNeedTwoFactor = 85,
        ItemDeleted = 86,
        AccountLoginDeniedThrottle = 87,
        TwoFactorCodeMismatch = 88,
        TwoFactorActivationCodeMismatch = 89,
        AccountAssociatedToMultiplePartners = 90,
        NotModified = 91,
        NoMobileDevice = 92,
        TimeNotSynced = 93,
        SmsCodeFailed = 94,
        AccountLimitExceeded = 95,
        AccountActivityLimitExceeded = 96,
        PhoneActivityLimitExceeded = 97,
        RefundToWallet = 98,
        EmailSendFailure = 99,
        NotSettled = 100,
        NeedCaptcha = 101,
        GsltDenied = 102,
        GsOwnerDenied = 103,
        InvalidItemType = 104,
        IPBanned = 105,
        GsltExpired = 106,
        InsufficientFunds = 107,
        TooManyPending = 108,
        NoSiteLicensesFound = 109,
        WgNetworkSendExceeded = 110,
        AccountNotFriends = 111,
        LimitedUserAccount = 112,
        CantRemoveItem = 113,
        AccountDeleted = 114,
        ExistingUserCancelledLicense = 115,
        CommunityCooldown = 116,
        NoLauncherSpecified = 117,
        MustAgreeToSsa = 118,
        LauncherMigrated = 119,
        SteamRealmMismatch = 120,
        InvalidSignature = 121,
        ParseFailure = 122,
        NoVerifiedPhone = 123,
        InsufficientBattery = 124,
        ChargerRequired = 125,
        CachedCredentialInvalid = 126,
        PhoneNumberIsVoip = 127
    }

    public enum SteamApiInitResult : long
    {
        Ok = 0,
        FailedGeneric = 1,
        NoSteamClient = 2,
        VersionMismatch = 3
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