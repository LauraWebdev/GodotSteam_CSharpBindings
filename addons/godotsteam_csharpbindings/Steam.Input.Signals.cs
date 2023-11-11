using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    private static event Action InputActionEventDelegate;
    static Action _inputActionAction = () =>
    {
        InputActionEventDelegate?.Invoke();
    };
    public static event Action InputActionEvent
    {
        add
        {
            if(InputActionEventDelegate == null)
            {
                GetInstance().Connect(Signals.InputActionEvent, Callable.From(_inputActionAction));
            }
            InputActionEventDelegate += value;
        }
        remove
        {
            InputActionEventDelegate -= value;
            if(InputActionEventDelegate == null)
            {
                GetInstance().Disconnect(Signals.InputActionEvent, Callable.From(_inputActionAction));
            }
        }
    }
    
    public delegate void InputDeviceConnectedEventHandler(long inputHandle);
    private static event InputDeviceConnectedEventHandler InputDeviceConnectedEvent;
    static Action<long> _inputDeviceConnectedAction = (inputHandle) =>
    {
        InputDeviceConnectedEvent?.Invoke(inputHandle);
    };
    public static event InputDeviceConnectedEventHandler InputDeviceConnected
    {
        add
        {
            if(InputDeviceConnectedEvent == null)
            {
                GetInstance().Connect(Signals.InputDeviceConnected, Callable.From(_inputDeviceConnectedAction));
            }
            InputDeviceConnectedEvent += value;
        }
        remove 
        { 
            InputDeviceConnectedEvent -= value; 
            if(InputDeviceConnectedEvent == null)
            {
                GetInstance().Disconnect(Signals.InputDeviceConnected, Callable.From(_inputDeviceConnectedAction));
            }
        }
    }
    
    public delegate void InputDeviceDisconnectedEventHandler(long inputHandle);
    private static event InputDeviceDisconnectedEventHandler InputDeviceDisconnectedEvent;
    static Action<long> _inputDeviceDisconnectedAction = (inputHandle) =>
    {
        InputDeviceDisconnectedEvent?.Invoke(inputHandle);
    };
    public static event InputDeviceDisconnectedEventHandler InputDeviceDisconnected
    {
        add
        {
            if(InputDeviceDisconnectedEvent == null)
            {
                GetInstance().Connect(Signals.InputDeviceDisconnected, Callable.From(_inputDeviceDisconnectedAction));
            }
            InputDeviceDisconnectedEvent += value;
        }
        remove
        {
            InputDeviceDisconnectedEvent -= value;
            if(InputDeviceDisconnectedEvent == null)
            {
                GetInstance().Disconnect(Signals.InputDeviceDisconnected, Callable.From(_inputDeviceDisconnectedAction));
            }
        }
    }
    
    public delegate void InputConfigurationLoadedEventHandler(uint appId, long deviceHandle, Godot.Collections.Dictionary configData);
    private static event InputConfigurationLoadedEventHandler InputConfigurationLoadedEvent;
    static Action<uint, long, Godot.Collections.Dictionary> _inputConfigurationLoadedAction = (appId, deviceHandle, configData) =>
    {
        InputConfigurationLoadedEvent?.Invoke(appId, deviceHandle, configData);
    };
    public static event InputConfigurationLoadedEventHandler InputConfigurationLoaded
    {
        add
        {
            if(InputConfigurationLoadedEvent == null)
            {
                GetInstance().Connect(Signals.InputConfigurationLoaded, Callable.From(_inputConfigurationLoadedAction));
            }
            InputConfigurationLoadedEvent += value;
        }
        remove
        {
            InputConfigurationLoadedEvent -= value;
            if(InputConfigurationLoadedEvent == null)
            {
                GetInstance().Disconnect(Signals.InputConfigurationLoaded, Callable.From(_inputConfigurationLoadedAction));
            }
        }
    }
    
    public delegate void InputGamepadSlotChangeEventHandler(uint appId, long deviceHandle, long deviceType, long oldGamepadSlot, long newGamepadSlot);
    private static event InputGamepadSlotChangeEventHandler InputGamepadSlotChangeEvent;
    static Action<uint, long, long, long, long> _inputGamepadSlotChangeAction = (appId, deviceHandle, deviceType, oldGamepadSlot, newGamepadSlot) =>
    {
        InputGamepadSlotChangeEvent?.Invoke(appId, deviceHandle, deviceType, oldGamepadSlot, newGamepadSlot);
    };
    public static event InputGamepadSlotChangeEventHandler InputGamepadSlotChange
    {
        add
        {
            if(InputGamepadSlotChangeEvent == null)
            {
                GetInstance().Connect(Signals.InputGamepadSlotChange, Callable.From(_inputGamepadSlotChangeAction));
            }
            InputGamepadSlotChangeEvent += value;
        }
        remove
        {
            InputGamepadSlotChangeEvent -= value;
            if(InputGamepadSlotChangeEvent == null)
            {
                GetInstance().Disconnect(Signals.InputGamepadSlotChange, Callable.From(_inputGamepadSlotChangeAction));
            }
        }
    }
}