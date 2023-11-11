using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The app installed event handler
    /// </summary>
    public delegate void AppInstalledEventHandler(uint appId, uint installFolderIndex);
    private static event AppInstalledEventHandler AppInstalledEvent;
    /// <summary>
    /// The install folder index
    /// </summary>
    static Action<uint, uint> _appInstalledAction = (appId, installFolderIndex) =>
    {
        AppInstalledEvent?.Invoke(appId, installFolderIndex);
    };
    /// <summary>
    /// The app installed
    /// </summary>
    public static event AppInstalledEventHandler AppInstalled
    {
        add
        {
            if(AppInstalledEvent == null)
            {
                GetInstance().Connect(Signals.AppInstalled, Callable.From(_appInstalledAction));
            }
            AppInstalledEvent += value;
        }
        remove 
        { 
            AppInstalledEvent -= value; 
            if(AppInstalledEvent == null)
            {
                GetInstance().Disconnect(Signals.AppInstalled, Callable.From(_appInstalledAction));
            }
        }
    }
    
    /// <summary>
    /// The app uninstalled event handler
    /// </summary>
    public delegate void AppUninstalledEventHandler(uint appId, uint installFolderIndex);
    private static event AppUninstalledEventHandler AppUninstalledEvent;
    /// <summary>
    /// The install folder index
    /// </summary>
    static Action<uint, uint> _appUninstalledAction = (appId, installFolderIndex) =>
    {
        AppUninstalledEvent?.Invoke(appId, installFolderIndex);
    };
    /// <summary>
    /// The app uninstalled
    /// </summary>
    public static event AppUninstalledEventHandler AppUninstalled
    {
        add
        {
            if(AppUninstalledEvent == null)
            {
                GetInstance().Connect(Signals.AppUninstalled, Callable.From(_appUninstalledAction));
            }
            AppUninstalledEvent += value;
        }
        remove 
        { 
            AppUninstalledEvent -= value; 
            if(AppUninstalledEvent == null)
            {
                GetInstance().Disconnect(Signals.AppUninstalled, Callable.From(_appUninstalledAction));
            }
        }
    }
}