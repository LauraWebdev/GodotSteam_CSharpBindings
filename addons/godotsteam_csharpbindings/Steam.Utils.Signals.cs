using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void CheckFileSignatureEventHandler(string signature);
    private static event CheckFileSignatureEventHandler CheckFileSignatureEvent;
    static Action<string> _checkFileSignatureAction = (signature) =>
    {
        CheckFileSignatureEvent?.Invoke(signature);
    };
    public static event CheckFileSignatureEventHandler CheckFileSignature
    {
        add
        {
            if(CheckFileSignatureEvent == null)
            {
                GetInstance().Connect(Signals.CheckFileSignature, Callable.From(_checkFileSignatureAction));
            }
            CheckFileSignatureEvent += value;
        }
        remove 
        { 
            CheckFileSignatureEvent -= value;
            if(CheckFileSignatureEvent == null)
            {
                GetInstance().Disconnect(Signals.CheckFileSignature, Callable.From(_checkFileSignatureAction));
            }
        }
    }
    
    public delegate void GamepadTextInputDismissedEventHandler(bool submitted, string enteredText, uint appId);
    private static event GamepadTextInputDismissedEventHandler GamepadTextInputDismissedEvent;
    static Action<bool, string, uint> _gamepadTextInputDismissedAction = (submitted, enteredText, appId) =>
    {
        GamepadTextInputDismissedEvent?.Invoke(submitted, enteredText, appId);
    };
    public static event GamepadTextInputDismissedEventHandler GamepadTextInputDismissed
    {
        add
        {
            if(GamepadTextInputDismissedEvent == null)
            {
                GetInstance().Connect(Signals.GamepadTextInputDismissed, Callable.From(_gamepadTextInputDismissedAction));
            }
            GamepadTextInputDismissedEvent += value;
        }
        remove 
        { 
            GamepadTextInputDismissedEvent -= value; 
            if(GamepadTextInputDismissedEvent == null)
            {
                GetInstance().Disconnect(Signals.GamepadTextInputDismissed, Callable.From(_gamepadTextInputDismissedAction));
            }
        }
    }
    
    private static event Action IPCountryEvent;
    static Action _iPCountryAction = () =>
    {
        IPCountryEvent?.Invoke();
    };
    public static event Action IPCountry
    {
        add
        {
            if(IPCountryEvent == null)
            {
                GetInstance().Connect(Signals.IPCountry, Callable.From(_iPCountryAction));
            }
            IPCountryEvent += value;
        }
        remove
        {
            IPCountryEvent -= value; 
            if(IPCountryEvent == null)
            {
                GetInstance().Disconnect(Signals.IPCountry, Callable.From(_iPCountryAction));
            }
        }
    }
    
    public delegate void LowPowerEventHandler(byte power);
    private static event LowPowerEventHandler LowPowerEvent;
    static Action<byte> _lowPowerAction = (power) =>
    {
        LowPowerEvent?.Invoke(power);
    };
    public static event LowPowerEventHandler LowPower
    {
        add
        {
            if(LowPowerEvent == null)
            {
                GetInstance().Connect(Signals.LowPower, Callable.From(_lowPowerAction));
            }
            LowPowerEvent += value;
        }
        remove 
        { 
            LowPowerEvent -= value;
            if(LowPowerEvent == null)
            {
                GetInstance().Disconnect(Signals.LowPower, Callable.From(_lowPowerAction));
            }
        }
    }
    
    public delegate void SteamApiCallCompletedEventHandler(ulong asyncCall, int callback, uint parameter);
    private static event SteamApiCallCompletedEventHandler SteamApiCallCompletedEvent;
    static Action<ulong, int, uint> _steamApiCallCompletedAction = (asyncCall, callback, parameter) =>
    {
        SteamApiCallCompletedEvent?.Invoke(asyncCall, callback, parameter);
    };
    public static event SteamApiCallCompletedEventHandler SteamApiCallCompleted
    {
        add
        {
            if(SteamApiCallCompletedEvent == null)
            {
                GetInstance().Connect(Signals.SteamApiCallCompleted, Callable.From(_steamApiCallCompletedAction));
            }
            SteamApiCallCompletedEvent += value;
        }
        remove 
        { 
            SteamApiCallCompletedEvent -= value; 
            if(SteamApiCallCompletedEvent == null)
            {
                GetInstance().Disconnect(Signals.SteamApiCallCompleted, Callable.From(_steamApiCallCompletedAction));
            }
        }
    }
    
    private static event Action SteamShutdownSignalEvent;
    static Action _steamShutdownSignalAction = () =>
    {
        SteamShutdownSignalEvent?.Invoke();
    };
    public static event Action SteamShutdownSignal
    {
        add
        {
            if(SteamShutdownSignalEvent == null)
            {
                GetInstance().Connect(Signals.SteamShutdownSignal, Callable.From(_steamShutdownSignalAction));
            }
            SteamShutdownSignalEvent += value;
        }
        remove
        {
            SteamShutdownSignalEvent -= value; 
            if(SteamShutdownSignalEvent == null)
            {
                GetInstance().Disconnect(Signals.SteamShutdownSignal, Callable.From(_steamShutdownSignalAction));
            }
        }
    }
    
    private static event Action AppResumingFromSuspendEvent;
    static Action _appResumingFromSuspendAction = () =>
    {
        AppResumingFromSuspendEvent?.Invoke();
    };
    public static event Action AppResumingFromSuspend
    {
        add
        {
            if(AppResumingFromSuspendEvent == null)
            {
                GetInstance().Connect(Signals.AppResumingFromSuspend, Callable.From(_appResumingFromSuspendAction));
            }
            AppResumingFromSuspendEvent += value;
        }
        remove
        {
            AppResumingFromSuspendEvent -= value;
            if(AppResumingFromSuspendEvent == null)
            {
                GetInstance().Disconnect(Signals.AppResumingFromSuspend, Callable.From(_appResumingFromSuspendAction));
            }
        }
    }
    
    private static event Action FloatingGamepadTextInputDismissedEvent;
    static Action _floatingGamepadTextInputDismissedAction = () =>
    {
        FloatingGamepadTextInputDismissedEvent?.Invoke();
    };
    public static event Action FloatingGamepadTextInputDismissed
    {
        add
        {
            if(FloatingGamepadTextInputDismissedEvent == null)
            {
                GetInstance().Connect(Signals.FloatingGamepadTextInputDismissed, Callable.From(_floatingGamepadTextInputDismissedAction));
            }
            FloatingGamepadTextInputDismissedEvent += value;
        }
        remove
        {
            FloatingGamepadTextInputDismissedEvent -= value;
            if(FloatingGamepadTextInputDismissedEvent == null)
            {
                GetInstance().Disconnect(Signals.FloatingGamepadTextInputDismissed, Callable.From(_floatingGamepadTextInputDismissedAction));
            }
        }
    }
    
    public delegate void FilterTextDictionaryChangedEventHandler(long language);
    private static event FilterTextDictionaryChangedEventHandler FilterTextDictionaryChangedEvent;
    static Action<long> _filterTextDictionaryChangedAction = (language) =>
    {
        FilterTextDictionaryChangedEvent?.Invoke(language);
    };
    public static event FilterTextDictionaryChangedEventHandler FilterTextDictionaryChanged
    {
        add
        {
            if(FilterTextDictionaryChangedEvent == null)
            {
                GetInstance().Connect(Signals.FilterTextDictionaryChanged, Callable.From(_filterTextDictionaryChangedAction));
            }
            FilterTextDictionaryChangedEvent += value;
        }
        remove 
        { 
            FilterTextDictionaryChangedEvent -= value;
            if(FilterTextDictionaryChangedEvent == null)
            {
                GetInstance().Disconnect(Signals.FilterTextDictionaryChanged, Callable.From(_filterTextDictionaryChangedAction));
            }
        }
    }
}