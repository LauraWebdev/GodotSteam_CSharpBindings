using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The relay network status event handler
    /// </summary>
    public delegate void RelayNetworkStatusEventHandler(long available, long pingMeasurement, long availableConfig, long availableRelay, string debugMessage);
    private static event RelayNetworkStatusEventHandler RelayNetworkStatusEvent;
    /// <summary>
    /// The debug message
    /// </summary>
    static Action<long, long, long, long, string> _relayNetworkStatusAction = (available, pingMeasurement, availableConfig, availableRelay, debugMessage) =>
    {
        RelayNetworkStatusEvent?.Invoke(available, pingMeasurement, availableConfig, availableRelay, debugMessage);
    };
    /// <summary>
    /// The relay network status
    /// </summary>
    public static event RelayNetworkStatusEventHandler RelayNetworkStatus
    {
        add
        {
            if(RelayNetworkStatusEvent == null)
            {
                GetInstance().Connect(Signals.RelayNetworkStatus, Callable.From(_relayNetworkStatusAction));
            }
            
            RelayNetworkStatusEvent += value;
        }
        remove 
        { 
            RelayNetworkStatusEvent -= value; 
            
            if(RelayNetworkStatusEvent == null)
            {
                GetInstance().Disconnect(Signals.RelayNetworkStatus, Callable.From(_relayNetworkStatusAction));
            }
        }
    }
}