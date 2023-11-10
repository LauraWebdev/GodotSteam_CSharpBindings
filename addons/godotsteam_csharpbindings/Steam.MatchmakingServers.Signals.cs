using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public static event Action ServerRespondedEvent;
    static Action _serverRespondedAction = () =>
    {
        ServerRespondedEvent?.Invoke();
    };
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
    static Action _serverFailedToRespondAction = () =>
    {
        ServerFailedToRespondEvent?.Invoke();
    };
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