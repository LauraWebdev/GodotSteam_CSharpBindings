using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void AppInstalledEventHandler(long appId, long installFolderIndex);
    private static event AppInstalledEventHandler AppInstalledEvent;
    static Action<long, long> _appInstalledAction = (appId, installFolderIndex) =>
    {
        AppInstalledEvent?.Invoke(appId, installFolderIndex);
    };
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
    
    public delegate void AppUninstalledEventHandler(long appId, long installFolderIndex);
    private static event AppUninstalledEventHandler AppUninstalledEvent;
    static Action<long, long> _appUninstalledAction = (appId, installFolderIndex) =>
    {
        AppUninstalledEvent?.Invoke(appId, installFolderIndex);
    };
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