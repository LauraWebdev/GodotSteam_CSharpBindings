using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The session request event handler
    /// </summary>
    public delegate void P2PSessionRequestEventHandler(ulong steamIdRemote);
    private static event P2PSessionRequestEventHandler P2PSessionRequestEvent;
    /// <summary>
    /// The steam id remote
    /// </summary>
    static Action<ulong> _p2pSessionRequestAction = (steamIdRemote) =>
    {
        P2PSessionRequestEvent?.Invoke(steamIdRemote);
    };
    /// <summary>
    /// The session request
    /// </summary>
    public static event P2PSessionRequestEventHandler P2PSessionRequest
    {
        add
        {
            if(P2PSessionRequestEvent == null)
            {
                GetInstance().Connect(Signals.P2PSessionRequest, Callable.From(_p2pSessionRequestAction));
            }
            P2PSessionRequestEvent += value;
        }
        remove 
        { 
            P2PSessionRequestEvent -= value; 
            if(P2PSessionRequestEvent == null)
            {
                GetInstance().Disconnect(Signals.P2PSessionRequest, Callable.From(_p2pSessionRequestAction));
            }
        }
    }
    
    /// <summary>
    /// The session connect fail event handler
    /// </summary>
    public delegate void P2PSessionConnectFailEventHandler(ulong steamIdRemote, long sessionError);
    private static event P2PSessionConnectFailEventHandler P2PSessionConnectFailEvent;
    /// <summary>
    /// The session error
    /// </summary>
    static Action<ulong, long> _p2pSessionConnectFailAction = (steamIdRemote, sessionError) =>
    {
        P2PSessionConnectFailEvent?.Invoke(steamIdRemote, sessionError);
    };
    /// <summary>
    /// The session connect fail
    /// </summary>
    public static event P2PSessionConnectFailEventHandler P2PSessionConnectFail
    {
        add
        {
            if(P2PSessionConnectFailEvent == null)
            {
                GetInstance().Connect(Signals.P2PSessionConnectFail, Callable.From(_p2pSessionConnectFailAction));
            }
            
            P2PSessionConnectFailEvent += value;
        }
        remove 
        { 
            P2PSessionConnectFailEvent -= value; 
            
            if(P2PSessionConnectFailEvent == null)
            {
                GetInstance().Disconnect(Signals.P2PSessionConnectFail, Callable.From(_p2pSessionConnectFailAction));
            }
        }
    }
}