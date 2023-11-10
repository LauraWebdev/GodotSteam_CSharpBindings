namespace GodotSteam;

public static partial class Steam
{
    public static string FilterText(TextFilteringContext context, ulong steamId, string message)
    {
        return GetInstance().Call(Methods.FilterText, (long)context, steamId, message).AsString();
    }
    
    public static string GetAPICallFailureReason()
    {
        return GetInstance().Call(Methods.GetAPICallFailureReason).AsString();
    }
    
    public static long GetAppID()
    {
        return GetInstance().Call(Methods.GetAppID).AsInt64();
    }
    
    public static long GetCurrentBatteryPower()
    {
        return GetInstance().Call(Methods.GetCurrentBatteryPower).AsInt64();
    }
    
    public static Godot.Collections.Dictionary GetImageRGBA(long image)
    {
        return GetInstance().Call(Methods.GetImageRGBA, image).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetImageSize(long image)
    {
        return GetInstance().Call(Methods.GetImageSize, image).AsGodotDictionary();
    }
    
    public static long GetIPCCallCount()
    {
        return GetInstance().Call(Methods.GetIPCCallCount).AsInt64();
    }
    
    public static string GetIPCountry()
    {
        return GetInstance().Call(Methods.GetIPCountry).AsString();
    }
    
    public static long GetSecondsSinceAppActive()
    {
        return GetInstance().Call(Methods.GetSecondsSinceAppActive).AsInt64();
    }
    
    public static long GetSecondsSinceComputerActive()
    {
        return GetInstance().Call(Methods.GetSecondsSinceComputerActive).AsInt64();
    }
    
    public static long GetServerRealTime()
    {
        return GetInstance().Call(Methods.GetServerRealTime).AsInt64();
    }
    
    public static string GetSteamUILanguage()
    {
        return GetInstance().Call(Methods.GetSteamUILanguage).AsString();
    }
    
    public static bool InitFilterText()
    {
        return GetInstance().Call(Methods.InitFilterText).AsBool();
    }
    
    public static Godot.Collections.Dictionary IsAPICallCompleted()
    {
        return GetInstance().Call(Methods.IsAPICallCompleted).AsGodotDictionary();
    }
    
    public static bool IsOverlayEnabled()
    {
        return GetInstance().Call(Methods.IsOverlayEnabled).AsBool();
    }
    
    public static bool IsSteamChinaLauncher()
    {
        return GetInstance().Call(Methods.IsSteamChinaLauncher).AsBool();
    }
    
    public static bool IsSteamInBigPictureMode()
    {
        return GetInstance().Call(Methods.IsSteamInBigPictureMode).AsBool();
    }
    
    public static bool IsSteamRunningInVR()
    {
        return GetInstance().Call(Methods.IsSteamRunningInVR).AsBool();
    }
    
    public static bool IsVRHeadsetStreamingEnabled()
    {
        return GetInstance().Call(Methods.IsVRHeadsetStreamingEnabled).AsBool();
    }
    
    public static bool OverlayNeedsPresent()
    {
        return GetInstance().Call(Methods.OverlayNeedsPresent).AsBool();
    }
    
    public static void SetOverlayNotificationInset(int horizontal, long vertical)
    {
        GetInstance().Call(Methods.SetOverlayNotificationInset, horizontal, vertical);
    }
    
    public static void SetOverlayNotificationPosition(long pos)
    {
        GetInstance().Call(Methods.SetOverlayNotificationPosition, pos);
    }
    
    public static void SetVRHeadsetStreamingEnabled(bool enabled)
    {
        GetInstance().Call(Methods.SetVRHeadsetStreamingEnabled, enabled);
    }
    
    public static bool ShowGamepadTextInput(GamepadTextInputMode inputMode, GamepadTextInputLineMode lineInputMode, string description, uint maxText, string presetText)
    {
        return GetInstance().Call(Methods.ShowGamepadTextInput, (long)inputMode, (long)lineInputMode, description, maxText, presetText).AsBool();
    }
    
    public static bool ShowFloatingGamepadTextInput(FloatingGamepadTextInputMode inputMode, int textFieldXPosition, int textFieldYPosition, int textFieldWidth, long textFieldHeight)
    {
        return GetInstance().Call(Methods.ShowFloatingGamepadTextInput, (long)inputMode, textFieldXPosition, textFieldYPosition, textFieldWidth, textFieldHeight).AsBool();
    }
    
    public static void SetGameLauncherMode(bool mode)
    {
        GetInstance().Call(Methods.SetGameLauncherMode, mode);
    }
    
    public static void StartVRDashboard()
    {
        GetInstance().Call(Methods.StartVRDashboard);
    }
    
    public static bool IsSteamRunningOnSteamDeck()
    {
        return GetInstance().Call(Methods.IsSteamRunningOnSteamDeck).AsBool();
    }
    
    public static bool DismissFloatingGamepadTextInput()
    {
        return GetInstance().Call(Methods.DismissFloatingGamepadTextInput).AsBool();
    }

    public enum ApiCallFailure : long
    {
        None = -1,
        SteamGone = 0,
        NetworkFailure = 1,
        InvalidHandle = 2,
        MismatchedCallback = 3
    }

    public enum CheckFileSignatureEnum : long
    {
        InvalidSignature = 0,
        ValidSignature = 1,
        FileNotFound = 2,
        NoSignaturesFoundForThisApp = 3,
        NoSignaturesFoundForThisFile = 4
    }

    public enum TextFilteringContext : long
    {
        Unknown = 0,
        GameContent = 1,
        Chat = 2,
        Name = 3
    }

    public enum FloatingGamepadTextInputMode : long
    {
        SingleLine = 0,
        MultipleLines = 1,
        Email = 2,
        Numeric = 3
    }

    public enum GamepadTextInputLineMode : long
    {
        SingleLine = 0,
        MultipleLines = 1
    }

    public enum GamepadTextInputMode : long
    {
        Normal = 0,
        Password = 1
    }
}