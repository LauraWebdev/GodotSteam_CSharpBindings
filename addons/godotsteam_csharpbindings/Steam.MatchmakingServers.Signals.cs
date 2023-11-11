using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    public static event Action ServerRespondedEvent;
    /// <summary>
    /// The invoke
    /// </summary>
    static Action _serverRespondedAction = () =>
    {
        ServerRespondedEvent?.Invoke();
    };
    /// <summary>
    /// The server responded
    /// </summary>
    public static event Action ServerResponded
    {
        add
        {
            if(ServerRespondedEvent == null)
            {
                GetInstance().Connect(Signals.ServerResponded, Callable.From(_serverRespondedAction));
            }
            ServerRespondedEvent += value;
        }
        remove
        {
            ServerRespondedEvent -= value;
            if(ServerRespondedEvent == null)
            {
                GetInstance().Disconnect(Signals.ServerResponded, Callable.From(_serverRespondedAction));
            }
        }
    }
    
    public static event Action ServerFailedToRespondEvent;
    /// <summary>
    /// The invoke
    /// </summary>
    static Action _serverFailedToRespondAction = () =>
    {
        ServerFailedToRespondEvent?.Invoke();
    };
    /// <summary>
    /// The server failed to respond
    /// </summary>
    public static event Action ServerFailedToRespond
    {
        add
        {
            if(ServerFailedToRespondEvent == null)
            {
                GetInstance().Connect(Signals.ServerFailedToRespond, Callable.From(_serverFailedToRespondAction));
            }
            ServerFailedToRespondEvent += value;
        }
        remove
        {
            ServerFailedToRespondEvent -= value;
            if(ServerFailedToRespondEvent == null)
            {
                GetInstance().Disconnect(Signals.ServerFailedToRespond, Callable.From(_serverFailedToRespondAction));
            }
        }
    }
}