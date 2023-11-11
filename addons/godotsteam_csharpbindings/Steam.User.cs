namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Advertises the game using the specified server ip
    /// </summary>
    /// <param name="serverIP">The server ip</param>
    /// <param name="port">The port</param>
    public static void AdvertiseGame(string serverIP, long port)
    {
        GetInstance().Call(Methods.AdvertiseGame, serverIP, port);
    }
    
    /// <summary>
    /// Begins the auth session using the specified ticket
    /// </summary>
    /// <param name="ticket">The ticket</param>
    /// <param name="ticketSize">The ticket size</param>
    /// <param name="steamId">The steam id</param>
    /// <returns>The begin auth session result</returns>
    public static BeginAuthSessionResult BeginAuthSession(byte[] ticket, int ticketSize, ulong steamId)
    {
        return (BeginAuthSessionResult)GetInstance().Call(Methods.BeginAuthSession, ticket, ticketSize, steamId).AsInt64();
    }
    
    /// <summary>
    /// Cancels the auth ticket using the specified auth ticket
    /// </summary>
    /// <param name="authTicket">The auth ticket</param>
    public static void CancelAuthTicket(long authTicket)
    {
        GetInstance().Call(Methods.CancelAuthTicket, authTicket);
    }
    
    /// <summary>
    /// Decompresses the voice using the specified voice
    /// </summary>
    /// <param name="voice">The voice</param>
    /// <param name="voiceSize">The voice size</param>
    /// <param name="sampleRate">The sample rate</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary DecompressVoice(byte[] voice, uint voiceSize, long sampleRate)
    {
        return GetInstance().Call(Methods.DecompressVoice, voice, voiceSize, sampleRate).AsGodotDictionary();
    }
    
    /// <summary>
    /// Ends the auth session using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    public static void EndAuthSession(ulong steamId)
    {
        GetInstance().Call(Methods.EndAuthSession, steamId);
    }
    
    /// <summary>
    /// Gets the auth session ticket using the specified identity reference
    /// </summary>
    /// <param name="identityReference">The identity reference</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetAuthSessionTicket(string identityReference = "")
    {
        return GetInstance().Call(Methods.GetAuthSessionTicket, identityReference).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the auth ticket for web api using the specified identity reference
    /// </summary>
    /// <param name="identityReference">The identity reference</param>
    /// <returns>The uint</returns>
    public static uint GetAuthTicketForWebApi(string identityReference = "")
    {
        return GetInstance().Call(Methods.GetAuthTicketForWebApi, identityReference).AsUInt32();
    }
    
    /// <summary>
    /// Gets the available voice
    /// </summary>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetAvailableVoice()
    {
        return GetInstance().Call(Methods.GetAvailableVoice).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the duration control
    /// </summary>
    public static void GetDurationControl()
    {
        GetInstance().Call(Methods.GetDurationControl);
    }
    
    /// <summary>
    /// Gets the encrypted app ticket
    /// </summary>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetEncryptedAppTicket()
    {
        return GetInstance().Call(Methods.GetEncryptedAppTicket).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the game badge level using the specified series
    /// </summary>
    /// <param name="series">The series</param>
    /// <param name="foil">The foil</param>
    /// <returns>The int</returns>
    public static int GetGameBadgeLevel(int series, bool foil)
    {
        return GetInstance().Call(Methods.GetGameBadgeLevel, series, foil).AsInt32();
    }
    
    /// <summary>
    /// Gets the voice
    /// </summary>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetVoice()
    {
        return GetInstance().Call(Methods.GetVoice).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the voice optimal sample rate
    /// </summary>
    /// <returns>The long</returns>
    public static long GetVoiceOptimalSampleRate()
    {
        return GetInstance().Call(Methods.GetVoiceOptimalSampleRate).AsInt64();
    }
    
    /// <summary>
    /// Initiates the game connection using the specified server id
    /// </summary>
    /// <param name="serverId">The server id</param>
    /// <param name="serverIP">The server ip</param>
    /// <param name="serverPort">The server port</param>
    /// <param name="secure">The secure</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary InitiateGameConnection(ulong serverId, uint serverIP, int serverPort, bool secure)
    {
        return GetInstance().Call(Methods.InitiateGameConnection, serverId, serverIP, serverPort, secure).AsGodotDictionary();
    }
    
    /// <summary>
    /// Describes whether is behind nat
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsBehindNAT()
    {
        return GetInstance().Call(Methods.IsBehindNAT).AsBool();
    }
    
    /// <summary>
    /// Describes whether is phone identifying
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsPhoneIdentifying()
    {
        return GetInstance().Call(Methods.IsPhoneIdentifying).AsBool();
    }
    
    /// <summary>
    /// Describes whether is phone requiring verification
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsPhoneRequiringVerification()
    {
        return GetInstance().Call(Methods.IsPhoneRequiringVerification).AsBool();
    }
    
    /// <summary>
    /// Describes whether is phone verified
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsPhoneVerified()
    {
        return GetInstance().Call(Methods.IsPhoneVerified).AsBool();
    }
    
    /// <summary>
    /// Describes whether is two factor enabled
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsTwoFactorEnabled()
    {
        return GetInstance().Call(Methods.IsTwoFactorEnabled).AsBool();
    }
    
    /// <summary>
    /// Describes whether logged on
    /// </summary>
    /// <returns>The bool</returns>
    public static bool LoggedOn()
    {
        return GetInstance().Call(Methods.LoggedOn).AsBool();
    }
    
    /// <summary>
    /// Requests the encrypted app ticket using the specified secret
    /// </summary>
    /// <param name="secret">The secret</param>
    public static void RequestEncryptedAppTicket(string secret)
    {
        GetInstance().Call(Methods.RequestEncryptedAppTicket, secret);
    }
    
    /// <summary>
    /// Requests the store auth url using the specified redirect
    /// </summary>
    /// <param name="redirect">The redirect</param>
    public static void RequestStoreAuthURL(string redirect)
    {
        GetInstance().Call(Methods.RequestStoreAuthURL, redirect);
    }
    
    /// <summary>
    /// Starts the voice recording
    /// </summary>
    public static void StartVoiceRecording()
    {
        GetInstance().Call(Methods.StartVoiceRecording);
    }
    
    /// <summary>
    /// Describes whether set duration control online state
    /// </summary>
    /// <param name="newState">The new state</param>
    /// <returns>The bool</returns>
    public static bool SetDurationControlOnlineState(long newState)
    {
        return GetInstance().Call(Methods.SetDurationControlOnlineState, newState).AsBool();
    }
    
    /// <summary>
    /// Stops the voice recording
    /// </summary>
    public static void StopVoiceRecording()
    {
        GetInstance().Call(Methods.StopVoiceRecording);
    }
    
    /// <summary>
    /// Terminates the game connection using the specified server ip
    /// </summary>
    /// <param name="serverIP">The server ip</param>
    /// <param name="serverPort">The server port</param>
    public static void TerminateGameConnection(uint serverIP, long serverPort)
    {
        GetInstance().Call(Methods.TerminateGameConnection, serverIP, serverPort);
    }
    
    /// <summary>
    /// Users the has license for app using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    /// <param name="appId">The app id</param>
    /// <returns>The int</returns>
    public static int UserHasLicenseForApp(ulong steamId, uint appId)
    {
        return GetInstance().Call(Methods.UserHasLicenseForApp, steamId, appId).AsInt32();
    }
    
    /// <summary>
    /// Gets the steam id
    /// </summary>
    /// <returns>The ulong</returns>
    public static ulong GetSteamID()
    {
        return GetInstance().Call(Methods.GetSteamID).AsUInt64();
    }
    
    /// <summary>
    /// Gets the player steam level
    /// </summary>
    /// <returns>The int</returns>
    public static int GetPlayerSteamLevel()
    {
        return GetInstance().Call(Methods.GetPlayerSteamLevel).AsInt32();
    }

    /// <summary>
    /// The duration control progress enum
    /// </summary>
    public enum DurationControlProgress : long
    {
        /// <summary>
        /// The progress full duration control progress
        /// </summary>
        ProgressFull = 0,
        /// <summary>
        /// The progress half duration control progress
        /// </summary>
        ProgressHalf = 1,
        /// <summary>
        /// The progress none duration control progress
        /// </summary>
        ProgressNone = 2,
        /// <summary>
        /// The exit soon duration control progress
        /// </summary>
        ExitSoon3H = 3,
        /// <summary>
        /// The exit soon duration control progress
        /// </summary>
        ExitSoon5H = 4,
        /// <summary>
        /// The exit soon night duration control progress
        /// </summary>
        ExitSoonNight = 5
    }

    /// <summary>
    /// The duration control notification enum
    /// </summary>
    public enum DurationControlNotification : long
    {
        /// <summary>
        /// The none duration control notification
        /// </summary>
        None = 0,
        /// <summary>
        /// The notification hour duration control notification
        /// </summary>
        Notification1Hour = 1,
        /// <summary>
        /// The notification hours duration control notification
        /// </summary>
        Notification3Hours = 2,
        /// <summary>
        /// The half progress duration control notification
        /// </summary>
        HalfProgress = 3,
        /// <summary>
        /// The no progress duration control notification
        /// </summary>
        NoProgress = 4,
        /// <summary>
        /// The exit soon duration control notification
        /// </summary>
        ExitSoon3H = 5,
        /// <summary>
        /// The exit soon duration control notification
        /// </summary>
        ExitSoon5H = 6,
        /// <summary>
        /// The exit soon night duration control notification
        /// </summary>
        ExitSoonNight = 7
    }
}