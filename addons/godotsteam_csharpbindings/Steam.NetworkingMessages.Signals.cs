using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The network messages session request event handler
    /// </summary>
    public delegate void NetworkMessagesSessionRequestEventHandler(string identity);
    private static event NetworkMessagesSessionRequestEventHandler NetworkMessagesSessionRequestEvent;
    /// <summary>
    /// The identity
    /// </summary>
    static Action<string> _networkMessagesSessionRequestAction = (identity) =>
    {
        NetworkMessagesSessionRequestEvent?.Invoke(identity);
    };
    /// <summary>
    /// The network messages session request
    /// </summary>
    public static event NetworkMessagesSessionRequestEventHandler NetworkMessagesSessionRequest
    {
        add
        {
            if(NetworkMessagesSessionRequestEvent == null)
            {
                GetInstance().Connect(Signals.NetworkMessagesSessionRequest, Callable.From(_networkMessagesSessionRequestAction));
            }
            
            NetworkMessagesSessionRequestEvent += value;
        }
        remove 
        { 
            NetworkMessagesSessionRequestEvent -= value; 
            
            if(NetworkMessagesSessionRequestEvent == null)
            {
                GetInstance().Disconnect(Signals.NetworkMessagesSessionRequest, Callable.From(_networkMessagesSessionRequestAction));
            }
        }
    }
    
    /// <summary>
    /// The network messages session failed event handler
    /// </summary>
    public delegate void NetworkMessagesSessionFailedEventHandler(long reason);
    private static event NetworkMessagesSessionFailedEventHandler NetworkMessagesSessionFailedEvent;
    /// <summary>
    /// The reason
    /// </summary>
    static Action<long> _networkMessagesSessionFailedAction = (reason) =>
    {
        NetworkMessagesSessionFailedEvent?.Invoke(reason);
    };
    /// <summary>
    /// The network messages session failed
    /// </summary>
    public static event NetworkMessagesSessionFailedEventHandler NetworkMessagesSessionFailed
    {
        add
        {
            if(NetworkMessagesSessionFailedEvent == null)
            {
                GetInstance().Connect(Signals.NetworkMessagesSessionFailed, Callable.From(_networkMessagesSessionFailedAction));
            }
            NetworkMessagesSessionFailedEvent += value;
        }
        remove 
        { 
            NetworkMessagesSessionFailedEvent -= value; 
            if(NetworkMessagesSessionFailedEvent == null)
            {
                GetInstance().Disconnect(Signals.NetworkMessagesSessionFailed, Callable.From(_networkMessagesSessionFailedAction));
            }
        }
    }
}