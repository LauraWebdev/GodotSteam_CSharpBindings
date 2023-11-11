using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The screenshot ready event handler
    /// </summary>
    public delegate void ScreenshotReadyEventHandler(uint handle, ErrorResult result);
    private static event ScreenshotReadyEventHandler ScreenshotReadyEvent;
    /// <summary>
    /// The result
    /// </summary>
    static Action<uint, int> _screenshotReadyAction = (handle, result) =>
    {
        ScreenshotReadyEvent?.Invoke(handle, (ErrorResult)result);
    };
    /// <summary>
    /// The screenshot ready
    /// </summary>
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
    /// <summary>
    /// The invoke
    /// </summary>
    static Action _screenshotRequestedAction = () =>
    {
        ScreenshotRequestedEvent?.Invoke();
    };
    /// <summary>
    /// The screenshot requested
    /// </summary>
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