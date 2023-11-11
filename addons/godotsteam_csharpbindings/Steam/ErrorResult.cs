namespace GodotSteam;

/// <summary>

/// The error result enum

/// </summary>

public enum ErrorResult
{
    /// <summary>
    /// The ok error result
    /// </summary>
    Ok = 1,
    /// <summary>
    /// The fail error result
    /// </summary>
    Fail = 2,
    /// <summary>
    /// The no connection error result
    /// </summary>
    NoConnection = 3,
    /// <summary>
    /// The invalid password error result
    /// </summary>
    InvalidPassword = 5,
    /// <summary>
    /// The logged in else where error result
    /// </summary>
    LoggedInElseWhere = 6,
    /// <summary>
    /// The invalid protocol version error result
    /// </summary>
    InvalidProtocolVersion = 7,
    /// <summary>
    /// The invalid param error result
    /// </summary>
    InvalidParam = 8,
    /// <summary>
    /// The file not found error result
    /// </summary>
    FileNotFound = 9,
    /// <summary>
    /// The busy error result
    /// </summary>
    Busy = 10,
    /// <summary>
    /// The invalid state error result
    /// </summary>
    InvalidState = 11,
    /// <summary>
    /// The invalid name error result
    /// </summary>
    InvalidName = 12,
    /// <summary>
    /// The invalid email error result
    /// </summary>
    InvalidEmail = 13,
    /// <summary>
    /// The duplicate name error result
    /// </summary>
    DuplicateName = 14,
    /// <summary>
    /// The access denied error result
    /// </summary>
    AccessDenied = 15,
    /// <summary>
    /// The timeout error result
    /// </summary>
    Timeout = 16,
    /// <summary>
    /// The banned error result
    /// </summary>
    Banned = 17,
    /// <summary>
    /// The account not found error result
    /// </summary>
    AccountNotFound = 18,
    /// <summary>
    /// The invalid steam id error result
    /// </summary>
    InvalidSteamId = 19,
    /// <summary>
    /// The service unavailable error result
    /// </summary>
    ServiceUnavailable = 20,
    /// <summary>
    /// The not logged on error result
    /// </summary>
    NotLoggedOn = 21,
    /// <summary>
    /// The pending error result
    /// </summary>
    Pending = 22,
    /// <summary>
    /// The encryption failure error result
    /// </summary>
    EncryptionFailure = 23,
    /// <summary>
    /// The insufficient priviledge error result
    /// </summary>
    InsufficientPriviledge = 24,
    /// <summary>
    /// The limit exceeded error result
    /// </summary>
    LimitExceeded = 25,
    /// <summary>
    /// The revoked error result
    /// </summary>
    Revoked = 26,
    /// <summary>
    /// The expired error result
    /// </summary>
    Expired = 27,
    /// <summary>
    /// The already redeemed error result
    /// </summary>
    AlreadyRedeemed = 28,
    /// <summary>
    /// The duplicate request error result
    /// </summary>
    DuplicateRequest = 29,
    /// <summary>
    /// The already owned error result
    /// </summary>
    AlreadyOwned = 30,
    /// <summary>
    /// The ip not found error result
    /// </summary>
    IPNotFound = 31,
    /// <summary>
    /// The persist failed error result
    /// </summary>
    PersistFailed = 32,
    /// <summary>
    /// The locking failed error result
    /// </summary>
    LockingFailed = 33,
    /// <summary>
    /// The logon session replaced error result
    /// </summary>
    LogonSessionReplaced = 24,
    /// <summary>
    /// The connect failed error result
    /// </summary>
    ConnectFailed = 36,
    /// <summary>
    /// The io failure error result
    /// </summary>
    IOFailure = 37,
    /// <summary>
    /// The remote disconnect error result
    /// </summary>
    RemoteDisconnect = 38,
    /// <summary>
    /// The shopping cart not found error result
    /// </summary>
    ShoppingCartNotFound = 39,
    /// <summary>
    /// The blocked error result
    /// </summary>
    Blocked = 40,
    /// <summary>
    /// The ignored error result
    /// </summary>
    Ignored = 41,
    /// <summary>
    /// The no match error result
    /// </summary>
    NoMatch = 42,
    /// <summary>
    /// The account disabled error result
    /// </summary>
    AccountDisabled = 43,
    /// <summary>
    /// The service read only error result
    /// </summary>
    ServiceReadOnly = 44,
    /// <summary>
    /// The account not featured error result
    /// </summary>
    AccountNotFeatured = 45,
    /// <summary>
    /// The administrator ok error result
    /// </summary>
    AdministratorOk= 46,
    /// <summary>
    /// The content version error result
    /// </summary>
    ContentVersion = 47,
    /// <summary>
    /// The try another cm error result
    /// </summary>
    TryAnotherCM = 48,
    /// <summary>
    /// The password required to kick session error result
    /// </summary>
    PasswordRequiredToKickSession = 49,
    /// <summary>
    /// The already logged in elsewhere error result
    /// </summary>
    AlreadyLoggedInElsewhere = 50,
    /// <summary>
    /// The suspended error result
    /// </summary>
    Suspended = 51,
    /// <summary>
    /// The cancelled error result
    /// </summary>
    Cancelled = 52,
    /// <summary>
    /// The corruption error result
    /// </summary>
    Corruption = 53,
    /// <summary>
    /// The disk full error result
    /// </summary>
    DiskFull = 54,
    /// <summary>
    /// The remote call failed error result
    /// </summary>
    RemoteCallFailed = 55,
    /// <summary>
    /// The password unset error result
    /// </summary>
    PasswordUnset = 56,
    /// <summary>
    /// The external account unlinked error result
    /// </summary>
    ExternalAccountUnlinked = 57,
    /// <summary>
    /// The psn ticket invalid error result
    /// </summary>
    PSNTicketInvalid = 58,
    /// <summary>
    /// The external account already linked error result
    /// </summary>
    ExternalAccountAlreadyLinked = 59,
    /// <summary>
    /// The remote file conflict error result
    /// </summary>
    RemoteFileConflict = 60,
    /// <summary>
    /// The illegal password error result
    /// </summary>
    IllegalPassword = 61,
    /// <summary>
    /// The same as previous value error result
    /// </summary>
    SameAsPreviousValue = 62,
    /// <summary>
    /// The account logon denied error result
    /// </summary>
    AccountLogonDenied = 63,
    /// <summary>
    /// The cannot use old password error result
    /// </summary>
    CannotUseOldPassword = 64,
    /// <summary>
    /// The invalid login auth code error result
    /// </summary>
    InvalidLoginAuthCode = 65,
    /// <summary>
    /// The account logon denied no mail error result
    /// </summary>
    AccountLogonDeniedNoMail = 66,
    /// <summary>
    /// The hardware not capable of ipt error result
    /// </summary>
    HardwareNotCapableOfIPT = 67,
    /// <summary>
    /// The ipt init error error result
    /// </summary>
    IPTInitError = 68,
    /// <summary>
    /// The parental control restricted error result
    /// </summary>
    ParentalControlRestricted = 69,
    /// <summary>
    /// The facebook query error error result
    /// </summary>
    FacebookQueryError = 70,
    /// <summary>
    /// The expired login auth code error result
    /// </summary>
    ExpiredLoginAuthCode = 71,
    /// <summary>
    /// The ip login restriction failed error result
    /// </summary>
    IPLoginRestrictionFailed = 72,
    /// <summary>
    /// The account locked down error result
    /// </summary>
    AccountLockedDown = 73,
    /// <summary>
    /// The account logon denied verified email required error result
    /// </summary>
    AccountLogonDeniedVerifiedEmailRequired = 74,
    /// <summary>
    /// The no matching url error result
    /// </summary>
    NoMatchingURL = 75,
    /// <summary>
    /// The bad response error result
    /// </summary>
    BadResponse = 76,
    /// <summary>
    /// The require password re entry error result
    /// </summary>
    RequirePasswordReEntry = 77,
    /// <summary>
    /// The value out of range error result
    /// </summary>
    ValueOutOfRange = 78,
    /// <summary>
    /// The unexpected error error result
    /// </summary>
    UnexpectedError = 79,
    /// <summary>
    /// The disabled error result
    /// </summary>
    Disabled = 80,
    /// <summary>
    /// The invalid ceg submission error result
    /// </summary>
    InvalidCEGSubmission = 81,
    /// <summary>
    /// The restricted device error result
    /// </summary>
    RestrictedDevice = 82,
    /// <summary>
    /// The region locked error result
    /// </summary>
    RegionLocked = 83,
    /// <summary>
    /// The rate limit exceeded error result
    /// </summary>
    RateLimitExceeded = 84,
    /// <summary>
    /// The account login denied need two factor error result
    /// </summary>
    AccountLoginDeniedNeedTwoFactor = 85,
    /// <summary>
    /// The item deleted error result
    /// </summary>
    ItemDeleted = 86,
    /// <summary>
    /// The account login denied throttle error result
    /// </summary>
    AccountLoginDeniedThrottle = 87,
    /// <summary>
    /// The two factor code mismatch error result
    /// </summary>
    TwoFactorCodeMismatch = 88,
    /// <summary>
    /// The two factor activation code mismatch error result
    /// </summary>
    TwoFactorActivationCodeMismatch = 89,
    /// <summary>
    /// The account associated to multiple partners error result
    /// </summary>
    AccountAssociatedToMultiplePartners = 90,
    /// <summary>
    /// The not modified error result
    /// </summary>
    NotModified = 91,
    /// <summary>
    /// The no mobile device error result
    /// </summary>
    NoMobileDevice = 92,
    /// <summary>
    /// The time not synced error result
    /// </summary>
    TimeNotSynced = 93,
    /// <summary>
    /// The sms code failed error result
    /// </summary>
    SmsCodeFailed = 94,
    /// <summary>
    /// The account limit exceeded error result
    /// </summary>
    AccountLimitExceeded = 95,
    /// <summary>
    /// The account activity limit exceeded error result
    /// </summary>
    AccountActivityLimitExceeded = 96,
    /// <summary>
    /// The phone activity limit exceeded error result
    /// </summary>
    PhoneActivityLimitExceeded = 97,
    /// <summary>
    /// The refund to wallet error result
    /// </summary>
    RefundToWallet = 98,
    /// <summary>
    /// The email send failure error result
    /// </summary>
    EmailSendFailure = 99,
    /// <summary>
    /// The not settled error result
    /// </summary>
    NotSettled = 100,
    /// <summary>
    /// The need captcha error result
    /// </summary>
    NeedCaptcha = 101,
    /// <summary>
    /// The gslt denied error result
    /// </summary>
    GSLTDenied = 102,
    /// <summary>
    /// The gs owner deneid error result
    /// </summary>
    GSOwnerDeneid = 103,
    /// <summary>
    /// The invalid item type error result
    /// </summary>
    InvalidItemType = 104,
    /// <summary>
    /// The ip banned error result
    /// </summary>
    IPBanned = 105,
    /// <summary>
    /// The gslt expired error result
    /// </summary>
    GSLTExpired = 106,
    /// <summary>
    /// The insufficient funds error result
    /// </summary>
    InsufficientFunds = 107,
    /// <summary>
    /// The too many pending error result
    /// </summary>
    TooManyPending = 108,
}