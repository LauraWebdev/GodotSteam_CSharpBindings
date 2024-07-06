namespace GodotSteam;

public static partial class Steam
{
    public static string FilterText(TextFilteringContext context, ulong steamId, string message)
    {
        return GetInstance().Call(Methods.FilterText, (int)context, steamId, message).As<string>();
    }
    
    public static string GetAPICallFailureReason()
    {
        return GetInstance().Call(Methods.GetAPICallFailureReason).As<string>();
    }
    
    public static uint GetAppID()
    {
        return GetInstance().Call(Methods.GetAppID).As<uint>();
    }
    
    public static int GetCurrentBatteryPower()
    {
        return GetInstance().Call(Methods.GetCurrentBatteryPower).As<int>();
    }
    
    public static ImageRGBA GetImageRGBA(int image)
    {
        var raw = GetInstance().Call(Methods.GetImageRGBA, image).AsGodotDictionary();

        if (!raw.ContainsKey("buffer") || !raw.ContainsKey("success"))
        {
            return null;
        }

        return new ImageRGBA
        {
            Buffer = raw["buffer"].AsByteArray(),
            Success = raw["success"].As<bool>(),
        };
    }
    
    public static ImageSize GetImageSize(int image)
    {
        var raw = GetInstance().Call(Methods.GetImageSize, image).AsGodotDictionary();
        
        if (!raw.ContainsKey("width") || !raw.ContainsKey("height"))
        {
            return null;
        }

        return new ImageSize
        {
            Width = raw["width"].As<uint>(),
            Height = raw["height"].As<uint>(),
        };
    }
    
    public static uint GetIPCCallCount()
    {
        return GetInstance().Call(Methods.GetIPCCallCount).As<uint>();
    }
    
    public static string GetIPCountry()
    {
        return GetInstance().Call(Methods.GetIPCountry).As<string>();
    }
    
    public static int GetSecondsSinceAppActive()
    {
        return GetInstance().Call(Methods.GetSecondsSinceAppActive).As<int>();
    }
    
    public static int GetSecondsSinceComputerActive()
    {
        return GetInstance().Call(Methods.GetSecondsSinceComputerActive).As<int>();
    }
    
    public static int GetServerRealTime()
    {
        return GetInstance().Call(Methods.GetServerRealTime).As<int>();
    }
    
    public static string GetSteamUILanguage()
    {
        return GetInstance().Call(Methods.GetSteamUILanguage).As<string>();
    }
    
    public static bool InitFilterText()
    {
        return GetInstance().Call(Methods.InitFilterText).As<bool>();
    }
    
    public static ApiCallResult IsAPICallCompleted()
    {
        var raw = GetInstance().Call(Methods.IsAPICallCompleted).AsGodotDictionary();

        if (!raw.ContainsKey("completed") || !raw.ContainsKey("failed"))
        {
            return null;
        }

        return new ApiCallResult
        {
            Completed = raw["completed"].As<bool>(),
            Failed = raw["failed"].As<bool>(),
        };
    }
    
    public static bool IsOverlayEnabled()
    {
        return GetInstance().Call(Methods.IsOverlayEnabled).As<bool>();
    }
    
    public static bool IsSteamChinaLauncher()
    {
        return GetInstance().Call(Methods.IsSteamChinaLauncher).As<bool>();
    }
    
    public static bool IsSteamInBigPictureMode()
    {
        return GetInstance().Call(Methods.IsSteamInBigPictureMode).As<bool>();
    }
    
    public static bool IsSteamRunningInVR()
    {
        return GetInstance().Call(Methods.IsSteamRunningInVR).As<bool>();
    }
    
    public static bool IsVRHeadsetStreamingEnabled()
    {
        return GetInstance().Call(Methods.IsVRHeadsetStreamingEnabled).As<bool>();
    }
    
    public static bool OverlayNeedsPresent()
    {
        return GetInstance().Call(Methods.OverlayNeedsPresent).As<bool>();
    }
    
    public static void SetOverlayNotificationInset(int horizontal, int vertical)
    {
        GetInstance().Call(Methods.SetOverlayNotificationInset, horizontal, vertical);
    }
    
    public static void SetOverlayNotificationPosition(OverlayNotificationPosition pos)
    {
        GetInstance().Call(Methods.SetOverlayNotificationPosition, (int)pos);
    }
    
    public static void SetVRHeadsetStreamingEnabled(bool enabled)
    {
        GetInstance().Call(Methods.SetVRHeadsetStreamingEnabled, enabled);
    }
    
    public static bool ShowGamepadTextInput(GamepadTextInputMode inputMode, GamepadTextInputLineMode lineInputMode, string description, uint maxText, string presetText)
    {
        return GetInstance().Call(Methods.ShowGamepadTextInput, (int)inputMode, (int)lineInputMode, description, maxText, presetText).As<bool>();
    }
    
    public static bool ShowFloatingGamepadTextInput(FloatingGamepadTextInputMode inputMode, int textFieldXPosition, int textFieldYPosition, int textFieldWidth, int textFieldHeight)
    {
        return GetInstance().Call(Methods.ShowFloatingGamepadTextInput, (long)inputMode, textFieldXPosition, textFieldYPosition, textFieldWidth, textFieldHeight).As<bool>();
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
        return GetInstance().Call(Methods.IsSteamRunningOnSteamDeck).As<bool>();
    }
    
    public static bool DismissFloatingGamepadTextInput()
    {
        return GetInstance().Call(Methods.DismissFloatingGamepadTextInput).As<bool>();
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
}