namespace GodotSteam;

public static partial class Steam
{
    public static void AdvertiseGame(string serverIP, long port)
    {
        GetInstance().Call(Methods.AdvertiseGame, serverIP, port);
    }
    
    public static BeginAuthSessionResult BeginAuthSession(byte[] ticket, int ticketSize, ulong steamId)
    {
        return (BeginAuthSessionResult)GetInstance().Call(Methods.BeginAuthSession, ticket, ticketSize, steamId).AsInt64();
    }
    
    public static void CancelAuthTicket(long authTicket)
    {
        GetInstance().Call(Methods.CancelAuthTicket, authTicket);
    }
    
    public static Godot.Collections.Dictionary DecompressVoice(byte[] voice, uint voiceSize, long sampleRate)
    {
        return GetInstance().Call(Methods.DecompressVoice, voice, voiceSize, sampleRate).AsGodotDictionary();
    }
    
    public static void EndAuthSession(ulong steamId)
    {
        GetInstance().Call(Methods.EndAuthSession, steamId);
    }
    
    public static Godot.Collections.Dictionary GetAuthSessionTicket(string identityReference = "")
    {
        return GetInstance().Call(Methods.GetAuthSessionTicket, identityReference).AsGodotDictionary();
    }
    
    public static uint GetAuthTicketForWebApi(string identityReference = "")
    {
        return GetInstance().Call(Methods.GetAuthTicketForWebApi, identityReference).As<uint>();
    }
    
    public static Godot.Collections.Dictionary GetAvailableVoice()
    {
        return GetInstance().Call(Methods.GetAvailableVoice).AsGodotDictionary();
    }
    
    public static void GetDurationControl()
    {
        GetInstance().Call(Methods.GetDurationControl);
    }
    
    public static Godot.Collections.Dictionary GetEncryptedAppTicket()
    {
        return GetInstance().Call(Methods.GetEncryptedAppTicket).AsGodotDictionary();
    }
    
    public static int GetGameBadgeLevel(int series, bool foil)
    {
        return GetInstance().Call(Methods.GetGameBadgeLevel, series, foil).As<int>();
    }
    
    public static Godot.Collections.Dictionary GetVoice()
    {
        return GetInstance().Call(Methods.GetVoice).AsGodotDictionary();
    }
    
    public static long GetVoiceOptimalSampleRate()
    {
        return GetInstance().Call(Methods.GetVoiceOptimalSampleRate).AsInt64();
    }
    
    public static Godot.Collections.Dictionary InitiateGameConnection(ulong serverId, uint serverIP, int serverPort, bool secure)
    {
        return GetInstance().Call(Methods.InitiateGameConnection, serverId, serverIP, serverPort, secure).AsGodotDictionary();
    }
    
    public static bool IsBehindNAT()
    {
        return GetInstance().Call(Methods.IsBehindNAT).As<bool>();
    }
    
    public static bool IsPhoneIdentifying()
    {
        return GetInstance().Call(Methods.IsPhoneIdentifying).As<bool>();
    }
    
    public static bool IsPhoneRequiringVerification()
    {
        return GetInstance().Call(Methods.IsPhoneRequiringVerification).As<bool>();
    }
    
    public static bool IsPhoneVerified()
    {
        return GetInstance().Call(Methods.IsPhoneVerified).As<bool>();
    }
    
    public static bool IsTwoFactorEnabled()
    {
        return GetInstance().Call(Methods.IsTwoFactorEnabled).As<bool>();
    }
    
    public static bool LoggedOn()
    {
        return GetInstance().Call(Methods.LoggedOn).As<bool>();
    }
    
    public static void RequestEncryptedAppTicket(string secret)
    {
        GetInstance().Call(Methods.RequestEncryptedAppTicket, secret);
    }
    
    public static void RequestStoreAuthURL(string redirect)
    {
        GetInstance().Call(Methods.RequestStoreAuthURL, redirect);
    }
    
    public static void StartVoiceRecording()
    {
        GetInstance().Call(Methods.StartVoiceRecording);
    }
    
    public static bool SetDurationControlOnlineState(long newState)
    {
        return GetInstance().Call(Methods.SetDurationControlOnlineState, newState).As<bool>();
    }
    
    public static void StopVoiceRecording()
    {
        GetInstance().Call(Methods.StopVoiceRecording);
    }
    
    public static void TerminateGameConnection(uint serverIP, long serverPort)
    {
        GetInstance().Call(Methods.TerminateGameConnection, serverIP, serverPort);
    }
    
    public static int UserHasLicenseForApp(ulong steamId, uint appId)
    {
        return GetInstance().Call(Methods.UserHasLicenseForApp, steamId, appId).As<int>();
    }
    
    public static ulong GetSteamID()
    {
        return GetInstance().Call(Methods.GetSteamID).As<ulong>();
    }
    
    public static int GetPlayerSteamLevel()
    {
        return GetInstance().Call(Methods.GetPlayerSteamLevel).As<int>();
    }

    public enum DurationControlProgress : long
    {
        ProgressFull = 0,
        ProgressHalf = 1,
        ProgressNone = 2,
        ExitSoon3H = 3,
        ExitSoon5H = 4,
        ExitSoonNight = 5
    }

    public enum DurationControlNotification : long
    {
        None = 0,
        Notification1Hour = 1,
        Notification3Hours = 2,
        HalfProgress = 3,
        NoProgress = 4,
        ExitSoon3H = 5,
        ExitSoon5H = 6,
        ExitSoonNight = 7
    }
}