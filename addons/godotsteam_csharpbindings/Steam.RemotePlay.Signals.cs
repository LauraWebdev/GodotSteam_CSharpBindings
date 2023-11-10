using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void RemotePlaySessionConnectedEventHandler(long sessionId);
    private static event RemotePlaySessionConnectedEventHandler RemotePlaySessionConnectedEvent;
    static Action<long> _remotePlaySessionConnectedAction = (sessionId) =>
    {
        RemotePlaySessionConnectedEvent?.Invoke(sessionId);
    };
    public static event RemotePlaySessionConnectedEventHandler RemotePlaySessionConnected
    {
        add
        {
            if(RemotePlaySessionConnectedEvent == null)
            {
                GetInstance().Connect(Signals.RemotePlaySessionConnected, Callable.From(_remotePlaySessionConnectedAction));
            }
            RemotePlaySessionConnectedEvent += value;
        }
        remove
        {
            RemotePlaySessionConnectedEvent -= value;
            if(RemotePlaySessionConnectedEvent == null)
            {
                GetInstance().Disconnect(Signals.RemotePlaySessionConnected, Callable.From(_remotePlaySessionConnectedAction));
            }
        }
    }
    
    public delegate void RemotePlaySessionDisconnectedEventHandler(long sessionId);
    private static event RemotePlaySessionDisconnectedEventHandler RemotePlaySessionDisconnectedEvent;
    static Action<long> _remotePlaySessionDisconnectedAction = (sessionId) =>
    {
        RemotePlaySessionDisconnectedEvent?.Invoke(sessionId);
    };
    public static event RemotePlaySessionDisconnectedEventHandler RemotePlaySessionDisconnected
    {
        add
        {
            if(RemotePlaySessionDisconnectedEvent == null)
            {
                GetInstance().Connect(Signals.RemotePlaySessionDisconnected, Callable.From(_remotePlaySessionDisconnectedAction));
            }
            RemotePlaySessionDisconnectedEvent += value;
        }
        remove
        {
            RemotePlaySessionDisconnectedEvent -= value;
            if(RemotePlaySessionDisconnectedEvent == null)
            {
                GetInstance().Disconnect(Signals.RemotePlaySessionDisconnected, Callable.From(_remotePlaySessionDisconnectedAction));
            }
        }
    }
}