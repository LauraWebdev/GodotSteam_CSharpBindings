using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    private static event Action ParentalSettingChangedEvent;
    static Action _parentalSettingChangedAction = () =>
    {
        ParentalSettingChangedEvent?.Invoke();
    };
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