namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Filters the text using the specified context
    /// </summary>
    /// <param name="context">The context</param>
    /// <param name="steamId">The steam id</param>
    /// <param name="message">The message</param>
    /// <returns>The string</returns>
    public static string FilterText(TextFilteringContext context, ulong steamId, string message)
    {
        return GetInstance().Call(Methods.FilterText, (int)context, steamId, message).AsString();
    }
    
    /// <summary>
    /// Gets the api call failure reason
    /// </summary>
    /// <returns>The string</returns>
    public static string GetAPICallFailureReason()
    {
        return GetInstance().Call(Methods.GetAPICallFailureReason).AsString();
    }
    
    /// <summary>
    /// Gets the app id
    /// </summary>
    /// <returns>The uint</returns>
    public static uint GetAppID()
    {
        return GetInstance().Call(Methods.GetAppID).AsUInt32();
    }
    
    /// <summary>
    /// Gets the current battery power
    /// </summary>
    /// <returns>The int</returns>
    public static int GetCurrentBatteryPower()
    {
        return GetInstance().Call(Methods.GetCurrentBatteryPower).AsInt32();
    }
    
    /// <summary>
    /// Gets the image rgba using the specified image
    /// </summary>
    /// <param name="image">The image</param>
    /// <returns>The image rgba</returns>
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
    
    /// <summary>
    /// Gets the image size using the specified image
    /// </summary>
    /// <param name="image">The image</param>
    /// <returns>The image size</returns>
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
    
    /// <summary>
    /// Gets the ipc call count
    /// </summary>
    /// <returns>The uint</returns>
    public static uint GetIPCCallCount()
    {
        return GetInstance().Call(Methods.GetIPCCallCount).AsUInt32();
    }
    
    /// <summary>
    /// Gets the ip country
    /// </summary>
    /// <returns>The string</returns>
    public static string GetIPCountry()
    {
        return GetInstance().Call(Methods.GetIPCountry).AsString();
    }
    
    /// <summary>
    /// Gets the seconds since app active
    /// </summary>
    /// <returns>The int</returns>
    public static int GetSecondsSinceAppActive()
    {
        return GetInstance().Call(Methods.GetSecondsSinceAppActive).AsInt32();
    }
    
    /// <summary>
    /// Gets the seconds since computer active
    /// </summary>
    /// <returns>The int</returns>
    public static int GetSecondsSinceComputerActive()
    {
        return GetInstance().Call(Methods.GetSecondsSinceComputerActive).AsInt32();
    }
    
    /// <summary>
    /// Gets the server real time
    /// </summary>
    /// <returns>The int</returns>
    public static int GetServerRealTime()
    {
        return GetInstance().Call(Methods.GetServerRealTime).AsInt32();
    }
    
    /// <summary>
    /// Gets the steam ui language
    /// </summary>
    /// <returns>The string</returns>
    public static string GetSteamUILanguage()
    {
        return GetInstance().Call(Methods.GetSteamUILanguage).AsString();
    }
    
    /// <summary>
    /// Describes whether init filter text
    /// </summary>
    /// <returns>The bool</returns>
    public static bool InitFilterText()
    {
        return GetInstance().Call(Methods.InitFilterText).AsBool();
    }
    
    /// <summary>
    /// Ises the api call completed
    /// </summary>
    /// <returns>The api call result</returns>
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
    
    /// <summary>
    /// Describes whether is overlay enabled
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsOverlayEnabled()
    {
        return GetInstance().Call(Methods.IsOverlayEnabled).AsBool();
    }
    
    /// <summary>
    /// Describes whether is steam china launcher
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsSteamChinaLauncher()
    {
        return GetInstance().Call(Methods.IsSteamChinaLauncher).AsBool();
    }
    
    /// <summary>
    /// Describes whether is steam in big picture mode
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsSteamInBigPictureMode()
    {
        return GetInstance().Call(Methods.IsSteamInBigPictureMode).AsBool();
    }
    
    /// <summary>
    /// Describes whether is steam running in vr
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsSteamRunningInVR()
    {
        return GetInstance().Call(Methods.IsSteamRunningInVR).AsBool();
    }
    
    /// <summary>
    /// Describes whether is vr headset streaming enabled
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsVRHeadsetStreamingEnabled()
    {
        return GetInstance().Call(Methods.IsVRHeadsetStreamingEnabled).AsBool();
    }
    
    /// <summary>
    /// Describes whether overlay needs present
    /// </summary>
    /// <returns>The bool</returns>
    public static bool OverlayNeedsPresent()
    {
        return GetInstance().Call(Methods.OverlayNeedsPresent).AsBool();
    }
    
    /// <summary>
    /// Sets the overlay notification inset using the specified horizontal
    /// </summary>
    /// <param name="horizontal">The horizontal</param>
    /// <param name="vertical">The vertical</param>
    public static void SetOverlayNotificationInset(int horizontal, int vertical)
    {
        GetInstance().Call(Methods.SetOverlayNotificationInset, horizontal, vertical);
    }
    
    /// <summary>
    /// Sets the overlay notification position using the specified pos
    /// </summary>
    /// <param name="pos">The pos</param>
    public static void SetOverlayNotificationPosition(OverlayNotificationPosition pos)
    {
        GetInstance().Call(Methods.SetOverlayNotificationPosition, (int)pos);
    }
    
    /// <summary>
    /// Sets the vr headset streaming enabled using the specified enabled
    /// </summary>
    /// <param name="enabled">The enabled</param>
    public static void SetVRHeadsetStreamingEnabled(bool enabled)
    {
        GetInstance().Call(Methods.SetVRHeadsetStreamingEnabled, enabled);
    }
    
    /// <summary>
    /// Describes whether show gamepad text input
    /// </summary>
    /// <param name="inputMode">The input mode</param>
    /// <param name="lineInputMode">The line input mode</param>
    /// <param name="description">The description</param>
    /// <param name="maxText">The max text</param>
    /// <param name="presetText">The preset text</param>
    /// <returns>The bool</returns>
    public static bool ShowGamepadTextInput(GamepadTextInputMode inputMode, GamepadTextInputLineMode lineInputMode, string description, uint maxText, string presetText)
    {
        return GetInstance().Call(Methods.ShowGamepadTextInput, (int)inputMode, (int)lineInputMode, description, maxText, presetText).AsBool();
    }
    
    /// <summary>
    /// Describes whether show floating gamepad text input
    /// </summary>
    /// <param name="inputMode">The input mode</param>
    /// <param name="textFieldXPosition">The text field position</param>
    /// <param name="textFieldYPosition">The text field position</param>
    /// <param name="textFieldWidth">The text field width</param>
    /// <param name="textFieldHeight">The text field height</param>
    /// <returns>The bool</returns>
    public static bool ShowFloatingGamepadTextInput(FloatingGamepadTextInputMode inputMode, int textFieldXPosition, int textFieldYPosition, int textFieldWidth, int textFieldHeight)
    {
        return GetInstance().Call(Methods.ShowFloatingGamepadTextInput, (long)inputMode, textFieldXPosition, textFieldYPosition, textFieldWidth, textFieldHeight).AsBool();
    }
    
    /// <summary>
    /// Sets the game launcher mode using the specified mode
    /// </summary>
    /// <param name="mode">The mode</param>
    public static void SetGameLauncherMode(bool mode)
    {
        GetInstance().Call(Methods.SetGameLauncherMode, mode);
    }
    
    /// <summary>
    /// Starts the vr dashboard
    /// </summary>
    public static void StartVRDashboard()
    {
        GetInstance().Call(Methods.StartVRDashboard);
    }
    
    /// <summary>
    /// Describes whether is steam running on steam deck
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsSteamRunningOnSteamDeck()
    {
        return GetInstance().Call(Methods.IsSteamRunningOnSteamDeck).AsBool();
    }
    
    /// <summary>
    /// Describes whether dismiss floating gamepad text input
    /// </summary>
    /// <returns>The bool</returns>
    public static bool DismissFloatingGamepadTextInput()
    {
        return GetInstance().Call(Methods.DismissFloatingGamepadTextInput).AsBool();
    }

    /// <summary>
    /// The api call failure enum
    /// </summary>
    public enum ApiCallFailure : long
    {
        /// <summary>
        /// The none api call failure
        /// </summary>
        None = -1,
        /// <summary>
        /// The steam gone api call failure
        /// </summary>
        SteamGone = 0,
        /// <summary>
        /// The network failure api call failure
        /// </summary>
        NetworkFailure = 1,
        /// <summary>
        /// The invalid handle api call failure
        /// </summary>
        InvalidHandle = 2,
        /// <summary>
        /// The mismatched callback api call failure
        /// </summary>
        MismatchedCallback = 3
    }

    /// <summary>
    /// The check file signature enum enum
    /// </summary>
    public enum CheckFileSignatureEnum : long
    {
        /// <summary>
        /// The invalid signature check file signature enum
        /// </summary>
        InvalidSignature = 0,
        /// <summary>
        /// The valid signature check file signature enum
        /// </summary>
        ValidSignature = 1,
        /// <summary>
        /// The file not found check file signature enum
        /// </summary>
        FileNotFound = 2,
        /// <summary>
        /// The no signatures found for this app check file signature enum
        /// </summary>
        NoSignaturesFoundForThisApp = 3,
        /// <summary>
        /// The no signatures found for this file check file signature enum
        /// </summary>
        NoSignaturesFoundForThisFile = 4
    }
}