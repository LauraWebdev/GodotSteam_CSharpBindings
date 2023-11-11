using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The steamworks error event handler
    /// </summary>
    public delegate void SteamworksErrorEventHandler(string failedSignal, string iOFailure);
    private static event SteamworksErrorEventHandler SteamworksErrorEvent;
    /// <summary>
    /// The failure
    /// </summary>
    static Action<string, string> _steamworksErrorAction = (failedSignal, iOFailure) =>
    {
        SteamworksErrorEvent?.Invoke(failedSignal, iOFailure);
    };
    /// <summary>
    /// The steamworks error
    /// </summary>
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