namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The api call invalid
    /// </summary>
    public const long ApiCallInvalid = 0;
    /// <summary>
    /// The app id invalid
    /// </summary>
    public const long AppIdInvalid = 0;
    /// <summary>
    /// The auth ticket invalid
    /// </summary>
    public const long AuthTicketInvalid = 0;
    /// <summary>
    /// The depot id invalid
    /// </summary>
    public const long DepotIdInvalid = 0;
    /// <summary>
    /// The game extra info max
    /// </summary>
    public const long GameExtraInfoMax = 64;
    /// <summary>
    /// The invalid breakpad handle
    /// </summary>
    public const long InvalidBreakpadHandle = 0;
    /// <summary>
    /// The steam account id mask
    /// </summary>
    public const long SteamAccountIdMask = 4294967295;
    /// <summary>
    /// The steam account instance mask
    /// </summary>
    public const long SteamAccountInstanceMask = 1048575;
    /// <summary>
    /// The steam buffer size
    /// </summary>
    public const long SteamBufferSize = 255;
    /// <summary>
    /// The steam large buffer size
    /// </summary>
    public const long SteamLargeBufferSize = 8160;
    /// <summary>
    /// The steam max error message
    /// </summary>
    public const long SteamMaxErrorMessage = 1024;
    /// <summary>
    /// The steam user console instance
    /// </summary>
    public const long SteamUserConsoleInstance = 2;
    /// <summary>
    /// The steam user desktop instance
    /// </summary>
    public const long SteamUserDesktopInstance = 1;
    /// <summary>
    /// The steam user web instance
    /// </summary>
    public const long SteamUserWebInstance = 4;
    /// <summary>
    /// The query port error
    /// </summary>
    public const long QueryPortError = 65534;
    /// <summary>
    /// The query port not initialized
    /// </summary>
    public const long QueryPortNotInitialized = 65535;
    /// <summary>
    /// The chat metadata max
    /// </summary>
    public const long ChatMetadataMax = 8192;
    /// <summary>
    /// The enumerated followers max
    /// </summary>
    public const long EnumeratedFollowersMax = 50;
    /// <summary>
    /// The friends group limit
    /// </summary>
    public const long FriendsGroupLimit = 100;
    /// <summary>
    /// The invalid friend group id
    /// </summary>
    public const long InvalidFriendGroupId = -1;
    /// <summary>
    /// The max friends group name
    /// </summary>
    public const long MaxFriendsGroupName = 64;
    /// <summary>
    /// The max rich presence key length
    /// </summary>
    public const long MaxRichPresenceKeyLength = 64;
    /// <summary>
    /// The max rich presence keys
    /// </summary>
    public const long MaxRichPresenceKeys = 20;
    /// <summary>
    /// The max rich presence value lenth
    /// </summary>
    public const long MaxRichPresenceValueLenth = 256;
    /// <summary>
    /// The persona name max utf
    /// </summary>
    public const long PersonaNameMaxUtf8 = 128;
    /// <summary>
    /// The persona name max utf 16
    /// </summary>
    public const long PersonaNameMaxUtf16 = 32;
    /// <summary>
    /// The invalid htmlbrowser
    /// </summary>
    public const long InvalidHtmlbrowser = 0;
    /// <summary>
    /// The invalid httpcookie handle
    /// </summary>
    public const long InvalidHttpcookieHandle = 0;
    /// <summary>
    /// The invalid httprequest handle
    /// </summary>
    public const long InvalidHttprequestHandle = 0;
    /// <summary>
    /// The input max analog actions
    /// </summary>
    public const long InputMaxAnalogActions = 24;
    /// <summary>
    /// The input max analog action data
    /// </summary>
    public const long InputMaxAnalogActionData = 1;
    /// <summary>
    /// The input max count
    /// </summary>
    public const long InputMaxCount = 16;
    /// <summary>
    /// The input max digital actions
    /// </summary>
    public const long InputMaxDigitalActions = 256;
    /// <summary>
    /// The input max origins
    /// </summary>
    public const long InputMaxOrigins = 8;
    /// <summary>
    /// The input min analog action data
    /// </summary>
    public const long InputMinAnalogActionData = -1;
    /// <summary>
    /// The inventory result invalid
    /// </summary>
    public const long InventoryResultInvalid = -1;
    /// <summary>
    /// The item instance id invalid
    /// </summary>
    public const long ItemInstanceIdInvalid = 0;
    /// <summary>
    /// The server query invalid
    /// </summary>
    public const long ServerQueryInvalid = 4294967295;
    /// <summary>
    /// The max lobby key length
    /// </summary>
    public const long MaxLobbyKeyLength = 255;
    /// <summary>
    /// The favorite flag favorite
    /// </summary>
    public const long FavoriteFlagFavorite = 1;
    /// <summary>
    /// The favorite flag history
    /// </summary>
    public const long FavoriteFlagHistory = 2;
    /// <summary>
    /// The favorite flag none
    /// </summary>
    public const long FavoriteFlagNone = 0;
    /// <summary>
    /// The max game server game data
    /// </summary>
    public const long MaxGameServerGameData = 2048;
    /// <summary>
    /// The max game server game description
    /// </summary>
    public const long MaxGameServerGameDescription = 64;
    /// <summary>
    /// The max game server game dir
    /// </summary>
    public const long MaxGameServerGameDir = 32;
    /// <summary>
    /// The max game server map name
    /// </summary>
    public const long MaxGameServerMapName = 32;
    /// <summary>
    /// The max game server name
    /// </summary>
    public const long MaxGameServerName = 64;
    /// <summary>
    /// The max game server tags
    /// </summary>
    public const long MaxGameServerTags = 128;
    /// <summary>
    /// The music name max length
    /// </summary>
    public const long MusicNameMaxLength = 255;
    /// <summary>
    /// The music png max length
    /// </summary>
    public const long MusicPngMaxLength = 65535;
    /// <summary>
    /// The networking send unreliable
    /// </summary>
    public const long NetworkingSendUnreliable = 0;
    /// <summary>
    /// The networking send no nagle
    /// </summary>
    public const long NetworkingSendNoNagle = 1;
    /// <summary>
    /// The networking send no delay
    /// </summary>
    public const long NetworkingSendNoDelay = 4;
    /// <summary>
    /// The networking send reliable
    /// </summary>
    public const long NetworkingSendReliable = 8;
    /// <summary>
    /// The device form factor unknown
    /// </summary>
    public const long DeviceFormFactorUnknown = 0;
    /// <summary>
    /// The device form factor phone
    /// </summary>
    public const long DeviceFormFactorPhone = 1;
    /// <summary>
    /// The device form factor tablet
    /// </summary>
    public const long DeviceFormFactorTablet = 2;
    /// <summary>
    /// The device form factor computer
    /// </summary>
    public const long DeviceFormFactorComputer = 3;
    /// <summary>
    /// The device form factor tv
    /// </summary>
    public const long DeviceFormFactorTv = 4;
    /// <summary>
    /// The file name max
    /// </summary>
    public const long FileNameMax = 1024;
    /// <summary>
    /// The published document change description max
    /// </summary>
    public const long PublishedDocumentChangeDescriptionMax = 8000;
    /// <summary>
    /// The published document description max
    /// </summary>
    public const long PublishedDocumentDescriptionMax = 8000;
    /// <summary>
    /// The published document title max
    /// </summary>
    public const long PublishedDocumentTitleMax = 129;
    /// <summary>
    /// The published file url max
    /// </summary>
    public const long PublishedFileUrlMax = 256;
    /// <summary>
    /// The tag list max
    /// </summary>
    public const long TagListMax = 1025;
    /// <summary>
    /// The published file id invalid
    /// </summary>
    public const long PublishedFileIdInvalid = 0;
    /// <summary>
    /// The published file update handle invalid
    /// </summary>
    public const long PublishedFileUpdateHandleInvalid = 0;
    /// <summary>
    /// The ugc file stream handle invalid
    /// </summary>
    public const long UgcFileStreamHandleInvalid = 0;
    /// <summary>
    /// The ugc handle invalid
    /// </summary>
    public const long UgcHandleInvalid = 0;
    /// <summary>
    /// The enumerate published files max results
    /// </summary>
    public const long EnumeratePublishedFilesMaxResults = 50;
    /// <summary>
    /// The max cloud file chunk size
    /// </summary>
    public const long MaxCloudFileChunkSize = 104857600;
    /// <summary>
    /// The invalid screenshot handle
    /// </summary>
    public const long InvalidScreenshotHandle = 0;
    /// <summary>
    /// The ufs tag type max
    /// </summary>
    public const long UfsTagTypeMax = 255;
    /// <summary>
    /// The ufs tag value max
    /// </summary>
    public const long UfsTagValueMax = 255;
    /// <summary>
    /// The max tagged published files
    /// </summary>
    public const long MaxTaggedPublishedFiles = 32;
    /// <summary>
    /// The max tagged users
    /// </summary>
    public const long MaxTaggedUsers = 32;
    /// <summary>
    /// The screenshot thumb width
    /// </summary>
    public const long ScreenshotThumbWidth = 200;
    /// <summary>
    /// The num ugc results per page
    /// </summary>
    public const long NumUgcResultsPerPage = 50;
    /// <summary>
    /// The developer metadata max
    /// </summary>
    public const long DeveloperMetadataMax = 5000;
    /// <summary>
    /// The ugc query handle invalid
    /// </summary>
    public const long UgcQueryHandleInvalid = 0;
    /// <summary>
    /// The ugc update handle invalid
    /// </summary>
    public const long UgcUpdateHandleInvalid = 0;
    /// <summary>
    /// The leaderboard detail max
    /// </summary>
    public const long LeaderboardDetailMax = 64;
    /// <summary>
    /// The leaderboard name max
    /// </summary>
    public const long LeaderboardNameMax = 128;
    /// <summary>
    /// The stat name max
    /// </summary>
    public const long StatNameMax = 128;

    /// <summary>
    /// The controller haptic location enum
    /// </summary>
    public enum ControllerHapticLocation : long
    {
        /// <summary>
        /// The left controller haptic location
        /// </summary>
        Left = 1,
        /// <summary>
        /// The right controller haptic location
        /// </summary>
        Right = 2,
        /// <summary>
        /// The both controller haptic location
        /// </summary>
        Both = 3
    }

    /// <summary>
    /// The controller haptic type enum
    /// </summary>
    public enum ControllerHapticType : long
    {
        /// <summary>
        /// The off controller haptic type
        /// </summary>
        Off = 0,
        /// <summary>
        /// The tick controller haptic type
        /// </summary>
        Tick = 1,
        /// <summary>
        /// The click controller haptic type
        /// </summary>
        Click = 2
    }

    /// <summary>
    /// The controller pad enum
    /// </summary>
    public enum ControllerPad : long
    {
        /// <summary>
        /// The left controller pad
        /// </summary>
        Left = 0,
        /// <summary>
        /// The right controller pad
        /// </summary>
        Right = 1
    }

    /// <summary>
    /// The device form factor enum
    /// </summary>
    public enum DeviceFormFactor : long
    {
        /// <summary>
        /// The unknown device form factor
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// The phone device form factor
        /// </summary>
        Phone = 1,
        /// <summary>
        /// The tablet device form factor
        /// </summary>
        Tablet = 2,
        /// <summary>
        /// The computer device form factor
        /// </summary>
        Computer = 3,
        /// <summary>
        /// The tv device form factor
        /// </summary>
        Tv = 4
    }

    /// <summary>
    /// The duration control online state enum
    /// </summary>
    public enum DurationControlOnlineState : long
    {
        /// <summary>
        /// The invalid duration control online state
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The offline duration control online state
        /// </summary>
        Offline = 1,
        /// <summary>
        /// The online duration control online state
        /// </summary>
        Online = 2,
        /// <summary>
        /// The online high priority duration control online state
        /// </summary>
        OnlineHighPriority = 3
    }

    /// <summary>
    /// The game search error code enum
    /// </summary>
    public enum GameSearchErrorCode : long
    {
        /// <summary>
        /// The ok game search error code
        /// </summary>
        Ok = 1,
        /// <summary>
        /// The search aready in progress game search error code
        /// </summary>
        SearchAreadyInProgress = 2,
        /// <summary>
        /// The no search in progress game search error code
        /// </summary>
        NoSearchInProgress = 3,
        /// <summary>
        /// The not lobby leader game search error code
        /// </summary>
        NotLobbyLeader = 4,
        /// <summary>
        /// The no host available game search error code
        /// </summary>
        NoHostAvailable = 5,
        /// <summary>
        /// The search params invalid game search error code
        /// </summary>
        SearchParamsInvalid = 6,
        /// <summary>
        /// The offline game search error code
        /// </summary>
        Offline = 7,
        /// <summary>
        /// The not authorized game search error code
        /// </summary>
        NotAuthorized = 8,
        /// <summary>
        /// The unknown error game search error code
        /// </summary>
        UnknownError = 9
    }

    /// <summary>
    /// The ip type enum
    /// </summary>
    public enum IPType : long
    {
        /// <summary>
        /// The ipv ip type
        /// </summary>
        Ipv4 = 0,
        /// <summary>
        /// The ipv ip type
        /// </summary>
        Ipv6 = 1
    }

    /// <summary>
    /// The pv connectivity protocol enum
    /// </summary>
    public enum IPv6ConnectivityProtocol : long
    {
        /// <summary>
        /// The invalid pv connectivity protocol
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The http pv connectivity protocol
        /// </summary>
        Http = 1,
        /// <summary>
        /// The udp pv connectivity protocol
        /// </summary>
        Udp = 2
    }

    /// <summary>
    /// The pv connectivity state enum
    /// </summary>
    public enum IPv6ConnectivityState : long
    {
        /// <summary>
        /// The unknown pv connectivity state
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// The good pv connectivity state
        /// </summary>
        Good = 1,
        /// <summary>
        /// The bad pv connectivity state
        /// </summary>
        Bad = 2
    }

    /// <summary>
    /// The market not allowed reason flags enum
    /// </summary>
    public enum MarketNotAllowedReasonFlags : long
    {
        /// <summary>
        /// The none market not allowed reason flags
        /// </summary>
        None = 0,
        /// <summary>
        /// The temporary failure market not allowed reason flags
        /// </summary>
        TemporaryFailure = 1,
        /// <summary>
        /// The account disabled market not allowed reason flags
        /// </summary>
        AccountDisabled = 2,
        /// <summary>
        /// The account locked down market not allowed reason flags
        /// </summary>
        AccountLockedDown = 4,
        /// <summary>
        /// The account limited market not allowed reason flags
        /// </summary>
        AccountLimited = 8,
        /// <summary>
        /// The trade banned market not allowed reason flags
        /// </summary>
        TradeBanned = 16,
        /// <summary>
        /// The account not trusted market not allowed reason flags
        /// </summary>
        AccountNotTrusted = 32,
        /// <summary>
        /// The steam guard not enabled market not allowed reason flags
        /// </summary>
        SteamGuardNotEnabled = 64,
        /// <summary>
        /// The steam gaurd only recently enabled market not allowed reason flags
        /// </summary>
        SteamGaurdOnlyRecentlyEnabled = 128,
        /// <summary>
        /// The recent password reset market not allowed reason flags
        /// </summary>
        RecentPasswordReset = 256,
        /// <summary>
        /// The new payment method market not allowed reason flags
        /// </summary>
        NewPaymentMethod = 512,
        /// <summary>
        /// The invalid cookie market not allowed reason flags
        /// </summary>
        InvalidCookie = 1024,
        /// <summary>
        /// The using new device market not allowed reason flags
        /// </summary>
        UsingNewDevice = 2048,
        /// <summary>
        /// The recent self refund market not allowed reason flags
        /// </summary>
        RecentSelfRefund = 4096,
        /// <summary>
        /// The new payment method cannot be verified market not allowed reason flags
        /// </summary>
        NewPaymentMethodCannotBeVerified = 8192,
        /// <summary>
        /// The no recent purchases market not allowed reason flags
        /// </summary>
        NoRecentPurchases = 16384,
        /// <summary>
        /// The accepted wallet gift market not allowed reason flags
        /// </summary>
        AcceptedWalletGift = 32768
    }

    /// <summary>
    /// The sce pad trigger effect mode enum
    /// </summary>
    public enum ScePadTriggerEffectMode : long
    {
        /// <summary>
        /// The off sce pad trigger effect mode
        /// </summary>
        Off = 0,
        /// <summary>
        /// The feedback sce pad trigger effect mode
        /// </summary>
        Feedback = 1,
        /// <summary>
        /// The weapon sce pad trigger effect mode
        /// </summary>
        Weapon = 2,
        /// <summary>
        /// The vibration sce pad trigger effect mode
        /// </summary>
        Vibration = 3,
        /// <summary>
        /// The multiple position feedback sce pad trigger effect mode
        /// </summary>
        MultiplePositionFeedback = 4,
        /// <summary>
        /// The slope feedback sce pad trigger effect mode
        /// </summary>
        SlopeFeedback = 5,
        /// <summary>
        /// The multiple position vibration sce pad trigger effect mode
        /// </summary>
        MultiplePositionVibration = 6
    }

    /// <summary>
    /// The xbox origin enum
    /// </summary>
    public enum XboxOrigin : long
    {
        /// <summary>
        /// The  xbox origin
        /// </summary>
        A = 0,
        /// <summary>
        /// The  xbox origin
        /// </summary>
        B = 1,
        /// <summary>
        /// The  xbox origin
        /// </summary>
        X = 2,
        /// <summary>
        /// The  xbox origin
        /// </summary>
        Y = 3,
        /// <summary>
        /// The left bumper xbox origin
        /// </summary>
        LeftBumper = 4,
        /// <summary>
        /// The right bumper xbox origin
        /// </summary>
        RightBumper = 5,
        /// <summary>
        /// The menu xbox origin
        /// </summary>
        Menu = 6,
        /// <summary>
        /// The view xbox origin
        /// </summary>
        View = 7,
        /// <summary>
        /// The left trigger pull xbox origin
        /// </summary>
        LeftTriggerPull = 8,
        /// <summary>
        /// The left trigger click xbox origin
        /// </summary>
        LeftTriggerClick = 9,
        /// <summary>
        /// The right trigger pull xbox origin
        /// </summary>
        RightTriggerPull = 10,
        /// <summary>
        /// The right trigger click xbox origin
        /// </summary>
        RightTriggerClick = 11,
        /// <summary>
        /// The left stick move xbox origin
        /// </summary>
        LeftStickMove = 12,
        /// <summary>
        /// The left stick click xbox origin
        /// </summary>
        LeftStickClick = 13,
        /// <summary>
        /// The left stick dpad north xbox origin
        /// </summary>
        LeftStickDpadNorth = 14,
        /// <summary>
        /// The left stick dpad south xbox origin
        /// </summary>
        LeftStickDpadSouth = 15,
        /// <summary>
        /// The left stick dpad west xbox origin
        /// </summary>
        LeftStickDpadWest = 16,
        /// <summary>
        /// The left stick dpad eat xbox origin
        /// </summary>
        LeftStickDpadEat = 17,
        /// <summary>
        /// The right stick move xbox origin
        /// </summary>
        RightStickMove = 18,
        /// <summary>
        /// The right stick click xbox origin
        /// </summary>
        RightStickClick = 19,
        /// <summary>
        /// The right stick dpad north xbox origin
        /// </summary>
        RightStickDpadNorth = 20,
        /// <summary>
        /// The right stick dpad south xbox origin
        /// </summary>
        RightStickDpadSouth = 21,
        /// <summary>
        /// The right stick dpad west xbox origin
        /// </summary>
        RightStickDpadWest = 22,
        /// <summary>
        /// The right stick dpad east xbox origin
        /// </summary>
        RightStickDpadEast = 23,
        /// <summary>
        /// The dpad north xbox origin
        /// </summary>
        DpadNorth = 24,
        /// <summary>
        /// The dpad south xbox origin
        /// </summary>
        DpadSouth = 25,
        /// <summary>
        /// The dpad west xbox origin
        /// </summary>
        DpadWest = 26,
        /// <summary>
        /// The dpad east xbox origin
        /// </summary>
        DpadEast = 27,
        /// <summary>
        /// The count xbox origin
        /// </summary>
        Count = 28
    }
}