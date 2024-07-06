using System.Collections.Generic;
using System.Linq;

namespace GodotSteam;

public static partial class Steam
{
    public static void ActivateActionSet(ulong inputHandle, ulong actionSetHandle)
    {
        GetInstance().Call(Methods.ActivateActionSet, inputHandle, actionSetHandle);
    }
    
    public static void ActivateActionSetLayer(ulong inputHandle, ulong actionSetLayerHandle)
    {
        GetInstance().Call(Methods.ActivateActionSetLayer, inputHandle, actionSetLayerHandle);
    }
    
    public static void DeactivateActionSetLayer(ulong inputHandle, ulong actionSetHandle)
    {
        GetInstance().Call(Methods.DeactivateActionSetLayer, inputHandle, actionSetHandle);
    }
    
    public static void DeactivateAllActionSetLayers(ulong inputHandle)
    {
        GetInstance().Call(Methods.DeactivateAllActionSetLayers, inputHandle);
    }
    
    public static ulong GetActionSetHandle(string actionSetName)
    {
        return GetInstance().Call(Methods.GetActionSetHandle, actionSetName).As<ulong>();
    }
    
    public static InputActionOrigin GetActionOriginFromXboxOrigin(ulong inputHandle, InputActionOrigin origin)
    {
        return GetInstance().Call(Methods.GetActionOriginFromXboxOrigin, inputHandle, (int)origin).As<InputActionOrigin>();
    }
    
    public static List<ulong> GetActiveActionSetLayers(ulong inputHandle)
    {
        var raw = GetInstance().Call(Methods.GetActiveActionSetLayers, inputHandle).AsGodotArray();
        
        return raw.Select(x => x.As<ulong>()).ToList();
    }
    
    public static AnalogActionData? GetAnalogActionData(ulong inputHandle, ulong analogActionHandle)
    {
        var raw = GetInstance().Call(Methods.GetAnalogActionData, inputHandle, analogActionHandle).AsGodotDictionary();
        
        return new AnalogActionData
        {
            Mode = raw["mode"].As<int>(),
            X = raw["x"].As<float>(),
            Y = raw["y"].As<float>(),
            Active = raw["active"].As<bool>(),
        };
    }
    
    public static ulong GetAnalogActionHandle(string actionName)
    {
        return GetInstance().Call(Methods.GetAnalogActionHandle, actionName).As<ulong>();
    }
    
    public static List<int> GetAnalogActionOrigins(ulong inputHandle, ulong actionSetHandle, ulong analogActionHandle)
    {
        var raw = GetInstance().Call(Methods.GetAnalogActionOrigins, inputHandle, actionSetHandle, analogActionHandle).AsGodotArray();
        
        return raw.Select(x => x.As<int>()).ToList();
    }
    
    public static List<ulong> GetConnectedControllers()
    {
        var raw = GetInstance().Call(Methods.GetConnectedControllers).AsGodotArray();
        
        return raw.Select(x => x.As<ulong>()).ToList();
    }
    
    public static ulong GetControllerForGamepadIndex(int index)
    {
        return GetInstance().Call(Methods.GetControllerForGamepadIndex, index).As<ulong>();
    }
    
    public static ulong GetCurrentActionSet(ulong inputHandle)
    {
        return GetInstance().Call(Methods.GetCurrentActionSet, inputHandle).As<ulong>();
    }
    
    public static List<DeviceBindingRevision> GetDeviceBindingRevision(ulong inputHandle)
    {
        var raw = GetInstance().Call(Methods.GetDeviceBindingRevision, inputHandle).AsGodotArray();

        return raw.Select(item => item.AsGodotDictionary()).Select(rawItem => new DeviceBindingRevision
        {
            Major = rawItem["major"].As<int>(),
            Minor = rawItem["minor"].As<int>(),
        }).ToList();
    }
    
    public static DigitalActionData GetDigitalActionData(ulong inputHandle, ulong digitalActionHandle)
    {
        var raw = GetInstance().Call(Methods.GetDigitalActionData, inputHandle, digitalActionHandle).AsGodotDictionary();
        
        return new DigitalActionData
        {
            State = raw["state"].As<bool>(),
            Active = raw["active"].As<bool>(),
        };
    }
    
