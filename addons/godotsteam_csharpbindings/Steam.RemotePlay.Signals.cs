using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The remote play session connected event handler
    /// </summary>
    public delegate void RemotePlaySessionConnectedEventHandler(long sessionId);
    private static event RemotePlaySessionConnectedEventHandler RemotePlaySessionConnectedEvent;
    /// <summary>
    /// The session id
    /// </summary>
    static Action<long> _remotePlaySessionConnectedAction = (sessionId) =>
    {
        RemotePlaySessionConnectedEvent?.Invoke(sessionId);
    };
    /// <summary>
    /// The remote play session connected
    /// </summary>
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
    
    /// <summary>
    /// The remote play session disconnected event handler
    /// </summary>
    public delegate void RemotePlaySessionDisconnectedEventHandler(long sessionId);
    private static event RemotePlaySessionDisconnectedEventHandler RemotePlaySessionDisconnectedEvent;
    /// <summary>
    /// The session id
    /// </summary>
    static Action<long> _remotePlaySessionDisconnectedAction = (sessionId) =>
    {
        RemotePlaySessionDisconnectedEvent?.Invoke(sessionId);
    };
    /// <summary>
    /// The remote play session disconnected
    /// </summary>
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