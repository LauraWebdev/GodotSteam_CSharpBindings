namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Activates the action set using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="actionSetHandle">The action set handle</param>
    public static void ActivateActionSet(ulong inputHandle, long actionSetHandle)
    {
        GetInstance().Call(Methods.ActivateActionSet, inputHandle, actionSetHandle);
    }
    
    /// <summary>
    /// Activates the action set layer using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="actionSetLayerHandle">The action set layer handle</param>
    public static void ActivateActionSetLayer(ulong inputHandle, long actionSetLayerHandle)
    {
        GetInstance().Call(Methods.ActivateActionSetLayer, inputHandle, actionSetLayerHandle);
    }
    
    /// <summary>
    /// Deactivates the action set layer using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="actionSetHandle">The action set handle</param>
    public static void DeactivateActionSetLayer(ulong inputHandle, long actionSetHandle)
    {
        GetInstance().Call(Methods.DeactivateActionSetLayer, inputHandle, actionSetHandle);
    }
    
    /// <summary>
    /// Deactivates the all action set layers using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    public static void DeactivateAllActionSetLayers(long inputHandle)
    {
        GetInstance().Call(Methods.DeactivateAllActionSetLayers, inputHandle);
    }
    
    /// <summary>
    /// Gets the action set handle using the specified action set name
    /// </summary>
    /// <param name="actionSetName">The action set name</param>
    /// <returns>The ulong</returns>
    public static ulong GetActionSetHandle(string actionSetName)
    {
        return GetInstance().Call(Methods.GetActionSetHandle, actionSetName).AsUInt64();
    }
    
    /// <summary>
    /// Gets the action origin from xbox origin using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="origin">The origin</param>
    /// <returns>The input action origin</returns>
    public static InputActionOrigin GetActionOriginFromXboxOrigin(ulong inputHandle, long origin)
    {
        return (InputActionOrigin)GetInstance().Call(Methods.GetActionOriginFromXboxOrigin, inputHandle, origin).AsInt64();
    }
    
    /// <summary>
    /// Gets the active action set layers using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetActiveActionSetLayers(long inputHandle)
    {
        return GetInstance().Call(Methods.GetActiveActionSetLayers, inputHandle).AsGodotArray();
    }
    
    /// <summary>
    /// Gets the analog action data using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="analogActionHandle">The analog action handle</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetAnalogActionData(ulong inputHandle, long analogActionHandle)
    {
        return GetInstance().Call(Methods.GetAnalogActionData, inputHandle, analogActionHandle).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the analog action handle using the specified action name
    /// </summary>
    /// <param name="actionName">The action name</param>
    /// <returns>The ulong</returns>
    public static ulong GetAnalogActionHandle(string actionName)
    {
        return GetInstance().Call(Methods.GetAnalogActionHandle, actionName).AsUInt16();
    }
    
    /// <summary>
    /// Gets the analog action origins using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="actionSetHandle">The action set handle</param>
    /// <param name="analogActionHandle">The analog action handle</param>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetAnalogActionOrigins(ulong inputHandle, ulong actionSetHandle, long analogActionHandle)
    {
        return GetInstance().Call(Methods.GetAnalogActionOrigins, inputHandle, actionSetHandle, analogActionHandle).AsGodotArray();
    }
    
    /// <summary>
    /// Gets the connected controllers
    /// </summary>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetConnectedControllers()
    {
        return GetInstance().Call(Methods.GetConnectedControllers).AsGodotArray();
    }
    
    /// <summary>
    /// Gets the controller for gamepad index using the specified index
    /// </summary>
    /// <param name="index">The index</param>
    /// <returns>The ulong</returns>
    public static ulong GetControllerForGamepadIndex(long index)
    {
        return GetInstance().Call(Methods.GetControllerForGamepadIndex, index).AsUInt16();
    }
    
    /// <summary>
    /// Gets the current action set using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <returns>The ulong</returns>
    public static ulong GetCurrentActionSet(long inputHandle)
    {
        return GetInstance().Call(Methods.GetCurrentActionSet, inputHandle).AsUInt16();
    }
    
    /// <summary>
    /// Gets the device binding revision using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetDeviceBindingRevision(long inputHandle)
    {
        return GetInstance().Call(Methods.GetDeviceBindingRevision, inputHandle).AsGodotArray();
    }
    
    /// <summary>
    /// Gets the digital action data using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="digitalActionHandle">The digital action handle</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetDigitalActionData(ulong inputHandle, long digitalActionHandle)
    {
        return GetInstance().Call(Methods.GetDigitalActionData, inputHandle, digitalActionHandle).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the digital action handle using the specified action name
    /// </summary>
    /// <param name="actionName">The action name</param>
    /// <returns>The ulong</returns>
    public static ulong GetDigitalActionHandle(string actionName)
    {
        return GetInstance().Call(Methods.GetDigitalActionHandle, actionName).AsUInt64();
    }
    
    /// <summary>
    /// Gets the digital action origins using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="actionSetHandle">The action set handle</param>
    /// <param name="digitalActionHandle">The digital action handle</param>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetDigitalActionOrigins(ulong inputHandle, ulong actionSetHandle, long digitalActionHandle)
    {
        return GetInstance().Call(Methods.GetDigitalActionOrigins, inputHandle, actionSetHandle, digitalActionHandle).AsGodotArray();
    }
    
    /// <summary>
    /// Gets the gamepad index for controller using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <returns>The int</returns>
    public static int GetGamepadIndexForController(long inputHandle)
    {
        return GetInstance().Call(Methods.GetGamepadIndexForController, inputHandle).AsInt32();
    }
    
    /// <summary>
    /// Gets the glyph for action origin using the specified origin
    /// </summary>
    /// <param name="origin">The origin</param>
    /// <returns>The string</returns>
    public static string GetGlyphForActionOrigin(InputActionOrigin origin)
    {
        return GetInstance().Call(Methods.GetGlyphForActionOrigin, (long)origin).AsString();
    }
    
    /// <summary>
    /// Gets the input type for handle using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <returns>The string</returns>
    public static string GetInputTypeForHandle(long inputHandle)
    {
        return GetInstance().Call(Methods.GetInputTypeForHandle, inputHandle).AsString();
    }
    
    /// <summary>
    /// Gets the motion data using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetMotionData(long inputHandle)
    {
        return GetInstance().Call(Methods.GetMotionData, inputHandle).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the remote play session id using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <returns>The int</returns>
    public static int GetRemotePlaySessionID(long inputHandle)
    {
        return GetInstance().Call(Methods.GetRemotePlaySessionID, inputHandle).AsInt32();
    }
    
    /// <summary>
    /// Gets the string for action origin using the specified origin
    /// </summary>
    /// <param name="origin">The origin</param>
    /// <returns>The string</returns>
    public static string GetStringForActionOrigin(InputActionOrigin origin)
    {
        return GetInstance().Call(Methods.GetStringForActionOrigin, (long)origin).AsString();
    }
    
    /// <summary>
    /// Describes whether input init
    /// </summary>
    /// <param name="explicitlyCallRunframe">The explicitly call runframe</param>
    /// <returns>The bool</returns>
    public static bool InputInit(bool explicitlyCallRunframe = false)
    {
        return GetInstance().Call(Methods.InputInit, explicitlyCallRunframe).AsBool();
    }
    
    /// <summary>
    /// Describes whether input shutdown
    /// </summary>
    /// <returns>The bool</returns>
    public static bool InputShutdown()
    {
        return GetInstance().Call(Methods.InputShutdown).AsBool();
    }
    
    /// <summary>
    /// Runs the frame using the specified reserved value
    /// </summary>
    /// <param name="reservedValue">The reserved value</param>
    public static void RunFrame(bool reservedValue = true)
    {
        GetInstance().Call(Methods.RunFrame, reservedValue);
    }
    
    /// <summary>
    /// Sets the led color using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="colorR">The color</param>
    /// <param name="colorG">The color</param>
    /// <param name="colorB">The color</param>
    /// <param name="flags">The flags</param>
    public static void SetLEDColor(ulong inputHandle, int colorR, int colorG, int colorB, long flags)
    {
        GetInstance().Call(Methods.SetLEDColor, inputHandle, colorR, colorG, colorB, flags);
    }
    
    /// <summary>
    /// Describes whether show binding panel
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <returns>The bool</returns>
    public static bool ShowBindingPanel(long inputHandle)
    {
        return GetInstance().Call(Methods.ShowBindingPanel, inputHandle).AsBool();
    }
    
    /// <summary>
    /// Stops the analog action momentum using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="action">The action</param>
    public static void StopAnalogActionMomentum(ulong inputHandle, long action)
    {
        GetInstance().Call(Methods.StopAnalogActionMomentum, inputHandle, action);
    }
    
    /// <summary>
    /// Translates the action origin using the specified destination input
    /// </summary>
    /// <param name="destinationInput">The destination input</param>
    /// <param name="sourceOrigin">The source origin</param>
    /// <returns>The int</returns>
    public static int TranslateActionOrigin(InputType destinationInput, InputActionOrigin sourceOrigin)
    {
        return GetInstance().Call(Methods.TranslateActionOrigin, (long)destinationInput, (long)sourceOrigin).AsInt32();
    }
    
    /// <summary>
    /// Triggers the haptic pulse using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="targetPad">The target pad</param>
    /// <param name="duration">The duration</param>
    public static void TriggerHapticPulse(ulong inputHandle, int targetPad, long duration)
    {
        GetInstance().Call(Methods.TriggerHapticPulse, inputHandle, targetPad, duration);
    }
    
    /// <summary>
    /// Triggers the repeated haptic pulse using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="targetPad">The target pad</param>
    /// <param name="duration">The duration</param>
    /// <param name="offset">The offset</param>
    /// <param name="repeat">The repeat</param>
    /// <param name="flags">The flags</param>
    public static void TriggerRepeatedHapticPulse(ulong inputHandle, int targetPad, int duration, int offset, int repeat, long flags)
    {
        GetInstance().Call(Methods.TriggerRepeatedHapticPulse, inputHandle, targetPad, duration, offset, repeat, flags);
    }
    
    /// <summary>
    /// Triggers the vibration using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="leftSpeed">The left speed</param>
    /// <param name="rightSpeed">The right speed</param>
    public static void TriggerVibration(ulong inputHandle, int leftSpeed, long rightSpeed)
    {
        GetInstance().Call(Methods.TriggerVibration, inputHandle, leftSpeed, rightSpeed);
    }
    
    /// <summary>
    /// Describes whether set input action manifest file path
    /// </summary>
    /// <param name="manifestPath">The manifest path</param>
    /// <returns>The bool</returns>
    public static bool SetInputActionManifestFilePath(string manifestPath)
    {
        return GetInstance().Call(Methods.SetInputActionManifestFilePath, manifestPath).AsBool();
    }
    
    /// <summary>
    /// Sets the dual sense trigger effect using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="parameters">The parameters</param>
    /// <param name="triggerMask">The trigger mask</param>
    /// <param name="effectMode">The effect mode</param>
    /// <param name="position">The position</param>
    /// <param name="amplitude">The amplitude</param>
    /// <param name="frequency">The frequency</param>
    public static void SetDualSenseTriggerEffect(ulong inputHandle, int parameters, int triggerMask, ScePadTriggerEffectMode effectMode, int position, int amplitude, long frequency)
    {
        GetInstance().Call(Methods.SetDualSenseTriggerEffect, inputHandle, parameters, triggerMask, (long)effectMode, position, amplitude, frequency);
    }
    
    /// <summary>
    /// Describes whether wait for data
    /// </summary>
    /// <param name="waitForever">The wait forever</param>
    /// <param name="timeout">The timeout</param>
    /// <returns>The bool</returns>
    public static bool WaitForData(bool waitForever, long timeout)
    {
        return GetInstance().Call(Methods.WaitForData, waitForever, timeout).AsBool();
    }
    
    /// <summary>
    /// Describes whether new data available
    /// </summary>
    /// <returns>The bool</returns>
    public static bool NewDataAvailable()
    {
        return GetInstance().Call(Methods.NewDataAvailable).AsBool();
    }
    
    /// <summary>
    /// Enables the device callbacks
    /// </summary>
    public static void EnableDeviceCallbacks()
    {
        GetInstance().Call(Methods.EnableDeviceCallbacks);
    }
    
    /// <summary>
    /// Gets the glyph png for action origin using the specified origin
    /// </summary>
    /// <param name="origin">The origin</param>
    /// <param name="size">The size</param>
    /// <param name="flags">The flags</param>
    /// <returns>The string</returns>
    public static string GetGlyphPNGForActionOrigin(InputActionOrigin origin, InputGlyphSize size, long flags)
    {
        return GetInstance().Call(Methods.GetGlyphPNGForActionOrigin, (long)origin, (long)size, flags).AsString();
    }
    
    /// <summary>
    /// Gets the glyph svg for action origin using the specified origin
    /// </summary>
    /// <param name="origin">The origin</param>
    /// <param name="flags">The flags</param>
    /// <returns>The string</returns>
    public static string GetGlyphSVGForActionOrigin(InputActionOrigin origin, long flags)
    {
        return GetInstance().Call(Methods.GetGlyphSVGForActionOrigin, (long)origin, flags).AsString();
    }
    
    /// <summary>
    /// Triggers the vibration extended using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="leftSpeed">The left speed</param>
    /// <param name="rightSpeed">The right speed</param>
    /// <param name="leftTriggerSpeed">The left trigger speed</param>
    /// <param name="rightTriggerSpeed">The right trigger speed</param>
    public static void TriggerVibrationExtended(ulong inputHandle, int leftSpeed, int rightSpeed, int leftTriggerSpeed, long rightTriggerSpeed)
    {
        GetInstance().Call(Methods.TriggerVibrationExtended, inputHandle, leftSpeed, rightSpeed, leftTriggerSpeed, rightTriggerSpeed);
    }
    
    /// <summary>
    /// Triggers the simple haptic event using the specified input handle
    /// </summary>
    /// <param name="inputHandle">The input handle</param>
    /// <param name="hapticLocation">The haptic location</param>
    /// <param name="intensity">The intensity</param>
    /// <param name="gainDb">The gain db</param>
    /// <param name="otherIntensity">The other intensity</param>
    /// <param name="otherGainDb">The other gain db</param>
    public static void TriggerSimpleHapticEvent(ulong inputHandle, int hapticLocation, int intensity, string gainDb, int otherIntensity, string otherGainDb)
    {
        GetInstance().Call(Methods.TriggerSimpleHapticEvent, inputHandle, hapticLocation, intensity, gainDb, otherIntensity, otherGainDb);
    }
    
    /// <summary>
    /// Gets the string for xbox origin using the specified origin
    /// </summary>
    /// <param name="origin">The origin</param>
    /// <returns>The string</returns>
    public static string GetStringForXboxOrigin(long origin)
    {
        return GetInstance().Call(Methods.GetStringForXboxOrigin, origin).AsString();
    }
    
    /// <summary>
    /// Gets the glyph for xbox origin using the specified origin
    /// </summary>
    /// <param name="origin">The origin</param>
    /// <returns>The string</returns>
    public static string GetGlyphForXboxOrigin(long origin)
    {
        return GetInstance().Call(Methods.GetGlyphForXboxOrigin, origin).AsString();
    }
    
    /// <summary>
    /// Gets the session input configuration settings
    /// </summary>
    /// <returns>The long</returns>
    public static long GetSessionInputConfigurationSettings()
    {
        return GetInstance().Call(Methods.GetSessionInputConfigurationSettings).AsInt64();
    }
    
    /// <summary>
    /// Gets the string for digital action name using the specified action handle
    /// </summary>
    /// <param name="actionHandle">The action handle</param>
    /// <returns>The string</returns>
    public static string GetStringForDigitalActionName(long actionHandle)
    {
        return GetInstance().Call(Methods.GetStringForDigitalActionName, actionHandle).AsString();
    }
    
    /// <summary>
    /// Gets the string for analog action name using the specified action handle
    /// </summary>
    /// <param name="actionHandle">The action handle</param>
    /// <returns>The string</returns>
    public static string GetStringForAnalogActionName(long actionHandle)
    {
        return GetInstance().Call(Methods.GetStringForAnalogActionName, actionHandle).AsString();
    }

    /// <summary>
    /// The input action event type enum
    /// </summary>
    public enum InputActionEventType : long
    {
        /// <summary>
        /// The digital action input action event type
        /// </summary>
        DigitalAction = 0,
        /// <summary>
        /// The analog action input action event type
        /// </summary>
        AnalogAction = 1
    }

    /// <summary>
    /// The input action origin enum
    /// </summary>
    public enum InputActionOrigin : long
    {
        /// <summary>
        /// The none input action origin
        /// </summary>
        None = 0,
        /// <summary>
        /// The steamcontroller input action origin
        /// </summary>
        SteamcontrollerA = 1,
        /// <summary>
        /// The steamcontroller input action origin
        /// </summary>
        SteamcontrollerB = 2,
        /// <summary>
        /// The steamcontroller input action origin
        /// </summary>
        SteamcontrollerX = 3,
        /// <summary>
        /// The steamcontroller input action origin
        /// </summary>
        SteamcontrollerY = 4,
        /// <summary>
        /// The steamcontroller leftbumper input action origin
        /// </summary>
        SteamcontrollerLeftbumper = 5,
        /// <summary>
        /// The steamcontroller rightbumper input action origin
        /// </summary>
        SteamcontrollerRightbumper = 6,
        /// <summary>
        /// The steamcontroller leftgrip input action origin
        /// </summary>
        SteamcontrollerLeftgrip = 7,
        /// <summary>
        /// The steamcontroller rightgrip input action origin
        /// </summary>
        SteamcontrollerRightgrip = 8,
        /// <summary>
        /// The steamcontroller start input action origin
        /// </summary>
        SteamcontrollerStart = 9,
        /// <summary>
        /// The steamcontroller back input action origin
        /// </summary>
        SteamcontrollerBack = 10,
        /// <summary>
        /// The steamcontroller leftpad touch input action origin
        /// </summary>
        SteamcontrollerLeftpadTouch = 11,
        /// <summary>
        /// The steamcontroller leftpad swipe input action origin
        /// </summary>
        SteamcontrollerLeftpadSwipe = 12,
        /// <summary>
        /// The steamcontroller leftpad click input action origin
        /// </summary>
        SteamcontrollerLeftpadClick = 13,
        /// <summary>
        /// The steamcontroller leftpad dpadnorth input action origin
        /// </summary>
        SteamcontrollerLeftpadDpadnorth = 14,
        /// <summary>
        /// The steamcontroller leftpad dpadsouth input action origin
        /// </summary>
        SteamcontrollerLeftpadDpadsouth = 15,
        /// <summary>
        /// The steamcontroller leftpad dpadwest input action origin
        /// </summary>
        SteamcontrollerLeftpadDpadwest = 16,
        /// <summary>
        /// The steamcontroller leftpad dpadeast input action origin
        /// </summary>
        SteamcontrollerLeftpadDpadeast = 17,
        /// <summary>
        /// The steamcontroller rightpad touch input action origin
        /// </summary>
        SteamcontrollerRightpadTouch = 18,
        /// <summary>
        /// The steamcontroller rightpad swipe input action origin
        /// </summary>
        SteamcontrollerRightpadSwipe = 19,
        /// <summary>
        /// The steamcontroller rightpad click input action origin
        /// </summary>
        SteamcontrollerRightpadClick = 20,
        /// <summary>
        /// The steamcontroller rightpad dpadnorth input action origin
        /// </summary>
        SteamcontrollerRightpadDpadnorth = 21,
        /// <summary>
        /// The steamcontroller rightpad dpadsouth input action origin
        /// </summary>
        SteamcontrollerRightpadDpadsouth = 22,
        /// <summary>
        /// The steamcontroller rightpad dpadwest input action origin
        /// </summary>
        SteamcontrollerRightpadDpadwest = 23,
        /// <summary>
        /// The steamcontroller rightpad dpadeast input action origin
        /// </summary>
        SteamcontrollerRightpadDpadeast = 24,
        /// <summary>
        /// The steamcontroller lefttrigger pull input action origin
        /// </summary>
        SteamcontrollerLefttriggerPull = 25,
        /// <summary>
        /// The steamcontroller lefttrigger click input action origin
        /// </summary>
        SteamcontrollerLefttriggerClick = 26,
        /// <summary>
        /// The steamcontroller righttrigger pull input action origin
        /// </summary>
        SteamcontrollerRighttriggerPull = 27,
        /// <summary>
        /// The steamcontroller righttrigger click input action origin
        /// </summary>
        SteamcontrollerRighttriggerClick = 28,
        /// <summary>
        /// The steamcontroller leftstick move input action origin
        /// </summary>
        SteamcontrollerLeftstickMove = 29,
        /// <summary>
        /// The steamcontroller leftstick click input action origin
        /// </summary>
        SteamcontrollerLeftstickClick = 30,
        /// <summary>
        /// The steamcontroller leftstick dpadnorth input action origin
        /// </summary>
        SteamcontrollerLeftstickDpadnorth = 31,
        /// <summary>
        /// The steamcontroller leftstick dpadsouth input action origin
        /// </summary>
        SteamcontrollerLeftstickDpadsouth = 32,
        /// <summary>
        /// The steamcontroller leftstick dpadwest input action origin
        /// </summary>
        SteamcontrollerLeftstickDpadwest = 33,
        /// <summary>
        /// The steamcontroller leftstick dpadeast input action origin
        /// </summary>
        SteamcontrollerLeftstickDpadeast = 34,
        /// <summary>
        /// The steamcontroller gyro move input action origin
        /// </summary>
        SteamcontrollerGyroMove = 35,
        /// <summary>
        /// The steamcontroller gyro pitch input action origin
        /// </summary>
        SteamcontrollerGyroPitch = 36,
        /// <summary>
        /// The steamcontroller gyro yaw input action origin
        /// </summary>
        SteamcontrollerGyroYaw = 37,
        /// <summary>
        /// The steamcontroller gyro roll input action origin
        /// </summary>
        SteamcontrollerGyroRoll = 38,
        /// <summary>
        /// The steamcontroller reserved input action origin
        /// </summary>
        SteamcontrollerReserved0 = 39,
        /// <summary>
        /// The steamcontroller reserved input action origin
        /// </summary>
        SteamcontrollerReserved1 = 40,
        /// <summary>
        /// The steamcontroller reserved input action origin
        /// </summary>
        SteamcontrollerReserved2 = 41,
        /// <summary>
        /// The steamcontroller reserved input action origin
        /// </summary>
        SteamcontrollerReserved3 = 42,
        /// <summary>
        /// The steamcontroller reserved input action origin
        /// </summary>
        SteamcontrollerReserved4 = 43,
        /// <summary>
        /// The steamcontroller reserved input action origin
        /// </summary>
        SteamcontrollerReserved5 = 44,
        /// <summary>
        /// The steamcontroller reserved input action origin
        /// </summary>
        SteamcontrollerReserved6 = 45,
        /// <summary>
        /// The steamcontroller reserved input action origin
        /// </summary>
        SteamcontrollerReserved7 = 46,
        /// <summary>
        /// The steamcontroller reserved input action origin
        /// </summary>
        SteamcontrollerReserved8 = 47,
        /// <summary>
        /// The steamcontroller reserved input action origin
        /// </summary>
        SteamcontrollerReserved9 = 48,
        /// <summary>
        /// The steamcontroller reserved 10 input action origin
        /// </summary>
        SteamcontrollerReserved10 = 49,
        /// <summary>
        /// The ps input action origin
        /// </summary>
        Ps4X = 50,
        /// <summary>
        /// The ps circle input action origin
        /// </summary>
        Ps4Circle = 51,
        /// <summary>
        /// The ps triangle input action origin
        /// </summary>
        Ps4Triangle = 52,
        /// <summary>
        /// The ps square input action origin
        /// </summary>
        Ps4Square = 53,
        /// <summary>
        /// The ps leftbumper input action origin
        /// </summary>
        Ps4Leftbumper = 54,
        /// <summary>
        /// The ps rightbumper input action origin
        /// </summary>
        Ps4Rightbumper = 55,
        /// <summary>
        /// The ps options input action origin
        /// </summary>
        Ps4Options = 56,
        /// <summary>
        /// The ps share input action origin
        /// </summary>
        Ps4Share = 57,
        /// <summary>
        /// The ps leftpad touch input action origin
        /// </summary>
        Ps4LeftpadTouch = 58,
        /// <summary>
        /// The ps leftpad swipe input action origin
        /// </summary>
        Ps4LeftpadSwipe = 59,
        /// <summary>
        /// The ps leftpad click input action origin
        /// </summary>
        Ps4LeftpadClick = 60,
        /// <summary>
        /// The ps leftpad dpadnorth input action origin
        /// </summary>
        Ps4LeftpadDpadnorth = 61,
        /// <summary>
        /// The ps leftpad dpadsouth input action origin
        /// </summary>
        Ps4LeftpadDpadsouth = 62,
        /// <summary>
        /// The ps leftpad dpadwest input action origin
        /// </summary>
        Ps4LeftpadDpadwest = 63,
        /// <summary>
        /// The ps leftpad dpadeast input action origin
        /// </summary>
        Ps4LeftpadDpadeast = 64,
        /// <summary>
        /// The ps rightpad touch input action origin
        /// </summary>
        Ps4RightpadTouch = 65,
        /// <summary>
        /// The ps rightpad swipe input action origin
        /// </summary>
        Ps4RightpadSwipe = 66,
        /// <summary>
        /// The ps rightpad click input action origin
        /// </summary>
        Ps4RightpadClick = 67,
        /// <summary>
        /// The ps rightpad dpadnorth input action origin
        /// </summary>
        Ps4RightpadDpadnorth = 68,
        /// <summary>
        /// The ps rightpad dpadsouth input action origin
        /// </summary>
        Ps4RightpadDpadsouth = 69,
        /// <summary>
        /// The ps rightpad dpadwest input action origin
        /// </summary>
        Ps4RightpadDpadwest = 70,
        /// <summary>
        /// The ps rightpad dpadeast input action origin
        /// </summary>
        Ps4RightpadDpadeast = 71,
        /// <summary>
        /// The ps centerpad touch input action origin
        /// </summary>
        Ps4CenterpadTouch = 72,
        /// <summary>
        /// The ps centerpad swipe input action origin
        /// </summary>
        Ps4CenterpadSwipe = 73,
        /// <summary>
        /// The ps centerpad click input action origin
        /// </summary>
        Ps4CenterpadClick = 74,
        /// <summary>
        /// The ps centerpad dpadnorth input action origin
        /// </summary>
        Ps4CenterpadDpadnorth = 75,
        /// <summary>
        /// The ps centerpad dpadsouth input action origin
        /// </summary>
        Ps4CenterpadDpadsouth = 76,
        /// <summary>
        /// The ps centerpad dpadwest input action origin
        /// </summary>
        Ps4CenterpadDpadwest = 77,
        /// <summary>
        /// The ps centerpad dpadeast input action origin
        /// </summary>
        Ps4CenterpadDpadeast = 78,
        /// <summary>
        /// The ps lefttrigger pull input action origin
        /// </summary>
        Ps4LefttriggerPull = 79,
        /// <summary>
        /// The ps lefttrigger click input action origin
        /// </summary>
        Ps4LefttriggerClick = 80,
        /// <summary>
        /// The ps righttrigger pull input action origin
        /// </summary>
        Ps4RighttriggerPull = 81,
        /// <summary>
        /// The ps righttrigger click input action origin
        /// </summary>
        Ps4RighttriggerClick = 82,
        /// <summary>
        /// The ps leftstick move input action origin
        /// </summary>
        Ps4LeftstickMove = 83,
        /// <summary>
        /// The ps leftstick click input action origin
        /// </summary>
        Ps4LeftstickClick = 84,
        /// <summary>
        /// The ps leftstick dpadnorth input action origin
        /// </summary>
        Ps4LeftstickDpadnorth = 85,
        /// <summary>
        /// The ps leftstick dpadsouth input action origin
        /// </summary>
        Ps4LeftstickDpadsouth = 86,
        /// <summary>
        /// The ps leftstick dpadwest input action origin
        /// </summary>
        Ps4LeftstickDpadwest = 87,
        /// <summary>
        /// The ps leftstick dpadeast input action origin
        /// </summary>
        Ps4LeftstickDpadeast = 88,
        /// <summary>
        /// The ps rightstick move input action origin
        /// </summary>
        Ps4RightstickMove = 89,
        /// <summary>
        /// The ps rightstick click input action origin
        /// </summary>
        Ps4RightstickClick = 90,
        /// <summary>
        /// The ps rightstick dpadnorth input action origin
        /// </summary>
        Ps4RightstickDpadnorth = 91,
        /// <summary>
        /// The ps rightstick dpadsouth input action origin
        /// </summary>
        Ps4RightstickDpadsouth = 92,
        /// <summary>
        /// The ps rightstick dpadwest input action origin
        /// </summary>
        Ps4RightstickDpadwest = 93,
        /// <summary>
        /// The ps rightstick dpadeast input action origin
        /// </summary>
        Ps4RightstickDpadeast = 94,
        /// <summary>
        /// The ps dpad north input action origin
        /// </summary>
        Ps4DpadNorth = 95,
        /// <summary>
        /// The ps dpad south input action origin
        /// </summary>
        Ps4DpadSouth = 96,
        /// <summary>
        /// The ps dpad west input action origin
        /// </summary>
        Ps4DpadWest = 97,
        /// <summary>
        /// The ps dpad east input action origin
        /// </summary>
        Ps4DpadEast = 98,
        /// <summary>
        /// The ps gyro move input action origin
        /// </summary>
        Ps4GyroMove = 99,
        /// <summary>
        /// The ps gyro pitch input action origin
        /// </summary>
        Ps4GyroPitch = 100,
        /// <summary>
        /// The ps gyro yaw input action origin
        /// </summary>
        Ps4GyroYaw = 101,
        /// <summary>
        /// The ps gyro roll input action origin
        /// </summary>
        Ps4GyroRoll = 102,
        /// <summary>
        /// The ps dpad move input action origin
        /// </summary>
        Ps4DpadMove = 103,
        /// <summary>
        /// The ps reserved input action origin
        /// </summary>
        Ps4Reserved1 = 104,
        /// <summary>
        /// The ps reserved input action origin
        /// </summary>
        Ps4Reserved2 = 105,
        /// <summary>
        /// The ps reserved input action origin
        /// </summary>
        Ps4Reserved3 = 106,
        /// <summary>
        /// The ps reserved input action origin
        /// </summary>
        Ps4Reserved4 = 107,
        /// <summary>
        /// The ps reserved input action origin
        /// </summary>
        Ps4Reserved5 = 108,
        /// <summary>
        /// The ps reserved input action origin
        /// </summary>
        Ps4Reserved6 = 109,
        /// <summary>
        /// The ps reserved input action origin
        /// </summary>
        Ps4Reserved7 = 110,
        /// <summary>
        /// The ps reserved input action origin
        /// </summary>
        Ps4Reserved8 = 111,
        /// <summary>
        /// The ps reserved input action origin
        /// </summary>
        Ps4Reserved9 = 112,
        /// <summary>
        /// The ps reserved 10 input action origin
        /// </summary>
        Ps4Reserved10 = 113,
        /// <summary>
        /// The xboxone input action origin
        /// </summary>
        XboxoneA = 114,
        /// <summary>
        /// The xboxone input action origin
        /// </summary>
        XboxoneB = 115,
        /// <summary>
        /// The xboxone input action origin
        /// </summary>
        XboxoneX = 116,
        /// <summary>
        /// The xboxone input action origin
        /// </summary>
        XboxoneY = 117,
        /// <summary>
        /// The xboxone leftbumper input action origin
        /// </summary>
        XboxoneLeftbumper = 118,
        /// <summary>
        /// The xboxone rightbumper input action origin
        /// </summary>
        XboxoneRightbumper = 119,
        /// <summary>
        /// The xboxone menu input action origin
        /// </summary>
        XboxoneMenu = 120,
        /// <summary>
        /// The xboxone view input action origin
        /// </summary>
        XboxoneView = 121,
        /// <summary>
        /// The xboxone lefttrigger pull input action origin
        /// </summary>
        XboxoneLefttriggerPull = 122,
        /// <summary>
        /// The xboxone lefttrigger click input action origin
        /// </summary>
        XboxoneLefttriggerClick = 123,
        /// <summary>
        /// The xboxone righttrigger pull input action origin
        /// </summary>
        XboxoneRighttriggerPull = 124,
        /// <summary>
        /// The xboxone righttrigger click input action origin
        /// </summary>
        XboxoneRighttriggerClick = 125,
        /// <summary>
        /// The xboxone leftstick move input action origin
        /// </summary>
        XboxoneLeftstickMove = 126,
        /// <summary>
        /// The xboxone leftstick click input action origin
        /// </summary>
        XboxoneLeftstickClick = 127,
        /// <summary>
        /// The xboxone leftstick dpadnorth input action origin
        /// </summary>
        XboxoneLeftstickDpadnorth = 128,
        /// <summary>
        /// The xboxone leftstick dpadsouth input action origin
        /// </summary>
        XboxoneLeftstickDpadsouth = 129,
        /// <summary>
        /// The xboxone leftstick dpadwest input action origin
        /// </summary>
        XboxoneLeftstickDpadwest = 130,
        /// <summary>
        /// The xboxone leftstick dpadeast input action origin
        /// </summary>
        XboxoneLeftstickDpadeast = 131,
        /// <summary>
        /// The xboxone rightstick move input action origin
        /// </summary>
        XboxoneRightstickMove = 132,
        /// <summary>
        /// The xboxone rightstick click input action origin
        /// </summary>
        XboxoneRightstickClick = 133,
        /// <summary>
        /// The xboxone rightstick dpadnorth input action origin
        /// </summary>
        XboxoneRightstickDpadnorth = 134,
        /// <summary>
        /// The xboxone rightstick dpadsouth input action origin
        /// </summary>
        XboxoneRightstickDpadsouth = 135,
        /// <summary>
        /// The xboxone rightstick dpadwest input action origin
        /// </summary>
        XboxoneRightstickDpadwest = 136,
        /// <summary>
        /// The xboxone rightstick dpadeast input action origin
        /// </summary>
        XboxoneRightstickDpadeast = 137,
        /// <summary>
        /// The xboxone dpad north input action origin
        /// </summary>
        XboxoneDpadNorth = 138,
        /// <summary>
        /// The xboxone dpad south input action origin
        /// </summary>
        XboxoneDpadSouth = 139,
        /// <summary>
        /// The xboxone dpad west input action origin
        /// </summary>
        XboxoneDpadWest = 140,
        /// <summary>
        /// The xboxone dpad east input action origin
        /// </summary>
        XboxoneDpadEast = 141,
        /// <summary>
        /// The xboxone dpad move input action origin
        /// </summary>
        XboxoneDpadMove = 142,
        /// <summary>
        /// The xboxone leftgrip lower input action origin
        /// </summary>
        XboxoneLeftgripLower = 143,
        /// <summary>
        /// The xboxone leftgrip upper input action origin
        /// </summary>
        XboxoneLeftgripUpper = 144,
        /// <summary>
        /// The xboxone rightgrip lower input action origin
        /// </summary>
        XboxoneRightgripLower = 145,
        /// <summary>
        /// The xboxone rightgrip upper input action origin
        /// </summary>
        XboxoneRightgripUpper = 146,
        /// <summary>
        /// The xboxone share input action origin
        /// </summary>
        XboxoneShare = 147,
        /// <summary>
        /// The xboxone reserved input action origin
        /// </summary>
        XboxoneReserved6 = 148,
        /// <summary>
        /// The xboxone reserved input action origin
        /// </summary>
        XboxoneReserved7 = 149,
        /// <summary>
        /// The xboxone reserved input action origin
        /// </summary>
        XboxoneReserved8 = 150,
        /// <summary>
        /// The xboxone reserved input action origin
        /// </summary>
        XboxoneReserved9 = 151,
        /// <summary>
        /// The xboxone reserved 10 input action origin
        /// </summary>
        XboxoneReserved10 = 152,
        /// <summary>
        /// The xbox 360 input action origin
        /// </summary>
        Xbox360A = 153,
        /// <summary>
        /// The xbox 360 input action origin
        /// </summary>
        Xbox360B = 154,
        /// <summary>
        /// The xbox 360 input action origin
        /// </summary>
        Xbox360X = 155,
        /// <summary>
        /// The xbox 360 input action origin
        /// </summary>
        Xbox360Y = 156,
        /// <summary>
        /// The xbox 360 leftbumper input action origin
        /// </summary>
        Xbox360Leftbumper = 157,
        /// <summary>
        /// The xbox 360 rightbumper input action origin
        /// </summary>
        Xbox360Rightbumper = 158,
        /// <summary>
        /// The xbox 360 start input action origin
        /// </summary>
        Xbox360Start = 159,
        /// <summary>
        /// The xbox 360 back input action origin
        /// </summary>
        Xbox360Back = 160,
        /// <summary>
        /// The xbox 360 lefttrigger pull input action origin
        /// </summary>
        Xbox360LefttriggerPull = 161,
        /// <summary>
        /// The xbox 360 lefttrigger click input action origin
        /// </summary>
        Xbox360LefttriggerClick = 162,
        /// <summary>
        /// The xbox 360 righttrigger pull input action origin
        /// </summary>
        Xbox360RighttriggerPull = 163,
        /// <summary>
        /// The xbox 360 righttrigger click input action origin
        /// </summary>
        Xbox360RighttriggerClick = 164,
        /// <summary>
        /// The xbox 360 leftstick move input action origin
        /// </summary>
        Xbox360LeftstickMove = 165,
        /// <summary>
        /// The xbox 360 leftstick click input action origin
        /// </summary>
        Xbox360LeftstickClick = 166,
        /// <summary>
        /// The xbox 360 leftstick dpadnorth input action origin
        /// </summary>
        Xbox360LeftstickDpadnorth = 167,
        /// <summary>
        /// The xbox 360 leftstick dpadsouth input action origin
        /// </summary>
        Xbox360LeftstickDpadsouth = 168,
        /// <summary>
        /// The xbox 360 leftstick dpadwest input action origin
        /// </summary>
        Xbox360LeftstickDpadwest = 169,
        /// <summary>
        /// The xbox 360 leftstick dpadeast input action origin
        /// </summary>
        Xbox360LeftstickDpadeast = 170,
        /// <summary>
        /// The xbox 360 rightstick move input action origin
        /// </summary>
        Xbox360RightstickMove = 171,
        /// <summary>
        /// The xbox 360 rightstick click input action origin
        /// </summary>
        Xbox360RightstickClick = 172,
        /// <summary>
        /// The xbox 360 rightstick dpadnorth input action origin
        /// </summary>
        Xbox360RightstickDpadnorth = 173,
        /// <summary>
        /// The xbox 360 rightstick dpadsouth input action origin
        /// </summary>
        Xbox360RightstickDpadsouth = 174,
        /// <summary>
        /// The xbox 360 rightstick dpadwest input action origin
        /// </summary>
        Xbox360RightstickDpadwest = 175,
        /// <summary>
        /// The xbox 360 rightstick dpadeast input action origin
        /// </summary>
        Xbox360RightstickDpadeast = 176,
        /// <summary>
        /// The xbox 360 dpad north input action origin
        /// </summary>
        Xbox360DpadNorth = 177,
        /// <summary>
        /// The xbox 360 dpad south input action origin
        /// </summary>
        Xbox360DpadSouth = 178,
        /// <summary>
        /// The xbox 360 dpad west input action origin
        /// </summary>
        Xbox360DpadWest = 179,
        /// <summary>
        /// The xbox 360 dpad east input action origin
        /// </summary>
        Xbox360DpadEast = 180,
        /// <summary>
        /// The xbox 360 dpad move input action origin
        /// </summary>
        Xbox360DpadMove = 181,
        /// <summary>
        /// The xbox 360 reserved input action origin
        /// </summary>
        Xbox360Reserved1 = 182,
        /// <summary>
        /// The xbox 360 reserved input action origin
        /// </summary>
        Xbox360Reserved2 = 183,
        /// <summary>
        /// The xbox 360 reserved input action origin
        /// </summary>
        Xbox360Reserved3 = 184,
        /// <summary>
        /// The xbox 360 reserved input action origin
        /// </summary>
        Xbox360Reserved4 = 185,
        /// <summary>
        /// The xbox 360 reserved input action origin
        /// </summary>
        Xbox360Reserved5 = 186,
        /// <summary>
        /// The xbox 360 reserved input action origin
        /// </summary>
        Xbox360Reserved6 = 187,
        /// <summary>
        /// The xbox 360 reserved input action origin
        /// </summary>
        Xbox360Reserved7 = 188,
        /// <summary>
        /// The xbox 360 reserved input action origin
        /// </summary>
        Xbox360Reserved8 = 189,
        /// <summary>
        /// The xbox 360 reserved input action origin
        /// </summary>
        Xbox360Reserved9 = 190,
        /// <summary>
        /// The xbox 360 reserved 10 input action origin
        /// </summary>
        Xbox360Reserved10 = 191,
        /// <summary>
        /// The switch input action origin
        /// </summary>
        SwitchA = 192,
        /// <summary>
        /// The switch input action origin
        /// </summary>
        SwitchB = 193,
        /// <summary>
        /// The switch input action origin
        /// </summary>
        SwitchX = 194,
        /// <summary>
        /// The switch input action origin
        /// </summary>
        SwitchY = 195,
        /// <summary>
        /// The switch leftbumper input action origin
        /// </summary>
        SwitchLeftbumper = 196,
        /// <summary>
        /// The switch rightbumper input action origin
        /// </summary>
        SwitchRightbumper = 197,
        /// <summary>
        /// The switch plus input action origin
        /// </summary>
        SwitchPlus = 198,
        /// <summary>
        /// The switch minus input action origin
        /// </summary>
        SwitchMinus = 199,
        /// <summary>
        /// The switch capture input action origin
        /// </summary>
        SwitchCapture = 200,
        /// <summary>
        /// The switch lefttrigger pull input action origin
        /// </summary>
        SwitchLefttriggerPull = 201,
        /// <summary>
        /// The switch lefttrigger click input action origin
        /// </summary>
        SwitchLefttriggerClick = 202,
        /// <summary>
        /// The switch righttrigger pull input action origin
        /// </summary>
        SwitchRighttriggerPull = 203,
        /// <summary>
        /// The switch righttrigger click input action origin
        /// </summary>
        SwitchRighttriggerClick = 204,
        /// <summary>
        /// The switch leftstick move input action origin
        /// </summary>
        SwitchLeftstickMove = 205,
        /// <summary>
        /// The switch leftstick click input action origin
        /// </summary>
        SwitchLeftstickClick = 206,
        /// <summary>
        /// The switch leftstick dpadnorth input action origin
        /// </summary>
        SwitchLeftstickDpadnorth = 207,
        /// <summary>
        /// The switch leftstick dpadsouth input action origin
        /// </summary>
        SwitchLeftstickDpadsouth = 208,
        /// <summary>
        /// The switch leftstick dpadwest input action origin
        /// </summary>
        SwitchLeftstickDpadwest = 209,
        /// <summary>
        /// The switch leftstick dpadeast input action origin
        /// </summary>
        SwitchLeftstickDpadeast = 210,
        /// <summary>
        /// The switch rightstick move input action origin
        /// </summary>
        SwitchRightstickMove = 211,
        /// <summary>
        /// The switch rightstick click input action origin
        /// </summary>
        SwitchRightstickClick = 212,
        /// <summary>
        /// The switch rightstick dpadnorth input action origin
        /// </summary>
        SwitchRightstickDpadnorth = 213,
        /// <summary>
        /// The switch rightstick dpadsouth input action origin
        /// </summary>
        SwitchRightstickDpadsouth = 214,
        /// <summary>
        /// The switch rightstick dpadwest input action origin
        /// </summary>
        SwitchRightstickDpadwest = 215,
        /// <summary>
        /// The switch rightstick dpadeast input action origin
        /// </summary>
        SwitchRightstickDpadeast = 216,
        /// <summary>
        /// The switch dpad north input action origin
        /// </summary>
        SwitchDpadNorth = 217,
        /// <summary>
        /// The switch dpad south input action origin
        /// </summary>
        SwitchDpadSouth = 218,
        /// <summary>
        /// The switch dpad west input action origin
        /// </summary>
        SwitchDpadWest = 219,
        /// <summary>
        /// The switch dpad east input action origin
        /// </summary>
        SwitchDpadEast = 220,
        /// <summary>
        /// The switch progyro move input action origin
        /// </summary>
        SwitchProgyroMove = 221,
        /// <summary>
        /// The switch progyro pitch input action origin
        /// </summary>
        SwitchProgyroPitch = 222,
        /// <summary>
        /// The switch progyro yaw input action origin
        /// </summary>
        SwitchProgyroYaw = 223,
        /// <summary>
        /// The switch progyro roll input action origin
        /// </summary>
        SwitchProgyroRoll = 224,
        /// <summary>
        /// The switch dpad move input action origin
        /// </summary>
        SwitchDpadMove = 225,
        /// <summary>
        /// The switch reserved input action origin
        /// </summary>
        SwitchReserved1 = 226,
        /// <summary>
        /// The switch reserved input action origin
        /// </summary>
        SwitchReserved2 = 227,
        /// <summary>
        /// The switch reserved input action origin
        /// </summary>
        SwitchReserved3 = 228,
        /// <summary>
        /// The switch reserved input action origin
        /// </summary>
        SwitchReserved4 = 229,
        /// <summary>
        /// The switch reserved input action origin
        /// </summary>
        SwitchReserved5 = 230,
        /// <summary>
        /// The switch reserved input action origin
        /// </summary>
        SwitchReserved6 = 231,
        /// <summary>
        /// The switch reserved input action origin
        /// </summary>
        SwitchReserved7 = 232,
        /// <summary>
        /// The switch reserved input action origin
        /// </summary>
        SwitchReserved8 = 233,
        /// <summary>
        /// The switch reserved input action origin
        /// </summary>
        SwitchReserved9 = 234,
        /// <summary>
        /// The switch reserved 10 input action origin
        /// </summary>
        SwitchReserved10 = 235,
        /// <summary>
        /// The switch rightgyro move input action origin
        /// </summary>
        SwitchRightgyroMove = 236,
        /// <summary>
        /// The switch rightgyro pitch input action origin
        /// </summary>
        SwitchRightgyroPitch = 237,
        /// <summary>
        /// The switch rightgyro yaw input action origin
        /// </summary>
        SwitchRightgyroYaw = 238,
        /// <summary>
        /// The switch rightgyro roll input action origin
        /// </summary>
        SwitchRightgyroRoll = 239,
        /// <summary>
        /// The switch leftgyro move input action origin
        /// </summary>
        SwitchLeftgyroMove = 240,
        /// <summary>
        /// The switch leftgyro pitch input action origin
        /// </summary>
        SwitchLeftgyroPitch = 241,
        /// <summary>
        /// The switch leftgyro yaw input action origin
        /// </summary>
        SwitchLeftgyroYaw = 242,
        /// <summary>
        /// The switch leftgyro roll input action origin
        /// </summary>
        SwitchLeftgyroRoll = 243,
        /// <summary>
        /// The switch leftgrip lower input action origin
        /// </summary>
        SwitchLeftgripLower = 244,
        /// <summary>
        /// The switch leftgrip upper input action origin
        /// </summary>
        SwitchLeftgripUpper = 245,
        /// <summary>
        /// The switch rightgrip lower input action origin
        /// </summary>
        SwitchRightgripLower = 246,
        /// <summary>
        /// The switch rightgrip upper input action origin
        /// </summary>
        SwitchRightgripUpper = 247,
        /// <summary>
        /// The switch joycon button input action origin
        /// </summary>
        SwitchJoyconButtonN = 248,
        /// <summary>
        /// The switch joycon button input action origin
        /// </summary>
        SwitchJoyconButtonE = 249,
        /// <summary>
        /// The switch joycon button input action origin
        /// </summary>
        SwitchJoyconButtonS = 250,
        /// <summary>
        /// The switch joycon button input action origin
        /// </summary>
        SwitchJoyconButtonW = 251,
        /// <summary>
        /// The switch reserved 15 input action origin
        /// </summary>
        SwitchReserved15 = 252,
        /// <summary>
        /// The switch reserved 16 input action origin
        /// </summary>
        SwitchReserved16 = 253,
        /// <summary>
        /// The switch reserved 17 input action origin
        /// </summary>
        SwitchReserved17 = 254,
        /// <summary>
        /// The switch reserved 18 input action origin
        /// </summary>
        SwitchReserved18 = 255,
        /// <summary>
        /// The switch reserved 19 input action origin
        /// </summary>
        SwitchReserved19 = 256,
        /// <summary>
        /// The switch reserved 20 input action origin
        /// </summary>
        SwitchReserved20 = 257,
        /// <summary>
        /// The ps input action origin
        /// </summary>
        Ps5X = 258,
        /// <summary>
        /// The ps circle input action origin
        /// </summary>
        Ps5Circle = 259,
        /// <summary>
        /// The ps triangle input action origin
        /// </summary>
        Ps5Triangle = 260,
        /// <summary>
        /// The ps square input action origin
        /// </summary>
        Ps5Square = 261,
        /// <summary>
        /// The ps leftbumper input action origin
        /// </summary>
        Ps5Leftbumper = 262,
        /// <summary>
        /// The ps rightbumper input action origin
        /// </summary>
        Ps5Rightbumper = 263,
        /// <summary>
        /// The ps option input action origin
        /// </summary>
        Ps5Option = 264,
        /// <summary>
        /// The ps create input action origin
        /// </summary>
        Ps5Create = 265,
        /// <summary>
        /// The ps mute input action origin
        /// </summary>
        Ps5Mute = 266,
        /// <summary>
        /// The ps leftpad touch input action origin
        /// </summary>
        Ps5LeftpadTouch = 267,
        /// <summary>
        /// The ps leftpad swipe input action origin
        /// </summary>
        Ps5LeftpadSwipe = 268,
        /// <summary>
        /// The ps leftpad click input action origin
        /// </summary>
        Ps5LeftpadClick = 269,
        /// <summary>
        /// The ps leftpad dpadnorth input action origin
        /// </summary>
        Ps5LeftpadDpadnorth = 270,
        /// <summary>
        /// The ps leftpad dpadsouth input action origin
        /// </summary>
        Ps5LeftpadDpadsouth = 271,
        /// <summary>
        /// The ps leftpad dpadwest input action origin
        /// </summary>
        Ps5LeftpadDpadwest = 272,
        /// <summary>
        /// The ps leftpad dpadeast input action origin
        /// </summary>
        Ps5LeftpadDpadeast = 273,
        /// <summary>
        /// The ps rightpad touch input action origin
        /// </summary>
        Ps5RightpadTouch = 274,
        /// <summary>
        /// The ps rightpad swipe input action origin
        /// </summary>
        Ps5RightpadSwipe = 275,
        /// <summary>
        /// The ps rightpad click input action origin
        /// </summary>
        Ps5RightpadClick = 276,
        /// <summary>
        /// The ps rightpad dpadnorth input action origin
        /// </summary>
        Ps5RightpadDpadnorth = 277,
        /// <summary>
        /// The ps rightpad dpadsouth input action origin
        /// </summary>
        Ps5RightpadDpadsouth = 278,
        /// <summary>
        /// The ps rightpad dpadwest input action origin
        /// </summary>
        Ps5RightpadDpadwest = 279,
        /// <summary>
        /// The ps rightpad dpadeast input action origin
        /// </summary>
        Ps5RightpadDpadeast = 280,
        /// <summary>
        /// The ps centerpad touch input action origin
        /// </summary>
        Ps5CenterpadTouch = 281,
        /// <summary>
        /// The ps centerpad swipe input action origin
        /// </summary>
        Ps5CenterpadSwipe = 282,
        /// <summary>
        /// The ps centerpad click input action origin
        /// </summary>
        Ps5CenterpadClick = 283,
        /// <summary>
        /// The ps centerpad dpadnorth input action origin
        /// </summary>
        Ps5CenterpadDpadnorth = 284,
        /// <summary>
        /// The ps centerpad dpadsouth input action origin
        /// </summary>
        Ps5CenterpadDpadsouth = 285,
        /// <summary>
        /// The ps centerpad dpadwest input action origin
        /// </summary>
        Ps5CenterpadDpadwest = 286,
        /// <summary>
        /// The ps centerpad dpadeast input action origin
        /// </summary>
        Ps5CenterpadDpadeast = 287,
        /// <summary>
        /// The ps lefttrigger pull input action origin
        /// </summary>
        Ps5LefttriggerPull = 288,
        /// <summary>
        /// The ps lefttrigger click input action origin
        /// </summary>
        Ps5LefttriggerClick = 289,
        /// <summary>
        /// The ps righttrigger pull input action origin
        /// </summary>
        Ps5RighttriggerPull = 290,
        /// <summary>
        /// The ps righttrigger click input action origin
        /// </summary>
        Ps5RighttriggerClick = 291,
        /// <summary>
        /// The ps leftstick move input action origin
        /// </summary>
        Ps5LeftstickMove = 292,
        /// <summary>
        /// The ps leftstick click input action origin
        /// </summary>
        Ps5LeftstickClick = 293,
        /// <summary>
        /// The ps leftstick dpadnorth input action origin
        /// </summary>
        Ps5LeftstickDpadnorth = 294,
        /// <summary>
        /// The ps leftstick dpadsouth input action origin
        /// </summary>
        Ps5LeftstickDpadsouth = 295,
        /// <summary>
        /// The ps leftstick dpadwest input action origin
        /// </summary>
        Ps5LeftstickDpadwest = 296,
        /// <summary>
        /// The ps leftstick dpadeast input action origin
        /// </summary>
        Ps5LeftstickDpadeast = 297,
        /// <summary>
        /// The ps rightstick move input action origin
        /// </summary>
        Ps5RightstickMove = 298,
        /// <summary>
        /// The ps rightstick click input action origin
        /// </summary>
        Ps5RightstickClick = 299,
        /// <summary>
        /// The ps rightstick dpadnorth input action origin
        /// </summary>
        Ps5RightstickDpadnorth = 300,
        /// <summary>
        /// The ps rightstick dpadsouth input action origin
        /// </summary>
        Ps5RightstickDpadsouth = 301,
        /// <summary>
        /// The ps rightstick dpadwest input action origin
        /// </summary>
        Ps5RightstickDpadwest = 302,
        /// <summary>
        /// The ps rightstick dpadeast input action origin
        /// </summary>
        Ps5RightstickDpadeast = 303,
        /// <summary>
        /// The ps dpad north input action origin
        /// </summary>
        Ps5DpadNorth = 304,
        /// <summary>
        /// The ps dpad south input action origin
        /// </summary>
        Ps5DpadSouth = 305,
        /// <summary>
        /// The ps dpad west input action origin
        /// </summary>
        Ps5DpadWest = 306,
        /// <summary>
        /// The ps dpad east input action origin
        /// </summary>
        Ps5DpadEast = 307,
        /// <summary>
        /// The ps gyro move input action origin
        /// </summary>
        Ps5GyroMove = 308,
        /// <summary>
        /// The ps gyro pitch input action origin
        /// </summary>
        Ps5GyroPitch = 309,
        /// <summary>
        /// The ps gyro yaw input action origin
        /// </summary>
        Ps5GyroYaw = 310,
        /// <summary>
        /// The ps gyro roll input action origin
        /// </summary>
        Ps5GyroRoll = 311,
        /// <summary>
        /// The ps dpad move input action origin
        /// </summary>
        Ps5DpadMove = 312,
        /// <summary>
        /// The ps leftgrip input action origin
        /// </summary>
        Ps5Leftgrip = 313,
        /// <summary>
        /// The ps rightgrip input action origin
        /// </summary>
        Ps5Rightgrip = 314,
        /// <summary>
        /// The ps leftfn input action origin
        /// </summary>
        Ps5Leftfn = 315,
        /// <summary>
        /// The ps rightfn input action origin
        /// </summary>
        Ps5Rightfn = 316,
        /// <summary>
        /// The ps reserved input action origin
        /// </summary>
        Ps5Reserved5 = 317,
        /// <summary>
        /// The ps reserved input action origin
        /// </summary>
        Ps5Reserved6 = 318,
        /// <summary>
        /// The ps reserved input action origin
        /// </summary>
        Ps5Reserved7 = 319,
        /// <summary>
        /// The ps reserved input action origin
        /// </summary>
        Ps5Reserved8 = 320,
        /// <summary>
        /// The ps reserved input action origin
        /// </summary>
        Ps5Reserved9 = 321,
        /// <summary>
        /// The ps reserved 10 input action origin
        /// </summary>
        Ps5Reserved10 = 322,
        /// <summary>
        /// The ps reserved 11 input action origin
        /// </summary>
        Ps5Reserved11 = 323,
        /// <summary>
        /// The ps reserved 12 input action origin
        /// </summary>
        Ps5Reserved12 = 324,
        /// <summary>
        /// The ps reserved 13 input action origin
        /// </summary>
        Ps5Reserved13 = 325,
        /// <summary>
        /// The ps reserved 14 input action origin
        /// </summary>
        Ps5Reserved14 = 326,
        /// <summary>
        /// The ps reserved 15 input action origin
        /// </summary>
        Ps5Reserved15 = 327,
        /// <summary>
        /// The ps reserved 16 input action origin
        /// </summary>
        Ps5Reserved16 = 328,
        /// <summary>
        /// The ps reserved 17 input action origin
        /// </summary>
        Ps5Reserved17 = 329,
        /// <summary>
        /// The ps reserved 18 input action origin
        /// </summary>
        Ps5Reserved18 = 330,
        /// <summary>
        /// The ps reserved 19 input action origin
        /// </summary>
        Ps5Reserved19 = 331,
        /// <summary>
        /// The ps reserved 20 input action origin
        /// </summary>
        Ps5Reserved20 = 332,
        /// <summary>
        /// The steamdeck input action origin
        /// </summary>
        SteamdeckA = 333,
        /// <summary>
        /// The steamdeck input action origin
        /// </summary>
        SteamdeckB = 334,
        /// <summary>
        /// The steamdeck input action origin
        /// </summary>
        SteamdeckX = 335,
        /// <summary>
        /// The steamdeck input action origin
        /// </summary>
        SteamdeckY = 336,
        /// <summary>
        /// The steamdeck input action origin
        /// </summary>
        SteamdeckL1 = 337,
        /// <summary>
        /// The steamdeck input action origin
        /// </summary>
        SteamdeckR1 = 338,
        /// <summary>
        /// The steamdeck menu input action origin
        /// </summary>
        SteamdeckMenu = 339,
        /// <summary>
        /// The steamdeck view input action origin
        /// </summary>
        SteamdeckView = 340,
        /// <summary>
        /// The steamdeck leftpad touch input action origin
        /// </summary>
        SteamdeckLeftpadTouch = 341,
        /// <summary>
        /// The steamdeck leftpad swipe input action origin
        /// </summary>
        SteamdeckLeftpadSwipe = 342,
        /// <summary>
        /// The steamdeck leftpad click input action origin
        /// </summary>
        SteamdeckLeftpadClick = 343,
        /// <summary>
        /// The steamdeck leftpad dpadnorth input action origin
        /// </summary>
        SteamdeckLeftpadDpadnorth = 344,
        /// <summary>
        /// The steamdeck leftpad dpadsouth input action origin
        /// </summary>
        SteamdeckLeftpadDpadsouth = 345,
        /// <summary>
        /// The steamdeck leftpad dpadwest input action origin
        /// </summary>
        SteamdeckLeftpadDpadwest = 346,
        /// <summary>
        /// The steamdeck leftpad dpadeast input action origin
        /// </summary>
        SteamdeckLeftpadDpadeast = 347,
        /// <summary>
        /// The steamdeck rightpad touch input action origin
        /// </summary>
        SteamdeckRightpadTouch = 348,
        /// <summary>
        /// The steamdeck rightpad swipe input action origin
        /// </summary>
        SteamdeckRightpadSwipe = 349,
        /// <summary>
        /// The steamdeck rightpad click input action origin
        /// </summary>
        SteamdeckRightpadClick = 350,
        /// <summary>
        /// The steamdeck rightpad dpadnorth input action origin
        /// </summary>
        SteamdeckRightpadDpadnorth = 351,
        /// <summary>
        /// The steamdeck rightpad dpadsouth input action origin
        /// </summary>
        SteamdeckRightpadDpadsouth = 352,
        /// <summary>
        /// The steamdeck rightpad dpadwest input action origin
        /// </summary>
        SteamdeckRightpadDpadwest = 353,
        /// <summary>
        /// The steamdeck rightpad dpadeast input action origin
        /// </summary>
        SteamdeckRightpadDpadeast = 354,
        /// <summary>
        /// The steamdeck softpull input action origin
        /// </summary>
        SteamdeckL2Softpull = 355,
        /// <summary>
        /// The steamdeck input action origin
        /// </summary>
        SteamdeckL2 = 356,
        /// <summary>
        /// The steamdeck softpull input action origin
        /// </summary>
        SteamdeckR2Softpull = 357,
        /// <summary>
        /// The steamdeck input action origin
        /// </summary>
        SteamdeckR2 = 358,
        /// <summary>
        /// The steamdeck leftstick move input action origin
        /// </summary>
        SteamdeckLeftstickMove = 359,
        /// <summary>
        /// The steamdeck input action origin
        /// </summary>
        SteamdeckL3 = 360,
        /// <summary>
        /// The steamdeck leftstick dpadnorth input action origin
        /// </summary>
        SteamdeckLeftstickDpadnorth = 361,
        /// <summary>
        /// The steamdeck leftstick dpadsouth input action origin
        /// </summary>
        SteamdeckLeftstickDpadsouth = 362,
        /// <summary>
        /// The steamdeck leftstick dpadwest input action origin
        /// </summary>
        SteamdeckLeftstickDpadwest = 363,
        /// <summary>
        /// The steamdeck leftstick dpadeast input action origin
        /// </summary>
        SteamdeckLeftstickDpadeast = 364,
        /// <summary>
        /// The steamdeck leftstick touch input action origin
        /// </summary>
        SteamdeckLeftstickTouch = 365,
        /// <summary>
        /// The steamdeck rightstick move input action origin
        /// </summary>
        SteamdeckRightstickMove = 366,
        /// <summary>
        /// The steamdeck input action origin
        /// </summary>
        SteamdeckR3 = 367,
        /// <summary>
        /// The steamdeck rightstick dpadnorth input action origin
        /// </summary>
        SteamdeckRightstickDpadnorth = 368,
        /// <summary>
        /// The steamdeck rightstick dpadsouth input action origin
        /// </summary>
        SteamdeckRightstickDpadsouth = 369,
        /// <summary>
        /// The steamdeck rightstick dpadwest input action origin
        /// </summary>
        SteamdeckRightstickDpadwest = 370,
        /// <summary>
        /// The steamdeck rightstick dpadeast input action origin
        /// </summary>
        SteamdeckRightstickDpadeast = 371,
        /// <summary>
        /// The steamdeck rightstick touch input action origin
        /// </summary>
        SteamdeckRightstickTouch = 372,
        /// <summary>
        /// The steamdeck input action origin
        /// </summary>
        SteamdeckL4 = 373,
        /// <summary>
        /// The steamdeck input action origin
        /// </summary>
        SteamdeckR4 = 374,
        /// <summary>
        /// The steamdeck input action origin
        /// </summary>
        SteamdeckL5 = 375,
        /// <summary>
        /// The steamdeck input action origin
        /// </summary>
        SteamdeckR5 = 376,
        /// <summary>
        /// The steamdeck dpad move input action origin
        /// </summary>
        SteamdeckDpadMove = 377,
        /// <summary>
        /// The steamdeck dpad north input action origin
        /// </summary>
        SteamdeckDpadNorth = 378,
        /// <summary>
        /// The steamdeck dpad south input action origin
        /// </summary>
        SteamdeckDpadSouth = 379,
        /// <summary>
        /// The steamdeck dpad west input action origin
        /// </summary>
        SteamdeckDpadWest = 380,
        /// <summary>
        /// The steamdeck dpad east input action origin
        /// </summary>
        SteamdeckDpadEast = 381,
        /// <summary>
        /// The steamdeck gyro move input action origin
        /// </summary>
        SteamdeckGyroMove = 382,
        /// <summary>
        /// The steamdeck gyro pitch input action origin
        /// </summary>
        SteamdeckGyroPitch = 383,
        /// <summary>
        /// The steamdeck gyro yaw input action origin
        /// </summary>
        SteamdeckGyroYaw = 384,
        /// <summary>
        /// The steamdeck gyro roll input action origin
        /// </summary>
        SteamdeckGyroRoll = 385,
        /// <summary>
        /// The steamdeck reserved input action origin
        /// </summary>
        SteamdeckReserved1 = 386,
        /// <summary>
        /// The steamdeck reserved input action origin
        /// </summary>
        SteamdeckReserved2 = 387,
        /// <summary>
        /// The steamdeck reserved input action origin
        /// </summary>
        SteamdeckReserved3 = 388,
        /// <summary>
        /// The steamdeck reserved input action origin
        /// </summary>
        SteamdeckReserved4 = 389,
        /// <summary>
        /// The steamdeck reserved input action origin
        /// </summary>
        SteamdeckReserved5 = 390,
        /// <summary>
        /// The steamdeck reserved input action origin
        /// </summary>
        SteamdeckReserved6 = 391,
        /// <summary>
        /// The steamdeck reserved input action origin
        /// </summary>
        SteamdeckReserved7 = 392,
        /// <summary>
        /// The steamdeck reserved input action origin
        /// </summary>
        SteamdeckReserved8 = 393,
        /// <summary>
        /// The steamdeck reserved input action origin
        /// </summary>
        SteamdeckReserved9 = 394,
        /// <summary>
        /// The steamdeck reserved 10 input action origin
        /// </summary>
        SteamdeckReserved10 = 395,
        /// <summary>
        /// The steamdeck reserved 11 input action origin
        /// </summary>
        SteamdeckReserved11 = 396,
        /// <summary>
        /// The steamdeck reserved 12 input action origin
        /// </summary>
        SteamdeckReserved12 = 397,
        /// <summary>
        /// The steamdeck reserved 13 input action origin
        /// </summary>
        SteamdeckReserved13 = 398,
        /// <summary>
        /// The steamdeck reserved 14 input action origin
        /// </summary>
        SteamdeckReserved14 = 399,
        /// <summary>
        /// The steamdeck reserved 15 input action origin
        /// </summary>
        SteamdeckReserved15 = 400,
        /// <summary>
        /// The steamdeck reserved 16 input action origin
        /// </summary>
        SteamdeckReserved16 = 401,
        /// <summary>
        /// The steamdeck reserved 17 input action origin
        /// </summary>
        SteamdeckReserved17 = 402,
        /// <summary>
        /// The steamdeck reserved 18 input action origin
        /// </summary>
        SteamdeckReserved18 = 403,
        /// <summary>
        /// The steamdeck reserved 19 input action origin
        /// </summary>
        SteamdeckReserved19 = 404,
        /// <summary>
        /// The steamdeck reserved 20 input action origin
        /// </summary>
        SteamdeckReserved20 = 405,
        /// <summary>
        /// The count input action origin
        /// </summary>
        Count = 406,
        /// <summary>
        /// The maximum possible value input action origin
        /// </summary>
        MaximumPossibleValue = 32767
    }

    /// <summary>
    /// The input configuration enable type enum
    /// </summary>
    [System.Flags]
    public enum InputConfigurationEnableType : long
    {
        /// <summary>
        /// The none input configuration enable type
        /// </summary>
        None = 0,
        /// <summary>
        /// The playstation input configuration enable type
        /// </summary>
        Playstation = 1,
        /// <summary>
        /// The xbox input configuration enable type
        /// </summary>
        Xbox = 2,
        /// <summary>
        /// The generic input configuration enable type
        /// </summary>
        Generic = 4,
        /// <summary>
        /// The switch input configuration enable type
        /// </summary>
        Switch = 8
    }

    /// <summary>
    /// The input glyph size enum
    /// </summary>
    public enum InputGlyphSize : long
    {
        /// <summary>
        /// The small input glyph size
        /// </summary>
        Small = 0,
        /// <summary>
        /// The medium input glyph size
        /// </summary>
        Medium = 1,
        /// <summary>
        /// The large input glyph size
        /// </summary>
        Large = 2,
        /// <summary>
        /// The count input glyph size
        /// </summary>
        Count = 3
    }

    /// <summary>
    /// The input glyph style enum
    /// </summary>
    [System.Flags]
    public enum InputGlyphStyle : long
    {
        /// <summary>
        /// The knockout input glyph style
        /// </summary>
        Knockout = 0,
        /// <summary>
        /// The light input glyph style
        /// </summary>
        Light = 1,
        /// <summary>
        /// The dark input glyph style
        /// </summary>
        Dark = 2,
        /// <summary>
        /// The neutral color abxy input glyph style
        /// </summary>
        NeutralColorAbxy = 16,
        /// <summary>
        /// The solid abxy input glyph style
        /// </summary>
        SolidAbxy = 32
    }

    /// <summary>
    /// The input led flag enum
    /// </summary>
    public enum InputLedFlag : long
    {
        /// <summary>
        /// The set color input led flag
        /// </summary>
        SetColor = 0,
        /// <summary>
        /// The restore user default input led flag
        /// </summary>
        RestoreUserDefault = 1
    }

    /// <summary>
    /// The input source mode enum
    /// </summary>
    public enum InputSourceMode : long
    {
        /// <summary>
        /// The none input source mode
        /// </summary>
        None = 0,
        /// <summary>
        /// The dpad input source mode
        /// </summary>
        Dpad = 1,
        /// <summary>
        /// The buttons input source mode
        /// </summary>
        Buttons = 2,
        /// <summary>
        /// The four buttons input source mode
        /// </summary>
        FourButtons = 3,
        /// <summary>
        /// The absolute mouse input source mode
        /// </summary>
        AbsoluteMouse = 4,
        /// <summary>
        /// The relative mouse input source mode
        /// </summary>
        RelativeMouse = 5,
        /// <summary>
        /// The joystick move input source mode
        /// </summary>
        JoystickMove = 6,
        /// <summary>
        /// The joystick mouse input source mode
        /// </summary>
        JoystickMouse = 7,
        /// <summary>
        /// The joystick camera input source mode
        /// </summary>
        JoystickCamera = 8,
        /// <summary>
        /// The scroll wheel input source mode
        /// </summary>
        ScrollWheel = 9,
        /// <summary>
        /// The trigger input source mode
        /// </summary>
        Trigger = 10,
        /// <summary>
        /// The touch menu input source mode
        /// </summary>
        TouchMenu = 11,
        /// <summary>
        /// The mouse joystick input source mode
        /// </summary>
        MouseJoystick = 12,
        /// <summary>
        /// The mouse region input source mode
        /// </summary>
        MouseRegion = 13,
        /// <summary>
        /// The radial menu input source mode
        /// </summary>
        RadialMenu = 14,
        /// <summary>
        /// The single button input source mode
        /// </summary>
        SingleButton = 15,
        /// <summary>
        /// The switch input source mode
        /// </summary>
        Switch = 16
    }

    /// <summary>
    /// The input type enum
    /// </summary>
    public enum InputType : long
    {
        /// <summary>
        /// The unknown input type
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// The steam controller input type
        /// </summary>
        SteamController = 1,
        /// <summary>
        /// The xbox 360 controller input type
        /// </summary>
        Xbox360Controller = 2,
        /// <summary>
        /// The xboxone controller input type
        /// </summary>
        XboxoneController = 3,
        /// <summary>
        /// The generic xinput input type
        /// </summary>
        GenericXinput = 4,
        /// <summary>
        /// The ps controller input type
        /// </summary>
        Ps4Controller = 5,
        /// <summary>
        /// The apple mfi controller input type
        /// </summary>
        AppleMfiController = 6,
        /// <summary>
        /// The android controller input type
        /// </summary>
        AndroidController = 7,
        /// <summary>
        /// The switch joycon pair input type
        /// </summary>
        SwitchJoyconPair = 8,
        /// <summary>
        /// The switch joycon single input type
        /// </summary>
        SwitchJoyconSingle = 9,
        /// <summary>
        /// The switch pro controller input type
        /// </summary>
        SwitchProController = 10,
        /// <summary>
        /// The mobile touch input type
        /// </summary>
        MobileTouch = 11,
        /// <summary>
        /// The ps controller input type
        /// </summary>
        Ps3Controller = 12,
        /// <summary>
        /// The ps controller input type
        /// </summary>
        Ps5Controller = 13,
        /// <summary>
        /// The steam deck controller input type
        /// </summary>
        SteamDeckController = 14,
        /// <summary>
        /// The count input type
        /// </summary>
        Count = 15,
        /// <summary>
        /// The maximum possible value input type
        /// </summary>
        MaximumPossibleValue = 255
    }
}