    public static ulong GetDigitalActionHandle(string actionName)
    {
        return GetInstance().Call(Methods.GetDigitalActionHandle, actionName).As<ulong>();
    }
    
    public static List<int> GetDigitalActionOrigins(ulong inputHandle, ulong actionSetHandle, ulong digitalActionHandle)
    {
        var raw = GetInstance().Call(Methods.GetDigitalActionOrigins, inputHandle, actionSetHandle, digitalActionHandle).AsGodotArray();
        
        
        return raw.Select(x => x.As<int>()).ToList();
    }
    
    public static int GetGamepadIndexForController(ulong inputHandle)
    {
        return GetInstance().Call(Methods.GetGamepadIndexForController, inputHandle).As<int>();
    }
    
    public static string GetGlyphForActionOrigin(InputActionOrigin origin)
    {
        return GetInstance().Call(Methods.GetGlyphForActionOrigin, (long)origin).As<string>();
    }
    
    public static string GetInputTypeForHandle(ulong inputHandle)
    {
        return GetInstance().Call(Methods.GetInputTypeForHandle, inputHandle).As<string>();
    }
    
    public static MotionData GetMotionData(ulong inputHandle)
    {
        var raw = GetInstance().Call(Methods.GetMotionData, inputHandle).AsGodotDictionary();
        
        return new MotionData
        {
            RotationQuaternionX = raw["rot_quat_x"].As<float>(),
            RotationQuaternionY = raw["rot_quat_y"].As<float>(),
            RotationQuaternionZ = raw["rot_quat_z"].As<float>(),
            RotationQuaternionW = raw["rot_quat_w"].As<float>(),
            PositionAccelerationX = raw["pos_accel_x"].As<float>(),
            PositionAccelerationY = raw["pos_accel_y"].As<float>(),
            PositionAccelerationZ = raw["pos_accel_z"].As<float>(),
            RotationVelocityX = raw["rot_vel_x"].As<float>(),
            RotationVelocityY = raw["rot_vel_y"].As<float>(),
            RotationVelocityZ = raw["rot_vel_z"].As<float>(),
        };
    }
    
    public static int GetRemotePlaySessionID(ulong inputHandle)
    {
        return GetInstance().Call(Methods.GetRemotePlaySessionID, inputHandle).As<int>();
    }
    
    public static string GetStringForActionOrigin(InputActionOrigin origin)
    {
        return GetInstance().Call(Methods.GetStringForActionOrigin, (long)origin).As<string>();
    }
    
    public static bool InputInit(bool explicitlyCallRunframe = false)
    {
        return GetInstance().Call(Methods.InputInit, explicitlyCallRunframe).As<bool>();
    }
    
    public static bool InputShutdown()
    {
        return GetInstance().Call(Methods.InputShutdown).As<bool>();
    }
    
    public static void RunFrame()
    {
        GetInstance().Call(Methods.RunFrame);
    }
    
    public static void SetLEDColor(ulong inputHandle, int colorR, int colorG, int colorB, int flags)
    {
        GetInstance().Call(Methods.SetLEDColor, inputHandle, colorR, colorG, colorB, flags);
    }
    
    public static bool ShowBindingPanel(ulong inputHandle)
    {
        return GetInstance().Call(Methods.ShowBindingPanel, inputHandle).As<bool>();
    }
    
    public static void StopAnalogActionMomentum(ulong inputHandle, ulong action)
    {
        GetInstance().Call(Methods.StopAnalogActionMomentum, inputHandle, action);
    }
    
    public static int TranslateActionOrigin(InputType destinationInput, InputActionOrigin sourceOrigin)
    {
        return GetInstance().Call(Methods.TranslateActionOrigin, (int)destinationInput, (int)sourceOrigin).As<int>();
    }
    
    public static void TriggerHapticPulse(ulong inputHandle, int targetPad, long duration)
    {
        GetInstance().Call(Methods.TriggerHapticPulse, inputHandle, targetPad, duration);
    }
    
    public static void TriggerRepeatedHapticPulse(ulong inputHandle, int targetPad, int duration, int offset, int repeat, int flags)
    {
        GetInstance().Call(Methods.TriggerRepeatedHapticPulse, inputHandle, targetPad, duration, offset, repeat, flags);
    }
    
