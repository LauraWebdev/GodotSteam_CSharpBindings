namespace GodotSteam;

public static partial class Steam
{
    public static string FilterText(TextFilteringContext context, ulong steamId, string message)
    {
        return GetInstance().Call(Methods.FilterText, (int)context, steamId, message).AsString();
    }
    
    public static string GetAPICallFailureReason()
    {
        return GetInstance().Call(Methods.GetAPICallFailureReason).AsString();
    }
    
    public static uint GetAppID()
    {
        return GetInstance().Call(Methods.GetAppID).AsUInt32();
    }
    
    public static int GetCurrentBatteryPower()
    {
        return GetInstance().Call(Methods.GetCurrentBatteryPower).AsInt32();
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
            Success = raw["success"].AsBool(),
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
            Width = raw["width"].AsUInt32(),
            Height = raw["height"].AsUInt32(),
        };
    }
    
    public static uint GetIPCCallCount()
    {
        return GetInstance().Call(Methods.GetIPCCallCount).AsUInt32();
    }
    
    public static string GetIPCountry()
    {
        return GetInstance().Call(Methods.GetIPCountry).AsString();
    }
    
    public static int GetSecondsSinceAppActive()
    {
        return GetInstance().Call(Methods.GetSecondsSinceAppActive).AsInt32();
    }
    
    public static int GetSecondsSinceComputerActive()
    {
        return GetInstance().Call(Methods.GetSecondsSinceComputerActive).AsInt32();
    }
    
    public static int GetServerRealTime()
    {
        return GetInstance().Call(Methods.GetServerRealTime).AsInt32();
    }
    
    public static string GetSteamUILanguage()
    {
        return GetInstance().Call(Methods.GetSteamUILanguage).AsString();
    }
    
    public static bool InitFilterText()
    {
        return GetInstance().Call(Methods.InitFilterText).AsBool();
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
            Completed = raw["completed"].AsBool(),
            Failed = raw["failed"].AsBool(),
        };
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
        return GetInstance().Call(Methods.ShowGamepadTextInput, (int)inputMode, (int)lineInputMode, description, maxText, presetText).AsBool();
    }
    
    public static bool ShowFloatingGamepadTextInput(FloatingGamepadTextInputMode inputMode, int textFieldXPosition, int textFieldYPosition, int textFieldWidth, int textFieldHeight)
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
}