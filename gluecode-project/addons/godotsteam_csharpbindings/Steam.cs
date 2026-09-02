#pragma warning disable CS0109
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Godot;
using Godot.Collections;

namespace GDExtension.Wrappers;

[Tool]
public partial class Steam : GodotObject
{

    private new static readonly StringName NativeName = new StringName("Steam");

    [Obsolete("Wrapper types cannot be constructed with constructors (it only instantiate the underlying Steam object), please use the Instantiate() method instead.")]
    protected Steam() { }

    private static CSharpScript _wrapperScriptAsset;

    /// <summary>
    /// Try to cast the script on the supplied <paramref name="godotObject"/> to the <see cref="Steam"/> wrapper type,
    /// if no script has attached to the type, or the script attached to the type does not inherit the <see cref="Steam"/> wrapper type,
    /// a new instance of the <see cref="Steam"/> wrapper script will get attaches to the <paramref name="godotObject"/>.
    /// </summary>
    /// <remarks>The developer should only supply the <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</remarks>
    /// <param name="godotObject">The <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</param>
    /// <returns>The existing or a new instance of the <see cref="Steam"/> wrapper script attached to the supplied <paramref name="godotObject"/>.</returns>
    public new static Steam Bind(GodotObject godotObject)
    {
        if (!IsInstanceValid(godotObject))
            return null;

        if (godotObject is Steam wrapperScriptInstance)
            return wrapperScriptInstance;

#if DEBUG
        var expectedType = typeof(Steam);
        var currentObjectClassName = godotObject.GetClass();
        if (!ClassDB.IsParentClass(expectedType.Name, currentObjectClassName))
            throw new InvalidOperationException($"The supplied GodotObject ({currentObjectClassName}) is not the {expectedType.Name} type.");
#endif

        if (_wrapperScriptAsset is null)
        {
            var scriptPathAttribute = typeof(Steam).GetCustomAttributes<ScriptPathAttribute>().FirstOrDefault();
            if (scriptPathAttribute is null) throw new UnreachableException();
            _wrapperScriptAsset = ResourceLoader.Load<CSharpScript>(scriptPathAttribute.Path);
        }

        var instanceId = godotObject.GetInstanceId();
        godotObject.SetScript(_wrapperScriptAsset);
        return (Steam)InstanceFromId(instanceId);
    }

    /// <summary>
    /// Creates an instance of the GDExtension <see cref="Steam"/> type, and attaches a wrapper script instance to it.
    /// </summary>
    /// <returns>The wrapper instance linked to the underlying GDExtension "Steam" type.</returns>
    public new static Steam Instantiate() => Bind(ClassDB.Instantiate(NativeName).As<GodotObject>());
    /// <summary>
    /// Gets the existing Engine singleton instance of the underlying GDExtension "Steam" type, if available,
    /// and attaches this C# wrapper to it.
    /// </summary>
    /// <returns>The wrapper instance bound to the existing Engine singleton, or null if not available.</returns>
    public static Steam GetSingleton()
    {
        var obj = Engine.GetSingleton(NativeName);
        if (obj is null)
            return null;
        return Bind(obj);
    }

    public enum AccountType
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

    public enum ApiCallFailure
    {
        SteamApiCallFailureNone = -1,
        SteamApiCallFailureSteamGone = 0,
        SteamApiCallFailureNetworkFailure = 1,
        SteamApiCallFailureInvalidHandle = 2,
        SteamApiCallFailureMismatchedCallback = 3,
    }

    public enum AudioPlaybackStatus
    {
        Undefined = 0,
        Playing = 1,
        Paused = 2,
        Idle = 3,
    }

    public enum AuthSessionResponse
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
        AuthTicketNetworkIdentityFailure = 10,
    }

    public enum AvatarSizes
    {
        Small = 1,
        Medium = 2,
        Large = 3,
    }

    public enum BeginAuthSessionResult
    {
        Ok = 0,
        InvalidTicket = 1,
        DuplicateRequest = 2,
        InvalidVersion = 3,
        GameMismatch = 4,
        ExpiredTicket = 5,
    }

    [Flags]
    public enum BetaBranchFlags
    {
        None = 0,
        Default = 1,
        Available = 2,
        Private = 4,
        Selected = 8,
        Installed = 16,
    }

    public enum BroadcastUploadResult
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

    public enum ChatEntryType
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
        LinkBlocked = 14,
    }

    [Flags]
    public enum ChatMemberStateChange
    {
        Entered = 1,
        Left = 2,
        Disconnected = 4,
        Kicked = 8,
        Banned = 16,
    }

    public enum ChatRoomEnterResponse
    {
        Success = 1,
        DoesntExist = 2,
        NotAllowed = 3,
        Full = 4,
        Error = 5,
        Banned = 6,
        Limited = 7,
        ClanDisabled = 8,
        CommunityBan = 9,
        MemberBlockedYou = 10,
        YouBlockedMember = 11,
        RateLimitExceeded = 15,
    }

    [Flags]
    public enum ChatSteamIdInstanceFlags
    {
        ChatAccountInstanceMask = 4095,
        FlagClan = 524288,
        FlagLobby = 262144,
        FlagMmsLobby = 131072,
    }

    public enum CheckFileSignatureEnum
    {
        InvalidSignature = 0,
        ValidSignature = 1,
        FileNotFound = 2,
        NoSignaturesFoundForThisApp = 3,
        NoSignaturesFoundForThisFile = 4,
    }

    public enum CommunityProfileItemType
    {
        AnimatedAvatar = 0,
        AvatarFrame = 1,
        ProfileModifier = 2,
        ProfileBackground = 3,
        MiniProfileBackground = 4,
    }

    public enum CommunityProfileItemProperty
    {
        ImageSmall = 0,
        ImageLarge = 1,
        InternalName = 2,
        Title = 3,
        Description = 4,
        AppId = 5,
        TypeId = 6,
        Class = 7,
        MovieWebm = 8,
        MovieMp4 = 9,
        MovieWebmSmall = 10,
        MovieMp4Small = 11,
    }

    public enum ControllerHapticLocation
    {
        Left = 1,
        Right = 2,
        Both = 3,
    }

    public enum ControllerHapticType
    {
        Off = 0,
        Tick = 1,
        Click = 2,
    }

    public enum DenyReason
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
        SteamOwnerLeftGuestUser = 15,
    }

    public enum DeviceFormFactor
    {
        Unknown = 0,
        Phone = 1,
        Tablet = 2,
        Computer = 3,
        Tv = 4,
        VrHeadset = 5,
    }

    public enum DurationControlNotification
    {
        None = 0,
        Notification1Hour = 1,
        Notification3Hours = 2,
        HalfProgress = 3,
        NoProgress = 4,
        ExitSoon3h = 5,
        ExitSoon5h = 6,
        ExitSoonNight = 7,
    }

    public enum DurationControlOnlineState
    {
        Invalid = 0,
        Offline = 1,
        Online = 2,
        OnlineHighPriority = 3,
    }

    public enum DurationControlProgress
    {
        Full = 0,
        Half = 1,
        None = 2,
        ExitSoon3h = 3,
        ExitSoon5h = 4,
        ExitSoonNight = 5,
    }

    public enum FailureType
    {
        FlushedCallbackQueue = 0,
        PipeFail = 1,
    }

    public enum FilePathType
    {
        Invalid = 0,
        Absolute = 1,
        ApiFilename = 2,
    }

    public enum FloatingGamepadTextInputMode
    {
        SingleLine = 0,
        MultipleLines = 1,
        Email = 2,
        Numeric = 3,
    }

    [Flags]
    public enum FriendFlags
    {
        FlagNone = 0,
        FlagBlocked = 1,
        FlagFriendshipRequested = 2,
        FlagImmediate = 4,
        FlagClanMember = 8,
        FlagOnGameServer = 16,
        FlagRequestingFriendship = 128,
        FlagRequestingInfo = 256,
        FlagIgnored = 512,
        FlagIgnoredFriend = 1024,
        FlagChatMember = 4096,
        FlagAll = 65535,
    }

    public enum FriendRelationship
    {
        RelationNone = 0,
        RelationBlocked = 1,
        RelationRequestRecipient = 2,
        RelationFriend = 3,
        RelationRequestInitiator = 4,
        RelationIgnored = 5,
        RelationIgnoredFriend = 6,
        RelationSuggested = 7,
        RelationMax = 8,
    }

    public enum GameIdType
    {
        App = 0,
        GameMod = 1,
        Shortcut = 2,
    }

    public enum GamepadTextInputLineMode
    {
        SingleLine = 0,
        MultipleLines = 1,
    }

    public enum GamepadTextInputMode
    {
        Normal = 0,
        Password = 1,
    }

    public enum GamePerformanceSetting
    {
        NotSet = 0,
        Low = 1,
        Medium = 2,
        High = 3,
        Ultra = 4,
        Custom = 5,
    }

    [Flags]
    public enum HtmlKeyModifiers
    {
        ModifierNone = 0,
        ModifierAltDown = 1,
        ModifierCtrlDown = 2,
        ModifierShiftDown = 4,
    }

    public enum HtmlMouseButton
    {
        Left = 0,
        Right = 1,
        Middle = 2,
    }

    public enum HtmlMouseCursor
    {
        User = 0,
        None = 1,
        Arrow = 2,
        Ibeam = 3,
        Hourglass = 4,
        WaitArrow = 5,
        Crosshair = 6,
        Up = 7,
        SizeNw = 8,
        SizeSe = 9,
        SizeNe = 10,
        SizeSw = 11,
        SizeW = 12,
        SizeE = 13,
        SizeN = 14,
        SizeS = 15,
        SizeWe = 16,
        SizeNs = 17,
        SizeAll = 18,
        CursorNo = 19,
        CursorHand = 20,
        CursorBlank = 21,
        MiddlePan = 22,
        NorthPan = 23,
        NorthEastPan = 24,
        EastPan = 25,
        SouthEastPan = 26,
        SouthPan = 27,
        SouthWestPan = 28,
        WestPan = 29,
        NorthWestPan = 30,
        Alias = 31,
        Cell = 32,
        ColResize = 33,
        CopyCur = 34,
        VerticalText = 35,
        RowResize = 36,
        ZoomIn = 37,
        ZoomOut = 38,
        Help = 39,
        Custom = 40,
        SizeNwse = 41,
        SizeNesw = 42,
        Last = 43,
    }

    public enum HttpMethod
    {
        Invalid = 0,
        Get = 1,
        Head = 2,
        Post = 3,
        Put = 4,
        Delete = 5,
        Options = 6,
        Patch = 7,
    }

    public enum HttpStatusCode
    {
        Invalid = 0,
        Code100Continue = 100,
        Code101SwitchingProtocols = 101,
        Code200Ok = 200,
        Code201Created = 201,
        Code202Accepted = 202,
        Code203NonAuthoritative = 203,
        Code204NoContent = 204,
        Code205ResetContent = 205,
        Code206PartialContent = 206,
        Code300MultipleChoices = 300,
        Code301MovedPermanently = 301,
        Code302Found = 302,
        Code303SeeOther = 303,
        Code304NotModified = 304,
        Code305UseProxy = 305,
        Code307TemporaryRedirect = 307,
        Code308PermanentRedirect = 308,
        Code400BadRequest = 400,
        Code401Unauthorized = 401,
        Code402PaymentRequired = 402,
        Code403Forbidden = 403,
        Code404NotFound = 404,
        Code405MethodNotAllowed = 405,
        Code406NotAcceptable = 406,
        Code407ProxyAuthRequired = 407,
        Code408RequestTimeout = 408,
        Code409Conflict = 409,
        Code410Gone = 410,
        Code411LengthRequired = 411,
        Code412PreconditionFailed = 412,
        Code413RequestEntityTooLarge = 413,
        Code414RequestUriTooLong = 414,
        Code415UnsupportedMediaType = 415,
        Code416RequestedRangeNotSatisfiable = 416,
        Code417ExpectationFailed = 417,
        Code4xxUnknown = 418,
        Code421MisdirectRequest = 421,
        Code422UnprocessableContent = 422,
        Code423Locked = 423,
        Code424FailedDependency = 424,
        Code425TooEarly = 425,
        Code426UpgradeRequired = 426,
        Code428PreconditionRequired = 428,
        Code429TooManyRequests = 429,
        Code431RequestHeaderFieldsTooLarge = 431,
        Code444ConnectionClosed = 444,
        Code451UnavailableForLegalAreasons = 451,
        Code500InternalServerError = 500,
        Code501NotImplemented = 501,
        Code502BadGateway = 502,
        Code503ServiceUnavailable = 503,
        Code504GatewayTimeout = 504,
        Code505HttpVersionNotSupported = 505,
        Code506VariantAlsoNegotiates = 506,
        Code507InsufficientStorage = 507,
        Code508LoopDetected = 508,
        Code510NotExtended = 510,
        Code511NetworkAuthenticationRequired = 511,
        Code5xxUnknown = 599,
    }

    public enum InputActionEventType
    {
        DigitalAction = 0,
        AnalogAction = 1,
    }

    public enum InputActionOrigin
    {
        None = 0,
        SteamcontrollerA = 1,
        SteamcontrollerB = 2,
        SteamcontrollerX = 3,
        SteamcontrollerY = 4,
        SteamcontrollerLeftBumper = 5,
        SteamcontrollerRightBumper = 6,
        SteamcontrollerLeftGrip = 7,
        SteamcontrollerRightGrip = 8,
        SteamcontrollerStart = 9,
        SteamcontrollerBack = 10,
        SteamcontrollerLeftPadTouch = 11,
        SteamcontrollerLeftPadSwipe = 12,
        SteamcontrollerLeftPadClick = 13,
        SteamcontrollerLeftPadDpadNorth = 14,
        SteamcontrollerLeftPadDpadSouth = 15,
        SteamcontrollerLeftPadDpadWest = 16,
        SteamcontrollerLeftPadDpadEast = 17,
        SteamcontrollerRightPadTouch = 18,
        SteamcontrollerRightPadSwipe = 19,
        SteamcontrollerRightPadClick = 20,
        SteamcontrollerRightPadDpadNorth = 21,
        SteamcontrollerRightPadDpadSouth = 22,
        SteamcontrollerRightPadDpadWest = 23,
        SteamcontrollerRightPadDpadEast = 24,
        SteamcontrollerLeftTriggerPull = 25,
        SteamcontrollerLeftTriggerClick = 26,
        SteamcontrollerRightTriggerPull = 27,
        SteamcontrollerRightTriggerClick = 28,
        SteamcontrollerLeftStickMove = 29,
        SteamcontrollerLeftStickClick = 30,
        SteamcontrollerLeftStickDpadNorth = 31,
        SteamcontrollerLeftStickDpadSouth = 32,
        SteamcontrollerLeftStickDpadWest = 33,
        SteamcontrollerLeftStickDpadEast = 34,
        SteamcontrollerGyroMove = 35,
        SteamcontrollerGyroPitch = 36,
        SteamcontrollerGyroYaw = 37,
        SteamcontrollerGyroRoll = 38,
        SteamcontrollerReserved0 = 39,
        SteamcontrollerReserved1 = 40,
        SteamcontrollerReserved2 = 41,
        SteamcontrollerReserved3 = 42,
        SteamcontrollerReserved4 = 43,
        SteamcontrollerReserved5 = 44,
        SteamcontrollerReserved6 = 45,
        SteamcontrollerReserved7 = 46,
        SteamcontrollerReserved8 = 47,
        SteamcontrollerReserved9 = 48,
        SteamcontrollerReserved10 = 49,
        Ps4X = 50,
        Ps4Circle = 51,
        Ps4Triangle = 52,
        Ps4Square = 53,
        Ps4LeftBumper = 54,
        Ps4RightBumper = 55,
        Ps4Options = 56,
        Ps4Share = 57,
        Ps4LeftPadTouch = 58,
        Ps4LeftPadSwipe = 59,
        Ps4LeftPadClick = 60,
        Ps4LeftPadDpadNorth = 61,
        Ps4LeftPadDpadSouth = 62,
        Ps4LeftPadDpadWest = 63,
        Ps4LeftPadDpadEast = 64,
        Ps4RightPadTouch = 65,
        Ps4RightPadSwipe = 66,
        Ps4RightPadClick = 67,
        Ps4RightPadDpadNorth = 68,
        Ps4RightPadDpadSouth = 69,
        Ps4RightPadDpadWest = 70,
        Ps4RightPadDpadEast = 71,
        Ps4CenterPadTouch = 72,
        Ps4CenterPadSwipe = 73,
        Ps4CenterPadClick = 74,
        Ps4CenterPadDpadNorth = 75,
        Ps4CenterPadDpadSouth = 76,
        Ps4CenterPadDpadWest = 77,
        Ps4CenterPadDpadEast = 78,
        Ps4LeftTriggerPull = 79,
        Ps4LeftTriggerClick = 80,
        Ps4RightTriggerPull = 81,
        Ps4RightTriggerClick = 82,
        Ps4LeftStickMove = 83,
        Ps4LeftStickClick = 84,
        Ps4LeftStickDpadNorth = 85,
        Ps4LeftStickDpadSouth = 86,
        Ps4LeftStickDpadWest = 87,
        Ps4LeftStickDpadEast = 88,
        Ps4RightStickMove = 89,
        Ps4RightStickClick = 90,
        Ps4RightStickDpadNorth = 91,
        Ps4RightStickDpadSouth = 92,
        Ps4RightStickDpadWest = 93,
        Ps4RightStickDpadEast = 94,
        Ps4DpadNorth = 95,
        Ps4DpadSouth = 96,
        Ps4DpadWest = 97,
        Ps4DpadEast = 98,
        Ps4GyroMove = 99,
        Ps4GyroPitch = 100,
        Ps4GyroYaw = 101,
        Ps4GyroRoll = 102,
        Ps4DpadMove = 103,
        Ps4Reserved1 = 104,
        Ps4Reserved2 = 105,
        Ps4Reserved3 = 106,
        Ps4Reserved4 = 107,
        Ps4Reserved5 = 108,
        Ps4Reserved6 = 109,
        Ps4Reserved7 = 110,
        Ps4Reserved8 = 111,
        Ps4Reserved9 = 112,
        Ps4Reserved10 = 113,
        XboxoneA = 114,
        XboxoneB = 115,
        XboxoneX = 116,
        XboxoneY = 117,
        XboxoneLeftBumper = 118,
        XboxoneRightBumper = 119,
        XboxoneMenu = 120,
        XboxoneView = 121,
        XboxoneLeftTriggerPull = 122,
        XboxoneLeftTriggerClick = 123,
        XboxoneRightTriggerPull = 124,
        XboxoneRightTriggerClick = 125,
        XboxoneLeftStickMove = 126,
        XboxoneLeftStickClick = 127,
        XboxoneLeftStickDpadNorth = 128,
        XboxoneLeftStickDpadSouth = 129,
        XboxoneLeftStickDpadWest = 130,
        XboxoneLeftStickDpadEast = 131,
        XboxoneRightStickMove = 132,
        XboxoneRightStickClick = 133,
        XboxoneRightStickDpadNorth = 134,
        XboxoneRightStickDpadSouth = 135,
        XboxoneRightStickDpadWest = 136,
        XboxoneRightStickDpadEast = 137,
        XboxoneDpadNorth = 138,
        XboxoneDpadSouth = 139,
        XboxoneDpadWest = 140,
        XboxoneDpadEast = 141,
        XboxoneDpadMove = 142,
        XboxoneLeftGripLower = 143,
        XboxoneLeftGripUpper = 144,
        XboxoneRightGripLower = 145,
        XboxoneRightGripUpper = 146,
        XboxoneShare = 147,
        XboxoneReserved6 = 148,
        XboxoneReserved7 = 149,
        XboxoneReserved8 = 150,
        XboxoneReserved9 = 151,
        XboxoneReserved10 = 152,
        Xbox360A = 153,
        Xbox360B = 154,
        Xbox360X = 155,
        Xbox360Y = 156,
        Xbox360LeftBumper = 157,
        Xbox360RightBumper = 158,
        Xbox360Start = 159,
        Xbox360Back = 160,
        Xbox360LeftTriggerPull = 161,
        Xbox360LeftTriggerClick = 162,
        Xbox360RightTriggerPull = 163,
        Xbox360RightTriggerClick = 164,
        Xbox360LeftStickMove = 165,
        Xbox360LeftStickClick = 166,
        Xbox360LeftStickDpadNorth = 167,
        Xbox360LeftStickDpadSouth = 168,
        Xbox360LeftStickDpadWest = 169,
        Xbox360LeftStickDpadEast = 170,
        Xbox360RightStickMove = 171,
        Xbox360RightStickClick = 172,
        Xbox360RightStickDpadNorth = 173,
        Xbox360RightStickDpadSouth = 174,
        Xbox360RightStickDpadWest = 175,
        Xbox360RightStickDpadEast = 176,
        Xbox360DpadNorth = 177,
        Xbox360DpadSouth = 178,
        Xbox360DpadWest = 179,
        Xbox360DpadEast = 180,
        Xbox360DpadMove = 181,
        Xbox360Reserved1 = 182,
        Xbox360Reserved2 = 183,
        Xbox360Reserved3 = 184,
        Xbox360Reserved4 = 185,
        Xbox360Reserved5 = 186,
        Xbox360Reserved6 = 187,
        Xbox360Reserved7 = 188,
        Xbox360Reserved8 = 189,
        Xbox360Reserved9 = 190,
        Xbox360Reserved10 = 191,
        SwitchA = 192,
        SwitchB = 193,
        SwitchX = 194,
        SwitchY = 195,
        SwitchLeftBumper = 196,
        SwitchRightBumper = 197,
        SwitchPlus = 198,
        SwitchMinus = 199,
        SwitchCapture = 200,
        SwitchLeftTriggerPull = 201,
        SwitchLeftTriggerClick = 202,
        SwitchRightTriggerPull = 203,
        SwitchRightTriggerClick = 204,
        SwitchLeftStickMove = 205,
        SwitchLeftStickClick = 206,
        SwitchLeftStickDpadNorth = 207,
        SwitchLeftStickDpadSouth = 208,
        SwitchLeftStickDpadWest = 209,
        SwitchLeftStickDpadEast = 210,
        SwitchRightStickMove = 211,
        SwitchRightStickClick = 212,
        SwitchRightStickDpadNorth = 213,
        SwitchRightStickDpadSouth = 214,
        SwitchRightStickDpadWest = 215,
        SwitchRightStickDpadEast = 216,
        SwitchDpadNorth = 217,
        SwitchDpadSouth = 218,
        SwitchDpadWest = 219,
        SwitchDpadEast = 220,
        SwitchProGyroMove = 221,
        SwitchProGyroPitch = 222,
        SwitchProGyroYaw = 223,
        SwitchProGyroRoll = 224,
        SwitchDpadMove = 225,
        SwitchReserved1 = 226,
        SwitchReserved2 = 227,
        SwitchReserved3 = 228,
        SwitchReserved4 = 229,
        SwitchReserved5 = 230,
        SwitchReserved6 = 231,
        SwitchReserved7 = 232,
        SwitchReserved8 = 233,
        SwitchReserved9 = 234,
        SwitchReserved10 = 235,
        SwitchRightGyroMove = 236,
        SwitchRightGyroPitch = 237,
        SwitchRightGyroYaw = 238,
        SwitchRightGyroRoll = 239,
        SwitchLeftGyroMove = 240,
        SwitchLeftGyroPitch = 241,
        SwitchLeftGyroYaw = 242,
        SwitchLeftGyroRoll = 243,
        SwitchLeftGripLower = 244,
        SwitchLeftGripUpper = 245,
        SwitchRightGripLower = 246,
        SwitchRightGripUpper = 247,
        SwitchJoyconButtonN = 248,
        SwitchJoyconButtonE = 249,
        SwitchJoyconButtonS = 250,
        SwitchJoyconButtonW = 251,
        SwitchReserved15 = 252,
        SwitchReserved16 = 253,
        SwitchReserved17 = 254,
        SwitchReserved18 = 255,
        SwitchReserved19 = 256,
        SwitchReserved20 = 257,
        Ps5X = 258,
        Ps5Circle = 259,
        Ps5Triangle = 260,
        Ps5Square = 261,
        Ps5LeftBumper = 262,
        Ps5RightBumper = 263,
        Ps5Option = 264,
        Ps5Create = 265,
        Ps5Mute = 266,
        Ps5LeftPadTouch = 267,
        Ps5LeftPadSwipe = 268,
        Ps5LeftPadClick = 269,
        Ps5LeftPadDpadNorth = 270,
        Ps5LeftPadDpadSouth = 271,
        Ps5LeftPadDpadWest = 272,
        Ps5LeftPadDpadEast = 273,
        Ps5RightPadTouch = 274,
        Ps5RightPadSwipe = 275,
        Ps5RightPadClick = 276,
        Ps5RightPadDpadNorth = 277,
        Ps5RightPadDpadSouth = 278,
        Ps5RightPadDpadWest = 279,
        Ps5RightPadDpadEast = 280,
        Ps5CenterPadTouch = 281,
        Ps5CenterPadSwipe = 282,
        Ps5CenterPadClick = 283,
        Ps5CenterPadDpadNorth = 284,
        Ps5CenterPadDpadSouth = 285,
        Ps5CenterPadDpadWest = 286,
        Ps5CenterPadDpadEast = 287,
        Ps5LeftTriggerPull = 288,
        Ps5LeftTriggerClick = 289,
        Ps5RightTriggerPull = 290,
        Ps5RightTriggerClick = 291,
        Ps5LeftStickMove = 292,
        Ps5LeftStickClick = 293,
        Ps5LeftStickDpadNorth = 294,
        Ps5LeftStickDpadSouth = 295,
        Ps5LeftStickDpadWest = 296,
        Ps5LeftStickDpadEast = 297,
        Ps5RightStickMove = 298,
        Ps5RightStickClick = 299,
        Ps5RightStickDpadNorth = 300,
        Ps5RightStickDpadSouth = 301,
        Ps5RightStickDpadWest = 302,
        Ps5RightStickDpadEast = 303,
        Ps5DpadNorth = 304,
        Ps5DpadSouth = 305,
        Ps5DpadWest = 306,
        Ps5DpadEast = 307,
        Ps5GyroMove = 308,
        Ps5GyroPitch = 309,
        Ps5GyroYaw = 310,
        Ps5GyroRoll = 311,
        Ps5DpadMove = 312,
        Ps5LeftGrip = 313,
        Ps5RightGrip = 314,
        Ps5LeftFn = 315,
        Ps5RightFn = 316,
        Ps5Reserved5 = 317,
        Ps5Reserved6 = 318,
        Ps5Reserved7 = 319,
        Ps5Reserved8 = 320,
        Ps5Reserved9 = 321,
        Ps5Reserved10 = 322,
        Ps5Reserved11 = 323,
        Ps5Reserved12 = 324,
        Ps5Reserved13 = 325,
        Ps5Reserved14 = 326,
        Ps5Reserved15 = 327,
        Ps5Reserved16 = 328,
        Ps5Reserved17 = 329,
        Ps5Reserved18 = 330,
        Ps5Reserved19 = 331,
        Ps5Reserved20 = 332,
        SteamdeckA = 333,
        SteamdeckB = 334,
        SteamdeckX = 335,
        SteamdeckY = 336,
        SteamdeckL1 = 337,
        SteamdeckR1 = 338,
        SteamdeckMenu = 339,
        SteamdeckView = 340,
        SteamdeckLeftPadTouch = 341,
        SteamdeckLeftPadSwipe = 342,
        SteamdeckLeftPadClick = 343,
        SteamdeckLeftPadDpadNorth = 344,
        SteamdeckLeftPadDpadSouth = 345,
        SteamdeckLeftPadDpadWest = 346,
        SteamdeckLeftPadDpadEast = 347,
        SteamdeckRightPadTouch = 348,
        SteamdeckRightPadSwipe = 349,
        SteamdeckRightPadClick = 350,
        SteamdeckRightPadDpadNorth = 351,
        SteamdeckRightPadDpadSouth = 352,
        SteamdeckRightPadDpadWest = 353,
        SteamdeckRightPadDpadEast = 354,
        SteamdeckL2Softpull = 355,
        SteamdeckL2 = 356,
        SteamdeckR2Softpull = 357,
        SteamdeckR2 = 358,
        SteamdeckLeftStickMove = 359,
        SteamdeckL3 = 360,
        SteamdeckLeftStickDpadNorth = 361,
        SteamdeckLeftStickDpadSouth = 362,
        SteamdeckLeftStickDpadWest = 363,
        SteamdeckLeftStickDpadEast = 364,
        SteamdeckLeftStickTouch = 365,
        SteamdeckRightStickMove = 366,
        SteamdeckR3 = 367,
        SteamdeckRightStickDpadNorth = 368,
        SteamdeckRightStickDpadSouth = 369,
        SteamdeckRightStickDpadWest = 370,
        SteamdeckRightStickDpadEast = 371,
        SteamdeckRightStickTouch = 372,
        SteamdeckL4 = 373,
        SteamdeckR4 = 374,
        SteamdeckL5 = 375,
        SteamdeckR5 = 376,
        SteamdeckDpadMove = 377,
        SteamdeckDpadNorth = 378,
        SteamdeckDpadSouth = 379,
        SteamdeckDpadWest = 380,
        SteamdeckDpadEast = 381,
        SteamdeckGyroMove = 382,
        SteamdeckGyroPitch = 383,
        SteamdeckGyroYaw = 384,
        SteamdeckGyroRoll = 385,
        SteamdeckReserved1 = 386,
        SteamdeckReserved2 = 387,
        SteamdeckReserved3 = 388,
        SteamdeckReserved4 = 389,
        SteamdeckReserved5 = 390,
        SteamdeckReserved6 = 391,
        SteamdeckReserved7 = 392,
        SteamdeckReserved8 = 393,
        SteamdeckReserved9 = 394,
        SteamdeckReserved10 = 395,
        SteamdeckReserved11 = 396,
        SteamdeckReserved12 = 397,
        SteamdeckReserved13 = 398,
        SteamdeckReserved14 = 399,
        SteamdeckReserved15 = 400,
        SteamdeckReserved16 = 401,
        SteamdeckReserved17 = 402,
        SteamdeckReserved18 = 403,
        SteamdeckReserved19 = 404,
        SteamdeckReserved20 = 405,
        HoripadM1 = 406,
        HoripadM2 = 407,
        HoripadL4 = 408,
        HoripadR4 = 409,
        LenovoLegionGoA = 410,
        LenovoLegionGoB = 411,
        LenovoLegionGoX = 412,
        LenovoLegionGoY = 413,
        LenovoLegionGoLb = 414,
        LenovoLegionGoRb = 415,
        LenovoLegionGoMenu = 416,
        LenovoLegionGoView = 417,
        LenovoLegionGoLeftPadTouch = 418,
        LenovoLegionGoLeftPadSwipe = 419,
        LenovoLegionGoLeftPadClick = 420,
        LenovoLegionGoLeftPadDpadNorth = 421,
        LenovoLegionGoLeftPadDpadSouth = 422,
        LenovoLegionGoLeftPadDpadWest = 423,
        LenovoLegionGoLeftPadDpadEast = 424,
        LenovoLegionGoRightPadTouch = 425,
        LenovoLegionGoRightPadSwipe = 426,
        LenovoLegionGoRightPadClick = 427,
        LenovoLegionGoRightPadDpadNorth = 428,
        LenovoLegionGoRightPadDpadSouth = 429,
        LenovoLegionGoRightPadDpadWest = 430,
        LenovoLegionGoRightPadDpadEast = 431,
        LenovoLegionGoLtSoftpull = 432,
        LenovoLegionGoLt = 433,
        LenovoLegionGoRtSoftpull = 434,
        LenovoLegionGoRt = 435,
        LenovoLegionGoLeftStickMove = 436,
        LenovoLegionGoLs = 437,
        LenovoLegionGoLeftStickDpadNorth = 438,
        LenovoLegionGoLeftStickDpadSouth = 439,
        LenovoLegionGoLeftStickDpadWest = 440,
        LenovoLegionGoLeftStickDpadEast = 441,
        LenovoLegionGoRightStickMove = 442,
        LenovoLegionGoRs = 443,
        LenovoLegionGoRightStickDpadNorth = 444,
        LenovoLegionGoRightStickDpadSouth = 445,
        LenovoLegionGoRightStickDpadWest = 446,
        LenovoLegionGoRightStickDpadEast = 447,
        LenovoLegionGoY1 = 448,
        LenovoLegionGoY2 = 449,
        LenovoLegionGoDpadMove = 450,
        LenovoLegionGoDpadNorth = 451,
        LenovoLegionGoDpadSouth = 452,
        LenovoLegionGoDpadWest = 453,
        LenovoLegionGoDpadEast = 454,
        LenovoLegionGoGyroMove = 455,
        LenovoLegionGoGyroPitch = 456,
        LenovoLegionGoGyroYaw = 457,
        LenovoLegionGoGyroRoll = 458,
        LenovoLegionGoReserved1 = 459,
        LenovoLegionGoReserved2 = 460,
        LenovoLegionGoReserved3 = 461,
        LenovoLegionGoReserved4 = 462,
        LenovoLegionGoReserved5 = 463,
        LenovoLegionGoReserved6 = 464,
        LenovoLegionGoReserved7 = 465,
        LenovoLegionGoReserved8 = 466,
        LenovoLegionGoReserved9 = 467,
        LenovoLegionGoReserved10 = 468,
        LenovoLegionGoReserved11 = 469,
        LenovoLegionGoReserved12 = 470,
        LenovoLegionGoReserved13 = 471,
        LenovoLegionGoReserved14 = 472,
        LenovoLegionGoReserved15 = 473,
        LenovoLegionGoReserved16 = 474,
        LenovoLegionGoReserved17 = 475,
        LenovoLegionGoReserved18 = 476,
        LenovoLegionGoReserved19 = 477,
        LenovoLegionGoReserved20 = 478,
        GenericL4 = 479,
        GenericR4 = 480,
        GenericL5 = 481,
        GenericR5 = 482,
        GenericPl = 483,
        GenericPr = 484,
        GenericC = 485,
        GenericZ = 486,
        GenericMisc1 = 487,
        GenericMisc2 = 488,
        GenericMisc3 = 489,
        GenericMisc4 = 490,
        GenericMisc5 = 491,
        GenericMisc6 = 492,
        GenericMisc7 = 493,
        GenericMisc8 = 494,
        Switch2RightTriggerPull = 506,
        Switch2RightTriggerClick = 507,
        Switch2LeftStickMove = 508,
        Switch2LeftStickClick = 509,
        Switch2LeftStickDpadNorth = 510,
        Switch2LeftStickDpadSouth = 511,
        Switch2LeftStickDpadWest = 512,
        Switch2LeftStickDpadEast = 513,
        Switch2RightStickMove = 514,
        Switch2RightStickClick = 515,
        Switch2RightStickDpadNorth = 516,
        Switch2RightStickDpadSouth = 517,
        Switch2RightStickDpadWest = 518,
        Switch2RightStickDpadEast = 519,
        Switch2DpadMove = 520,
        Switch2DpadNorth = 521,
        Switch2DpadSouth = 522,
        Switch2DpadWest = 523,
        Switch2DpadEast = 524,
        Switch2ProGyroMove = 525,
        Switch2ProGyroPitch = 526,
        Switch2ProGyroYaw = 527,
        Switch2ProGyroRoll = 528,
        Switch2Gl = 529,
        Switch2Gr = 530,
        Switch2C = 531,
        Switch2Reserved1 = 532,
        Switch2Reserved2 = 533,
        Switch2Reserved3 = 534,
        Switch2Reserved4 = 535,
        Switch2Reserved5 = 536,
        Switch2Reserved6 = 537,
        Switch2Reserved7 = 538,
        Switch2Reserved8 = 539,
        Switch2Reserved9 = 540,
        Switch2Reserved10 = 541,
        Steamcontroller2026A = 542,
        Steamcontroller2026B = 543,
        Steamcontroller2026X = 544,
        Steamcontroller2026Y = 545,
        Steamcontroller2026L1 = 546,
        Steamcontroller2026R1 = 547,
        Steamcontroller2026Menu = 548,
        Steamcontroller2026View = 549,
        Steamcontroller2026LeftPadTouch = 550,
        Steamcontroller2026LeftPadSwipe = 551,
        Steamcontroller2026LeftPadClick = 552,
        Steamcontroller2026LeftPadDpadNorth = 553,
        Steamcontroller2026LeftPadDpadSouth = 554,
        Steamcontroller2026LeftPadDpadWest = 555,
        Steamcontroller2026LeftPadDpadEast = 556,
        Steamcontroller2026RightPadTouch = 557,
        Steamcontroller2026RightPadSwipe = 558,
        Steamcontroller2026RightPadClick = 559,
        Steamcontroller2026RightPadDpadNorth = 560,
        Steamcontroller2026RightPadDpadSouth = 561,
        Steamcontroller2026RightPadDpadWest = 562,
        Steamcontroller2026RightPadDpadEast = 563,
        Steamcontroller2026L2Softpull = 564,
        Steamcontroller2026L2 = 565,
        Steamcontroller2026R2Softpull = 566,
        Steamcontroller2026R2 = 567,
        Steamcontroller2026LeftStickMove = 568,
        Steamcontroller2026L3 = 569,
        Steamcontroller2026LeftStickDpadNorth = 570,
        Steamcontroller2026LeftStickDpadSouth = 571,
        Steamcontroller2026LeftStickDpadWest = 572,
        Steamcontroller2026LeftStickDpadEast = 573,
        Steamcontroller2026LeftStickTouch = 574,
        Steamcontroller2026RightStickMove = 575,
        Steamcontroller2026R3 = 576,
        Steamcontroller2026RightStickDpadNorth = 577,
        Steamcontroller2026RightStickDpadSouth = 578,
        Steamcontroller2026RightStickDpadWest = 579,
        Steamcontroller2026RightStickDpadEast = 580,
        Steamcontroller2026RightStickTouch = 581,
        Steamcontroller2026L4 = 582,
        Steamcontroller2026R4 = 583,
        Steamcontroller2026L5 = 584,
        Steamcontroller2026R5 = 585,
        Steamcontroller2026DpadMove = 586,
        Steamcontroller2026DpadNorth = 587,
        Steamcontroller2026DpadSouth = 588,
        Steamcontroller2026DpadWest = 589,
        Steamcontroller2026DpadEast = 590,
        Steamcontroller2026GyroMove = 591,
        Steamcontroller2026GyroPitch = 592,
        Steamcontroller2026GyroYaw = 593,
        Steamcontroller2026GyroRoll = 594,
        Steamcontroller2026Lgrip = 595,
        Steamcontroller2026Rgrip = 596,
        Steamcontroller2026Reserved1 = 597,
        Steamcontroller2026Reserved2 = 598,
        Steamcontroller2026Reserved3 = 599,
        Steamcontroller2026Reserved4 = 600,
        Steamcontroller2026Reserved5 = 601,
        Steamcontroller2026Reserved6 = 602,
        Steamcontroller2026Reserved7 = 603,
        Steamcontroller2026Reserved8 = 604,
        Steamcontroller2026Reserved9 = 605,
        Steamcontroller2026Reserved10 = 606,
        Steamcontroller2026Reserved11 = 607,
        Steamcontroller2026Reserved12 = 608,
        Steamcontroller2026Reserved13 = 609,
        Steamcontroller2026Reserved14 = 610,
        Steamcontroller2026Reserved15 = 611,
        Steamcontroller2026Reserved16 = 612,
        Steamcontroller2026Reserved17 = 613,
        Steamcontroller2026Reserved18 = 614,
        Steamcontroller2026Reserved19 = 615,
        Steamcontroller2026Reserved20 = 616,
        SteamframecontrollerAClick = 617,
        SteamframecontrollerATouch = 618,
        SteamframecontrollerBClick = 619,
        SteamframecontrollerBTouch = 620,
        SteamframecontrollerXClick = 621,
        SteamframecontrollerXTouch = 622,
        SteamframecontrollerYClick = 623,
        SteamframecontrollerYTouch = 624,
        SteamframecontrollerLeftTriggerPull = 625,
        SteamframecontrollerLeftTriggerClick = 626,
        SteamframecontrollerLeftTriggerTouch = 627,
        SteamframecontrollerRightTriggerPull = 628,
        SteamframecontrollerRightTriggerClick = 629,
        SteamframecontrollerRightTriggerTouch = 630,
        SteamframecontrollerMenuClick = 631,
        SteamframecontrollerMenuTouch = 632,
        SteamframecontrollerViewClick = 633,
        SteamframecontrollerViewTouch = 634,
        SteamframecontrollerLeftBumperClick = 635,
        SteamframecontrollerLeftBumperTouch = 636,
        SteamframecontrollerRightBumperClick = 637,
        SteamframecontrollerRightBumperTouch = 638,
        SteamframecontrollerLeftStickMove = 639,
        SteamframecontrollerLeftStickClick = 640,
        SteamframecontrollerLeftStickDpadNorth = 641,
        SteamframecontrollerLeftStickDpadSouth = 642,
        SteamframecontrollerLeftStickDpadWest = 643,
        SteamframecontrollerLeftStickDpadEast = 644,
        SteamframecontrollerLeftStickTouch = 645,
        SteamframecontrollerRightStickMove = 646,
        SteamframecontrollerRightStickClick = 647,
        SteamframecontrollerRightStickDpadNorth = 648,
        SteamframecontrollerRightStickDpadSouth = 649,
        SteamframecontrollerRightStickDpadWest = 650,
        SteamframecontrollerRightStickDpadEast = 651,
        SteamframecontrollerRightStickTouch = 652,
        SteamframecontrollerDpadMove = 653,
        SteamframecontrollerDpadNorth = 654,
        SteamframecontrollerDpadSouth = 655,
        SteamframecontrollerDpadWest = 656,
        SteamframecontrollerDpadEast = 657,
        SteamframecontrollerDpadTouch = 658,
        SteamframecontrollerLeftGyroMove = 659,
        SteamframecontrollerLeftGyroPitch = 660,
        SteamframecontrollerLeftGyroYaw = 661,
        SteamframecontrollerLeftGyroRoll = 662,
        SteamframecontrollerRightGyroMove = 663,
        SteamframecontrollerRightGyroPitch = 664,
        SteamframecontrollerRightGyroYaw = 665,
        SteamframecontrollerRightGyroRoll = 666,
        SteamframecontrollerLeftGripPull = 667,
        SteamframecontrollerLeftGripClick = 668,
        SteamframecontrollerLeftGripTouch = 669,
        SteamframecontrollerRightGripPull = 670,
        SteamframecontrollerRightGripClick = 671,
        SteamframecontrollerRightGripTouch = 672,
        SteamframecontrollerLeftThumbrestTouch = 673,
        SteamframecontrollerRightThumbrestTouch = 674,
        SteamframecontrollerReserved1 = 675,
        SteamframecontrollerReserved2 = 676,
        SteamframecontrollerReserved3 = 677,
        SteamframecontrollerReserved4 = 678,
        SteamframecontrollerReserved5 = 679,
        SteamframecontrollerReserved6 = 680,
        SteamframecontrollerReserved7 = 681,
        SteamframecontrollerReserved8 = 682,
        SteamframecontrollerReserved9 = 683,
        SteamframecontrollerReserved10 = 684,
        SteamframecontrollerReserved11 = 685,
        SteamframecontrollerReserved12 = 686,
        SteamframecontrollerReserved13 = 687,
        SteamframecontrollerReserved14 = 688,
        SteamframecontrollerReserved15 = 689,
        SteamframecontrollerReserved16 = 690,
        SteamframecontrollerReserved17 = 691,
        SteamframecontrollerReserved18 = 692,
        SteamframecontrollerReserved19 = 693,
        SteamframecontrollerReserved20 = 694,
        Count = 695,
        MaximumPossibleValue = 32767,
    }

    [Flags]
    public enum InputConfigurationEnableType
    {
        None = 0,
        Playstation = 1,
        Xbox = 2,
        Generic = 4,
        Switch = 8,
    }

    public enum InputGlyphSize
    {
        Small = 0,
        Medium = 1,
        Large = 2,
        Count = 3,
    }

    [Flags]
    public enum InputGlyphStyle
    {
        Knockout = 0,
        Light = 1,
        Dark = 2,
        NeutralColorAbxy = 16,
        SolidAbxy = 32,
    }

    public enum InputLedFlag
    {
        SetColor = 0,
        RestoreUserDefault = 1,
    }

    public enum InputSourceMode
    {
        None = 0,
        Dpad = 1,
        Buttons = 2,
        FourButtons = 3,
        AbsoluteMouse = 4,
        RelativeMouse = 5,
        JoystickMove = 6,
        JoystickMouse = 7,
        JoystickCamera = 8,
        ScrollWheel = 9,
        Trigger = 10,
        TouchMenu = 11,
        MouseJoystick = 12,
        MouseRegion = 13,
        RadialMenu = 14,
        SingleButton = 15,
        Switch = 16,
    }

    public enum InputType
    {
        Unknown = 0,
        SteamController = 1,
        Xbox360Controller = 2,
        XboxoneController = 3,
        GenericXinput = 4,
        Ps4Controller = 5,
        AppleMfiController = 6,
        AndroidController = 7,
        SwitchJoyconPair = 8,
        SwitchJoyconSingle = 9,
        SwitchProController = 10,
        MobileTouch = 11,
        Ps3Controller = 12,
        Ps5Controller = 13,
        SteamDeckController = 14,
        SteamOsHandheld = 15,
        Switch2ProController = 16,
        SteamController2 = 17,
        SteamFrameControllerPair = 18,
        Count = 19,
        MaximumPossibleValue = 255,
    }

    public enum IpType
    {
        Ipv4 = 0,
        Ipv6 = 1,
    }

    public enum IPv6ConnectivityProtocol
    {
        Ipv6ConnectivityProtocolInvalid = 0,
        Ipv6ConnectivityProtocolHttp = 1,
        Ipv6ConnectivityProtocolUdp = 2,
    }

    public enum IPv6ConnectivityState
    {
        Ipv6ConnectivityStateUnknown = 0,
        Ipv6ConnectivityStateGood = 1,
        Ipv6ConnectivityStateBad = 2,
    }

    [Flags]
    public enum ItemFlags
    {
        SteamItemNoTrade = 1,
        SteamItemRemoved = 256,
        SteamItemConsumed = 512,
    }

    public enum ItemPreviewType
    {
        Image = 0,
        YoutubeVideo = 1,
        Sketchfab = 2,
        EnvironmentmapHorizontalCross = 3,
        EnvironmentmapLatLong = 4,
        Clip = 5,
        ReservedMax = 255,
    }

    [Flags]
    public enum ItemState
    {
        None = 0,
        Subscribed = 1,
        LegacyItem = 2,
        Installed = 4,
        NeedsUpdate = 8,
        Downloading = 16,
        DownloadPending = 32,
        DisabledLocally = 64,
    }

    public enum ItemStatistic
    {
        NumSubscriptions = 0,
        NumFavorites = 1,
        NumFollowers = 2,
        NumUniqueSubscriptions = 3,
        NumUniqueFavorites = 4,
        NumUniqueFollowers = 5,
        NumUniqueWebsiteViews = 6,
        ReportScore = 7,
        NumSecondsPlayed = 8,
        NumPlaytimeSessions = 9,
        NumComments = 10,
        NumSecondsPlayedDuringTimePeriod = 11,
        NumPlaytimeSessionsDuringTimePeriod = 12,
    }

    public enum ItemUpdateStatus
    {
        Invalid = 0,
        PreparingConfig = 1,
        PreparingContent = 2,
        UploadingContent = 3,
        UploadingPreviewFile = 4,
        CommittingChanges = 5,
    }

    public enum LeaderboardDataRequest
    {
        Global = 0,
        GlobalAroundUser = 1,
        Friends = 2,
        Users = 3,
    }

    public enum LeaderboardDisplayType
    {
        None = 0,
        Numeric = 1,
        TimeSeconds = 2,
        TimeMilliseconds = 3,
    }

    public enum LeaderboardSortMethod
    {
        None = 0,
        Ascending = 1,
        Descending = 2,
    }

    public enum LeaderboardUploadScoreMethod
    {
        None = 0,
        KeepBest = 1,
        ForceUpdate = 2,
    }

    public enum LobbyComparison
    {
        EqualToOrLessThan = -2,
        LessThan = -1,
        Equal = 0,
        GreaterThan = 1,
        EqualToGreaterThan = 2,
        NotEqual = 3,
    }

    public enum LobbyDistanceFilter
    {
        Close = 0,
        Default = 1,
        Far = 2,
        Worldwide = 3,
    }

    public enum LobbyType
    {
        Private = 0,
        FriendsOnly = 1,
        Public = 2,
        Invisible = 3,
        PrivateUnique = 4,
    }

    public enum LocalFileChange
    {
        Invalid = 0,
        FileUpdated = 1,
        FileDeleted = 2,
    }

    [Flags]
    public enum MarketNotAllowedReasonFlags
    {
        None = 0,
        TemporaryFailure = 1,
        AccountDisabled = 2,
        AccountLockedDown = 4,
        AccountLimited = 8,
        TradeBanned = 16,
        AccountNotTrusted = 32,
        SteamGuardNotEnabled = 64,
        SteamGuardOnlyRecentlyEnabled = 128,
        RecentPasswordReset = 256,
        NewPaymentMethod = 512,
        InvalidCookie = 1024,
        UsingNewDevice = 2048,
        RecentSelfRefund = 4096,
        NewPaymentMethodCannotBeVerified = 8192,
        NoRecentPurchases = 16384,
        AcceptedWalletGift = 32768,
        TradeCooldown = 65536,
    }

    public enum MatchMakingServerResponse
    {
        Responded = 0,
        FailedToRespond = 1,
        NoServersListedOnMasterServer = 2,
    }

    public enum NetworkingAvailability
    {
        CannotTry = -102,
        Failed = -101,
        Previously = -100,
        Retrying = -10,
        NeverTried = 1,
        Waiting = 2,
        Attempting = 3,
        Current = 100,
        Unknown = 0,
        Force32bit = 2147483647,
    }

    public enum NetworkingConfigDataType
    {
        Int32 = 1,
        Int64 = 2,
        Float = 3,
        String = 4,
        FunctionPtr = 5,
        Force32bit = 2147483647,
    }

    public enum NetworkingConfigScope
    {
        Global = 1,
        SocketsInterface = 2,
        ListenSocket = 3,
        Connection = 4,
        Force32bit = 2147483647,
    }

    public enum NetworkingConfigValue
    {
        Invalid = 0,
        FakePacketLossSend = 2,
        FakePacketLossRecv = 3,
        FakePacketLagSend = 4,
        FakePacketLagRecv = 5,
        FakePacketJitterSendAvg = 53,
        FakePacketJitterSendMax = 54,
        FakePacketJitterSendPct = 55,
        FakePacketJitterRecvAvg = 56,
        FakePacketJitterRecvMax = 57,
        FakePacketJitterRecvPct = 58,
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
        OutOfOrderCorrectionWindowMicroseconds = 51,
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
        IpAllowWithoutAuth = 23,
        IpLocalHostAllowWithoutAuth = 52,
        MtuPacketSize = 32,
        MtuDataSize = 33,
        Unencrypted = 34,
        SymmetricConnect = 37,
        LocalVirtualPort = 38,
        DualWifiEnable = 39,
        EnableDiagnosticsUi = 46,
        SendTimeSincePreviousPacket = 59,
        SdrClientConsecPingTimeoutFailInitial = 19,
        SdrClientConsecPingTimeoutFail = 20,
        SdrClientMinPingsBeforePingAccurate = 21,
        SdrClientSingleSocket = 22,
        SdrClientForceRelayCluster = 29,
        SdrClientDevTicket = 30,
        SdrClientForceProxyAddr = 31,
        SdrClientFakeClusterPing = 36,
        SdrClientLimitPingProbesToNearestN = 60,
        LogLevelAckRtt = 13,
        LogLevelPacketDecode = 14,
        LogLevelMessage = 15,
        LogLevelPacketGaps = 16,
        LogLevelP2pRendezvous = 17,
        LogLevelSrdRelayPings = 18,
        CallbackConnectionStatusChanged = 201,
        CallbackAuthStatusChanged = 202,
        CallbackRelayNetworkStatusChanged = 203,
        CallbackMessageSessionRequest = 204,
        CallbackMessagesSessionFailed = 205,
        CallbackCreateConnectionSignaling = 206,
        CallbackFakeIpResult = 207,
        P2pStunServerList = 103,
        P2pTransportIceEnable = 104,
        P2pTransportIcePenalty = 105,
        P2pTransportSdrPenalty = 106,
        P2pTurnServerList = 107,
        P2pTurnUserList = 108,
        P2pTurnPassList = 109,
        P2pTransportIceImplementation = 110,
        Ecn = 999,
        Force32bit = 2147483647,
    }

    public enum NetworkingConnectionEnd
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
        RemoteP2pIceNoPublicAddresses = 4007,
        RemoteMax = 4999,
        MiscMin = 5000,
        MiscGeneric = 5001,
        MiscInternalError = 5002,
        MiscTimeout = 5003,
        MiscSteamConnectivity = 5005,
        MiscNoRelaySessionsToClient = 5006,
        MiscP2pRendezvous = 5008,
        MiscP2pNatFirewall = 5009,
        MiscPeerSentNoConnection = 5010,
        MiscMax = 5999,
        Force32bit = 2147483647,
    }

    public enum NetworkingConnectionState
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
        Force32bit = 2147483647,
    }

    public enum NetworkingFakeIpType
    {
        Invalid = 0,
        NotFake = 1,
        GlobalIpv4 = 2,
        LocalIpv4 = 3,
        Force32bit = 2147483647,
    }

    public enum NetworkingGetConfigValueResult
    {
        BadValue = -1,
        BadScopeObj = -2,
        BufferTooSmall = -3,
        Ok = 1,
        OkInherited = 2,
        Force32bit = 2147483647,
    }

    public enum NetworkingIdentityType
    {
        Invalid = 0,
        Steamid = 16,
        IpAddress = 1,
        GenericString = 2,
        GenericBytes = 3,
        UnknownType = 4,
        XboxPairwise = 17,
        SonyPsn = 18,
        Force32bit = 2147483647,
    }

    public enum NetworkingSocketsDebugOutputType
    {
        NetworkingSocketDebugOutputTypeNone = 0,
        NetworkingSocketDebugOutputTypeBug = 1,
        NetworkingSocketDebugOutputTypeError = 2,
        NetworkingSocketDebugOutputTypeImportant = 3,
        NetworkingSocketDebugOutputTypeWarning = 4,
        NetworkingSocketDebugOutputTypeMsg = 5,
        NetworkingSocketDebugOutputTypeVerbose = 6,
        NetworkingSocketDebugOutputTypeDebug = 7,
        NetworkingSocketDebugOutputTypeEverything = 8,
        NetworkingSocketDebugOutputTypeForce32bit = 2147483647,
    }

    public enum NotificationPosition
    {
        Invalid = -1,
        TopLeft = 0,
        TopRight = 1,
        BottomLeft = 2,
        BottomRight = 3,
    }

    public enum OverlayToStoreFlag
    {
        None = 0,
        AddToCart = 1,
        AndToCartAndShow = 2,
    }

    public enum OverlayToWebPageMode
    {
        Default = 0,
        Modal = 1,
    }

    public enum P2pSend
    {
        Unreliable = 0,
        UnreliableNoDelay = 1,
        Reliable = 2,
        ReliableWithBuffering = 3,
    }

    public enum P2pSessionError
    {
        None = 0,
        NotRunningApp = 1,
        NoRightsToApp = 2,
        DestinationNotLoggedOn = 3,
        Timeout = 4,
        Max = 5,
    }

    public enum ParentalFeature
    {
        Invalid = 0,
        Store = 1,
        Community = 2,
        Profile = 3,
        Friends = 4,
        News = 5,
        Trading = 6,
        Settings = 7,
        Console = 8,
        Browser = 9,
        FeatureParentalSetup = 10,
        Library = 11,
        Test = 12,
        SiteLicense = 13,
        KioskMode = 14,
        BlockAlways = 15,
        Desktop = 16,
        Max = 17,
    }

    public enum PartyBeaconLocationData
    {
        SteamPartyBeaconLocationDataInvalid = 0,
        SteamPartyBeaconLocationDataName = 1,
        SteamPartyBeaconLocationDataUrlSmall = 2,
        SteamPartyBeaconLocationDataUrlMedium = 3,
        SteamPartyBeaconLocationDataUrlLarge = 4,
    }

    public enum PartyBeaconLocationType
    {
        SteamPartyBeaconLocationTypeInvalid = 0,
        SteamPartyBeaconLocationTypeChatGroup = 1,
        SteamPartyBeaconLocationTypeMax = 2,
    }

    [Flags]
    public enum PersonaChange
    {
        Name = 1,
        Status = 2,
        ComeOnline = 4,
        GoneOffline = 8,
        GamePlayed = 16,
        GameServer = 32,
        Avatar = 64,
        JoinedSource = 128,
        LeftSource = 256,
        RelationshipChanged = 512,
        NameFirstSet = 1024,
        Broadcast = 2048,
        Nickname = 4096,
        SteamLevel = 8192,
        RichPresence = 16384,
    }

    public enum PersonaState
    {
        Offline = 0,
        Online = 1,
        Busy = 2,
        Away = 3,
        Snooze = 4,
        LookingToTrade = 5,
        LookingToPlay = 6,
        Invisible = 7,
        Max = 8,
    }

    public enum RemotePlayInputType
    {
        Unknown = 0,
        MouseMotion = 1,
        MouseButtonDown = 2,
        MouseButtonUp = 3,
        MouseWheel = 4,
        KeyDown = 5,
        KeyUp = 6,
    }

    [Flags]
    public enum RemotePlayKeyModifier
    {
        None = 0,
        LeftShift = 1,
        RightShift = 2,
        LeftControl = 64,
        RightControl = 128,
        LeftAlt = 256,
        RightAlt = 512,
        LeftGui = 1024,
        RightGui = 2048,
        NumLock = 4096,
        CapsLock = 8192,
        Mask = 65535,
    }

    [Flags]
    public enum RemotePlayMouseButton
    {
        Left = 1,
        Right = 2,
        Middle = 16,
        X1 = 32,
        X2 = 64,
    }

    public enum RemotePlayMouseWheelDirection
    {
        Up = 1,
        Down = 2,
        Left = 3,
        Right = 4,
    }

    public enum RemotePlayScancode
    {
        RemotePlayerScancodeUnknown = 0,
        RemotePlayerScancodeA = 4,
        RemotePlayerScancodeB = 5,
        RemotePlayerScancodeC = 6,
        RemotePlayerScancodeD = 7,
        RemotePlayerScancodeE = 8,
        RemotePlayerScancodeF = 9,
        RemotePlayerScancodeG = 10,
        RemotePlayerScancodeH = 11,
        RemotePlayerScancodeI = 12,
        RemotePlayerScancodeJ = 13,
        RemotePlayerScancodeK = 14,
        RemotePlayerScancodeL = 15,
        RemotePlayerScancodeM = 16,
        RemotePlayerScancodeN = 17,
        RemotePlayerScancodeO = 18,
        RemotePlayerScancodeP = 19,
        RemotePlayerScancodeQ = 20,
        RemotePlayerScancodeR = 21,
        RemotePlayerScancodeS = 22,
        RemotePlayerScancodeT = 23,
        RemotePlayerScancodeU = 24,
        RemotePlayerScancodeV = 25,
        RemotePlayerScancodeW = 26,
        RemotePlayerScancodeX = 27,
        RemotePlayerScancodeY = 28,
        RemotePlayerScancodeZ = 29,
        RemotePlayerScancode1 = 30,
        RemotePlayerScancode2 = 31,
        RemotePlayerScancode3 = 32,
        RemotePlayerScancode4 = 33,
        RemotePlayerScancode5 = 34,
        RemotePlayerScancode6 = 35,
        RemotePlayerScancode7 = 36,
        RemotePlayerScancode8 = 37,
        RemotePlayerScancode9 = 38,
        RemotePlayerScancode0 = 39,
        RemotePlayerScancodeReturn = 40,
        RemotePlayerScancodeEscape = 41,
        RemotePlayerScancodeBackspace = 42,
        RemotePlayerScancodeTab = 43,
        RemotePlayerScancodeSpace = 44,
        RemotePlayerScancodeMinus = 45,
        RemotePlayerScancodeEquals = 46,
        RemotePlayerScancodeLeftBracket = 47,
        RemotePlayerScancodeRightBracket = 48,
        RemotePlayerScancodeBackslash = 49,
        RemotePlayerScancodeSemicolon = 51,
        RemotePlayerScancodeApostrophe = 52,
        RemotePlayerScancodeGrave = 53,
        RemotePlayerScancodeComma = 54,
        RemotePlayerScancodePeriod = 55,
        RemotePlayerScancodeSlash = 56,
        RemotePlayerScancodeCapslock = 57,
        RemotePlayerScancodeF1 = 58,
        RemotePlayerScancodeF2 = 59,
        RemotePlayerScancodeF3 = 60,
        RemotePlayerScancodeF4 = 61,
        RemotePlayerScancodeF5 = 62,
        RemotePlayerScancodeF6 = 63,
        RemotePlayerScancodeF7 = 64,
        RemotePlayerScancodeF8 = 65,
        RemotePlayerScancodeF9 = 66,
        RemotePlayerScancodeF10 = 67,
        RemotePlayerScancodeF11 = 68,
        RemotePlayerScancodeF12 = 69,
        RemotePlayerScancodeInsert = 73,
        RemotePlayerScancodeHome = 74,
        RemotePlayerScancodePageUp = 75,
        RemotePlayerScancodeDelete = 76,
        RemotePlayerScancodeEnd = 77,
        RemotePlayerScancodePageDown = 78,
        RemotePlayerScancodeRight = 79,
        RemotePlayerScancodeLeft = 80,
        RemotePlayerScancodeDown = 81,
        RemotePlayerScancodeUp = 82,
        RemotePlayerScancodeKeypadDivide = 84,
        RemotePlayerScancodeKeypadMultiply = 85,
        RemotePlayerScancodeKeypadMinus = 86,
        RemotePlayerScancodeKeypadPlus = 87,
        RemotePlayerScancodeKeypadEnter = 88,
        RemotePlayerScancodeKeypad1 = 89,
        RemotePlayerScancodeKeypad2 = 90,
        RemotePlayerScancodeKeypad3 = 91,
        RemotePlayerScancodeKeypad4 = 92,
        RemotePlayerScancodeKeypad5 = 93,
        RemotePlayerScancodeKeypad6 = 94,
        RemotePlayerScancodeKeypad7 = 95,
        RemotePlayerScancodeKeypad8 = 96,
        RemotePlayerScancodeKeypad9 = 97,
        RemotePlayerScancodeKeypad0 = 98,
        RemotePlayerScancodeKeypadPeriod = 99,
        RemotePlayerScancodeLeftControl = 224,
        RemotePlayerScancodeLeftShift = 225,
        RemotePlayerScancodeLeftAlt = 226,
        RemotePlayerScancodeLeftGui = 227,
        RemotePlayerScancodeRightControl = 228,
        RemotePlayerScancodeRightShift = 229,
        RemotePlayerScancodeRightAlt = 230,
        RemotePlayerScancodeRightGui = 231,
    }

    [Flags]
    public enum RemoteStoragePlatform
    {
        None = 0,
        Windows = 1,
        Osx = 2,
        Ps3 = 4,
        Linux = 8,
        Reserved1 = 16,
        Reserved2 = 32,
        All = -1,
    }

    public enum RemoteStoragePublishedFileVisibility
    {
        Public = 0,
        FriendsOnly = 1,
        Private = 2,
        Unlisted = 3,
    }

    public enum Result
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
        IpNotFound = 31,
        PersistFailed = 32,
        LockingFailed = 33,
        LogOnSessionReplaced = 34,
        ConnectFailed = 35,
        HandshakeFailed = 36,
        IoFailure = 37,
        RemoteDisconnect = 38,
        ShoppingCartNotFound = 39,
        Blocked = 40,
        Ignored = 41,
        NoMatch = 42,
        AccountDisabled = 43,
        ServiceReadOnly = 44,
        AccountNotFeatured = 45,
        AdministratorOk = 46,
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
        IpLoginRestrictionFailed = 72,
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
        IpBanned = 105,
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
        PhoneNumberIsVoip = 127,
        NotSupported = 128,
        FamilySizeLimitExceeded = 129,
        OfflineAppCacheInvalid = 130,
        TryLater = 131,
    }

    public enum ScePadTriggerEffectMode
    {
        Off = 0,
        Feedback = 1,
        Weapon = 2,
        Vibration = 3,
        MultiplePositionFeedback = 4,
        SlopeFeedback = 5,
        MultiplePositionVibration = 6,
    }

    public enum SocketConnectionType
    {
        NetSocketConnectionTypeNotConnected = 0,
        NetSocketConnectionTypeUdp = 1,
        NetSocketConnectionTypeUdpRelay = 2,
    }

    public enum SocketState
    {
        NetSocketStateInvalid = 0,
        NetSocketStateConnected = 1,
        NetSocketStateInitiated = 10,
        NetSocketStateLocalCandidateFound = 11,
        NetSocketStateReceivedRemoteCandidates = 12,
        NetSocketStateChallengeHandshake = 15,
        NetSocketStateDisconnecting = 21,
        NetSocketStateLocalDisconnect = 22,
        NetSocketStateTimeoutDuringConnect = 23,
        NetSocketStateRemoteEndDisconnected = 24,
        NetSocketStateBroken = 25,
    }

    public enum SteamApiInitResult
    {
        Ok = 0,
        FailedGeneric = 1,
        NoSteamClient = 2,
        VersionMismatch = 3,
    }

    public enum SteamControllerPad
    {
        Left = 0,
        Right = 1,
        Both = 2,
        GripLeft = 3,
        GripRight = 4,
        GripBoth = 5,
    }

    public enum SteamHardwareType
    {
        None = 0,
        SteamDeck = 1,
        SteamMachine = 2,
        SteamFrame = 3,
    }

    public enum SteamHardwareDefaultConfig
    {
        None = 0,
        Low = 1,
        Medium = 2,
        High = 3,
        Max = 4,
        SteamDeck = 5,
        SteamMachine = 6,
        SteamFrame = 7,
    }

    public enum TextFilteringContext
    {
        Unknown = 0,
        GameContent = 1,
        Chat = 2,
        Name = 3,
    }

    public enum TimelineGameMode
    {
        Invalid = 0,
        Playing = 1,
        Staging = 2,
        Menus = 3,
        LoadingScreen = 4,
        Max = 5,
    }

    public enum TimelineEventClipPriority
    {
        Invalid = 0,
        None = 1,
        Standard = 2,
        Featured = 3,
    }

    public enum Universe
    {
        Invalid = 0,
        Public = 1,
        Beta = 2,
        Internal = 3,
        Dev = 4,
        Max = 5,
    }

    public enum UgcContentDescriptorId
    {
        NudityOrSexualContent = 1,
        FrequentViolenceOrGore = 2,
        AdultOnlySexualContent = 3,
        GratuitousSexualContent = 4,
        AnyMatureContent = 5,
    }

    public enum UgcMatchingUgcType
    {
        UgcMatchingUgcTypeItems = 0,
        UgcMatchingUgcTypeItemsMtx = 1,
        UgcMatchingUgcTypeItemsReadyToUse = 2,
        UgcMatchingUgcTypeCollections = 3,
        UgcMatchingUgcTypeArtwork = 4,
        UgcMatchingUgcTypeVideos = 5,
        UgcMatchingUgcTypeScreenshots = 6,
        UgcMatchingUgcTypeAllGuides = 7,
        UgcMatchingUgcTypeWebGuides = 8,
        UgcMatchingUgcTypeIntegratedGuides = 9,
        UgcMatchingUgcTypeUsableInGame = 10,
        UgcMatchingUgcTypeControllerBindings = 11,
        UgcMatchingUgcTypeGameManagedItems = 12,
        UgcMatchingUgcTypeAll = -1,
    }

    public enum UgcQuery
    {
        RankedByVote = 0,
        RankedByPublicationDate = 1,
        AcceptedForGameRankedByAcceptanceDate = 2,
        RankedByTrend = 3,
        FavoritedByFriendsRankedByPublicationDate = 4,
        CreatedByFriendsRankedByPublicationDate = 5,
        RankedByNumTimesReported = 6,
        CreatedByFollowedUsersRankedByPublicationDate = 7,
        NotYetRated = 8,
        RankedByTotalVotesAsc = 9,
        RankedByVotesUp = 10,
        RankedByTextSearch = 11,
        RankedByTotalUniqueSubscriptions = 12,
        RankedByPlaytimeTrend = 13,
        RankedByTotalPlaytime = 14,
        RankedByAveragePlaytimeTrend = 15,
        RankedByLifetimeAveragePlaytime = 16,
        RankedByPlaytimeSessionsTrend = 17,
        RankedByLifetimePlaytimeSessions = 18,
        RankedByLastUpdatedDate = 19,
        RankedByNumParentItems = 20,
        RankedByNumParentCollections = 21,
    }

    public enum UgcReadAction
    {
        ContinueReadingUntilFinished = 0,
        ContinueReading = 1,
        Close = 2,
    }

    public enum UserHasLicenseForAppResult
    {
        HasLicense = 0,
        DoesNotHaveLicense = 1,
        NoAuth = 2,
    }

    public enum UserUgcList
    {
        Published = 0,
        VotedOn = 1,
        VotedUp = 2,
        VotedDown = 3,
        WillVoteLater = 4,
        Favorited = 5,
        Subscribed = 6,
        UsedOrPlayed = 7,
        Followed = 8,
    }

    public enum UserUgcListSortOrder
    {
        CreationOrderDesc = 0,
        CreationOrderAsc = 1,
        TitleAsc = 2,
        LastUpdatedDesc = 3,
        SubscriptionDateDesc = 4,
        VoteScoreDesc = 5,
        ForModeration = 6,
    }

    public enum VoiceResult
    {
        Ok = 0,
        NotInitialized = 1,
        NotRecording = 2,
        NoData = 3,
        BufferTooSmall = 4,
        DataCorrupted = 5,
        Restricted = 6,
        UnsupportedCodec = 7,
        ReceiverOutOfDate = 8,
        ReceiverDidNotAnswer = 9,
    }

    public enum VrScreenshotType
    {
        None = 0,
        Mono = 1,
        Stereo = 2,
        MonoCubeMap = 3,
        MonoPanorama = 4,
        StereoPanorama = 5,
    }

    public enum WorkshopEnumerationType
    {
        RankedByVote = 0,
        Recent = 1,
        Trending = 2,
        FavoritesOfFriends = 3,
        VotedByFriends = 4,
        ContentByFriends = 5,
        RecentFromFollowedUsers = 6,
    }

    public enum WorkshopFileAction
    {
        Played = 0,
        Completed = 1,
    }

    public enum WorkshopFileType
    {
        First = 0,
        Community = 0,
        Microtransaction = 1,
        Collection = 2,
        Art = 3,
        Video = 4,
        Screenshot = 5,
        Game = 6,
        Software = 7,
        Concept = 8,
        WebGuide = 9,
        IntegratedGuide = 10,
        Merch = 11,
        ControllerBinding = 12,
        SteamworksAccessInvite = 13,
        SteamVideo = 14,
        GameManagedItem = 15,
        Clip = 16,
        Max = 17,
    }

    public enum WorkshopVideoProvider
    {
        None = 0,
        Youtube = 1,
    }

    public enum WorkshopVote
    {
        Unvoted = 0,
        For = 1,
        Against = 2,
        Later = 3,
    }

    public enum XboxOrigin
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
        LeftStickDpadEast = 17,
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
        Count = 28,
    }

    public new static class GDExtensionSignalName
    {
        public new static readonly StringName FileDetailsResult = "file_details_result";
        public new static readonly StringName DlcInstalled = "dlc_installed";
        public new static readonly StringName NewLaunchUrlParameters = "new_launch_url_parameters";
        public new static readonly StringName TimedTrialStatus = "timed_trial_status";
        public new static readonly StringName AvatarImageLoaded = "avatar_image_loaded";
        public new static readonly StringName AvatarLoaded = "avatar_loaded";
        public new static readonly StringName ChangeServerRequested = "change_server_requested";
        public new static readonly StringName ClanActivityDownloaded = "clan_activity_downloaded";
        public new static readonly StringName ConnectedChatJoin = "connected_chat_join";
        public new static readonly StringName ConnectedChatLeave = "connected_chat_leave";
        public new static readonly StringName ConnectedClanChatMessage = "connected_clan_chat_message";
        public new static readonly StringName ConnectedFriendChatMessage = "connected_friend_chat_message";
        public new static readonly StringName EnumerateFollowingList = "enumerate_following_list";
        public new static readonly StringName EquippedProfileItems = "equipped_profile_items";
        public new static readonly StringName EquippedProfileItemsChanged = "equipped_profile_items_changed";
        public new static readonly StringName FriendRichPresenceUpdate = "friend_rich_presence_update";
        public new static readonly StringName GetFollowerCount = "get_follower_count";
        public new static readonly StringName IsFollowing = "is_following";
        public new static readonly StringName JoinClanChatComplete = "join_clan_chat_complete";
        public new static readonly StringName JoinGameRequested = "join_game_requested";
        public new static readonly StringName JoinRequested = "join_requested";
        public new static readonly StringName OverlayBrowserProtocol = "overlay_browser_protocol";
        public new static readonly StringName OverlayToggled = "overlay_toggled";
        public new static readonly StringName PersonaStateChange = "persona_state_change";
        public new static readonly StringName RequestClanOfficerList = "request_clan_officer_list";
        public new static readonly StringName UnreadChatMessagesChanged = "unread_chat_messages_changed";
        public new static readonly StringName SearchForGameProgress = "search_for_game_progress";
        public new static readonly StringName SearchForGameResult = "search_for_game_result";
        public new static readonly StringName RequestPlayersForGameProgress = "request_players_for_game_progress";
        public new static readonly StringName RequestPlayersForGameResult = "request_players_for_game_result";
        public new static readonly StringName RequestPlayersForGameFinalResult = "request_players_for_game_final_result";
        public new static readonly StringName SubmitPlayerResult = "submit_player_result";
        public new static readonly StringName EndGameResult = "end_game_result";
        public new static readonly StringName HtmlBrowserReady = "html_browser_ready";
        public new static readonly StringName HtmlCanGoBackandforward = "html_can_go_backandforward";
        public new static readonly StringName HtmlChangedTitle = "html_changed_title";
        public new static readonly StringName HtmlCloseBrowser = "html_close_browser";
        public new static readonly StringName HtmlFileOpenDialog = "html_file_open_dialog";
        public new static readonly StringName HtmlFinishedRequest = "html_finished_request";
        public new static readonly StringName HtmlHideTooltip = "html_hide_tooltip";
        public new static readonly StringName HtmlHorizontalScroll = "html_horizontal_scroll";
        public new static readonly StringName HtmlJsAlert = "html_js_alert";
        public new static readonly StringName HtmlJsConfirm = "html_js_confirm";
        public new static readonly StringName HtmlLinkAtPosition = "html_link_at_position";
        public new static readonly StringName HtmlNeedsPaint = "html_needs_paint";
        public new static readonly StringName HtmlNewWindow = "html_new_window";
        public new static readonly StringName HtmlOpenLinkInNewTab = "html_open_link_in_new_tab";
        public new static readonly StringName HtmlSearchResults = "html_search_results";
        public new static readonly StringName HtmlSetCursor = "html_set_cursor";
        public new static readonly StringName HtmlShowTooltip = "html_show_tooltip";
        public new static readonly StringName HtmlStartRequest = "html_start_request";
        public new static readonly StringName HtmlStatusText = "html_status_text";
        public new static readonly StringName HtmlUpdateTooltip = "html_update_tooltip";
        public new static readonly StringName HtmlUrlChanged = "html_url_changed";
        public new static readonly StringName HtmlVerticalScroll = "html_vertical_scroll";
        public new static readonly StringName HttpRequestCompleted = "http_request_completed";
        public new static readonly StringName HttpRequestDataReceived = "http_request_data_received";
        public new static readonly StringName HttpRequestHeadersReceived = "http_request_headers_received";
        public new static readonly StringName InputActionEvent = "input_action_event";
        public new static readonly StringName InputDeviceConnected = "input_device_connected";
        public new static readonly StringName InputDeviceDisconnected = "input_device_disconnected";
        public new static readonly StringName InputConfigurationLoaded = "input_configuration_loaded";
        public new static readonly StringName InputGamepadSlotChange = "input_gamepad_slot_change";
        public new static readonly StringName InventoryDefinitionUpdate = "inventory_definition_update";
        public new static readonly StringName InventoryEligiblePromoItem = "inventory_eligible_promo_item";
        public new static readonly StringName InventoryFullUpdate = "inventory_full_update";
        public new static readonly StringName InventoryResultReady = "inventory_result_ready";
        public new static readonly StringName InventoryStartPurchaseResult = "inventory_start_purchase_result";
        public new static readonly StringName InventoryRequestPricesResult = "inventory_request_prices_result";
        public new static readonly StringName FavoritesListAccountsUpdated = "favorites_list_accounts_updated";
        public new static readonly StringName FavoritesListChanged = "favorites_list_changed";
        public new static readonly StringName LobbyMessage = "lobby_message";
        public new static readonly StringName LobbyChatUpdate = "lobby_chat_update";
        public new static readonly StringName LobbyCreated = "lobby_created";
        public new static readonly StringName LobbyDataUpdate = "lobby_data_update";
        public new static readonly StringName LobbyJoined = "lobby_joined";
        public new static readonly StringName LobbyGameCreated = "lobby_game_created";
        public new static readonly StringName LobbyInvite = "lobby_invite";
        public new static readonly StringName LobbyMatchList = "lobby_match_list";
        public new static readonly StringName LobbyKicked = "lobby_kicked";
        public new static readonly StringName AddFriendToList = "add_friend_to_list";
        public new static readonly StringName FriendsFailedToRespond = "friends_failed_to_respond";
        public new static readonly StringName FriendsRefreshComplete = "friends_refresh_complete";
        public new static readonly StringName PingServerFailedToRespond = "ping_server_failed_to_respond";
        public new static readonly StringName PingServerResponded = "ping_server_responded";
        public new static readonly StringName PlayerDetailsFailedToRespond = "player_details_failed_to_respond";
        public new static readonly StringName PlayerDetailsPlayerAdded = "player_details_player_added";
        public new static readonly StringName PlayerDetailsRefreshComplete = "player_details_refresh_complete";
        public new static readonly StringName RequestServerListRefreshComplete = "request_server_list_refresh_complete";
        public new static readonly StringName RequestServerListServerFailedToRespond = "request_server_list_server_failed_to_respond";
        public new static readonly StringName RequestServerListServerResponded = "request_server_list_server_responded";
        public new static readonly StringName ServerRulesFailedToRespond = "server_rules_failed_to_respond";
        public new static readonly StringName ServerRulesRefreshComplete = "server_rules_refresh_complete";
        public new static readonly StringName ServerRulesResponded = "server_rules_responded";
        public new static readonly StringName MusicPlaybackStatusHasChanged = "music_playback_status_has_changed";
        public new static readonly StringName MusicVolumeHasChanged = "music_volume_has_changed";
        public new static readonly StringName P2pSessionRequest = "p2p_session_request";
        public new static readonly StringName P2pSessionConnectFail = "p2p_session_connect_fail";
        public new static readonly StringName NetworkMessagesSessionRequest = "network_messages_session_request";
        public new static readonly StringName NetworkMessagesSessionFailed = "network_messages_session_failed";
        public new static readonly StringName NetworkConnectionStatusChanged = "network_connection_status_changed";
        public new static readonly StringName NetworkAuthenticationStatus = "network_authentication_status";
        public new static readonly StringName FakeIpResult = "fake_ip_result";
        public new static readonly StringName RelayNetworkStatus = "relay_network_status";
        public new static readonly StringName ParentalSettingChanged = "parental_setting_changed";
        public new static readonly StringName JoinParty = "join_party";
        public new static readonly StringName CreateBeacon = "create_beacon";
        public new static readonly StringName ReservationNotification = "reservation_notification";
        public new static readonly StringName ChangeNumOpenSlots = "change_num_open_slots";
        public new static readonly StringName AvailableBeaconLocationsUpdated = "available_beacon_locations_updated";
        public new static readonly StringName ActiveBeaconsUpdated = "active_beacons_updated";
        public new static readonly StringName RemotePlayGuestInvite = "remote_play_guest_invite";
        public new static readonly StringName RemotePlaySessionAvatarLoaded = "remote_play_session_avatar_loaded";
        public new static readonly StringName RemotePlaySessionConnected = "remote_play_session_connected";
        public new static readonly StringName RemotePlaySessionDisconnected = "remote_play_session_disconnected";
        public new static readonly StringName FileReadAsyncComplete = "file_read_async_complete";
        public new static readonly StringName FileShareResult = "file_share_result";
        public new static readonly StringName FileWriteAsyncComplete = "file_write_async_complete";
        public new static readonly StringName DownloadUgcResult = "download_ugc_result";
        public new static readonly StringName PublishedFileSubscribed = "published_file_subscribed";
        public new static readonly StringName PublishedFileUnsubscribed = "published_file_unsubscribed";
        public new static readonly StringName UnsubscribeItem = "unsubscribe_item";
        public new static readonly StringName SubscribeItem = "subscribe_item";
        public new static readonly StringName LocalFileChanged = "local_file_changed";
        public new static readonly StringName ScreenshotReady = "screenshot_ready";
        public new static readonly StringName ScreenshotRequested = "screenshot_requested";
        public new static readonly StringName TimelineEventRecordingExists = "timeline_event_recording_exists";
        public new static readonly StringName TimelineGamePhaseRecordingExists = "timeline_game_phase_recording_exists";
        public new static readonly StringName AddAppDependencyResult = "add_app_dependency_result";
        public new static readonly StringName AddUgcDependencyResult = "add_ugc_dependency_result";
        public new static readonly StringName GetAppDependenciesResult = "get_app_dependencies_result";
        public new static readonly StringName GetItemVoteResult = "get_item_vote_result";
        public new static readonly StringName ItemCreated = "item_created";
        public new static readonly StringName ItemDeleted = "item_deleted";
        public new static readonly StringName ItemDownloaded = "item_downloaded";
        public new static readonly StringName ItemInstalled = "item_installed";
        public new static readonly StringName ItemUpdated = "item_updated";
        public new static readonly StringName RemoveAppDependencyResult = "remove_app_dependency_result";
        public new static readonly StringName RemoveUgcDependencyResult = "remove_ugc_dependency_result";
        public new static readonly StringName SetUserItemVote = "set_user_item_vote";
        public new static readonly StringName StartPlaytimeTracking = "start_playtime_tracking";
        public new static readonly StringName StopPlaytimeTracking = "stop_playtime_tracking";
        public new static readonly StringName UgcQueryCompleted = "ugc_query_completed";
        public new static readonly StringName UserFavoriteItemsListChanged = "user_favorite_items_list_changed";
        public new static readonly StringName UserSubscribedItemsListChanged = "user_subscribed_items_list_changed";
        public new static readonly StringName WorkshopEulaStatus = "workshop_eula_status";
        public new static readonly StringName ClientGameServerDeny = "client_game_server_deny";
        public new static readonly StringName DurationControl = "duration_control";
        public new static readonly StringName EncryptedAppTicketResponse = "encrypted_app_ticket_response";
        public new static readonly StringName GameWebCallback = "game_web_callback";
        public new static readonly StringName GetAuthSessionTicketResponse = "get_auth_session_ticket_response";
        public new static readonly StringName GetTicketForWebApi = "get_ticket_for_web_api";
        public new static readonly StringName IpcFailure = "ipc_failure";
        public new static readonly StringName LicensesUpdated = "licenses_updated";
        public new static readonly StringName MarketEligibilityResponse = "market_eligibility_response";
        public new static readonly StringName MicrotransactionAuthResponse = "microtransaction_auth_response";
        public new static readonly StringName SteamServerConnectFailed = "steam_server_connect_failed";
        public new static readonly StringName SteamServerConnected = "steam_server_connected";
        public new static readonly StringName SteamServerDisconnected = "steam_server_disconnected";
        public new static readonly StringName StoreAuthUrlResponse = "store_auth_url_response";
        public new static readonly StringName ValidateAuthTicketResponse = "validate_auth_ticket_response";
        public new static readonly StringName GlobalAchievementPercentagesReady = "global_achievement_percentages_ready";
        public new static readonly StringName GlobalStatsReceived = "global_stats_received";
        public new static readonly StringName LeaderboardFindResult = "leaderboard_find_result";
        public new static readonly StringName LeaderboardScoresDownloaded = "leaderboard_scores_downloaded";
        public new static readonly StringName LeaderboardScoreUploaded = "leaderboard_score_uploaded";
        public new static readonly StringName LeaderboardUgcSet = "leaderboard_ugc_set";
        public new static readonly StringName NumberOfCurrentPlayers = "number_of_current_players";
        public new static readonly StringName UserAchievementIconFetched = "user_achievement_icon_fetched";
        public new static readonly StringName UserAchievementStored = "user_achievement_stored";
        public new static readonly StringName UserStatsReceived = "user_stats_received";
        public new static readonly StringName UserStatsStored = "user_stats_stored";
        public new static readonly StringName UserStatsUnloaded = "user_stats_unloaded";
        public new static readonly StringName CheckFileSignature = "check_file_signature";
        public new static readonly StringName GamepadTextInputDismissed = "gamepad_text_input_dismissed";
        public new static readonly StringName IpCountry = "ip_country";
        public new static readonly StringName LowPower = "low_power";
        public new static readonly StringName SteamApiCallCompleted = "steam_api_call_completed";
        public new static readonly StringName SteamShutdown = "steam_shutdown";
        public new static readonly StringName AppResumingFromSuspend = "app_resuming_from_suspend";
        public new static readonly StringName FloatingGamepadTextInputDismissed = "floating_gamepad_text_input_dismissed";
        public new static readonly StringName FilterTextDictionaryChanged = "filter_text_dictionary_changed";
        public new static readonly StringName BroadcastUploadStart = "broadcast_upload_start";
        public new static readonly StringName BroadcastUploadStop = "broadcast_upload_stop";
        public new static readonly StringName GetOpfSettingsResult = "get_opf_settings_result";
        public new static readonly StringName GetVideoResult = "get_video_result";
    }

    public new delegate void FileDetailsResultSignalHandler(long result, long fileSize, long fileHash, long flags);
    private FileDetailsResultSignalHandler _fileDetailsResultSignal;
    private Callable _fileDetailsResultSignalCallable;
    public event FileDetailsResultSignalHandler FileDetailsResultSignal
    {
        add
        {
            if (_fileDetailsResultSignal is null)
            {
                _fileDetailsResultSignalCallable = Callable.From((Variant result, Variant fileSize, Variant fileHash, Variant flags) => 
                    _fileDetailsResultSignal?.Invoke(result.As<long>(), fileSize.As<long>(), fileHash.As<long>(), flags.As<long>()));
                Connect(GDExtensionSignalName.FileDetailsResult, _fileDetailsResultSignalCallable);
            }
            _fileDetailsResultSignal += value;
        }
        remove
        {
            _fileDetailsResultSignal -= value;
            if (_fileDetailsResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.FileDetailsResult, _fileDetailsResultSignalCallable);
            _fileDetailsResultSignalCallable = default;
        }
    }

    public new delegate void DlcInstalledSignalHandler(long app);
    private DlcInstalledSignalHandler _dlcInstalledSignal;
    private Callable _dlcInstalledSignalCallable;
    public event DlcInstalledSignalHandler DlcInstalledSignal
    {
        add
        {
            if (_dlcInstalledSignal is null)
            {
                _dlcInstalledSignalCallable = Callable.From((Variant app) => 
                    _dlcInstalledSignal?.Invoke(app.As<long>()));
                Connect(GDExtensionSignalName.DlcInstalled, _dlcInstalledSignalCallable);
            }
            _dlcInstalledSignal += value;
        }
        remove
        {
            _dlcInstalledSignal -= value;
            if (_dlcInstalledSignal is not null) return;
            Disconnect(GDExtensionSignalName.DlcInstalled, _dlcInstalledSignalCallable);
            _dlcInstalledSignalCallable = default;
        }
    }

    public new delegate void NewLaunchUrlParametersSignalHandler();
    private NewLaunchUrlParametersSignalHandler _newLaunchUrlParametersSignal;
    private Callable _newLaunchUrlParametersSignalCallable;
    public event NewLaunchUrlParametersSignalHandler NewLaunchUrlParametersSignal
    {
        add
        {
            if (_newLaunchUrlParametersSignal is null)
            {
                _newLaunchUrlParametersSignalCallable = Callable.From(() => 
                    _newLaunchUrlParametersSignal?.Invoke());
                Connect(GDExtensionSignalName.NewLaunchUrlParameters, _newLaunchUrlParametersSignalCallable);
            }
            _newLaunchUrlParametersSignal += value;
        }
        remove
        {
            _newLaunchUrlParametersSignal -= value;
            if (_newLaunchUrlParametersSignal is not null) return;
            Disconnect(GDExtensionSignalName.NewLaunchUrlParameters, _newLaunchUrlParametersSignalCallable);
            _newLaunchUrlParametersSignalCallable = default;
        }
    }

    public new delegate void TimedTrialStatusSignalHandler(long appId, bool isOffline, long secondsAllowed, long secondsPlayed);
    private TimedTrialStatusSignalHandler _timedTrialStatusSignal;
    private Callable _timedTrialStatusSignalCallable;
    public event TimedTrialStatusSignalHandler TimedTrialStatusSignal
    {
        add
        {
            if (_timedTrialStatusSignal is null)
            {
                _timedTrialStatusSignalCallable = Callable.From((Variant appId, Variant isOffline, Variant secondsAllowed, Variant secondsPlayed) => 
                    _timedTrialStatusSignal?.Invoke(appId.As<long>(), isOffline.As<bool>(), secondsAllowed.As<long>(), secondsPlayed.As<long>()));
                Connect(GDExtensionSignalName.TimedTrialStatus, _timedTrialStatusSignalCallable);
            }
            _timedTrialStatusSignal += value;
        }
        remove
        {
            _timedTrialStatusSignal -= value;
            if (_timedTrialStatusSignal is not null) return;
            Disconnect(GDExtensionSignalName.TimedTrialStatus, _timedTrialStatusSignalCallable);
            _timedTrialStatusSignalCallable = default;
        }
    }

    public new delegate void AvatarImageLoadedSignalHandler(long avatarId, long avatarIndex, long width, long height);
    private AvatarImageLoadedSignalHandler _avatarImageLoadedSignal;
    private Callable _avatarImageLoadedSignalCallable;
    public event AvatarImageLoadedSignalHandler AvatarImageLoadedSignal
    {
        add
        {
            if (_avatarImageLoadedSignal is null)
            {
                _avatarImageLoadedSignalCallable = Callable.From((Variant avatarId, Variant avatarIndex, Variant width, Variant height) => 
                    _avatarImageLoadedSignal?.Invoke(avatarId.As<long>(), avatarIndex.As<long>(), width.As<long>(), height.As<long>()));
                Connect(GDExtensionSignalName.AvatarImageLoaded, _avatarImageLoadedSignalCallable);
            }
            _avatarImageLoadedSignal += value;
        }
        remove
        {
            _avatarImageLoadedSignal -= value;
            if (_avatarImageLoadedSignal is not null) return;
            Disconnect(GDExtensionSignalName.AvatarImageLoaded, _avatarImageLoadedSignalCallable);
            _avatarImageLoadedSignalCallable = default;
        }
    }

    public new delegate void AvatarLoadedSignalHandler(long avatarId, long size, byte[] data);
    private AvatarLoadedSignalHandler _avatarLoadedSignal;
    private Callable _avatarLoadedSignalCallable;
    public event AvatarLoadedSignalHandler AvatarLoadedSignal
    {
        add
        {
            if (_avatarLoadedSignal is null)
            {
                _avatarLoadedSignalCallable = Callable.From((Variant avatarId, Variant size, Variant data) => 
                    _avatarLoadedSignal?.Invoke(avatarId.As<long>(), size.As<long>(), data.As<byte[]>()));
                Connect(GDExtensionSignalName.AvatarLoaded, _avatarLoadedSignalCallable);
            }
            _avatarLoadedSignal += value;
        }
        remove
        {
            _avatarLoadedSignal -= value;
            if (_avatarLoadedSignal is not null) return;
            Disconnect(GDExtensionSignalName.AvatarLoaded, _avatarLoadedSignalCallable);
            _avatarLoadedSignalCallable = default;
        }
    }

    public new delegate void ChangeServerRequestedSignalHandler(string server, string password);
    private ChangeServerRequestedSignalHandler _changeServerRequestedSignal;
    private Callable _changeServerRequestedSignalCallable;
    public event ChangeServerRequestedSignalHandler ChangeServerRequestedSignal
    {
        add
        {
            if (_changeServerRequestedSignal is null)
            {
                _changeServerRequestedSignalCallable = Callable.From((Variant server, Variant password) => 
                    _changeServerRequestedSignal?.Invoke(server.As<string>(), password.As<string>()));
                Connect(GDExtensionSignalName.ChangeServerRequested, _changeServerRequestedSignalCallable);
            }
            _changeServerRequestedSignal += value;
        }
        remove
        {
            _changeServerRequestedSignal -= value;
            if (_changeServerRequestedSignal is not null) return;
            Disconnect(GDExtensionSignalName.ChangeServerRequested, _changeServerRequestedSignalCallable);
            _changeServerRequestedSignalCallable = default;
        }
    }

    public new delegate void ClanActivityDownloadedSignalHandler(Godot.Collections.Dictionary activity);
    private ClanActivityDownloadedSignalHandler _clanActivityDownloadedSignal;
    private Callable _clanActivityDownloadedSignalCallable;
    public event ClanActivityDownloadedSignalHandler ClanActivityDownloadedSignal
    {
        add
        {
            if (_clanActivityDownloadedSignal is null)
            {
                _clanActivityDownloadedSignalCallable = Callable.From((Variant activity) => 
                    _clanActivityDownloadedSignal?.Invoke(activity.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.ClanActivityDownloaded, _clanActivityDownloadedSignalCallable);
            }
            _clanActivityDownloadedSignal += value;
        }
        remove
        {
            _clanActivityDownloadedSignal -= value;
            if (_clanActivityDownloadedSignal is not null) return;
            Disconnect(GDExtensionSignalName.ClanActivityDownloaded, _clanActivityDownloadedSignalCallable);
            _clanActivityDownloadedSignalCallable = default;
        }
    }

    public new delegate void ConnectedChatJoinSignalHandler(long chatId, long steamId);
    private ConnectedChatJoinSignalHandler _connectedChatJoinSignal;
    private Callable _connectedChatJoinSignalCallable;
    public event ConnectedChatJoinSignalHandler ConnectedChatJoinSignal
    {
        add
        {
            if (_connectedChatJoinSignal is null)
            {
                _connectedChatJoinSignalCallable = Callable.From((Variant chatId, Variant steamId) => 
                    _connectedChatJoinSignal?.Invoke(chatId.As<long>(), steamId.As<long>()));
                Connect(GDExtensionSignalName.ConnectedChatJoin, _connectedChatJoinSignalCallable);
            }
            _connectedChatJoinSignal += value;
        }
        remove
        {
            _connectedChatJoinSignal -= value;
            if (_connectedChatJoinSignal is not null) return;
            Disconnect(GDExtensionSignalName.ConnectedChatJoin, _connectedChatJoinSignalCallable);
            _connectedChatJoinSignalCallable = default;
        }
    }

    public new delegate void ConnectedChatLeaveSignalHandler(long chatId, long steamId, bool kicked, bool dropped);
    private ConnectedChatLeaveSignalHandler _connectedChatLeaveSignal;
    private Callable _connectedChatLeaveSignalCallable;
    public event ConnectedChatLeaveSignalHandler ConnectedChatLeaveSignal
    {
        add
        {
            if (_connectedChatLeaveSignal is null)
            {
                _connectedChatLeaveSignalCallable = Callable.From((Variant chatId, Variant steamId, Variant kicked, Variant dropped) => 
                    _connectedChatLeaveSignal?.Invoke(chatId.As<long>(), steamId.As<long>(), kicked.As<bool>(), dropped.As<bool>()));
                Connect(GDExtensionSignalName.ConnectedChatLeave, _connectedChatLeaveSignalCallable);
            }
            _connectedChatLeaveSignal += value;
        }
        remove
        {
            _connectedChatLeaveSignal -= value;
            if (_connectedChatLeaveSignal is not null) return;
            Disconnect(GDExtensionSignalName.ConnectedChatLeave, _connectedChatLeaveSignalCallable);
            _connectedChatLeaveSignalCallable = default;
        }
    }

    public new delegate void ConnectedClanChatMessageSignalHandler(long clanChatId, long messageIndex, string messageText, long type, long chatter);
    private ConnectedClanChatMessageSignalHandler _connectedClanChatMessageSignal;
    private Callable _connectedClanChatMessageSignalCallable;
    public event ConnectedClanChatMessageSignalHandler ConnectedClanChatMessageSignal
    {
        add
        {
            if (_connectedClanChatMessageSignal is null)
            {
                _connectedClanChatMessageSignalCallable = Callable.From((Variant clanChatId, Variant messageIndex, Variant messageText, Variant type, Variant chatter) => 
                    _connectedClanChatMessageSignal?.Invoke(clanChatId.As<long>(), messageIndex.As<long>(), messageText.As<string>(), type.As<long>(), chatter.As<long>()));
                Connect(GDExtensionSignalName.ConnectedClanChatMessage, _connectedClanChatMessageSignalCallable);
            }
            _connectedClanChatMessageSignal += value;
        }
        remove
        {
            _connectedClanChatMessageSignal -= value;
            if (_connectedClanChatMessageSignal is not null) return;
            Disconnect(GDExtensionSignalName.ConnectedClanChatMessage, _connectedClanChatMessageSignalCallable);
            _connectedClanChatMessageSignalCallable = default;
        }
    }

    public new delegate void ConnectedFriendChatMessageSignalHandler(long steamId, long messageIndex, long messageText, long type);
    private ConnectedFriendChatMessageSignalHandler _connectedFriendChatMessageSignal;
    private Callable _connectedFriendChatMessageSignalCallable;
    public event ConnectedFriendChatMessageSignalHandler ConnectedFriendChatMessageSignal
    {
        add
        {
            if (_connectedFriendChatMessageSignal is null)
            {
                _connectedFriendChatMessageSignalCallable = Callable.From((Variant steamId, Variant messageIndex, Variant messageText, Variant type) => 
                    _connectedFriendChatMessageSignal?.Invoke(steamId.As<long>(), messageIndex.As<long>(), messageText.As<long>(), type.As<long>()));
                Connect(GDExtensionSignalName.ConnectedFriendChatMessage, _connectedFriendChatMessageSignalCallable);
            }
            _connectedFriendChatMessageSignal += value;
        }
        remove
        {
            _connectedFriendChatMessageSignal -= value;
            if (_connectedFriendChatMessageSignal is not null) return;
            Disconnect(GDExtensionSignalName.ConnectedFriendChatMessage, _connectedFriendChatMessageSignalCallable);
            _connectedFriendChatMessageSignalCallable = default;
        }
    }

    public new delegate void EnumerateFollowingListSignalHandler(string message, long[] following);
    private EnumerateFollowingListSignalHandler _enumerateFollowingListSignal;
    private Callable _enumerateFollowingListSignalCallable;
    public event EnumerateFollowingListSignalHandler EnumerateFollowingListSignal
    {
        add
        {
            if (_enumerateFollowingListSignal is null)
            {
                _enumerateFollowingListSignalCallable = Callable.From((Variant message, Variant following) => 
                    _enumerateFollowingListSignal?.Invoke(message.As<string>(), following.As<long[]>()));
                Connect(GDExtensionSignalName.EnumerateFollowingList, _enumerateFollowingListSignalCallable);
            }
            _enumerateFollowingListSignal += value;
        }
        remove
        {
            _enumerateFollowingListSignal -= value;
            if (_enumerateFollowingListSignal is not null) return;
            Disconnect(GDExtensionSignalName.EnumerateFollowingList, _enumerateFollowingListSignalCallable);
            _enumerateFollowingListSignalCallable = default;
        }
    }

    public new delegate void EquippedProfileItemsSignalHandler(long result, long steamId, Godot.Collections.Dictionary profileData);
    private EquippedProfileItemsSignalHandler _equippedProfileItemsSignal;
    private Callable _equippedProfileItemsSignalCallable;
    public event EquippedProfileItemsSignalHandler EquippedProfileItemsSignal
    {
        add
        {
            if (_equippedProfileItemsSignal is null)
            {
                _equippedProfileItemsSignalCallable = Callable.From((Variant result, Variant steamId, Variant profileData) => 
                    _equippedProfileItemsSignal?.Invoke(result.As<long>(), steamId.As<long>(), profileData.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.EquippedProfileItems, _equippedProfileItemsSignalCallable);
            }
            _equippedProfileItemsSignal += value;
        }
        remove
        {
            _equippedProfileItemsSignal -= value;
            if (_equippedProfileItemsSignal is not null) return;
            Disconnect(GDExtensionSignalName.EquippedProfileItems, _equippedProfileItemsSignalCallable);
            _equippedProfileItemsSignalCallable = default;
        }
    }

    public new delegate void EquippedProfileItemsChangedSignalHandler(long steamId);
    private EquippedProfileItemsChangedSignalHandler _equippedProfileItemsChangedSignal;
    private Callable _equippedProfileItemsChangedSignalCallable;
    public event EquippedProfileItemsChangedSignalHandler EquippedProfileItemsChangedSignal
    {
        add
        {
            if (_equippedProfileItemsChangedSignal is null)
            {
                _equippedProfileItemsChangedSignalCallable = Callable.From((Variant steamId) => 
                    _equippedProfileItemsChangedSignal?.Invoke(steamId.As<long>()));
                Connect(GDExtensionSignalName.EquippedProfileItemsChanged, _equippedProfileItemsChangedSignalCallable);
            }
            _equippedProfileItemsChangedSignal += value;
        }
        remove
        {
            _equippedProfileItemsChangedSignal -= value;
            if (_equippedProfileItemsChangedSignal is not null) return;
            Disconnect(GDExtensionSignalName.EquippedProfileItemsChanged, _equippedProfileItemsChangedSignalCallable);
            _equippedProfileItemsChangedSignalCallable = default;
        }
    }

    public new delegate void FriendRichPresenceUpdateSignalHandler(long steamId, long appId);
    private FriendRichPresenceUpdateSignalHandler _friendRichPresenceUpdateSignal;
    private Callable _friendRichPresenceUpdateSignalCallable;
    public event FriendRichPresenceUpdateSignalHandler FriendRichPresenceUpdateSignal
    {
        add
        {
            if (_friendRichPresenceUpdateSignal is null)
            {
                _friendRichPresenceUpdateSignalCallable = Callable.From((Variant steamId, Variant appId) => 
                    _friendRichPresenceUpdateSignal?.Invoke(steamId.As<long>(), appId.As<long>()));
                Connect(GDExtensionSignalName.FriendRichPresenceUpdate, _friendRichPresenceUpdateSignalCallable);
            }
            _friendRichPresenceUpdateSignal += value;
        }
        remove
        {
            _friendRichPresenceUpdateSignal -= value;
            if (_friendRichPresenceUpdateSignal is not null) return;
            Disconnect(GDExtensionSignalName.FriendRichPresenceUpdate, _friendRichPresenceUpdateSignalCallable);
            _friendRichPresenceUpdateSignalCallable = default;
        }
    }

    public new delegate void GetFollowerCountSignalHandler(long result, long steamId, long count);
    private GetFollowerCountSignalHandler _getFollowerCountSignal;
    private Callable _getFollowerCountSignalCallable;
    public event GetFollowerCountSignalHandler GetFollowerCountSignal
    {
        add
        {
            if (_getFollowerCountSignal is null)
            {
                _getFollowerCountSignalCallable = Callable.From((Variant result, Variant steamId, Variant count) => 
                    _getFollowerCountSignal?.Invoke(result.As<long>(), steamId.As<long>(), count.As<long>()));
                Connect(GDExtensionSignalName.GetFollowerCount, _getFollowerCountSignalCallable);
            }
            _getFollowerCountSignal += value;
        }
        remove
        {
            _getFollowerCountSignal -= value;
            if (_getFollowerCountSignal is not null) return;
            Disconnect(GDExtensionSignalName.GetFollowerCount, _getFollowerCountSignalCallable);
            _getFollowerCountSignalCallable = default;
        }
    }

    public new delegate void IsFollowingSignalHandler(long result, long steamId, bool following);
    private IsFollowingSignalHandler _isFollowingSignal;
    private Callable _isFollowingSignalCallable;
    public event IsFollowingSignalHandler IsFollowingSignal
    {
        add
        {
            if (_isFollowingSignal is null)
            {
                _isFollowingSignalCallable = Callable.From((Variant result, Variant steamId, Variant following) => 
                    _isFollowingSignal?.Invoke(result.As<long>(), steamId.As<long>(), following.As<bool>()));
                Connect(GDExtensionSignalName.IsFollowing, _isFollowingSignalCallable);
            }
            _isFollowingSignal += value;
        }
        remove
        {
            _isFollowingSignal -= value;
            if (_isFollowingSignal is not null) return;
            Disconnect(GDExtensionSignalName.IsFollowing, _isFollowingSignalCallable);
            _isFollowingSignalCallable = default;
        }
    }

    public new delegate void JoinClanChatCompleteSignalHandler(long chatId, long response);
    private JoinClanChatCompleteSignalHandler _joinClanChatCompleteSignal;
    private Callable _joinClanChatCompleteSignalCallable;
    public event JoinClanChatCompleteSignalHandler JoinClanChatCompleteSignal
    {
        add
        {
            if (_joinClanChatCompleteSignal is null)
            {
                _joinClanChatCompleteSignalCallable = Callable.From((Variant chatId, Variant response) => 
                    _joinClanChatCompleteSignal?.Invoke(chatId.As<long>(), response.As<long>()));
                Connect(GDExtensionSignalName.JoinClanChatComplete, _joinClanChatCompleteSignalCallable);
            }
            _joinClanChatCompleteSignal += value;
        }
        remove
        {
            _joinClanChatCompleteSignal -= value;
            if (_joinClanChatCompleteSignal is not null) return;
            Disconnect(GDExtensionSignalName.JoinClanChatComplete, _joinClanChatCompleteSignalCallable);
            _joinClanChatCompleteSignalCallable = default;
        }
    }

    public new delegate void JoinGameRequestedSignalHandler(long user, string connect);
    private JoinGameRequestedSignalHandler _joinGameRequestedSignal;
    private Callable _joinGameRequestedSignalCallable;
    public event JoinGameRequestedSignalHandler JoinGameRequestedSignal
    {
        add
        {
            if (_joinGameRequestedSignal is null)
            {
                _joinGameRequestedSignalCallable = Callable.From((Variant user, Variant connect) => 
                    _joinGameRequestedSignal?.Invoke(user.As<long>(), connect.As<string>()));
                Connect(GDExtensionSignalName.JoinGameRequested, _joinGameRequestedSignalCallable);
            }
            _joinGameRequestedSignal += value;
        }
        remove
        {
            _joinGameRequestedSignal -= value;
            if (_joinGameRequestedSignal is not null) return;
            Disconnect(GDExtensionSignalName.JoinGameRequested, _joinGameRequestedSignalCallable);
            _joinGameRequestedSignalCallable = default;
        }
    }

    public new delegate void JoinRequestedSignalHandler(long lobbyId, long steamId);
    private JoinRequestedSignalHandler _joinRequestedSignal;
    private Callable _joinRequestedSignalCallable;
    public event JoinRequestedSignalHandler JoinRequestedSignal
    {
        add
        {
            if (_joinRequestedSignal is null)
            {
                _joinRequestedSignalCallable = Callable.From((Variant lobbyId, Variant steamId) => 
                    _joinRequestedSignal?.Invoke(lobbyId.As<long>(), steamId.As<long>()));
                Connect(GDExtensionSignalName.JoinRequested, _joinRequestedSignalCallable);
            }
            _joinRequestedSignal += value;
        }
        remove
        {
            _joinRequestedSignal -= value;
            if (_joinRequestedSignal is not null) return;
            Disconnect(GDExtensionSignalName.JoinRequested, _joinRequestedSignalCallable);
            _joinRequestedSignalCallable = default;
        }
    }

    public new delegate void OverlayBrowserProtocolSignalHandler(string uri);
    private OverlayBrowserProtocolSignalHandler _overlayBrowserProtocolSignal;
    private Callable _overlayBrowserProtocolSignalCallable;
    public event OverlayBrowserProtocolSignalHandler OverlayBrowserProtocolSignal
    {
        add
        {
            if (_overlayBrowserProtocolSignal is null)
            {
                _overlayBrowserProtocolSignalCallable = Callable.From((Variant uri) => 
                    _overlayBrowserProtocolSignal?.Invoke(uri.As<string>()));
                Connect(GDExtensionSignalName.OverlayBrowserProtocol, _overlayBrowserProtocolSignalCallable);
            }
            _overlayBrowserProtocolSignal += value;
        }
        remove
        {
            _overlayBrowserProtocolSignal -= value;
            if (_overlayBrowserProtocolSignal is not null) return;
            Disconnect(GDExtensionSignalName.OverlayBrowserProtocol, _overlayBrowserProtocolSignalCallable);
            _overlayBrowserProtocolSignalCallable = default;
        }
    }

    public new delegate void OverlayToggledSignalHandler(bool active, bool userInitiated, long appId);
    private OverlayToggledSignalHandler _overlayToggledSignal;
    private Callable _overlayToggledSignalCallable;
    public event OverlayToggledSignalHandler OverlayToggledSignal
    {
        add
        {
            if (_overlayToggledSignal is null)
            {
                _overlayToggledSignalCallable = Callable.From((Variant active, Variant userInitiated, Variant appId) => 
                    _overlayToggledSignal?.Invoke(active.As<bool>(), userInitiated.As<bool>(), appId.As<long>()));
                Connect(GDExtensionSignalName.OverlayToggled, _overlayToggledSignalCallable);
            }
            _overlayToggledSignal += value;
        }
        remove
        {
            _overlayToggledSignal -= value;
            if (_overlayToggledSignal is not null) return;
            Disconnect(GDExtensionSignalName.OverlayToggled, _overlayToggledSignalCallable);
            _overlayToggledSignalCallable = default;
        }
    }

    public new delegate void PersonaStateChangeSignalHandler(long steamId, long flags);
    private PersonaStateChangeSignalHandler _personaStateChangeSignal;
    private Callable _personaStateChangeSignalCallable;
    public event PersonaStateChangeSignalHandler PersonaStateChangeSignal
    {
        add
        {
            if (_personaStateChangeSignal is null)
            {
                _personaStateChangeSignalCallable = Callable.From((Variant steamId, Variant flags) => 
                    _personaStateChangeSignal?.Invoke(steamId.As<long>(), flags.As<long>()));
                Connect(GDExtensionSignalName.PersonaStateChange, _personaStateChangeSignalCallable);
            }
            _personaStateChangeSignal += value;
        }
        remove
        {
            _personaStateChangeSignal -= value;
            if (_personaStateChangeSignal is not null) return;
            Disconnect(GDExtensionSignalName.PersonaStateChange, _personaStateChangeSignalCallable);
            _personaStateChangeSignalCallable = default;
        }
    }

    public new delegate void RequestClanOfficerListSignalHandler(bool success, Godot.Collections.Array officerList);
    private RequestClanOfficerListSignalHandler _requestClanOfficerListSignal;
    private Callable _requestClanOfficerListSignalCallable;
    public event RequestClanOfficerListSignalHandler RequestClanOfficerListSignal
    {
        add
        {
            if (_requestClanOfficerListSignal is null)
            {
                _requestClanOfficerListSignalCallable = Callable.From((Variant success, Variant officerList) => 
                    _requestClanOfficerListSignal?.Invoke(success.As<bool>(), officerList.As<Godot.Collections.Array>()));
                Connect(GDExtensionSignalName.RequestClanOfficerList, _requestClanOfficerListSignalCallable);
            }
            _requestClanOfficerListSignal += value;
        }
        remove
        {
            _requestClanOfficerListSignal -= value;
            if (_requestClanOfficerListSignal is not null) return;
            Disconnect(GDExtensionSignalName.RequestClanOfficerList, _requestClanOfficerListSignalCallable);
            _requestClanOfficerListSignalCallable = default;
        }
    }

    public new delegate void UnreadChatMessagesChangedSignalHandler();
    private UnreadChatMessagesChangedSignalHandler _unreadChatMessagesChangedSignal;
    private Callable _unreadChatMessagesChangedSignalCallable;
    public event UnreadChatMessagesChangedSignalHandler UnreadChatMessagesChangedSignal
    {
        add
        {
            if (_unreadChatMessagesChangedSignal is null)
            {
                _unreadChatMessagesChangedSignalCallable = Callable.From(() => 
                    _unreadChatMessagesChangedSignal?.Invoke());
                Connect(GDExtensionSignalName.UnreadChatMessagesChanged, _unreadChatMessagesChangedSignalCallable);
            }
            _unreadChatMessagesChangedSignal += value;
        }
        remove
        {
            _unreadChatMessagesChangedSignal -= value;
            if (_unreadChatMessagesChangedSignal is not null) return;
            Disconnect(GDExtensionSignalName.UnreadChatMessagesChanged, _unreadChatMessagesChangedSignalCallable);
            _unreadChatMessagesChangedSignalCallable = default;
        }
    }

    public new delegate void SearchForGameProgressSignalHandler(long result, long searchId, Godot.Collections.Dictionary searchProgress);
    private SearchForGameProgressSignalHandler _searchForGameProgressSignal;
    private Callable _searchForGameProgressSignalCallable;
    public event SearchForGameProgressSignalHandler SearchForGameProgressSignal
    {
        add
        {
            if (_searchForGameProgressSignal is null)
            {
                _searchForGameProgressSignalCallable = Callable.From((Variant result, Variant searchId, Variant searchProgress) => 
                    _searchForGameProgressSignal?.Invoke(result.As<long>(), searchId.As<long>(), searchProgress.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.SearchForGameProgress, _searchForGameProgressSignalCallable);
            }
            _searchForGameProgressSignal += value;
        }
        remove
        {
            _searchForGameProgressSignal -= value;
            if (_searchForGameProgressSignal is not null) return;
            Disconnect(GDExtensionSignalName.SearchForGameProgress, _searchForGameProgressSignalCallable);
            _searchForGameProgressSignalCallable = default;
        }
    }

    public new delegate void SearchForGameResultSignalHandler(long result, long searchId, Godot.Collections.Dictionary searchResult);
    private SearchForGameResultSignalHandler _searchForGameResultSignal;
    private Callable _searchForGameResultSignalCallable;
    public event SearchForGameResultSignalHandler SearchForGameResultSignal
    {
        add
        {
            if (_searchForGameResultSignal is null)
            {
                _searchForGameResultSignalCallable = Callable.From((Variant result, Variant searchId, Variant searchResult) => 
                    _searchForGameResultSignal?.Invoke(result.As<long>(), searchId.As<long>(), searchResult.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.SearchForGameResult, _searchForGameResultSignalCallable);
            }
            _searchForGameResultSignal += value;
        }
        remove
        {
            _searchForGameResultSignal -= value;
            if (_searchForGameResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.SearchForGameResult, _searchForGameResultSignalCallable);
            _searchForGameResultSignalCallable = default;
        }
    }

    public new delegate void RequestPlayersForGameProgressSignalHandler(long result, long searchId);
    private RequestPlayersForGameProgressSignalHandler _requestPlayersForGameProgressSignal;
    private Callable _requestPlayersForGameProgressSignalCallable;
    public event RequestPlayersForGameProgressSignalHandler RequestPlayersForGameProgressSignal
    {
        add
        {
            if (_requestPlayersForGameProgressSignal is null)
            {
                _requestPlayersForGameProgressSignalCallable = Callable.From((Variant result, Variant searchId) => 
                    _requestPlayersForGameProgressSignal?.Invoke(result.As<long>(), searchId.As<long>()));
                Connect(GDExtensionSignalName.RequestPlayersForGameProgress, _requestPlayersForGameProgressSignalCallable);
            }
            _requestPlayersForGameProgressSignal += value;
        }
        remove
        {
            _requestPlayersForGameProgressSignal -= value;
            if (_requestPlayersForGameProgressSignal is not null) return;
            Disconnect(GDExtensionSignalName.RequestPlayersForGameProgress, _requestPlayersForGameProgressSignalCallable);
            _requestPlayersForGameProgressSignalCallable = default;
        }
    }

    public new delegate void RequestPlayersForGameResultSignalHandler(long result, long searchId, Godot.Collections.Dictionary playerData);
    private RequestPlayersForGameResultSignalHandler _requestPlayersForGameResultSignal;
    private Callable _requestPlayersForGameResultSignalCallable;
    public event RequestPlayersForGameResultSignalHandler RequestPlayersForGameResultSignal
    {
        add
        {
            if (_requestPlayersForGameResultSignal is null)
            {
                _requestPlayersForGameResultSignalCallable = Callable.From((Variant result, Variant searchId, Variant playerData) => 
                    _requestPlayersForGameResultSignal?.Invoke(result.As<long>(), searchId.As<long>(), playerData.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.RequestPlayersForGameResult, _requestPlayersForGameResultSignalCallable);
            }
            _requestPlayersForGameResultSignal += value;
        }
        remove
        {
            _requestPlayersForGameResultSignal -= value;
            if (_requestPlayersForGameResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.RequestPlayersForGameResult, _requestPlayersForGameResultSignalCallable);
            _requestPlayersForGameResultSignalCallable = default;
        }
    }

    public new delegate void RequestPlayersForGameFinalResultSignalHandler(long result, long searchId, long gameId);
    private RequestPlayersForGameFinalResultSignalHandler _requestPlayersForGameFinalResultSignal;
    private Callable _requestPlayersForGameFinalResultSignalCallable;
    public event RequestPlayersForGameFinalResultSignalHandler RequestPlayersForGameFinalResultSignal
    {
        add
        {
            if (_requestPlayersForGameFinalResultSignal is null)
            {
                _requestPlayersForGameFinalResultSignalCallable = Callable.From((Variant result, Variant searchId, Variant gameId) => 
                    _requestPlayersForGameFinalResultSignal?.Invoke(result.As<long>(), searchId.As<long>(), gameId.As<long>()));
                Connect(GDExtensionSignalName.RequestPlayersForGameFinalResult, _requestPlayersForGameFinalResultSignalCallable);
            }
            _requestPlayersForGameFinalResultSignal += value;
        }
        remove
        {
            _requestPlayersForGameFinalResultSignal -= value;
            if (_requestPlayersForGameFinalResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.RequestPlayersForGameFinalResult, _requestPlayersForGameFinalResultSignalCallable);
            _requestPlayersForGameFinalResultSignalCallable = default;
        }
    }

    public new delegate void SubmitPlayerResultSignalHandler(long result, long gameId, long playerId);
    private SubmitPlayerResultSignalHandler _submitPlayerResultSignal;
    private Callable _submitPlayerResultSignalCallable;
    public event SubmitPlayerResultSignalHandler SubmitPlayerResultSignal
    {
        add
        {
            if (_submitPlayerResultSignal is null)
            {
                _submitPlayerResultSignalCallable = Callable.From((Variant result, Variant gameId, Variant playerId) => 
                    _submitPlayerResultSignal?.Invoke(result.As<long>(), gameId.As<long>(), playerId.As<long>()));
                Connect(GDExtensionSignalName.SubmitPlayerResult, _submitPlayerResultSignalCallable);
            }
            _submitPlayerResultSignal += value;
        }
        remove
        {
            _submitPlayerResultSignal -= value;
            if (_submitPlayerResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.SubmitPlayerResult, _submitPlayerResultSignalCallable);
            _submitPlayerResultSignalCallable = default;
        }
    }

    public new delegate void EndGameResultSignalHandler(long result, long gameId);
    private EndGameResultSignalHandler _endGameResultSignal;
    private Callable _endGameResultSignalCallable;
    public event EndGameResultSignalHandler EndGameResultSignal
    {
        add
        {
            if (_endGameResultSignal is null)
            {
                _endGameResultSignalCallable = Callable.From((Variant result, Variant gameId) => 
                    _endGameResultSignal?.Invoke(result.As<long>(), gameId.As<long>()));
                Connect(GDExtensionSignalName.EndGameResult, _endGameResultSignalCallable);
            }
            _endGameResultSignal += value;
        }
        remove
        {
            _endGameResultSignal -= value;
            if (_endGameResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.EndGameResult, _endGameResultSignalCallable);
            _endGameResultSignalCallable = default;
        }
    }

    public new delegate void HtmlBrowserReadySignalHandler(long browserHandle);
    private HtmlBrowserReadySignalHandler _htmlBrowserReadySignal;
    private Callable _htmlBrowserReadySignalCallable;
    public event HtmlBrowserReadySignalHandler HtmlBrowserReadySignal
    {
        add
        {
            if (_htmlBrowserReadySignal is null)
            {
                _htmlBrowserReadySignalCallable = Callable.From((Variant browserHandle) => 
                    _htmlBrowserReadySignal?.Invoke(browserHandle.As<long>()));
                Connect(GDExtensionSignalName.HtmlBrowserReady, _htmlBrowserReadySignalCallable);
            }
            _htmlBrowserReadySignal += value;
        }
        remove
        {
            _htmlBrowserReadySignal -= value;
            if (_htmlBrowserReadySignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlBrowserReady, _htmlBrowserReadySignalCallable);
            _htmlBrowserReadySignalCallable = default;
        }
    }

    public new delegate void HtmlCanGoBackandforwardSignalHandler(long browserHandle, bool goBack, bool goForward);
    private HtmlCanGoBackandforwardSignalHandler _htmlCanGoBackandforwardSignal;
    private Callable _htmlCanGoBackandforwardSignalCallable;
    public event HtmlCanGoBackandforwardSignalHandler HtmlCanGoBackandforwardSignal
    {
        add
        {
            if (_htmlCanGoBackandforwardSignal is null)
            {
                _htmlCanGoBackandforwardSignalCallable = Callable.From((Variant browserHandle, Variant goBack, Variant goForward) => 
                    _htmlCanGoBackandforwardSignal?.Invoke(browserHandle.As<long>(), goBack.As<bool>(), goForward.As<bool>()));
                Connect(GDExtensionSignalName.HtmlCanGoBackandforward, _htmlCanGoBackandforwardSignalCallable);
            }
            _htmlCanGoBackandforwardSignal += value;
        }
        remove
        {
            _htmlCanGoBackandforwardSignal -= value;
            if (_htmlCanGoBackandforwardSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlCanGoBackandforward, _htmlCanGoBackandforwardSignalCallable);
            _htmlCanGoBackandforwardSignalCallable = default;
        }
    }

    public new delegate void HtmlChangedTitleSignalHandler(long browserHandle, string title);
    private HtmlChangedTitleSignalHandler _htmlChangedTitleSignal;
    private Callable _htmlChangedTitleSignalCallable;
    public event HtmlChangedTitleSignalHandler HtmlChangedTitleSignal
    {
        add
        {
            if (_htmlChangedTitleSignal is null)
            {
                _htmlChangedTitleSignalCallable = Callable.From((Variant browserHandle, Variant title) => 
                    _htmlChangedTitleSignal?.Invoke(browserHandle.As<long>(), title.As<string>()));
                Connect(GDExtensionSignalName.HtmlChangedTitle, _htmlChangedTitleSignalCallable);
            }
            _htmlChangedTitleSignal += value;
        }
        remove
        {
            _htmlChangedTitleSignal -= value;
            if (_htmlChangedTitleSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlChangedTitle, _htmlChangedTitleSignalCallable);
            _htmlChangedTitleSignalCallable = default;
        }
    }

    public new delegate void HtmlCloseBrowserSignalHandler(long browserHandle);
    private HtmlCloseBrowserSignalHandler _htmlCloseBrowserSignal;
    private Callable _htmlCloseBrowserSignalCallable;
    public event HtmlCloseBrowserSignalHandler HtmlCloseBrowserSignal
    {
        add
        {
            if (_htmlCloseBrowserSignal is null)
            {
                _htmlCloseBrowserSignalCallable = Callable.From((Variant browserHandle) => 
                    _htmlCloseBrowserSignal?.Invoke(browserHandle.As<long>()));
                Connect(GDExtensionSignalName.HtmlCloseBrowser, _htmlCloseBrowserSignalCallable);
            }
            _htmlCloseBrowserSignal += value;
        }
        remove
        {
            _htmlCloseBrowserSignal -= value;
            if (_htmlCloseBrowserSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlCloseBrowser, _htmlCloseBrowserSignalCallable);
            _htmlCloseBrowserSignalCallable = default;
        }
    }

    public new delegate void HtmlFileOpenDialogSignalHandler(long browserHandle, string title, string initialFile);
    private HtmlFileOpenDialogSignalHandler _htmlFileOpenDialogSignal;
    private Callable _htmlFileOpenDialogSignalCallable;
    public event HtmlFileOpenDialogSignalHandler HtmlFileOpenDialogSignal
    {
        add
        {
            if (_htmlFileOpenDialogSignal is null)
            {
                _htmlFileOpenDialogSignalCallable = Callable.From((Variant browserHandle, Variant title, Variant initialFile) => 
                    _htmlFileOpenDialogSignal?.Invoke(browserHandle.As<long>(), title.As<string>(), initialFile.As<string>()));
                Connect(GDExtensionSignalName.HtmlFileOpenDialog, _htmlFileOpenDialogSignalCallable);
            }
            _htmlFileOpenDialogSignal += value;
        }
        remove
        {
            _htmlFileOpenDialogSignal -= value;
            if (_htmlFileOpenDialogSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlFileOpenDialog, _htmlFileOpenDialogSignalCallable);
            _htmlFileOpenDialogSignalCallable = default;
        }
    }

    public new delegate void HtmlFinishedRequestSignalHandler(long browserHandle, string url, string title);
    private HtmlFinishedRequestSignalHandler _htmlFinishedRequestSignal;
    private Callable _htmlFinishedRequestSignalCallable;
    public event HtmlFinishedRequestSignalHandler HtmlFinishedRequestSignal
    {
        add
        {
            if (_htmlFinishedRequestSignal is null)
            {
                _htmlFinishedRequestSignalCallable = Callable.From((Variant browserHandle, Variant url, Variant title) => 
                    _htmlFinishedRequestSignal?.Invoke(browserHandle.As<long>(), url.As<string>(), title.As<string>()));
                Connect(GDExtensionSignalName.HtmlFinishedRequest, _htmlFinishedRequestSignalCallable);
            }
            _htmlFinishedRequestSignal += value;
        }
        remove
        {
            _htmlFinishedRequestSignal -= value;
            if (_htmlFinishedRequestSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlFinishedRequest, _htmlFinishedRequestSignalCallable);
            _htmlFinishedRequestSignalCallable = default;
        }
    }

    public new delegate void HtmlHideTooltipSignalHandler(long browserHandle);
    private HtmlHideTooltipSignalHandler _htmlHideTooltipSignal;
    private Callable _htmlHideTooltipSignalCallable;
    public event HtmlHideTooltipSignalHandler HtmlHideTooltipSignal
    {
        add
        {
            if (_htmlHideTooltipSignal is null)
            {
                _htmlHideTooltipSignalCallable = Callable.From((Variant browserHandle) => 
                    _htmlHideTooltipSignal?.Invoke(browserHandle.As<long>()));
                Connect(GDExtensionSignalName.HtmlHideTooltip, _htmlHideTooltipSignalCallable);
            }
            _htmlHideTooltipSignal += value;
        }
        remove
        {
            _htmlHideTooltipSignal -= value;
            if (_htmlHideTooltipSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlHideTooltip, _htmlHideTooltipSignalCallable);
            _htmlHideTooltipSignalCallable = default;
        }
    }

    public new delegate void HtmlHorizontalScrollSignalHandler(long browserHandle, Godot.Collections.Dictionary scrollData);
    private HtmlHorizontalScrollSignalHandler _htmlHorizontalScrollSignal;
    private Callable _htmlHorizontalScrollSignalCallable;
    public event HtmlHorizontalScrollSignalHandler HtmlHorizontalScrollSignal
    {
        add
        {
            if (_htmlHorizontalScrollSignal is null)
            {
                _htmlHorizontalScrollSignalCallable = Callable.From((Variant browserHandle, Variant scrollData) => 
                    _htmlHorizontalScrollSignal?.Invoke(browserHandle.As<long>(), scrollData.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.HtmlHorizontalScroll, _htmlHorizontalScrollSignalCallable);
            }
            _htmlHorizontalScrollSignal += value;
        }
        remove
        {
            _htmlHorizontalScrollSignal -= value;
            if (_htmlHorizontalScrollSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlHorizontalScroll, _htmlHorizontalScrollSignalCallable);
            _htmlHorizontalScrollSignalCallable = default;
        }
    }

    public new delegate void HtmlJsAlertSignalHandler(long browserHandle, string message);
    private HtmlJsAlertSignalHandler _htmlJsAlertSignal;
    private Callable _htmlJsAlertSignalCallable;
    public event HtmlJsAlertSignalHandler HtmlJsAlertSignal
    {
        add
        {
            if (_htmlJsAlertSignal is null)
            {
                _htmlJsAlertSignalCallable = Callable.From((Variant browserHandle, Variant message) => 
                    _htmlJsAlertSignal?.Invoke(browserHandle.As<long>(), message.As<string>()));
                Connect(GDExtensionSignalName.HtmlJsAlert, _htmlJsAlertSignalCallable);
            }
            _htmlJsAlertSignal += value;
        }
        remove
        {
            _htmlJsAlertSignal -= value;
            if (_htmlJsAlertSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlJsAlert, _htmlJsAlertSignalCallable);
            _htmlJsAlertSignalCallable = default;
        }
    }

    public new delegate void HtmlJsConfirmSignalHandler(long browserHandle, string message);
    private HtmlJsConfirmSignalHandler _htmlJsConfirmSignal;
    private Callable _htmlJsConfirmSignalCallable;
    public event HtmlJsConfirmSignalHandler HtmlJsConfirmSignal
    {
        add
        {
            if (_htmlJsConfirmSignal is null)
            {
                _htmlJsConfirmSignalCallable = Callable.From((Variant browserHandle, Variant message) => 
                    _htmlJsConfirmSignal?.Invoke(browserHandle.As<long>(), message.As<string>()));
                Connect(GDExtensionSignalName.HtmlJsConfirm, _htmlJsConfirmSignalCallable);
            }
            _htmlJsConfirmSignal += value;
        }
        remove
        {
            _htmlJsConfirmSignal -= value;
            if (_htmlJsConfirmSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlJsConfirm, _htmlJsConfirmSignalCallable);
            _htmlJsConfirmSignalCallable = default;
        }
    }

    public new delegate void HtmlLinkAtPositionSignalHandler(long browserHandle, Godot.Collections.Dictionary linkData);
    private HtmlLinkAtPositionSignalHandler _htmlLinkAtPositionSignal;
    private Callable _htmlLinkAtPositionSignalCallable;
    public event HtmlLinkAtPositionSignalHandler HtmlLinkAtPositionSignal
    {
        add
        {
            if (_htmlLinkAtPositionSignal is null)
            {
                _htmlLinkAtPositionSignalCallable = Callable.From((Variant browserHandle, Variant linkData) => 
                    _htmlLinkAtPositionSignal?.Invoke(browserHandle.As<long>(), linkData.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.HtmlLinkAtPosition, _htmlLinkAtPositionSignalCallable);
            }
            _htmlLinkAtPositionSignal += value;
        }
        remove
        {
            _htmlLinkAtPositionSignal -= value;
            if (_htmlLinkAtPositionSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlLinkAtPosition, _htmlLinkAtPositionSignalCallable);
            _htmlLinkAtPositionSignalCallable = default;
        }
    }

    public new delegate void HtmlNeedsPaintSignalHandler(long browserHandle, Godot.Collections.Dictionary pageData);
    private HtmlNeedsPaintSignalHandler _htmlNeedsPaintSignal;
    private Callable _htmlNeedsPaintSignalCallable;
    public event HtmlNeedsPaintSignalHandler HtmlNeedsPaintSignal
    {
        add
        {
            if (_htmlNeedsPaintSignal is null)
            {
                _htmlNeedsPaintSignalCallable = Callable.From((Variant browserHandle, Variant pageData) => 
                    _htmlNeedsPaintSignal?.Invoke(browserHandle.As<long>(), pageData.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.HtmlNeedsPaint, _htmlNeedsPaintSignalCallable);
            }
            _htmlNeedsPaintSignal += value;
        }
        remove
        {
            _htmlNeedsPaintSignal -= value;
            if (_htmlNeedsPaintSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlNeedsPaint, _htmlNeedsPaintSignalCallable);
            _htmlNeedsPaintSignalCallable = default;
        }
    }

    public new delegate void HtmlNewWindowSignalHandler(long browserHandle, Godot.Collections.Dictionary windowData);
    private HtmlNewWindowSignalHandler _htmlNewWindowSignal;
    private Callable _htmlNewWindowSignalCallable;
    public event HtmlNewWindowSignalHandler HtmlNewWindowSignal
    {
        add
        {
            if (_htmlNewWindowSignal is null)
            {
                _htmlNewWindowSignalCallable = Callable.From((Variant browserHandle, Variant windowData) => 
                    _htmlNewWindowSignal?.Invoke(browserHandle.As<long>(), windowData.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.HtmlNewWindow, _htmlNewWindowSignalCallable);
            }
            _htmlNewWindowSignal += value;
        }
        remove
        {
            _htmlNewWindowSignal -= value;
            if (_htmlNewWindowSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlNewWindow, _htmlNewWindowSignalCallable);
            _htmlNewWindowSignalCallable = default;
        }
    }

    public new delegate void HtmlOpenLinkInNewTabSignalHandler(long browserHandle, string url);
    private HtmlOpenLinkInNewTabSignalHandler _htmlOpenLinkInNewTabSignal;
    private Callable _htmlOpenLinkInNewTabSignalCallable;
    public event HtmlOpenLinkInNewTabSignalHandler HtmlOpenLinkInNewTabSignal
    {
        add
        {
            if (_htmlOpenLinkInNewTabSignal is null)
            {
                _htmlOpenLinkInNewTabSignalCallable = Callable.From((Variant browserHandle, Variant url) => 
                    _htmlOpenLinkInNewTabSignal?.Invoke(browserHandle.As<long>(), url.As<string>()));
                Connect(GDExtensionSignalName.HtmlOpenLinkInNewTab, _htmlOpenLinkInNewTabSignalCallable);
            }
            _htmlOpenLinkInNewTabSignal += value;
        }
        remove
        {
            _htmlOpenLinkInNewTabSignal -= value;
            if (_htmlOpenLinkInNewTabSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlOpenLinkInNewTab, _htmlOpenLinkInNewTabSignalCallable);
            _htmlOpenLinkInNewTabSignalCallable = default;
        }
    }

    public new delegate void HtmlSearchResultsSignalHandler(long browserHandle, long results, long currentMatch);
    private HtmlSearchResultsSignalHandler _htmlSearchResultsSignal;
    private Callable _htmlSearchResultsSignalCallable;
    public event HtmlSearchResultsSignalHandler HtmlSearchResultsSignal
    {
        add
        {
            if (_htmlSearchResultsSignal is null)
            {
                _htmlSearchResultsSignalCallable = Callable.From((Variant browserHandle, Variant results, Variant currentMatch) => 
                    _htmlSearchResultsSignal?.Invoke(browserHandle.As<long>(), results.As<long>(), currentMatch.As<long>()));
                Connect(GDExtensionSignalName.HtmlSearchResults, _htmlSearchResultsSignalCallable);
            }
            _htmlSearchResultsSignal += value;
        }
        remove
        {
            _htmlSearchResultsSignal -= value;
            if (_htmlSearchResultsSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlSearchResults, _htmlSearchResultsSignalCallable);
            _htmlSearchResultsSignalCallable = default;
        }
    }

    public new delegate void HtmlSetCursorSignalHandler(long browserHandle, long mouseCursor);
    private HtmlSetCursorSignalHandler _htmlSetCursorSignal;
    private Callable _htmlSetCursorSignalCallable;
    public event HtmlSetCursorSignalHandler HtmlSetCursorSignal
    {
        add
        {
            if (_htmlSetCursorSignal is null)
            {
                _htmlSetCursorSignalCallable = Callable.From((Variant browserHandle, Variant mouseCursor) => 
                    _htmlSetCursorSignal?.Invoke(browserHandle.As<long>(), mouseCursor.As<long>()));
                Connect(GDExtensionSignalName.HtmlSetCursor, _htmlSetCursorSignalCallable);
            }
            _htmlSetCursorSignal += value;
        }
        remove
        {
            _htmlSetCursorSignal -= value;
            if (_htmlSetCursorSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlSetCursor, _htmlSetCursorSignalCallable);
            _htmlSetCursorSignalCallable = default;
        }
    }

    public new delegate void HtmlShowTooltipSignalHandler(long browserHandle, string message);
    private HtmlShowTooltipSignalHandler _htmlShowTooltipSignal;
    private Callable _htmlShowTooltipSignalCallable;
    public event HtmlShowTooltipSignalHandler HtmlShowTooltipSignal
    {
        add
        {
            if (_htmlShowTooltipSignal is null)
            {
                _htmlShowTooltipSignalCallable = Callable.From((Variant browserHandle, Variant message) => 
                    _htmlShowTooltipSignal?.Invoke(browserHandle.As<long>(), message.As<string>()));
                Connect(GDExtensionSignalName.HtmlShowTooltip, _htmlShowTooltipSignalCallable);
            }
            _htmlShowTooltipSignal += value;
        }
        remove
        {
            _htmlShowTooltipSignal -= value;
            if (_htmlShowTooltipSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlShowTooltip, _htmlShowTooltipSignalCallable);
            _htmlShowTooltipSignalCallable = default;
        }
    }

    public new delegate void HtmlStartRequestSignalHandler(long browserHandle, string url, string target, string postData, bool redirect);
    private HtmlStartRequestSignalHandler _htmlStartRequestSignal;
    private Callable _htmlStartRequestSignalCallable;
    public event HtmlStartRequestSignalHandler HtmlStartRequestSignal
    {
        add
        {
            if (_htmlStartRequestSignal is null)
            {
                _htmlStartRequestSignalCallable = Callable.From((Variant browserHandle, Variant url, Variant target, Variant postData, Variant redirect) => 
                    _htmlStartRequestSignal?.Invoke(browserHandle.As<long>(), url.As<string>(), target.As<string>(), postData.As<string>(), redirect.As<bool>()));
                Connect(GDExtensionSignalName.HtmlStartRequest, _htmlStartRequestSignalCallable);
            }
            _htmlStartRequestSignal += value;
        }
        remove
        {
            _htmlStartRequestSignal -= value;
            if (_htmlStartRequestSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlStartRequest, _htmlStartRequestSignalCallable);
            _htmlStartRequestSignalCallable = default;
        }
    }

    public new delegate void HtmlStatusTextSignalHandler(long browserHandle, string message);
    private HtmlStatusTextSignalHandler _htmlStatusTextSignal;
    private Callable _htmlStatusTextSignalCallable;
    public event HtmlStatusTextSignalHandler HtmlStatusTextSignal
    {
        add
        {
            if (_htmlStatusTextSignal is null)
            {
                _htmlStatusTextSignalCallable = Callable.From((Variant browserHandle, Variant message) => 
                    _htmlStatusTextSignal?.Invoke(browserHandle.As<long>(), message.As<string>()));
                Connect(GDExtensionSignalName.HtmlStatusText, _htmlStatusTextSignalCallable);
            }
            _htmlStatusTextSignal += value;
        }
        remove
        {
            _htmlStatusTextSignal -= value;
            if (_htmlStatusTextSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlStatusText, _htmlStatusTextSignalCallable);
            _htmlStatusTextSignalCallable = default;
        }
    }

    public new delegate void HtmlUpdateTooltipSignalHandler(long browserHandle, string message);
    private HtmlUpdateTooltipSignalHandler _htmlUpdateTooltipSignal;
    private Callable _htmlUpdateTooltipSignalCallable;
    public event HtmlUpdateTooltipSignalHandler HtmlUpdateTooltipSignal
    {
        add
        {
            if (_htmlUpdateTooltipSignal is null)
            {
                _htmlUpdateTooltipSignalCallable = Callable.From((Variant browserHandle, Variant message) => 
                    _htmlUpdateTooltipSignal?.Invoke(browserHandle.As<long>(), message.As<string>()));
                Connect(GDExtensionSignalName.HtmlUpdateTooltip, _htmlUpdateTooltipSignalCallable);
            }
            _htmlUpdateTooltipSignal += value;
        }
        remove
        {
            _htmlUpdateTooltipSignal -= value;
            if (_htmlUpdateTooltipSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlUpdateTooltip, _htmlUpdateTooltipSignalCallable);
            _htmlUpdateTooltipSignalCallable = default;
        }
    }

    public new delegate void HtmlUrlChangedSignalHandler(long browserHandle, Godot.Collections.Dictionary urlData);
    private HtmlUrlChangedSignalHandler _htmlUrlChangedSignal;
    private Callable _htmlUrlChangedSignalCallable;
    public event HtmlUrlChangedSignalHandler HtmlUrlChangedSignal
    {
        add
        {
            if (_htmlUrlChangedSignal is null)
            {
                _htmlUrlChangedSignalCallable = Callable.From((Variant browserHandle, Variant urlData) => 
                    _htmlUrlChangedSignal?.Invoke(browserHandle.As<long>(), urlData.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.HtmlUrlChanged, _htmlUrlChangedSignalCallable);
            }
            _htmlUrlChangedSignal += value;
        }
        remove
        {
            _htmlUrlChangedSignal -= value;
            if (_htmlUrlChangedSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlUrlChanged, _htmlUrlChangedSignalCallable);
            _htmlUrlChangedSignalCallable = default;
        }
    }

    public new delegate void HtmlVerticalScrollSignalHandler(long browserHandle, Godot.Collections.Dictionary scrollData);
    private HtmlVerticalScrollSignalHandler _htmlVerticalScrollSignal;
    private Callable _htmlVerticalScrollSignalCallable;
    public event HtmlVerticalScrollSignalHandler HtmlVerticalScrollSignal
    {
        add
        {
            if (_htmlVerticalScrollSignal is null)
            {
                _htmlVerticalScrollSignalCallable = Callable.From((Variant browserHandle, Variant scrollData) => 
                    _htmlVerticalScrollSignal?.Invoke(browserHandle.As<long>(), scrollData.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.HtmlVerticalScroll, _htmlVerticalScrollSignalCallable);
            }
            _htmlVerticalScrollSignal += value;
        }
        remove
        {
            _htmlVerticalScrollSignal -= value;
            if (_htmlVerticalScrollSignal is not null) return;
            Disconnect(GDExtensionSignalName.HtmlVerticalScroll, _htmlVerticalScrollSignalCallable);
            _htmlVerticalScrollSignalCallable = default;
        }
    }

    public new delegate void HttpRequestCompletedSignalHandler(long requestHandle, long contextValue, bool requestSuccess, long statusCode, long bodySize);
    private HttpRequestCompletedSignalHandler _httpRequestCompletedSignal;
    private Callable _httpRequestCompletedSignalCallable;
    public event HttpRequestCompletedSignalHandler HttpRequestCompletedSignal
    {
        add
        {
            if (_httpRequestCompletedSignal is null)
            {
                _httpRequestCompletedSignalCallable = Callable.From((Variant requestHandle, Variant contextValue, Variant requestSuccess, Variant statusCode, Variant bodySize) => 
                    _httpRequestCompletedSignal?.Invoke(requestHandle.As<long>(), contextValue.As<long>(), requestSuccess.As<bool>(), statusCode.As<long>(), bodySize.As<long>()));
                Connect(GDExtensionSignalName.HttpRequestCompleted, _httpRequestCompletedSignalCallable);
            }
            _httpRequestCompletedSignal += value;
        }
        remove
        {
            _httpRequestCompletedSignal -= value;
            if (_httpRequestCompletedSignal is not null) return;
            Disconnect(GDExtensionSignalName.HttpRequestCompleted, _httpRequestCompletedSignalCallable);
            _httpRequestCompletedSignalCallable = default;
        }
    }

    public new delegate void HttpRequestDataReceivedSignalHandler(long requestHandle, long contextValue, long offset, long bytesReceived);
    private HttpRequestDataReceivedSignalHandler _httpRequestDataReceivedSignal;
    private Callable _httpRequestDataReceivedSignalCallable;
    public event HttpRequestDataReceivedSignalHandler HttpRequestDataReceivedSignal
    {
        add
        {
            if (_httpRequestDataReceivedSignal is null)
            {
                _httpRequestDataReceivedSignalCallable = Callable.From((Variant requestHandle, Variant contextValue, Variant offset, Variant bytesReceived) => 
                    _httpRequestDataReceivedSignal?.Invoke(requestHandle.As<long>(), contextValue.As<long>(), offset.As<long>(), bytesReceived.As<long>()));
                Connect(GDExtensionSignalName.HttpRequestDataReceived, _httpRequestDataReceivedSignalCallable);
            }
            _httpRequestDataReceivedSignal += value;
        }
        remove
        {
            _httpRequestDataReceivedSignal -= value;
            if (_httpRequestDataReceivedSignal is not null) return;
            Disconnect(GDExtensionSignalName.HttpRequestDataReceived, _httpRequestDataReceivedSignalCallable);
            _httpRequestDataReceivedSignalCallable = default;
        }
    }

    public new delegate void HttpRequestHeadersReceivedSignalHandler(long requestHandle, long contextValue);
    private HttpRequestHeadersReceivedSignalHandler _httpRequestHeadersReceivedSignal;
    private Callable _httpRequestHeadersReceivedSignalCallable;
    public event HttpRequestHeadersReceivedSignalHandler HttpRequestHeadersReceivedSignal
    {
        add
        {
            if (_httpRequestHeadersReceivedSignal is null)
            {
                _httpRequestHeadersReceivedSignalCallable = Callable.From((Variant requestHandle, Variant contextValue) => 
                    _httpRequestHeadersReceivedSignal?.Invoke(requestHandle.As<long>(), contextValue.As<long>()));
                Connect(GDExtensionSignalName.HttpRequestHeadersReceived, _httpRequestHeadersReceivedSignalCallable);
            }
            _httpRequestHeadersReceivedSignal += value;
        }
        remove
        {
            _httpRequestHeadersReceivedSignal -= value;
            if (_httpRequestHeadersReceivedSignal is not null) return;
            Disconnect(GDExtensionSignalName.HttpRequestHeadersReceived, _httpRequestHeadersReceivedSignalCallable);
            _httpRequestHeadersReceivedSignalCallable = default;
        }
    }

    public new delegate void InputActionEventSignalHandler(long inputHandle, long eventType, long actionHandle, bool isActive, Godot.Collections.Dictionary actionData);
    private InputActionEventSignalHandler _inputActionEventSignal;
    private Callable _inputActionEventSignalCallable;
    public event InputActionEventSignalHandler InputActionEventSignal
    {
        add
        {
            if (_inputActionEventSignal is null)
            {
                _inputActionEventSignalCallable = Callable.From((Variant inputHandle, Variant eventType, Variant actionHandle, Variant isActive, Variant actionData) => 
                    _inputActionEventSignal?.Invoke(inputHandle.As<long>(), eventType.As<long>(), actionHandle.As<long>(), isActive.As<bool>(), actionData.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.InputActionEvent, _inputActionEventSignalCallable);
            }
            _inputActionEventSignal += value;
        }
        remove
        {
            _inputActionEventSignal -= value;
            if (_inputActionEventSignal is not null) return;
            Disconnect(GDExtensionSignalName.InputActionEvent, _inputActionEventSignalCallable);
            _inputActionEventSignalCallable = default;
        }
    }

    public new delegate void InputDeviceConnectedSignalHandler(long inputHandle);
    private InputDeviceConnectedSignalHandler _inputDeviceConnectedSignal;
    private Callable _inputDeviceConnectedSignalCallable;
    public event InputDeviceConnectedSignalHandler InputDeviceConnectedSignal
    {
        add
        {
            if (_inputDeviceConnectedSignal is null)
            {
                _inputDeviceConnectedSignalCallable = Callable.From((Variant inputHandle) => 
                    _inputDeviceConnectedSignal?.Invoke(inputHandle.As<long>()));
                Connect(GDExtensionSignalName.InputDeviceConnected, _inputDeviceConnectedSignalCallable);
            }
            _inputDeviceConnectedSignal += value;
        }
        remove
        {
            _inputDeviceConnectedSignal -= value;
            if (_inputDeviceConnectedSignal is not null) return;
            Disconnect(GDExtensionSignalName.InputDeviceConnected, _inputDeviceConnectedSignalCallable);
            _inputDeviceConnectedSignalCallable = default;
        }
    }

    public new delegate void InputDeviceDisconnectedSignalHandler(long inputHandle);
    private InputDeviceDisconnectedSignalHandler _inputDeviceDisconnectedSignal;
    private Callable _inputDeviceDisconnectedSignalCallable;
    public event InputDeviceDisconnectedSignalHandler InputDeviceDisconnectedSignal
    {
        add
        {
            if (_inputDeviceDisconnectedSignal is null)
            {
                _inputDeviceDisconnectedSignalCallable = Callable.From((Variant inputHandle) => 
                    _inputDeviceDisconnectedSignal?.Invoke(inputHandle.As<long>()));
                Connect(GDExtensionSignalName.InputDeviceDisconnected, _inputDeviceDisconnectedSignalCallable);
            }
            _inputDeviceDisconnectedSignal += value;
        }
        remove
        {
            _inputDeviceDisconnectedSignal -= value;
            if (_inputDeviceDisconnectedSignal is not null) return;
            Disconnect(GDExtensionSignalName.InputDeviceDisconnected, _inputDeviceDisconnectedSignalCallable);
            _inputDeviceDisconnectedSignalCallable = default;
        }
    }

    public new delegate void InputConfigurationLoadedSignalHandler(long appId, long deviceHandle, Godot.Collections.Dictionary configData);
    private InputConfigurationLoadedSignalHandler _inputConfigurationLoadedSignal;
    private Callable _inputConfigurationLoadedSignalCallable;
    public event InputConfigurationLoadedSignalHandler InputConfigurationLoadedSignal
    {
        add
        {
            if (_inputConfigurationLoadedSignal is null)
            {
                _inputConfigurationLoadedSignalCallable = Callable.From((Variant appId, Variant deviceHandle, Variant configData) => 
                    _inputConfigurationLoadedSignal?.Invoke(appId.As<long>(), deviceHandle.As<long>(), configData.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.InputConfigurationLoaded, _inputConfigurationLoadedSignalCallable);
            }
            _inputConfigurationLoadedSignal += value;
        }
        remove
        {
            _inputConfigurationLoadedSignal -= value;
            if (_inputConfigurationLoadedSignal is not null) return;
            Disconnect(GDExtensionSignalName.InputConfigurationLoaded, _inputConfigurationLoadedSignalCallable);
            _inputConfigurationLoadedSignalCallable = default;
        }
    }

    public new delegate void InputGamepadSlotChangeSignalHandler(long appId, long deviceHandle, long deviceType, long oldGamepadSlot, long newGamepadSlot);
    private InputGamepadSlotChangeSignalHandler _inputGamepadSlotChangeSignal;
    private Callable _inputGamepadSlotChangeSignalCallable;
    public event InputGamepadSlotChangeSignalHandler InputGamepadSlotChangeSignal
    {
        add
        {
            if (_inputGamepadSlotChangeSignal is null)
            {
                _inputGamepadSlotChangeSignalCallable = Callable.From((Variant appId, Variant deviceHandle, Variant deviceType, Variant oldGamepadSlot, Variant newGamepadSlot) => 
                    _inputGamepadSlotChangeSignal?.Invoke(appId.As<long>(), deviceHandle.As<long>(), deviceType.As<long>(), oldGamepadSlot.As<long>(), newGamepadSlot.As<long>()));
                Connect(GDExtensionSignalName.InputGamepadSlotChange, _inputGamepadSlotChangeSignalCallable);
            }
            _inputGamepadSlotChangeSignal += value;
        }
        remove
        {
            _inputGamepadSlotChangeSignal -= value;
            if (_inputGamepadSlotChangeSignal is not null) return;
            Disconnect(GDExtensionSignalName.InputGamepadSlotChange, _inputGamepadSlotChangeSignalCallable);
            _inputGamepadSlotChangeSignalCallable = default;
        }
    }

    public new delegate void InventoryDefinitionUpdateSignalHandler(Godot.Collections.Array definitions);
    private InventoryDefinitionUpdateSignalHandler _inventoryDefinitionUpdateSignal;
    private Callable _inventoryDefinitionUpdateSignalCallable;
    public event InventoryDefinitionUpdateSignalHandler InventoryDefinitionUpdateSignal
    {
        add
        {
            if (_inventoryDefinitionUpdateSignal is null)
            {
                _inventoryDefinitionUpdateSignalCallable = Callable.From((Variant definitions) => 
                    _inventoryDefinitionUpdateSignal?.Invoke(definitions.As<Godot.Collections.Array>()));
                Connect(GDExtensionSignalName.InventoryDefinitionUpdate, _inventoryDefinitionUpdateSignalCallable);
            }
            _inventoryDefinitionUpdateSignal += value;
        }
        remove
        {
            _inventoryDefinitionUpdateSignal -= value;
            if (_inventoryDefinitionUpdateSignal is not null) return;
            Disconnect(GDExtensionSignalName.InventoryDefinitionUpdate, _inventoryDefinitionUpdateSignalCallable);
            _inventoryDefinitionUpdateSignalCallable = default;
        }
    }

    public new delegate void InventoryEligiblePromoItemSignalHandler(long result, bool cached, Godot.Collections.Array definitions);
    private InventoryEligiblePromoItemSignalHandler _inventoryEligiblePromoItemSignal;
    private Callable _inventoryEligiblePromoItemSignalCallable;
    public event InventoryEligiblePromoItemSignalHandler InventoryEligiblePromoItemSignal
    {
        add
        {
            if (_inventoryEligiblePromoItemSignal is null)
            {
                _inventoryEligiblePromoItemSignalCallable = Callable.From((Variant result, Variant cached, Variant definitions) => 
                    _inventoryEligiblePromoItemSignal?.Invoke(result.As<long>(), cached.As<bool>(), definitions.As<Godot.Collections.Array>()));
                Connect(GDExtensionSignalName.InventoryEligiblePromoItem, _inventoryEligiblePromoItemSignalCallable);
            }
            _inventoryEligiblePromoItemSignal += value;
        }
        remove
        {
            _inventoryEligiblePromoItemSignal -= value;
            if (_inventoryEligiblePromoItemSignal is not null) return;
            Disconnect(GDExtensionSignalName.InventoryEligiblePromoItem, _inventoryEligiblePromoItemSignalCallable);
            _inventoryEligiblePromoItemSignalCallable = default;
        }
    }

    public new delegate void InventoryFullUpdateSignalHandler(long inventoryHandle);
    private InventoryFullUpdateSignalHandler _inventoryFullUpdateSignal;
    private Callable _inventoryFullUpdateSignalCallable;
    public event InventoryFullUpdateSignalHandler InventoryFullUpdateSignal
    {
        add
        {
            if (_inventoryFullUpdateSignal is null)
            {
                _inventoryFullUpdateSignalCallable = Callable.From((Variant inventoryHandle) => 
                    _inventoryFullUpdateSignal?.Invoke(inventoryHandle.As<long>()));
                Connect(GDExtensionSignalName.InventoryFullUpdate, _inventoryFullUpdateSignalCallable);
            }
            _inventoryFullUpdateSignal += value;
        }
        remove
        {
            _inventoryFullUpdateSignal -= value;
            if (_inventoryFullUpdateSignal is not null) return;
            Disconnect(GDExtensionSignalName.InventoryFullUpdate, _inventoryFullUpdateSignalCallable);
            _inventoryFullUpdateSignalCallable = default;
        }
    }

    public new delegate void InventoryResultReadySignalHandler(long result, long inventoryHandle);
    private InventoryResultReadySignalHandler _inventoryResultReadySignal;
    private Callable _inventoryResultReadySignalCallable;
    public event InventoryResultReadySignalHandler InventoryResultReadySignal
    {
        add
        {
            if (_inventoryResultReadySignal is null)
            {
                _inventoryResultReadySignalCallable = Callable.From((Variant result, Variant inventoryHandle) => 
                    _inventoryResultReadySignal?.Invoke(result.As<long>(), inventoryHandle.As<long>()));
                Connect(GDExtensionSignalName.InventoryResultReady, _inventoryResultReadySignalCallable);
            }
            _inventoryResultReadySignal += value;
        }
        remove
        {
            _inventoryResultReadySignal -= value;
            if (_inventoryResultReadySignal is not null) return;
            Disconnect(GDExtensionSignalName.InventoryResultReady, _inventoryResultReadySignalCallable);
            _inventoryResultReadySignalCallable = default;
        }
    }

    public new delegate void InventoryStartPurchaseResultSignalHandler(string result, long orderId, long transactionId);
    private InventoryStartPurchaseResultSignalHandler _inventoryStartPurchaseResultSignal;
    private Callable _inventoryStartPurchaseResultSignalCallable;
    public event InventoryStartPurchaseResultSignalHandler InventoryStartPurchaseResultSignal
    {
        add
        {
            if (_inventoryStartPurchaseResultSignal is null)
            {
                _inventoryStartPurchaseResultSignalCallable = Callable.From((Variant result, Variant orderId, Variant transactionId) => 
                    _inventoryStartPurchaseResultSignal?.Invoke(result.As<string>(), orderId.As<long>(), transactionId.As<long>()));
                Connect(GDExtensionSignalName.InventoryStartPurchaseResult, _inventoryStartPurchaseResultSignalCallable);
            }
            _inventoryStartPurchaseResultSignal += value;
        }
        remove
        {
            _inventoryStartPurchaseResultSignal -= value;
            if (_inventoryStartPurchaseResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.InventoryStartPurchaseResult, _inventoryStartPurchaseResultSignalCallable);
            _inventoryStartPurchaseResultSignalCallable = default;
        }
    }

    public new delegate void InventoryRequestPricesResultSignalHandler(long result, string currency);
    private InventoryRequestPricesResultSignalHandler _inventoryRequestPricesResultSignal;
    private Callable _inventoryRequestPricesResultSignalCallable;
    public event InventoryRequestPricesResultSignalHandler InventoryRequestPricesResultSignal
    {
        add
        {
            if (_inventoryRequestPricesResultSignal is null)
            {
                _inventoryRequestPricesResultSignalCallable = Callable.From((Variant result, Variant currency) => 
                    _inventoryRequestPricesResultSignal?.Invoke(result.As<long>(), currency.As<string>()));
                Connect(GDExtensionSignalName.InventoryRequestPricesResult, _inventoryRequestPricesResultSignalCallable);
            }
            _inventoryRequestPricesResultSignal += value;
        }
        remove
        {
            _inventoryRequestPricesResultSignal -= value;
            if (_inventoryRequestPricesResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.InventoryRequestPricesResult, _inventoryRequestPricesResultSignalCallable);
            _inventoryRequestPricesResultSignalCallable = default;
        }
    }

    public new delegate void FavoritesListAccountsUpdatedSignalHandler(long result);
    private FavoritesListAccountsUpdatedSignalHandler _favoritesListAccountsUpdatedSignal;
    private Callable _favoritesListAccountsUpdatedSignalCallable;
    public event FavoritesListAccountsUpdatedSignalHandler FavoritesListAccountsUpdatedSignal
    {
        add
        {
            if (_favoritesListAccountsUpdatedSignal is null)
            {
                _favoritesListAccountsUpdatedSignalCallable = Callable.From((Variant result) => 
                    _favoritesListAccountsUpdatedSignal?.Invoke(result.As<long>()));
                Connect(GDExtensionSignalName.FavoritesListAccountsUpdated, _favoritesListAccountsUpdatedSignalCallable);
            }
            _favoritesListAccountsUpdatedSignal += value;
        }
        remove
        {
            _favoritesListAccountsUpdatedSignal -= value;
            if (_favoritesListAccountsUpdatedSignal is not null) return;
            Disconnect(GDExtensionSignalName.FavoritesListAccountsUpdated, _favoritesListAccountsUpdatedSignalCallable);
            _favoritesListAccountsUpdatedSignalCallable = default;
        }
    }

    public new delegate void FavoritesListChangedSignalHandler(Godot.Collections.Dictionary favorite);
    private FavoritesListChangedSignalHandler _favoritesListChangedSignal;
    private Callable _favoritesListChangedSignalCallable;
    public event FavoritesListChangedSignalHandler FavoritesListChangedSignal
    {
        add
        {
            if (_favoritesListChangedSignal is null)
            {
                _favoritesListChangedSignalCallable = Callable.From((Variant favorite) => 
                    _favoritesListChangedSignal?.Invoke(favorite.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.FavoritesListChanged, _favoritesListChangedSignalCallable);
            }
            _favoritesListChangedSignal += value;
        }
        remove
        {
            _favoritesListChangedSignal -= value;
            if (_favoritesListChangedSignal is not null) return;
            Disconnect(GDExtensionSignalName.FavoritesListChanged, _favoritesListChangedSignalCallable);
            _favoritesListChangedSignalCallable = default;
        }
    }

    public new delegate void LobbyMessageSignalHandler(long lobbyId, long user, string message, long chatType);
    private LobbyMessageSignalHandler _lobbyMessageSignal;
    private Callable _lobbyMessageSignalCallable;
    public event LobbyMessageSignalHandler LobbyMessageSignal
    {
        add
        {
            if (_lobbyMessageSignal is null)
            {
                _lobbyMessageSignalCallable = Callable.From((Variant lobbyId, Variant user, Variant message, Variant chatType) => 
                    _lobbyMessageSignal?.Invoke(lobbyId.As<long>(), user.As<long>(), message.As<string>(), chatType.As<long>()));
                Connect(GDExtensionSignalName.LobbyMessage, _lobbyMessageSignalCallable);
            }
            _lobbyMessageSignal += value;
        }
        remove
        {
            _lobbyMessageSignal -= value;
            if (_lobbyMessageSignal is not null) return;
            Disconnect(GDExtensionSignalName.LobbyMessage, _lobbyMessageSignalCallable);
            _lobbyMessageSignalCallable = default;
        }
    }

    public new delegate void LobbyChatUpdateSignalHandler(long lobbyId, long changedId, long makingChangeId, long chatState);
    private LobbyChatUpdateSignalHandler _lobbyChatUpdateSignal;
    private Callable _lobbyChatUpdateSignalCallable;
    public event LobbyChatUpdateSignalHandler LobbyChatUpdateSignal
    {
        add
        {
            if (_lobbyChatUpdateSignal is null)
            {
                _lobbyChatUpdateSignalCallable = Callable.From((Variant lobbyId, Variant changedId, Variant makingChangeId, Variant chatState) => 
                    _lobbyChatUpdateSignal?.Invoke(lobbyId.As<long>(), changedId.As<long>(), makingChangeId.As<long>(), chatState.As<long>()));
                Connect(GDExtensionSignalName.LobbyChatUpdate, _lobbyChatUpdateSignalCallable);
            }
            _lobbyChatUpdateSignal += value;
        }
        remove
        {
            _lobbyChatUpdateSignal -= value;
            if (_lobbyChatUpdateSignal is not null) return;
            Disconnect(GDExtensionSignalName.LobbyChatUpdate, _lobbyChatUpdateSignalCallable);
            _lobbyChatUpdateSignalCallable = default;
        }
    }

    public new delegate void LobbyCreatedSignalHandler(long connect, long lobbyId);
    private LobbyCreatedSignalHandler _lobbyCreatedSignal;
    private Callable _lobbyCreatedSignalCallable;
    public event LobbyCreatedSignalHandler LobbyCreatedSignal
    {
        add
        {
            if (_lobbyCreatedSignal is null)
            {
                _lobbyCreatedSignalCallable = Callable.From((Variant connect, Variant lobbyId) => 
                    _lobbyCreatedSignal?.Invoke(connect.As<long>(), lobbyId.As<long>()));
                Connect(GDExtensionSignalName.LobbyCreated, _lobbyCreatedSignalCallable);
            }
            _lobbyCreatedSignal += value;
        }
        remove
        {
            _lobbyCreatedSignal -= value;
            if (_lobbyCreatedSignal is not null) return;
            Disconnect(GDExtensionSignalName.LobbyCreated, _lobbyCreatedSignalCallable);
            _lobbyCreatedSignalCallable = default;
        }
    }

    public new delegate void LobbyDataUpdateSignalHandler(long success, long lobbyId, long memberId);
    private LobbyDataUpdateSignalHandler _lobbyDataUpdateSignal;
    private Callable _lobbyDataUpdateSignalCallable;
    public event LobbyDataUpdateSignalHandler LobbyDataUpdateSignal
    {
        add
        {
            if (_lobbyDataUpdateSignal is null)
            {
                _lobbyDataUpdateSignalCallable = Callable.From((Variant success, Variant lobbyId, Variant memberId) => 
                    _lobbyDataUpdateSignal?.Invoke(success.As<long>(), lobbyId.As<long>(), memberId.As<long>()));
                Connect(GDExtensionSignalName.LobbyDataUpdate, _lobbyDataUpdateSignalCallable);
            }
            _lobbyDataUpdateSignal += value;
        }
        remove
        {
            _lobbyDataUpdateSignal -= value;
            if (_lobbyDataUpdateSignal is not null) return;
            Disconnect(GDExtensionSignalName.LobbyDataUpdate, _lobbyDataUpdateSignalCallable);
            _lobbyDataUpdateSignalCallable = default;
        }
    }

    public new delegate void LobbyJoinedSignalHandler(long lobby, long permissions, bool locked, long response);
    private LobbyJoinedSignalHandler _lobbyJoinedSignal;
    private Callable _lobbyJoinedSignalCallable;
    public event LobbyJoinedSignalHandler LobbyJoinedSignal
    {
        add
        {
            if (_lobbyJoinedSignal is null)
            {
                _lobbyJoinedSignalCallable = Callable.From((Variant lobby, Variant permissions, Variant locked, Variant response) => 
                    _lobbyJoinedSignal?.Invoke(lobby.As<long>(), permissions.As<long>(), locked.As<bool>(), response.As<long>()));
                Connect(GDExtensionSignalName.LobbyJoined, _lobbyJoinedSignalCallable);
            }
            _lobbyJoinedSignal += value;
        }
        remove
        {
            _lobbyJoinedSignal -= value;
            if (_lobbyJoinedSignal is not null) return;
            Disconnect(GDExtensionSignalName.LobbyJoined, _lobbyJoinedSignalCallable);
            _lobbyJoinedSignalCallable = default;
        }
    }

    public new delegate void LobbyGameCreatedSignalHandler(long lobbyId, long serverId, string serverIp, long port);
    private LobbyGameCreatedSignalHandler _lobbyGameCreatedSignal;
    private Callable _lobbyGameCreatedSignalCallable;
    public event LobbyGameCreatedSignalHandler LobbyGameCreatedSignal
    {
        add
        {
            if (_lobbyGameCreatedSignal is null)
            {
                _lobbyGameCreatedSignalCallable = Callable.From((Variant lobbyId, Variant serverId, Variant serverIp, Variant port) => 
                    _lobbyGameCreatedSignal?.Invoke(lobbyId.As<long>(), serverId.As<long>(), serverIp.As<string>(), port.As<long>()));
                Connect(GDExtensionSignalName.LobbyGameCreated, _lobbyGameCreatedSignalCallable);
            }
            _lobbyGameCreatedSignal += value;
        }
        remove
        {
            _lobbyGameCreatedSignal -= value;
            if (_lobbyGameCreatedSignal is not null) return;
            Disconnect(GDExtensionSignalName.LobbyGameCreated, _lobbyGameCreatedSignalCallable);
            _lobbyGameCreatedSignalCallable = default;
        }
    }

    public new delegate void LobbyInviteSignalHandler(long inviter, long lobby, long game);
    private LobbyInviteSignalHandler _lobbyInviteSignal;
    private Callable _lobbyInviteSignalCallable;
    public event LobbyInviteSignalHandler LobbyInviteSignal
    {
        add
        {
            if (_lobbyInviteSignal is null)
            {
                _lobbyInviteSignalCallable = Callable.From((Variant inviter, Variant lobby, Variant game) => 
                    _lobbyInviteSignal?.Invoke(inviter.As<long>(), lobby.As<long>(), game.As<long>()));
                Connect(GDExtensionSignalName.LobbyInvite, _lobbyInviteSignalCallable);
            }
            _lobbyInviteSignal += value;
        }
        remove
        {
            _lobbyInviteSignal -= value;
            if (_lobbyInviteSignal is not null) return;
            Disconnect(GDExtensionSignalName.LobbyInvite, _lobbyInviteSignalCallable);
            _lobbyInviteSignalCallable = default;
        }
    }

    public new delegate void LobbyMatchListSignalHandler(Godot.Collections.Array lobbies);
    private LobbyMatchListSignalHandler _lobbyMatchListSignal;
    private Callable _lobbyMatchListSignalCallable;
    public event LobbyMatchListSignalHandler LobbyMatchListSignal
    {
        add
        {
            if (_lobbyMatchListSignal is null)
            {
                _lobbyMatchListSignalCallable = Callable.From((Variant lobbies) => 
                    _lobbyMatchListSignal?.Invoke(lobbies.As<Godot.Collections.Array>()));
                Connect(GDExtensionSignalName.LobbyMatchList, _lobbyMatchListSignalCallable);
            }
            _lobbyMatchListSignal += value;
        }
        remove
        {
            _lobbyMatchListSignal -= value;
            if (_lobbyMatchListSignal is not null) return;
            Disconnect(GDExtensionSignalName.LobbyMatchList, _lobbyMatchListSignalCallable);
            _lobbyMatchListSignalCallable = default;
        }
    }

    public new delegate void LobbyKickedSignalHandler(long lobbyId, long adminId, long dueToDisconnect);
    private LobbyKickedSignalHandler _lobbyKickedSignal;
    private Callable _lobbyKickedSignalCallable;
    public event LobbyKickedSignalHandler LobbyKickedSignal
    {
        add
        {
            if (_lobbyKickedSignal is null)
            {
                _lobbyKickedSignalCallable = Callable.From((Variant lobbyId, Variant adminId, Variant dueToDisconnect) => 
                    _lobbyKickedSignal?.Invoke(lobbyId.As<long>(), adminId.As<long>(), dueToDisconnect.As<long>()));
                Connect(GDExtensionSignalName.LobbyKicked, _lobbyKickedSignalCallable);
            }
            _lobbyKickedSignal += value;
        }
        remove
        {
            _lobbyKickedSignal -= value;
            if (_lobbyKickedSignal is not null) return;
            Disconnect(GDExtensionSignalName.LobbyKicked, _lobbyKickedSignalCallable);
            _lobbyKickedSignalCallable = default;
        }
    }

    public new delegate void AddFriendToListSignalHandler(long friendId, string friendName, bool currentlyConnected);
    private AddFriendToListSignalHandler _addFriendToListSignal;
    private Callable _addFriendToListSignalCallable;
    public event AddFriendToListSignalHandler AddFriendToListSignal
    {
        add
        {
            if (_addFriendToListSignal is null)
            {
                _addFriendToListSignalCallable = Callable.From((Variant friendId, Variant friendName, Variant currentlyConnected) => 
                    _addFriendToListSignal?.Invoke(friendId.As<long>(), friendName.As<string>(), currentlyConnected.As<bool>()));
                Connect(GDExtensionSignalName.AddFriendToList, _addFriendToListSignalCallable);
            }
            _addFriendToListSignal += value;
        }
        remove
        {
            _addFriendToListSignal -= value;
            if (_addFriendToListSignal is not null) return;
            Disconnect(GDExtensionSignalName.AddFriendToList, _addFriendToListSignalCallable);
            _addFriendToListSignalCallable = default;
        }
    }

    public new delegate void FriendsFailedToRespondSignalHandler();
    private FriendsFailedToRespondSignalHandler _friendsFailedToRespondSignal;
    private Callable _friendsFailedToRespondSignalCallable;
    public event FriendsFailedToRespondSignalHandler FriendsFailedToRespondSignal
    {
        add
        {
            if (_friendsFailedToRespondSignal is null)
            {
                _friendsFailedToRespondSignalCallable = Callable.From(() => 
                    _friendsFailedToRespondSignal?.Invoke());
                Connect(GDExtensionSignalName.FriendsFailedToRespond, _friendsFailedToRespondSignalCallable);
            }
            _friendsFailedToRespondSignal += value;
        }
        remove
        {
            _friendsFailedToRespondSignal -= value;
            if (_friendsFailedToRespondSignal is not null) return;
            Disconnect(GDExtensionSignalName.FriendsFailedToRespond, _friendsFailedToRespondSignalCallable);
            _friendsFailedToRespondSignalCallable = default;
        }
    }

    public new delegate void FriendsRefreshCompleteSignalHandler();
    private FriendsRefreshCompleteSignalHandler _friendsRefreshCompleteSignal;
    private Callable _friendsRefreshCompleteSignalCallable;
    public event FriendsRefreshCompleteSignalHandler FriendsRefreshCompleteSignal
    {
        add
        {
            if (_friendsRefreshCompleteSignal is null)
            {
                _friendsRefreshCompleteSignalCallable = Callable.From(() => 
                    _friendsRefreshCompleteSignal?.Invoke());
                Connect(GDExtensionSignalName.FriendsRefreshComplete, _friendsRefreshCompleteSignalCallable);
            }
            _friendsRefreshCompleteSignal += value;
        }
        remove
        {
            _friendsRefreshCompleteSignal -= value;
            if (_friendsRefreshCompleteSignal is not null) return;
            Disconnect(GDExtensionSignalName.FriendsRefreshComplete, _friendsRefreshCompleteSignalCallable);
            _friendsRefreshCompleteSignalCallable = default;
        }
    }

    public new delegate void PingServerFailedToRespondSignalHandler();
    private PingServerFailedToRespondSignalHandler _pingServerFailedToRespondSignal;
    private Callable _pingServerFailedToRespondSignalCallable;
    public event PingServerFailedToRespondSignalHandler PingServerFailedToRespondSignal
    {
        add
        {
            if (_pingServerFailedToRespondSignal is null)
            {
                _pingServerFailedToRespondSignalCallable = Callable.From(() => 
                    _pingServerFailedToRespondSignal?.Invoke());
                Connect(GDExtensionSignalName.PingServerFailedToRespond, _pingServerFailedToRespondSignalCallable);
            }
            _pingServerFailedToRespondSignal += value;
        }
        remove
        {
            _pingServerFailedToRespondSignal -= value;
            if (_pingServerFailedToRespondSignal is not null) return;
            Disconnect(GDExtensionSignalName.PingServerFailedToRespond, _pingServerFailedToRespondSignalCallable);
            _pingServerFailedToRespondSignalCallable = default;
        }
    }

    public new delegate void PingServerRespondedSignalHandler(Godot.Collections.Dictionary serverDetails);
    private PingServerRespondedSignalHandler _pingServerRespondedSignal;
    private Callable _pingServerRespondedSignalCallable;
    public event PingServerRespondedSignalHandler PingServerRespondedSignal
    {
        add
        {
            if (_pingServerRespondedSignal is null)
            {
                _pingServerRespondedSignalCallable = Callable.From((Variant serverDetails) => 
                    _pingServerRespondedSignal?.Invoke(serverDetails.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.PingServerResponded, _pingServerRespondedSignalCallable);
            }
            _pingServerRespondedSignal += value;
        }
        remove
        {
            _pingServerRespondedSignal -= value;
            if (_pingServerRespondedSignal is not null) return;
            Disconnect(GDExtensionSignalName.PingServerResponded, _pingServerRespondedSignalCallable);
            _pingServerRespondedSignalCallable = default;
        }
    }

    public new delegate void PlayerDetailsFailedToRespondSignalHandler();
    private PlayerDetailsFailedToRespondSignalHandler _playerDetailsFailedToRespondSignal;
    private Callable _playerDetailsFailedToRespondSignalCallable;
    public event PlayerDetailsFailedToRespondSignalHandler PlayerDetailsFailedToRespondSignal
    {
        add
        {
            if (_playerDetailsFailedToRespondSignal is null)
            {
                _playerDetailsFailedToRespondSignalCallable = Callable.From(() => 
                    _playerDetailsFailedToRespondSignal?.Invoke());
                Connect(GDExtensionSignalName.PlayerDetailsFailedToRespond, _playerDetailsFailedToRespondSignalCallable);
            }
            _playerDetailsFailedToRespondSignal += value;
        }
        remove
        {
            _playerDetailsFailedToRespondSignal -= value;
            if (_playerDetailsFailedToRespondSignal is not null) return;
            Disconnect(GDExtensionSignalName.PlayerDetailsFailedToRespond, _playerDetailsFailedToRespondSignalCallable);
            _playerDetailsFailedToRespondSignalCallable = default;
        }
    }

    public new delegate void PlayerDetailsPlayerAddedSignalHandler(string name, long score, double timePlayed);
    private PlayerDetailsPlayerAddedSignalHandler _playerDetailsPlayerAddedSignal;
    private Callable _playerDetailsPlayerAddedSignalCallable;
    public event PlayerDetailsPlayerAddedSignalHandler PlayerDetailsPlayerAddedSignal
    {
        add
        {
            if (_playerDetailsPlayerAddedSignal is null)
            {
                _playerDetailsPlayerAddedSignalCallable = Callable.From((Variant name, Variant score, Variant timePlayed) => 
                    _playerDetailsPlayerAddedSignal?.Invoke(name.As<string>(), score.As<long>(), timePlayed.As<double>()));
                Connect(GDExtensionSignalName.PlayerDetailsPlayerAdded, _playerDetailsPlayerAddedSignalCallable);
            }
            _playerDetailsPlayerAddedSignal += value;
        }
        remove
        {
            _playerDetailsPlayerAddedSignal -= value;
            if (_playerDetailsPlayerAddedSignal is not null) return;
            Disconnect(GDExtensionSignalName.PlayerDetailsPlayerAdded, _playerDetailsPlayerAddedSignalCallable);
            _playerDetailsPlayerAddedSignalCallable = default;
        }
    }

    public new delegate void PlayerDetailsRefreshCompleteSignalHandler();
    private PlayerDetailsRefreshCompleteSignalHandler _playerDetailsRefreshCompleteSignal;
    private Callable _playerDetailsRefreshCompleteSignalCallable;
    public event PlayerDetailsRefreshCompleteSignalHandler PlayerDetailsRefreshCompleteSignal
    {
        add
        {
            if (_playerDetailsRefreshCompleteSignal is null)
            {
                _playerDetailsRefreshCompleteSignalCallable = Callable.From(() => 
                    _playerDetailsRefreshCompleteSignal?.Invoke());
                Connect(GDExtensionSignalName.PlayerDetailsRefreshComplete, _playerDetailsRefreshCompleteSignalCallable);
            }
            _playerDetailsRefreshCompleteSignal += value;
        }
        remove
        {
            _playerDetailsRefreshCompleteSignal -= value;
            if (_playerDetailsRefreshCompleteSignal is not null) return;
            Disconnect(GDExtensionSignalName.PlayerDetailsRefreshComplete, _playerDetailsRefreshCompleteSignalCallable);
            _playerDetailsRefreshCompleteSignalCallable = default;
        }
    }

    public new delegate void RequestServerListRefreshCompleteSignalHandler(long requestHandle, long response);
    private RequestServerListRefreshCompleteSignalHandler _requestServerListRefreshCompleteSignal;
    private Callable _requestServerListRefreshCompleteSignalCallable;
    public event RequestServerListRefreshCompleteSignalHandler RequestServerListRefreshCompleteSignal
    {
        add
        {
            if (_requestServerListRefreshCompleteSignal is null)
            {
                _requestServerListRefreshCompleteSignalCallable = Callable.From((Variant requestHandle, Variant response) => 
                    _requestServerListRefreshCompleteSignal?.Invoke(requestHandle.As<long>(), response.As<long>()));
                Connect(GDExtensionSignalName.RequestServerListRefreshComplete, _requestServerListRefreshCompleteSignalCallable);
            }
            _requestServerListRefreshCompleteSignal += value;
        }
        remove
        {
            _requestServerListRefreshCompleteSignal -= value;
            if (_requestServerListRefreshCompleteSignal is not null) return;
            Disconnect(GDExtensionSignalName.RequestServerListRefreshComplete, _requestServerListRefreshCompleteSignalCallable);
            _requestServerListRefreshCompleteSignalCallable = default;
        }
    }

    public new delegate void RequestServerListServerFailedToRespondSignalHandler(long requestHandle, long server);
    private RequestServerListServerFailedToRespondSignalHandler _requestServerListServerFailedToRespondSignal;
    private Callable _requestServerListServerFailedToRespondSignalCallable;
    public event RequestServerListServerFailedToRespondSignalHandler RequestServerListServerFailedToRespondSignal
    {
        add
        {
            if (_requestServerListServerFailedToRespondSignal is null)
            {
                _requestServerListServerFailedToRespondSignalCallable = Callable.From((Variant requestHandle, Variant server) => 
                    _requestServerListServerFailedToRespondSignal?.Invoke(requestHandle.As<long>(), server.As<long>()));
                Connect(GDExtensionSignalName.RequestServerListServerFailedToRespond, _requestServerListServerFailedToRespondSignalCallable);
            }
            _requestServerListServerFailedToRespondSignal += value;
        }
        remove
        {
            _requestServerListServerFailedToRespondSignal -= value;
            if (_requestServerListServerFailedToRespondSignal is not null) return;
            Disconnect(GDExtensionSignalName.RequestServerListServerFailedToRespond, _requestServerListServerFailedToRespondSignalCallable);
            _requestServerListServerFailedToRespondSignalCallable = default;
        }
    }

    public new delegate void RequestServerListServerRespondedSignalHandler(long requestHandle, long server);
    private RequestServerListServerRespondedSignalHandler _requestServerListServerRespondedSignal;
    private Callable _requestServerListServerRespondedSignalCallable;
    public event RequestServerListServerRespondedSignalHandler RequestServerListServerRespondedSignal
    {
        add
        {
            if (_requestServerListServerRespondedSignal is null)
            {
                _requestServerListServerRespondedSignalCallable = Callable.From((Variant requestHandle, Variant server) => 
                    _requestServerListServerRespondedSignal?.Invoke(requestHandle.As<long>(), server.As<long>()));
                Connect(GDExtensionSignalName.RequestServerListServerResponded, _requestServerListServerRespondedSignalCallable);
            }
            _requestServerListServerRespondedSignal += value;
        }
        remove
        {
            _requestServerListServerRespondedSignal -= value;
            if (_requestServerListServerRespondedSignal is not null) return;
            Disconnect(GDExtensionSignalName.RequestServerListServerResponded, _requestServerListServerRespondedSignalCallable);
            _requestServerListServerRespondedSignalCallable = default;
        }
    }

    public new delegate void ServerRulesFailedToRespondSignalHandler();
    private ServerRulesFailedToRespondSignalHandler _serverRulesFailedToRespondSignal;
    private Callable _serverRulesFailedToRespondSignalCallable;
    public event ServerRulesFailedToRespondSignalHandler ServerRulesFailedToRespondSignal
    {
        add
        {
            if (_serverRulesFailedToRespondSignal is null)
            {
                _serverRulesFailedToRespondSignalCallable = Callable.From(() => 
                    _serverRulesFailedToRespondSignal?.Invoke());
                Connect(GDExtensionSignalName.ServerRulesFailedToRespond, _serverRulesFailedToRespondSignalCallable);
            }
            _serverRulesFailedToRespondSignal += value;
        }
        remove
        {
            _serverRulesFailedToRespondSignal -= value;
            if (_serverRulesFailedToRespondSignal is not null) return;
            Disconnect(GDExtensionSignalName.ServerRulesFailedToRespond, _serverRulesFailedToRespondSignalCallable);
            _serverRulesFailedToRespondSignalCallable = default;
        }
    }

    public new delegate void ServerRulesRefreshCompleteSignalHandler();
    private ServerRulesRefreshCompleteSignalHandler _serverRulesRefreshCompleteSignal;
    private Callable _serverRulesRefreshCompleteSignalCallable;
    public event ServerRulesRefreshCompleteSignalHandler ServerRulesRefreshCompleteSignal
    {
        add
        {
            if (_serverRulesRefreshCompleteSignal is null)
            {
                _serverRulesRefreshCompleteSignalCallable = Callable.From(() => 
                    _serverRulesRefreshCompleteSignal?.Invoke());
                Connect(GDExtensionSignalName.ServerRulesRefreshComplete, _serverRulesRefreshCompleteSignalCallable);
            }
            _serverRulesRefreshCompleteSignal += value;
        }
        remove
        {
            _serverRulesRefreshCompleteSignal -= value;
            if (_serverRulesRefreshCompleteSignal is not null) return;
            Disconnect(GDExtensionSignalName.ServerRulesRefreshComplete, _serverRulesRefreshCompleteSignalCallable);
            _serverRulesRefreshCompleteSignalCallable = default;
        }
    }

    public new delegate void ServerRulesRespondedSignalHandler(string rule, string value);
    private ServerRulesRespondedSignalHandler _serverRulesRespondedSignal;
    private Callable _serverRulesRespondedSignalCallable;
    public event ServerRulesRespondedSignalHandler ServerRulesRespondedSignal
    {
        add
        {
            if (_serverRulesRespondedSignal is null)
            {
                _serverRulesRespondedSignalCallable = Callable.From((Variant rule, Variant value) => 
                    _serverRulesRespondedSignal?.Invoke(rule.As<string>(), value.As<string>()));
                Connect(GDExtensionSignalName.ServerRulesResponded, _serverRulesRespondedSignalCallable);
            }
            _serverRulesRespondedSignal += value;
        }
        remove
        {
            _serverRulesRespondedSignal -= value;
            if (_serverRulesRespondedSignal is not null) return;
            Disconnect(GDExtensionSignalName.ServerRulesResponded, _serverRulesRespondedSignalCallable);
            _serverRulesRespondedSignalCallable = default;
        }
    }

    public new delegate void MusicPlaybackStatusHasChangedSignalHandler();
    private MusicPlaybackStatusHasChangedSignalHandler _musicPlaybackStatusHasChangedSignal;
    private Callable _musicPlaybackStatusHasChangedSignalCallable;
    public event MusicPlaybackStatusHasChangedSignalHandler MusicPlaybackStatusHasChangedSignal
    {
        add
        {
            if (_musicPlaybackStatusHasChangedSignal is null)
            {
                _musicPlaybackStatusHasChangedSignalCallable = Callable.From(() => 
                    _musicPlaybackStatusHasChangedSignal?.Invoke());
                Connect(GDExtensionSignalName.MusicPlaybackStatusHasChanged, _musicPlaybackStatusHasChangedSignalCallable);
            }
            _musicPlaybackStatusHasChangedSignal += value;
        }
        remove
        {
            _musicPlaybackStatusHasChangedSignal -= value;
            if (_musicPlaybackStatusHasChangedSignal is not null) return;
            Disconnect(GDExtensionSignalName.MusicPlaybackStatusHasChanged, _musicPlaybackStatusHasChangedSignalCallable);
            _musicPlaybackStatusHasChangedSignalCallable = default;
        }
    }

    public new delegate void MusicVolumeHasChangedSignalHandler(double newVolume);
    private MusicVolumeHasChangedSignalHandler _musicVolumeHasChangedSignal;
    private Callable _musicVolumeHasChangedSignalCallable;
    public event MusicVolumeHasChangedSignalHandler MusicVolumeHasChangedSignal
    {
        add
        {
            if (_musicVolumeHasChangedSignal is null)
            {
                _musicVolumeHasChangedSignalCallable = Callable.From((Variant newVolume) => 
                    _musicVolumeHasChangedSignal?.Invoke(newVolume.As<double>()));
                Connect(GDExtensionSignalName.MusicVolumeHasChanged, _musicVolumeHasChangedSignalCallable);
            }
            _musicVolumeHasChangedSignal += value;
        }
        remove
        {
            _musicVolumeHasChangedSignal -= value;
            if (_musicVolumeHasChangedSignal is not null) return;
            Disconnect(GDExtensionSignalName.MusicVolumeHasChanged, _musicVolumeHasChangedSignalCallable);
            _musicVolumeHasChangedSignalCallable = default;
        }
    }

    public new delegate void P2pSessionRequestSignalHandler(long remoteSteamId);
    private P2pSessionRequestSignalHandler _p2pSessionRequestSignal;
    private Callable _p2pSessionRequestSignalCallable;
    public event P2pSessionRequestSignalHandler P2pSessionRequestSignal
    {
        add
        {
            if (_p2pSessionRequestSignal is null)
            {
                _p2pSessionRequestSignalCallable = Callable.From((Variant remoteSteamId) => 
                    _p2pSessionRequestSignal?.Invoke(remoteSteamId.As<long>()));
                Connect(GDExtensionSignalName.P2pSessionRequest, _p2pSessionRequestSignalCallable);
            }
            _p2pSessionRequestSignal += value;
        }
        remove
        {
            _p2pSessionRequestSignal -= value;
            if (_p2pSessionRequestSignal is not null) return;
            Disconnect(GDExtensionSignalName.P2pSessionRequest, _p2pSessionRequestSignalCallable);
            _p2pSessionRequestSignalCallable = default;
        }
    }

    public new delegate void P2pSessionConnectFailSignalHandler(long remoteSteamId, long sessionError);
    private P2pSessionConnectFailSignalHandler _p2pSessionConnectFailSignal;
    private Callable _p2pSessionConnectFailSignalCallable;
    public event P2pSessionConnectFailSignalHandler P2pSessionConnectFailSignal
    {
        add
        {
            if (_p2pSessionConnectFailSignal is null)
            {
                _p2pSessionConnectFailSignalCallable = Callable.From((Variant remoteSteamId, Variant sessionError) => 
                    _p2pSessionConnectFailSignal?.Invoke(remoteSteamId.As<long>(), sessionError.As<long>()));
                Connect(GDExtensionSignalName.P2pSessionConnectFail, _p2pSessionConnectFailSignalCallable);
            }
            _p2pSessionConnectFailSignal += value;
        }
        remove
        {
            _p2pSessionConnectFailSignal -= value;
            if (_p2pSessionConnectFailSignal is not null) return;
            Disconnect(GDExtensionSignalName.P2pSessionConnectFail, _p2pSessionConnectFailSignalCallable);
            _p2pSessionConnectFailSignalCallable = default;
        }
    }

    public new delegate void NetworkMessagesSessionRequestSignalHandler(long remoteSteamId);
    private NetworkMessagesSessionRequestSignalHandler _networkMessagesSessionRequestSignal;
    private Callable _networkMessagesSessionRequestSignalCallable;
    public event NetworkMessagesSessionRequestSignalHandler NetworkMessagesSessionRequestSignal
    {
        add
        {
            if (_networkMessagesSessionRequestSignal is null)
            {
                _networkMessagesSessionRequestSignalCallable = Callable.From((Variant remoteSteamId) => 
                    _networkMessagesSessionRequestSignal?.Invoke(remoteSteamId.As<long>()));
                Connect(GDExtensionSignalName.NetworkMessagesSessionRequest, _networkMessagesSessionRequestSignalCallable);
            }
            _networkMessagesSessionRequestSignal += value;
        }
        remove
        {
            _networkMessagesSessionRequestSignal -= value;
            if (_networkMessagesSessionRequestSignal is not null) return;
            Disconnect(GDExtensionSignalName.NetworkMessagesSessionRequest, _networkMessagesSessionRequestSignalCallable);
            _networkMessagesSessionRequestSignalCallable = default;
        }
    }

    public new delegate void NetworkMessagesSessionFailedSignalHandler(long reason, long remoteSteamId, long connectionState, string debugMessage);
    private NetworkMessagesSessionFailedSignalHandler _networkMessagesSessionFailedSignal;
    private Callable _networkMessagesSessionFailedSignalCallable;
    public event NetworkMessagesSessionFailedSignalHandler NetworkMessagesSessionFailedSignal
    {
        add
        {
            if (_networkMessagesSessionFailedSignal is null)
            {
                _networkMessagesSessionFailedSignalCallable = Callable.From((Variant reason, Variant remoteSteamId, Variant connectionState, Variant debugMessage) => 
                    _networkMessagesSessionFailedSignal?.Invoke(reason.As<long>(), remoteSteamId.As<long>(), connectionState.As<long>(), debugMessage.As<string>()));
                Connect(GDExtensionSignalName.NetworkMessagesSessionFailed, _networkMessagesSessionFailedSignalCallable);
            }
            _networkMessagesSessionFailedSignal += value;
        }
        remove
        {
            _networkMessagesSessionFailedSignal -= value;
            if (_networkMessagesSessionFailedSignal is not null) return;
            Disconnect(GDExtensionSignalName.NetworkMessagesSessionFailed, _networkMessagesSessionFailedSignalCallable);
            _networkMessagesSessionFailedSignalCallable = default;
        }
    }

    public new delegate void NetworkConnectionStatusChangedSignalHandler(long connectHandle, Godot.Collections.Dictionary connection, long oldState);
    private NetworkConnectionStatusChangedSignalHandler _networkConnectionStatusChangedSignal;
    private Callable _networkConnectionStatusChangedSignalCallable;
    public event NetworkConnectionStatusChangedSignalHandler NetworkConnectionStatusChangedSignal
    {
        add
        {
            if (_networkConnectionStatusChangedSignal is null)
            {
                _networkConnectionStatusChangedSignalCallable = Callable.From((Variant connectHandle, Variant connection, Variant oldState) => 
                    _networkConnectionStatusChangedSignal?.Invoke(connectHandle.As<long>(), connection.As<Godot.Collections.Dictionary>(), oldState.As<long>()));
                Connect(GDExtensionSignalName.NetworkConnectionStatusChanged, _networkConnectionStatusChangedSignalCallable);
            }
            _networkConnectionStatusChangedSignal += value;
        }
        remove
        {
            _networkConnectionStatusChangedSignal -= value;
            if (_networkConnectionStatusChangedSignal is not null) return;
            Disconnect(GDExtensionSignalName.NetworkConnectionStatusChanged, _networkConnectionStatusChangedSignalCallable);
            _networkConnectionStatusChangedSignalCallable = default;
        }
    }

    public new delegate void NetworkAuthenticationStatusSignalHandler(long available, string debugMessage);
    private NetworkAuthenticationStatusSignalHandler _networkAuthenticationStatusSignal;
    private Callable _networkAuthenticationStatusSignalCallable;
    public event NetworkAuthenticationStatusSignalHandler NetworkAuthenticationStatusSignal
    {
        add
        {
            if (_networkAuthenticationStatusSignal is null)
            {
                _networkAuthenticationStatusSignalCallable = Callable.From((Variant available, Variant debugMessage) => 
                    _networkAuthenticationStatusSignal?.Invoke(available.As<long>(), debugMessage.As<string>()));
                Connect(GDExtensionSignalName.NetworkAuthenticationStatus, _networkAuthenticationStatusSignalCallable);
            }
            _networkAuthenticationStatusSignal += value;
        }
        remove
        {
            _networkAuthenticationStatusSignal -= value;
            if (_networkAuthenticationStatusSignal is not null) return;
            Disconnect(GDExtensionSignalName.NetworkAuthenticationStatus, _networkAuthenticationStatusSignalCallable);
            _networkAuthenticationStatusSignalCallable = default;
        }
    }

    public new delegate void FakeIpResultSignalHandler(long result, long remoteFakeSteamId, string fakeIp, int[] portList);
    private FakeIpResultSignalHandler _fakeIpResultSignal;
    private Callable _fakeIpResultSignalCallable;
    public event FakeIpResultSignalHandler FakeIpResultSignal
    {
        add
        {
            if (_fakeIpResultSignal is null)
            {
                _fakeIpResultSignalCallable = Callable.From((Variant result, Variant remoteFakeSteamId, Variant fakeIp, Variant portList) => 
                    _fakeIpResultSignal?.Invoke(result.As<long>(), remoteFakeSteamId.As<long>(), fakeIp.As<string>(), portList.As<int[]>()));
                Connect(GDExtensionSignalName.FakeIpResult, _fakeIpResultSignalCallable);
            }
            _fakeIpResultSignal += value;
        }
        remove
        {
            _fakeIpResultSignal -= value;
            if (_fakeIpResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.FakeIpResult, _fakeIpResultSignalCallable);
            _fakeIpResultSignalCallable = default;
        }
    }

    public new delegate void RelayNetworkStatusSignalHandler(long available, long pingMeasurement, long availableConfig, long availableRelay, string debugMessage);
    private RelayNetworkStatusSignalHandler _relayNetworkStatusSignal;
    private Callable _relayNetworkStatusSignalCallable;
    public event RelayNetworkStatusSignalHandler RelayNetworkStatusSignal
    {
        add
        {
            if (_relayNetworkStatusSignal is null)
            {
                _relayNetworkStatusSignalCallable = Callable.From((Variant available, Variant pingMeasurement, Variant availableConfig, Variant availableRelay, Variant debugMessage) => 
                    _relayNetworkStatusSignal?.Invoke(available.As<long>(), pingMeasurement.As<long>(), availableConfig.As<long>(), availableRelay.As<long>(), debugMessage.As<string>()));
                Connect(GDExtensionSignalName.RelayNetworkStatus, _relayNetworkStatusSignalCallable);
            }
            _relayNetworkStatusSignal += value;
        }
        remove
        {
            _relayNetworkStatusSignal -= value;
            if (_relayNetworkStatusSignal is not null) return;
            Disconnect(GDExtensionSignalName.RelayNetworkStatus, _relayNetworkStatusSignalCallable);
            _relayNetworkStatusSignalCallable = default;
        }
    }

    public new delegate void ParentalSettingChangedSignalHandler();
    private ParentalSettingChangedSignalHandler _parentalSettingChangedSignal;
    private Callable _parentalSettingChangedSignalCallable;
    public event ParentalSettingChangedSignalHandler ParentalSettingChangedSignal
    {
        add
        {
            if (_parentalSettingChangedSignal is null)
            {
                _parentalSettingChangedSignalCallable = Callable.From(() => 
                    _parentalSettingChangedSignal?.Invoke());
                Connect(GDExtensionSignalName.ParentalSettingChanged, _parentalSettingChangedSignalCallable);
            }
            _parentalSettingChangedSignal += value;
        }
        remove
        {
            _parentalSettingChangedSignal -= value;
            if (_parentalSettingChangedSignal is not null) return;
            Disconnect(GDExtensionSignalName.ParentalSettingChanged, _parentalSettingChangedSignalCallable);
            _parentalSettingChangedSignalCallable = default;
        }
    }

    public new delegate void JoinPartySignalHandler(long result, long beaconId, long steamId, string connectString);
    private JoinPartySignalHandler _joinPartySignal;
    private Callable _joinPartySignalCallable;
    public event JoinPartySignalHandler JoinPartySignal
    {
        add
        {
            if (_joinPartySignal is null)
            {
                _joinPartySignalCallable = Callable.From((Variant result, Variant beaconId, Variant steamId, Variant connectString) => 
                    _joinPartySignal?.Invoke(result.As<long>(), beaconId.As<long>(), steamId.As<long>(), connectString.As<string>()));
                Connect(GDExtensionSignalName.JoinParty, _joinPartySignalCallable);
            }
            _joinPartySignal += value;
        }
        remove
        {
            _joinPartySignal -= value;
            if (_joinPartySignal is not null) return;
            Disconnect(GDExtensionSignalName.JoinParty, _joinPartySignalCallable);
            _joinPartySignalCallable = default;
        }
    }

    public new delegate void CreateBeaconSignalHandler(long result, long beaconId);
    private CreateBeaconSignalHandler _createBeaconSignal;
    private Callable _createBeaconSignalCallable;
    public event CreateBeaconSignalHandler CreateBeaconSignal
    {
        add
        {
            if (_createBeaconSignal is null)
            {
                _createBeaconSignalCallable = Callable.From((Variant result, Variant beaconId) => 
                    _createBeaconSignal?.Invoke(result.As<long>(), beaconId.As<long>()));
                Connect(GDExtensionSignalName.CreateBeacon, _createBeaconSignalCallable);
            }
            _createBeaconSignal += value;
        }
        remove
        {
            _createBeaconSignal -= value;
            if (_createBeaconSignal is not null) return;
            Disconnect(GDExtensionSignalName.CreateBeacon, _createBeaconSignalCallable);
            _createBeaconSignalCallable = default;
        }
    }

    public new delegate void ReservationNotificationSignalHandler(long beaconId, long steamId);
    private ReservationNotificationSignalHandler _reservationNotificationSignal;
    private Callable _reservationNotificationSignalCallable;
    public event ReservationNotificationSignalHandler ReservationNotificationSignal
    {
        add
        {
            if (_reservationNotificationSignal is null)
            {
                _reservationNotificationSignalCallable = Callable.From((Variant beaconId, Variant steamId) => 
                    _reservationNotificationSignal?.Invoke(beaconId.As<long>(), steamId.As<long>()));
                Connect(GDExtensionSignalName.ReservationNotification, _reservationNotificationSignalCallable);
            }
            _reservationNotificationSignal += value;
        }
        remove
        {
            _reservationNotificationSignal -= value;
            if (_reservationNotificationSignal is not null) return;
            Disconnect(GDExtensionSignalName.ReservationNotification, _reservationNotificationSignalCallable);
            _reservationNotificationSignalCallable = default;
        }
    }

    public new delegate void ChangeNumOpenSlotsSignalHandler(long result);
    private ChangeNumOpenSlotsSignalHandler _changeNumOpenSlotsSignal;
    private Callable _changeNumOpenSlotsSignalCallable;
    public event ChangeNumOpenSlotsSignalHandler ChangeNumOpenSlotsSignal
    {
        add
        {
            if (_changeNumOpenSlotsSignal is null)
            {
                _changeNumOpenSlotsSignalCallable = Callable.From((Variant result) => 
                    _changeNumOpenSlotsSignal?.Invoke(result.As<long>()));
                Connect(GDExtensionSignalName.ChangeNumOpenSlots, _changeNumOpenSlotsSignalCallable);
            }
            _changeNumOpenSlotsSignal += value;
        }
        remove
        {
            _changeNumOpenSlotsSignal -= value;
            if (_changeNumOpenSlotsSignal is not null) return;
            Disconnect(GDExtensionSignalName.ChangeNumOpenSlots, _changeNumOpenSlotsSignalCallable);
            _changeNumOpenSlotsSignalCallable = default;
        }
    }

    public new delegate void AvailableBeaconLocationsUpdatedSignalHandler();
    private AvailableBeaconLocationsUpdatedSignalHandler _availableBeaconLocationsUpdatedSignal;
    private Callable _availableBeaconLocationsUpdatedSignalCallable;
    public event AvailableBeaconLocationsUpdatedSignalHandler AvailableBeaconLocationsUpdatedSignal
    {
        add
        {
            if (_availableBeaconLocationsUpdatedSignal is null)
            {
                _availableBeaconLocationsUpdatedSignalCallable = Callable.From(() => 
                    _availableBeaconLocationsUpdatedSignal?.Invoke());
                Connect(GDExtensionSignalName.AvailableBeaconLocationsUpdated, _availableBeaconLocationsUpdatedSignalCallable);
            }
            _availableBeaconLocationsUpdatedSignal += value;
        }
        remove
        {
            _availableBeaconLocationsUpdatedSignal -= value;
            if (_availableBeaconLocationsUpdatedSignal is not null) return;
            Disconnect(GDExtensionSignalName.AvailableBeaconLocationsUpdated, _availableBeaconLocationsUpdatedSignalCallable);
            _availableBeaconLocationsUpdatedSignalCallable = default;
        }
    }

    public new delegate void ActiveBeaconsUpdatedSignalHandler();
    private ActiveBeaconsUpdatedSignalHandler _activeBeaconsUpdatedSignal;
    private Callable _activeBeaconsUpdatedSignalCallable;
    public event ActiveBeaconsUpdatedSignalHandler ActiveBeaconsUpdatedSignal
    {
        add
        {
            if (_activeBeaconsUpdatedSignal is null)
            {
                _activeBeaconsUpdatedSignalCallable = Callable.From(() => 
                    _activeBeaconsUpdatedSignal?.Invoke());
                Connect(GDExtensionSignalName.ActiveBeaconsUpdated, _activeBeaconsUpdatedSignalCallable);
            }
            _activeBeaconsUpdatedSignal += value;
        }
        remove
        {
            _activeBeaconsUpdatedSignal -= value;
            if (_activeBeaconsUpdatedSignal is not null) return;
            Disconnect(GDExtensionSignalName.ActiveBeaconsUpdated, _activeBeaconsUpdatedSignalCallable);
            _activeBeaconsUpdatedSignalCallable = default;
        }
    }

    public new delegate void RemotePlayGuestInviteSignalHandler(string inviteUrl);
    private RemotePlayGuestInviteSignalHandler _remotePlayGuestInviteSignal;
    private Callable _remotePlayGuestInviteSignalCallable;
    public event RemotePlayGuestInviteSignalHandler RemotePlayGuestInviteSignal
    {
        add
        {
            if (_remotePlayGuestInviteSignal is null)
            {
                _remotePlayGuestInviteSignalCallable = Callable.From((Variant inviteUrl) => 
                    _remotePlayGuestInviteSignal?.Invoke(inviteUrl.As<string>()));
                Connect(GDExtensionSignalName.RemotePlayGuestInvite, _remotePlayGuestInviteSignalCallable);
            }
            _remotePlayGuestInviteSignal += value;
        }
        remove
        {
            _remotePlayGuestInviteSignal -= value;
            if (_remotePlayGuestInviteSignal is not null) return;
            Disconnect(GDExtensionSignalName.RemotePlayGuestInvite, _remotePlayGuestInviteSignalCallable);
            _remotePlayGuestInviteSignalCallable = default;
        }
    }

    public new delegate void RemotePlaySessionAvatarLoadedSignalHandler(long sessionId, long avatarIndex, long width, long height);
    private RemotePlaySessionAvatarLoadedSignalHandler _remotePlaySessionAvatarLoadedSignal;
    private Callable _remotePlaySessionAvatarLoadedSignalCallable;
    public event RemotePlaySessionAvatarLoadedSignalHandler RemotePlaySessionAvatarLoadedSignal
    {
        add
        {
            if (_remotePlaySessionAvatarLoadedSignal is null)
            {
                _remotePlaySessionAvatarLoadedSignalCallable = Callable.From((Variant sessionId, Variant avatarIndex, Variant width, Variant height) => 
                    _remotePlaySessionAvatarLoadedSignal?.Invoke(sessionId.As<long>(), avatarIndex.As<long>(), width.As<long>(), height.As<long>()));
                Connect(GDExtensionSignalName.RemotePlaySessionAvatarLoaded, _remotePlaySessionAvatarLoadedSignalCallable);
            }
            _remotePlaySessionAvatarLoadedSignal += value;
        }
        remove
        {
            _remotePlaySessionAvatarLoadedSignal -= value;
            if (_remotePlaySessionAvatarLoadedSignal is not null) return;
            Disconnect(GDExtensionSignalName.RemotePlaySessionAvatarLoaded, _remotePlaySessionAvatarLoadedSignalCallable);
            _remotePlaySessionAvatarLoadedSignalCallable = default;
        }
    }

    public new delegate void RemotePlaySessionConnectedSignalHandler(long sessionId);
    private RemotePlaySessionConnectedSignalHandler _remotePlaySessionConnectedSignal;
    private Callable _remotePlaySessionConnectedSignalCallable;
    public event RemotePlaySessionConnectedSignalHandler RemotePlaySessionConnectedSignal
    {
        add
        {
            if (_remotePlaySessionConnectedSignal is null)
            {
                _remotePlaySessionConnectedSignalCallable = Callable.From((Variant sessionId) => 
                    _remotePlaySessionConnectedSignal?.Invoke(sessionId.As<long>()));
                Connect(GDExtensionSignalName.RemotePlaySessionConnected, _remotePlaySessionConnectedSignalCallable);
            }
            _remotePlaySessionConnectedSignal += value;
        }
        remove
        {
            _remotePlaySessionConnectedSignal -= value;
            if (_remotePlaySessionConnectedSignal is not null) return;
            Disconnect(GDExtensionSignalName.RemotePlaySessionConnected, _remotePlaySessionConnectedSignalCallable);
            _remotePlaySessionConnectedSignalCallable = default;
        }
    }

    public new delegate void RemotePlaySessionDisconnectedSignalHandler(long sessionId);
    private RemotePlaySessionDisconnectedSignalHandler _remotePlaySessionDisconnectedSignal;
    private Callable _remotePlaySessionDisconnectedSignalCallable;
    public event RemotePlaySessionDisconnectedSignalHandler RemotePlaySessionDisconnectedSignal
    {
        add
        {
            if (_remotePlaySessionDisconnectedSignal is null)
            {
                _remotePlaySessionDisconnectedSignalCallable = Callable.From((Variant sessionId) => 
                    _remotePlaySessionDisconnectedSignal?.Invoke(sessionId.As<long>()));
                Connect(GDExtensionSignalName.RemotePlaySessionDisconnected, _remotePlaySessionDisconnectedSignalCallable);
            }
            _remotePlaySessionDisconnectedSignal += value;
        }
        remove
        {
            _remotePlaySessionDisconnectedSignal -= value;
            if (_remotePlaySessionDisconnectedSignal is not null) return;
            Disconnect(GDExtensionSignalName.RemotePlaySessionDisconnected, _remotePlaySessionDisconnectedSignalCallable);
            _remotePlaySessionDisconnectedSignalCallable = default;
        }
    }

    public new delegate void FileReadAsyncCompleteSignalHandler(Godot.Collections.Dictionary fileRead);
    private FileReadAsyncCompleteSignalHandler _fileReadAsyncCompleteSignal;
    private Callable _fileReadAsyncCompleteSignalCallable;
    public event FileReadAsyncCompleteSignalHandler FileReadAsyncCompleteSignal
    {
        add
        {
            if (_fileReadAsyncCompleteSignal is null)
            {
                _fileReadAsyncCompleteSignalCallable = Callable.From((Variant fileRead) => 
                    _fileReadAsyncCompleteSignal?.Invoke(fileRead.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.FileReadAsyncComplete, _fileReadAsyncCompleteSignalCallable);
            }
            _fileReadAsyncCompleteSignal += value;
        }
        remove
        {
            _fileReadAsyncCompleteSignal -= value;
            if (_fileReadAsyncCompleteSignal is not null) return;
            Disconnect(GDExtensionSignalName.FileReadAsyncComplete, _fileReadAsyncCompleteSignalCallable);
            _fileReadAsyncCompleteSignalCallable = default;
        }
    }

    public new delegate void FileShareResultSignalHandler(long result, long handle, string name);
    private FileShareResultSignalHandler _fileShareResultSignal;
    private Callable _fileShareResultSignalCallable;
    public event FileShareResultSignalHandler FileShareResultSignal
    {
        add
        {
            if (_fileShareResultSignal is null)
            {
                _fileShareResultSignalCallable = Callable.From((Variant result, Variant handle, Variant name) => 
                    _fileShareResultSignal?.Invoke(result.As<long>(), handle.As<long>(), name.As<string>()));
                Connect(GDExtensionSignalName.FileShareResult, _fileShareResultSignalCallable);
            }
            _fileShareResultSignal += value;
        }
        remove
        {
            _fileShareResultSignal -= value;
            if (_fileShareResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.FileShareResult, _fileShareResultSignalCallable);
            _fileShareResultSignalCallable = default;
        }
    }

    public new delegate void FileWriteAsyncCompleteSignalHandler(long result);
    private FileWriteAsyncCompleteSignalHandler _fileWriteAsyncCompleteSignal;
    private Callable _fileWriteAsyncCompleteSignalCallable;
    public event FileWriteAsyncCompleteSignalHandler FileWriteAsyncCompleteSignal
    {
        add
        {
            if (_fileWriteAsyncCompleteSignal is null)
            {
                _fileWriteAsyncCompleteSignalCallable = Callable.From((Variant result) => 
                    _fileWriteAsyncCompleteSignal?.Invoke(result.As<long>()));
                Connect(GDExtensionSignalName.FileWriteAsyncComplete, _fileWriteAsyncCompleteSignalCallable);
            }
            _fileWriteAsyncCompleteSignal += value;
        }
        remove
        {
            _fileWriteAsyncCompleteSignal -= value;
            if (_fileWriteAsyncCompleteSignal is not null) return;
            Disconnect(GDExtensionSignalName.FileWriteAsyncComplete, _fileWriteAsyncCompleteSignalCallable);
            _fileWriteAsyncCompleteSignalCallable = default;
        }
    }

    public new delegate void DownloadUgcResultSignalHandler(long result, Godot.Collections.Dictionary downloadData);
    private DownloadUgcResultSignalHandler _downloadUgcResultSignal;
    private Callable _downloadUgcResultSignalCallable;
    public event DownloadUgcResultSignalHandler DownloadUgcResultSignal
    {
        add
        {
            if (_downloadUgcResultSignal is null)
            {
                _downloadUgcResultSignalCallable = Callable.From((Variant result, Variant downloadData) => 
                    _downloadUgcResultSignal?.Invoke(result.As<long>(), downloadData.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.DownloadUgcResult, _downloadUgcResultSignalCallable);
            }
            _downloadUgcResultSignal += value;
        }
        remove
        {
            _downloadUgcResultSignal -= value;
            if (_downloadUgcResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.DownloadUgcResult, _downloadUgcResultSignalCallable);
            _downloadUgcResultSignalCallable = default;
        }
    }

    public new delegate void PublishedFileSubscribedSignalHandler(long fileId, long appId);
    private PublishedFileSubscribedSignalHandler _publishedFileSubscribedSignal;
    private Callable _publishedFileSubscribedSignalCallable;
    public event PublishedFileSubscribedSignalHandler PublishedFileSubscribedSignal
    {
        add
        {
            if (_publishedFileSubscribedSignal is null)
            {
                _publishedFileSubscribedSignalCallable = Callable.From((Variant fileId, Variant appId) => 
                    _publishedFileSubscribedSignal?.Invoke(fileId.As<long>(), appId.As<long>()));
                Connect(GDExtensionSignalName.PublishedFileSubscribed, _publishedFileSubscribedSignalCallable);
            }
            _publishedFileSubscribedSignal += value;
        }
        remove
        {
            _publishedFileSubscribedSignal -= value;
            if (_publishedFileSubscribedSignal is not null) return;
            Disconnect(GDExtensionSignalName.PublishedFileSubscribed, _publishedFileSubscribedSignalCallable);
            _publishedFileSubscribedSignalCallable = default;
        }
    }

    public new delegate void PublishedFileUnsubscribedSignalHandler(long fileId, long appId);
    private PublishedFileUnsubscribedSignalHandler _publishedFileUnsubscribedSignal;
    private Callable _publishedFileUnsubscribedSignalCallable;
    public event PublishedFileUnsubscribedSignalHandler PublishedFileUnsubscribedSignal
    {
        add
        {
            if (_publishedFileUnsubscribedSignal is null)
            {
                _publishedFileUnsubscribedSignalCallable = Callable.From((Variant fileId, Variant appId) => 
                    _publishedFileUnsubscribedSignal?.Invoke(fileId.As<long>(), appId.As<long>()));
                Connect(GDExtensionSignalName.PublishedFileUnsubscribed, _publishedFileUnsubscribedSignalCallable);
            }
            _publishedFileUnsubscribedSignal += value;
        }
        remove
        {
            _publishedFileUnsubscribedSignal -= value;
            if (_publishedFileUnsubscribedSignal is not null) return;
            Disconnect(GDExtensionSignalName.PublishedFileUnsubscribed, _publishedFileUnsubscribedSignalCallable);
            _publishedFileUnsubscribedSignalCallable = default;
        }
    }

    public new delegate void UnsubscribeItemSignalHandler(long result, long fileId);
    private UnsubscribeItemSignalHandler _unsubscribeItemSignal;
    private Callable _unsubscribeItemSignalCallable;
    public event UnsubscribeItemSignalHandler UnsubscribeItemSignal
    {
        add
        {
            if (_unsubscribeItemSignal is null)
            {
                _unsubscribeItemSignalCallable = Callable.From((Variant result, Variant fileId) => 
                    _unsubscribeItemSignal?.Invoke(result.As<long>(), fileId.As<long>()));
                Connect(GDExtensionSignalName.UnsubscribeItem, _unsubscribeItemSignalCallable);
            }
            _unsubscribeItemSignal += value;
        }
        remove
        {
            _unsubscribeItemSignal -= value;
            if (_unsubscribeItemSignal is not null) return;
            Disconnect(GDExtensionSignalName.UnsubscribeItem, _unsubscribeItemSignalCallable);
            _unsubscribeItemSignalCallable = default;
        }
    }

    public new delegate void SubscribeItemSignalHandler(long result, long fileId);
    private SubscribeItemSignalHandler _subscribeItemSignal;
    private Callable _subscribeItemSignalCallable;
    public event SubscribeItemSignalHandler SubscribeItemSignal
    {
        add
        {
            if (_subscribeItemSignal is null)
            {
                _subscribeItemSignalCallable = Callable.From((Variant result, Variant fileId) => 
                    _subscribeItemSignal?.Invoke(result.As<long>(), fileId.As<long>()));
                Connect(GDExtensionSignalName.SubscribeItem, _subscribeItemSignalCallable);
            }
            _subscribeItemSignal += value;
        }
        remove
        {
            _subscribeItemSignal -= value;
            if (_subscribeItemSignal is not null) return;
            Disconnect(GDExtensionSignalName.SubscribeItem, _subscribeItemSignalCallable);
            _subscribeItemSignalCallable = default;
        }
    }

    public new delegate void LocalFileChangedSignalHandler();
    private LocalFileChangedSignalHandler _localFileChangedSignal;
    private Callable _localFileChangedSignalCallable;
    public event LocalFileChangedSignalHandler LocalFileChangedSignal
    {
        add
        {
            if (_localFileChangedSignal is null)
            {
                _localFileChangedSignalCallable = Callable.From(() => 
                    _localFileChangedSignal?.Invoke());
                Connect(GDExtensionSignalName.LocalFileChanged, _localFileChangedSignalCallable);
            }
            _localFileChangedSignal += value;
        }
        remove
        {
            _localFileChangedSignal -= value;
            if (_localFileChangedSignal is not null) return;
            Disconnect(GDExtensionSignalName.LocalFileChanged, _localFileChangedSignalCallable);
            _localFileChangedSignalCallable = default;
        }
    }

    public new delegate void ScreenshotReadySignalHandler(long handle, long result);
    private ScreenshotReadySignalHandler _screenshotReadySignal;
    private Callable _screenshotReadySignalCallable;
    public event ScreenshotReadySignalHandler ScreenshotReadySignal
    {
        add
        {
            if (_screenshotReadySignal is null)
            {
                _screenshotReadySignalCallable = Callable.From((Variant handle, Variant result) => 
                    _screenshotReadySignal?.Invoke(handle.As<long>(), result.As<long>()));
                Connect(GDExtensionSignalName.ScreenshotReady, _screenshotReadySignalCallable);
            }
            _screenshotReadySignal += value;
        }
        remove
        {
            _screenshotReadySignal -= value;
            if (_screenshotReadySignal is not null) return;
            Disconnect(GDExtensionSignalName.ScreenshotReady, _screenshotReadySignalCallable);
            _screenshotReadySignalCallable = default;
        }
    }

    public new delegate void ScreenshotRequestedSignalHandler();
    private ScreenshotRequestedSignalHandler _screenshotRequestedSignal;
    private Callable _screenshotRequestedSignalCallable;
    public event ScreenshotRequestedSignalHandler ScreenshotRequestedSignal
    {
        add
        {
            if (_screenshotRequestedSignal is null)
            {
                _screenshotRequestedSignalCallable = Callable.From(() => 
                    _screenshotRequestedSignal?.Invoke());
                Connect(GDExtensionSignalName.ScreenshotRequested, _screenshotRequestedSignalCallable);
            }
            _screenshotRequestedSignal += value;
        }
        remove
        {
            _screenshotRequestedSignal -= value;
            if (_screenshotRequestedSignal is not null) return;
            Disconnect(GDExtensionSignalName.ScreenshotRequested, _screenshotRequestedSignalCallable);
            _screenshotRequestedSignalCallable = default;
        }
    }

    public new delegate void TimelineEventRecordingExistsSignalHandler(long eventId, bool recordingExists);
    private TimelineEventRecordingExistsSignalHandler _timelineEventRecordingExistsSignal;
    private Callable _timelineEventRecordingExistsSignalCallable;
    public event TimelineEventRecordingExistsSignalHandler TimelineEventRecordingExistsSignal
    {
        add
        {
            if (_timelineEventRecordingExistsSignal is null)
            {
                _timelineEventRecordingExistsSignalCallable = Callable.From((Variant eventId, Variant recordingExists) => 
                    _timelineEventRecordingExistsSignal?.Invoke(eventId.As<long>(), recordingExists.As<bool>()));
                Connect(GDExtensionSignalName.TimelineEventRecordingExists, _timelineEventRecordingExistsSignalCallable);
            }
            _timelineEventRecordingExistsSignal += value;
        }
        remove
        {
            _timelineEventRecordingExistsSignal -= value;
            if (_timelineEventRecordingExistsSignal is not null) return;
            Disconnect(GDExtensionSignalName.TimelineEventRecordingExists, _timelineEventRecordingExistsSignalCallable);
            _timelineEventRecordingExistsSignalCallable = default;
        }
    }

    public new delegate void TimelineGamePhaseRecordingExistsSignalHandler(string phaseId, long recordingMs, long longestClipMs, long clipCount, long screenshotCount);
    private TimelineGamePhaseRecordingExistsSignalHandler _timelineGamePhaseRecordingExistsSignal;
    private Callable _timelineGamePhaseRecordingExistsSignalCallable;
    public event TimelineGamePhaseRecordingExistsSignalHandler TimelineGamePhaseRecordingExistsSignal
    {
        add
        {
            if (_timelineGamePhaseRecordingExistsSignal is null)
            {
                _timelineGamePhaseRecordingExistsSignalCallable = Callable.From((Variant phaseId, Variant recordingMs, Variant longestClipMs, Variant clipCount, Variant screenshotCount) => 
                    _timelineGamePhaseRecordingExistsSignal?.Invoke(phaseId.As<string>(), recordingMs.As<long>(), longestClipMs.As<long>(), clipCount.As<long>(), screenshotCount.As<long>()));
                Connect(GDExtensionSignalName.TimelineGamePhaseRecordingExists, _timelineGamePhaseRecordingExistsSignalCallable);
            }
            _timelineGamePhaseRecordingExistsSignal += value;
        }
        remove
        {
            _timelineGamePhaseRecordingExistsSignal -= value;
            if (_timelineGamePhaseRecordingExistsSignal is not null) return;
            Disconnect(GDExtensionSignalName.TimelineGamePhaseRecordingExists, _timelineGamePhaseRecordingExistsSignalCallable);
            _timelineGamePhaseRecordingExistsSignalCallable = default;
        }
    }

    public new delegate void AddAppDependencyResultSignalHandler(long result, long fileId, long appId);
    private AddAppDependencyResultSignalHandler _addAppDependencyResultSignal;
    private Callable _addAppDependencyResultSignalCallable;
    public event AddAppDependencyResultSignalHandler AddAppDependencyResultSignal
    {
        add
        {
            if (_addAppDependencyResultSignal is null)
            {
                _addAppDependencyResultSignalCallable = Callable.From((Variant result, Variant fileId, Variant appId) => 
                    _addAppDependencyResultSignal?.Invoke(result.As<long>(), fileId.As<long>(), appId.As<long>()));
                Connect(GDExtensionSignalName.AddAppDependencyResult, _addAppDependencyResultSignalCallable);
            }
            _addAppDependencyResultSignal += value;
        }
        remove
        {
            _addAppDependencyResultSignal -= value;
            if (_addAppDependencyResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.AddAppDependencyResult, _addAppDependencyResultSignalCallable);
            _addAppDependencyResultSignalCallable = default;
        }
    }

    public new delegate void AddUgcDependencyResultSignalHandler(long result, long fileId, long childId);
    private AddUgcDependencyResultSignalHandler _addUgcDependencyResultSignal;
    private Callable _addUgcDependencyResultSignalCallable;
    public event AddUgcDependencyResultSignalHandler AddUgcDependencyResultSignal
    {
        add
        {
            if (_addUgcDependencyResultSignal is null)
            {
                _addUgcDependencyResultSignalCallable = Callable.From((Variant result, Variant fileId, Variant childId) => 
                    _addUgcDependencyResultSignal?.Invoke(result.As<long>(), fileId.As<long>(), childId.As<long>()));
                Connect(GDExtensionSignalName.AddUgcDependencyResult, _addUgcDependencyResultSignalCallable);
            }
            _addUgcDependencyResultSignal += value;
        }
        remove
        {
            _addUgcDependencyResultSignal -= value;
            if (_addUgcDependencyResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.AddUgcDependencyResult, _addUgcDependencyResultSignalCallable);
            _addUgcDependencyResultSignalCallable = default;
        }
    }

    public new delegate void GetAppDependenciesResultSignalHandler(long result, long fileId, long appDependencies, long totalAppDependencies, int[] appIds);
    private GetAppDependenciesResultSignalHandler _getAppDependenciesResultSignal;
    private Callable _getAppDependenciesResultSignalCallable;
    public event GetAppDependenciesResultSignalHandler GetAppDependenciesResultSignal
    {
        add
        {
            if (_getAppDependenciesResultSignal is null)
            {
                _getAppDependenciesResultSignalCallable = Callable.From((Variant result, Variant fileId, Variant appDependencies, Variant totalAppDependencies, Variant appIds) => 
                    _getAppDependenciesResultSignal?.Invoke(result.As<long>(), fileId.As<long>(), appDependencies.As<long>(), totalAppDependencies.As<long>(), appIds.As<int[]>()));
                Connect(GDExtensionSignalName.GetAppDependenciesResult, _getAppDependenciesResultSignalCallable);
            }
            _getAppDependenciesResultSignal += value;
        }
        remove
        {
            _getAppDependenciesResultSignal -= value;
            if (_getAppDependenciesResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.GetAppDependenciesResult, _getAppDependenciesResultSignalCallable);
            _getAppDependenciesResultSignalCallable = default;
        }
    }

    public new delegate void GetItemVoteResultSignalHandler(long result, long fileId, bool voteUp, bool voteDown, bool voteSkipped);
    private GetItemVoteResultSignalHandler _getItemVoteResultSignal;
    private Callable _getItemVoteResultSignalCallable;
    public event GetItemVoteResultSignalHandler GetItemVoteResultSignal
    {
        add
        {
            if (_getItemVoteResultSignal is null)
            {
                _getItemVoteResultSignalCallable = Callable.From((Variant result, Variant fileId, Variant voteUp, Variant voteDown, Variant voteSkipped) => 
                    _getItemVoteResultSignal?.Invoke(result.As<long>(), fileId.As<long>(), voteUp.As<bool>(), voteDown.As<bool>(), voteSkipped.As<bool>()));
                Connect(GDExtensionSignalName.GetItemVoteResult, _getItemVoteResultSignalCallable);
            }
            _getItemVoteResultSignal += value;
        }
        remove
        {
            _getItemVoteResultSignal -= value;
            if (_getItemVoteResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.GetItemVoteResult, _getItemVoteResultSignalCallable);
            _getItemVoteResultSignalCallable = default;
        }
    }

    public new delegate void ItemCreatedSignalHandler(long result, long fileId, bool acceptTos);
    private ItemCreatedSignalHandler _itemCreatedSignal;
    private Callable _itemCreatedSignalCallable;
    public event ItemCreatedSignalHandler ItemCreatedSignal
    {
        add
        {
            if (_itemCreatedSignal is null)
            {
                _itemCreatedSignalCallable = Callable.From((Variant result, Variant fileId, Variant acceptTos) => 
                    _itemCreatedSignal?.Invoke(result.As<long>(), fileId.As<long>(), acceptTos.As<bool>()));
                Connect(GDExtensionSignalName.ItemCreated, _itemCreatedSignalCallable);
            }
            _itemCreatedSignal += value;
        }
        remove
        {
            _itemCreatedSignal -= value;
            if (_itemCreatedSignal is not null) return;
            Disconnect(GDExtensionSignalName.ItemCreated, _itemCreatedSignalCallable);
            _itemCreatedSignalCallable = default;
        }
    }

    public new delegate void ItemDeletedSignalHandler(long result, long fileId);
    private ItemDeletedSignalHandler _itemDeletedSignal;
    private Callable _itemDeletedSignalCallable;
    public event ItemDeletedSignalHandler ItemDeletedSignal
    {
        add
        {
            if (_itemDeletedSignal is null)
            {
                _itemDeletedSignalCallable = Callable.From((Variant result, Variant fileId) => 
                    _itemDeletedSignal?.Invoke(result.As<long>(), fileId.As<long>()));
                Connect(GDExtensionSignalName.ItemDeleted, _itemDeletedSignalCallable);
            }
            _itemDeletedSignal += value;
        }
        remove
        {
            _itemDeletedSignal -= value;
            if (_itemDeletedSignal is not null) return;
            Disconnect(GDExtensionSignalName.ItemDeleted, _itemDeletedSignalCallable);
            _itemDeletedSignalCallable = default;
        }
    }

    public new delegate void ItemDownloadedSignalHandler(long result, long fileId, long appId);
    private ItemDownloadedSignalHandler _itemDownloadedSignal;
    private Callable _itemDownloadedSignalCallable;
    public event ItemDownloadedSignalHandler ItemDownloadedSignal
    {
        add
        {
            if (_itemDownloadedSignal is null)
            {
                _itemDownloadedSignalCallable = Callable.From((Variant result, Variant fileId, Variant appId) => 
                    _itemDownloadedSignal?.Invoke(result.As<long>(), fileId.As<long>(), appId.As<long>()));
                Connect(GDExtensionSignalName.ItemDownloaded, _itemDownloadedSignalCallable);
            }
            _itemDownloadedSignal += value;
        }
        remove
        {
            _itemDownloadedSignal -= value;
            if (_itemDownloadedSignal is not null) return;
            Disconnect(GDExtensionSignalName.ItemDownloaded, _itemDownloadedSignalCallable);
            _itemDownloadedSignalCallable = default;
        }
    }

    public new delegate void ItemInstalledSignalHandler(long appId, long fileId);
    private ItemInstalledSignalHandler _itemInstalledSignal;
    private Callable _itemInstalledSignalCallable;
    public event ItemInstalledSignalHandler ItemInstalledSignal
    {
        add
        {
            if (_itemInstalledSignal is null)
            {
                _itemInstalledSignalCallable = Callable.From((Variant appId, Variant fileId) => 
                    _itemInstalledSignal?.Invoke(appId.As<long>(), fileId.As<long>()));
                Connect(GDExtensionSignalName.ItemInstalled, _itemInstalledSignalCallable);
            }
            _itemInstalledSignal += value;
        }
        remove
        {
            _itemInstalledSignal -= value;
            if (_itemInstalledSignal is not null) return;
            Disconnect(GDExtensionSignalName.ItemInstalled, _itemInstalledSignalCallable);
            _itemInstalledSignalCallable = default;
        }
    }

    public new delegate void ItemUpdatedSignalHandler(long result, bool needToAcceptTos, long fileId);
    private ItemUpdatedSignalHandler _itemUpdatedSignal;
    private Callable _itemUpdatedSignalCallable;
    public event ItemUpdatedSignalHandler ItemUpdatedSignal
    {
        add
        {
            if (_itemUpdatedSignal is null)
            {
                _itemUpdatedSignalCallable = Callable.From((Variant result, Variant needToAcceptTos, Variant fileId) => 
                    _itemUpdatedSignal?.Invoke(result.As<long>(), needToAcceptTos.As<bool>(), fileId.As<long>()));
                Connect(GDExtensionSignalName.ItemUpdated, _itemUpdatedSignalCallable);
            }
            _itemUpdatedSignal += value;
        }
        remove
        {
            _itemUpdatedSignal -= value;
            if (_itemUpdatedSignal is not null) return;
            Disconnect(GDExtensionSignalName.ItemUpdated, _itemUpdatedSignalCallable);
            _itemUpdatedSignalCallable = default;
        }
    }

    public new delegate void RemoveAppDependencyResultSignalHandler(long result, long fileId, long appId);
    private RemoveAppDependencyResultSignalHandler _removeAppDependencyResultSignal;
    private Callable _removeAppDependencyResultSignalCallable;
    public event RemoveAppDependencyResultSignalHandler RemoveAppDependencyResultSignal
    {
        add
        {
            if (_removeAppDependencyResultSignal is null)
            {
                _removeAppDependencyResultSignalCallable = Callable.From((Variant result, Variant fileId, Variant appId) => 
                    _removeAppDependencyResultSignal?.Invoke(result.As<long>(), fileId.As<long>(), appId.As<long>()));
                Connect(GDExtensionSignalName.RemoveAppDependencyResult, _removeAppDependencyResultSignalCallable);
            }
            _removeAppDependencyResultSignal += value;
        }
        remove
        {
            _removeAppDependencyResultSignal -= value;
            if (_removeAppDependencyResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.RemoveAppDependencyResult, _removeAppDependencyResultSignalCallable);
            _removeAppDependencyResultSignalCallable = default;
        }
    }

    public new delegate void RemoveUgcDependencyResultSignalHandler(long result, long fileId, long childId);
    private RemoveUgcDependencyResultSignalHandler _removeUgcDependencyResultSignal;
    private Callable _removeUgcDependencyResultSignalCallable;
    public event RemoveUgcDependencyResultSignalHandler RemoveUgcDependencyResultSignal
    {
        add
        {
            if (_removeUgcDependencyResultSignal is null)
            {
                _removeUgcDependencyResultSignalCallable = Callable.From((Variant result, Variant fileId, Variant childId) => 
                    _removeUgcDependencyResultSignal?.Invoke(result.As<long>(), fileId.As<long>(), childId.As<long>()));
                Connect(GDExtensionSignalName.RemoveUgcDependencyResult, _removeUgcDependencyResultSignalCallable);
            }
            _removeUgcDependencyResultSignal += value;
        }
        remove
        {
            _removeUgcDependencyResultSignal -= value;
            if (_removeUgcDependencyResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.RemoveUgcDependencyResult, _removeUgcDependencyResultSignalCallable);
            _removeUgcDependencyResultSignalCallable = default;
        }
    }

    public new delegate void SetUserItemVoteSignalHandler(long result, long fileId, bool voteUp);
    private SetUserItemVoteSignalHandler _setUserItemVoteSignal;
    private Callable _setUserItemVoteSignalCallable;
    public event SetUserItemVoteSignalHandler SetUserItemVoteSignal
    {
        add
        {
            if (_setUserItemVoteSignal is null)
            {
                _setUserItemVoteSignalCallable = Callable.From((Variant result, Variant fileId, Variant voteUp) => 
                    _setUserItemVoteSignal?.Invoke(result.As<long>(), fileId.As<long>(), voteUp.As<bool>()));
                Connect(GDExtensionSignalName.SetUserItemVote, _setUserItemVoteSignalCallable);
            }
            _setUserItemVoteSignal += value;
        }
        remove
        {
            _setUserItemVoteSignal -= value;
            if (_setUserItemVoteSignal is not null) return;
            Disconnect(GDExtensionSignalName.SetUserItemVote, _setUserItemVoteSignalCallable);
            _setUserItemVoteSignalCallable = default;
        }
    }

    public new delegate void StartPlaytimeTrackingSignalHandler(long result);
    private StartPlaytimeTrackingSignalHandler _startPlaytimeTrackingSignal;
    private Callable _startPlaytimeTrackingSignalCallable;
    public event StartPlaytimeTrackingSignalHandler StartPlaytimeTrackingSignal
    {
        add
        {
            if (_startPlaytimeTrackingSignal is null)
            {
                _startPlaytimeTrackingSignalCallable = Callable.From((Variant result) => 
                    _startPlaytimeTrackingSignal?.Invoke(result.As<long>()));
                Connect(GDExtensionSignalName.StartPlaytimeTracking, _startPlaytimeTrackingSignalCallable);
            }
            _startPlaytimeTrackingSignal += value;
        }
        remove
        {
            _startPlaytimeTrackingSignal -= value;
            if (_startPlaytimeTrackingSignal is not null) return;
            Disconnect(GDExtensionSignalName.StartPlaytimeTracking, _startPlaytimeTrackingSignalCallable);
            _startPlaytimeTrackingSignalCallable = default;
        }
    }

    public new delegate void StopPlaytimeTrackingSignalHandler(long result);
    private StopPlaytimeTrackingSignalHandler _stopPlaytimeTrackingSignal;
    private Callable _stopPlaytimeTrackingSignalCallable;
    public event StopPlaytimeTrackingSignalHandler StopPlaytimeTrackingSignal
    {
        add
        {
            if (_stopPlaytimeTrackingSignal is null)
            {
                _stopPlaytimeTrackingSignalCallable = Callable.From((Variant result) => 
                    _stopPlaytimeTrackingSignal?.Invoke(result.As<long>()));
                Connect(GDExtensionSignalName.StopPlaytimeTracking, _stopPlaytimeTrackingSignalCallable);
            }
            _stopPlaytimeTrackingSignal += value;
        }
        remove
        {
            _stopPlaytimeTrackingSignal -= value;
            if (_stopPlaytimeTrackingSignal is not null) return;
            Disconnect(GDExtensionSignalName.StopPlaytimeTracking, _stopPlaytimeTrackingSignalCallable);
            _stopPlaytimeTrackingSignalCallable = default;
        }
    }

    public new delegate void UgcQueryCompletedSignalHandler(long handle, long result, long resultsReturned, long totalMatching, bool cached, string nextCursor);
    private UgcQueryCompletedSignalHandler _ugcQueryCompletedSignal;
    private Callable _ugcQueryCompletedSignalCallable;
    public event UgcQueryCompletedSignalHandler UgcQueryCompletedSignal
    {
        add
        {
            if (_ugcQueryCompletedSignal is null)
            {
                _ugcQueryCompletedSignalCallable = Callable.From((Variant handle, Variant result, Variant resultsReturned, Variant totalMatching, Variant cached, Variant nextCursor) => 
                    _ugcQueryCompletedSignal?.Invoke(handle.As<long>(), result.As<long>(), resultsReturned.As<long>(), totalMatching.As<long>(), cached.As<bool>(), nextCursor.As<string>()));
                Connect(GDExtensionSignalName.UgcQueryCompleted, _ugcQueryCompletedSignalCallable);
            }
            _ugcQueryCompletedSignal += value;
        }
        remove
        {
            _ugcQueryCompletedSignal -= value;
            if (_ugcQueryCompletedSignal is not null) return;
            Disconnect(GDExtensionSignalName.UgcQueryCompleted, _ugcQueryCompletedSignalCallable);
            _ugcQueryCompletedSignalCallable = default;
        }
    }

    public new delegate void UserFavoriteItemsListChangedSignalHandler(long result, long fileId, bool wasAddRequest);
    private UserFavoriteItemsListChangedSignalHandler _userFavoriteItemsListChangedSignal;
    private Callable _userFavoriteItemsListChangedSignalCallable;
    public event UserFavoriteItemsListChangedSignalHandler UserFavoriteItemsListChangedSignal
    {
        add
        {
            if (_userFavoriteItemsListChangedSignal is null)
            {
                _userFavoriteItemsListChangedSignalCallable = Callable.From((Variant result, Variant fileId, Variant wasAddRequest) => 
                    _userFavoriteItemsListChangedSignal?.Invoke(result.As<long>(), fileId.As<long>(), wasAddRequest.As<bool>()));
                Connect(GDExtensionSignalName.UserFavoriteItemsListChanged, _userFavoriteItemsListChangedSignalCallable);
            }
            _userFavoriteItemsListChangedSignal += value;
        }
        remove
        {
            _userFavoriteItemsListChangedSignal -= value;
            if (_userFavoriteItemsListChangedSignal is not null) return;
            Disconnect(GDExtensionSignalName.UserFavoriteItemsListChanged, _userFavoriteItemsListChangedSignalCallable);
            _userFavoriteItemsListChangedSignalCallable = default;
        }
    }

    public new delegate void UserSubscribedItemsListChangedSignalHandler(long appId);
    private UserSubscribedItemsListChangedSignalHandler _userSubscribedItemsListChangedSignal;
    private Callable _userSubscribedItemsListChangedSignalCallable;
    public event UserSubscribedItemsListChangedSignalHandler UserSubscribedItemsListChangedSignal
    {
        add
        {
            if (_userSubscribedItemsListChangedSignal is null)
            {
                _userSubscribedItemsListChangedSignalCallable = Callable.From((Variant appId) => 
                    _userSubscribedItemsListChangedSignal?.Invoke(appId.As<long>()));
                Connect(GDExtensionSignalName.UserSubscribedItemsListChanged, _userSubscribedItemsListChangedSignalCallable);
            }
            _userSubscribedItemsListChangedSignal += value;
        }
        remove
        {
            _userSubscribedItemsListChangedSignal -= value;
            if (_userSubscribedItemsListChangedSignal is not null) return;
            Disconnect(GDExtensionSignalName.UserSubscribedItemsListChanged, _userSubscribedItemsListChangedSignalCallable);
            _userSubscribedItemsListChangedSignalCallable = default;
        }
    }

    public new delegate void WorkshopEulaStatusSignalHandler(long result, long appId, Godot.Collections.Dictionary eulaData);
    private WorkshopEulaStatusSignalHandler _workshopEulaStatusSignal;
    private Callable _workshopEulaStatusSignalCallable;
    public event WorkshopEulaStatusSignalHandler WorkshopEulaStatusSignal
    {
        add
        {
            if (_workshopEulaStatusSignal is null)
            {
                _workshopEulaStatusSignalCallable = Callable.From((Variant result, Variant appId, Variant eulaData) => 
                    _workshopEulaStatusSignal?.Invoke(result.As<long>(), appId.As<long>(), eulaData.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.WorkshopEulaStatus, _workshopEulaStatusSignalCallable);
            }
            _workshopEulaStatusSignal += value;
        }
        remove
        {
            _workshopEulaStatusSignal -= value;
            if (_workshopEulaStatusSignal is not null) return;
            Disconnect(GDExtensionSignalName.WorkshopEulaStatus, _workshopEulaStatusSignalCallable);
            _workshopEulaStatusSignalCallable = default;
        }
    }

    public new delegate void ClientGameServerDenySignalHandler(long appId, string serverIp, long serverPort, long secure, long reason);
    private ClientGameServerDenySignalHandler _clientGameServerDenySignal;
    private Callable _clientGameServerDenySignalCallable;
    public event ClientGameServerDenySignalHandler ClientGameServerDenySignal
    {
        add
        {
            if (_clientGameServerDenySignal is null)
            {
                _clientGameServerDenySignalCallable = Callable.From((Variant appId, Variant serverIp, Variant serverPort, Variant secure, Variant reason) => 
                    _clientGameServerDenySignal?.Invoke(appId.As<long>(), serverIp.As<string>(), serverPort.As<long>(), secure.As<long>(), reason.As<long>()));
                Connect(GDExtensionSignalName.ClientGameServerDeny, _clientGameServerDenySignalCallable);
            }
            _clientGameServerDenySignal += value;
        }
        remove
        {
            _clientGameServerDenySignal -= value;
            if (_clientGameServerDenySignal is not null) return;
            Disconnect(GDExtensionSignalName.ClientGameServerDeny, _clientGameServerDenySignalCallable);
            _clientGameServerDenySignalCallable = default;
        }
    }

    public new delegate void DurationControlSignalHandler(long result, Godot.Collections.Dictionary duration);
    private DurationControlSignalHandler _durationControlSignal;
    private Callable _durationControlSignalCallable;
    public event DurationControlSignalHandler DurationControlSignal
    {
        add
        {
            if (_durationControlSignal is null)
            {
                _durationControlSignalCallable = Callable.From((Variant result, Variant duration) => 
                    _durationControlSignal?.Invoke(result.As<long>(), duration.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.DurationControl, _durationControlSignalCallable);
            }
            _durationControlSignal += value;
        }
        remove
        {
            _durationControlSignal -= value;
            if (_durationControlSignal is not null) return;
            Disconnect(GDExtensionSignalName.DurationControl, _durationControlSignalCallable);
            _durationControlSignalCallable = default;
        }
    }

    public new delegate void EncryptedAppTicketResponseSignalHandler(long result);
    private EncryptedAppTicketResponseSignalHandler _encryptedAppTicketResponseSignal;
    private Callable _encryptedAppTicketResponseSignalCallable;
    public event EncryptedAppTicketResponseSignalHandler EncryptedAppTicketResponseSignal
    {
        add
        {
            if (_encryptedAppTicketResponseSignal is null)
            {
                _encryptedAppTicketResponseSignalCallable = Callable.From((Variant result) => 
                    _encryptedAppTicketResponseSignal?.Invoke(result.As<long>()));
                Connect(GDExtensionSignalName.EncryptedAppTicketResponse, _encryptedAppTicketResponseSignalCallable);
            }
            _encryptedAppTicketResponseSignal += value;
        }
        remove
        {
            _encryptedAppTicketResponseSignal -= value;
            if (_encryptedAppTicketResponseSignal is not null) return;
            Disconnect(GDExtensionSignalName.EncryptedAppTicketResponse, _encryptedAppTicketResponseSignalCallable);
            _encryptedAppTicketResponseSignalCallable = default;
        }
    }

    public new delegate void GameWebCallbackSignalHandler(string url);
    private GameWebCallbackSignalHandler _gameWebCallbackSignal;
    private Callable _gameWebCallbackSignalCallable;
    public event GameWebCallbackSignalHandler GameWebCallbackSignal
    {
        add
        {
            if (_gameWebCallbackSignal is null)
            {
                _gameWebCallbackSignalCallable = Callable.From((Variant url) => 
                    _gameWebCallbackSignal?.Invoke(url.As<string>()));
                Connect(GDExtensionSignalName.GameWebCallback, _gameWebCallbackSignalCallable);
            }
            _gameWebCallbackSignal += value;
        }
        remove
        {
            _gameWebCallbackSignal -= value;
            if (_gameWebCallbackSignal is not null) return;
            Disconnect(GDExtensionSignalName.GameWebCallback, _gameWebCallbackSignalCallable);
            _gameWebCallbackSignalCallable = default;
        }
    }

    public new delegate void GetAuthSessionTicketResponseSignalHandler(long authTicket, long result);
    private GetAuthSessionTicketResponseSignalHandler _getAuthSessionTicketResponseSignal;
    private Callable _getAuthSessionTicketResponseSignalCallable;
    public event GetAuthSessionTicketResponseSignalHandler GetAuthSessionTicketResponseSignal
    {
        add
        {
            if (_getAuthSessionTicketResponseSignal is null)
            {
                _getAuthSessionTicketResponseSignalCallable = Callable.From((Variant authTicket, Variant result) => 
                    _getAuthSessionTicketResponseSignal?.Invoke(authTicket.As<long>(), result.As<long>()));
                Connect(GDExtensionSignalName.GetAuthSessionTicketResponse, _getAuthSessionTicketResponseSignalCallable);
            }
            _getAuthSessionTicketResponseSignal += value;
        }
        remove
        {
            _getAuthSessionTicketResponseSignal -= value;
            if (_getAuthSessionTicketResponseSignal is not null) return;
            Disconnect(GDExtensionSignalName.GetAuthSessionTicketResponse, _getAuthSessionTicketResponseSignalCallable);
            _getAuthSessionTicketResponseSignalCallable = default;
        }
    }

    public new delegate void GetTicketForWebApiSignalHandler(long authTicket, long result, long ticketSize, byte[] ticketBuffer);
    private GetTicketForWebApiSignalHandler _getTicketForWebApiSignal;
    private Callable _getTicketForWebApiSignalCallable;
    public event GetTicketForWebApiSignalHandler GetTicketForWebApiSignal
    {
        add
        {
            if (_getTicketForWebApiSignal is null)
            {
                _getTicketForWebApiSignalCallable = Callable.From((Variant authTicket, Variant result, Variant ticketSize, Variant ticketBuffer) => 
                    _getTicketForWebApiSignal?.Invoke(authTicket.As<long>(), result.As<long>(), ticketSize.As<long>(), ticketBuffer.As<byte[]>()));
                Connect(GDExtensionSignalName.GetTicketForWebApi, _getTicketForWebApiSignalCallable);
            }
            _getTicketForWebApiSignal += value;
        }
        remove
        {
            _getTicketForWebApiSignal -= value;
            if (_getTicketForWebApiSignal is not null) return;
            Disconnect(GDExtensionSignalName.GetTicketForWebApi, _getTicketForWebApiSignalCallable);
            _getTicketForWebApiSignalCallable = default;
        }
    }

    public new delegate void IpcFailureSignalHandler(long type);
    private IpcFailureSignalHandler _ipcFailureSignal;
    private Callable _ipcFailureSignalCallable;
    public event IpcFailureSignalHandler IpcFailureSignal
    {
        add
        {
            if (_ipcFailureSignal is null)
            {
                _ipcFailureSignalCallable = Callable.From((Variant type) => 
                    _ipcFailureSignal?.Invoke(type.As<long>()));
                Connect(GDExtensionSignalName.IpcFailure, _ipcFailureSignalCallable);
            }
            _ipcFailureSignal += value;
        }
        remove
        {
            _ipcFailureSignal -= value;
            if (_ipcFailureSignal is not null) return;
            Disconnect(GDExtensionSignalName.IpcFailure, _ipcFailureSignalCallable);
            _ipcFailureSignalCallable = default;
        }
    }

    public new delegate void LicensesUpdatedSignalHandler();
    private LicensesUpdatedSignalHandler _licensesUpdatedSignal;
    private Callable _licensesUpdatedSignalCallable;
    public event LicensesUpdatedSignalHandler LicensesUpdatedSignal
    {
        add
        {
            if (_licensesUpdatedSignal is null)
            {
                _licensesUpdatedSignalCallable = Callable.From(() => 
                    _licensesUpdatedSignal?.Invoke());
                Connect(GDExtensionSignalName.LicensesUpdated, _licensesUpdatedSignalCallable);
            }
            _licensesUpdatedSignal += value;
        }
        remove
        {
            _licensesUpdatedSignal -= value;
            if (_licensesUpdatedSignal is not null) return;
            Disconnect(GDExtensionSignalName.LicensesUpdated, _licensesUpdatedSignalCallable);
            _licensesUpdatedSignalCallable = default;
        }
    }

    public new delegate void MarketEligibilityResponseSignalHandler(bool isAllowed, long disallowReason, long allowedAtTime, long steamGuardRequiredDays, long newDeviceCooldown);
    private MarketEligibilityResponseSignalHandler _marketEligibilityResponseSignal;
    private Callable _marketEligibilityResponseSignalCallable;
    public event MarketEligibilityResponseSignalHandler MarketEligibilityResponseSignal
    {
        add
        {
            if (_marketEligibilityResponseSignal is null)
            {
                _marketEligibilityResponseSignalCallable = Callable.From((Variant isAllowed, Variant disallowReason, Variant allowedAtTime, Variant steamGuardRequiredDays, Variant newDeviceCooldown) => 
                    _marketEligibilityResponseSignal?.Invoke(isAllowed.As<bool>(), disallowReason.As<long>(), allowedAtTime.As<long>(), steamGuardRequiredDays.As<long>(), newDeviceCooldown.As<long>()));
                Connect(GDExtensionSignalName.MarketEligibilityResponse, _marketEligibilityResponseSignalCallable);
            }
            _marketEligibilityResponseSignal += value;
        }
        remove
        {
            _marketEligibilityResponseSignal -= value;
            if (_marketEligibilityResponseSignal is not null) return;
            Disconnect(GDExtensionSignalName.MarketEligibilityResponse, _marketEligibilityResponseSignalCallable);
            _marketEligibilityResponseSignalCallable = default;
        }
    }

    public new delegate void MicrotransactionAuthResponseSignalHandler(long appId, long orderId, bool authorized);
    private MicrotransactionAuthResponseSignalHandler _microtransactionAuthResponseSignal;
    private Callable _microtransactionAuthResponseSignalCallable;
    public event MicrotransactionAuthResponseSignalHandler MicrotransactionAuthResponseSignal
    {
        add
        {
            if (_microtransactionAuthResponseSignal is null)
            {
                _microtransactionAuthResponseSignalCallable = Callable.From((Variant appId, Variant orderId, Variant authorized) => 
                    _microtransactionAuthResponseSignal?.Invoke(appId.As<long>(), orderId.As<long>(), authorized.As<bool>()));
                Connect(GDExtensionSignalName.MicrotransactionAuthResponse, _microtransactionAuthResponseSignalCallable);
            }
            _microtransactionAuthResponseSignal += value;
        }
        remove
        {
            _microtransactionAuthResponseSignal -= value;
            if (_microtransactionAuthResponseSignal is not null) return;
            Disconnect(GDExtensionSignalName.MicrotransactionAuthResponse, _microtransactionAuthResponseSignalCallable);
            _microtransactionAuthResponseSignalCallable = default;
        }
    }

    public new delegate void SteamServerConnectFailedSignalHandler(long result, bool retrying);
    private SteamServerConnectFailedSignalHandler _steamServerConnectFailedSignal;
    private Callable _steamServerConnectFailedSignalCallable;
    public event SteamServerConnectFailedSignalHandler SteamServerConnectFailedSignal
    {
        add
        {
            if (_steamServerConnectFailedSignal is null)
            {
                _steamServerConnectFailedSignalCallable = Callable.From((Variant result, Variant retrying) => 
                    _steamServerConnectFailedSignal?.Invoke(result.As<long>(), retrying.As<bool>()));
                Connect(GDExtensionSignalName.SteamServerConnectFailed, _steamServerConnectFailedSignalCallable);
            }
            _steamServerConnectFailedSignal += value;
        }
        remove
        {
            _steamServerConnectFailedSignal -= value;
            if (_steamServerConnectFailedSignal is not null) return;
            Disconnect(GDExtensionSignalName.SteamServerConnectFailed, _steamServerConnectFailedSignalCallable);
            _steamServerConnectFailedSignalCallable = default;
        }
    }

    public new delegate void SteamServerConnectedSignalHandler();
    private SteamServerConnectedSignalHandler _steamServerConnectedSignal;
    private Callable _steamServerConnectedSignalCallable;
    public event SteamServerConnectedSignalHandler SteamServerConnectedSignal
    {
        add
        {
            if (_steamServerConnectedSignal is null)
            {
                _steamServerConnectedSignalCallable = Callable.From(() => 
                    _steamServerConnectedSignal?.Invoke());
                Connect(GDExtensionSignalName.SteamServerConnected, _steamServerConnectedSignalCallable);
            }
            _steamServerConnectedSignal += value;
        }
        remove
        {
            _steamServerConnectedSignal -= value;
            if (_steamServerConnectedSignal is not null) return;
            Disconnect(GDExtensionSignalName.SteamServerConnected, _steamServerConnectedSignalCallable);
            _steamServerConnectedSignalCallable = default;
        }
    }

    public new delegate void SteamServerDisconnectedSignalHandler(long result);
    private SteamServerDisconnectedSignalHandler _steamServerDisconnectedSignal;
    private Callable _steamServerDisconnectedSignalCallable;
    public event SteamServerDisconnectedSignalHandler SteamServerDisconnectedSignal
    {
        add
        {
            if (_steamServerDisconnectedSignal is null)
            {
                _steamServerDisconnectedSignalCallable = Callable.From((Variant result) => 
                    _steamServerDisconnectedSignal?.Invoke(result.As<long>()));
                Connect(GDExtensionSignalName.SteamServerDisconnected, _steamServerDisconnectedSignalCallable);
            }
            _steamServerDisconnectedSignal += value;
        }
        remove
        {
            _steamServerDisconnectedSignal -= value;
            if (_steamServerDisconnectedSignal is not null) return;
            Disconnect(GDExtensionSignalName.SteamServerDisconnected, _steamServerDisconnectedSignalCallable);
            _steamServerDisconnectedSignalCallable = default;
        }
    }

    public new delegate void StoreAuthUrlResponseSignalHandler(string url);
    private StoreAuthUrlResponseSignalHandler _storeAuthUrlResponseSignal;
    private Callable _storeAuthUrlResponseSignalCallable;
    public event StoreAuthUrlResponseSignalHandler StoreAuthUrlResponseSignal
    {
        add
        {
            if (_storeAuthUrlResponseSignal is null)
            {
                _storeAuthUrlResponseSignalCallable = Callable.From((Variant url) => 
                    _storeAuthUrlResponseSignal?.Invoke(url.As<string>()));
                Connect(GDExtensionSignalName.StoreAuthUrlResponse, _storeAuthUrlResponseSignalCallable);
            }
            _storeAuthUrlResponseSignal += value;
        }
        remove
        {
            _storeAuthUrlResponseSignal -= value;
            if (_storeAuthUrlResponseSignal is not null) return;
            Disconnect(GDExtensionSignalName.StoreAuthUrlResponse, _storeAuthUrlResponseSignalCallable);
            _storeAuthUrlResponseSignalCallable = default;
        }
    }

    public new delegate void ValidateAuthTicketResponseSignalHandler(long authId, long response, long ownerId);
    private ValidateAuthTicketResponseSignalHandler _validateAuthTicketResponseSignal;
    private Callable _validateAuthTicketResponseSignalCallable;
    public event ValidateAuthTicketResponseSignalHandler ValidateAuthTicketResponseSignal
    {
        add
        {
            if (_validateAuthTicketResponseSignal is null)
            {
                _validateAuthTicketResponseSignalCallable = Callable.From((Variant authId, Variant response, Variant ownerId) => 
                    _validateAuthTicketResponseSignal?.Invoke(authId.As<long>(), response.As<long>(), ownerId.As<long>()));
                Connect(GDExtensionSignalName.ValidateAuthTicketResponse, _validateAuthTicketResponseSignalCallable);
            }
            _validateAuthTicketResponseSignal += value;
        }
        remove
        {
            _validateAuthTicketResponseSignal -= value;
            if (_validateAuthTicketResponseSignal is not null) return;
            Disconnect(GDExtensionSignalName.ValidateAuthTicketResponse, _validateAuthTicketResponseSignalCallable);
            _validateAuthTicketResponseSignalCallable = default;
        }
    }

    public new delegate void GlobalAchievementPercentagesReadySignalHandler(long gameId, long result);
    private GlobalAchievementPercentagesReadySignalHandler _globalAchievementPercentagesReadySignal;
    private Callable _globalAchievementPercentagesReadySignalCallable;
    public event GlobalAchievementPercentagesReadySignalHandler GlobalAchievementPercentagesReadySignal
    {
        add
        {
            if (_globalAchievementPercentagesReadySignal is null)
            {
                _globalAchievementPercentagesReadySignalCallable = Callable.From((Variant gameId, Variant result) => 
                    _globalAchievementPercentagesReadySignal?.Invoke(gameId.As<long>(), result.As<long>()));
                Connect(GDExtensionSignalName.GlobalAchievementPercentagesReady, _globalAchievementPercentagesReadySignalCallable);
            }
            _globalAchievementPercentagesReadySignal += value;
        }
        remove
        {
            _globalAchievementPercentagesReadySignal -= value;
            if (_globalAchievementPercentagesReadySignal is not null) return;
            Disconnect(GDExtensionSignalName.GlobalAchievementPercentagesReady, _globalAchievementPercentagesReadySignalCallable);
            _globalAchievementPercentagesReadySignalCallable = default;
        }
    }

    public new delegate void GlobalStatsReceivedSignalHandler(long gameId, long result);
    private GlobalStatsReceivedSignalHandler _globalStatsReceivedSignal;
    private Callable _globalStatsReceivedSignalCallable;
    public event GlobalStatsReceivedSignalHandler GlobalStatsReceivedSignal
    {
        add
        {
            if (_globalStatsReceivedSignal is null)
            {
                _globalStatsReceivedSignalCallable = Callable.From((Variant gameId, Variant result) => 
                    _globalStatsReceivedSignal?.Invoke(gameId.As<long>(), result.As<long>()));
                Connect(GDExtensionSignalName.GlobalStatsReceived, _globalStatsReceivedSignalCallable);
            }
            _globalStatsReceivedSignal += value;
        }
        remove
        {
            _globalStatsReceivedSignal -= value;
            if (_globalStatsReceivedSignal is not null) return;
            Disconnect(GDExtensionSignalName.GlobalStatsReceived, _globalStatsReceivedSignalCallable);
            _globalStatsReceivedSignalCallable = default;
        }
    }

    public new delegate void LeaderboardFindResultSignalHandler(long leaderboardHandle, long found);
    private LeaderboardFindResultSignalHandler _leaderboardFindResultSignal;
    private Callable _leaderboardFindResultSignalCallable;
    public event LeaderboardFindResultSignalHandler LeaderboardFindResultSignal
    {
        add
        {
            if (_leaderboardFindResultSignal is null)
            {
                _leaderboardFindResultSignalCallable = Callable.From((Variant leaderboardHandle, Variant found) => 
                    _leaderboardFindResultSignal?.Invoke(leaderboardHandle.As<long>(), found.As<long>()));
                Connect(GDExtensionSignalName.LeaderboardFindResult, _leaderboardFindResultSignalCallable);
            }
            _leaderboardFindResultSignal += value;
        }
        remove
        {
            _leaderboardFindResultSignal -= value;
            if (_leaderboardFindResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.LeaderboardFindResult, _leaderboardFindResultSignalCallable);
            _leaderboardFindResultSignalCallable = default;
        }
    }

    public new delegate void LeaderboardScoresDownloadedSignalHandler(string message, long leaderboardHandle, Godot.Collections.Array leaderboardEntries);
    private LeaderboardScoresDownloadedSignalHandler _leaderboardScoresDownloadedSignal;
    private Callable _leaderboardScoresDownloadedSignalCallable;
    public event LeaderboardScoresDownloadedSignalHandler LeaderboardScoresDownloadedSignal
    {
        add
        {
            if (_leaderboardScoresDownloadedSignal is null)
            {
                _leaderboardScoresDownloadedSignalCallable = Callable.From((Variant message, Variant leaderboardHandle, Variant leaderboardEntries) => 
                    _leaderboardScoresDownloadedSignal?.Invoke(message.As<string>(), leaderboardHandle.As<long>(), leaderboardEntries.As<Godot.Collections.Array>()));
                Connect(GDExtensionSignalName.LeaderboardScoresDownloaded, _leaderboardScoresDownloadedSignalCallable);
            }
            _leaderboardScoresDownloadedSignal += value;
        }
        remove
        {
            _leaderboardScoresDownloadedSignal -= value;
            if (_leaderboardScoresDownloadedSignal is not null) return;
            Disconnect(GDExtensionSignalName.LeaderboardScoresDownloaded, _leaderboardScoresDownloadedSignalCallable);
            _leaderboardScoresDownloadedSignalCallable = default;
        }
    }

    public new delegate void LeaderboardScoreUploadedSignalHandler(bool success, long thisHandle, Godot.Collections.Dictionary thisScore);
    private LeaderboardScoreUploadedSignalHandler _leaderboardScoreUploadedSignal;
    private Callable _leaderboardScoreUploadedSignalCallable;
    public event LeaderboardScoreUploadedSignalHandler LeaderboardScoreUploadedSignal
    {
        add
        {
            if (_leaderboardScoreUploadedSignal is null)
            {
                _leaderboardScoreUploadedSignalCallable = Callable.From((Variant success, Variant thisHandle, Variant thisScore) => 
                    _leaderboardScoreUploadedSignal?.Invoke(success.As<bool>(), thisHandle.As<long>(), thisScore.As<Godot.Collections.Dictionary>()));
                Connect(GDExtensionSignalName.LeaderboardScoreUploaded, _leaderboardScoreUploadedSignalCallable);
            }
            _leaderboardScoreUploadedSignal += value;
        }
        remove
        {
            _leaderboardScoreUploadedSignal -= value;
            if (_leaderboardScoreUploadedSignal is not null) return;
            Disconnect(GDExtensionSignalName.LeaderboardScoreUploaded, _leaderboardScoreUploadedSignalCallable);
            _leaderboardScoreUploadedSignalCallable = default;
        }
    }

    public new delegate void LeaderboardUgcSetSignalHandler(long leaderboardHandle, long result);
    private LeaderboardUgcSetSignalHandler _leaderboardUgcSetSignal;
    private Callable _leaderboardUgcSetSignalCallable;
    public event LeaderboardUgcSetSignalHandler LeaderboardUgcSetSignal
    {
        add
        {
            if (_leaderboardUgcSetSignal is null)
            {
                _leaderboardUgcSetSignalCallable = Callable.From((Variant leaderboardHandle, Variant result) => 
                    _leaderboardUgcSetSignal?.Invoke(leaderboardHandle.As<long>(), result.As<long>()));
                Connect(GDExtensionSignalName.LeaderboardUgcSet, _leaderboardUgcSetSignalCallable);
            }
            _leaderboardUgcSetSignal += value;
        }
        remove
        {
            _leaderboardUgcSetSignal -= value;
            if (_leaderboardUgcSetSignal is not null) return;
            Disconnect(GDExtensionSignalName.LeaderboardUgcSet, _leaderboardUgcSetSignalCallable);
            _leaderboardUgcSetSignalCallable = default;
        }
    }

    public new delegate void NumberOfCurrentPlayersSignalHandler(long success, long players);
    private NumberOfCurrentPlayersSignalHandler _numberOfCurrentPlayersSignal;
    private Callable _numberOfCurrentPlayersSignalCallable;
    public event NumberOfCurrentPlayersSignalHandler NumberOfCurrentPlayersSignal
    {
        add
        {
            if (_numberOfCurrentPlayersSignal is null)
            {
                _numberOfCurrentPlayersSignalCallable = Callable.From((Variant success, Variant players) => 
                    _numberOfCurrentPlayersSignal?.Invoke(success.As<long>(), players.As<long>()));
                Connect(GDExtensionSignalName.NumberOfCurrentPlayers, _numberOfCurrentPlayersSignalCallable);
            }
            _numberOfCurrentPlayersSignal += value;
        }
        remove
        {
            _numberOfCurrentPlayersSignal -= value;
            if (_numberOfCurrentPlayersSignal is not null) return;
            Disconnect(GDExtensionSignalName.NumberOfCurrentPlayers, _numberOfCurrentPlayersSignalCallable);
            _numberOfCurrentPlayersSignalCallable = default;
        }
    }

    public new delegate void UserAchievementIconFetchedSignalHandler(long gameId, string achievementName, bool wasAchieved, long iconHandle);
    private UserAchievementIconFetchedSignalHandler _userAchievementIconFetchedSignal;
    private Callable _userAchievementIconFetchedSignalCallable;
    public event UserAchievementIconFetchedSignalHandler UserAchievementIconFetchedSignal
    {
        add
        {
            if (_userAchievementIconFetchedSignal is null)
            {
                _userAchievementIconFetchedSignalCallable = Callable.From((Variant gameId, Variant achievementName, Variant wasAchieved, Variant iconHandle) => 
                    _userAchievementIconFetchedSignal?.Invoke(gameId.As<long>(), achievementName.As<string>(), wasAchieved.As<bool>(), iconHandle.As<long>()));
                Connect(GDExtensionSignalName.UserAchievementIconFetched, _userAchievementIconFetchedSignalCallable);
            }
            _userAchievementIconFetchedSignal += value;
        }
        remove
        {
            _userAchievementIconFetchedSignal -= value;
            if (_userAchievementIconFetchedSignal is not null) return;
            Disconnect(GDExtensionSignalName.UserAchievementIconFetched, _userAchievementIconFetchedSignalCallable);
            _userAchievementIconFetchedSignalCallable = default;
        }
    }

    public new delegate void UserAchievementStoredSignalHandler(long gameId, bool groupAchieve, string achievementName, long currentProgress, long maxProgress);
    private UserAchievementStoredSignalHandler _userAchievementStoredSignal;
    private Callable _userAchievementStoredSignalCallable;
    public event UserAchievementStoredSignalHandler UserAchievementStoredSignal
    {
        add
        {
            if (_userAchievementStoredSignal is null)
            {
                _userAchievementStoredSignalCallable = Callable.From((Variant gameId, Variant groupAchieve, Variant achievementName, Variant currentProgress, Variant maxProgress) => 
                    _userAchievementStoredSignal?.Invoke(gameId.As<long>(), groupAchieve.As<bool>(), achievementName.As<string>(), currentProgress.As<long>(), maxProgress.As<long>()));
                Connect(GDExtensionSignalName.UserAchievementStored, _userAchievementStoredSignalCallable);
            }
            _userAchievementStoredSignal += value;
        }
        remove
        {
            _userAchievementStoredSignal -= value;
            if (_userAchievementStoredSignal is not null) return;
            Disconnect(GDExtensionSignalName.UserAchievementStored, _userAchievementStoredSignalCallable);
            _userAchievementStoredSignalCallable = default;
        }
    }

    public new delegate void UserStatsReceivedSignalHandler(long gameId, long result, long userId);
    private UserStatsReceivedSignalHandler _userStatsReceivedSignal;
    private Callable _userStatsReceivedSignalCallable;
    public event UserStatsReceivedSignalHandler UserStatsReceivedSignal
    {
        add
        {
            if (_userStatsReceivedSignal is null)
            {
                _userStatsReceivedSignalCallable = Callable.From((Variant gameId, Variant result, Variant userId) => 
                    _userStatsReceivedSignal?.Invoke(gameId.As<long>(), result.As<long>(), userId.As<long>()));
                Connect(GDExtensionSignalName.UserStatsReceived, _userStatsReceivedSignalCallable);
            }
            _userStatsReceivedSignal += value;
        }
        remove
        {
            _userStatsReceivedSignal -= value;
            if (_userStatsReceivedSignal is not null) return;
            Disconnect(GDExtensionSignalName.UserStatsReceived, _userStatsReceivedSignalCallable);
            _userStatsReceivedSignalCallable = default;
        }
    }

    public new delegate void UserStatsStoredSignalHandler(long gameId, long result);
    private UserStatsStoredSignalHandler _userStatsStoredSignal;
    private Callable _userStatsStoredSignalCallable;
    public event UserStatsStoredSignalHandler UserStatsStoredSignal
    {
        add
        {
            if (_userStatsStoredSignal is null)
            {
                _userStatsStoredSignalCallable = Callable.From((Variant gameId, Variant result) => 
                    _userStatsStoredSignal?.Invoke(gameId.As<long>(), result.As<long>()));
                Connect(GDExtensionSignalName.UserStatsStored, _userStatsStoredSignalCallable);
            }
            _userStatsStoredSignal += value;
        }
        remove
        {
            _userStatsStoredSignal -= value;
            if (_userStatsStoredSignal is not null) return;
            Disconnect(GDExtensionSignalName.UserStatsStored, _userStatsStoredSignalCallable);
            _userStatsStoredSignalCallable = default;
        }
    }

    public new delegate void UserStatsUnloadedSignalHandler(long userId);
    private UserStatsUnloadedSignalHandler _userStatsUnloadedSignal;
    private Callable _userStatsUnloadedSignalCallable;
    public event UserStatsUnloadedSignalHandler UserStatsUnloadedSignal
    {
        add
        {
            if (_userStatsUnloadedSignal is null)
            {
                _userStatsUnloadedSignalCallable = Callable.From((Variant userId) => 
                    _userStatsUnloadedSignal?.Invoke(userId.As<long>()));
                Connect(GDExtensionSignalName.UserStatsUnloaded, _userStatsUnloadedSignalCallable);
            }
            _userStatsUnloadedSignal += value;
        }
        remove
        {
            _userStatsUnloadedSignal -= value;
            if (_userStatsUnloadedSignal is not null) return;
            Disconnect(GDExtensionSignalName.UserStatsUnloaded, _userStatsUnloadedSignalCallable);
            _userStatsUnloadedSignalCallable = default;
        }
    }

    public new delegate void CheckFileSignatureSignalHandler(long signature);
    private CheckFileSignatureSignalHandler _checkFileSignatureSignal;
    private Callable _checkFileSignatureSignalCallable;
    public event CheckFileSignatureSignalHandler CheckFileSignatureSignal
    {
        add
        {
            if (_checkFileSignatureSignal is null)
            {
                _checkFileSignatureSignalCallable = Callable.From((Variant signature) => 
                    _checkFileSignatureSignal?.Invoke(signature.As<long>()));
                Connect(GDExtensionSignalName.CheckFileSignature, _checkFileSignatureSignalCallable);
            }
            _checkFileSignatureSignal += value;
        }
        remove
        {
            _checkFileSignatureSignal -= value;
            if (_checkFileSignatureSignal is not null) return;
            Disconnect(GDExtensionSignalName.CheckFileSignature, _checkFileSignatureSignalCallable);
            _checkFileSignatureSignalCallable = default;
        }
    }

    public new delegate void GamepadTextInputDismissedSignalHandler(bool submitted, string enteredText, long appId);
    private GamepadTextInputDismissedSignalHandler _gamepadTextInputDismissedSignal;
    private Callable _gamepadTextInputDismissedSignalCallable;
    public event GamepadTextInputDismissedSignalHandler GamepadTextInputDismissedSignal
    {
        add
        {
            if (_gamepadTextInputDismissedSignal is null)
            {
                _gamepadTextInputDismissedSignalCallable = Callable.From((Variant submitted, Variant enteredText, Variant appId) => 
                    _gamepadTextInputDismissedSignal?.Invoke(submitted.As<bool>(), enteredText.As<string>(), appId.As<long>()));
                Connect(GDExtensionSignalName.GamepadTextInputDismissed, _gamepadTextInputDismissedSignalCallable);
            }
            _gamepadTextInputDismissedSignal += value;
        }
        remove
        {
            _gamepadTextInputDismissedSignal -= value;
            if (_gamepadTextInputDismissedSignal is not null) return;
            Disconnect(GDExtensionSignalName.GamepadTextInputDismissed, _gamepadTextInputDismissedSignalCallable);
            _gamepadTextInputDismissedSignalCallable = default;
        }
    }

    public new delegate void IpCountrySignalHandler();
    private IpCountrySignalHandler _ipCountrySignal;
    private Callable _ipCountrySignalCallable;
    public event IpCountrySignalHandler IpCountrySignal
    {
        add
        {
            if (_ipCountrySignal is null)
            {
                _ipCountrySignalCallable = Callable.From(() => 
                    _ipCountrySignal?.Invoke());
                Connect(GDExtensionSignalName.IpCountry, _ipCountrySignalCallable);
            }
            _ipCountrySignal += value;
        }
        remove
        {
            _ipCountrySignal -= value;
            if (_ipCountrySignal is not null) return;
            Disconnect(GDExtensionSignalName.IpCountry, _ipCountrySignalCallable);
            _ipCountrySignalCallable = default;
        }
    }

    public new delegate void LowPowerSignalHandler(long power);
    private LowPowerSignalHandler _lowPowerSignal;
    private Callable _lowPowerSignalCallable;
    public event LowPowerSignalHandler LowPowerSignal
    {
        add
        {
            if (_lowPowerSignal is null)
            {
                _lowPowerSignalCallable = Callable.From((Variant power) => 
                    _lowPowerSignal?.Invoke(power.As<long>()));
                Connect(GDExtensionSignalName.LowPower, _lowPowerSignalCallable);
            }
            _lowPowerSignal += value;
        }
        remove
        {
            _lowPowerSignal -= value;
            if (_lowPowerSignal is not null) return;
            Disconnect(GDExtensionSignalName.LowPower, _lowPowerSignalCallable);
            _lowPowerSignalCallable = default;
        }
    }

    public new delegate void SteamApiCallCompletedSignalHandler(long asyncCall, long callback, long parameter);
    private SteamApiCallCompletedSignalHandler _steamApiCallCompletedSignal;
    private Callable _steamApiCallCompletedSignalCallable;
    public event SteamApiCallCompletedSignalHandler SteamApiCallCompletedSignal
    {
        add
        {
            if (_steamApiCallCompletedSignal is null)
            {
                _steamApiCallCompletedSignalCallable = Callable.From((Variant asyncCall, Variant callback, Variant parameter) => 
                    _steamApiCallCompletedSignal?.Invoke(asyncCall.As<long>(), callback.As<long>(), parameter.As<long>()));
                Connect(GDExtensionSignalName.SteamApiCallCompleted, _steamApiCallCompletedSignalCallable);
            }
            _steamApiCallCompletedSignal += value;
        }
        remove
        {
            _steamApiCallCompletedSignal -= value;
            if (_steamApiCallCompletedSignal is not null) return;
            Disconnect(GDExtensionSignalName.SteamApiCallCompleted, _steamApiCallCompletedSignalCallable);
            _steamApiCallCompletedSignalCallable = default;
        }
    }

    public new delegate void SteamShutdownSignalHandler();
    private SteamShutdownSignalHandler _steamShutdownSignal;
    private Callable _steamShutdownSignalCallable;
    public event SteamShutdownSignalHandler SteamShutdownSignal
    {
        add
        {
            if (_steamShutdownSignal is null)
            {
                _steamShutdownSignalCallable = Callable.From(() => 
                    _steamShutdownSignal?.Invoke());
                Connect(GDExtensionSignalName.SteamShutdown, _steamShutdownSignalCallable);
            }
            _steamShutdownSignal += value;
        }
        remove
        {
            _steamShutdownSignal -= value;
            if (_steamShutdownSignal is not null) return;
            Disconnect(GDExtensionSignalName.SteamShutdown, _steamShutdownSignalCallable);
            _steamShutdownSignalCallable = default;
        }
    }

    public new delegate void AppResumingFromSuspendSignalHandler();
    private AppResumingFromSuspendSignalHandler _appResumingFromSuspendSignal;
    private Callable _appResumingFromSuspendSignalCallable;
    public event AppResumingFromSuspendSignalHandler AppResumingFromSuspendSignal
    {
        add
        {
            if (_appResumingFromSuspendSignal is null)
            {
                _appResumingFromSuspendSignalCallable = Callable.From(() => 
                    _appResumingFromSuspendSignal?.Invoke());
                Connect(GDExtensionSignalName.AppResumingFromSuspend, _appResumingFromSuspendSignalCallable);
            }
            _appResumingFromSuspendSignal += value;
        }
        remove
        {
            _appResumingFromSuspendSignal -= value;
            if (_appResumingFromSuspendSignal is not null) return;
            Disconnect(GDExtensionSignalName.AppResumingFromSuspend, _appResumingFromSuspendSignalCallable);
            _appResumingFromSuspendSignalCallable = default;
        }
    }

    public new delegate void FloatingGamepadTextInputDismissedSignalHandler();
    private FloatingGamepadTextInputDismissedSignalHandler _floatingGamepadTextInputDismissedSignal;
    private Callable _floatingGamepadTextInputDismissedSignalCallable;
    public event FloatingGamepadTextInputDismissedSignalHandler FloatingGamepadTextInputDismissedSignal
    {
        add
        {
            if (_floatingGamepadTextInputDismissedSignal is null)
            {
                _floatingGamepadTextInputDismissedSignalCallable = Callable.From(() => 
                    _floatingGamepadTextInputDismissedSignal?.Invoke());
                Connect(GDExtensionSignalName.FloatingGamepadTextInputDismissed, _floatingGamepadTextInputDismissedSignalCallable);
            }
            _floatingGamepadTextInputDismissedSignal += value;
        }
        remove
        {
            _floatingGamepadTextInputDismissedSignal -= value;
            if (_floatingGamepadTextInputDismissedSignal is not null) return;
            Disconnect(GDExtensionSignalName.FloatingGamepadTextInputDismissed, _floatingGamepadTextInputDismissedSignalCallable);
            _floatingGamepadTextInputDismissedSignalCallable = default;
        }
    }

    public new delegate void FilterTextDictionaryChangedSignalHandler(long language);
    private FilterTextDictionaryChangedSignalHandler _filterTextDictionaryChangedSignal;
    private Callable _filterTextDictionaryChangedSignalCallable;
    public event FilterTextDictionaryChangedSignalHandler FilterTextDictionaryChangedSignal
    {
        add
        {
            if (_filterTextDictionaryChangedSignal is null)
            {
                _filterTextDictionaryChangedSignalCallable = Callable.From((Variant language) => 
                    _filterTextDictionaryChangedSignal?.Invoke(language.As<long>()));
                Connect(GDExtensionSignalName.FilterTextDictionaryChanged, _filterTextDictionaryChangedSignalCallable);
            }
            _filterTextDictionaryChangedSignal += value;
        }
        remove
        {
            _filterTextDictionaryChangedSignal -= value;
            if (_filterTextDictionaryChangedSignal is not null) return;
            Disconnect(GDExtensionSignalName.FilterTextDictionaryChanged, _filterTextDictionaryChangedSignalCallable);
            _filterTextDictionaryChangedSignalCallable = default;
        }
    }

    public new delegate void BroadcastUploadStartSignalHandler(bool isRtmp);
    private BroadcastUploadStartSignalHandler _broadcastUploadStartSignal;
    private Callable _broadcastUploadStartSignalCallable;
    public event BroadcastUploadStartSignalHandler BroadcastUploadStartSignal
    {
        add
        {
            if (_broadcastUploadStartSignal is null)
            {
                _broadcastUploadStartSignalCallable = Callable.From((Variant isRtmp) => 
                    _broadcastUploadStartSignal?.Invoke(isRtmp.As<bool>()));
                Connect(GDExtensionSignalName.BroadcastUploadStart, _broadcastUploadStartSignalCallable);
            }
            _broadcastUploadStartSignal += value;
        }
        remove
        {
            _broadcastUploadStartSignal -= value;
            if (_broadcastUploadStartSignal is not null) return;
            Disconnect(GDExtensionSignalName.BroadcastUploadStart, _broadcastUploadStartSignalCallable);
            _broadcastUploadStartSignalCallable = default;
        }
    }

    public new delegate void BroadcastUploadStopSignalHandler(long result);
    private BroadcastUploadStopSignalHandler _broadcastUploadStopSignal;
    private Callable _broadcastUploadStopSignalCallable;
    public event BroadcastUploadStopSignalHandler BroadcastUploadStopSignal
    {
        add
        {
            if (_broadcastUploadStopSignal is null)
            {
                _broadcastUploadStopSignalCallable = Callable.From((Variant result) => 
                    _broadcastUploadStopSignal?.Invoke(result.As<long>()));
                Connect(GDExtensionSignalName.BroadcastUploadStop, _broadcastUploadStopSignalCallable);
            }
            _broadcastUploadStopSignal += value;
        }
        remove
        {
            _broadcastUploadStopSignal -= value;
            if (_broadcastUploadStopSignal is not null) return;
            Disconnect(GDExtensionSignalName.BroadcastUploadStop, _broadcastUploadStopSignalCallable);
            _broadcastUploadStopSignalCallable = default;
        }
    }

    public new delegate void GetOpfSettingsResultSignalHandler(long result, long appId);
    private GetOpfSettingsResultSignalHandler _getOpfSettingsResultSignal;
    private Callable _getOpfSettingsResultSignalCallable;
    public event GetOpfSettingsResultSignalHandler GetOpfSettingsResultSignal
    {
        add
        {
            if (_getOpfSettingsResultSignal is null)
            {
                _getOpfSettingsResultSignalCallable = Callable.From((Variant result, Variant appId) => 
                    _getOpfSettingsResultSignal?.Invoke(result.As<long>(), appId.As<long>()));
                Connect(GDExtensionSignalName.GetOpfSettingsResult, _getOpfSettingsResultSignalCallable);
            }
            _getOpfSettingsResultSignal += value;
        }
        remove
        {
            _getOpfSettingsResultSignal -= value;
            if (_getOpfSettingsResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.GetOpfSettingsResult, _getOpfSettingsResultSignalCallable);
            _getOpfSettingsResultSignalCallable = default;
        }
    }

    public new delegate void GetVideoResultSignalHandler(long result, long appId, string url);
    private GetVideoResultSignalHandler _getVideoResultSignal;
    private Callable _getVideoResultSignalCallable;
    public event GetVideoResultSignalHandler GetVideoResultSignal
    {
        add
        {
            if (_getVideoResultSignal is null)
            {
                _getVideoResultSignalCallable = Callable.From((Variant result, Variant appId, Variant url) => 
                    _getVideoResultSignal?.Invoke(result.As<long>(), appId.As<long>(), url.As<string>()));
                Connect(GDExtensionSignalName.GetVideoResult, _getVideoResultSignalCallable);
            }
            _getVideoResultSignal += value;
        }
        remove
        {
            _getVideoResultSignal -= value;
            if (_getVideoResultSignal is not null) return;
            Disconnect(GDExtensionSignalName.GetVideoResult, _getVideoResultSignalCallable);
            _getVideoResultSignalCallable = default;
        }
    }

    public new static class GDExtensionPropertyName
    {
        public new static readonly StringName CurrentBrowserHandle = "current_browser_handle";
        public new static readonly StringName CurrentClanId = "current_clan_id";
        public new static readonly StringName InventoryHandle = "inventory_handle";
        public new static readonly StringName InventoryUpdateHandle = "inventory_update_handle";
        public new static readonly StringName CurrentSteamId = "current_steam_id";
        public new static readonly StringName LeaderboardDetailsMax = "leaderboard_details_max";
        public new static readonly StringName LeaderboardEntriesArray = "leaderboard_entries_array";
        public new static readonly StringName LeaderboardHandle = "leaderboard_handle";
        public new static readonly StringName LeaderboardUgcHandle = "leaderboard_ugc_handle";
        public new static readonly StringName CurrentAppId = "current_app_id";
    }

    public new long CurrentBrowserHandle
    {
        get => Get(GDExtensionPropertyName.CurrentBrowserHandle).As<long>();
        set => Set(GDExtensionPropertyName.CurrentBrowserHandle, value);
    }

    public new long CurrentClanId
    {
        get => Get(GDExtensionPropertyName.CurrentClanId).As<long>();
        set => Set(GDExtensionPropertyName.CurrentClanId, value);
    }

    public new long InventoryHandle
    {
        get => Get(GDExtensionPropertyName.InventoryHandle).As<long>();
        set => Set(GDExtensionPropertyName.InventoryHandle, value);
    }

    public new long InventoryUpdateHandle
    {
        get => Get(GDExtensionPropertyName.InventoryUpdateHandle).As<long>();
        set => Set(GDExtensionPropertyName.InventoryUpdateHandle, value);
    }

    public new long CurrentSteamId
    {
        get => Get(GDExtensionPropertyName.CurrentSteamId).As<long>();
        set => Set(GDExtensionPropertyName.CurrentSteamId, value);
    }

    public new long LeaderboardDetailsMax
    {
        get => Get(GDExtensionPropertyName.LeaderboardDetailsMax).As<long>();
        set => Set(GDExtensionPropertyName.LeaderboardDetailsMax, value);
    }

    public new Godot.Collections.Array LeaderboardEntriesArray
    {
        get => Get(GDExtensionPropertyName.LeaderboardEntriesArray).As<Godot.Collections.Array>();
        set => Set(GDExtensionPropertyName.LeaderboardEntriesArray, value);
    }

    public new long LeaderboardHandle
    {
        get => Get(GDExtensionPropertyName.LeaderboardHandle).As<long>();
        set => Set(GDExtensionPropertyName.LeaderboardHandle, value);
    }

    public new long LeaderboardUgcHandle
    {
        get => Get(GDExtensionPropertyName.LeaderboardUgcHandle).As<long>();
        set => Set(GDExtensionPropertyName.LeaderboardUgcHandle, value);
    }

    public new long CurrentAppId
    {
        get => Get(GDExtensionPropertyName.CurrentAppId).As<long>();
        set => Set(GDExtensionPropertyName.CurrentAppId, value);
    }

    public new static class GDExtensionMethodName
    {
        public new static readonly StringName GetGodotsteamVersion = "get_godotsteam_version";
        public new static readonly StringName GetSteamId32 = "getSteamID32";
        public new static readonly StringName IsAnonAccount = "isAnonAccount";
        public new static readonly StringName IsAnonUserAccount = "isAnonUserAccount";
        public new static readonly StringName IsChatAccount = "isChatAccount";
        public new static readonly StringName IsClanAccount = "isClanAccount";
        public new static readonly StringName IsConsoleUserAccount = "isConsoleUserAccount";
        public new static readonly StringName IsIndividualAccount = "isIndividualAccount";
        public new static readonly StringName IsLobby = "isLobby";
        public new static readonly StringName IsSteamRunning = "isSteamRunning";
        public new static readonly StringName RunCallbacks = "run_callbacks";
        public new static readonly StringName RestartAppIfNecessary = "restartAppIfNecessary";
        public new static readonly StringName SteamInit = "steamInit";
        public new static readonly StringName SteamInitEx = "steamInitEx";
        public new static readonly StringName ReleaseCurrentThreadMemory = "releaseCurrentThreadMemory";
        public new static readonly StringName SteamShutdown = "steamShutdown";
        public new static readonly StringName GetServerListRequest = "get_server_list_request";
        public new static readonly StringName GetSteamInitResult = "get_steam_init_result";
        public new static readonly StringName SetServerListRequest = "set_server_list_request";
        public new static readonly StringName GetAppBuildId = "getAppBuildId";
        public new static readonly StringName GetAppInstallDir = "getAppInstallDir";
        public new static readonly StringName GetAppOwner = "getAppOwner";
        public new static readonly StringName GetAvailableGameLanguages = "getAvailableGameLanguages";
        public new static readonly StringName GetBetaInfo = "getBetaInfo";
        public new static readonly StringName GetCurrentBetaName = "getCurrentBetaName";
        public new static readonly StringName GetCurrentGameLanguage = "getCurrentGameLanguage";
        public new static readonly StringName GetDlcCount = "getDLCCount";
        public new static readonly StringName GetDlcData = "getDLCData";
        public new static readonly StringName GetDlcDataByIndex = "getDLCDataByIndex";
        public new static readonly StringName GetDlcDownloadProgress = "getDLCDownloadProgress";
        public new static readonly StringName GetEarliestPurchaseUnixTime = "getEarliestPurchaseUnixTime";
        public new static readonly StringName GetFileDetails = "getFileDetails";
        public new static readonly StringName GetInstalledDepots = "getInstalledDepots";
        public new static readonly StringName GetLaunchCommandLine = "getLaunchCommandLine";
        public new static readonly StringName GetLaunchQueryParam = "getLaunchQueryParam";
        public new static readonly StringName GetNumBetas = "getNumBetas";
        public new static readonly StringName InstallDlc = "installDLC";
        public new static readonly StringName IsAppInstalled = "isAppInstalled";
        public new static readonly StringName IsCybercafe = "isCybercafe";
        public new static readonly StringName IsDlcInstalled = "isDLCInstalled";
        public new static readonly StringName IsLowViolence = "isLowViolence";
        public new static readonly StringName IsSubscribed = "isSubscribed";
        public new static readonly StringName IsSubscribedApp = "isSubscribedApp";
        public new static readonly StringName IsSubscribedFromFamilySharing = "isSubscribedFromFamilySharing";
        public new static readonly StringName IsSubscribedFromFreeWeekend = "isSubscribedFromFreeWeekend";
        public new static readonly StringName IsTimedTrial = "isTimedTrial";
        public new static readonly StringName IsVacBanned = "isVACBanned";
        public new static readonly StringName MarkContentCorrupt = "markContentCorrupt";
        public new static readonly StringName SetActiveBeta = "setActiveBeta";
        public new static readonly StringName SetDlcContext = "setDLCContext";
        public new static readonly StringName SetGamePerformanceSettings = "setGamePerformanceSettings";
        public new static readonly StringName SetGameRenderResolution = "setGameRenderResolution";
        public new static readonly StringName UninstallDlc = "uninstallDLC";
        public new static readonly StringName ActivateGameOverlay = "activateGameOverlay";
        public new static readonly StringName ActivateGameOverlayInviteDialog = "activateGameOverlayInviteDialog";
        public new static readonly StringName ActivateGameOverlayInviteDialogConnectString = "activateGameOverlayInviteDialogConnectString";
        public new static readonly StringName ActivateGameOverlayRemotePlayTogetherInviteDialog = "activateGameOverlayRemotePlayTogetherInviteDialog";
        public new static readonly StringName ActivateGameOverlayToStore = "activateGameOverlayToStore";
        public new static readonly StringName ActivateGameOverlayToUser = "activateGameOverlayToUser";
        public new static readonly StringName ActivateGameOverlayToWebPage = "activateGameOverlayToWebPage";
        public new static readonly StringName ClearRichPresence = "clearRichPresence";
        public new static readonly StringName CloseClanChatWindowInSteam = "closeClanChatWindowInSteam";
        public new static readonly StringName DownloadClanActivityCounts = "downloadClanActivityCounts";
        public new static readonly StringName EnumerateFollowingList = "enumerateFollowingList";
        public new static readonly StringName GetChatMemberByIndex = "getChatMemberByIndex";
        public new static readonly StringName GetClanActivityCounts = "getClanActivityCounts";
        public new static readonly StringName GetClanByIndex = "getClanByIndex";
        public new static readonly StringName GetClanChatMemberCount = "getClanChatMemberCount";
        public new static readonly StringName GetClanCount = "getClanCount";
        public new static readonly StringName GetClanName = "getClanName";
        public new static readonly StringName GetClanOfficerByIndex = "getClanOfficerByIndex";
        public new static readonly StringName GetClanOfficerCount = "getClanOfficerCount";
        public new static readonly StringName GetClanOwner = "getClanOwner";
        public new static readonly StringName GetClanTag = "getClanTag";
        public new static readonly StringName GetCoplayFriend = "getCoplayFriend";
        public new static readonly StringName GetCoplayFriendCount = "getCoplayFriendCount";
        public new static readonly StringName GetFollowerCount = "getFollowerCount";
        public new static readonly StringName GetFriendByIndex = "getFriendByIndex";
        public new static readonly StringName GetFriendCoplayGame = "getFriendCoplayGame";
        public new static readonly StringName GetFriendCoplayTime = "getFriendCoplayTime";
        public new static readonly StringName GetFriendCount = "getFriendCount";
        public new static readonly StringName GetFriendCountFromSource = "getFriendCountFromSource";
        public new static readonly StringName GetFriendFromSourceByIndex = "getFriendFromSourceByIndex";
        public new static readonly StringName GetFriendGamePlayed = "getFriendGamePlayed";
        public new static readonly StringName GetFriendPersonaName = "getFriendPersonaName";
        public new static readonly StringName GetFriendPersonaNameHistory = "getFriendPersonaNameHistory";
        public new static readonly StringName GetFriendPersonaState = "getFriendPersonaState";
        public new static readonly StringName GetFriendRelationship = "getFriendRelationship";
        public new static readonly StringName GetFriendRichPresence = "getFriendRichPresence";
        public new static readonly StringName GetFriendRichPresenceKeyCount = "getFriendRichPresenceKeyCount";
        public new static readonly StringName GetFriendRichPresenceKeyByIndex = "getFriendRichPresenceKeyByIndex";
        public new static readonly StringName GetFriendsGroupCount = "getFriendsGroupCount";
        public new static readonly StringName GetFriendsGroupIdByIndex = "getFriendsGroupIDByIndex";
        public new static readonly StringName GetFriendsGroupMembersCount = "getFriendsGroupMembersCount";
        public new static readonly StringName GetFriendsGroupMembersList = "getFriendsGroupMembersList";
        public new static readonly StringName GetFriendsGroupName = "getFriendsGroupName";
        public new static readonly StringName GetFriendSteamLevel = "getFriendSteamLevel";
        public new static readonly StringName GetLargeFriendAvatar = "getLargeFriendAvatar";
        public new static readonly StringName GetMediumFriendAvatar = "getMediumFriendAvatar";
        public new static readonly StringName GetPersonaName = "getPersonaName";
        public new static readonly StringName GetPersonaState = "getPersonaState";
        public new static readonly StringName GetPlayerAvatar = "getPlayerAvatar";
        public new static readonly StringName GetPlayerNickname = "getPlayerNickname";
        public new static readonly StringName GetProfileItemPropertyString = "getProfileItemPropertyString";
        public new static readonly StringName GetProfileItemPropertyInt = "getProfileItemPropertyInt";
        public new static readonly StringName GetRecentPlayers = "getRecentPlayers";
        public new static readonly StringName GetSmallFriendAvatar = "getSmallFriendAvatar";
        public new static readonly StringName GetUserFriendsGroups = "getUserFriendsGroups";
        public new static readonly StringName GetUserSteamFriends = "getUserSteamFriends";
        public new static readonly StringName GetUserSteamGroups = "getUserSteamGroups";
        public new static readonly StringName HasEquippedProfileItem = "hasEquippedProfileItem";
        public new static readonly StringName HasFriend = "hasFriend";
        public new static readonly StringName InviteUserToGame = "inviteUserToGame";
        public new static readonly StringName IsClanChatAdmin = "isClanChatAdmin";
        public new static readonly StringName IsClanPublic = "isClanPublic";
        public new static readonly StringName IsClanOfficialGameGroup = "isClanOfficialGameGroup";
        public new static readonly StringName IsClanChatWindowOpenInSteam = "isClanChatWindowOpenInSteam";
        public new static readonly StringName IsFollowing = "isFollowing";
        public new static readonly StringName IsUserInSource = "isUserInSource";
        public new static readonly StringName JoinClanChatRoom = "joinClanChatRoom";
        public new static readonly StringName LeaveClanChatRoom = "leaveClanChatRoom";
        public new static readonly StringName OpenClanChatWindowInSteam = "openClanChatWindowInSteam";
        public new static readonly StringName RegisterProtocolInOverlayBrowser = "registerProtocolInOverlayBrowser";
        public new static readonly StringName ReplyToFriendMessage = "replyToFriendMessage";
        public new static readonly StringName RequestClanOfficerList = "requestClanOfficerList";
        public new static readonly StringName RequestEquippedProfileItems = "requestEquippedProfileItems";
        public new static readonly StringName RequestFriendRichPresence = "requestFriendRichPresence";
        public new static readonly StringName RequestUserInformation = "requestUserInformation";
        public new static readonly StringName SendClanChatMessage = "sendClanChatMessage";
        public new static readonly StringName SetInGameVoiceSpeaking = "setInGameVoiceSpeaking";
        public new static readonly StringName SetListenForFriendsMessages = "setListenForFriendsMessages";
        public new static readonly StringName SetPlayedWith = "setPlayedWith";
        public new static readonly StringName SetRichPresence = "setRichPresence";
        public new static readonly StringName AddHeader = "addHeader";
        public new static readonly StringName AllowStartRequest = "allowStartRequest";
        public new static readonly StringName CopyToClipboard = "copyToClipboard";
        public new static readonly StringName CreateBrowser = "createBrowser";
        public new static readonly StringName ExecuteJavascript = "executeJavascript";
        public new static readonly StringName Find = "find";
        public new static readonly StringName GetLinkAtPosition = "getLinkAtPosition";
        public new static readonly StringName GoBack = "goBack";
        public new static readonly StringName GoForward = "goForward";
        public new static readonly StringName HtmlInit = "htmlInit";
        public new static readonly StringName JsDialogResponse = "jsDialogResponse";
        public new static readonly StringName KeyChar = "keyChar";
        public new static readonly StringName KeyDown = "keyDown";
        public new static readonly StringName KeyUp = "keyUp";
        public new static readonly StringName LoadUrl = "loadURL";
        public new static readonly StringName MouseDoubleClick = "mouseDoubleClick";
        public new static readonly StringName MouseDown = "mouseDown";
        public new static readonly StringName MouseMove = "mouseMove";
        public new static readonly StringName MouseUp = "mouseUp";
        public new static readonly StringName MouseWheel = "mouseWheel";
        public new static readonly StringName OpenDeveloperTools = "openDeveloperTools";
        public new static readonly StringName PasteFromClipboard = "pasteFromClipboard";
        public new static readonly StringName Reload = "reload";
        public new static readonly StringName RemoveBrowser = "removeBrowser";
        public new static readonly StringName SetBackgroundMode = "setBackgroundMode";
        public new static readonly StringName SetCookie = "setCookie";
        public new static readonly StringName SetDpiScalingFactor = "setDPIScalingFactor";
        public new static readonly StringName SetHorizontalScroll = "setHorizontalScroll";
        public new static readonly StringName SetKeyFocus = "setKeyFocus";
        public new static readonly StringName SetPageScaleFactor = "setPageScaleFactor";
        public new static readonly StringName SetSize = "setSize";
        public new static readonly StringName SetVerticalScroll = "setVerticalScroll";
        public new static readonly StringName HtmlShutdown = "htmlShutdown";
        public new static readonly StringName StopFind = "stopFind";
        public new static readonly StringName StopLoad = "stopLoad";
        public new static readonly StringName ViewSource = "viewSource";
        public new static readonly StringName CreateCookieContainer = "createCookieContainer";
        public new static readonly StringName CreateHttpRequest = "createHTTPRequest";
        public new static readonly StringName DeferHttpRequest = "deferHTTPRequest";
        public new static readonly StringName GetHttpDownloadProgressPct = "getHTTPDownloadProgressPct";
        public new static readonly StringName GetHttpRequestWasTimedOut = "getHTTPRequestWasTimedOut";
        public new static readonly StringName GetHttpResponseBodyData = "getHTTPResponseBodyData";
        public new static readonly StringName GetHttpResponseBodySize = "getHTTPResponseBodySize";
        public new static readonly StringName GetHttpResponseHeaderSize = "getHTTPResponseHeaderSize";
        public new static readonly StringName GetHttpResponseHeaderValue = "getHTTPResponseHeaderValue";
        public new static readonly StringName GetHttpStreamingResponseBodyData = "getHTTPStreamingResponseBodyData";
        public new static readonly StringName PrioritizeHttpRequest = "prioritizeHTTPRequest";
        public new static readonly StringName ReleaseCookieContainer = "releaseCookieContainer";
        public new static readonly StringName ReleaseHttpRequest = "releaseHTTPRequest";
        public new static readonly StringName SendHttpRequest = "sendHTTPRequest";
        public new static readonly StringName SendHttpRequestAndStreamResponse = "sendHTTPRequestAndStreamResponse";
        public new static readonly StringName SetHttpCookie = "setHTTPCookie";
        public new static readonly StringName SetHttpRequestAbsoluteTimeoutMs = "setHTTPRequestAbsoluteTimeoutMS";
        public new static readonly StringName SetHttpRequestContextValue = "setHTTPRequestContextValue";
        public new static readonly StringName SetHttpRequestCookieContainer = "setHTTPRequestCookieContainer";
        public new static readonly StringName SetHttpRequestGetOrPostParameter = "setHTTPRequestGetOrPostParameter";
        public new static readonly StringName SetHttpRequestHeaderValue = "setHTTPRequestHeaderValue";
        public new static readonly StringName SetHttpRequestNetworkActivityTimeout = "setHTTPRequestNetworkActivityTimeout";
        public new static readonly StringName SetHttpRequestRawPostBody = "setHTTPRequestRawPostBody";
        public new static readonly StringName SetHttpRequestRequiresVerifiedCertificate = "setHTTPRequestRequiresVerifiedCertificate";
        public new static readonly StringName SetHttpRequestUserAgentInfo = "setHTTPRequestUserAgentInfo";
        public new static readonly StringName ActivateActionSet = "activateActionSet";
        public new static readonly StringName ActivateActionSetLayer = "activateActionSetLayer";
        public new static readonly StringName DeactivateActionSetLayer = "deactivateActionSetLayer";
        public new static readonly StringName DeactivateAllActionSetLayers = "deactivateAllActionSetLayers";
        public new static readonly StringName GetActionSetHandle = "getActionSetHandle";
        public new static readonly StringName GetActionOriginFromXboxOrigin = "getActionOriginFromXboxOrigin";
        public new static readonly StringName GetActiveActionSetLayers = "getActiveActionSetLayers";
        public new static readonly StringName GetAnalogActionData = "getAnalogActionData";
        public new static readonly StringName GetAnalogActionHandle = "getAnalogActionHandle";
        public new static readonly StringName GetAnalogActionOrigins = "getAnalogActionOrigins";
        public new static readonly StringName GetConnectedControllers = "getConnectedControllers";
        public new static readonly StringName GetControllerForGamepadIndex = "getControllerForGamepadIndex";
        public new static readonly StringName GetCurrentActionSet = "getCurrentActionSet";
        public new static readonly StringName GetDeviceBindingRevision = "getDeviceBindingRevision";
        public new static readonly StringName GetDigitalActionData = "getDigitalActionData";
        public new static readonly StringName GetDigitalActionHandle = "getDigitalActionHandle";
        public new static readonly StringName GetDigitalActionOrigins = "getDigitalActionOrigins";
        public new static readonly StringName GetGamepadIndexForController = "getGamepadIndexForController";
        public new static readonly StringName GetGlyphForActionOrigin = "getGlyphForActionOrigin";
        public new static readonly StringName GetInputTypeForHandle = "getInputTypeForHandle";
        public new static readonly StringName GetMotionData = "getMotionData";
        public new static readonly StringName GetRemotePlaySessionId = "getRemotePlaySessionID";
        public new static readonly StringName GetStringForActionOrigin = "getStringForActionOrigin";
        public new static readonly StringName InputInit = "inputInit";
        public new static readonly StringName InputShutdown = "inputShutdown";
        public new static readonly StringName RunFrame = "runFrame";
        public new static readonly StringName SetLedColor = "setLEDColor";
        public new static readonly StringName ShowBindingPanel = "showBindingPanel";
        public new static readonly StringName StopAnalogActionMomentum = "stopAnalogActionMomentum";
        public new static readonly StringName TranslateActionOrigin = "translateActionOrigin";
        public new static readonly StringName TriggerHapticPulse = "triggerHapticPulse";
        public new static readonly StringName TriggerRepeatedHapticPulse = "triggerRepeatedHapticPulse";
        public new static readonly StringName TriggerVibration = "triggerVibration";
        public new static readonly StringName SetInputActionManifestFilePath = "setInputActionManifestFilePath";
        public new static readonly StringName WaitForData = "waitForData";
        public new static readonly StringName NewDataAvailable = "newDataAvailable";
        public new static readonly StringName EnableDeviceCallbacks = "enableDeviceCallbacks";
        public new static readonly StringName EnableActionEventCallbacks = "enableActionEventCallbacks";
        public new static readonly StringName GetGlyphPngForActionOrigin = "getGlyphPNGForActionOrigin";
        public new static readonly StringName GetGlyphSvgForActionOrigin = "getGlyphSVGForActionOrigin";
        public new static readonly StringName TriggerVibrationExtended = "triggerVibrationExtended";
        public new static readonly StringName TriggerSimpleHapticEvent = "triggerSimpleHapticEvent";
        public new static readonly StringName GetStringForXboxOrigin = "getStringForXboxOrigin";
        public new static readonly StringName GetGlyphForXboxOrigin = "getGlyphForXboxOrigin";
        public new static readonly StringName GetSessionInputConfigurationSettings = "getSessionInputConfigurationSettings";
        public new static readonly StringName GetStringForDigitalActionName = "getStringForDigitalActionName";
        public new static readonly StringName GetStringForAnalogActionName = "getStringForAnalogActionName";
        public new static readonly StringName AddPromoItem = "addPromoItem";
        public new static readonly StringName AddPromoItems = "addPromoItems";
        public new static readonly StringName CheckResultSteamId = "checkResultSteamID";
        public new static readonly StringName ConsumeItem = "consumeItem";
        public new static readonly StringName DeserializeResult = "deserializeResult";
        public new static readonly StringName DestroyResult = "destroyResult";
        public new static readonly StringName ExchangeItems = "exchangeItems";
        public new static readonly StringName GenerateItems = "generateItems";
        public new static readonly StringName GetAllItems = "getAllItems";
        public new static readonly StringName GetItemDefinitionProperty = "getItemDefinitionProperty";
        public new static readonly StringName GetItemsById = "getItemsByID";
        public new static readonly StringName GetItemPrice = "getItemPrice";
        public new static readonly StringName GetItemsWithPrices = "getItemsWithPrices";
        public new static readonly StringName GetResultItemProperty = "getResultItemProperty";
        public new static readonly StringName GetResultItems = "getResultItems";
        public new static readonly StringName GetResultStatus = "getResultStatus";
        public new static readonly StringName GetResultTimestamp = "getResultTimestamp";
        public new static readonly StringName GrantPromoItems = "grantPromoItems";
        public new static readonly StringName LoadItemDefinitions = "loadItemDefinitions";
        public new static readonly StringName RequestEligiblePromoItemDefinitionsIDs = "requestEligiblePromoItemDefinitionsIDs";
        public new static readonly StringName RequestPrices = "requestPrices";
        public new static readonly StringName SerializeResult = "serializeResult";
        public new static readonly StringName StartPurchase = "startPurchase";
        public new static readonly StringName TransferItemQuantity = "transferItemQuantity";
        public new static readonly StringName TriggerItemDrop = "triggerItemDrop";
        public new static readonly StringName StartUpdateProperties = "startUpdateProperties";
        public new static readonly StringName SubmitUpdateProperties = "submitUpdateProperties";
        public new static readonly StringName RemoveProperty = "removeProperty";
        public new static readonly StringName SetPropertyString = "setPropertyString";
        public new static readonly StringName SetPropertyBool = "setPropertyBool";
        public new static readonly StringName SetPropertyInt = "setPropertyInt";
        public new static readonly StringName SetPropertyFloat = "setPropertyFloat";
        public new static readonly StringName GetFavoriteGames = "getFavoriteGames";
        public new static readonly StringName AddFavoriteGame = "addFavoriteGame";
        public new static readonly StringName RemoveFavoriteGame = "removeFavoriteGame";
        public new static readonly StringName RequestLobbyList = "requestLobbyList";
        public new static readonly StringName AddRequestLobbyListStringFilter = "addRequestLobbyListStringFilter";
        public new static readonly StringName AddRequestLobbyListNumericalFilter = "addRequestLobbyListNumericalFilter";
        public new static readonly StringName AddRequestLobbyListNearValueFilter = "addRequestLobbyListNearValueFilter";
        public new static readonly StringName AddRequestLobbyListFilterSlotsAvailable = "addRequestLobbyListFilterSlotsAvailable";
        public new static readonly StringName AddRequestLobbyListDistanceFilter = "addRequestLobbyListDistanceFilter";
        public new static readonly StringName AddRequestLobbyListResultCountFilter = "addRequestLobbyListResultCountFilter";
        public new static readonly StringName CreateLobby = "createLobby";
        public new static readonly StringName JoinLobby = "joinLobby";
        public new static readonly StringName LeaveLobby = "leaveLobby";
        public new static readonly StringName InviteUserToLobby = "inviteUserToLobby";
        public new static readonly StringName GetNumLobbyMembers = "getNumLobbyMembers";
        public new static readonly StringName GetLobbyMemberByIndex = "getLobbyMemberByIndex";
        public new static readonly StringName GetLobbyData = "getLobbyData";
        public new static readonly StringName SetLobbyData = "setLobbyData";
        public new static readonly StringName GetAllLobbyData = "getAllLobbyData";
        public new static readonly StringName DeleteLobbyData = "deleteLobbyData";
        public new static readonly StringName GetLobbyMemberData = "getLobbyMemberData";
        public new static readonly StringName SetLobbyMemberData = "setLobbyMemberData";
        public new static readonly StringName SendLobbyChatMsg = "sendLobbyChatMsg";
        public new static readonly StringName RequestLobbyData = "requestLobbyData";
        public new static readonly StringName SetLobbyGameServer = "setLobbyGameServer";
        public new static readonly StringName GetLobbyGameServer = "getLobbyGameServer";
        public new static readonly StringName SetLobbyMemberLimit = "setLobbyMemberLimit";
        public new static readonly StringName GetLobbyMemberLimit = "getLobbyMemberLimit";
        public new static readonly StringName SetLobbyType = "setLobbyType";
        public new static readonly StringName SetLobbyJoinable = "setLobbyJoinable";
        public new static readonly StringName GetLobbyOwner = "getLobbyOwner";
        public new static readonly StringName SetLobbyOwner = "setLobbyOwner";
        public new static readonly StringName CancelQuery = "cancelQuery";
        public new static readonly StringName CancelServerQuery = "cancelServerQuery";
        public new static readonly StringName GetServerCount = "getServerCount";
        public new static readonly StringName GetServerDetails = "getServerDetails";
        public new static readonly StringName IsRefreshing = "isRefreshing";
        public new static readonly StringName PingServer = "pingServer";
        public new static readonly StringName PlayerDetails = "playerDetails";
        public new static readonly StringName RefreshQuery = "refreshQuery";
        public new static readonly StringName RefreshServer = "refreshServer";
        public new static readonly StringName ReleaseRequest = "releaseRequest";
        public new static readonly StringName RequestFavoritesServerList = "requestFavoritesServerList";
        public new static readonly StringName RequestFriendsServerList = "requestFriendsServerList";
        public new static readonly StringName RequestHistoryServerList = "requestHistoryServerList";
        public new static readonly StringName RequestInternetServerList = "requestInternetServerList";
        public new static readonly StringName RequestLanServerList = "requestLANServerList";
        public new static readonly StringName RequestSpectatorServerList = "requestSpectatorServerList";
        public new static readonly StringName ServerFriends = "serverFriends";
        public new static readonly StringName ServerRules = "serverRules";
        public new static readonly StringName MusicIsEnabled = "musicIsEnabled";
        public new static readonly StringName MusicIsPlaying = "musicIsPlaying";
        public new static readonly StringName GetPlaybackStatus = "getPlaybackStatus";
        public new static readonly StringName MusicGetVolume = "musicGetVolume";
        public new static readonly StringName MusicPause = "musicPause";
        public new static readonly StringName MusicPlay = "musicPlay";
        public new static readonly StringName MusicPlayNext = "musicPlayNext";
        public new static readonly StringName MusicPlayPrev = "musicPlayPrev";
        public new static readonly StringName MusicSetVolume = "musicSetVolume";
        public new static readonly StringName AcceptP2pSessionWithUser = "acceptP2PSessionWithUser";
        public new static readonly StringName AllowP2pPacketRelay = "allowP2PPacketRelay";
        public new static readonly StringName CloseP2pChannelWithUser = "closeP2PChannelWithUser";
        public new static readonly StringName CloseP2pSessionWithUser = "closeP2PSessionWithUser";
        public new static readonly StringName GetP2pSessionState = "getP2PSessionState";
        public new static readonly StringName GetAvailableP2pPacketSize = "getAvailableP2PPacketSize";
        public new static readonly StringName ReadP2pPacket = "readP2PPacket";
        public new static readonly StringName SendP2pPacket = "sendP2PPacket";
        public new static readonly StringName AcceptSessionWithUser = "acceptSessionWithUser";
        public new static readonly StringName CloseChannelWithUser = "closeChannelWithUser";
        public new static readonly StringName CloseSessionWithUser = "closeSessionWithUser";
        public new static readonly StringName GetSessionConnectionInfo = "getSessionConnectionInfo";
        public new static readonly StringName ReceiveMessagesOnChannel = "receiveMessagesOnChannel";
        public new static readonly StringName SendMessageToUser = "sendMessageToUser";
        public new static readonly StringName AcceptConnection = "acceptConnection";
        public new static readonly StringName BeginAsyncRequestFakeIp = "beginAsyncRequestFakeIP";
        public new static readonly StringName CloseConnection = "closeConnection";
        public new static readonly StringName CloseListenSocket = "closeListenSocket";
        public new static readonly StringName ConfigureConnectionLanes = "configureConnectionLanes";
        public new static readonly StringName ConnectP2p = "connectP2P";
        public new static readonly StringName ConnectByIpAddress = "connectByIPAddress";
        public new static readonly StringName ConnectToHostedDedicatedServer = "connectToHostedDedicatedServer";
        public new static readonly StringName CreateFakeUdpPort = "createFakeUDPPort";
        public new static readonly StringName CreateListenSocketIp = "createListenSocketIP";
        public new static readonly StringName CreateListenSocketP2p = "createListenSocketP2P";
        public new static readonly StringName CreateListenSocketP2pFakeIp = "createListenSocketP2PFakeIP";
        public new static readonly StringName CreatePollGroup = "createPollGroup";
        public new static readonly StringName CreateSocketPair = "createSocketPair";
        public new static readonly StringName DestroyPollGroup = "destroyPollGroup";
        public new static readonly StringName FlushMessagesOnConnection = "flushMessagesOnConnection";
        public new static readonly StringName GetAuthenticationStatus = "getAuthenticationStatus";
        public new static readonly StringName GetCertificateRequest = "getCertificateRequest";
        public new static readonly StringName GetConnectionInfo = "getConnectionInfo";
        public new static readonly StringName GetConnectionName = "getConnectionName";
        public new static readonly StringName GetConnectionRealTimeStatus = "getConnectionRealTimeStatus";
        public new static readonly StringName GetConnectionUserData = "getConnectionUserData";
        public new static readonly StringName GetDetailedConnectionStatus = "getDetailedConnectionStatus";
        public new static readonly StringName GetFakeIp = "getFakeIP";
        public new static readonly StringName GetHostedDedicatedServerPopId = "getHostedDedicatedServerPOPId";
        public new static readonly StringName GetHostedDedicatedServerPort = "getHostedDedicatedServerPort";
        public new static readonly StringName GetListenSocketAddress = "getListenSocketAddress";
        public new static readonly StringName GetRemoteFakeIpForConnection = "getRemoteFakeIPForConnection";
        public new static readonly StringName InitAuthentication = "initAuthentication";
        public new static readonly StringName ReceiveMessagesOnConnection = "receiveMessagesOnConnection";
        public new static readonly StringName ReceiveMessagesOnPollGroup = "receiveMessagesOnPollGroup";
        public new static readonly StringName ResetIdentity = "resetIdentity";
        public new static readonly StringName RunNetworkingCallbacks = "runNetworkingCallbacks";
        public new static readonly StringName SendMessages = "sendMessages";
        public new static readonly StringName SendMessageToConnection = "sendMessageToConnection";
        public new static readonly StringName SetCertificate = "setCertificate";
        public new static readonly StringName SetConnectionPollGroup = "setConnectionPollGroup";
        public new static readonly StringName SetConnectionName = "setConnectionName";
        public new static readonly StringName SetConnectionUserData = "setConnectionUserData";
        public new static readonly StringName CheckPingDataUpToDate = "checkPingDataUpToDate";
        public new static readonly StringName ConvertPingLocationToString = "convertPingLocationToString";
        public new static readonly StringName EstimatePingTimeBetweenTwoLocations = "estimatePingTimeBetweenTwoLocations";
        public new static readonly StringName EstimatePingTimeFromLocalHost = "estimatePingTimeFromLocalHost";
        public new static readonly StringName GetConfigValue = "getConfigValue";
        public new static readonly StringName GetConfigValueInfo = "getConfigValueInfo";
        public new static readonly StringName GetDirectPingToPop = "getDirectPingToPOP";
        public new static readonly StringName GetIPv4FakeIpType = "getIPv4FakeIPType";
        public new static readonly StringName GetLocalPingLocation = "getLocalPingLocation";
        public new static readonly StringName GetLocalTimestamp = "getLocalTimestamp";
        public new static readonly StringName GetPingToDataCenter = "getPingToDataCenter";
        public new static readonly StringName GetPopCount = "getPOPCount";
        public new static readonly StringName GetPopList = "getPOPList";
        public new static readonly StringName GetRealIdentityForFakeIp = "getRealIdentityForFakeIP";
        public new static readonly StringName GetRelayNetworkStatus = "getRelayNetworkStatus";
        public new static readonly StringName InitRelayNetworkAccess = "initRelayNetworkAccess";
        public new static readonly StringName IsFakeIPv4 = "isFakeIPv4";
        public new static readonly StringName IterateGenericEditableConfigValues = "iterateGenericEditableConfigValues";
        public new static readonly StringName ParsePingLocationString = "parsePingLocationString";
        public new static readonly StringName SetConnectionConfigValueFloat = "setConnectionConfigValueFloat";
        public new static readonly StringName SetConnectionConfigValueInt32 = "setConnectionConfigValueInt32";
        public new static readonly StringName SetConnectionConfigValueString = "setConnectionConfigValueString";
        public new static readonly StringName SetGlobalConfigValueFloat = "setGlobalConfigValueFloat";
        public new static readonly StringName SetGlobalConfigValueInt32 = "setGlobalConfigValueInt32";
        public new static readonly StringName SetGlobalConfigValueString = "setGlobalConfigValueString";
        public new static readonly StringName IsParentalLockEnabled = "isParentalLockEnabled";
        public new static readonly StringName IsParentalLockLocked = "isParentalLockLocked";
        public new static readonly StringName IsAppBlocked = "isAppBlocked";
        public new static readonly StringName IsAppInBlockList = "isAppInBlockList";
        public new static readonly StringName IsFeatureBlocked = "isFeatureBlocked";
        public new static readonly StringName IsFeatureInBlockList = "isFeatureInBlockList";
        public new static readonly StringName CancelReservation = "cancelReservation";
        public new static readonly StringName ChangeNumOpenSlots = "changeNumOpenSlots";
        public new static readonly StringName CreateBeacon = "createBeacon";
        public new static readonly StringName DestroyBeacon = "destroyBeacon";
        public new static readonly StringName GetAvailableBeaconLocations = "getAvailableBeaconLocations";
        public new static readonly StringName GetBeaconByIndex = "getBeaconByIndex";
        public new static readonly StringName GetBeaconDetails = "getBeaconDetails";
        public new static readonly StringName GetBeaconLocationData = "getBeaconLocationData";
        public new static readonly StringName GetNumActiveBeacons = "getNumActiveBeacons";
        public new static readonly StringName GetNumAvailableBeaconLocations = "getNumAvailableBeaconLocations";
        public new static readonly StringName JoinParty = "joinParty";
        public new static readonly StringName OnReservationCompleted = "onReservationCompleted";
        public new static readonly StringName EnableRemotePlayTogetherDirectInput = "enableRemotePlayTogetherDirectInput";
        public new static readonly StringName DisableRemotePlayTogetherDirectInput = "disableRemotePlayTogetherDirectInput";
        public new static readonly StringName GetInput = "getInput";
        public new static readonly StringName GetLargeSessionAvatar = "getLargeSessionAvatar";
        public new static readonly StringName GetMediumSessionAvatar = "getMediumSessionAvatar";
        public new static readonly StringName GetSessionCount = "getSessionCount";
        public new static readonly StringName GetSessionGuestId = "getSessionGuestID";
        public new static readonly StringName GetSessionId = "getSessionID";
        public new static readonly StringName GetSessionSteamId = "getSessionSteamID";
        public new static readonly StringName GetSmallSessionAvatar = "getSmallSessionAvatar";
        public new static readonly StringName GetSessionClientName = "getSessionClientName";
        public new static readonly StringName GetSessionClientFormFactor = "getSessionClientFormFactor";
        public new static readonly StringName GetSessionClientResolution = "getSessionClientResolution";
        public new static readonly StringName SendRemotePlayTogetherInvite = "sendRemotePlayTogetherInvite";
        public new static readonly StringName SessionRemotePlayTogether = "sessionRemotePlayTogether";
        public new static readonly StringName SetMouseCursor = "setMouseCursor";
        public new static readonly StringName SetMousePosition = "setMousePosition";
        public new static readonly StringName SetMouseVisibility = "setMouseVisibility";
        public new static readonly StringName ShowRemotePlayTogetherUi = "showRemotePlayTogetherUI";
        public new static readonly StringName BeginFileWriteBatch = "beginFileWriteBatch";
        public new static readonly StringName EndFileWriteBatch = "endFileWriteBatch";
        public new static readonly StringName FileDelete = "fileDelete";
        public new static readonly StringName FileExists = "fileExists";
        public new static readonly StringName FileForget = "fileForget";
        public new static readonly StringName FilePersisted = "filePersisted";
        public new static readonly StringName FileRead = "fileRead";
        public new static readonly StringName FileReadAsync = "fileReadAsync";
        public new static readonly StringName FileShare = "fileShare";
        public new static readonly StringName FileWrite = "fileWrite";
        public new static readonly StringName FileWriteAsync = "fileWriteAsync";
        public new static readonly StringName FileWriteStreamCancel = "fileWriteStreamCancel";
        public new static readonly StringName FileWriteStreamClose = "fileWriteStreamClose";
        public new static readonly StringName FileWriteStreamOpen = "fileWriteStreamOpen";
        public new static readonly StringName FileWriteStreamWriteChunk = "fileWriteStreamWriteChunk";
        public new static readonly StringName GetCachedUgcCount = "getCachedUGCCount";
        public new static readonly StringName GetCachedUgcHandle = "getCachedUGCHandle";
        public new static readonly StringName GetFileCount = "getFileCount";
        public new static readonly StringName GetFileNameAndSize = "getFileNameAndSize";
        public new static readonly StringName GetFileSize = "getFileSize";
        public new static readonly StringName GetFileTimestamp = "getFileTimestamp";
        public new static readonly StringName GetLocalFileChange = "getLocalFileChange";
        public new static readonly StringName GetLocalFileChangeCount = "getLocalFileChangeCount";
        public new static readonly StringName GetQuota = "getQuota";
        public new static readonly StringName GetSyncPlatforms = "getSyncPlatforms";
        public new static readonly StringName GetUgcDetails = "getUGCDetails";
        public new static readonly StringName GetUgcDownloadProgress = "getUGCDownloadProgress";
        public new static readonly StringName IsCloudEnabledForAccount = "isCloudEnabledForAccount";
        public new static readonly StringName IsCloudEnabledForApp = "isCloudEnabledForApp";
        public new static readonly StringName SetCloudEnabledForApp = "setCloudEnabledForApp";
        public new static readonly StringName SetSyncPlatforms = "setSyncPlatforms";
        public new static readonly StringName UgcDownload = "ugcDownload";
        public new static readonly StringName UgcDownloadToLocation = "ugcDownloadToLocation";
        public new static readonly StringName UgcRead = "ugcRead";
        public new static readonly StringName AddScreenshotToLibrary = "addScreenshotToLibrary";
        public new static readonly StringName AddVrScreenshotToLibrary = "addVRScreenshotToLibrary";
        public new static readonly StringName HookScreenshots = "hookScreenshots";
        public new static readonly StringName IsScreenshotsHooked = "isScreenshotsHooked";
        public new static readonly StringName SetLocation = "setLocation";
        public new static readonly StringName TagPublishedFile = "tagPublishedFile";
        public new static readonly StringName TagUser = "tagUser";
        public new static readonly StringName TriggerScreenshot = "triggerScreenshot";
        public new static readonly StringName WriteScreenshot = "writeScreenshot";
        public new static readonly StringName AddGamePhaseTag = "addGamePhaseTag";
        public new static readonly StringName AddInstantaneousTimelineEvent = "addInstantaneousTimelineEvent";
        public new static readonly StringName AddRangeTimelineEvent = "addRangeTimelineEvent";
        public new static readonly StringName ClearTimelineTooltip = "clearTimelineTooltip";
        public new static readonly StringName DoesEventRecordingExist = "doesEventRecordingExist";
        public new static readonly StringName DoesGamePhaseRecordingExist = "doesGamePhaseRecordingExist";
        public new static readonly StringName EndGamePhase = "endGamePhase";
        public new static readonly StringName EndRangeTimelineEvent = "endRangeTimelineEvent";
        public new static readonly StringName OpenOverlayToGamePhase = "openOverlayToGamePhase";
        public new static readonly StringName OpenOverlayToTimelineEvent = "openOverlayToTimelineEvent";
        public new static readonly StringName RemoveTimelineEvent = "removeTimelineEvent";
        public new static readonly StringName SetGamePhaseAttribute = "setGamePhaseAttribute";
        public new static readonly StringName SetGamePhaseId = "setGamePhaseID";
        public new static readonly StringName SetTimelineGameMode = "setTimelineGameMode";
        public new static readonly StringName SetTimelineTooltip = "setTimelineTooltip";
        public new static readonly StringName StartGamePhase = "startGamePhase";
        public new static readonly StringName StartRangeTimelineEvent = "startRangeTimelineEvent";
        public new static readonly StringName UpdateRangeTimelineEvent = "updateRangeTimelineEvent";
        public new static readonly StringName AddAppDependency = "addAppDependency";
        public new static readonly StringName AddContentDescriptor = "addContentDescriptor";
        public new static readonly StringName AddDependency = "addDependency";
        public new static readonly StringName AddExcludedTag = "addExcludedTag";
        public new static readonly StringName AddItemKeyValueTag = "addItemKeyValueTag";
        public new static readonly StringName AddItemPreviewFile = "addItemPreviewFile";
        public new static readonly StringName AddItemPreviewVideo = "addItemPreviewVideo";
        public new static readonly StringName AddItemToFavorites = "addItemToFavorites";
        public new static readonly StringName AddRequiredKeyValueTag = "addRequiredKeyValueTag";
        public new static readonly StringName AddRequiredTag = "addRequiredTag";
        public new static readonly StringName AddRequiredTagGroup = "addRequiredTagGroup";
        public new static readonly StringName InitWorkshopForGameServer = "initWorkshopForGameServer";
        public new static readonly StringName MarkDownloadedItemAsUnused = "markDownloadedItemAsUnused";
        public new static readonly StringName CreateItem = "createItem";
        public new static readonly StringName CreateQueryAllUgcRequestPage = "createQueryAllUGCRequestPage";
        public new static readonly StringName CreateQueryAllUgcRequestCursor = "createQueryAllUGCRequestCursor";
        public new static readonly StringName CreateQueryUgcDetailsRequest = "createQueryUGCDetailsRequest";
        public new static readonly StringName CreateQueryUserUgcRequest = "createQueryUserUGCRequest";
        public new static readonly StringName DeleteItem = "deleteItem";
        public new static readonly StringName DownloadItem = "downloadItem";
        public new static readonly StringName GetAppDependencies = "getAppDependencies";
        public new static readonly StringName GetDownloadedItems = "getDownloadedItems";
        public new static readonly StringName GetItemDownloadInfo = "getItemDownloadInfo";
        public new static readonly StringName GetItemInstallInfo = "getItemInstallInfo";
        public new static readonly StringName GetItemState = "getItemState";
        public new static readonly StringName GetItemUpdateProgress = "getItemUpdateProgress";
        public new static readonly StringName GetNumDownloadedItems = "getNumDownloadedItems";
        public new static readonly StringName GetNumSubscribedItems = "getNumSubscribedItems";
        public new static readonly StringName GetNumSupportedGameVersions = "getNumSupportedGameVersions";
        public new static readonly StringName GetQueryUgcAdditionalPreview = "getQueryUGCAdditionalPreview";
        public new static readonly StringName GetQueryUgcChildren = "getQueryUGCChildren";
        public new static readonly StringName GetQueryUgcContentDescriptors = "getQueryUGCContentDescriptors";
        public new static readonly StringName GetQueryUgcKeyValueTag = "getQueryUGCKeyValueTag";
        public new static readonly StringName GetQueryUgcMetadata = "getQueryUGCMetadata";
        public new static readonly StringName GetQueryUgcNumAdditionalPreviews = "getQueryUGCNumAdditionalPreviews";
        public new static readonly StringName GetQueryUgcNumKeyValueTags = "getQueryUGCNumKeyValueTags";
        public new static readonly StringName GetQueryUgcNumTags = "getQueryUGCNumTags";
        public new static readonly StringName GetQueryUgcPreviewUrl = "getQueryUGCPreviewURL";
        public new static readonly StringName GetQueryUgcResult = "getQueryUGCResult";
        public new static readonly StringName GetQueryUgcStatistic = "getQueryUGCStatistic";
        public new static readonly StringName GetQueryUgcTag = "getQueryUGCTag";
        public new static readonly StringName GetQueryUgcTagDisplayName = "getQueryUGCTagDisplayName";
        public new static readonly StringName GetSubscribedItems = "getSubscribedItems";
        public new static readonly StringName GetSupportedGameVersionData = "getSupportedGameVersionData";
        public new static readonly StringName GetUserContentDescriptorPreferences = "getUserContentDescriptorPreferences";
        public new static readonly StringName GetUserItemVote = "getUserItemVote";
        public new static readonly StringName ReleaseQueryUgcRequest = "releaseQueryUGCRequest";
        public new static readonly StringName RemoveAllItemKeyValueTags = "removeAllItemKeyValueTags";
        public new static readonly StringName RemoveAppDependency = "removeAppDependency";
        public new static readonly StringName RemoveContentDescriptor = "removeContentDescriptor";
        public new static readonly StringName RemoveDependency = "removeDependency";
        public new static readonly StringName RemoveItemFromFavorites = "removeItemFromFavorites";
        public new static readonly StringName RemoveItemKeyValueTags = "removeItemKeyValueTags";
        public new static readonly StringName RemoveItemPreview = "removeItemPreview";
        public new static readonly StringName SendQueryUgcRequest = "sendQueryUGCRequest";
        public new static readonly StringName SetAdminQuery = "setAdminQuery";
        public new static readonly StringName SetAllowCachedResponse = "setAllowCachedResponse";
        public new static readonly StringName SetAllowLegacyUpload = "setAllowLegacyUpload";
        public new static readonly StringName SetCloudFileNameFilter = "setCloudFileNameFilter";
        public new static readonly StringName SetItemContent = "setItemContent";
        public new static readonly StringName SetItemDescription = "setItemDescription";
        public new static readonly StringName SetItemMetadata = "setItemMetadata";
        public new static readonly StringName SetItemPreview = "setItemPreview";
        public new static readonly StringName SetItemTags = "setItemTags";
        public new static readonly StringName SetItemTitle = "setItemTitle";
        public new static readonly StringName SetItemUpdateLanguage = "setItemUpdateLanguage";
        public new static readonly StringName SetItemVisibility = "setItemVisibility";
        public new static readonly StringName SetItemsDisabledLocally = "setItemsDisabledLocally";
        public new static readonly StringName SetLanguage = "setLanguage";
        public new static readonly StringName SetMatchAnyTag = "setMatchAnyTag";
        public new static readonly StringName SetRankedByTrendDays = "setRankedByTrendDays";
        public new static readonly StringName SetRequiredGameVersions = "setRequiredGameVersions";
        public new static readonly StringName SetReturnAdditionalPreviews = "setReturnAdditionalPreviews";
        public new static readonly StringName SetReturnChildren = "setReturnChildren";
        public new static readonly StringName SetReturnKeyValueTags = "setReturnKeyValueTags";
        public new static readonly StringName SetReturnLongDescription = "setReturnLongDescription";
        public new static readonly StringName SetReturnMetadata = "setReturnMetadata";
        public new static readonly StringName SetReturnOnlyIDs = "setReturnOnlyIDs";
        public new static readonly StringName SetReturnPlaytimeStats = "setReturnPlaytimeStats";
        public new static readonly StringName SetReturnTotalOnly = "setReturnTotalOnly";
        public new static readonly StringName SetSearchText = "setSearchText";
        public new static readonly StringName SetSubscriptionsLoadOrder = "setSubscriptionsLoadOrder";
        public new static readonly StringName SetUserItemVote = "setUserItemVote";
        public new static readonly StringName StartItemUpdate = "startItemUpdate";
        public new static readonly StringName StartPlaytimeTracking = "startPlaytimeTracking";
        public new static readonly StringName StopPlaytimeTracking = "stopPlaytimeTracking";
        public new static readonly StringName StopPlaytimeTrackingForAllItems = "stopPlaytimeTrackingForAllItems";
        public new static readonly StringName SubmitItemUpdate = "submitItemUpdate";
        public new static readonly StringName SubscribeItem = "subscribeItem";
        public new static readonly StringName SuspendDownloads = "suspendDownloads";
        public new static readonly StringName UnsubscribeItem = "unsubscribeItem";
        public new static readonly StringName UpdateItemPreviewFile = "updateItemPreviewFile";
        public new static readonly StringName UpdateItemPreviewVideo = "updateItemPreviewVideo";
        public new static readonly StringName ShowWorkshopEula = "showWorkshopEULA";
        public new static readonly StringName GetWorkshopEulaStatus = "getWorkshopEULAStatus";
        public new static readonly StringName SetTimeCreatedDateRange = "setTimeCreatedDateRange";
        public new static readonly StringName SetTimeUpdatedDateRange = "setTimeUpdatedDateRange";
        public new static readonly StringName AdvertiseGame = "advertiseGame";
        public new static readonly StringName BeginAuthSession = "beginAuthSession";
        public new static readonly StringName CancelAuthTicket = "cancelAuthTicket";
        public new static readonly StringName DecompressVoice = "decompressVoice";
        public new static readonly StringName EndAuthSession = "endAuthSession";
        public new static readonly StringName GetAuthSessionTicket = "getAuthSessionTicket";
        public new static readonly StringName GetAuthTicketForWebApi = "getAuthTicketForWebApi";
        public new static readonly StringName GetAvailableVoice = "getAvailableVoice";
        public new static readonly StringName GetDurationControl = "getDurationControl";
        public new static readonly StringName GetEncryptedAppTicket = "getEncryptedAppTicket";
        public new static readonly StringName GetGameBadgeLevel = "getGameBadgeLevel";
        public new static readonly StringName GetPlayerSteamLevel = "getPlayerSteamLevel";
        public new static readonly StringName GetSteamId = "getSteamID";
        public new static readonly StringName GetVoice = "getVoice";
        public new static readonly StringName GetVoiceOptimalSampleRate = "getVoiceOptimalSampleRate";
        public new static readonly StringName InitiateGameConnection = "initiateGameConnection";
        public new static readonly StringName IsBehindNat = "isBehindNAT";
        public new static readonly StringName IsPhoneIdentifying = "isPhoneIdentifying";
        public new static readonly StringName IsPhoneRequiringVerification = "isPhoneRequiringVerification";
        public new static readonly StringName IsPhoneVerified = "isPhoneVerified";
        public new static readonly StringName IsTwoFactorEnabled = "isTwoFactorEnabled";
        public new static readonly StringName LoggedOn = "loggedOn";
        public new static readonly StringName RequestEncryptedAppTicket = "requestEncryptedAppTicket";
        public new static readonly StringName RequestStoreAuthUrl = "requestStoreAuthURL";
        public new static readonly StringName StartVoiceRecording = "startVoiceRecording";
        public new static readonly StringName SetDurationControlOnlineState = "setDurationControlOnlineState";
        public new static readonly StringName StopVoiceRecording = "stopVoiceRecording";
        public new static readonly StringName TerminateGameConnection = "terminateGameConnection";
        public new static readonly StringName UserHasLicenseForApp = "userHasLicenseForApp";
        public new static readonly StringName AttachLeaderboardUgc = "attachLeaderboardUGC";
        public new static readonly StringName ClearAchievement = "clearAchievement";
        public new static readonly StringName DownloadLeaderboardEntries = "downloadLeaderboardEntries";
        public new static readonly StringName DownloadLeaderboardEntriesForUsers = "downloadLeaderboardEntriesForUsers";
        public new static readonly StringName FindLeaderboard = "findLeaderboard";
        public new static readonly StringName FindOrCreateLeaderboard = "findOrCreateLeaderboard";
        public new static readonly StringName GetAchievement = "getAchievement";
        public new static readonly StringName GetAchievementAchievedPercent = "getAchievementAchievedPercent";
        public new static readonly StringName GetAchievementAndUnlockTime = "getAchievementAndUnlockTime";
        public new static readonly StringName GetAchievementDisplayAttribute = "getAchievementDisplayAttribute";
        public new static readonly StringName GetAchievementIcon = "getAchievementIcon";
        public new static readonly StringName GetAchievementName = "getAchievementName";
        public new static readonly StringName GetAchievementProgressLimitsInt = "getAchievementProgressLimitsInt";
        public new static readonly StringName GetAchievementProgressLimitsFloat = "getAchievementProgressLimitsFloat";
        public new static readonly StringName GetGlobalStatInt = "getGlobalStatInt";
        public new static readonly StringName GetGlobalStatFloat = "getGlobalStatFloat";
        public new static readonly StringName GetGlobalStatIntHistory = "getGlobalStatIntHistory";
        public new static readonly StringName GetGlobalStatFloatHistory = "getGlobalStatFloatHistory";
        public new static readonly StringName GetLeaderboardDisplayType = "getLeaderboardDisplayType";
        public new static readonly StringName GetLeaderboardEntryCount = "getLeaderboardEntryCount";
        public new static readonly StringName GetLeaderboardName = "getLeaderboardName";
        public new static readonly StringName GetLeaderboardSortMethod = "getLeaderboardSortMethod";
        public new static readonly StringName GetMostAchievedAchievementInfo = "getMostAchievedAchievementInfo";
        public new static readonly StringName GetNextMostAchievedAchievementInfo = "getNextMostAchievedAchievementInfo";
        public new static readonly StringName GetNumAchievements = "getNumAchievements";
        public new static readonly StringName GetNumberOfCurrentPlayers = "getNumberOfCurrentPlayers";
        public new static readonly StringName GetStatFloat = "getStatFloat";
        public new static readonly StringName GetStatInt = "getStatInt";
        public new static readonly StringName GetUserAchievement = "getUserAchievement";
        public new static readonly StringName GetUserAchievementAndUnlockTime = "getUserAchievementAndUnlockTime";
        public new static readonly StringName GetUserStatFloat = "getUserStatFloat";
        public new static readonly StringName GetUserStatInt = "getUserStatInt";
        public new static readonly StringName IndicateAchievementProgress = "indicateAchievementProgress";
        public new static readonly StringName RequestGlobalAchievementPercentages = "requestGlobalAchievementPercentages";
        public new static readonly StringName RequestGlobalStats = "requestGlobalStats";
        public new static readonly StringName RequestUserStats = "requestUserStats";
        public new static readonly StringName ResetAllStats = "resetAllStats";
        public new static readonly StringName SetAchievement = "setAchievement";
        public new static readonly StringName SetStatFloat = "setStatFloat";
        public new static readonly StringName SetStatInt = "setStatInt";
        public new static readonly StringName StoreStats = "storeStats";
        public new static readonly StringName UpdateAvgRateStat = "updateAvgRateStat";
        public new static readonly StringName UploadLeaderboardScore = "uploadLeaderboardScore";
        public new static readonly StringName CheckFileSignature = "checkFileSignature";
        public new static readonly StringName DismissFloatingGamepadTextInput = "dismissFloatingGamepadTextInput";
        public new static readonly StringName DismissGamepadTextInput = "dismissGamepadTextInput";
        public new static readonly StringName FilterText = "filterText";
        public new static readonly StringName GetApiCallFailureReason = "getAPICallFailureReason";
        public new static readonly StringName GetAppId = "getAppID";
        public new static readonly StringName GetConnectedUniverse = "getConnectedUniverse";
        public new static readonly StringName GetCurrentBatteryPower = "getCurrentBatteryPower";
        public new static readonly StringName GetImageRgba = "getImageRGBA";
        public new static readonly StringName GetImageSize = "getImageSize";
        public new static readonly StringName GetIpcCallCount = "getIPCCallCount";
        public new static readonly StringName GetIpCountry = "getIPCountry";
        public new static readonly StringName GetIPv6ConnectivityState = "getIPv6ConnectivityState";
        public new static readonly StringName GetSecondsSinceAppActive = "getSecondsSinceAppActive";
        public new static readonly StringName GetSecondsSinceComputerActive = "getSecondsSinceComputerActive";
        public new static readonly StringName GetServerRealTime = "getServerRealTime";
        public new static readonly StringName GetSteamHardwareDefaultConfig = "getSteamHardwareDefaultConfig";
        public new static readonly StringName GetSteamUiLanguage = "getSteamUILanguage";
        public new static readonly StringName InitFilterText = "initFilterText";
        public new static readonly StringName IsApiCallCompleted = "isAPICallCompleted";
        public new static readonly StringName IsOverlayEnabled = "isOverlayEnabled";
        public new static readonly StringName IsRunningOnSteamHardware = "isRunningOnSteamHardware";
        public new static readonly StringName IsSteamChinaLauncher = "isSteamChinaLauncher";
        public new static readonly StringName IsRunningUnderProton = "isRunningUnderProton";
        public new static readonly StringName IsSteamInBigPictureMode = "isSteamInBigPictureMode";
        public new static readonly StringName IsSteamRunningInVr = "isSteamRunningInVR";
        public new static readonly StringName IsVrHeadsetStreamingEnabled = "isVRHeadsetStreamingEnabled";
        public new static readonly StringName OverlayNeedsPresent = "overlayNeedsPresent";
        public new static readonly StringName SetGameLauncherMode = "setGameLauncherMode";
        public new static readonly StringName SetOverlayNotificationInset = "setOverlayNotificationInset";
        public new static readonly StringName SetOverlayNotificationPosition = "setOverlayNotificationPosition";
        public new static readonly StringName SetVrHeadsetStreamingEnabled = "setVRHeadsetStreamingEnabled";
        public new static readonly StringName ShowFloatingGamepadTextInput = "showFloatingGamepadTextInput";
        public new static readonly StringName ShowGamepadTextInput = "showGamepadTextInput";
        public new static readonly StringName StartVrDashboard = "startVRDashboard";
        public new static readonly StringName GetOpfSettings = "getOPFSettings";
        public new static readonly StringName GetOpfStringForApp = "getOPFStringForApp";
        public new static readonly StringName GetVideoUrl = "getVideoURL";
        public new static readonly StringName IsBroadcasting = "isBroadcasting";
    }

    public new string GetGodotsteamVersion() => 
        Call(GDExtensionMethodName.GetGodotsteamVersion, []).As<string>();

    public new long GetSteamId32(ulong steamId) =>
        Call(GDExtensionMethodName.GetSteamId32, [steamId]).As<long>();

    public new bool IsAnonAccount(long steamId) => 
        Call(GDExtensionMethodName.IsAnonAccount, [steamId]).As<bool>();

    public new bool IsAnonUserAccount(long steamId) => 
        Call(GDExtensionMethodName.IsAnonUserAccount, [steamId]).As<bool>();

    public new bool IsChatAccount(long steamId) => 
        Call(GDExtensionMethodName.IsChatAccount, [steamId]).As<bool>();

    public new bool IsClanAccount(long steamId) => 
        Call(GDExtensionMethodName.IsClanAccount, [steamId]).As<bool>();

    public new bool IsConsoleUserAccount(long steamId) => 
        Call(GDExtensionMethodName.IsConsoleUserAccount, [steamId]).As<bool>();

    public new bool IsIndividualAccount(long steamId) => 
        Call(GDExtensionMethodName.IsIndividualAccount, [steamId]).As<bool>();

    public new bool IsLobby(long steamId) => 
        Call(GDExtensionMethodName.IsLobby, [steamId]).As<bool>();

    public new bool IsSteamRunning() => 
        Call(GDExtensionMethodName.IsSteamRunning, []).As<bool>();

    public new void RunCallbacks() => 
        Call(GDExtensionMethodName.RunCallbacks, []);

    public new bool RestartAppIfNecessary(long appId) => 
        Call(GDExtensionMethodName.RestartAppIfNecessary, [appId]).As<bool>();

    public new bool SteamInit(long appId = 0, bool embedCallbacks = false) => 
        Call(GDExtensionMethodName.SteamInit, [appId, embedCallbacks]).As<bool>();

    public new Godot.Collections.Dictionary SteamInitEx(long appId = 0, bool embedCallbacks = false) => 
        Call(GDExtensionMethodName.SteamInitEx, [appId, embedCallbacks]).As<Godot.Collections.Dictionary>();

    public new void ReleaseCurrentThreadMemory() => 
        Call(GDExtensionMethodName.ReleaseCurrentThreadMemory, []);

    public new void SteamShutdown() => 
        Call(GDExtensionMethodName.SteamShutdown, []);

    public new long GetServerListRequest() => 
        Call(GDExtensionMethodName.GetServerListRequest, []).As<long>();

    public new Godot.Collections.Dictionary GetSteamInitResult() => 
        Call(GDExtensionMethodName.GetSteamInitResult, []).As<Godot.Collections.Dictionary>();

    public new void SetServerListRequest(long newServerListRequest) => 
        Call(GDExtensionMethodName.SetServerListRequest, [newServerListRequest]);

    public new long GetAppBuildId() => 
        Call(GDExtensionMethodName.GetAppBuildId, []).As<long>();

    public new string GetAppInstallDir(long appId) => 
        Call(GDExtensionMethodName.GetAppInstallDir, [appId]).As<string>();

    public new long GetAppOwner() => 
        Call(GDExtensionMethodName.GetAppOwner, []).As<long>();

    public new string GetAvailableGameLanguages() => 
        Call(GDExtensionMethodName.GetAvailableGameLanguages, []).As<string>();

    public new Godot.Collections.Dictionary GetBetaInfo() => 
        Call(GDExtensionMethodName.GetBetaInfo, []).As<Godot.Collections.Dictionary>();

    public new string GetCurrentBetaName() => 
        Call(GDExtensionMethodName.GetCurrentBetaName, []).As<string>();

    public new string GetCurrentGameLanguage() => 
        Call(GDExtensionMethodName.GetCurrentGameLanguage, []).As<string>();

    public new long GetDlcCount() => 
        Call(GDExtensionMethodName.GetDlcCount, []).As<long>();

    public new Godot.Collections.Array GetDlcData() => 
        Call(GDExtensionMethodName.GetDlcData, []).As<Godot.Collections.Array>();

    public new Godot.Collections.Dictionary GetDlcDataByIndex(long thisDlcIndex) => 
        Call(GDExtensionMethodName.GetDlcDataByIndex, [thisDlcIndex]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetDlcDownloadProgress(long dlcId) => 
        Call(GDExtensionMethodName.GetDlcDownloadProgress, [dlcId]).As<Godot.Collections.Dictionary>();

    public new long GetEarliestPurchaseUnixTime(long appId) => 
        Call(GDExtensionMethodName.GetEarliestPurchaseUnixTime, [appId]).As<long>();

    public new void GetFileDetails(string filename) => 
        Call(GDExtensionMethodName.GetFileDetails, [filename]);

    public new Godot.Collections.Array GetInstalledDepots(long appId) => 
        Call(GDExtensionMethodName.GetInstalledDepots, [appId]).As<Godot.Collections.Array>();

    public new string GetLaunchCommandLine() => 
        Call(GDExtensionMethodName.GetLaunchCommandLine, []).As<string>();

    public new string GetLaunchQueryParam(string key) => 
        Call(GDExtensionMethodName.GetLaunchQueryParam, [key]).As<string>();

    public new Godot.Collections.Dictionary GetNumBetas() => 
        Call(GDExtensionMethodName.GetNumBetas, []).As<Godot.Collections.Dictionary>();

    public new void InstallDlc(long dlcId) => 
        Call(GDExtensionMethodName.InstallDlc, [dlcId]);

    public new bool IsAppInstalled(long appId) => 
        Call(GDExtensionMethodName.IsAppInstalled, [appId]).As<bool>();

    public new bool IsCybercafe() => 
        Call(GDExtensionMethodName.IsCybercafe, []).As<bool>();

    public new bool IsDlcInstalled(long dlcId) => 
        Call(GDExtensionMethodName.IsDlcInstalled, [dlcId]).As<bool>();

    public new bool IsLowViolence() => 
        Call(GDExtensionMethodName.IsLowViolence, []).As<bool>();

    public new bool IsSubscribed() => 
        Call(GDExtensionMethodName.IsSubscribed, []).As<bool>();

    public new bool IsSubscribedApp(long appId) => 
        Call(GDExtensionMethodName.IsSubscribedApp, [appId]).As<bool>();

    public new bool IsSubscribedFromFamilySharing() => 
        Call(GDExtensionMethodName.IsSubscribedFromFamilySharing, []).As<bool>();

    public new bool IsSubscribedFromFreeWeekend() => 
        Call(GDExtensionMethodName.IsSubscribedFromFreeWeekend, []).As<bool>();

    public new Godot.Collections.Dictionary IsTimedTrial() => 
        Call(GDExtensionMethodName.IsTimedTrial, []).As<Godot.Collections.Dictionary>();

    public new bool IsVacBanned() => 
        Call(GDExtensionMethodName.IsVacBanned, []).As<bool>();

    public new bool MarkContentCorrupt(bool missingFilesOnly) => 
        Call(GDExtensionMethodName.MarkContentCorrupt, [missingFilesOnly]).As<bool>();

    public new bool SetActiveBeta(string betaName) => 
        Call(GDExtensionMethodName.SetActiveBeta, [betaName]).As<bool>();

    public new bool SetDlcContext(long appId) => 
        Call(GDExtensionMethodName.SetDlcContext, [appId]).As<bool>();

    public new void SetGamePerformanceSettings(Steam.GamePerformanceSetting setting) => 
        Call(GDExtensionMethodName.SetGamePerformanceSettings, [Variant.From(setting)]);

    public new void SetGameRenderResolution(long width, long height) => 
        Call(GDExtensionMethodName.SetGameRenderResolution, [width, height]);

    public new void UninstallDlc(long dlcId) => 
        Call(GDExtensionMethodName.UninstallDlc, [dlcId]);

    public new void ActivateGameOverlay(string type = "") => 
        Call(GDExtensionMethodName.ActivateGameOverlay, [type]);

    public new void ActivateGameOverlayInviteDialog(long lobbyId) => 
        Call(GDExtensionMethodName.ActivateGameOverlayInviteDialog, [lobbyId]);

    public new void ActivateGameOverlayInviteDialogConnectString(string connectString) => 
        Call(GDExtensionMethodName.ActivateGameOverlayInviteDialogConnectString, [connectString]);

    public new void ActivateGameOverlayRemotePlayTogetherInviteDialog(long lobbyId) => 
        Call(GDExtensionMethodName.ActivateGameOverlayRemotePlayTogetherInviteDialog, [lobbyId]);

    public new void ActivateGameOverlayToStore(long appId, Steam.OverlayToStoreFlag storeFlag = Steam.OverlayToStoreFlag.None) => 
        Call(GDExtensionMethodName.ActivateGameOverlayToStore, [appId, Variant.From(storeFlag)]);

    public new void ActivateGameOverlayToUser(string type = "", long steamId = 0) => 
        Call(GDExtensionMethodName.ActivateGameOverlayToUser, [type, steamId]);

    public new void ActivateGameOverlayToWebPage(string url, Steam.OverlayToWebPageMode webpageMode = Steam.OverlayToWebPageMode.Default) => 
        Call(GDExtensionMethodName.ActivateGameOverlayToWebPage, [url, Variant.From(webpageMode)]);

    public new void ClearRichPresence() => 
        Call(GDExtensionMethodName.ClearRichPresence, []);

    public new bool CloseClanChatWindowInSteam(long chatId) => 
        Call(GDExtensionMethodName.CloseClanChatWindowInSteam, [chatId]).As<bool>();

    public new void DownloadClanActivityCounts(long[] clanIdArray) => 
        Call(GDExtensionMethodName.DownloadClanActivityCounts, [clanIdArray]);

    public new void EnumerateFollowingList(long startIndex) => 
        Call(GDExtensionMethodName.EnumerateFollowingList, [startIndex]);

    public new long GetChatMemberByIndex(long clanId, long user) => 
        Call(GDExtensionMethodName.GetChatMemberByIndex, [clanId, user]).As<long>();

    public new Godot.Collections.Dictionary GetClanActivityCounts(long clanId) => 
        Call(GDExtensionMethodName.GetClanActivityCounts, [clanId]).As<Godot.Collections.Dictionary>();

    public new long GetClanByIndex(long clanIndex) => 
        Call(GDExtensionMethodName.GetClanByIndex, [clanIndex]).As<long>();

    public new long GetClanChatMemberCount(long clanId) => 
        Call(GDExtensionMethodName.GetClanChatMemberCount, [clanId]).As<long>();

    public new long GetClanCount() => 
        Call(GDExtensionMethodName.GetClanCount, []).As<long>();

    public new string GetClanName(long clanId) => 
        Call(GDExtensionMethodName.GetClanName, [clanId]).As<string>();

    public new long GetClanOfficerByIndex(long clanId, long officerIndex) => 
        Call(GDExtensionMethodName.GetClanOfficerByIndex, [clanId, officerIndex]).As<long>();

    public new long GetClanOfficerCount(long clanId) => 
        Call(GDExtensionMethodName.GetClanOfficerCount, [clanId]).As<long>();

    public new long GetClanOwner(long clanId) => 
        Call(GDExtensionMethodName.GetClanOwner, [clanId]).As<long>();

    public new string GetClanTag(long clanId) => 
        Call(GDExtensionMethodName.GetClanTag, [clanId]).As<string>();

    public new long GetCoplayFriend(long friendIndex) => 
        Call(GDExtensionMethodName.GetCoplayFriend, [friendIndex]).As<long>();

    public new long GetCoplayFriendCount() => 
        Call(GDExtensionMethodName.GetCoplayFriendCount, []).As<long>();

    public new void GetFollowerCount(long steamId) => 
        Call(GDExtensionMethodName.GetFollowerCount, [steamId]);

    public new long GetFriendByIndex(long friendNumber, long friendFlags) => 
        Call(GDExtensionMethodName.GetFriendByIndex, [friendNumber, friendFlags]).As<long>();

    public new long GetFriendCoplayGame(long friendId) => 
        Call(GDExtensionMethodName.GetFriendCoplayGame, [friendId]).As<long>();

    public new long GetFriendCoplayTime(long friendId) => 
        Call(GDExtensionMethodName.GetFriendCoplayTime, [friendId]).As<long>();

    public new long GetFriendCount(long friendFlags = 65535) => 
        Call(GDExtensionMethodName.GetFriendCount, [friendFlags]).As<long>();

    public new long GetFriendCountFromSource(long sourceId) => 
        Call(GDExtensionMethodName.GetFriendCountFromSource, [sourceId]).As<long>();

    public new long GetFriendFromSourceByIndex(long sourceId, long friendNumber) => 
        Call(GDExtensionMethodName.GetFriendFromSourceByIndex, [sourceId, friendNumber]).As<long>();

    public new Godot.Collections.Dictionary GetFriendGamePlayed(long steamId) => 
        Call(GDExtensionMethodName.GetFriendGamePlayed, [steamId]).As<Godot.Collections.Dictionary>();

    public new string GetFriendPersonaName(long steamId) => 
        Call(GDExtensionMethodName.GetFriendPersonaName, [steamId]).As<string>();

    public new string GetFriendPersonaNameHistory(long steamId, long nameHistory) => 
        Call(GDExtensionMethodName.GetFriendPersonaNameHistory, [steamId, nameHistory]).As<string>();

    public new Steam.PersonaState GetFriendPersonaState(long steamId) => 
        Call(GDExtensionMethodName.GetFriendPersonaState, [steamId]).As<Steam.PersonaState>();

    public new Steam.FriendRelationship GetFriendRelationship(long steamId) => 
        Call(GDExtensionMethodName.GetFriendRelationship, [steamId]).As<Steam.FriendRelationship>();

    public new string GetFriendRichPresence(long friendId, string key) => 
        Call(GDExtensionMethodName.GetFriendRichPresence, [friendId, key]).As<string>();

    public new long GetFriendRichPresenceKeyCount(long friendId) => 
        Call(GDExtensionMethodName.GetFriendRichPresenceKeyCount, [friendId]).As<long>();

    public new string GetFriendRichPresenceKeyByIndex(long friendId, long keyIndex) => 
        Call(GDExtensionMethodName.GetFriendRichPresenceKeyByIndex, [friendId, keyIndex]).As<string>();

    public new long GetFriendsGroupCount() => 
        Call(GDExtensionMethodName.GetFriendsGroupCount, []).As<long>();

    public new long GetFriendsGroupIdByIndex(long friendGroup) => 
        Call(GDExtensionMethodName.GetFriendsGroupIdByIndex, [friendGroup]).As<long>();

    public new long GetFriendsGroupMembersCount(long friendGroup) => 
        Call(GDExtensionMethodName.GetFriendsGroupMembersCount, [friendGroup]).As<long>();

    public new Godot.Collections.Array GetFriendsGroupMembersList(long friendGroup, long memberCount) => 
        Call(GDExtensionMethodName.GetFriendsGroupMembersList, [friendGroup, memberCount]).As<Godot.Collections.Array>();

    public new string GetFriendsGroupName(long friendGroup) => 
        Call(GDExtensionMethodName.GetFriendsGroupName, [friendGroup]).As<string>();

    public new long GetFriendSteamLevel(long steamId) => 
        Call(GDExtensionMethodName.GetFriendSteamLevel, [steamId]).As<long>();

    public new long GetLargeFriendAvatar(long steamId) => 
        Call(GDExtensionMethodName.GetLargeFriendAvatar, [steamId]).As<long>();

    public new long GetMediumFriendAvatar(long steamId) => 
        Call(GDExtensionMethodName.GetMediumFriendAvatar, [steamId]).As<long>();

    public new string GetPersonaName() => 
        Call(GDExtensionMethodName.GetPersonaName, []).As<string>();

    public new Steam.PersonaState GetPersonaState() => 
        Call(GDExtensionMethodName.GetPersonaState, []).As<Steam.PersonaState>();

    public new void GetPlayerAvatar(long size = 2, long steamId = 0) => 
        Call(GDExtensionMethodName.GetPlayerAvatar, [size, steamId]);

    public new string GetPlayerNickname(long steamId) => 
        Call(GDExtensionMethodName.GetPlayerNickname, [steamId]).As<string>();

    public new string GetProfileItemPropertyString(long steamId, Steam.CommunityProfileItemType itemType, Steam.CommunityProfileItemProperty itemProperty) => 
        Call(GDExtensionMethodName.GetProfileItemPropertyString, [steamId, Variant.From(itemType), Variant.From(itemProperty)]).As<string>();

    public new long GetProfileItemPropertyInt(long steamId, Steam.CommunityProfileItemType itemType, Steam.CommunityProfileItemProperty itemProperty) => 
        Call(GDExtensionMethodName.GetProfileItemPropertyInt, [steamId, Variant.From(itemType), Variant.From(itemProperty)]).As<long>();

    public new Godot.Collections.Array GetRecentPlayers() => 
        Call(GDExtensionMethodName.GetRecentPlayers, []).As<Godot.Collections.Array>();

    public new long GetSmallFriendAvatar(long steamId) => 
        Call(GDExtensionMethodName.GetSmallFriendAvatar, [steamId]).As<long>();

    public new Godot.Collections.Array GetUserFriendsGroups() => 
        Call(GDExtensionMethodName.GetUserFriendsGroups, []).As<Godot.Collections.Array>();

    public new Godot.Collections.Array GetUserSteamFriends() => 
        Call(GDExtensionMethodName.GetUserSteamFriends, []).As<Godot.Collections.Array>();

    public new Godot.Collections.Array GetUserSteamGroups() => 
        Call(GDExtensionMethodName.GetUserSteamGroups, []).As<Godot.Collections.Array>();

    public new bool HasEquippedProfileItem(long steamId, Steam.CommunityProfileItemType friendFlags) => 
        Call(GDExtensionMethodName.HasEquippedProfileItem, [steamId, Variant.From(friendFlags)]).As<bool>();

    public new bool HasFriend(long steamId, long friendFlags) => 
        Call(GDExtensionMethodName.HasFriend, [steamId, friendFlags]).As<bool>();

    public new bool InviteUserToGame(long friendId, string connectString) => 
        Call(GDExtensionMethodName.InviteUserToGame, [friendId, connectString]).As<bool>();

    public new bool IsClanChatAdmin(long chatId, long steamId) => 
        Call(GDExtensionMethodName.IsClanChatAdmin, [chatId, steamId]).As<bool>();

    public new bool IsClanPublic(long clanId) => 
        Call(GDExtensionMethodName.IsClanPublic, [clanId]).As<bool>();

    public new bool IsClanOfficialGameGroup(long clanId) => 
        Call(GDExtensionMethodName.IsClanOfficialGameGroup, [clanId]).As<bool>();

    public new bool IsClanChatWindowOpenInSteam(long chatId) => 
        Call(GDExtensionMethodName.IsClanChatWindowOpenInSteam, [chatId]).As<bool>();

    public new void IsFollowing(long steamId) => 
        Call(GDExtensionMethodName.IsFollowing, [steamId]);

    public new bool IsUserInSource(long steamId, long sourceId) => 
        Call(GDExtensionMethodName.IsUserInSource, [steamId, sourceId]).As<bool>();

    public new void JoinClanChatRoom(long clanId) => 
        Call(GDExtensionMethodName.JoinClanChatRoom, [clanId]);

    public new bool LeaveClanChatRoom(long clanId) => 
        Call(GDExtensionMethodName.LeaveClanChatRoom, [clanId]).As<bool>();

    public new bool OpenClanChatWindowInSteam(long chatId) => 
        Call(GDExtensionMethodName.OpenClanChatWindowInSteam, [chatId]).As<bool>();

    public new bool RegisterProtocolInOverlayBrowser(string protocol) => 
        Call(GDExtensionMethodName.RegisterProtocolInOverlayBrowser, [protocol]).As<bool>();

    public new bool ReplyToFriendMessage(long steamId, string message) => 
        Call(GDExtensionMethodName.ReplyToFriendMessage, [steamId, message]).As<bool>();

    public new void RequestClanOfficerList(long clanId) => 
        Call(GDExtensionMethodName.RequestClanOfficerList, [clanId]);

    public new void RequestEquippedProfileItems(long steamId) => 
        Call(GDExtensionMethodName.RequestEquippedProfileItems, [steamId]);

    public new void RequestFriendRichPresence(long friendId) => 
        Call(GDExtensionMethodName.RequestFriendRichPresence, [friendId]);

    public new bool RequestUserInformation(long steamId, bool requireNameOnly) => 
        Call(GDExtensionMethodName.RequestUserInformation, [steamId, requireNameOnly]).As<bool>();

    public new bool SendClanChatMessage(long chatId, string text) => 
        Call(GDExtensionMethodName.SendClanChatMessage, [chatId, text]).As<bool>();

    public new void SetInGameVoiceSpeaking(long steamId, bool speaking) => 
        Call(GDExtensionMethodName.SetInGameVoiceSpeaking, [steamId, speaking]);

    public new bool SetListenForFriendsMessages(bool interceptEnabled) => 
        Call(GDExtensionMethodName.SetListenForFriendsMessages, [interceptEnabled]).As<bool>();

    public new void SetPlayedWith(long steamId) => 
        Call(GDExtensionMethodName.SetPlayedWith, [steamId]);

    public new bool SetRichPresence(string key, string value) => 
        Call(GDExtensionMethodName.SetRichPresence, [key, value]).As<bool>();

    public new void AddHeader(string key, string value, long browserHandle = 0) => 
        Call(GDExtensionMethodName.AddHeader, [key, value, browserHandle]);

    public new void AllowStartRequest(bool allowed, long browserHandle = 0) => 
        Call(GDExtensionMethodName.AllowStartRequest, [allowed, browserHandle]);

    public new void CopyToClipboard(long browserHandle = 0) => 
        Call(GDExtensionMethodName.CopyToClipboard, [browserHandle]);

    public new void CreateBrowser(string userAgent = "", string userCss = "") => 
        Call(GDExtensionMethodName.CreateBrowser, [userAgent, userCss]);

    public new void ExecuteJavascript(string script, long browserHandle = 0) => 
        Call(GDExtensionMethodName.ExecuteJavascript, [script, browserHandle]);

    public new void Find(string search, bool currentlyInFind, bool reverse, long browserHandle = 0) => 
        Call(GDExtensionMethodName.Find, [search, currentlyInFind, reverse, browserHandle]);

    public new void GetLinkAtPosition(long x, long y, long browserHandle = 0) => 
        Call(GDExtensionMethodName.GetLinkAtPosition, [x, y, browserHandle]);

    public new void GoBack(long browserHandle = 0) => 
        Call(GDExtensionMethodName.GoBack, [browserHandle]);

    public new void GoForward(long browserHandle = 0) => 
        Call(GDExtensionMethodName.GoForward, [browserHandle]);

    public new bool HtmlInit() => 
        Call(GDExtensionMethodName.HtmlInit, []).As<bool>();

    public new void JsDialogResponse(bool result, long browserHandle = 0) => 
        Call(GDExtensionMethodName.JsDialogResponse, [result, browserHandle]);

    public new void KeyChar(long unicodeChar, long keyModifiers, long browserHandle = 0) => 
        Call(GDExtensionMethodName.KeyChar, [unicodeChar, keyModifiers, browserHandle]);

    public new void KeyDown(long nativeKeyCode, long keyModifiers, long browserHandle = 0, bool isSystemKey = false) => 
        Call(GDExtensionMethodName.KeyDown, [nativeKeyCode, keyModifiers, browserHandle, isSystemKey]);

    public new void KeyUp(long nativeKeyCode, long keyModifiers, long browserHandle = 0) => 
        Call(GDExtensionMethodName.KeyUp, [nativeKeyCode, keyModifiers, browserHandle]);

    public new void LoadUrl(string url, string postData, long browserHandle = 0) => 
        Call(GDExtensionMethodName.LoadUrl, [url, postData, browserHandle]);

    public new void MouseDoubleClick(Steam.HtmlMouseButton mouseButton, long browserHandle = 0) => 
        Call(GDExtensionMethodName.MouseDoubleClick, [Variant.From(mouseButton), browserHandle]);

    public new void MouseDown(Steam.HtmlMouseButton mouseButton, long browserHandle = 0) => 
        Call(GDExtensionMethodName.MouseDown, [Variant.From(mouseButton), browserHandle]);

    public new void MouseMove(long x, long y, long browserHandle = 0) => 
        Call(GDExtensionMethodName.MouseMove, [x, y, browserHandle]);

    public new void MouseUp(Steam.HtmlMouseButton mouseButton, long browserHandle = 0) => 
        Call(GDExtensionMethodName.MouseUp, [Variant.From(mouseButton), browserHandle]);

    public new void MouseWheel(long delta, long browserHandle = 0) => 
        Call(GDExtensionMethodName.MouseWheel, [delta, browserHandle]);

    public new void OpenDeveloperTools(long browserHandle = 0) => 
        Call(GDExtensionMethodName.OpenDeveloperTools, [browserHandle]);

    public new void PasteFromClipboard(long browserHandle = 0) => 
        Call(GDExtensionMethodName.PasteFromClipboard, [browserHandle]);

    public new void Reload(long browserHandle = 0) => 
        Call(GDExtensionMethodName.Reload, [browserHandle]);

    public new void RemoveBrowser(long browserHandle = 0) => 
        Call(GDExtensionMethodName.RemoveBrowser, [browserHandle]);

    public new void SetBackgroundMode(bool backgroundMode, long browserHandle = 0) => 
        Call(GDExtensionMethodName.SetBackgroundMode, [backgroundMode, browserHandle]);

    public new void SetCookie(string hostname, string key, string value, string path, long expires, bool secure, bool httpOnly) => 
        Call(GDExtensionMethodName.SetCookie, [hostname, key, value, path, expires, secure, httpOnly]);

    public new void SetDpiScalingFactor(double dpiScaling, long browserHandle) => 
        Call(GDExtensionMethodName.SetDpiScalingFactor, [dpiScaling, browserHandle]);

    public new void SetHorizontalScroll(long absolutePixelScroll, long browserHandle = 0) => 
        Call(GDExtensionMethodName.SetHorizontalScroll, [absolutePixelScroll, browserHandle]);

    public new void SetKeyFocus(bool hasKeyFocus, long browserHandle = 0) => 
        Call(GDExtensionMethodName.SetKeyFocus, [hasKeyFocus, browserHandle]);

    public new void SetPageScaleFactor(double zoom, long pointX, long pointY, long browserHandle = 0) => 
        Call(GDExtensionMethodName.SetPageScaleFactor, [zoom, pointX, pointY, browserHandle]);

    public new void SetSize(long width, long height, long browserHandle = 0) => 
        Call(GDExtensionMethodName.SetSize, [width, height, browserHandle]);

    public new void SetVerticalScroll(long absolutePixelScroll, long browserHandle = 0) => 
        Call(GDExtensionMethodName.SetVerticalScroll, [absolutePixelScroll, browserHandle]);

    public new bool HtmlShutdown() => 
        Call(GDExtensionMethodName.HtmlShutdown, []).As<bool>();

    public new void StopFind(long browserHandle = 0) => 
        Call(GDExtensionMethodName.StopFind, [browserHandle]);

    public new void StopLoad(long browserHandle = 0) => 
        Call(GDExtensionMethodName.StopLoad, [browserHandle]);

    public new void ViewSource(long browserHandle = 0) => 
        Call(GDExtensionMethodName.ViewSource, [browserHandle]);

    public new long CreateCookieContainer(bool allowResponseToModify) => 
        Call(GDExtensionMethodName.CreateCookieContainer, [allowResponseToModify]).As<long>();

    public new long CreateHttpRequest(Steam.HttpMethod requestMethod, string absoluteUrl) => 
        Call(GDExtensionMethodName.CreateHttpRequest, [Variant.From(requestMethod), absoluteUrl]).As<long>();

    public new bool DeferHttpRequest(long requestHandle) => 
        Call(GDExtensionMethodName.DeferHttpRequest, [requestHandle]).As<bool>();

    public new double GetHttpDownloadProgressPct(long requestHandle) => 
        Call(GDExtensionMethodName.GetHttpDownloadProgressPct, [requestHandle]).As<double>();

    public new bool GetHttpRequestWasTimedOut(long requestHandle) => 
        Call(GDExtensionMethodName.GetHttpRequestWasTimedOut, [requestHandle]).As<bool>();

    public new byte[] GetHttpResponseBodyData(long requestHandle, long bufferSize) => 
        Call(GDExtensionMethodName.GetHttpResponseBodyData, [requestHandle, bufferSize]).As<byte[]>();

    public new long GetHttpResponseBodySize(long requestHandle) => 
        Call(GDExtensionMethodName.GetHttpResponseBodySize, [requestHandle]).As<long>();

    public new long GetHttpResponseHeaderSize(long requestHandle, string headerName) => 
        Call(GDExtensionMethodName.GetHttpResponseHeaderSize, [requestHandle, headerName]).As<long>();

    public new byte[] GetHttpResponseHeaderValue(long requestHandle, string headerName, long bufferSize) => 
        Call(GDExtensionMethodName.GetHttpResponseHeaderValue, [requestHandle, headerName, bufferSize]).As<byte[]>();

    public new byte[] GetHttpStreamingResponseBodyData(long requestHandle, long offset, long bufferSize) => 
        Call(GDExtensionMethodName.GetHttpStreamingResponseBodyData, [requestHandle, offset, bufferSize]).As<byte[]>();

    public new bool PrioritizeHttpRequest(long requestHandle) => 
        Call(GDExtensionMethodName.PrioritizeHttpRequest, [requestHandle]).As<bool>();

    public new bool ReleaseCookieContainer(long cookieHandle) => 
        Call(GDExtensionMethodName.ReleaseCookieContainer, [cookieHandle]).As<bool>();

    public new bool ReleaseHttpRequest(long requestHandle) => 
        Call(GDExtensionMethodName.ReleaseHttpRequest, [requestHandle]).As<bool>();

    public new bool SendHttpRequest(long requestHandle) => 
        Call(GDExtensionMethodName.SendHttpRequest, [requestHandle]).As<bool>();

    public new bool SendHttpRequestAndStreamResponse(long requestHandle) => 
        Call(GDExtensionMethodName.SendHttpRequestAndStreamResponse, [requestHandle]).As<bool>();

    public new bool SetHttpCookie(long cookieHandle, string host, string url, string cookieName) => 
        Call(GDExtensionMethodName.SetHttpCookie, [cookieHandle, host, url, cookieName]).As<bool>();

    public new bool SetHttpRequestAbsoluteTimeoutMs(long requestHandle, long milliseconds) => 
        Call(GDExtensionMethodName.SetHttpRequestAbsoluteTimeoutMs, [requestHandle, milliseconds]).As<bool>();

    public new bool SetHttpRequestContextValue(long requestHandle, long contextValue) => 
        Call(GDExtensionMethodName.SetHttpRequestContextValue, [requestHandle, contextValue]).As<bool>();

    public new bool SetHttpRequestCookieContainer(long requestHandle, long cookieHandle) => 
        Call(GDExtensionMethodName.SetHttpRequestCookieContainer, [requestHandle, cookieHandle]).As<bool>();

    public new bool SetHttpRequestGetOrPostParameter(long requestHandle, string paramName, string paramValue) => 
        Call(GDExtensionMethodName.SetHttpRequestGetOrPostParameter, [requestHandle, paramName, paramValue]).As<bool>();

    public new bool SetHttpRequestHeaderValue(long requestHandle, string headerName, string headerValue) => 
        Call(GDExtensionMethodName.SetHttpRequestHeaderValue, [requestHandle, headerName, headerValue]).As<bool>();

    public new bool SetHttpRequestNetworkActivityTimeout(long requestHandle, long timeoutSeconds) => 
        Call(GDExtensionMethodName.SetHttpRequestNetworkActivityTimeout, [requestHandle, timeoutSeconds]).As<bool>();

    public new bool SetHttpRequestRawPostBody(long requestHandle, string contentType, string body) => 
        Call(GDExtensionMethodName.SetHttpRequestRawPostBody, [requestHandle, contentType, body]).As<bool>();

    public new bool SetHttpRequestRequiresVerifiedCertificate(long requestHandle, bool requireVerifiedCertificate) => 
        Call(GDExtensionMethodName.SetHttpRequestRequiresVerifiedCertificate, [requestHandle, requireVerifiedCertificate]).As<bool>();

    public new bool SetHttpRequestUserAgentInfo(long requestHandle, string userAgentInfo) => 
        Call(GDExtensionMethodName.SetHttpRequestUserAgentInfo, [requestHandle, userAgentInfo]).As<bool>();

    public new void ActivateActionSet(long inputHandle, long actionSetHandle) => 
        Call(GDExtensionMethodName.ActivateActionSet, [inputHandle, actionSetHandle]);

    public new void ActivateActionSetLayer(long inputHandle, long actionSetLayerHandle) => 
        Call(GDExtensionMethodName.ActivateActionSetLayer, [inputHandle, actionSetLayerHandle]);

    public new void DeactivateActionSetLayer(long inputHandle, long actionSetHandle) => 
        Call(GDExtensionMethodName.DeactivateActionSetLayer, [inputHandle, actionSetHandle]);

    public new void DeactivateAllActionSetLayers(long inputHandle) => 
        Call(GDExtensionMethodName.DeactivateAllActionSetLayers, [inputHandle]);

    public new long GetActionSetHandle(string actionSetName) => 
        Call(GDExtensionMethodName.GetActionSetHandle, [actionSetName]).As<long>();

    public new Steam.InputActionOrigin GetActionOriginFromXboxOrigin(long inputHandle, Steam.XboxOrigin origin) => 
        Call(GDExtensionMethodName.GetActionOriginFromXboxOrigin, [inputHandle, Variant.From(origin)]).As<Steam.InputActionOrigin>();

    public new Godot.Collections.Array GetActiveActionSetLayers(long inputHandle) => 
        Call(GDExtensionMethodName.GetActiveActionSetLayers, [inputHandle]).As<Godot.Collections.Array>();

    public new Godot.Collections.Dictionary GetAnalogActionData(long inputHandle, long analogActionHandle) => 
        Call(GDExtensionMethodName.GetAnalogActionData, [inputHandle, analogActionHandle]).As<Godot.Collections.Dictionary>();

    public new long GetAnalogActionHandle(string actionName) => 
        Call(GDExtensionMethodName.GetAnalogActionHandle, [actionName]).As<long>();

    public new Godot.Collections.Array GetAnalogActionOrigins(long inputHandle, long actionSetHandle, long analogActionHandle) => 
        Call(GDExtensionMethodName.GetAnalogActionOrigins, [inputHandle, actionSetHandle, analogActionHandle]).As<Godot.Collections.Array>();

    public new Godot.Collections.Array GetConnectedControllers() => 
        Call(GDExtensionMethodName.GetConnectedControllers, []).As<Godot.Collections.Array>();

    public new long GetControllerForGamepadIndex(long index) => 
        Call(GDExtensionMethodName.GetControllerForGamepadIndex, [index]).As<long>();

    public new long GetCurrentActionSet(long inputHandle) => 
        Call(GDExtensionMethodName.GetCurrentActionSet, [inputHandle]).As<long>();

    public new Godot.Collections.Array GetDeviceBindingRevision(long inputHandle) => 
        Call(GDExtensionMethodName.GetDeviceBindingRevision, [inputHandle]).As<Godot.Collections.Array>();

    public new Godot.Collections.Dictionary GetDigitalActionData(long inputHandle, long digitalActionHandle) => 
        Call(GDExtensionMethodName.GetDigitalActionData, [inputHandle, digitalActionHandle]).As<Godot.Collections.Dictionary>();

    public new long GetDigitalActionHandle(string actionName) => 
        Call(GDExtensionMethodName.GetDigitalActionHandle, [actionName]).As<long>();

    public new Godot.Collections.Array GetDigitalActionOrigins(long inputHandle, long actionSetHandle, long digitalActionHandle) => 
        Call(GDExtensionMethodName.GetDigitalActionOrigins, [inputHandle, actionSetHandle, digitalActionHandle]).As<Godot.Collections.Array>();

    public new long GetGamepadIndexForController(long inputHandle) => 
        Call(GDExtensionMethodName.GetGamepadIndexForController, [inputHandle]).As<long>();

    public new string GetGlyphForActionOrigin(Steam.InputActionOrigin origin) => 
        Call(GDExtensionMethodName.GetGlyphForActionOrigin, [Variant.From(origin)]).As<string>();

    public new Steam.InputType GetInputTypeForHandle(long inputHandle) => 
        Call(GDExtensionMethodName.GetInputTypeForHandle, [inputHandle]).As<Steam.InputType>();

    public new Godot.Collections.Dictionary GetMotionData(long inputHandle) => 
        Call(GDExtensionMethodName.GetMotionData, [inputHandle]).As<Godot.Collections.Dictionary>();

    public new long GetRemotePlaySessionId(long inputHandle) => 
        Call(GDExtensionMethodName.GetRemotePlaySessionId, [inputHandle]).As<long>();

    public new string GetStringForActionOrigin(Steam.InputActionOrigin origin) => 
        Call(GDExtensionMethodName.GetStringForActionOrigin, [Variant.From(origin)]).As<string>();

    public new bool InputInit(bool explicitlyCallRunframe = false) => 
        Call(GDExtensionMethodName.InputInit, [explicitlyCallRunframe]).As<bool>();

    public new bool InputShutdown() => 
        Call(GDExtensionMethodName.InputShutdown, []).As<bool>();

    public new void RunFrame(bool reservedValue = true) => 
        Call(GDExtensionMethodName.RunFrame, [reservedValue]);

    public new void SetLedColor(long inputHandle, long colorR, long colorG, long colorB, Steam.InputLedFlag flags) => 
        Call(GDExtensionMethodName.SetLedColor, [inputHandle, colorR, colorG, colorB, Variant.From(flags)]);

    public new bool ShowBindingPanel(long inputHandle) => 
        Call(GDExtensionMethodName.ShowBindingPanel, [inputHandle]).As<bool>();

    public new void StopAnalogActionMomentum(long inputHandle, long action) => 
        Call(GDExtensionMethodName.StopAnalogActionMomentum, [inputHandle, action]);

    public new Steam.InputActionOrigin TranslateActionOrigin(Steam.InputType destinationInput, Steam.InputActionOrigin sourceOrigin) => 
        Call(GDExtensionMethodName.TranslateActionOrigin, [Variant.From(destinationInput), Variant.From(sourceOrigin)]).As<Steam.InputActionOrigin>();

    public new void TriggerHapticPulse(long inputHandle, Steam.SteamControllerPad targetPad, long duration) => 
        Call(GDExtensionMethodName.TriggerHapticPulse, [inputHandle, Variant.From(targetPad), duration]);

    public new void TriggerRepeatedHapticPulse(long inputHandle, Steam.SteamControllerPad targetPad, long duration, long offset, long repeat, long flags) => 
        Call(GDExtensionMethodName.TriggerRepeatedHapticPulse, [inputHandle, Variant.From(targetPad), duration, offset, repeat, flags]);

    public new void TriggerVibration(long inputHandle, long leftSpeed, long rightSpeed) => 
        Call(GDExtensionMethodName.TriggerVibration, [inputHandle, leftSpeed, rightSpeed]);

    public new bool SetInputActionManifestFilePath(string manifestPath) => 
        Call(GDExtensionMethodName.SetInputActionManifestFilePath, [manifestPath]).As<bool>();

    public new bool WaitForData(bool waitForever, long timeout) => 
        Call(GDExtensionMethodName.WaitForData, [waitForever, timeout]).As<bool>();

    public new bool NewDataAvailable() => 
        Call(GDExtensionMethodName.NewDataAvailable, []).As<bool>();

    public new void EnableDeviceCallbacks() => 
        Call(GDExtensionMethodName.EnableDeviceCallbacks, []);

    public new void EnableActionEventCallbacks() => 
        Call(GDExtensionMethodName.EnableActionEventCallbacks, []);

    public new string GetGlyphPngForActionOrigin(Steam.InputActionOrigin origin, Steam.InputGlyphSize size, long flags) => 
        Call(GDExtensionMethodName.GetGlyphPngForActionOrigin, [Variant.From(origin), Variant.From(size), flags]).As<string>();

    public new string GetGlyphSvgForActionOrigin(Steam.InputActionOrigin origin, long flags) => 
        Call(GDExtensionMethodName.GetGlyphSvgForActionOrigin, [Variant.From(origin), flags]).As<string>();

    public new void TriggerVibrationExtended(long inputHandle, long leftSpeed, long rightSpeed, long leftTriggerSpeed, long rightTriggerSpeed) => 
        Call(GDExtensionMethodName.TriggerVibrationExtended, [inputHandle, leftSpeed, rightSpeed, leftTriggerSpeed, rightTriggerSpeed]);

    public new void TriggerSimpleHapticEvent(long inputHandle, Steam.ControllerHapticLocation hapticLocation, long intensity, string gainDb, long otherIntensity, string otherGainDb) => 
        Call(GDExtensionMethodName.TriggerSimpleHapticEvent, [inputHandle, Variant.From(hapticLocation), intensity, gainDb, otherIntensity, otherGainDb]);

    public new string GetStringForXboxOrigin(Steam.XboxOrigin origin) => 
        Call(GDExtensionMethodName.GetStringForXboxOrigin, [Variant.From(origin)]).As<string>();

    public new string GetGlyphForXboxOrigin(Steam.XboxOrigin origin) => 
        Call(GDExtensionMethodName.GetGlyphForXboxOrigin, [Variant.From(origin)]).As<string>();

    public new long GetSessionInputConfigurationSettings() => 
        Call(GDExtensionMethodName.GetSessionInputConfigurationSettings, []).As<long>();

    public new string GetStringForDigitalActionName(long actionHandle) => 
        Call(GDExtensionMethodName.GetStringForDigitalActionName, [actionHandle]).As<string>();

    public new string GetStringForAnalogActionName(long actionHandle) => 
        Call(GDExtensionMethodName.GetStringForAnalogActionName, [actionHandle]).As<string>();

    public new long AddPromoItem(long item) => 
        Call(GDExtensionMethodName.AddPromoItem, [item]).As<long>();

    public new long AddPromoItems(long[] items) => 
        Call(GDExtensionMethodName.AddPromoItems, [items]).As<long>();

    public new bool CheckResultSteamId(long steamIdExpected, long thisInventoryHandle = 0) => 
        Call(GDExtensionMethodName.CheckResultSteamId, [steamIdExpected, thisInventoryHandle]).As<bool>();

    public new long ConsumeItem(long itemConsume, long quantity) => 
        Call(GDExtensionMethodName.ConsumeItem, [itemConsume, quantity]).As<long>();

    public new long DeserializeResult(byte[] buffer) => 
        Call(GDExtensionMethodName.DeserializeResult, [buffer]).As<long>();

    public new void DestroyResult(long thisInventoryHandle = 0) => 
        Call(GDExtensionMethodName.DestroyResult, [thisInventoryHandle]);

    public new long ExchangeItems(long[] outputItems, int[] outputQuantity, long[] inputItems, int[] inputQuantity) => 
        Call(GDExtensionMethodName.ExchangeItems, [outputItems, outputQuantity, inputItems, inputQuantity]).As<long>();

    public new long GenerateItems(long[] items, int[] quantity) => 
        Call(GDExtensionMethodName.GenerateItems, [items, quantity]).As<long>();

    public new long GetAllItems() => 
        Call(GDExtensionMethodName.GetAllItems, []).As<long>();

    public new Godot.Collections.Dictionary GetItemDefinitionProperty(long definition, string name) => 
        Call(GDExtensionMethodName.GetItemDefinitionProperty, [definition, name]).As<Godot.Collections.Dictionary>();

    public new long GetItemsById(long[] idArray) => 
        Call(GDExtensionMethodName.GetItemsById, [idArray]).As<long>();

    public new Godot.Collections.Dictionary GetItemPrice(long definition) => 
        Call(GDExtensionMethodName.GetItemPrice, [definition]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Array GetItemsWithPrices() => 
        Call(GDExtensionMethodName.GetItemsWithPrices, []).As<Godot.Collections.Array>();

    public new string GetResultItemProperty(long index, string name, long thisInventoryHandle = 0) => 
        Call(GDExtensionMethodName.GetResultItemProperty, [index, name, thisInventoryHandle]).As<string>();

    public new Godot.Collections.Array GetResultItems(long thisInventoryHandle = 0) => 
        Call(GDExtensionMethodName.GetResultItems, [thisInventoryHandle]).As<Godot.Collections.Array>();

    public new Steam.Result GetResultStatus(long thisInventoryHandle = 0) => 
        Call(GDExtensionMethodName.GetResultStatus, [thisInventoryHandle]).As<Steam.Result>();

    public new long GetResultTimestamp(long thisInventoryHandle = 0) => 
        Call(GDExtensionMethodName.GetResultTimestamp, [thisInventoryHandle]).As<long>();

    public new long GrantPromoItems() => 
        Call(GDExtensionMethodName.GrantPromoItems, []).As<long>();

    public new bool LoadItemDefinitions() => 
        Call(GDExtensionMethodName.LoadItemDefinitions, []).As<bool>();

    public new void RequestEligiblePromoItemDefinitionsIDs(long steamId) => 
        Call(GDExtensionMethodName.RequestEligiblePromoItemDefinitionsIDs, [steamId]);

    public new void RequestPrices() => 
        Call(GDExtensionMethodName.RequestPrices, []);

    public new byte[] SerializeResult(long thisInventoryHandle = 0) => 
        Call(GDExtensionMethodName.SerializeResult, [thisInventoryHandle]).As<byte[]>();

    public new void StartPurchase(long[] items, int[] quantity) => 
        Call(GDExtensionMethodName.StartPurchase, [items, quantity]);

    public new long TransferItemQuantity(long itemId, long quantity, long itemDestination, bool split) => 
        Call(GDExtensionMethodName.TransferItemQuantity, [itemId, quantity, itemDestination, split]).As<long>();

    public new long TriggerItemDrop(long definition) => 
        Call(GDExtensionMethodName.TriggerItemDrop, [definition]).As<long>();

    public new long StartUpdateProperties() => 
        Call(GDExtensionMethodName.StartUpdateProperties, []).As<long>();

    public new long SubmitUpdateProperties(long thisInventoryUpdateHandle = 0) => 
        Call(GDExtensionMethodName.SubmitUpdateProperties, [thisInventoryUpdateHandle]).As<long>();

    public new bool RemoveProperty(long itemId, string name, long thisInventoryUpdateHandle = 0) => 
        Call(GDExtensionMethodName.RemoveProperty, [itemId, name, thisInventoryUpdateHandle]).As<bool>();

    public new bool SetPropertyString(long itemId, string name, string value, long thisInventoryUpdateHandle = 0) => 
        Call(GDExtensionMethodName.SetPropertyString, [itemId, name, value, thisInventoryUpdateHandle]).As<bool>();

    public new bool SetPropertyBool(long itemId, string name, bool value, long thisInventoryUpdateHandle = 0) => 
        Call(GDExtensionMethodName.SetPropertyBool, [itemId, name, value, thisInventoryUpdateHandle]).As<bool>();

    public new bool SetPropertyInt(long itemId, string name, long value, long thisInventoryUpdateHandle = 0) => 
        Call(GDExtensionMethodName.SetPropertyInt, [itemId, name, value, thisInventoryUpdateHandle]).As<bool>();

    public new bool SetPropertyFloat(long itemId, string name, double value, long thisInventoryUpdateHandle = 0) => 
        Call(GDExtensionMethodName.SetPropertyFloat, [itemId, name, value, thisInventoryUpdateHandle]).As<bool>();

    public new Godot.Collections.Array GetFavoriteGames() => 
        Call(GDExtensionMethodName.GetFavoriteGames, []).As<Godot.Collections.Array>();

    public new long AddFavoriteGame(string ip, long port, long queryPort, long flags, long lastPlayed) => 
        Call(GDExtensionMethodName.AddFavoriteGame, [ip, port, queryPort, flags, lastPlayed]).As<long>();

    public new bool RemoveFavoriteGame(long appId, string ip, long port, long queryPort, long flags) => 
        Call(GDExtensionMethodName.RemoveFavoriteGame, [appId, ip, port, queryPort, flags]).As<bool>();

    public new void RequestLobbyList() => 
        Call(GDExtensionMethodName.RequestLobbyList, []);

    public new void AddRequestLobbyListStringFilter(string keyToMatch, string valueToMatch, Steam.LobbyComparison comparisonType) => 
        Call(GDExtensionMethodName.AddRequestLobbyListStringFilter, [keyToMatch, valueToMatch, Variant.From(comparisonType)]);

    public new void AddRequestLobbyListNumericalFilter(string keyToMatch, long valueToMatch, Steam.LobbyComparison comparisonType) => 
        Call(GDExtensionMethodName.AddRequestLobbyListNumericalFilter, [keyToMatch, valueToMatch, Variant.From(comparisonType)]);

    public new void AddRequestLobbyListNearValueFilter(string keyToMatch, long valueToBeCloseTo) => 
        Call(GDExtensionMethodName.AddRequestLobbyListNearValueFilter, [keyToMatch, valueToBeCloseTo]);

    public new void AddRequestLobbyListFilterSlotsAvailable(long slotsAvailable) => 
        Call(GDExtensionMethodName.AddRequestLobbyListFilterSlotsAvailable, [slotsAvailable]);

    public new void AddRequestLobbyListDistanceFilter(Steam.LobbyDistanceFilter distanceFilter) => 
        Call(GDExtensionMethodName.AddRequestLobbyListDistanceFilter, [Variant.From(distanceFilter)]);

    public new void AddRequestLobbyListResultCountFilter(long maxResults) => 
        Call(GDExtensionMethodName.AddRequestLobbyListResultCountFilter, [maxResults]);

    public new void CreateLobby(Steam.LobbyType lobbyType, long maxMembers = 2) => 
        Call(GDExtensionMethodName.CreateLobby, [Variant.From(lobbyType), maxMembers]);

    public new void JoinLobby(long steamLobbyId) => 
        Call(GDExtensionMethodName.JoinLobby, [steamLobbyId]);

    public new void LeaveLobby(long steamLobbyId) => 
        Call(GDExtensionMethodName.LeaveLobby, [steamLobbyId]);

    public new bool InviteUserToLobby(long steamLobbyId, long steamIdInvitee) => 
        Call(GDExtensionMethodName.InviteUserToLobby, [steamLobbyId, steamIdInvitee]).As<bool>();

    public new long GetNumLobbyMembers(long steamLobbyId) => 
        Call(GDExtensionMethodName.GetNumLobbyMembers, [steamLobbyId]).As<long>();

    public new long GetLobbyMemberByIndex(long steamLobbyId, long member) => 
        Call(GDExtensionMethodName.GetLobbyMemberByIndex, [steamLobbyId, member]).As<long>();

    public new string GetLobbyData(long steamLobbyId, string key) => 
        Call(GDExtensionMethodName.GetLobbyData, [steamLobbyId, key]).As<string>();

    public new bool SetLobbyData(long steamLobbyId, string key, string value) => 
        Call(GDExtensionMethodName.SetLobbyData, [steamLobbyId, key, value]).As<bool>();

    public new Godot.Collections.Dictionary GetAllLobbyData(long steamLobbyId) => 
        Call(GDExtensionMethodName.GetAllLobbyData, [steamLobbyId]).As<Godot.Collections.Dictionary>();

    public new bool DeleteLobbyData(long steamLobbyId, string key) => 
        Call(GDExtensionMethodName.DeleteLobbyData, [steamLobbyId, key]).As<bool>();

    public new string GetLobbyMemberData(long steamLobbyId, long steamIdUser, string key) => 
        Call(GDExtensionMethodName.GetLobbyMemberData, [steamLobbyId, steamIdUser, key]).As<string>();

    public new void SetLobbyMemberData(long steamLobbyId, string key, string value) => 
        Call(GDExtensionMethodName.SetLobbyMemberData, [steamLobbyId, key, value]);

    public new bool SendLobbyChatMsg(long steamLobbyId, string messageBody) => 
        Call(GDExtensionMethodName.SendLobbyChatMsg, [steamLobbyId, messageBody]).As<bool>();

    public new bool RequestLobbyData(long steamLobbyId) => 
        Call(GDExtensionMethodName.RequestLobbyData, [steamLobbyId]).As<bool>();

    public new void SetLobbyGameServer(long steamLobbyId, string serverIp = "0", long serverPort = 0, long steamIdGameServer = 0) => 
        Call(GDExtensionMethodName.SetLobbyGameServer, [steamLobbyId, serverIp, serverPort, steamIdGameServer]);

    public new Godot.Collections.Dictionary GetLobbyGameServer(long steamLobbyId) => 
        Call(GDExtensionMethodName.GetLobbyGameServer, [steamLobbyId]).As<Godot.Collections.Dictionary>();

    public new bool SetLobbyMemberLimit(long steamLobbyId, long maxMembers) => 
        Call(GDExtensionMethodName.SetLobbyMemberLimit, [steamLobbyId, maxMembers]).As<bool>();

    public new long GetLobbyMemberLimit(long steamLobbyId) => 
        Call(GDExtensionMethodName.GetLobbyMemberLimit, [steamLobbyId]).As<long>();

    public new bool SetLobbyType(long steamLobbyId, Steam.LobbyType lobbyType) => 
        Call(GDExtensionMethodName.SetLobbyType, [steamLobbyId, Variant.From(lobbyType)]).As<bool>();

    public new bool SetLobbyJoinable(long steamLobbyId, bool joinable) => 
        Call(GDExtensionMethodName.SetLobbyJoinable, [steamLobbyId, joinable]).As<bool>();

    public new long GetLobbyOwner(long steamLobbyId) => 
        Call(GDExtensionMethodName.GetLobbyOwner, [steamLobbyId]).As<long>();

    public new bool SetLobbyOwner(long steamLobbyId, long steamIdNewOwner) => 
        Call(GDExtensionMethodName.SetLobbyOwner, [steamLobbyId, steamIdNewOwner]).As<bool>();

    public new void CancelQuery(long serverListRequest) => 
        Call(GDExtensionMethodName.CancelQuery, [serverListRequest]);

    public new void CancelServerQuery(long serverQuery) => 
        Call(GDExtensionMethodName.CancelServerQuery, [serverQuery]);

    public new long GetServerCount(long serverListRequest) => 
        Call(GDExtensionMethodName.GetServerCount, [serverListRequest]).As<long>();

    public new Godot.Collections.Dictionary GetServerDetails(long server, long serverListRequest) => 
        Call(GDExtensionMethodName.GetServerDetails, [server, serverListRequest]).As<Godot.Collections.Dictionary>();

    public new bool IsRefreshing(long serverListRequest) => 
        Call(GDExtensionMethodName.IsRefreshing, [serverListRequest]).As<bool>();

    public new long PingServer(string ip, long port) => 
        Call(GDExtensionMethodName.PingServer, [ip, port]).As<long>();

    public new long PlayerDetails(string ip, long port) => 
        Call(GDExtensionMethodName.PlayerDetails, [ip, port]).As<long>();

    public new void RefreshQuery(long serverListRequest) => 
        Call(GDExtensionMethodName.RefreshQuery, [serverListRequest]);

    public new void RefreshServer(long server, long serverListRequest) => 
        Call(GDExtensionMethodName.RefreshServer, [server, serverListRequest]);

    public new void ReleaseRequest(long serverListRequest) => 
        Call(GDExtensionMethodName.ReleaseRequest, [serverListRequest]);

    public new long RequestFavoritesServerList(long appId, Godot.Collections.Array filters) => 
        Call(GDExtensionMethodName.RequestFavoritesServerList, [appId, filters]).As<long>();

    public new long RequestFriendsServerList(long appId, Godot.Collections.Array filters) => 
        Call(GDExtensionMethodName.RequestFriendsServerList, [appId, filters]).As<long>();

    public new long RequestHistoryServerList(long appId, Godot.Collections.Array filters) => 
        Call(GDExtensionMethodName.RequestHistoryServerList, [appId, filters]).As<long>();

    public new long RequestInternetServerList(long appId, Godot.Collections.Array filters) => 
        Call(GDExtensionMethodName.RequestInternetServerList, [appId, filters]).As<long>();

    public new long RequestLanServerList(long appId) => 
        Call(GDExtensionMethodName.RequestLanServerList, [appId]).As<long>();

    public new long RequestSpectatorServerList(long appId, Godot.Collections.Array filters) => 
        Call(GDExtensionMethodName.RequestSpectatorServerList, [appId, filters]).As<long>();

    public new long ServerFriends(string ip, long port) => 
        Call(GDExtensionMethodName.ServerFriends, [ip, port]).As<long>();

    public new long ServerRules(string ip, long port) => 
        Call(GDExtensionMethodName.ServerRules, [ip, port]).As<long>();

    public new bool MusicIsEnabled() => 
        Call(GDExtensionMethodName.MusicIsEnabled, []).As<bool>();

    public new bool MusicIsPlaying() => 
        Call(GDExtensionMethodName.MusicIsPlaying, []).As<bool>();

    public new Steam.AudioPlaybackStatus GetPlaybackStatus() => 
        Call(GDExtensionMethodName.GetPlaybackStatus, []).As<Steam.AudioPlaybackStatus>();

    public new double MusicGetVolume() => 
        Call(GDExtensionMethodName.MusicGetVolume, []).As<double>();

    public new void MusicPause() => 
        Call(GDExtensionMethodName.MusicPause, []);

    public new void MusicPlay() => 
        Call(GDExtensionMethodName.MusicPlay, []);

    public new void MusicPlayNext() => 
        Call(GDExtensionMethodName.MusicPlayNext, []);

    public new void MusicPlayPrev() => 
        Call(GDExtensionMethodName.MusicPlayPrev, []);

    public new void MusicSetVolume(double volume) => 
        Call(GDExtensionMethodName.MusicSetVolume, [volume]);

    public new bool AcceptP2pSessionWithUser(long remoteSteamId) => 
        Call(GDExtensionMethodName.AcceptP2pSessionWithUser, [remoteSteamId]).As<bool>();

    public new bool AllowP2pPacketRelay(bool allow) => 
        Call(GDExtensionMethodName.AllowP2pPacketRelay, [allow]).As<bool>();

    public new bool CloseP2pChannelWithUser(long remoteSteamId, long channel) => 
        Call(GDExtensionMethodName.CloseP2pChannelWithUser, [remoteSteamId, channel]).As<bool>();

    public new bool CloseP2pSessionWithUser(long remoteSteamId) => 
        Call(GDExtensionMethodName.CloseP2pSessionWithUser, [remoteSteamId]).As<bool>();

    public new Godot.Collections.Dictionary GetP2pSessionState(long remoteSteamId) => 
        Call(GDExtensionMethodName.GetP2pSessionState, [remoteSteamId]).As<Godot.Collections.Dictionary>();

    public new long GetAvailableP2pPacketSize(long channel = 0) => 
        Call(GDExtensionMethodName.GetAvailableP2pPacketSize, [channel]).As<long>();

    public new Godot.Collections.Dictionary ReadP2pPacket(long packetSize, long channel = 0) => 
        Call(GDExtensionMethodName.ReadP2pPacket, [packetSize, channel]).As<Godot.Collections.Dictionary>();

    public new bool SendP2pPacket(long remoteSteamId, byte[] data, Steam.P2pSend sendType, long channel = 0) => 
        Call(GDExtensionMethodName.SendP2pPacket, [remoteSteamId, data, Variant.From(sendType), channel]).As<bool>();

    public new bool AcceptSessionWithUser(long remoteSteamId) => 
        Call(GDExtensionMethodName.AcceptSessionWithUser, [remoteSteamId]).As<bool>();

    public new bool CloseChannelWithUser(long remoteSteamId, long channel) => 
        Call(GDExtensionMethodName.CloseChannelWithUser, [remoteSteamId, channel]).As<bool>();

    public new bool CloseSessionWithUser(long remoteSteamId) => 
        Call(GDExtensionMethodName.CloseSessionWithUser, [remoteSteamId]).As<bool>();

    public new Godot.Collections.Dictionary GetSessionConnectionInfo(long remoteSteamId, bool getConnection, bool getStatus) => 
        Call(GDExtensionMethodName.GetSessionConnectionInfo, [remoteSteamId, getConnection, getStatus]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Array ReceiveMessagesOnChannel(long channel, long maxMessages) => 
        Call(GDExtensionMethodName.ReceiveMessagesOnChannel, [channel, maxMessages]).As<Godot.Collections.Array>();

    public new long SendMessageToUser(long remoteSteamId, byte[] data, long flags, long channel) => 
        Call(GDExtensionMethodName.SendMessageToUser, [remoteSteamId, data, flags, channel]).As<long>();

    public new long AcceptConnection(long connectionHandle) => 
        Call(GDExtensionMethodName.AcceptConnection, [connectionHandle]).As<long>();

    public new bool BeginAsyncRequestFakeIp(long numPorts) => 
        Call(GDExtensionMethodName.BeginAsyncRequestFakeIp, [numPorts]).As<bool>();

    public new bool CloseConnection(long connectionHandle, long reason, string debugMessage, bool linger) => 
        Call(GDExtensionMethodName.CloseConnection, [connectionHandle, reason, debugMessage, linger]).As<bool>();

    public new bool CloseListenSocket(long socket) => 
        Call(GDExtensionMethodName.CloseListenSocket, [socket]).As<bool>();

    public new long ConfigureConnectionLanes(long connection, long lanes, Godot.Collections.Array priorities, Godot.Collections.Array weights) => 
        Call(GDExtensionMethodName.ConfigureConnectionLanes, [connection, lanes, priorities, weights]).As<long>();

    public new long ConnectP2p(long remoteSteamId, long virtualPort, Godot.Collections.Dictionary options) => 
        Call(GDExtensionMethodName.ConnectP2p, [remoteSteamId, virtualPort, options]).As<long>();

    public new long ConnectByIpAddress(string ipAddressWithPort, Godot.Collections.Dictionary options) => 
        Call(GDExtensionMethodName.ConnectByIpAddress, [ipAddressWithPort, options]).As<long>();

    public new long ConnectToHostedDedicatedServer(long remoteSteamId, long virtualPort, Godot.Collections.Dictionary options) => 
        Call(GDExtensionMethodName.ConnectToHostedDedicatedServer, [remoteSteamId, virtualPort, options]).As<long>();

    public new void CreateFakeUdpPort(long fakeServerPort) => 
        Call(GDExtensionMethodName.CreateFakeUdpPort, [fakeServerPort]);

    public new long CreateListenSocketIp(string ipReference, Godot.Collections.Dictionary options) => 
        Call(GDExtensionMethodName.CreateListenSocketIp, [ipReference, options]).As<long>();

    public new long CreateListenSocketP2p(long virtualPort, Godot.Collections.Dictionary options) => 
        Call(GDExtensionMethodName.CreateListenSocketP2p, [virtualPort, options]).As<long>();

    public new long CreateListenSocketP2pFakeIp(long fakePort, Godot.Collections.Dictionary options) => 
        Call(GDExtensionMethodName.CreateListenSocketP2pFakeIp, [fakePort, options]).As<long>();

    public new long CreatePollGroup() => 
        Call(GDExtensionMethodName.CreatePollGroup, []).As<long>();

    public new Godot.Collections.Dictionary CreateSocketPair(bool loopback, long remoteSteamId1, long remoteSteamId2) => 
        Call(GDExtensionMethodName.CreateSocketPair, [loopback, remoteSteamId1, remoteSteamId2]).As<Godot.Collections.Dictionary>();

    public new bool DestroyPollGroup(long pollGroup) => 
        Call(GDExtensionMethodName.DestroyPollGroup, [pollGroup]).As<bool>();

    public new long FlushMessagesOnConnection(long connectionHandle) => 
        Call(GDExtensionMethodName.FlushMessagesOnConnection, [connectionHandle]).As<long>();

    public new Steam.NetworkingAvailability GetAuthenticationStatus() => 
        Call(GDExtensionMethodName.GetAuthenticationStatus, []).As<Steam.NetworkingAvailability>();

    public new Godot.Collections.Dictionary GetCertificateRequest() => 
        Call(GDExtensionMethodName.GetCertificateRequest, []).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetConnectionInfo(long connectionHandle) => 
        Call(GDExtensionMethodName.GetConnectionInfo, [connectionHandle]).As<Godot.Collections.Dictionary>();

    public new string GetConnectionName(long connectionHandle) => 
        Call(GDExtensionMethodName.GetConnectionName, [connectionHandle]).As<string>();

    public new Godot.Collections.Dictionary GetConnectionRealTimeStatus(long connectionHandle, long lanes, bool getStatus = true) => 
        Call(GDExtensionMethodName.GetConnectionRealTimeStatus, [connectionHandle, lanes, getStatus]).As<Godot.Collections.Dictionary>();

    public new long GetConnectionUserData(long connectionHandle) => 
        Call(GDExtensionMethodName.GetConnectionUserData, [connectionHandle]).As<long>();

    public new Godot.Collections.Dictionary GetDetailedConnectionStatus(long connectionHandle) => 
        Call(GDExtensionMethodName.GetDetailedConnectionStatus, [connectionHandle]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetFakeIp(long firstPort = 0) => 
        Call(GDExtensionMethodName.GetFakeIp, [firstPort]).As<Godot.Collections.Dictionary>();

    public new long GetHostedDedicatedServerPopId() => 
        Call(GDExtensionMethodName.GetHostedDedicatedServerPopId, []).As<long>();

    public new long GetHostedDedicatedServerPort() => 
        Call(GDExtensionMethodName.GetHostedDedicatedServerPort, []).As<long>();

    public new string GetListenSocketAddress(long socket, bool withPort = true) => 
        Call(GDExtensionMethodName.GetListenSocketAddress, [socket, withPort]).As<string>();

    public new Godot.Collections.Dictionary GetRemoteFakeIpForConnection(long connection) => 
        Call(GDExtensionMethodName.GetRemoteFakeIpForConnection, [connection]).As<Godot.Collections.Dictionary>();

    public new Steam.NetworkingAvailability InitAuthentication() => 
        Call(GDExtensionMethodName.InitAuthentication, []).As<Steam.NetworkingAvailability>();

    public new Godot.Collections.Array ReceiveMessagesOnConnection(long connectionHandle, long maxMessages) => 
        Call(GDExtensionMethodName.ReceiveMessagesOnConnection, [connectionHandle, maxMessages]).As<Godot.Collections.Array>();

    public new Godot.Collections.Array ReceiveMessagesOnPollGroup(long pollGroup, long maxMessages) => 
        Call(GDExtensionMethodName.ReceiveMessagesOnPollGroup, [pollGroup, maxMessages]).As<Godot.Collections.Array>();

    public new void ResetIdentity(long remoteSteamId) => 
        Call(GDExtensionMethodName.ResetIdentity, [remoteSteamId]);

    public new void RunNetworkingCallbacks() => 
        Call(GDExtensionMethodName.RunNetworkingCallbacks, []);

    public new long[] SendMessages(long connectionHandle, Godot.Collections.Array messages, long flags, bool deleteFailedMessages) => 
        Call(GDExtensionMethodName.SendMessages, [connectionHandle, messages, flags, deleteFailedMessages]).As<long[]>();

    public new Godot.Collections.Dictionary SendMessageToConnection(long connectionHandle, byte[] message, long flags) => 
        Call(GDExtensionMethodName.SendMessageToConnection, [connectionHandle, message, flags]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary SetCertificate(byte[] certificate) => 
        Call(GDExtensionMethodName.SetCertificate, [certificate]).As<Godot.Collections.Dictionary>();

    public new bool SetConnectionPollGroup(long connectionHandle, long pollGroup) => 
        Call(GDExtensionMethodName.SetConnectionPollGroup, [connectionHandle, pollGroup]).As<bool>();

    public new void SetConnectionName(long connectionHandle, string name) => 
        Call(GDExtensionMethodName.SetConnectionName, [connectionHandle, name]);

    public new bool SetConnectionUserData(long connectionHandle, long userData) => 
        Call(GDExtensionMethodName.SetConnectionUserData, [connectionHandle, userData]).As<bool>();

    public new bool CheckPingDataUpToDate(double maxAgeInSeconds) => 
        Call(GDExtensionMethodName.CheckPingDataUpToDate, [maxAgeInSeconds]).As<bool>();

    public new string ConvertPingLocationToString(byte[] location) => 
        Call(GDExtensionMethodName.ConvertPingLocationToString, [location]).As<string>();

    public new long EstimatePingTimeBetweenTwoLocations(byte[] location1, byte[] location2) => 
        Call(GDExtensionMethodName.EstimatePingTimeBetweenTwoLocations, [location1, location2]).As<long>();

    public new long EstimatePingTimeFromLocalHost(byte[] location) => 
        Call(GDExtensionMethodName.EstimatePingTimeFromLocalHost, [location]).As<long>();

    public new Godot.Collections.Dictionary GetConfigValue(Steam.NetworkingConfigValue configValue, Steam.NetworkingConfigScope scopeType, long connectionHandle) => 
        Call(GDExtensionMethodName.GetConfigValue, [Variant.From(configValue), Variant.From(scopeType), connectionHandle]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetConfigValueInfo(Steam.NetworkingConfigValue configValue) => 
        Call(GDExtensionMethodName.GetConfigValueInfo, [Variant.From(configValue)]).As<Godot.Collections.Dictionary>();

    public new long GetDirectPingToPop(long popId) => 
        Call(GDExtensionMethodName.GetDirectPingToPop, [popId]).As<long>();

    public new Steam.NetworkingFakeIpType GetIPv4FakeIpType(string ipv4) => 
        Call(GDExtensionMethodName.GetIPv4FakeIpType, [ipv4]).As<Steam.NetworkingFakeIpType>();

    public new Godot.Collections.Dictionary GetLocalPingLocation() => 
        Call(GDExtensionMethodName.GetLocalPingLocation, []).As<Godot.Collections.Dictionary>();

    public new long GetLocalTimestamp() => 
        Call(GDExtensionMethodName.GetLocalTimestamp, []).As<long>();

    public new Godot.Collections.Dictionary GetPingToDataCenter(long popId) => 
        Call(GDExtensionMethodName.GetPingToDataCenter, [popId]).As<Godot.Collections.Dictionary>();

    public new long GetPopCount() => 
        Call(GDExtensionMethodName.GetPopCount, []).As<long>();

    public new Godot.Collections.Array GetPopList() => 
        Call(GDExtensionMethodName.GetPopList, []).As<Godot.Collections.Array>();

    public new Godot.Collections.Dictionary GetRealIdentityForFakeIp(string fakeIp) => 
        Call(GDExtensionMethodName.GetRealIdentityForFakeIp, [fakeIp]).As<Godot.Collections.Dictionary>();

    public new Steam.NetworkingAvailability GetRelayNetworkStatus() => 
        Call(GDExtensionMethodName.GetRelayNetworkStatus, []).As<Steam.NetworkingAvailability>();

    public new void InitRelayNetworkAccess() => 
        Call(GDExtensionMethodName.InitRelayNetworkAccess, []);

    public new bool IsFakeIPv4(string ipAddress) => 
        Call(GDExtensionMethodName.IsFakeIPv4, [ipAddress]).As<bool>();

    public new Steam.NetworkingConfigValue IterateGenericEditableConfigValues(Steam.NetworkingConfigValue currentValue, bool enumerateDevVars) => 
        Call(GDExtensionMethodName.IterateGenericEditableConfigValues, [Variant.From(currentValue), enumerateDevVars]).As<Steam.NetworkingConfigValue>();

    public new Godot.Collections.Dictionary ParsePingLocationString(string @string) => 
        Call(GDExtensionMethodName.ParsePingLocationString, [@string]).As<Godot.Collections.Dictionary>();

    public new bool SetConnectionConfigValueFloat(long connectionHandle, Steam.NetworkingConfigValue config, double value) => 
        Call(GDExtensionMethodName.SetConnectionConfigValueFloat, [connectionHandle, Variant.From(config), value]).As<bool>();

    public new bool SetConnectionConfigValueInt32(long connectionHandle, Steam.NetworkingConfigValue config, long value) => 
        Call(GDExtensionMethodName.SetConnectionConfigValueInt32, [connectionHandle, Variant.From(config), value]).As<bool>();

    public new bool SetConnectionConfigValueString(long connectionHandle, Steam.NetworkingConfigValue config, string value) => 
        Call(GDExtensionMethodName.SetConnectionConfigValueString, [connectionHandle, Variant.From(config), value]).As<bool>();

    public new bool SetGlobalConfigValueFloat(Steam.NetworkingConfigValue config, double value) => 
        Call(GDExtensionMethodName.SetGlobalConfigValueFloat, [Variant.From(config), value]).As<bool>();

    public new bool SetGlobalConfigValueInt32(Steam.NetworkingConfigValue config, long value) => 
        Call(GDExtensionMethodName.SetGlobalConfigValueInt32, [Variant.From(config), value]).As<bool>();

    public new bool SetGlobalConfigValueString(Steam.NetworkingConfigValue config, string value) => 
        Call(GDExtensionMethodName.SetGlobalConfigValueString, [Variant.From(config), value]).As<bool>();

    public new bool IsParentalLockEnabled() => 
        Call(GDExtensionMethodName.IsParentalLockEnabled, []).As<bool>();

    public new bool IsParentalLockLocked() => 
        Call(GDExtensionMethodName.IsParentalLockLocked, []).As<bool>();

    public new bool IsAppBlocked(long appId) => 
        Call(GDExtensionMethodName.IsAppBlocked, [appId]).As<bool>();

    public new bool IsAppInBlockList(long appId) => 
        Call(GDExtensionMethodName.IsAppInBlockList, [appId]).As<bool>();

    public new bool IsFeatureBlocked(Steam.ParentalFeature feature) => 
        Call(GDExtensionMethodName.IsFeatureBlocked, [Variant.From(feature)]).As<bool>();

    public new bool IsFeatureInBlockList(Steam.ParentalFeature feature) => 
        Call(GDExtensionMethodName.IsFeatureInBlockList, [Variant.From(feature)]).As<bool>();

    public new void CancelReservation(long beaconId, long steamId) => 
        Call(GDExtensionMethodName.CancelReservation, [beaconId, steamId]);

    public new void ChangeNumOpenSlots(long beaconId, long openSlots) => 
        Call(GDExtensionMethodName.ChangeNumOpenSlots, [beaconId, openSlots]);

    public new void CreateBeacon(long openSlots, long locationId, Steam.PartyBeaconLocationType locationType, string connectString, string beaconMetadata) => 
        Call(GDExtensionMethodName.CreateBeacon, [openSlots, locationId, Variant.From(locationType), connectString, beaconMetadata]);

    public new bool DestroyBeacon(long beaconId) => 
        Call(GDExtensionMethodName.DestroyBeacon, [beaconId]).As<bool>();

    public new Godot.Collections.Array GetAvailableBeaconLocations(long maxLocations) => 
        Call(GDExtensionMethodName.GetAvailableBeaconLocations, [maxLocations]).As<Godot.Collections.Array>();

    public new long GetBeaconByIndex(long index) => 
        Call(GDExtensionMethodName.GetBeaconByIndex, [index]).As<long>();

    public new Godot.Collections.Dictionary GetBeaconDetails(long beaconId) => 
        Call(GDExtensionMethodName.GetBeaconDetails, [beaconId]).As<Godot.Collections.Dictionary>();

    public new string GetBeaconLocationData(long locationId, Steam.PartyBeaconLocationType locationType, Steam.PartyBeaconLocationData locationData) => 
        Call(GDExtensionMethodName.GetBeaconLocationData, [locationId, Variant.From(locationType), Variant.From(locationData)]).As<string>();

    public new long GetNumActiveBeacons() => 
        Call(GDExtensionMethodName.GetNumActiveBeacons, []).As<long>();

    public new long GetNumAvailableBeaconLocations() => 
        Call(GDExtensionMethodName.GetNumAvailableBeaconLocations, []).As<long>();

    public new void JoinParty(long beaconId) => 
        Call(GDExtensionMethodName.JoinParty, [beaconId]);

    public new void OnReservationCompleted(long beaconId, long steamId) => 
        Call(GDExtensionMethodName.OnReservationCompleted, [beaconId, steamId]);

    public new bool EnableRemotePlayTogetherDirectInput() => 
        Call(GDExtensionMethodName.EnableRemotePlayTogetherDirectInput, []).As<bool>();

    public new void DisableRemotePlayTogetherDirectInput() => 
        Call(GDExtensionMethodName.DisableRemotePlayTogetherDirectInput, []);

    public new Godot.Collections.Array GetInput(long maxEvents) => 
        Call(GDExtensionMethodName.GetInput, [maxEvents]).As<Godot.Collections.Array>();

    public new long GetLargeSessionAvatar(long sessionId) => 
        Call(GDExtensionMethodName.GetLargeSessionAvatar, [sessionId]).As<long>();

    public new long GetMediumSessionAvatar(long sessionId) => 
        Call(GDExtensionMethodName.GetMediumSessionAvatar, [sessionId]).As<long>();

    public new long GetSessionCount() => 
        Call(GDExtensionMethodName.GetSessionCount, []).As<long>();

    public new long GetSessionGuestId(long sessionId) => 
        Call(GDExtensionMethodName.GetSessionGuestId, [sessionId]).As<long>();

    public new long GetSessionId(long index) => 
        Call(GDExtensionMethodName.GetSessionId, [index]).As<long>();

    public new long GetSessionSteamId(long sessionId) => 
        Call(GDExtensionMethodName.GetSessionSteamId, [sessionId]).As<long>();

    public new long GetSmallSessionAvatar(long sessionId) => 
        Call(GDExtensionMethodName.GetSmallSessionAvatar, [sessionId]).As<long>();

    public new string GetSessionClientName(long sessionId) => 
        Call(GDExtensionMethodName.GetSessionClientName, [sessionId]).As<string>();

    public new Steam.DeviceFormFactor GetSessionClientFormFactor(long sessionId) => 
        Call(GDExtensionMethodName.GetSessionClientFormFactor, [sessionId]).As<Steam.DeviceFormFactor>();

    public new Godot.Collections.Dictionary GetSessionClientResolution(long sessionId) => 
        Call(GDExtensionMethodName.GetSessionClientResolution, [sessionId]).As<Godot.Collections.Dictionary>();

    public new bool SendRemotePlayTogetherInvite(long friendId) => 
        Call(GDExtensionMethodName.SendRemotePlayTogetherInvite, [friendId]).As<bool>();

    public new bool SessionRemotePlayTogether(long sessionId) => 
        Call(GDExtensionMethodName.SessionRemotePlayTogether, [sessionId]).As<bool>();

    public new void SetMouseCursor(long sessionId, long cursorId) => 
        Call(GDExtensionMethodName.SetMouseCursor, [sessionId, cursorId]);

    public new void SetMousePosition(long sessionId, double normalizedX, double normalizedY) => 
        Call(GDExtensionMethodName.SetMousePosition, [sessionId, normalizedX, normalizedY]);

    public new void SetMouseVisibility(long sessionId, bool visible) => 
        Call(GDExtensionMethodName.SetMouseVisibility, [sessionId, visible]);

    public new bool ShowRemotePlayTogetherUi() => 
        Call(GDExtensionMethodName.ShowRemotePlayTogetherUi, []).As<bool>();

    public new bool BeginFileWriteBatch() => 
        Call(GDExtensionMethodName.BeginFileWriteBatch, []).As<bool>();

    public new bool EndFileWriteBatch() => 
        Call(GDExtensionMethodName.EndFileWriteBatch, []).As<bool>();

    public new bool FileDelete(string file) => 
        Call(GDExtensionMethodName.FileDelete, [file]).As<bool>();

    public new bool FileExists(string file) => 
        Call(GDExtensionMethodName.FileExists, [file]).As<bool>();

    public new bool FileForget(string file) => 
        Call(GDExtensionMethodName.FileForget, [file]).As<bool>();

    public new bool FilePersisted(string file) => 
        Call(GDExtensionMethodName.FilePersisted, [file]).As<bool>();

    public new Godot.Collections.Dictionary FileRead(string file, long dataToRead) => 
        Call(GDExtensionMethodName.FileRead, [file, dataToRead]).As<Godot.Collections.Dictionary>();

    public new void FileReadAsync(string file, long offset, long dataToRead) => 
        Call(GDExtensionMethodName.FileReadAsync, [file, offset, dataToRead]);

    public new void FileShare(string file) => 
        Call(GDExtensionMethodName.FileShare, [file]);

    public new bool FileWrite(string file, byte[] data, long size = 0) => 
        Call(GDExtensionMethodName.FileWrite, [file, data, size]).As<bool>();

    public new void FileWriteAsync(string file, byte[] data, long size = 0) => 
        Call(GDExtensionMethodName.FileWriteAsync, [file, data, size]);

    public new bool FileWriteStreamCancel(long writeHandle) => 
        Call(GDExtensionMethodName.FileWriteStreamCancel, [writeHandle]).As<bool>();

    public new bool FileWriteStreamClose(long writeHandle) => 
        Call(GDExtensionMethodName.FileWriteStreamClose, [writeHandle]).As<bool>();

    public new long FileWriteStreamOpen(string file) => 
        Call(GDExtensionMethodName.FileWriteStreamOpen, [file]).As<long>();

    public new bool FileWriteStreamWriteChunk(long writeHandle, byte[] data) => 
        Call(GDExtensionMethodName.FileWriteStreamWriteChunk, [writeHandle, data]).As<bool>();

    public new long GetCachedUgcCount() => 
        Call(GDExtensionMethodName.GetCachedUgcCount, []).As<long>();

    public new long GetCachedUgcHandle(long content) => 
        Call(GDExtensionMethodName.GetCachedUgcHandle, [content]).As<long>();

    public new long GetFileCount() => 
        Call(GDExtensionMethodName.GetFileCount, []).As<long>();

    public new Godot.Collections.Dictionary GetFileNameAndSize(long file) => 
        Call(GDExtensionMethodName.GetFileNameAndSize, [file]).As<Godot.Collections.Dictionary>();

    public new long GetFileSize(string file) => 
        Call(GDExtensionMethodName.GetFileSize, [file]).As<long>();

    public new long GetFileTimestamp(string file) => 
        Call(GDExtensionMethodName.GetFileTimestamp, [file]).As<long>();

    public new Godot.Collections.Dictionary GetLocalFileChange(long file) => 
        Call(GDExtensionMethodName.GetLocalFileChange, [file]).As<Godot.Collections.Dictionary>();

    public new long GetLocalFileChangeCount() => 
        Call(GDExtensionMethodName.GetLocalFileChangeCount, []).As<long>();

    public new Godot.Collections.Dictionary GetQuota() => 
        Call(GDExtensionMethodName.GetQuota, []).As<Godot.Collections.Dictionary>();

    public new long GetSyncPlatforms(string file) => 
        Call(GDExtensionMethodName.GetSyncPlatforms, [file]).As<long>();

    public new Godot.Collections.Dictionary GetUgcDetails(long content) => 
        Call(GDExtensionMethodName.GetUgcDetails, [content]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetUgcDownloadProgress(long content) => 
        Call(GDExtensionMethodName.GetUgcDownloadProgress, [content]).As<Godot.Collections.Dictionary>();

    public new bool IsCloudEnabledForAccount() => 
        Call(GDExtensionMethodName.IsCloudEnabledForAccount, []).As<bool>();

    public new bool IsCloudEnabledForApp() => 
        Call(GDExtensionMethodName.IsCloudEnabledForApp, []).As<bool>();

    public new void SetCloudEnabledForApp(bool enabled) => 
        Call(GDExtensionMethodName.SetCloudEnabledForApp, [enabled]);

    public new bool SetSyncPlatforms(string file, long platform) => 
        Call(GDExtensionMethodName.SetSyncPlatforms, [file, platform]).As<bool>();

    public new void UgcDownload(long content, long priority) => 
        Call(GDExtensionMethodName.UgcDownload, [content, priority]);

    public new void UgcDownloadToLocation(long content, string location, long priority) => 
        Call(GDExtensionMethodName.UgcDownloadToLocation, [content, location, priority]);

    public new byte[] UgcRead(long content, long dataSize, long offset, Steam.UgcReadAction action) => 
        Call(GDExtensionMethodName.UgcRead, [content, dataSize, offset, Variant.From(action)]).As<byte[]>();

    public new long AddScreenshotToLibrary(string filename, string thumbnailFilename, long width, long height) => 
        Call(GDExtensionMethodName.AddScreenshotToLibrary, [filename, thumbnailFilename, width, height]).As<long>();

    public new long AddVrScreenshotToLibrary(Steam.VrScreenshotType type, string filename, string vrFilename) => 
        Call(GDExtensionMethodName.AddVrScreenshotToLibrary, [Variant.From(type), filename, vrFilename]).As<long>();

    public new void HookScreenshots(bool hook) => 
        Call(GDExtensionMethodName.HookScreenshots, [hook]);

    public new bool IsScreenshotsHooked() => 
        Call(GDExtensionMethodName.IsScreenshotsHooked, []).As<bool>();

    public new bool SetLocation(long screenshot, string location) => 
        Call(GDExtensionMethodName.SetLocation, [screenshot, location]).As<bool>();

    public new bool TagPublishedFile(long screenshot, long fileId) => 
        Call(GDExtensionMethodName.TagPublishedFile, [screenshot, fileId]).As<bool>();

    public new bool TagUser(long screenshot, long steamId) => 
        Call(GDExtensionMethodName.TagUser, [screenshot, steamId]).As<bool>();

    public new void TriggerScreenshot() => 
        Call(GDExtensionMethodName.TriggerScreenshot, []);

    public new long WriteScreenshot(byte[] rgb, long width, long height) => 
        Call(GDExtensionMethodName.WriteScreenshot, [rgb, width, height]).As<long>();

    public new void AddGamePhaseTag(string tagName, string tagIcon, string tagGroup, long priority) => 
        Call(GDExtensionMethodName.AddGamePhaseTag, [tagName, tagIcon, tagGroup, priority]);

    public new long AddInstantaneousTimelineEvent(string title, string description, string icon, long iconPriority, double startOffsetSeconds, Steam.TimelineEventClipPriority possibleClip = Steam.TimelineEventClipPriority.None) => 
        Call(GDExtensionMethodName.AddInstantaneousTimelineEvent, [title, description, icon, iconPriority, startOffsetSeconds, Variant.From(possibleClip)]).As<long>();

    public new long AddRangeTimelineEvent(string title, string description, string icon, long iconPriority, double startOffsetSeconds, double duration, Steam.TimelineEventClipPriority possibleClip = Steam.TimelineEventClipPriority.None) => 
        Call(GDExtensionMethodName.AddRangeTimelineEvent, [title, description, icon, iconPriority, startOffsetSeconds, duration, Variant.From(possibleClip)]).As<long>();

    public new void ClearTimelineTooltip(double timeDelta) => 
        Call(GDExtensionMethodName.ClearTimelineTooltip, [timeDelta]);

    public new void DoesEventRecordingExist(long timelineEventHandle) => 
        Call(GDExtensionMethodName.DoesEventRecordingExist, [timelineEventHandle]);

    public new void DoesGamePhaseRecordingExist(string phaseId) => 
        Call(GDExtensionMethodName.DoesGamePhaseRecordingExist, [phaseId]);

    public new void EndGamePhase() => 
        Call(GDExtensionMethodName.EndGamePhase, []);

    public new void EndRangeTimelineEvent(long timelineEventHandle, double endOffsetSeconds) => 
        Call(GDExtensionMethodName.EndRangeTimelineEvent, [timelineEventHandle, endOffsetSeconds]);

    public new void OpenOverlayToGamePhase(string phaseId) => 
        Call(GDExtensionMethodName.OpenOverlayToGamePhase, [phaseId]);

    public new void OpenOverlayToTimelineEvent(long timelineEventHandle) => 
        Call(GDExtensionMethodName.OpenOverlayToTimelineEvent, [timelineEventHandle]);

    public new void RemoveTimelineEvent(long timelineEventHandle) => 
        Call(GDExtensionMethodName.RemoveTimelineEvent, [timelineEventHandle]);

    public new void SetGamePhaseAttribute(string attributeGroup, string attributeValue, long priority) => 
        Call(GDExtensionMethodName.SetGamePhaseAttribute, [attributeGroup, attributeValue, priority]);

    public new void SetGamePhaseId(string phaseId) => 
        Call(GDExtensionMethodName.SetGamePhaseId, [phaseId]);

    public new void SetTimelineGameMode(Steam.TimelineGameMode mode) => 
        Call(GDExtensionMethodName.SetTimelineGameMode, [Variant.From(mode)]);

    public new void SetTimelineTooltip(string description, double timeDelta) => 
        Call(GDExtensionMethodName.SetTimelineTooltip, [description, timeDelta]);

    public new void StartGamePhase() => 
        Call(GDExtensionMethodName.StartGamePhase, []);

    public new long StartRangeTimelineEvent(string title, string description, string icon, long priority, double startOffsetSeconds, Steam.TimelineEventClipPriority possibleClip = Steam.TimelineEventClipPriority.None) => 
        Call(GDExtensionMethodName.StartRangeTimelineEvent, [title, description, icon, priority, startOffsetSeconds, Variant.From(possibleClip)]).As<long>();

    public new void UpdateRangeTimelineEvent(long timelineEventHandle, string title, string description, string icon, long priority, Steam.TimelineEventClipPriority possibleClip = Steam.TimelineEventClipPriority.None) => 
        Call(GDExtensionMethodName.UpdateRangeTimelineEvent, [timelineEventHandle, title, description, icon, priority, Variant.From(possibleClip)]);

    public new void AddAppDependency(long publishedFileId, long appId) => 
        Call(GDExtensionMethodName.AddAppDependency, [publishedFileId, appId]);

    public new bool AddContentDescriptor(long updateHandle, Steam.UgcContentDescriptorId descriptorId) => 
        Call(GDExtensionMethodName.AddContentDescriptor, [updateHandle, Variant.From(descriptorId)]).As<bool>();

    public new void AddDependency(long publishedFileId, long childPublishedFileId) => 
        Call(GDExtensionMethodName.AddDependency, [publishedFileId, childPublishedFileId]);

    public new bool AddExcludedTag(long queryHandle, string tagName) => 
        Call(GDExtensionMethodName.AddExcludedTag, [queryHandle, tagName]).As<bool>();

    public new bool AddItemKeyValueTag(long updateHandle, string key, string value) => 
        Call(GDExtensionMethodName.AddItemKeyValueTag, [updateHandle, key, value]).As<bool>();

    public new bool AddItemPreviewFile(long updateHandle, string previewFile, Steam.ItemPreviewType previewType) => 
        Call(GDExtensionMethodName.AddItemPreviewFile, [updateHandle, previewFile, Variant.From(previewType)]).As<bool>();

    public new bool AddItemPreviewVideo(long updateHandle, string videoId) => 
        Call(GDExtensionMethodName.AddItemPreviewVideo, [updateHandle, videoId]).As<bool>();

    public new void AddItemToFavorites(long appId, long publishedFileId) => 
        Call(GDExtensionMethodName.AddItemToFavorites, [appId, publishedFileId]);

    public new bool AddRequiredKeyValueTag(long queryHandle, string key, string value) => 
        Call(GDExtensionMethodName.AddRequiredKeyValueTag, [queryHandle, key, value]).As<bool>();

    public new bool AddRequiredTag(long queryHandle, string tagName) => 
        Call(GDExtensionMethodName.AddRequiredTag, [queryHandle, tagName]).As<bool>();

    public new bool AddRequiredTagGroup(long queryHandle, Godot.Collections.Array tagArray) => 
        Call(GDExtensionMethodName.AddRequiredTagGroup, [queryHandle, tagArray]).As<bool>();

    public new bool InitWorkshopForGameServer(long workshopDepotId, string folder) => 
        Call(GDExtensionMethodName.InitWorkshopForGameServer, [workshopDepotId, folder]).As<bool>();

    public new bool MarkDownloadedItemAsUnused(long publishedFileId) => 
        Call(GDExtensionMethodName.MarkDownloadedItemAsUnused, [publishedFileId]).As<bool>();

    public new void CreateItem(long appId, Steam.WorkshopFileType fileType) => 
        Call(GDExtensionMethodName.CreateItem, [appId, Variant.From(fileType)]);

    public new long CreateQueryAllUgcRequestPage(Steam.UgcQuery queryType, Steam.UgcMatchingUgcType matchingType, long creatorId, long consumerId, long page) => 
        Call(GDExtensionMethodName.CreateQueryAllUgcRequestPage, [Variant.From(queryType), Variant.From(matchingType), creatorId, consumerId, page]).As<long>();

    public new long CreateQueryAllUgcRequestCursor(Steam.UgcQuery queryType, Steam.UgcMatchingUgcType matchingType, long creatorId, long consumerId, string cursor) => 
        Call(GDExtensionMethodName.CreateQueryAllUgcRequestCursor, [Variant.From(queryType), Variant.From(matchingType), creatorId, consumerId, cursor]).As<long>();

    public new long CreateQueryUgcDetailsRequest(Godot.Collections.Array publishedFileIdArray) => 
        Call(GDExtensionMethodName.CreateQueryUgcDetailsRequest, [publishedFileIdArray]).As<long>();

    public new long CreateQueryUserUgcRequest(long accountId, Steam.UserUgcList listType, Steam.UgcMatchingUgcType matchingUgcType, Steam.UserUgcListSortOrder sortOrder, long creatorId, long consumerId, long page) => 
        Call(GDExtensionMethodName.CreateQueryUserUgcRequest, [accountId, Variant.From(listType), Variant.From(matchingUgcType), Variant.From(sortOrder), creatorId, consumerId, page]).As<long>();

    public new void DeleteItem(long publishedFileId) => 
        Call(GDExtensionMethodName.DeleteItem, [publishedFileId]);

    public new bool DownloadItem(long publishedFileId, bool highPriority) => 
        Call(GDExtensionMethodName.DownloadItem, [publishedFileId, highPriority]).As<bool>();

    public new void GetAppDependencies(long publishedFileId) => 
        Call(GDExtensionMethodName.GetAppDependencies, [publishedFileId]);

    public new long[] GetDownloadedItems(long maxEntries) => 
        Call(GDExtensionMethodName.GetDownloadedItems, [maxEntries]).As<long[]>();

    public new Godot.Collections.Dictionary GetItemDownloadInfo(long publishedFileId) => 
        Call(GDExtensionMethodName.GetItemDownloadInfo, [publishedFileId]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetItemInstallInfo(long publishedFileId) => 
        Call(GDExtensionMethodName.GetItemInstallInfo, [publishedFileId]).As<Godot.Collections.Dictionary>();

    public new long GetItemState(long publishedFileId) => 
        Call(GDExtensionMethodName.GetItemState, [publishedFileId]).As<long>();

    public new Godot.Collections.Dictionary GetItemUpdateProgress(long updateHandle) => 
        Call(GDExtensionMethodName.GetItemUpdateProgress, [updateHandle]).As<Godot.Collections.Dictionary>();

    public new long GetNumDownloadedItems() => 
        Call(GDExtensionMethodName.GetNumDownloadedItems, []).As<long>();

    public new long GetNumSubscribedItems(bool includeLocallyDisabled = false) => 
        Call(GDExtensionMethodName.GetNumSubscribedItems, [includeLocallyDisabled]).As<long>();

    public new long GetNumSupportedGameVersions(long queryHandle, long index) => 
        Call(GDExtensionMethodName.GetNumSupportedGameVersions, [queryHandle, index]).As<long>();

    public new Godot.Collections.Dictionary GetQueryUgcAdditionalPreview(long queryHandle, long index, long previewIndex) => 
        Call(GDExtensionMethodName.GetQueryUgcAdditionalPreview, [queryHandle, index, previewIndex]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetQueryUgcChildren(long queryHandle, long index, long childCount) => 
        Call(GDExtensionMethodName.GetQueryUgcChildren, [queryHandle, index, childCount]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetQueryUgcContentDescriptors(long queryHandle, long index, long maxEntries = 5) => 
        Call(GDExtensionMethodName.GetQueryUgcContentDescriptors, [queryHandle, index, maxEntries]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetQueryUgcKeyValueTag(long queryHandle, long index, long keyValueTagIndex) => 
        Call(GDExtensionMethodName.GetQueryUgcKeyValueTag, [queryHandle, index, keyValueTagIndex]).As<Godot.Collections.Dictionary>();

    public new string GetQueryUgcMetadata(long queryHandle, long index) => 
        Call(GDExtensionMethodName.GetQueryUgcMetadata, [queryHandle, index]).As<string>();

    public new long GetQueryUgcNumAdditionalPreviews(long queryHandle, long index) => 
        Call(GDExtensionMethodName.GetQueryUgcNumAdditionalPreviews, [queryHandle, index]).As<long>();

    public new long GetQueryUgcNumKeyValueTags(long queryHandle, long index) => 
        Call(GDExtensionMethodName.GetQueryUgcNumKeyValueTags, [queryHandle, index]).As<long>();

    public new long GetQueryUgcNumTags(long queryHandle, long index) => 
        Call(GDExtensionMethodName.GetQueryUgcNumTags, [queryHandle, index]).As<long>();

    public new string GetQueryUgcPreviewUrl(long queryHandle, long index) => 
        Call(GDExtensionMethodName.GetQueryUgcPreviewUrl, [queryHandle, index]).As<string>();

    public new Godot.Collections.Dictionary GetQueryUgcResult(long queryHandle, long index) => 
        Call(GDExtensionMethodName.GetQueryUgcResult, [queryHandle, index]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetQueryUgcStatistic(long queryHandle, long index, Steam.ItemStatistic statType) => 
        Call(GDExtensionMethodName.GetQueryUgcStatistic, [queryHandle, index, Variant.From(statType)]).As<Godot.Collections.Dictionary>();

    public new string GetQueryUgcTag(long queryHandle, long index, long tagIndex) => 
        Call(GDExtensionMethodName.GetQueryUgcTag, [queryHandle, index, tagIndex]).As<string>();

    public new string GetQueryUgcTagDisplayName(long queryHandle, long index, long tagIndex) => 
        Call(GDExtensionMethodName.GetQueryUgcTagDisplayName, [queryHandle, index, tagIndex]).As<string>();

    public new Godot.Collections.Array GetSubscribedItems(bool includeLocallyDisabled = false) => 
        Call(GDExtensionMethodName.GetSubscribedItems, [includeLocallyDisabled]).As<Godot.Collections.Array>();

    public new Godot.Collections.Dictionary GetSupportedGameVersionData(long queryHandle, long index, long versionIndex) => 
        Call(GDExtensionMethodName.GetSupportedGameVersionData, [queryHandle, index, versionIndex]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Array GetUserContentDescriptorPreferences(long maxEntries = 5) => 
        Call(GDExtensionMethodName.GetUserContentDescriptorPreferences, [maxEntries]).As<Godot.Collections.Array>();

    public new void GetUserItemVote(long publishedFileId) => 
        Call(GDExtensionMethodName.GetUserItemVote, [publishedFileId]);

    public new bool ReleaseQueryUgcRequest(long queryHandle) => 
        Call(GDExtensionMethodName.ReleaseQueryUgcRequest, [queryHandle]).As<bool>();

    public new bool RemoveAllItemKeyValueTags(long updateHandle) => 
        Call(GDExtensionMethodName.RemoveAllItemKeyValueTags, [updateHandle]).As<bool>();

    public new void RemoveAppDependency(long publishedFileId, long appId) => 
        Call(GDExtensionMethodName.RemoveAppDependency, [publishedFileId, appId]);

    public new bool RemoveContentDescriptor(long updateHandle, Steam.UgcContentDescriptorId descriptorId) => 
        Call(GDExtensionMethodName.RemoveContentDescriptor, [updateHandle, Variant.From(descriptorId)]).As<bool>();

    public new void RemoveDependency(long publishedFileId, long childPublishedFileId) => 
        Call(GDExtensionMethodName.RemoveDependency, [publishedFileId, childPublishedFileId]);

    public new void RemoveItemFromFavorites(long appId, long publishedFileId) => 
        Call(GDExtensionMethodName.RemoveItemFromFavorites, [appId, publishedFileId]);

    public new bool RemoveItemKeyValueTags(long updateHandle, string key) => 
        Call(GDExtensionMethodName.RemoveItemKeyValueTags, [updateHandle, key]).As<bool>();

    public new bool RemoveItemPreview(long updateHandle, long index) => 
        Call(GDExtensionMethodName.RemoveItemPreview, [updateHandle, index]).As<bool>();

    public new void SendQueryUgcRequest(long queryHandle) => 
        Call(GDExtensionMethodName.SendQueryUgcRequest, [queryHandle]);

    public new bool SetAdminQuery(long queryHandle, bool adminQuery) => 
        Call(GDExtensionMethodName.SetAdminQuery, [queryHandle, adminQuery]).As<bool>();

    public new bool SetAllowCachedResponse(long updateHandle, long maxAgeSeconds) => 
        Call(GDExtensionMethodName.SetAllowCachedResponse, [updateHandle, maxAgeSeconds]).As<bool>();

    public new bool SetAllowLegacyUpload(long updateHandle, bool allowLegacyUpload) => 
        Call(GDExtensionMethodName.SetAllowLegacyUpload, [updateHandle, allowLegacyUpload]).As<bool>();

    public new bool SetCloudFileNameFilter(long queryHandle, string matchCloudFilename) => 
        Call(GDExtensionMethodName.SetCloudFileNameFilter, [queryHandle, matchCloudFilename]).As<bool>();

    public new bool SetItemContent(long updateHandle, string contentFolder) => 
        Call(GDExtensionMethodName.SetItemContent, [updateHandle, contentFolder]).As<bool>();

    public new bool SetItemDescription(long updateHandle, string description) => 
        Call(GDExtensionMethodName.SetItemDescription, [updateHandle, description]).As<bool>();

    public new bool SetItemMetadata(long updateHandle, string ugcMetadata) => 
        Call(GDExtensionMethodName.SetItemMetadata, [updateHandle, ugcMetadata]).As<bool>();

    public new bool SetItemPreview(long updateHandle, string previewFile) => 
        Call(GDExtensionMethodName.SetItemPreview, [updateHandle, previewFile]).As<bool>();

    public new bool SetItemTags(long updateHandle, Godot.Collections.Array tagArray, bool allowAdminTags = false) => 
        Call(GDExtensionMethodName.SetItemTags, [updateHandle, tagArray, allowAdminTags]).As<bool>();

    public new bool SetItemTitle(long updateHandle, string title) => 
        Call(GDExtensionMethodName.SetItemTitle, [updateHandle, title]).As<bool>();

    public new bool SetItemUpdateLanguage(long updateHandle, string language) => 
        Call(GDExtensionMethodName.SetItemUpdateLanguage, [updateHandle, language]).As<bool>();

    public new bool SetItemVisibility(long updateHandle, Steam.RemoteStoragePublishedFileVisibility visibility) => 
        Call(GDExtensionMethodName.SetItemVisibility, [updateHandle, Variant.From(visibility)]).As<bool>();

    public new bool SetItemsDisabledLocally(long[] fileIds, bool disabledLocally) => 
        Call(GDExtensionMethodName.SetItemsDisabledLocally, [fileIds, disabledLocally]).As<bool>();

    public new bool SetLanguage(long queryHandle, string language) => 
        Call(GDExtensionMethodName.SetLanguage, [queryHandle, language]).As<bool>();

    public new bool SetMatchAnyTag(long queryHandle, bool matchAnyTag) => 
        Call(GDExtensionMethodName.SetMatchAnyTag, [queryHandle, matchAnyTag]).As<bool>();

    public new bool SetRankedByTrendDays(long queryHandle, long days) => 
        Call(GDExtensionMethodName.SetRankedByTrendDays, [queryHandle, days]).As<bool>();

    public new bool SetRequiredGameVersions(long queryHandle, string gameBranchMin, string gameBranchMax) => 
        Call(GDExtensionMethodName.SetRequiredGameVersions, [queryHandle, gameBranchMin, gameBranchMax]).As<bool>();

    public new bool SetReturnAdditionalPreviews(long queryHandle, bool returnAdditionalPreviews) => 
        Call(GDExtensionMethodName.SetReturnAdditionalPreviews, [queryHandle, returnAdditionalPreviews]).As<bool>();

    public new bool SetReturnChildren(long queryHandle, bool returnChildren) => 
        Call(GDExtensionMethodName.SetReturnChildren, [queryHandle, returnChildren]).As<bool>();

    public new bool SetReturnKeyValueTags(long queryHandle, bool returnKeyValueTags) => 
        Call(GDExtensionMethodName.SetReturnKeyValueTags, [queryHandle, returnKeyValueTags]).As<bool>();

    public new bool SetReturnLongDescription(long queryHandle, bool returnLongDescription) => 
        Call(GDExtensionMethodName.SetReturnLongDescription, [queryHandle, returnLongDescription]).As<bool>();

    public new bool SetReturnMetadata(long queryHandle, bool returnMetadata) => 
        Call(GDExtensionMethodName.SetReturnMetadata, [queryHandle, returnMetadata]).As<bool>();

    public new bool SetReturnOnlyIDs(long queryHandle, bool returnOnlyIds) => 
        Call(GDExtensionMethodName.SetReturnOnlyIDs, [queryHandle, returnOnlyIds]).As<bool>();

    public new bool SetReturnPlaytimeStats(long queryHandle, long days) => 
        Call(GDExtensionMethodName.SetReturnPlaytimeStats, [queryHandle, days]).As<bool>();

    public new bool SetReturnTotalOnly(long queryHandle, bool returnTotalOnly) => 
        Call(GDExtensionMethodName.SetReturnTotalOnly, [queryHandle, returnTotalOnly]).As<bool>();

    public new bool SetSearchText(long queryHandle, string searchText) => 
        Call(GDExtensionMethodName.SetSearchText, [queryHandle, searchText]).As<bool>();

    public new bool SetSubscriptionsLoadOrder(long[] publishedFileIds) => 
        Call(GDExtensionMethodName.SetSubscriptionsLoadOrder, [publishedFileIds]).As<bool>();

    public new void SetUserItemVote(long publishedFileId, bool voteUp) => 
        Call(GDExtensionMethodName.SetUserItemVote, [publishedFileId, voteUp]);

    public new long StartItemUpdate(long appId, long fileId) => 
        Call(GDExtensionMethodName.StartItemUpdate, [appId, fileId]).As<long>();

    public new void StartPlaytimeTracking(Godot.Collections.Array publishedFileIds) => 
        Call(GDExtensionMethodName.StartPlaytimeTracking, [publishedFileIds]);

    public new void StopPlaytimeTracking(Godot.Collections.Array publishedFileIds) => 
        Call(GDExtensionMethodName.StopPlaytimeTracking, [publishedFileIds]);

    public new void StopPlaytimeTrackingForAllItems() => 
        Call(GDExtensionMethodName.StopPlaytimeTrackingForAllItems, []);

    public new void SubmitItemUpdate(long updateHandle, string changeNote = "") => 
        Call(GDExtensionMethodName.SubmitItemUpdate, [updateHandle, changeNote]);

    public new void SubscribeItem(long publishedFileId) => 
        Call(GDExtensionMethodName.SubscribeItem, [publishedFileId]);

    public new void SuspendDownloads(bool suspend) => 
        Call(GDExtensionMethodName.SuspendDownloads, [suspend]);

    public new void UnsubscribeItem(long publishedFileId) => 
        Call(GDExtensionMethodName.UnsubscribeItem, [publishedFileId]);

    public new bool UpdateItemPreviewFile(long updateHandle, long index, string previewFile) => 
        Call(GDExtensionMethodName.UpdateItemPreviewFile, [updateHandle, index, previewFile]).As<bool>();

    public new bool UpdateItemPreviewVideo(long updateHandle, long index, string videoId) => 
        Call(GDExtensionMethodName.UpdateItemPreviewVideo, [updateHandle, index, videoId]).As<bool>();

    public new bool ShowWorkshopEula() => 
        Call(GDExtensionMethodName.ShowWorkshopEula, []).As<bool>();

    public new void GetWorkshopEulaStatus() => 
        Call(GDExtensionMethodName.GetWorkshopEulaStatus, []);

    public new bool SetTimeCreatedDateRange(long updateHandle, long start, long end) => 
        Call(GDExtensionMethodName.SetTimeCreatedDateRange, [updateHandle, start, end]).As<bool>();

    public new bool SetTimeUpdatedDateRange(long updateHandle, long start, long end) => 
        Call(GDExtensionMethodName.SetTimeUpdatedDateRange, [updateHandle, start, end]).As<bool>();

    public new void AdvertiseGame(string serverIp = "", long port = 0) => 
        Call(GDExtensionMethodName.AdvertiseGame, [serverIp, port]);

    public new Steam.BeginAuthSessionResult BeginAuthSession(byte[] ticket, long ticketSize, long steamId) => 
        Call(GDExtensionMethodName.BeginAuthSession, [ticket, ticketSize, steamId]).As<Steam.BeginAuthSessionResult>();

    public new void CancelAuthTicket(long authTicket) => 
        Call(GDExtensionMethodName.CancelAuthTicket, [authTicket]);

    public new Godot.Collections.Dictionary DecompressVoice(byte[] voiceData, long sampleRate = 11025, long bufferSize = 20480) => 
        Call(GDExtensionMethodName.DecompressVoice, [voiceData, sampleRate, bufferSize]).As<Godot.Collections.Dictionary>();

    public new void EndAuthSession(long steamId) => 
        Call(GDExtensionMethodName.EndAuthSession, [steamId]);

    public new Godot.Collections.Dictionary GetAuthSessionTicket(long remoteSteamId = 0) => 
        Call(GDExtensionMethodName.GetAuthSessionTicket, [remoteSteamId]).As<Godot.Collections.Dictionary>();

    public new long GetAuthTicketForWebApi(string serviceIdentity = "") => 
        Call(GDExtensionMethodName.GetAuthTicketForWebApi, [serviceIdentity]).As<long>();

    public new Godot.Collections.Dictionary GetAvailableVoice() => 
        Call(GDExtensionMethodName.GetAvailableVoice, []).As<Godot.Collections.Dictionary>();

    public new void GetDurationControl() => 
        Call(GDExtensionMethodName.GetDurationControl, []);

    public new Godot.Collections.Dictionary GetEncryptedAppTicket() => 
        Call(GDExtensionMethodName.GetEncryptedAppTicket, []).As<Godot.Collections.Dictionary>();

    public new long GetGameBadgeLevel(long series, bool foil) => 
        Call(GDExtensionMethodName.GetGameBadgeLevel, [series, foil]).As<long>();

    public new long GetPlayerSteamLevel() => 
        Call(GDExtensionMethodName.GetPlayerSteamLevel, []).As<long>();

    public new ulong GetSteamId() =>
        Call(GDExtensionMethodName.GetSteamId, []).As<ulong>();

    public new Godot.Collections.Dictionary GetVoice(long bufferSize = 1024) => 
        Call(GDExtensionMethodName.GetVoice, [bufferSize]).As<Godot.Collections.Dictionary>();

    public new long GetVoiceOptimalSampleRate() => 
        Call(GDExtensionMethodName.GetVoiceOptimalSampleRate, []).As<long>();

    public new Godot.Collections.Dictionary InitiateGameConnection(long serverId, string serverIp, long serverPort, bool secure) => 
        Call(GDExtensionMethodName.InitiateGameConnection, [serverId, serverIp, serverPort, secure]).As<Godot.Collections.Dictionary>();

    public new bool IsBehindNat() => 
        Call(GDExtensionMethodName.IsBehindNat, []).As<bool>();

    public new bool IsPhoneIdentifying() => 
        Call(GDExtensionMethodName.IsPhoneIdentifying, []).As<bool>();

    public new bool IsPhoneRequiringVerification() => 
        Call(GDExtensionMethodName.IsPhoneRequiringVerification, []).As<bool>();

    public new bool IsPhoneVerified() => 
        Call(GDExtensionMethodName.IsPhoneVerified, []).As<bool>();

    public new bool IsTwoFactorEnabled() => 
        Call(GDExtensionMethodName.IsTwoFactorEnabled, []).As<bool>();

    public new bool LoggedOn() => 
        Call(GDExtensionMethodName.LoggedOn, []).As<bool>();

    public new void RequestEncryptedAppTicket(string secret) => 
        Call(GDExtensionMethodName.RequestEncryptedAppTicket, [secret]);

    public new void RequestStoreAuthUrl(string redirectUrl) => 
        Call(GDExtensionMethodName.RequestStoreAuthUrl, [redirectUrl]);

    public new void StartVoiceRecording() => 
        Call(GDExtensionMethodName.StartVoiceRecording, []);

    public new bool SetDurationControlOnlineState(Steam.DurationControlOnlineState newState) => 
        Call(GDExtensionMethodName.SetDurationControlOnlineState, [Variant.From(newState)]).As<bool>();

    public new void StopVoiceRecording() => 
        Call(GDExtensionMethodName.StopVoiceRecording, []);

    public new void TerminateGameConnection(string serverIp, long serverPort) => 
        Call(GDExtensionMethodName.TerminateGameConnection, [serverIp, serverPort]);

    public new Steam.UserHasLicenseForAppResult UserHasLicenseForApp(long steamId, long appId) => 
        Call(GDExtensionMethodName.UserHasLicenseForApp, [steamId, appId]).As<Steam.UserHasLicenseForAppResult>();

    public new void AttachLeaderboardUgc(long ugcHandle, long thisLeaderboard = 0) => 
        Call(GDExtensionMethodName.AttachLeaderboardUgc, [ugcHandle, thisLeaderboard]);

    public new bool ClearAchievement(string achievementName) => 
        Call(GDExtensionMethodName.ClearAchievement, [achievementName]).As<bool>();

    public new void DownloadLeaderboardEntries(long start, long end, Steam.LeaderboardDataRequest type = Steam.LeaderboardDataRequest.Global, long thisLeaderboard = 0) => 
        Call(GDExtensionMethodName.DownloadLeaderboardEntries, [start, end, Variant.From(type), thisLeaderboard]);

    public new void DownloadLeaderboardEntriesForUsers(Godot.Collections.Array usersId, long thisLeaderboard = 0) => 
        Call(GDExtensionMethodName.DownloadLeaderboardEntriesForUsers, [usersId, thisLeaderboard]);

    public new void FindLeaderboard(string leaderboardName) => 
        Call(GDExtensionMethodName.FindLeaderboard, [leaderboardName]);

    public new void FindOrCreateLeaderboard(string leaderboardName, Steam.LeaderboardSortMethod sortMethod, Steam.LeaderboardDisplayType displayType) => 
        Call(GDExtensionMethodName.FindOrCreateLeaderboard, [leaderboardName, Variant.From(sortMethod), Variant.From(displayType)]);

    public new Godot.Collections.Dictionary GetAchievement(string achievementName) => 
        Call(GDExtensionMethodName.GetAchievement, [achievementName]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetAchievementAchievedPercent(string achievementName) => 
        Call(GDExtensionMethodName.GetAchievementAchievedPercent, [achievementName]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetAchievementAndUnlockTime(string achievementName) => 
        Call(GDExtensionMethodName.GetAchievementAndUnlockTime, [achievementName]).As<Godot.Collections.Dictionary>();

    public new string GetAchievementDisplayAttribute(string achievementName, string key) => 
        Call(GDExtensionMethodName.GetAchievementDisplayAttribute, [achievementName, key]).As<string>();

    public new long GetAchievementIcon(string achievementName) => 
        Call(GDExtensionMethodName.GetAchievementIcon, [achievementName]).As<long>();

    public new string GetAchievementName(long achievementIndex) => 
        Call(GDExtensionMethodName.GetAchievementName, [achievementIndex]).As<string>();

    public new Godot.Collections.Dictionary GetAchievementProgressLimitsInt(string achievementName) => 
        Call(GDExtensionMethodName.GetAchievementProgressLimitsInt, [achievementName]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetAchievementProgressLimitsFloat(string achievementName) => 
        Call(GDExtensionMethodName.GetAchievementProgressLimitsFloat, [achievementName]).As<Godot.Collections.Dictionary>();

    public new long GetGlobalStatInt(string statName) => 
        Call(GDExtensionMethodName.GetGlobalStatInt, [statName]).As<long>();

    public new double GetGlobalStatFloat(string statName) => 
        Call(GDExtensionMethodName.GetGlobalStatFloat, [statName]).As<double>();

    public new long[] GetGlobalStatIntHistory(string statName) => 
        Call(GDExtensionMethodName.GetGlobalStatIntHistory, [statName]).As<long[]>();

    public new double[] GetGlobalStatFloatHistory(string statName) => 
        Call(GDExtensionMethodName.GetGlobalStatFloatHistory, [statName]).As<double[]>();

    public new Steam.LeaderboardDisplayType GetLeaderboardDisplayType(long thisLeaderboard = 0) => 
        Call(GDExtensionMethodName.GetLeaderboardDisplayType, [thisLeaderboard]).As<Steam.LeaderboardDisplayType>();

    public new long GetLeaderboardEntryCount(long thisLeaderboard = 0) => 
        Call(GDExtensionMethodName.GetLeaderboardEntryCount, [thisLeaderboard]).As<long>();

    public new string GetLeaderboardName(long thisLeaderboard = 0) => 
        Call(GDExtensionMethodName.GetLeaderboardName, [thisLeaderboard]).As<string>();

    public new Steam.LeaderboardSortMethod GetLeaderboardSortMethod(long thisLeaderboard = 0) => 
        Call(GDExtensionMethodName.GetLeaderboardSortMethod, [thisLeaderboard]).As<Steam.LeaderboardSortMethod>();

    public new Godot.Collections.Dictionary GetMostAchievedAchievementInfo() => 
        Call(GDExtensionMethodName.GetMostAchievedAchievementInfo, []).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetNextMostAchievedAchievementInfo(long iterator) => 
        Call(GDExtensionMethodName.GetNextMostAchievedAchievementInfo, [iterator]).As<Godot.Collections.Dictionary>();

    public new long GetNumAchievements() => 
        Call(GDExtensionMethodName.GetNumAchievements, []).As<long>();

    public new void GetNumberOfCurrentPlayers() => 
        Call(GDExtensionMethodName.GetNumberOfCurrentPlayers, []);

    public new double GetStatFloat(string statName) => 
        Call(GDExtensionMethodName.GetStatFloat, [statName]).As<double>();

    public new long GetStatInt(string statName) => 
        Call(GDExtensionMethodName.GetStatInt, [statName]).As<long>();

    public new Godot.Collections.Dictionary GetUserAchievement(long steamId, string achievementName) => 
        Call(GDExtensionMethodName.GetUserAchievement, [steamId, achievementName]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetUserAchievementAndUnlockTime(long steamId, string achievementName) => 
        Call(GDExtensionMethodName.GetUserAchievementAndUnlockTime, [steamId, achievementName]).As<Godot.Collections.Dictionary>();

    public new double GetUserStatFloat(long steamId, string statName) => 
        Call(GDExtensionMethodName.GetUserStatFloat, [steamId, statName]).As<double>();

    public new long GetUserStatInt(long steamId, string statName) => 
        Call(GDExtensionMethodName.GetUserStatInt, [steamId, statName]).As<long>();

    public new bool IndicateAchievementProgress(string achievementName, long currentProgress, long maxProgress) => 
        Call(GDExtensionMethodName.IndicateAchievementProgress, [achievementName, currentProgress, maxProgress]).As<bool>();

    public new void RequestGlobalAchievementPercentages() => 
        Call(GDExtensionMethodName.RequestGlobalAchievementPercentages, []);

    public new void RequestGlobalStats(long historyDays) => 
        Call(GDExtensionMethodName.RequestGlobalStats, [historyDays]);

    public new void RequestUserStats(long steamId) => 
        Call(GDExtensionMethodName.RequestUserStats, [steamId]);

    public new bool ResetAllStats(bool achievementsToo) => 
        Call(GDExtensionMethodName.ResetAllStats, [achievementsToo]).As<bool>();

    public new bool SetAchievement(string achievementName) => 
        Call(GDExtensionMethodName.SetAchievement, [achievementName]).As<bool>();

    public new bool SetStatFloat(string statName, double value) => 
        Call(GDExtensionMethodName.SetStatFloat, [statName, value]).As<bool>();

    public new bool SetStatInt(string statName, long value) => 
        Call(GDExtensionMethodName.SetStatInt, [statName, value]).As<bool>();

    public new bool StoreStats() => 
        Call(GDExtensionMethodName.StoreStats, []).As<bool>();

    public new bool UpdateAvgRateStat(string statName, double thisSession, double sessionLength) => 
        Call(GDExtensionMethodName.UpdateAvgRateStat, [statName, thisSession, sessionLength]).As<bool>();

    public new void UploadLeaderboardScore(long score, bool keepBest = true, int[] details = default, long thisLeaderboard = 0) => 
        Call(GDExtensionMethodName.UploadLeaderboardScore, [score, keepBest, details, thisLeaderboard]);

    public new void CheckFileSignature(string unnamedArg0) => 
        Call(GDExtensionMethodName.CheckFileSignature, [unnamedArg0]);

    public new bool DismissFloatingGamepadTextInput() => 
        Call(GDExtensionMethodName.DismissFloatingGamepadTextInput, []).As<bool>();

    public new bool DismissGamepadTextInput() => 
        Call(GDExtensionMethodName.DismissGamepadTextInput, []).As<bool>();

    public new string FilterText(Steam.TextFilteringContext context, long steamId, string message) => 
        Call(GDExtensionMethodName.FilterText, [Variant.From(context), steamId, message]).As<string>();

    public new Steam.ApiCallFailure GetApiCallFailureReason() => 
        Call(GDExtensionMethodName.GetApiCallFailureReason, []).As<Steam.ApiCallFailure>();

    public new long GetAppId() => 
        Call(GDExtensionMethodName.GetAppId, []).As<long>();

    public new Steam.Universe GetConnectedUniverse() => 
        Call(GDExtensionMethodName.GetConnectedUniverse, []).As<Steam.Universe>();

    public new long GetCurrentBatteryPower() => 
        Call(GDExtensionMethodName.GetCurrentBatteryPower, []).As<long>();

    public new Godot.Collections.Dictionary GetImageRgba(long imageHandle) => 
        Call(GDExtensionMethodName.GetImageRgba, [imageHandle]).As<Godot.Collections.Dictionary>();

    public new Godot.Collections.Dictionary GetImageSize(long imageHandle) => 
        Call(GDExtensionMethodName.GetImageSize, [imageHandle]).As<Godot.Collections.Dictionary>();

    public new long GetIpcCallCount() => 
        Call(GDExtensionMethodName.GetIpcCallCount, []).As<long>();

    public new string GetIpCountry() => 
        Call(GDExtensionMethodName.GetIpCountry, []).As<string>();

    public new Steam.IPv6ConnectivityState GetIPv6ConnectivityState(Steam.IPv6ConnectivityProtocol protocol) => 
        Call(GDExtensionMethodName.GetIPv6ConnectivityState, [Variant.From(protocol)]).As<Steam.IPv6ConnectivityState>();

    public new long GetSecondsSinceAppActive() => 
        Call(GDExtensionMethodName.GetSecondsSinceAppActive, []).As<long>();

    public new long GetSecondsSinceComputerActive() => 
        Call(GDExtensionMethodName.GetSecondsSinceComputerActive, []).As<long>();

    public new long GetServerRealTime() => 
        Call(GDExtensionMethodName.GetServerRealTime, []).As<long>();

    public new Steam.SteamHardwareDefaultConfig GetSteamHardwareDefaultConfig() => 
        Call(GDExtensionMethodName.GetSteamHardwareDefaultConfig, []).As<Steam.SteamHardwareDefaultConfig>();

    public new string GetSteamUiLanguage() => 
        Call(GDExtensionMethodName.GetSteamUiLanguage, []).As<string>();

    public new bool InitFilterText() => 
        Call(GDExtensionMethodName.InitFilterText, []).As<bool>();

    public new Godot.Collections.Dictionary IsApiCallCompleted() => 
        Call(GDExtensionMethodName.IsApiCallCompleted, []).As<Godot.Collections.Dictionary>();

    public new bool IsOverlayEnabled() => 
        Call(GDExtensionMethodName.IsOverlayEnabled, []).As<bool>();

    public new Steam.SteamHardwareType IsRunningOnSteamHardware() => 
        Call(GDExtensionMethodName.IsRunningOnSteamHardware, []).As<Steam.SteamHardwareType>();

    public new bool IsSteamChinaLauncher() => 
        Call(GDExtensionMethodName.IsSteamChinaLauncher, []).As<bool>();

    public new bool IsRunningUnderProton() => 
        Call(GDExtensionMethodName.IsRunningUnderProton, []).As<bool>();

    public new bool IsSteamInBigPictureMode() => 
        Call(GDExtensionMethodName.IsSteamInBigPictureMode, []).As<bool>();

    public new bool IsSteamRunningInVr() => 
        Call(GDExtensionMethodName.IsSteamRunningInVr, []).As<bool>();

    public new bool IsVrHeadsetStreamingEnabled() => 
        Call(GDExtensionMethodName.IsVrHeadsetStreamingEnabled, []).As<bool>();

    public new bool OverlayNeedsPresent() => 
        Call(GDExtensionMethodName.OverlayNeedsPresent, []).As<bool>();

    public new void SetGameLauncherMode(bool mode) => 
        Call(GDExtensionMethodName.SetGameLauncherMode, [mode]);

    public new void SetOverlayNotificationInset(long horizontal, long vertical) => 
        Call(GDExtensionMethodName.SetOverlayNotificationInset, [horizontal, vertical]);

    public new void SetOverlayNotificationPosition(Steam.NotificationPosition position) => 
        Call(GDExtensionMethodName.SetOverlayNotificationPosition, [Variant.From(position)]);

    public new void SetVrHeadsetStreamingEnabled(bool enabled = true) => 
        Call(GDExtensionMethodName.SetVrHeadsetStreamingEnabled, [enabled]);

    public new bool ShowFloatingGamepadTextInput(Steam.FloatingGamepadTextInputMode inputMode, long textFieldXPosition, long textFieldYPosition, long textFieldWidth, long textFieldHeight) => 
        Call(GDExtensionMethodName.ShowFloatingGamepadTextInput, [Variant.From(inputMode), textFieldXPosition, textFieldYPosition, textFieldWidth, textFieldHeight]).As<bool>();

    public new bool ShowGamepadTextInput(Steam.GamepadTextInputMode inputMode, Steam.GamepadTextInputLineMode lineInputMode, string description, long maxText, string presetText) => 
        Call(GDExtensionMethodName.ShowGamepadTextInput, [Variant.From(inputMode), Variant.From(lineInputMode), description, maxText, presetText]).As<bool>();

    public new void StartVrDashboard() => 
        Call(GDExtensionMethodName.StartVrDashboard, []);

    public new void GetOpfSettings(long appId) => 
        Call(GDExtensionMethodName.GetOpfSettings, [appId]);

    public new string GetOpfStringForApp(long appId) => 
        Call(GDExtensionMethodName.GetOpfStringForApp, [appId]).As<string>();

    public new void GetVideoUrl(long appId) => 
        Call(GDExtensionMethodName.GetVideoUrl, [appId]);

    public new Godot.Collections.Dictionary IsBroadcasting() => 
        Call(GDExtensionMethodName.IsBroadcasting, []).As<Godot.Collections.Dictionary>();

}
