using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    [Obsolete]
    public delegate void P2PSessionRequestEventHandler(ulong steamIdRemote);
    [Obsolete]
    private static event P2PSessionRequestEventHandler P2PSessionRequestEvent;
    [Obsolete]
    static Action<ulong> _p2pSessionRequestAction = (steamIdRemote) =>
    {
        P2PSessionRequestEvent?.Invoke(steamIdRemote);
    };
    [Obsolete]
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
    
    [Obsolete]
    public delegate void P2PSessionConnectFailEventHandler(ulong steamIdRemote, long sessionError);
    [Obsolete]
    private static event P2PSessionConnectFailEventHandler P2PSessionConnectFailEvent;
    [Obsolete]
    static Action<ulong, long> _p2pSessionConnectFailAction = (steamIdRemote, sessionError) =>
    {
        P2PSessionConnectFailEvent?.Invoke(steamIdRemote, sessionError);
    };
    [Obsolete]
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