using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    private static event Action ParentalSettingChangedEvent;
    /// <summary>
    /// The invoke
    /// </summary>
    static Action _parentalSettingChangedAction = () =>
    {
        ParentalSettingChangedEvent?.Invoke();
    };
    /// <summary>
    /// The parental setting changed
    /// </summary>
    public static event Action ParentalSettingChanged
    {
        add
        {
            if(ParentalSettingChangedEvent == null)
            {
                GetInstance().Connect(Signals.ParentalSettingChanged, Callable.From(_parentalSettingChangedAction));
            }
            
            ParentalSettingChangedEvent += value;
        }
        remove 
        { 
            ParentalSettingChangedEvent -= value; 
            
            if(ParentalSettingChangedEvent == null)
            {
                GetInstance().Disconnect(Signals.ParentalSettingChanged, Callable.From(_parentalSettingChangedAction));
            }
        }
    }
}