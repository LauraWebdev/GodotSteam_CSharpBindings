using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void SteamworksErrorEventHandler(string failedSignal, string iOFailure);
    private static event SteamworksErrorEventHandler SteamworksErrorEvent;
    static Action<string, string> _steamworksErrorAction = (failedSignal, iOFailure) =>
    {
        SteamworksErrorEvent?.Invoke(failedSignal, iOFailure);
    };
    public static event SteamworksErrorEventHandler SteamworksError
    {
        add
        {
            if(SteamworksErrorEvent == null)
            {
                GetInstance().Connect(Signals.SteamworksError, Callable.From(_steamworksErrorAction));
            }
            SteamworksErrorEvent += value;
        }
        remove 
        { 
            SteamworksErrorEvent -= value; 
            if(SteamworksErrorEvent == null)
            {
                GetInstance().Disconnect(Signals.SteamworksError, Callable.From(_steamworksErrorAction));
            }
        }
    }
}