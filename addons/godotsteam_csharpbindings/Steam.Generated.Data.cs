namespace GodotSteam;

public static partial class Steam
{
    public const long ApiCallInvalid = 0;
    public const long AppIdInvalid = 0;
    public const long AuthTicketInvalid = 0;
    public const long DepotIdInvalid = 0;
    public const long GameExtraInfoMax = 64;
    public const long InvalidBreakpadHandle = 0;
    public const long SteamAccountIdMask = 4294967295;
    public const long SteamAccountInstanceMask = 1048575;
    public const long SteamBufferSize = 255;
    public const long SteamLargeBufferSize = 8160;
    public const long SteamMaxErrorMessage = 1024;
    public const long SteamUserConsoleInstance = 2;
    public const long SteamUserDesktopInstance = 1;
    public const long SteamUserWebInstance = 4;
    public const long QueryPortError = 65534;
    public const long QueryPortNotInitialized = 65535;
    public const long ChatMetadataMax = 8192;
    public const long EnumeratedFollowersMax = 50;
    public const long FriendsGroupLimit = 100;
    public const long InvalidFriendGroupId = -1;
    public const long MaxFriendsGroupName = 64;
    public const long MaxRichPresenceKeyLength = 64;
    public const long MaxRichPresenceKeys = 20;
    public const long MaxRichPresenceValueLenth = 256;
    public const long PersonaNameMaxUtf8 = 128;
    public const long PersonaNameMaxUtf16 = 32;
    public const long InvalidHtmlbrowser = 0;
    public const long InvalidHttpcookieHandle = 0;
    public const long InvalidHttprequestHandle = 0;
    public const long InputMaxAnalogActions = 24;
    public const long InputMaxAnalogActionData = 1;
    public const long InputMaxCount = 16;
    public const long InputMaxDigitalActions = 256;
    public const long InputMaxOrigins = 8;
    public const long InputMinAnalogActionData = -1;
    public const long InventoryResultInvalid = -1;
    public const long ItemInstanceIdInvalid = 0;
    public const long ServerQueryInvalid = 4294967295;
    public const long MaxLobbyKeyLength = 255;
    public const long FavoriteFlagFavorite = 1;
    public const long FavoriteFlagHistory = 2;
    public const long FavoriteFlagNone = 0;
    public const long MaxGameServerGameData = 2048;
    public const long MaxGameServerGameDescription = 64;
    public const long MaxGameServerGameDir = 32;
    public const long MaxGameServerMapName = 32;
    public const long MaxGameServerName = 64;
    public const long MaxGameServerTags = 128;
    public const long MusicNameMaxLength = 255;
    public const long MusicPngMaxLength = 65535;
    public const long NetworkingSendUnreliable = 0;
    public const long NetworkingSendNoNagle = 1;
    public const long NetworkingSendNoDelay = 4;
    public const long NetworkingSendReliable = 8;
    public const long DeviceFormFactorUnknown = 0;
    public const long DeviceFormFactorPhone = 1;
    public const long DeviceFormFactorTablet = 2;
    public const long DeviceFormFactorComputer = 3;
    public const long DeviceFormFactorTv = 4;
    public const long FileNameMax = 1024;
    public const long PublishedDocumentChangeDescriptionMax = 8000;
    public const long PublishedDocumentDescriptionMax = 8000;
    public const long PublishedDocumentTitleMax = 129;
    public const long PublishedFileUrlMax = 256;
    public const long TagListMax = 1025;
    public const long PublishedFileIdInvalid = 0;
    public const long PublishedFileUpdateHandleInvalid = 0;
    public const long UgcFileStreamHandleInvalid = 0;
    public const long UgcHandleInvalid = 0;
    public const long EnumeratePublishedFilesMaxResults = 50;
    public const long MaxCloudFileChunkSize = 104857600;
    public const long InvalidScreenshotHandle = 0;
    public const long UfsTagTypeMax = 255;
    public const long UfsTagValueMax = 255;
    public const long MaxTaggedPublishedFiles = 32;
    public const long MaxTaggedUsers = 32;
    public const long ScreenshotThumbWidth = 200;
    public const long NumUgcResultsPerPage = 50;
    public const long DeveloperMetadataMax = 5000;
    public const long UgcQueryHandleInvalid = 0;
    public const long UgcUpdateHandleInvalid = 0;
    public const long LeaderboardDetailMax = 64;
    public const long LeaderboardNameMax = 128;
    public const long StatNameMax = 128;

    public enum ControllerHapticLocation : long
    {
        Left = 1,
        Right = 2,
        Both = 3
    }

    public enum ControllerHapticType : long
    {
        Off = 0,
        Tick = 1,
        Click = 2
    }

    public enum ControllerPad : long
    {
        Left = 0,
        Right = 1
    }

    public enum DeviceFormFactor : long
    {
        Unknown = 0,
        Phone = 1,
        Tablet = 2,
        Computer = 3,
        Tv = 4
    }

    public enum DurationControlOnlineState : long
    {
        Invalid = 0,
        Offline = 1,
        Online = 2,
        OnlineHighPriority = 3
    }

    public enum GameSearchErrorCode : long
    {
        Ok = 1,
        SearchAreadyInProgress = 2,
        NoSearchInProgress = 3,
        NotLobbyLeader = 4,
        NoHostAvailable = 5,
        SearchParamsInvalid = 6,
        Offline = 7,
        NotAuthorized = 8,
        UnknownError = 9
    }

    public enum IPType : long
    {
        Ipv4 = 0,
        Ipv6 = 1
    }

    public enum IPv6ConnectivityProtocol : long
    {
        Invalid = 0,
        Http = 1,
        Udp = 2
    }

    public enum IPv6ConnectivityState : long
    {
        Unknown = 0,
        Good = 1,
        Bad = 2
    }

    public enum MarketNotAllowedReasonFlags : long
    {
        None = 0,
        TemporaryFailure = 1,
        AccountDisabled = 2,
        AccountLockedDown = 4,
        AccountLimited = 8,
        TradeBanned = 16,
        AccountNotTrusted = 32,
        SteamGuardNotEnabled = 64,
        SteamGaurdOnlyRecentlyEnabled = 128,
        RecentPasswordReset = 256,
        NewPaymentMethod = 512,
        InvalidCookie = 1024,
        UsingNewDevice = 2048,
        RecentSelfRefund = 4096,
        NewPaymentMethodCannotBeVerified = 8192,
        NoRecentPurchases = 16384,
        AcceptedWalletGift = 32768
    }

    public enum XboxOrigin : long
    {
        A = 0,
        B = 1,
        X = 2,
        Y = 3,
        LeftBumper = 4,
        RightBumper = 5,
        Menu = 6,
        View = 7,
        LeftTriggerPull = 8,
        LeftTriggerClick = 9,
        RightTriggerPull = 10,
        RightTriggerClick = 11,
        LeftStickMove = 12,
        LeftStickClick = 13,
        LeftStickDpadNorth = 14,
        LeftStickDpadSouth = 15,
        LeftStickDpadWest = 16,
        LeftStickDpadEat = 17,
        RightStickMove = 18,
        RightStickClick = 19,
        RightStickDpadNorth = 20,
        RightStickDpadSouth = 21,
        RightStickDpadWest = 22,
        RightStickDpadEast = 23,
        DpadNorth = 24,
        DpadSouth = 25,
        DpadWest = 26,
        DpadEast = 27,
        Count = 28
    }
}