    public static void TriggerVibration(ulong inputHandle, ushort leftSpeed, ushort rightSpeed)
    {
        GetInstance().Call(Methods.TriggerVibration, inputHandle, leftSpeed, rightSpeed);
    }
    
    public static bool SetInputActionManifestFilePath(string manifestPath)
    {
        return GetInstance().Call(Methods.SetInputActionManifestFilePath, manifestPath).As<bool>();
    }
    
    public static void SetDualSenseTriggerEffect(ulong inputHandle, int parameters, int triggerMask, ScePadTriggerEffectMode effectMode, int position, int amplitude, int frequency)
    {
        GetInstance().Call(Methods.SetDualSenseTriggerEffect, inputHandle, parameters, triggerMask, (int)effectMode, position, amplitude, frequency);
    }
    
    public static bool WaitForData(bool waitForever, int timeout)
    {
        return GetInstance().Call(Methods.WaitForData, waitForever, timeout).As<bool>();
    }
    
    public static bool NewDataAvailable()
    {
        return GetInstance().Call(Methods.NewDataAvailable).As<bool>();
    }
    
    public static void EnableDeviceCallbacks()
    {
        GetInstance().Call(Methods.EnableDeviceCallbacks);
    }
    
    public static string GetGlyphPNGForActionOrigin(InputActionOrigin origin, InputGlyphSize size, int flags)
    {
        return GetInstance().Call(Methods.GetGlyphPNGForActionOrigin, (int)origin, (int)size, flags).As<string>();
    }
    
    public static string GetGlyphSVGForActionOrigin(InputActionOrigin origin, int flags)
    {
        return GetInstance().Call(Methods.GetGlyphSVGForActionOrigin, (int)origin, flags).As<string>();
    }
    
    public static void TriggerVibrationExtended(ulong inputHandle, ushort leftSpeed, ushort rightSpeed, ushort leftTriggerSpeed, ushort rightTriggerSpeed)
    {
        GetInstance().Call(Methods.TriggerVibrationExtended, inputHandle, leftSpeed, rightSpeed, leftTriggerSpeed, rightTriggerSpeed);
    }
    
    public static void TriggerSimpleHapticEvent(ulong inputHandle, int hapticLocation, int intensity, string gainDb, int otherIntensity, string otherGainDb)
    {
        GetInstance().Call(Methods.TriggerSimpleHapticEvent, inputHandle, hapticLocation, intensity, gainDb, otherIntensity, otherGainDb);
    }
    
    public static string GetStringForXboxOrigin(long origin)
    {
        return GetInstance().Call(Methods.GetStringForXboxOrigin, origin).As<string>();
    }
    
    public static string GetGlyphForXboxOrigin(long origin)
    {
        return GetInstance().Call(Methods.GetGlyphForXboxOrigin, origin).As<string>();
    }
    
    public static int GetSessionInputConfigurationSettings()
    {
        return GetInstance().Call(Methods.GetSessionInputConfigurationSettings).As<int>();
    }
    
    public static string GetStringForDigitalActionName(int actionHandle)
    {
        return GetInstance().Call(Methods.GetStringForDigitalActionName, actionHandle).As<string>();
    }
    
    public static string GetStringForAnalogActionName(int actionHandle)
    {
        return GetInstance().Call(Methods.GetStringForAnalogActionName, actionHandle).As<string>();
    }

    public enum InputActionEventType : int
    {
        DigitalAction = 0,
        AnalogAction = 1
    }

    [System.Flags]
    public enum InputConfigurationEnableType : long
    {
        None = 0,
        Playstation = 1,
        Xbox = 2,
        Generic = 4,
        Switch = 8
    }

    [System.Flags]
    public enum InputGlyphStyle : long
    {
        Knockout = 0,
        Light = 1,
        Dark = 2,
        NeutralColorAbxy = 16,
        SolidAbxy = 32
    }

    public enum InputLedFlag : long
    {
        SetColor = 0,
        RestoreUserDefault = 1
    }

    public enum InputSourceMode : long
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
        Switch = 16
    }
}