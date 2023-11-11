using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The network connection status changed event handler
    /// </summary>
    public delegate void NetworkConnectionStatusChangedEventHandler(long connectHandle, Godot.Collections.Dictionary connection, long oldState);
    private static event NetworkConnectionStatusChangedEventHandler NetworkConnectionStatusChangedEvent;
    /// <summary>
    /// The old state
    /// </summary>
    static Action<long, Godot.Collections.Dictionary, long> _networkConnectionStatusChangedAction = (connectHandle, connection, oldState) =>
    {
        NetworkConnectionStatusChangedEvent?.Invoke(connectHandle, connection, oldState);
    };
    /// <summary>
    /// The network connection status changed
    /// </summary>
    public static event NetworkConnectionStatusChangedEventHandler NetworkConnectionStatusChanged
    {
        add
        {
            if(NetworkConnectionStatusChangedEvent == null)
            {
                GetInstance().Connect(Signals.NetworkConnectionStatusChanged, Callable.From(_networkConnectionStatusChangedAction));
            }
            
            NetworkConnectionStatusChangedEvent += value;
        }
        remove 
        { 
            NetworkConnectionStatusChangedEvent -= value; 
            
            if(NetworkConnectionStatusChangedEvent == null)
            {
                GetInstance().Disconnect(Signals.NetworkConnectionStatusChanged, Callable.From(_networkConnectionStatusChangedAction));
            }
        }
    }
    
    /// <summary>
    /// The network authentication status event handler
    /// </summary>
    public delegate void NetworkAuthenticationStatusEventHandler(long available, string debugMessage);
    private static event NetworkAuthenticationStatusEventHandler NetworkAuthenticationStatusEvent;
    /// <summary>
    /// The debug message
    /// </summary>
    static Action<long, string> _networkAuthenticationStatusAction = (available, debugMessage) =>
    {
        NetworkAuthenticationStatusEvent?.Invoke(available, debugMessage);
    };
    /// <summary>
    /// The network authentication status
    /// </summary>
    public static event NetworkAuthenticationStatusEventHandler NetworkAuthenticationStatus
    {
        add
        {
            if(NetworkAuthenticationStatusEvent == null)
            {
                GetInstance().Connect(Signals.NetworkAuthenticationStatus, Callable.From(_networkAuthenticationStatusAction));
            }
            
            NetworkAuthenticationStatusEvent += value;
        }
        remove 
        { 
            NetworkAuthenticationStatusEvent -= value; 
            
            if(NetworkAuthenticationStatusEvent == null)
            {
                GetInstance().Disconnect(Signals.NetworkAuthenticationStatus, Callable.From(_networkAuthenticationStatusAction));
            }
        }
    }
    
    /// <summary>
    /// The fake ip result event handler
    /// </summary>
    public delegate void FakeIPResultEventHandler(long result, string identity, string fakeIP, Godot.Collections.Array portList);
    private static event FakeIPResultEventHandler FakeIPResultEvent;
    /// <summary>
    /// The port list
    /// </summary>
    static Action<long, string, string, Godot.Collections.Array> _fakeIPResultAction = (result, identity, fakeIP, portList) =>
    {
        FakeIPResultEvent?.Invoke(result, identity, fakeIP, portList);
    };
    /// <summary>
    /// The fake ip result
    /// </summary>
    public static event FakeIPResultEventHandler FakeIPResult
    {
        add
        {
            if(FakeIPResultEvent == null)
            {
                GetInstance().Connect(Signals.FakeIPResult, Callable.From(_fakeIPResultAction));
            }
            
            FakeIPResultEvent += value;
        }
        remove 
        { 
            FakeIPResultEvent -= value; 
            
            if(FakeIPResultEvent == null)
            {
                GetInstance().Disconnect(Signals.FakeIPResult, Callable.From(_fakeIPResultAction));
            }
        }
    }
}