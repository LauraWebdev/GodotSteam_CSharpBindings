using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The html browser ready event handler
    /// </summary>
    public delegate void HtmlBrowserReadyEventHandler(long browserHandle);
    private static event HtmlBrowserReadyEventHandler HtmlBrowserReadyEvent;
    /// <summary>
    /// The browser handle
    /// </summary>
    static Action<long> _htmlBrowserReadyAction = (browserHandle) =>
    {
        HtmlBrowserReadyEvent?.Invoke(browserHandle);
    };
    /// <summary>
    /// The html browser ready
    /// </summary>
    public static event HtmlBrowserReadyEventHandler HtmlBrowserReady
    {
        add
        {
            if(HtmlBrowserReadyEvent == null)
            {
                GetInstance().Connect(Signals.HtmlBrowserReady, Callable.From(_htmlBrowserReadyAction));
            }
            HtmlBrowserReadyEvent += value;
        }
        remove
        {
            HtmlBrowserReadyEvent -= value; 
            if(HtmlBrowserReadyEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlBrowserReady, Callable.From(_htmlBrowserReadyAction));
            }
        }
    }
    
    /// <summary>
    /// The html can go backandforward event handler
    /// </summary>
    public delegate void HtmlCanGoBackandforwardEventHandler(long browserHandle, bool goBack, bool goForward);
    private static event HtmlCanGoBackandforwardEventHandler HtmlCanGoBackandforwardEvent;
    /// <summary>
    /// The go forward
    /// </summary>
    static Action<long, bool, bool> _htmlCanGoBackandforwardAction = (browserHandle, goBack, goForward) =>
    {
        HtmlCanGoBackandforwardEvent?.Invoke(browserHandle, goBack, goForward);
    };
    /// <summary>
    /// The html can go backandforward
    /// </summary>
    public static event HtmlCanGoBackandforwardEventHandler HtmlCanGoBackandforward
    {
        add
        {
            if(HtmlCanGoBackandforwardEvent == null)
            {
                GetInstance().Connect(Signals.HtmlCanGoBackandforward, Callable.From(_htmlCanGoBackandforwardAction));
            }
            HtmlCanGoBackandforwardEvent += value;
        }
        remove
        {
            HtmlCanGoBackandforwardEvent -= value; 
            if(HtmlCanGoBackandforwardEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlCanGoBackandforward, Callable.From(_htmlCanGoBackandforwardAction));
            }
        }
    }
    
    /// <summary>
    /// The html changed title event handler
    /// </summary>
    public delegate void HtmlChangedTitleEventHandler(long browserHandle, string title);
    private static event HtmlChangedTitleEventHandler HtmlChangedTitleEvent;
    /// <summary>
    /// The title
    /// </summary>
    static Action<long, string> _htmlChangedTitleAction = (browserHandle, title) =>
    {
        HtmlChangedTitleEvent?.Invoke(browserHandle, title);
    };
    /// <summary>
    /// The html changed title
    /// </summary>
    public static event HtmlChangedTitleEventHandler HtmlChangedTitle
    {
        add
        {
            if(HtmlChangedTitleEvent == null)
            {
                GetInstance().Connect(Signals.HtmlChangedTitle, Callable.From(_htmlChangedTitleAction));
            }
            HtmlChangedTitleEvent += value;
        }
        remove
        {
            HtmlChangedTitleEvent -= value; 
            if(HtmlChangedTitleEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlChangedTitle, Callable.From(_htmlChangedTitleAction));
            }
        }
    }
    
    /// <summary>
    /// The html close browser event handler
    /// </summary>
    public delegate void HtmlCloseBrowserEventHandler(long browserHandle);
    private static event HtmlCloseBrowserEventHandler HtmlCloseBrowserEvent;
    /// <summary>
    /// The browser handle
    /// </summary>
    static Action<long> _htmlCloseBrowserAction = (browserHandle) =>
    {
        HtmlCloseBrowserEvent?.Invoke(browserHandle);
    };
    /// <summary>
    /// The html close browser
    /// </summary>
    public static event HtmlCloseBrowserEventHandler HtmlCloseBrowser
    {
        add
        {
            if(HtmlCloseBrowserEvent == null)
            {
                GetInstance().Connect(Signals.HtmlCloseBrowser, Callable.From(_htmlCloseBrowserAction));
            }
            HtmlCloseBrowserEvent += value;
        }
        remove
        {
            HtmlCloseBrowserEvent -= value; 
            if(HtmlCloseBrowserEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlCloseBrowser, Callable.From(_htmlCloseBrowserAction));
            }
        }
    }
    
    /// <summary>
    /// The html file open dialog event handler
    /// </summary>
    public delegate void HtmlFileOpenDialogEventHandler(long browserHandle, string title, string initialFile);
    private static event HtmlFileOpenDialogEventHandler HtmlFileOpenDialogEvent;
    /// <summary>
    /// The initial file
    /// </summary>
    static Action<long, string, string> _htmlFileOpenDialogAction = (browserHandle, title, initialFile) =>
    {
        HtmlFileOpenDialogEvent?.Invoke(browserHandle, title, initialFile);
    };
    /// <summary>
    /// The html file open dialog
    /// </summary>
    public static event HtmlFileOpenDialogEventHandler HtmlFileOpenDialog
    {
        add
        {
            if(HtmlFileOpenDialogEvent == null)
            {
                GetInstance().Connect(Signals.HtmlFileOpenDialog, Callable.From(_htmlFileOpenDialogAction));
            }
            HtmlFileOpenDialogEvent += value;
        }
        remove
        {
            HtmlFileOpenDialogEvent -= value; 
            if(HtmlFileOpenDialogEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlFileOpenDialog, Callable.From(_htmlFileOpenDialogAction));
            }
        }
    }
    
    /// <summary>
    /// The html finished request event handler
    /// </summary>
    public delegate void HtmlFinishedRequestEventHandler(long browserHandle, string url, string title);
    private static event HtmlFinishedRequestEventHandler HtmlFinishedRequestEvent;
    /// <summary>
    /// The title
    /// </summary>
    static Action<long, string, string> _htmlFinishedRequestAction = (browserHandle, url, title) =>
    {
        HtmlFinishedRequestEvent?.Invoke(browserHandle, url, title);
    };
    /// <summary>
    /// The html finished request
    /// </summary>
    public static event HtmlFinishedRequestEventHandler HtmlFinishedRequest
    {
        add
        {
            if(HtmlFinishedRequestEvent == null)
            {
                GetInstance().Connect(Signals.HtmlFinishedRequest, Callable.From(_htmlFinishedRequestAction));
            }
            HtmlFinishedRequestEvent += value;
        }
        remove
        {
            HtmlFinishedRequestEvent -= value; 
            if(HtmlFinishedRequestEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlFinishedRequest, Callable.From(_htmlFinishedRequestAction));
            }
        }
    }
    
    /// <summary>
    /// The html hide tooltip event handler
    /// </summary>
    public delegate void HtmlHideTooltipEventHandler(long browserHandle);
    private static event HtmlHideTooltipEventHandler HtmlHideTooltipEvent;
    /// <summary>
    /// The browser handle
    /// </summary>
    static Action<long> _htmlHideTooltipAction = (browserHandle) =>
    {
        HtmlHideTooltipEvent?.Invoke(browserHandle);
    };
    /// <summary>
    /// The html hide tooltip
    /// </summary>
    public static event HtmlHideTooltipEventHandler HtmlHideTooltip
    {
        add
        {
            if(HtmlHideTooltipEvent == null)
            {
                GetInstance().Connect(Signals.HtmlHideTooltip, Callable.From(_htmlHideTooltipAction));
            }
            HtmlHideTooltipEvent += value;
        }
        remove
        {
            HtmlHideTooltipEvent -= value; 
            if(HtmlHideTooltipEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlHideTooltip, Callable.From(_htmlHideTooltipAction));
            }
        }
    }
    
    /// <summary>
    /// The html horizontal scroll event handler
    /// </summary>
    public delegate void HtmlHorizontalScrollEventHandler(long browserHandle, Godot.Collections.Dictionary scrollData);
    private static event HtmlHorizontalScrollEventHandler HtmlHorizontalScrollEvent;
    /// <summary>
    /// The scroll data
    /// </summary>
    static Action<long, Godot.Collections.Dictionary> _htmlHorizontalScrollAction = (browserHandle, scrollData) =>
    {
        HtmlHorizontalScrollEvent?.Invoke(browserHandle, scrollData);
    };
    /// <summary>
    /// The html horizontal scroll
    /// </summary>
    public static event HtmlHorizontalScrollEventHandler HtmlHorizontalScroll
    {
        add
        {
            if(HtmlHorizontalScrollEvent == null)
            {
                GetInstance().Connect(Signals.HtmlHorizontalScroll, Callable.From(_htmlHorizontalScrollAction));
            }
            HtmlHorizontalScrollEvent += value;
        }
        remove
        {
            HtmlHorizontalScrollEvent -= value; 
            if(HtmlHorizontalScrollEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlHorizontalScroll, Callable.From(_htmlHorizontalScrollAction));
            }
        }
    }
    
    /// <summary>
    /// The html js alert event handler
    /// </summary>
    public delegate void HtmlJsAlertEventHandler(long browserHandle, string message);
    private static event HtmlJsAlertEventHandler HtmlJsAlertEvent;
    /// <summary>
    /// The message
    /// </summary>
    static Action<long, string> _htmlJsAlertAction = (browserHandle, message) =>
    {
        HtmlJsAlertEvent?.Invoke(browserHandle, message);
    };
    /// <summary>
    /// The html js alert
    /// </summary>
    public static event HtmlJsAlertEventHandler HtmlJsAlert
    {
        add
        {
            if(HtmlJsAlertEvent == null)
            {
                GetInstance().Connect(Signals.HtmlJsAlert, Callable.From(_htmlJsAlertAction));
            }
            HtmlJsAlertEvent += value;
        }
        remove
        {
            HtmlJsAlertEvent -= value; 
            if(HtmlJsAlertEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlJsAlert, Callable.From(_htmlJsAlertAction));
            }
        }
    }
    
    /// <summary>
    /// The html js confirm event handler
    /// </summary>
    public delegate void HtmlJsConfirmEventHandler(long browserHandle, string message);
    private static event HtmlJsConfirmEventHandler HtmlJsConfirmEvent;
    /// <summary>
    /// The message
    /// </summary>
    static Action<long, string> _htmlJsConfirmAction = (browserHandle, message) =>
    {
        HtmlJsConfirmEvent?.Invoke(browserHandle, message);
    };
    /// <summary>
    /// The html js confirm
    /// </summary>
    public static event HtmlJsConfirmEventHandler HtmlJsConfirm
    {
        add
        {
            if(HtmlJsConfirmEvent == null)
            {
                GetInstance().Connect(Signals.HtmlJsConfirm, Callable.From(_htmlJsConfirmAction));
            }
            HtmlJsConfirmEvent += value;
        }
        remove
        {
            HtmlJsConfirmEvent -= value; 
            if(HtmlJsConfirmEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlJsConfirm, Callable.From(_htmlJsConfirmAction));
            }
        }
    }
    
    /// <summary>
    /// The html link at position event handler
    /// </summary>
    public delegate void HtmlLinkAtPositionEventHandler(long browserHandle, Godot.Collections.Dictionary linkData);
    private static event HtmlLinkAtPositionEventHandler HtmlLinkAtPositionEvent;
    /// <summary>
    /// The link data
    /// </summary>
    static Action<long, Godot.Collections.Dictionary> _htmlLinkAtPositionAction = (browserHandle, linkData) =>
    {
        HtmlLinkAtPositionEvent?.Invoke(browserHandle, linkData);
    };
    /// <summary>
    /// The html link at position
    /// </summary>
    public static event HtmlLinkAtPositionEventHandler HtmlLinkAtPosition
    {
        add
        {
            if(HtmlLinkAtPositionEvent == null)
            {
                GetInstance().Connect(Signals.HtmlLinkAtPosition, Callable.From(_htmlLinkAtPositionAction));
            }
            HtmlLinkAtPositionEvent += value;
        }
        remove
        {
            HtmlLinkAtPositionEvent -= value; 
            if(HtmlLinkAtPositionEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlLinkAtPosition, Callable.From(_htmlLinkAtPositionAction));
            }
        }
    }
    
    /// <summary>
    /// The html needs paint event handler
    /// </summary>
    public delegate void HtmlNeedsPaintEventHandler(long browserHandle, Godot.Collections.Dictionary pageData);
    private static event HtmlNeedsPaintEventHandler HtmlNeedsPaintEvent;
    /// <summary>
    /// The page data
    /// </summary>
    static Action<long, Godot.Collections.Dictionary> _htmlNeedsPaintAction = (browserHandle, pageData) =>
    {
        HtmlNeedsPaintEvent?.Invoke(browserHandle, pageData);
    };
    /// <summary>
    /// The html needs paint
    /// </summary>
    public static event HtmlNeedsPaintEventHandler HtmlNeedsPaint
    {
        add
        {
            if(HtmlNeedsPaintEvent == null)
            {
                GetInstance().Connect(Signals.HtmlNeedsPaint, Callable.From(_htmlNeedsPaintAction));
            }
            HtmlNeedsPaintEvent += value;
        }
        remove
        {
            HtmlNeedsPaintEvent -= value; 
            if(HtmlNeedsPaintEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlNeedsPaint, Callable.From(_htmlNeedsPaintAction));
            }
        }
    }
    
    /// <summary>
    /// The html new window event handler
    /// </summary>
    public delegate void HtmlNewWindowEventHandler(long browserHandle, Godot.Collections.Dictionary windowData);
    private static event HtmlNewWindowEventHandler HtmlNewWindowEvent;
    /// <summary>
    /// The window data
    /// </summary>
    static Action<long, Godot.Collections.Dictionary> _htmlNewWindowAction = (browserHandle, windowData) =>
    {
        HtmlNewWindowEvent?.Invoke(browserHandle, windowData);
    };
    /// <summary>
    /// The html new window
    /// </summary>
    public static event HtmlNewWindowEventHandler HtmlNewWindow
    {
        add
        {
            if(HtmlNewWindowEvent == null)
            {
                GetInstance().Connect(Signals.HtmlNewWindow, Callable.From(_htmlNewWindowAction));
            }
            HtmlNewWindowEvent += value;
        }
        remove
        {
            HtmlNewWindowEvent -= value; 
            if(HtmlNewWindowEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlNewWindow, Callable.From(_htmlNewWindowAction));
            }
        }
    }
    
    /// <summary>
    /// The html open link in new tab event handler
    /// </summary>
    public delegate void HtmlOpenLinkInNewTabEventHandler(long browserHandle, string url);
    private static event HtmlOpenLinkInNewTabEventHandler HtmlOpenLinkInNewTabEvent;
    /// <summary>
    /// The url
    /// </summary>
    static Action<long, string> _htmlOpenLinkInNewTabAction = (browserHandle, url) =>
    {
        HtmlOpenLinkInNewTabEvent?.Invoke(browserHandle, url);
    };
    /// <summary>
    /// The html open link in new tab
    /// </summary>
    public static event HtmlOpenLinkInNewTabEventHandler HtmlOpenLinkInNewTab
    {
        add
        {
            if(HtmlOpenLinkInNewTabEvent == null)
            {
                GetInstance().Connect(Signals.HtmlOpenLinkInNewTab, Callable.From(_htmlOpenLinkInNewTabAction));
            }
            HtmlOpenLinkInNewTabEvent += value;
        }
        remove
        {
            HtmlOpenLinkInNewTabEvent -= value; 
            if(HtmlOpenLinkInNewTabEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlOpenLinkInNewTab, Callable.From(_htmlOpenLinkInNewTabAction));
            }
        }
    }
    
    /// <summary>
    /// The html search results event handler
    /// </summary>
    public delegate void HtmlSearchResultsEventHandler(long browserHandle, long results, long currentMatch);
    private static event HtmlSearchResultsEventHandler HtmlSearchResultsEvent;
    /// <summary>
    /// The current match
    /// </summary>
    static Action<long, long, long> _htmlSearchResultsAction = (browserHandle, results, currentMatch) =>
    {
        HtmlSearchResultsEvent?.Invoke(browserHandle, results, currentMatch);
    };
    /// <summary>
    /// The html search results
    /// </summary>
    public static event HtmlSearchResultsEventHandler HtmlSearchResults
    {
        add
        {
            if(HtmlSearchResultsEvent == null)
            {
                GetInstance().Connect(Signals.HtmlSearchResults, Callable.From(_htmlSearchResultsAction));
            }
            HtmlSearchResultsEvent += value;
        }
        remove
        {
            HtmlSearchResultsEvent -= value; 
            if(HtmlSearchResultsEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlSearchResults, Callable.From(_htmlSearchResultsAction));
            }
        }
    }
    
    /// <summary>
    /// The html set cursor event handler
    /// </summary>
    public delegate void HtmlSetCursorEventHandler(long browserHandle, long mouseCursor);
    private static event HtmlSetCursorEventHandler HtmlSetCursorEvent;
    /// <summary>
    /// The mouse cursor
    /// </summary>
    static Action<long, long> _htmlSetCursorAction = (browserHandle, mouseCursor) =>
    {
        HtmlSetCursorEvent?.Invoke(browserHandle, mouseCursor);
    };
    /// <summary>
    /// The html set cursor
    /// </summary>
    public static event HtmlSetCursorEventHandler HtmlSetCursor
    {
        add
        {
            if(HtmlSetCursorEvent == null)
            {
                GetInstance().Connect(Signals.HtmlSetCursor, Callable.From(_htmlSetCursorAction));
            }
            HtmlSetCursorEvent += value;
        }
        remove
        {
            HtmlSetCursorEvent -= value; 
            if(HtmlSetCursorEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlSetCursor, Callable.From(_htmlSetCursorAction));
            }
        }
    }
    
    /// <summary>
    /// The html show tooltip event handler
    /// </summary>
    public delegate void HtmlShowTooltipEventHandler(long browserHandle, string message);
    private static event HtmlShowTooltipEventHandler HtmlShowTooltipEvent;
    /// <summary>
    /// The message
    /// </summary>
    static Action<long, string> _htmlShowTooltipAction = (browserHandle, message) =>
    {
        HtmlShowTooltipEvent?.Invoke(browserHandle, message);
    };
    /// <summary>
    /// The html show tooltip
    /// </summary>
    public static event HtmlShowTooltipEventHandler HtmlShowTooltip
    {
        add
        {
            if(HtmlShowTooltipEvent == null)
            {
                GetInstance().Connect(Signals.HtmlShowTooltip, Callable.From(_htmlShowTooltipAction));
            }
            HtmlShowTooltipEvent += value;
        }
        remove
        {
            HtmlShowTooltipEvent -= value; 
            if(HtmlShowTooltipEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlShowTooltip, Callable.From(_htmlShowTooltipAction));
            }
        }
    }
    
    /// <summary>
    /// The html start request event handler
    /// </summary>
    public delegate void HtmlStartRequestEventHandler(long browserHandle, string url, string target, string postData, bool redirect);
    private static event HtmlStartRequestEventHandler HtmlStartRequestEvent;
    /// <summary>
    /// The redirect
    /// </summary>
    static Action<long, string, string, string, bool> _htmlStartRequestAction = (browserHandle, url, target, postData, redirect) =>
    {
        HtmlStartRequestEvent?.Invoke(browserHandle, url, target, postData, redirect);
    };
    /// <summary>
    /// The html start request
    /// </summary>
    public static event HtmlStartRequestEventHandler HtmlStartRequest
    {
        add
        {
            if(HtmlStartRequestEvent == null)
            {
                GetInstance().Connect(Signals.HtmlStartRequest, Callable.From(_htmlStartRequestAction));
            }
            HtmlStartRequestEvent += value;
        }
        remove
        {
            HtmlStartRequestEvent -= value; 
            if(HtmlStartRequestEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlStartRequest, Callable.From(_htmlStartRequestAction));
            }
        }
    }
    
    /// <summary>
    /// The html status text event handler
    /// </summary>
    public delegate void HtmlStatusTextEventHandler(long browserHandle, string message);
    private static event HtmlStatusTextEventHandler HtmlStatusTextEvent;
    /// <summary>
    /// The message
    /// </summary>
    static Action<long, string> _htmlStatusTextAction = (browserHandle, message) =>
    {
        HtmlStatusTextEvent?.Invoke(browserHandle, message);
    };
    /// <summary>
    /// The html status text
    /// </summary>
    public static event HtmlStatusTextEventHandler HtmlStatusText
    {
        add
        {
            if(HtmlStatusTextEvent == null)
            {
                GetInstance().Connect(Signals.HtmlStatusText, Callable.From(_htmlStatusTextAction));
            }
            HtmlStatusTextEvent += value;
        }
        remove
        {
            HtmlStatusTextEvent -= value; 
            if(HtmlStatusTextEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlStatusText, Callable.From(_htmlStatusTextAction));
            }
        }
    }
    
    /// <summary>
    /// The html update tooltip event handler
    /// </summary>
    public delegate void HtmlUpdateTooltipEventHandler(long browserHandle, string message);
    private static event HtmlUpdateTooltipEventHandler HtmlUpdateTooltipEvent;
    /// <summary>
    /// The message
    /// </summary>
    static Action<long, string> _htmlUpdateTooltipAction = (browserHandle, message) =>
    {
        HtmlUpdateTooltipEvent?.Invoke(browserHandle, message);
    };
    /// <summary>
    /// The html update tooltip
    /// </summary>
    public static event HtmlUpdateTooltipEventHandler HtmlUpdateTooltip
    {
        add
        {
            if(HtmlUpdateTooltipEvent == null)
            {
                GetInstance().Connect(Signals.HtmlUpdateTooltip, Callable.From(_htmlUpdateTooltipAction));
            }
            HtmlUpdateTooltipEvent += value;
        }
        remove
        {
            HtmlUpdateTooltipEvent -= value; 
            if(HtmlUpdateTooltipEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlUpdateTooltip, Callable.From(_htmlUpdateTooltipAction));
            }
        }
    }
    
    /// <summary>
    /// The html url changed event handler
    /// </summary>
    public delegate void HtmlUrlChangedEventHandler(long browserHandle, Godot.Collections.Dictionary urlData);
    private static event HtmlUrlChangedEventHandler HtmlUrlChangedEvent;
    /// <summary>
    /// The url data
    /// </summary>
    static Action<long, Godot.Collections.Dictionary> _htmlUrlChangedAction = (browserHandle, urlData) =>
    {
        HtmlUrlChangedEvent?.Invoke(browserHandle, urlData);
    };
    /// <summary>
    /// The html url changed
    /// </summary>
    public static event HtmlUrlChangedEventHandler HtmlUrlChanged
    {
        add
        {
            if(HtmlUrlChangedEvent == null)
            {
                GetInstance().Connect(Signals.HtmlUrlChanged, Callable.From(_htmlUrlChangedAction));
            }
            HtmlUrlChangedEvent += value;
        }
        remove
        {
            HtmlUrlChangedEvent -= value; 
            if(HtmlUrlChangedEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlUrlChanged, Callable.From(_htmlUrlChangedAction));
            }
        }
    }
    
    /// <summary>
    /// The html vertical scroll event handler
    /// </summary>
    public delegate void HtmlVerticalScrollEventHandler(long browserHandle, Godot.Collections.Dictionary scrollData);
    private static event HtmlVerticalScrollEventHandler HtmlVerticalScrollEvent;
    /// <summary>
    /// The scroll data
    /// </summary>
    static Action<long, Godot.Collections.Dictionary> _htmlVerticalScrollAction = (browserHandle, scrollData) =>
    {
        HtmlVerticalScrollEvent?.Invoke(browserHandle, scrollData);
    };
    /// <summary>
    /// The html vertical scroll
    /// </summary>
    public static event HtmlVerticalScrollEventHandler HtmlVerticalScroll
    {
        add
        {
            if(HtmlVerticalScrollEvent == null)
            {
                GetInstance().Connect(Signals.HtmlVerticalScroll, Callable.From(_htmlVerticalScrollAction));
            }
            HtmlVerticalScrollEvent += value;
        }
        remove
        {
            HtmlVerticalScrollEvent -= value; 
            if(HtmlVerticalScrollEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlVerticalScroll, Callable.From(_htmlVerticalScrollAction));
            }
        }
    }
}