using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void ScreenshotReadyEventHandler(uint handle, ErrorResult result);
    private static event ScreenshotReadyEventHandler ScreenshotReadyEvent;
    static Action<uint, int> _screenshotReadyAction = (handle, result) =>
    {
        ScreenshotReadyEvent?.Invoke(handle, (ErrorResult)result);
    };
    public static event ScreenshotReadyEventHandler ScreenshotReady
    {
        add
        {
            if(ScreenshotReadyEvent == null)
            {
                GetInstance().Connect(Signals.ScreenshotReady, Callable.From(_screenshotReadyAction));
            }
            ScreenshotReadyEvent += value;
        }
        remove
        {
            ScreenshotReadyEvent -= value;
            if(ScreenshotReadyEvent == null)
            {
                GetInstance().Disconnect(Signals.ScreenshotReady, Callable.From(_screenshotReadyAction));
            }
        }
    }
    
    private static event Action ScreenshotRequestedEvent;
    static Action _screenshotRequestedAction = () =>
    {
        ScreenshotRequestedEvent?.Invoke();
    };
    public static event Action ScreenshotRequested
    {
        add
        {
            if(ScreenshotRequestedEvent == null)
            {
                GetInstance().Connect(Signals.ScreenshotRequested, Callable.From(_screenshotRequestedAction));
            }
            ScreenshotRequestedEvent += value;
        }
        remove
        {
            ScreenshotRequestedEvent -= value;
            if(ScreenshotRequestedEvent == null)
            {
                GetInstance().Disconnect(Signals.ScreenshotRequested, Callable.From(_screenshotRequestedAction));
            }
        }
    }
}