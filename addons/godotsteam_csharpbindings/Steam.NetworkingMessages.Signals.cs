using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void NetworkMessagesSessionRequestEventHandler(ulong remoteSteamId);
    private static event NetworkMessagesSessionRequestEventHandler NetworkMessagesSessionRequestEvent;
    static Action<ulong> _networkMessagesSessionRequestAction = (remoteSteamId) =>
    {
        NetworkMessagesSessionRequestEvent?.Invoke(remoteSteamId);
    };
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
    
    public delegate void NetworkMessagesSessionFailedEventHandler(long reason);
    private static event NetworkMessagesSessionFailedEventHandler NetworkMessagesSessionFailedEvent;
    static Action<long> _networkMessagesSessionFailedAction = (reason) =>
    {
        NetworkMessagesSessionFailedEvent?.Invoke(reason);
    };
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